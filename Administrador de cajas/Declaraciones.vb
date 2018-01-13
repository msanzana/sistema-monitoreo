Imports System.Xml
Imports MySql.Data.MySqlClient

Module Declaraciones
    'VARIABLES
    Public BG_BD As MySqlConnection
    Public DRG_Dr As MySqlDataReader
    Public SG_Nombre_BD As String = ""
    Public SG_Direccion_BD As String = ""
    Public IG_Puerto_BD As Integer = 0
    Public SG_Usuario As String = ""
    Public DoG_Id_Usuario As Double = 0
    Public SG_Empresa As String = ""
    Public SG_Ruta_Configuracion As String = ""
    Public SG_Sistema As String = "ADMINISTRADOR DE SISTEMAS"
    Public SG_Usuario_BD As String = ""
    Public SG_Password_BD As String = ""
    Public SG_Credenciales(,) As String = {{"OTROS", "helpcom_db", "helpcom211"},
                                           {"LILY", "anavarrete", "aldong"}}
    Public Ig_I As Double = 0
    Public Ig_X As Double = 0

    Public Sub Main()
        SG_Ruta_Configuracion = Application.StartupPath & "\configuracion.xml"
        If Leer_Parametros(SG_Ruta_Configuracion) = True Then
            If Credenciales_BD() = True Then
                frmAutorizacion.ShowDialog()
                'Ceteo de variables principales    
            Else
                MsgBox("PROBLEMA DE LECTURA CREDENCIALES BASE DE DATOS, EL PROGRAMA SE CERRARA", MsgBoxStyle.Exclamation, SG_Sistema)
                End
            End If
        Else
            MsgBox("PROBLEMA DE LECTURA ARCHIVO DE CONFIGURACION, EL PROGRAMA SE CERRARA", MsgBoxStyle.Exclamation, SG_Sistema)
            End
        End If
    End Sub

    Public Function Leer_Parametros(Sp_Ruta As String) As Boolean
        Dim Bop_Estado = False
        Dim xmlp_Configuracion As XmlDocument
        Dim xmlp_Lista_Nodo As XmlNodeList
        Dim xmlp_Nodo As XmlNode
        'Creamos el “XML Document”
        Try
            xmlp_Configuracion = New XmlDocument()
            xmlp_Configuracion.Load(Sp_Ruta)
            xmlp_Lista_Nodo = xmlp_Configuracion.SelectNodes("/configuracion/parametros")

            For Each xmlp_Nodo In xmlp_Lista_Nodo
                SG_Direccion_BD = xmlp_Nodo.Item("direccionbd").InnerText  ' Direccion base de datos
                SG_Nombre_BD = xmlp_Nodo.Item("nombrebd").InnerText  ' Nombre base de datos
                IG_Puerto_BD = xmlp_Nodo.Item("puertobd").InnerText  ' Puerto base de datos
                SG_Empresa = xmlp_Nodo.Item("empresa").InnerText ' Nombre empresa
            Next
            Bop_Estado = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, SG_Sistema)
        End Try
        Return Bop_Estado
    End Function

    Public Function Escribir_Parametros(Sp_Ruta As String) As Boolean
        Dim Bop_Estado = False
        Dim xmlp_Configuracion As XmlDocument
        Dim xmlp_Lista_Nodo As XmlNodeList
        Dim xmlp_Nodo As XmlNode
        'guardamos el “XML Document”
        Try
            xmlp_Configuracion = New XmlDocument()
            xmlp_Configuracion.Load(Sp_Ruta)
            xmlp_Lista_Nodo = xmlp_Configuracion.SelectNodes("/configuracion/parametros")

            For Each xmlp_Nodo In xmlp_Lista_Nodo
                xmlp_Nodo.Item("direccionbd").InnerText = SG_Direccion_BD  ' Direccion base de datos
                xmlp_Nodo.Item("nombrebd").InnerText = SG_Nombre_BD  ' Nombre base de datos
                xmlp_Nodo.Item("puertobd").InnerText = IG_Puerto_BD ' Puerto base de datos
                xmlp_Nodo.Item("empresa").InnerText = SG_Empresa  ' Nombre empresa
            Next
            xmlp_Configuracion.Save(Sp_Ruta)
            Bop_Estado = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, SG_Sistema)
        End Try
        Return Bop_Estado
    End Function

    Private Function Credenciales_BD() As Boolean
        Dim Bop_Estado As Boolean = False
        For Ig_I = 0 To 1
            If SG_Credenciales(Ig_I, 0).ToString = UCase(SG_Empresa) Then
                SG_Usuario_BD = SG_Credenciales(Ig_I, 1).ToString
                SG_Password_BD = SG_Credenciales(Ig_I, 2).ToString
                Bop_Estado = True
                Exit For
            End If
        Next Ig_I
        Return Bop_Estado
    End Function

    Public Function Conecta_BD() As Boolean
        Dim Bop_Estado As Boolean
        Try
            BG_BD = New MySqlConnection("Server=" & SG_Direccion_BD & ";Database=" & SG_Nombre_BD & ";Uid=" & SG_Usuario_BD & ";Pwd=" & SG_Password_BD & ";Port=" & IG_Puerto_BD)
            BG_BD.Open()
            Bop_Estado = True
        Catch ex As Exception
            Bop_Estado = False
        End Try
        Return Bop_Estado
    End Function

    Public Sub Consulta_SQL(Sp_Cadena_Sql As String)
        Try
            If Conecta_BD() = True Then
                Dim cmd As New MySqlCommand(Sp_Cadena_Sql, BG_BD)
                DRG_Dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Else
                MsgBox("A OCURRIDO UN ERROR AL CONECTARSE A LA BASE DE DATOS!!!", MsgBoxStyle.Exclamation, SG_Sistema)
            End If
        Catch ex As Exception
            MsgBox("LA TRANSACCION SQL A GENERADO UN ERROR :" & vbCrLf &
                   ex.Message, MsgBoxStyle.Exclamation, SG_Sistema)
        End Try
    End Sub
End Module
