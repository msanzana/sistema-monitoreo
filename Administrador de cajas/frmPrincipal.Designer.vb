<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MnuStPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLocalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarServidoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RutasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrasConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvLocales = New System.Windows.Forms.ListView()
        Me.TbOpciones = New System.Windows.Forms.TabControl()
        Me.tbpCajas = New System.Windows.Forms.TabPage()
        Me.lvCajas = New System.Windows.Forms.ListView()
        Me.clnNumCaja = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnNumImp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TbpServidores = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TssLblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TssLblServidor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MnuStPrincipal.SuspendLayout()
        Me.TbOpciones.SuspendLayout()
        Me.tbpCajas.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuStPrincipal
        '
        Me.MnuStPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ConfiguracionesToolStripMenuItem})
        Me.MnuStPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MnuStPrincipal.Name = "MnuStPrincipal"
        Me.MnuStPrincipal.Size = New System.Drawing.Size(1258, 24)
        Me.MnuStPrincipal.TabIndex = 0
        Me.MnuStPrincipal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarLocalToolStripMenuItem, Me.AdministrarServidoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'AgregarLocalToolStripMenuItem
        '
        Me.AgregarLocalToolStripMenuItem.Name = "AgregarLocalToolStripMenuItem"
        Me.AgregarLocalToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AgregarLocalToolStripMenuItem.Text = "Administrar locales"
        '
        'AdministrarServidoresToolStripMenuItem
        '
        Me.AdministrarServidoresToolStripMenuItem.Name = "AdministrarServidoresToolStripMenuItem"
        Me.AdministrarServidoresToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AdministrarServidoresToolStripMenuItem.Text = "Administrar Servidores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ConfiguracionesToolStripMenuItem
        '
        Me.ConfiguracionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RutasToolStripMenuItem, Me.OtrasConfiguracionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        Me.ConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ConfiguracionesToolStripMenuItem.Text = "Configuraciones"
        '
        'RutasToolStripMenuItem
        '
        Me.RutasToolStripMenuItem.Name = "RutasToolStripMenuItem"
        Me.RutasToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.RutasToolStripMenuItem.Text = "Base de datos"
        '
        'OtrasConfiguracionesToolStripMenuItem
        '
        Me.OtrasConfiguracionesToolStripMenuItem.Name = "OtrasConfiguracionesToolStripMenuItem"
        Me.OtrasConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.OtrasConfiguracionesToolStripMenuItem.Text = "Otras configuraciones"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'lvLocales
        '
        Me.lvLocales.GridLines = True
        Me.lvLocales.Location = New System.Drawing.Point(12, 67)
        Me.lvLocales.Name = "lvLocales"
        Me.lvLocales.Size = New System.Drawing.Size(395, 203)
        Me.lvLocales.TabIndex = 1
        Me.lvLocales.UseCompatibleStateImageBehavior = False
        '
        'TbOpciones
        '
        Me.TbOpciones.Controls.Add(Me.tbpCajas)
        Me.TbOpciones.Controls.Add(Me.TbpServidores)
        Me.TbOpciones.Location = New System.Drawing.Point(12, 285)
        Me.TbOpciones.Name = "TbOpciones"
        Me.TbOpciones.SelectedIndex = 0
        Me.TbOpciones.Size = New System.Drawing.Size(395, 331)
        Me.TbOpciones.TabIndex = 3
        '
        'tbpCajas
        '
        Me.tbpCajas.Controls.Add(Me.lvCajas)
        Me.tbpCajas.Location = New System.Drawing.Point(4, 22)
        Me.tbpCajas.Name = "tbpCajas"
        Me.tbpCajas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCajas.Size = New System.Drawing.Size(387, 305)
        Me.tbpCajas.TabIndex = 0
        Me.tbpCajas.Text = "Cajas"
        Me.tbpCajas.UseVisualStyleBackColor = True
        '
        'lvCajas
        '
        Me.lvCajas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clnNumCaja, Me.clnNumImp, Me.clnIP, Me.clnEstado})
        Me.lvCajas.GridLines = True
        Me.lvCajas.Location = New System.Drawing.Point(6, 56)
        Me.lvCajas.Name = "lvCajas"
        Me.lvCajas.Size = New System.Drawing.Size(368, 243)
        Me.lvCajas.TabIndex = 0
        Me.lvCajas.UseCompatibleStateImageBehavior = False
        Me.lvCajas.View = System.Windows.Forms.View.Details
        '
        'clnNumCaja
        '
        Me.clnNumCaja.Text = "Num. Caja"
        Me.clnNumCaja.Width = 62
        '
        'clnNumImp
        '
        Me.clnNumImp.Text = "Numero Imp."
        Me.clnNumImp.Width = 75
        '
        'clnIP
        '
        Me.clnIP.Text = "IP"
        Me.clnIP.Width = 111
        '
        'clnEstado
        '
        Me.clnEstado.Text = "Estado"
        Me.clnEstado.Width = 87
        '
        'TbpServidores
        '
        Me.TbpServidores.Location = New System.Drawing.Point(4, 22)
        Me.TbpServidores.Name = "TbpServidores"
        Me.TbpServidores.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpServidores.Size = New System.Drawing.Size(387, 305)
        Me.TbpServidores.TabIndex = 1
        Me.TbpServidores.Text = "Servidores"
        Me.TbpServidores.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.TssLblUsuario, Me.ToolStripStatusLabel2, Me.TssLblServidor})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 606)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1258, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario:"
        '
        'TssLblUsuario
        '
        Me.TssLblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TssLblUsuario.Name = "TssLblUsuario"
        Me.TssLblUsuario.Size = New System.Drawing.Size(12, 17)
        Me.TssLblUsuario.Text = "_"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel2.Text = "Servidor:"
        '
        'TssLblServidor
        '
        Me.TssLblServidor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TssLblServidor.Name = "TssLblServidor"
        Me.TssLblServidor.Size = New System.Drawing.Size(12, 17)
        Me.TssLblServidor.Text = "_"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 628)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TbOpciones)
        Me.Controls.Add(Me.lvLocales)
        Me.Controls.Add(Me.MnuStPrincipal)
        Me.MainMenuStrip = Me.MnuStPrincipal
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.MnuStPrincipal.ResumeLayout(False)
        Me.MnuStPrincipal.PerformLayout()
        Me.TbOpciones.ResumeLayout(False)
        Me.tbpCajas.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuStPrincipal As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarLocalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarServidoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguracionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RutasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtrasConfiguracionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lvLocales As ListView
    Friend WithEvents TbOpciones As TabControl
    Friend WithEvents tbpCajas As TabPage
    Friend WithEvents lvCajas As ListView
    Friend WithEvents clnNumCaja As ColumnHeader
    Friend WithEvents clnNumImp As ColumnHeader
    Friend WithEvents clnIP As ColumnHeader
    Friend WithEvents clnEstado As ColumnHeader
    Friend WithEvents TbpServidores As TabPage
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TssLblUsuario As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents TssLblServidor As ToolStripStatusLabel
End Class
