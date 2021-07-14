<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroTAGs
    Inherits FeedAutomacao.frmPadrao

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroTAGs))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.FbPanel1 = New FeedAutomacao.fbPanel()
        Me.btnLimpar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.StatusTAGs = New System.Windows.Forms.GroupBox()
        Me.rbTAGsDisponíveis = New System.Windows.Forms.RadioButton()
        Me.rbTAGsUtilizadas = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCarregar = New System.Windows.Forms.Button()
        Me.pnlRodape = New System.Windows.Forms.Panel()
        Me.txtNumeroTAG = New System.Windows.Forms.TextBox()
        Me.txtLeituraTag = New System.Windows.Forms.TextBox()
        Me.LbDataLeituraTag = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCadTAGs = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnExcluir = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnRelatorio = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PVeiculo2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtGridTag = New System.Windows.Forms.DataGridView()
        Me.pnlTop.SuspendLayout()
        Me.FbPanel1.SuspendLayout()
        Me.StatusTAGs.SuspendLayout()
        Me.pnlRodape.SuspendLayout()
        Me.PVeiculo2.SuspendLayout()
        CType(Me.dtGridTag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Lavender
        Me.pnlTop.Controls.Add(Me.FbPanel1)
        Me.pnlTop.Controls.Add(Me.StatusTAGs)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Controls.Add(Me.btnCarregar)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(864, 98)
        Me.pnlTop.TabIndex = 36
        '
        'FbPanel1
        '
        Me.FbPanel1.Controls.Add(Me.btnLimpar)
        Me.FbPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FbPanel1.Location = New System.Drawing.Point(730, 23)
        Me.FbPanel1.Name = "FbPanel1"
        Me.FbPanel1.Size = New System.Drawing.Size(134, 52)
        Me.FbPanel1.TabIndex = 42
        '
        'btnLimpar
        '
        Me.btnLimpar.ActiveBorderThickness = 1
        Me.btnLimpar.ActiveCornerRadius = 30
        Me.btnLimpar.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnLimpar.ActiveForecolor = System.Drawing.Color.White
        Me.btnLimpar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnLimpar.BackColor = System.Drawing.Color.Lavender
        Me.btnLimpar.BackgroundImage = CType(resources.GetObject("btnLimpar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpar.ButtonText = "Fechar"
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnLimpar.IdleBorderThickness = 1
        Me.btnLimpar.IdleCornerRadius = 20
        Me.btnLimpar.IdleFillColor = System.Drawing.Color.Red
        Me.btnLimpar.IdleForecolor = System.Drawing.Color.Gainsboro
        Me.btnLimpar.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnLimpar.Location = New System.Drawing.Point(33, 5)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(71, 40)
        Me.btnLimpar.TabIndex = 24
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusTAGs
        '
        Me.StatusTAGs.BackColor = System.Drawing.Color.Lavender
        Me.StatusTAGs.Controls.Add(Me.rbTAGsDisponíveis)
        Me.StatusTAGs.Controls.Add(Me.rbTAGsUtilizadas)
        Me.StatusTAGs.Controls.Add(Me.rbTodos)
        Me.StatusTAGs.Location = New System.Drawing.Point(14, 29)
        Me.StatusTAGs.Name = "StatusTAGs"
        Me.StatusTAGs.Size = New System.Drawing.Size(350, 38)
        Me.StatusTAGs.TabIndex = 35
        Me.StatusTAGs.TabStop = False
        Me.StatusTAGs.Text = "Status"
        '
        'rbTAGsDisponíveis
        '
        Me.rbTAGsDisponíveis.AutoSize = True
        Me.rbTAGsDisponíveis.Location = New System.Drawing.Point(224, 15)
        Me.rbTAGsDisponíveis.Name = "rbTAGsDisponíveis"
        Me.rbTAGsDisponíveis.Size = New System.Drawing.Size(111, 17)
        Me.rbTAGsDisponíveis.TabIndex = 2
        Me.rbTAGsDisponíveis.TabStop = True
        Me.rbTAGsDisponíveis.Text = "TAGs Disponíveis"
        Me.rbTAGsDisponíveis.UseVisualStyleBackColor = True
        '
        'rbTAGsUtilizadas
        '
        Me.rbTAGsUtilizadas.AutoSize = True
        Me.rbTAGsUtilizadas.Location = New System.Drawing.Point(104, 15)
        Me.rbTAGsUtilizadas.Name = "rbTAGsUtilizadas"
        Me.rbTAGsUtilizadas.Size = New System.Drawing.Size(100, 17)
        Me.rbTAGsUtilizadas.TabIndex = 1
        Me.rbTAGsUtilizadas.TabStop = True
        Me.rbTAGsUtilizadas.Text = "TAGs Utilizadas"
        Me.rbTAGsUtilizadas.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(7, 15)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 0
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(864, 23)
        Me.Label1.TabIndex = 34
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCarregar
        '
        Me.btnCarregar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCarregar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarregar.ForeColor = System.Drawing.Color.White
        Me.btnCarregar.Location = New System.Drawing.Point(0, 75)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(864, 23)
        Me.btnCarregar.TabIndex = 33
        Me.btnCarregar.Text = "Carregar"
        Me.btnCarregar.UseVisualStyleBackColor = False
        '
        'pnlRodape
        '
        Me.pnlRodape.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlRodape.Controls.Add(Me.txtNumeroTAG)
        Me.pnlRodape.Controls.Add(Me.txtLeituraTag)
        Me.pnlRodape.Controls.Add(Me.LbDataLeituraTag)
        Me.pnlRodape.Controls.Add(Me.Label2)
        Me.pnlRodape.Controls.Add(Me.btnCadTAGs)
        Me.pnlRodape.Controls.Add(Me.btnExcluir)
        Me.pnlRodape.Controls.Add(Me.btnRelatorio)
        Me.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRodape.Location = New System.Drawing.Point(0, 424)
        Me.pnlRodape.Name = "pnlRodape"
        Me.pnlRodape.Size = New System.Drawing.Size(864, 131)
        Me.pnlRodape.TabIndex = 38
        '
        'txtNumeroTAG
        '
        Me.txtNumeroTAG.Location = New System.Drawing.Point(118, 15)
        Me.txtNumeroTAG.Name = "txtNumeroTAG"
        Me.txtNumeroTAG.Size = New System.Drawing.Size(72, 20)
        Me.txtNumeroTAG.TabIndex = 55
        '
        'txtLeituraTag
        '
        Me.txtLeituraTag.Location = New System.Drawing.Point(33, 15)
        Me.txtLeituraTag.Name = "txtLeituraTag"
        Me.txtLeituraTag.Size = New System.Drawing.Size(72, 20)
        Me.txtLeituraTag.TabIndex = 54
        '
        'LbDataLeituraTag
        '
        Me.LbDataLeituraTag.AutoSize = True
        Me.LbDataLeituraTag.Location = New System.Drawing.Point(28, 70)
        Me.LbDataLeituraTag.Name = "LbDataLeituraTag"
        Me.LbDataLeituraTag.Size = New System.Drawing.Size(0, 13)
        Me.LbDataLeituraTag.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(864, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCadTAGs
        '
        Me.btnCadTAGs.ActiveBorderThickness = 1
        Me.btnCadTAGs.ActiveCornerRadius = 20
        Me.btnCadTAGs.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCadTAGs.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCadTAGs.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCadTAGs.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCadTAGs.BackgroundImage = CType(resources.GetObject("btnCadTAGs.BackgroundImage"), System.Drawing.Image)
        Me.btnCadTAGs.ButtonText = "Cadastrar TAG"
        Me.btnCadTAGs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadTAGs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadTAGs.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnCadTAGs.IdleBorderThickness = 1
        Me.btnCadTAGs.IdleCornerRadius = 30
        Me.btnCadTAGs.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCadTAGs.IdleForecolor = System.Drawing.Color.Gainsboro
        Me.btnCadTAGs.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnCadTAGs.Location = New System.Drawing.Point(14, 31)
        Me.btnCadTAGs.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCadTAGs.Name = "btnCadTAGs"
        Me.btnCadTAGs.Size = New System.Drawing.Size(208, 40)
        Me.btnCadTAGs.TabIndex = 22
        Me.btnCadTAGs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExcluir
        '
        Me.btnExcluir.ActiveBorderThickness = 1
        Me.btnExcluir.ActiveCornerRadius = 30
        Me.btnExcluir.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnExcluir.ActiveForecolor = System.Drawing.Color.White
        Me.btnExcluir.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnExcluir.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExcluir.BackgroundImage = CType(resources.GetObject("btnExcluir.BackgroundImage"), System.Drawing.Image)
        Me.btnExcluir.ButtonText = "Excluir"
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnExcluir.IdleBorderThickness = 1
        Me.btnExcluir.IdleCornerRadius = 20
        Me.btnExcluir.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnExcluir.IdleForecolor = System.Drawing.Color.Gainsboro
        Me.btnExcluir.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnExcluir.Location = New System.Drawing.Point(365, 31)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(90, 40)
        Me.btnExcluir.TabIndex = 22
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRelatorio
        '
        Me.btnRelatorio.ActiveBorderThickness = 1
        Me.btnRelatorio.ActiveCornerRadius = 30
        Me.btnRelatorio.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnRelatorio.ActiveForecolor = System.Drawing.Color.White
        Me.btnRelatorio.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnRelatorio.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnRelatorio.BackgroundImage = CType(resources.GetObject("btnRelatorio.BackgroundImage"), System.Drawing.Image)
        Me.btnRelatorio.ButtonText = "Relatório"
        Me.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelatorio.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnRelatorio.IdleBorderThickness = 1
        Me.btnRelatorio.IdleCornerRadius = 20
        Me.btnRelatorio.IdleFillColor = System.Drawing.Color.DarkCyan
        Me.btnRelatorio.IdleForecolor = System.Drawing.Color.Gainsboro
        Me.btnRelatorio.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnRelatorio.Location = New System.Drawing.Point(252, 31)
        Me.btnRelatorio.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(90, 40)
        Me.btnRelatorio.TabIndex = 19
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PVeiculo2
        '
        Me.PVeiculo2.BackColor = System.Drawing.Color.Navy
        Me.PVeiculo2.Controls.Add(Me.Label3)
        Me.PVeiculo2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PVeiculo2.Location = New System.Drawing.Point(0, 416)
        Me.PVeiculo2.Name = "PVeiculo2"
        Me.PVeiculo2.Size = New System.Drawing.Size(864, 8)
        Me.PVeiculo2.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(864, 0)
        Me.Label3.TabIndex = 32
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtGridTag
        '
        Me.dtGridTag.AllowUserToOrderColumns = True
        Me.dtGridTag.BackgroundColor = System.Drawing.Color.Lavender
        Me.dtGridTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridTag.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridTag.GridColor = System.Drawing.SystemColors.Control
        Me.dtGridTag.Location = New System.Drawing.Point(0, 98)
        Me.dtGridTag.Name = "dtGridTag"
        Me.dtGridTag.Size = New System.Drawing.Size(864, 318)
        Me.dtGridTag.TabIndex = 41
        '
        'frmCadastroTAGs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(864, 555)
        Me.Controls.Add(Me.dtGridTag)
        Me.Controls.Add(Me.PVeiculo2)
        Me.Controls.Add(Me.pnlRodape)
        Me.Controls.Add(Me.pnlTop)
        Me.Name = "frmCadastroTAGs"
        Me.Text = "Cadastro de TAGs"
        Me.pnlTop.ResumeLayout(False)
        Me.FbPanel1.ResumeLayout(False)
        Me.StatusTAGs.ResumeLayout(False)
        Me.StatusTAGs.PerformLayout()
        Me.pnlRodape.ResumeLayout(False)
        Me.pnlRodape.PerformLayout()
        Me.PVeiculo2.ResumeLayout(False)
        CType(Me.dtGridTag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents StatusTAGs As GroupBox
    Friend WithEvents rbTAGsDisponíveis As RadioButton
    Friend WithEvents rbTAGsUtilizadas As RadioButton
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCarregar As Button
    Friend WithEvents btnLimpar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pnlRodape As Panel
    Friend WithEvents txtLeituraTag As TextBox
    Friend WithEvents LbDataLeituraTag As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCadTAGs As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnExcluir As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnRelatorio As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PVeiculo2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents dtGridTag As DataGridView
    Friend WithEvents FbPanel1 As fbPanel
    Friend WithEvents txtNumeroTAG As TextBox
End Class
