<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPadraoCadastro
    Inherits frmPadrao

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.menuFiltro = New fbMenu()
        Me.pesDados = New fbLookUp()
        Me.pnlBarra = New fbPanel()
        Me.FbBarra1 = New fbBarra()
        Me.pnlCampos = New fbPanel()
        Me.menuFiltro.SuspendLayout()
        Me.pnlBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuFiltro
        '
        Me.menuFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.menuFiltro.Controls.Add(Me.pesDados)
        Me.menuFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Hint = ""
        Me.menuFiltro.Icone = Nothing
        Me.menuFiltro.Location = New System.Drawing.Point(0, 0)
        Me.menuFiltro.Name = "menuFiltro"
        Me.menuFiltro.Size = New System.Drawing.Size(558, 59)
        Me.menuFiltro.TabIndex = 1
        Me.menuFiltro.Texto = "Pesquisar"
        '
        'pesDados
        '
        Me.pesDados.DataTableSelect = Nothing
        Me.pesDados.FormularioPesquisa = Nothing
        Me.pesDados.Location = New System.Drawing.Point(17, 29)
        Me.pesDados.Name = "pesDados"
        Me.pesDados.Requerido = False
        Me.pesDados.SelectID = -1
        Me.pesDados.Size = New System.Drawing.Size(529, 20)
        Me.pesDados.TabIndex = 4
        '
        'pnlBarra
        '
        Me.pnlBarra.Controls.Add(Me.FbBarra1)
        Me.pnlBarra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBarra.Location = New System.Drawing.Point(0, 363)
        Me.pnlBarra.Name = "pnlBarra"
        Me.pnlBarra.Size = New System.Drawing.Size(558, 53)
        Me.pnlBarra.TabIndex = 1
        '
        'FbBarra1
        '
        Me.FbBarra1.CampoFoco = Nothing
        Me.FbBarra1.frmCadastro = Nothing
        Me.FbBarra1.Location = New System.Drawing.Point(12, 6)
        Me.FbBarra1.Name = "FbBarra1"
        Me.FbBarra1.PanelCadastro = Me.pnlCampos
        Me.FbBarra1.Size = New System.Drawing.Size(540, 44)
        Me.FbBarra1.TabIndex = 0
        '
        'pnlCampos
        '
        Me.pnlCampos.AutoScroll = True
        Me.pnlCampos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCampos.Location = New System.Drawing.Point(0, 59)
        Me.pnlCampos.Name = "pnlCampos"
        Me.pnlCampos.Size = New System.Drawing.Size(558, 304)
        Me.pnlCampos.TabIndex = 2
        '
        'frmPadraoCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(558, 416)
        Me.Controls.Add(Me.pnlCampos)
        Me.Controls.Add(Me.menuFiltro)
        Me.Controls.Add(Me.pnlBarra)
        Me.KeyPreview = True
        Me.Name = "frmPadraoCadastro"
        Me.menuFiltro.ResumeLayout(False)
        Me.pnlBarra.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents menuFiltro As fbMenu
    Protected WithEvents pesDados As fbLookUp
    Protected Friend WithEvents pnlCampos As fbPanel
    Protected Friend WithEvents FbBarra1 As fbBarra
    Public WithEvents pnlBarra As fbPanel

End Class
