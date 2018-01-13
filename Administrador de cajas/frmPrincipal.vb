Imports System.Xml
Imports MySql.Data.MySqlClient
Public Class FrmPrincipal
    Private Sub RutasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RutasToolStripMenuItem.Click
        FrmConfiguracionConexion.ShowDialog()
    End Sub

    Private Sub TbpCajas_Click(sender As Object, e As EventArgs) Handles tbpCajas.Click

    End Sub

    Private Sub TbpServidores_Click(sender As Object, e As EventArgs) Handles TbpServidores.Click

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class
