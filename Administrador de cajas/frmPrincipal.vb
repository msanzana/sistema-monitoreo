Imports System.Xml
Imports MySql.Data.MySqlClient
Public Class FrmPrincipal
    Public DP_Cantidad As Double = 0
    Public DP_Codigo As Double = 0
    Public IP_Indice_PLU As Integer = 0
    Private Sub RutasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RutasToolStripMenuItem.Click
        FrmConfiguracionConexion.ShowDialog()
    End Sub
    Public Sub Totalizar()
        lblTotal.Text = "0"
        If lvProductos.Items.Count > 0 Then
            For Ig_I = 0 To lvProductos.Items.Count - 1
                lblTotal.Text = Format(CDbl(lblTotal.Text) + CDbl(lvProductos.Items(CInt(Ig_I)).SubItems(5).Text), "##,#0")
            Next Ig_I
        End If
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main()
        TssLblUsuario.Text = SG_Usuario
        TssLblServidor.Text = SG_Direccion_BD
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub txtCodigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoProducto.KeyPress
        Dim Dp_Codigo_Producto As Double = 0
        If e.KeyChar = Chr(13) Then
            '//////////////////////// Algoritmo para agregar codigo producto ///////////////////////
            If txtCodigoProducto.Text = "" Then
                MsgBox("DEBE INGRESAR UN CODIGO DE PRODUCTO PARA CONTINUAR")
                Exit Sub
            End If
            ''''''''Algoritmo para extraer codigo producto''''''''
            Dp_Codigo_Producto = Extraer_Codigo_Producto(txtCodigoProducto.Text)
            Consulta_SQL("SELECT * FROM mae_productos WHERE pro_plu=" & Dp_Codigo_Producto & " or pro_codigo_barra=" & Dp_Codigo_Producto)
            If DRG_Dr.Read Then

                If Buscar_PLU(CStr(Dp_Codigo_Producto)) = True Then
                    lvProductos.Items(IP_Indice_PLU).SubItems(4).Text += DP_Cantidad
                    lvProductos.Items(IP_Indice_PLU).SubItems(5).Text = Format(CDbl(lvProductos.Items(IP_Indice_PLU).SubItems(3).Text) * CDbl(lvProductos.Items(IP_Indice_PLU).SubItems(4).Text), "##,#0")
                    txtCodigoProducto.Text = ""
                    Totalizar()
                Else
                    Dim Itmx = New ListViewItem
                    Itmx.Text = DRG_Dr.GetValue(0)
                    Itmx.SubItems.Add(DRG_Dr.GetValue(1))
                    Itmx.SubItems.Add(DRG_Dr.GetValue(2))
                    Itmx.SubItems.Add(Format(DRG_Dr.GetValue(3), "##,#0"))
                    Itmx.SubItems.Add(DP_Cantidad)
                    Itmx.SubItems.Add(Format(CDbl(DRG_Dr.GetValue(3)) * DP_Cantidad, "##,#0"))
                    lvProductos.Items.Add(Itmx)
                    txtCodigoProducto.Text = ""
                    Totalizar()
                End If
            Else
                MsgBox("NO SE A ENCONTRADO EL PRODUCTO EN LA LISTA")
                txtCodigoProducto.Text = ""
                Exit Sub
            End If
            DRG_Dr.Close()
            '///////////////////////////////////////////////////////////////////////////////////////
        End If
    End Sub
    Public Function Buscar_PLU(Sp_Cadena_Busqueda As String) As Boolean
        Dim Bop_Encontrado As Boolean = False
        If lvProductos.Items.Count > 0 Then
            For Ig_I = 0 To lvProductos.Items.Count - 1
                If Sp_Cadena_Busqueda = lvProductos.Items(CInt(Ig_I)).Text Or Sp_Cadena_Busqueda = lvProductos.Items(CInt(Ig_I)).SubItems(1).Text Then
                    IP_Indice_PLU = CInt(Ig_I)
                    lvProductos.Items(CInt(Ig_I)).Selected = True
                    Bop_Encontrado = True
                    Return Bop_Encontrado
                    Exit Function
                End If
            Next Ig_I
        End If
        Return Bop_Encontrado
    End Function
    Public Function Extraer_Codigo_Producto(Dp_Cadena_Lectura As String) As Double
        Dim Sp_Multiplicador As String = ""
        Dim Sp_Codigo As String = ""
        Dim Bop_Detectar_Cantidad As Boolean = True
        Dim Bop_Detectar_Codigo As Boolean = False
        For Ig_I = 1 To Len(Dp_Cadena_Lectura)
            If UCase(Mid(Dp_Cadena_Lectura, Ig_I, 1)) = "X" Then
                Bop_Detectar_Cantidad = False
                Bop_Detectar_Codigo = True
                Ig_I += 1
            End If
            If Bop_Detectar_Cantidad = True And UCase(Dp_Cadena_Lectura).Contains("X") = True Then Sp_Multiplicador &= Mid(Dp_Cadena_Lectura, Ig_I, 1)
            If Bop_Detectar_Codigo = True Then Sp_Codigo &= Mid(Dp_Cadena_Lectura, Ig_I, 1)
        Next
        'Cantidad producto
        If Sp_Multiplicador = "" Then
            DP_Cantidad = 1
        Else
            DP_Cantidad = Sp_Multiplicador
        End If
        'Codigo producto
        If Sp_Codigo = "" Then
            DP_Codigo = Dp_Cadena_Lectura
        Else
            DP_Codigo = Sp_Codigo
        End If

        Return DP_Codigo

    End Function

    Private Sub txtCodigoProducto_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoProducto.TextChanged

    End Sub
End Class
