<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracionConexion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDireccionBD = New System.Windows.Forms.TextBox()
        Me.txtNombreBD = New System.Windows.Forms.TextBox()
        Me.txtPuertoBD = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDireccionBD
        '
        Me.txtDireccionBD.Location = New System.Drawing.Point(104, 34)
        Me.txtDireccionBD.Name = "txtDireccionBD"
        Me.txtDireccionBD.Size = New System.Drawing.Size(234, 20)
        Me.txtDireccionBD.TabIndex = 0
        Me.txtDireccionBD.Tag = "Direccion BD"
        '
        'txtNombreBD
        '
        Me.txtNombreBD.Location = New System.Drawing.Point(104, 70)
        Me.txtNombreBD.Name = "txtNombreBD"
        Me.txtNombreBD.Size = New System.Drawing.Size(234, 20)
        Me.txtNombreBD.TabIndex = 1
        Me.txtNombreBD.Tag = "Nombre BD"
        '
        'txtPuertoBD
        '
        Me.txtPuertoBD.Location = New System.Drawing.Point(104, 107)
        Me.txtPuertoBD.Name = "txtPuertoBD"
        Me.txtPuertoBD.Size = New System.Drawing.Size(74, 20)
        Me.txtPuertoBD.TabIndex = 2
        Me.txtPuertoBD.Tag = "Puerto BD"
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(104, 142)
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(134, 20)
        Me.txtNombreEmpresa.TabIndex = 3
        Me.txtNombreEmpresa.Tag = "Nombre Empresa"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(126, 187)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(101, 23)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(236, 187)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(101, 23)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "Salir"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Direccion BD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre BD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Puerto BD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre Empresa"
        '
        'FrmConfiguracionConexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 227)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtNombreEmpresa)
        Me.Controls.Add(Me.txtPuertoBD)
        Me.Controls.Add(Me.txtNombreBD)
        Me.Controls.Add(Me.txtDireccionBD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmConfiguracionConexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion Conexión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDireccionBD As TextBox
    Friend WithEvents txtNombreBD As TextBox
    Friend WithEvents txtPuertoBD As TextBox
    Friend WithEvents txtNombreEmpresa As TextBox
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
