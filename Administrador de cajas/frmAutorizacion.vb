Public Class frmAutorizacion
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        End
    End Sub

    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Consulta_SQL("select * from mae_usuarios")
        If DRG_Dr.Read Then
            If DRG_Dr.GetValue(5) = "NO" Then
                MsgBox("EL USUARIO " & txtUsuario.Text & " ESTA DESACTIVADO", MsgBoxStyle.Exclamation, SG_Sistema)
                Exit Sub
            End If
        End If
        DRG_Dr.Close()
        Me.Close()
    End Sub
End Class