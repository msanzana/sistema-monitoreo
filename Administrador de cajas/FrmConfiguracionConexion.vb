Public Class FrmConfiguracionConexion
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmConfiguracionConexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar_datos()
    End Sub
    Private Sub Llenar_datos()
        txtDireccionBD.Text = SG_Direccion_BD
        txtNombreBD.Text = SG_Nombre_BD
        txtPuertoBD.Text = IG_Puerto_BD
        txtNombreEmpresa.Text = SG_Empresa
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim Sp_Mensaje As String = ""
        For Each txtTexto As TextBox In Me.Controls.OfType(Of TextBox)
            If txtTexto.Text = "" Then Sp_Mensaje &= txtTexto.Tag & ","
        Next
        If Sp_Mensaje <> "" Then
            MsgBox("LOS CAMPOS '" & Mid(Sp_Mensaje, 1, Len(Sp_Mensaje) - 1) & "' NO PUEDEN ESTAR VACIOS!!", MsgBoxStyle.Exclamation, SG_Sistema)
            Exit Sub
        End If
        '////////// Codigo para guardar parametros //////////
        SG_Direccion_BD = txtDireccionBD.Text
        SG_Nombre_BD = txtNombreBD.Text
        IG_Puerto_BD = txtPuertoBD.Text
        SG_Empresa = txtNombreEmpresa.Text

        If Escribir_Parametros(SG_Ruta_Configuracion) = False Then
            MsgBox("SE A PRODUCIDO UN ERROR AL GUARDAR LA CONFIGURACION", MsgBoxStyle.Exclamation, SG_Sistema)
            Exit Sub
        End If
        MsgBox("EL PROGRAMA SE CERRARA, PARA QUE SISTEMA TOME LOS CAMBIOS DEBE EJECUTARLA NUEVAMENTE", MsgBoxStyle.Information, SG_Sistema)
        End
    End Sub
End Class