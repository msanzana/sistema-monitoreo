Public Class frmAutorizacion
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        End
    End Sub

    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Consulta_SQL("SELECT * FROM mae_usuarios WHERE usu_usuario='" & txtUsuario.Text & "' AND usu_contrasena='" & txtContrasena.Text & "'")
        If DRG_Dr.Read Then
            If DRG_Dr.GetValue(5) = "NO" Then
                MsgBox("EL USUARIO " & txtUsuario.Text & " ESTA DESACTIVADO", MsgBoxStyle.Exclamation, SG_Sistema)
                txtUsuario.Focus()
                DRG_Dr.Close() : Exit Sub
            End If
            '//Variables de usuario
            SG_Usuario = DRG_Dr.GetValue(1)
            DoG_Id_Usuario = DRG_Dr.GetValue(0)
        Else
            MsgBox("USUARIO O CONTRASEÑA INVALIDOS", MsgBoxStyle.Exclamation, SG_Sistema)
            txtUsuario.Focus()
            DRG_Dr.Close() : Exit Sub
        End If
        DRG_Dr.Close()
        Me.Close()
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtUsuario.Text <> "" Then txtContrasena.Focus()
        End If
    End Sub

    Private Sub txtContrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContrasena.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdIngresar.PerformClick()
        End If
    End Sub
End Class