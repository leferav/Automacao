<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutomacao
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutomacao))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLeitorSaida = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLeitorEntrada = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCancela = New System.Windows.Forms.TextBox()
        Me.dtfim = New System.Windows.Forms.DateTimePicker()
        Me.dtini = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNumeroTAG = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.FbPanel1 = New FeedAutomacao.fbPanel()
        Me.btLimpar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ckbCancela1 = New System.Windows.Forms.CheckBox()
        Me.btnLimpar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCarregar = New System.Windows.Forms.Button()
        Me.PVeiculo2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtGridTag = New System.Windows.Forms.DataGridView()
        Me.pnlRodape = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtGridStatusCancela = New System.Windows.Forms.DataGridView()
        Me.PictureBoxCancela1 = New System.Windows.Forms.PictureBox()
        Me.LbControle = New System.Windows.Forms.Label()
        Me.btnExcluir = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnRelatorio = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnAbrir = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnFechar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtGridAutomacao = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FbGroupBox1 = New FeedAutomacao.fbGroupBox()
        Me.DtsFuncao1 = New FeedAutomacao.dtsFuncao()
        Me.rbPortaria = New FeedAutomacao.fbRadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rbAcesso = New FeedAutomacao.fbRadioButton()
        Me.pnlTop.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FbPanel1.SuspendLayout()
        Me.PVeiculo2.SuspendLayout()
        CType(Me.dtGridTag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRodape.SuspendLayout()
        CType(Me.dtGridStatusCancela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCancela1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dtGridAutomacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FbGroupBox1.SuspendLayout()
        CType(Me.DtsFuncao1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Lavender
        Me.pnlTop.Controls.Add(Me.Label12)
        Me.pnlTop.Controls.Add(Me.FbGroupBox1)
        Me.pnlTop.Controls.Add(Me.Panel2)
        Me.pnlTop.Controls.Add(Me.FbPanel1)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Controls.Add(Me.btnCarregar)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1029, 155)
        Me.pnlTop.TabIndex = 36
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtLeitorSaida)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtLeitorEntrada)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtCancela)
        Me.Panel2.Controls.Add(Me.dtfim)
        Me.Panel2.Controls.Add(Me.dtini)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TxtNumeroTAG)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtNome)
        Me.Panel2.Location = New System.Drawing.Point(154, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(719, 95)
        Me.Panel2.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(474, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Saída:"
        '
        'txtLeitorSaida
        '
        Me.txtLeitorSaida.Location = New System.Drawing.Point(525, 63)
        Me.txtLeitorSaida.Name = "txtLeitorSaida"
        Me.txtLeitorSaida.Size = New System.Drawing.Size(180, 20)
        Me.txtLeitorSaida.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(462, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Entrada:"
        '
        'txtLeitorEntrada
        '
        Me.txtLeitorEntrada.Location = New System.Drawing.Point(525, 37)
        Me.txtLeitorEntrada.Name = "txtLeitorEntrada"
        Me.txtLeitorEntrada.Size = New System.Drawing.Size(180, 20)
        Me.txtLeitorEntrada.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(462, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cancela:"
        '
        'txtCancela
        '
        Me.txtCancela.Location = New System.Drawing.Point(525, 12)
        Me.txtCancela.Name = "txtCancela"
        Me.txtCancela.Size = New System.Drawing.Size(180, 20)
        Me.txtCancela.TabIndex = 11
        '
        'dtfim
        '
        Me.dtfim.CustomFormat = "dd/MM/yyyy"
        Me.dtfim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfim.Location = New System.Drawing.Point(175, 37)
        Me.dtfim.Name = "dtfim"
        Me.dtfim.Size = New System.Drawing.Size(96, 20)
        Me.dtfim.TabIndex = 10
        '
        'dtini
        '
        Me.dtini.CustomFormat = "dd/MM/yyyy"
        Me.dtini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtini.Location = New System.Drawing.Point(52, 37)
        Me.dtini.Name = "dtini"
        Me.dtini.Size = New System.Drawing.Size(96, 20)
        Me.dtini.TabIndex = 9
        Me.dtini.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(1, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "n°TAG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(148, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Até"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(18, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "De:"
        '
        'TxtNumeroTAG
        '
        Me.TxtNumeroTAG.Location = New System.Drawing.Point(52, 64)
        Me.TxtNumeroTAG.Name = "TxtNumeroTAG"
        Me.TxtNumeroTAG.Size = New System.Drawing.Size(73, 20)
        Me.TxtNumeroTAG.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(4, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(52, 10)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(384, 20)
        Me.txtNome.TabIndex = 0
        '
        'FbPanel1
        '
        Me.FbPanel1.Controls.Add(Me.btLimpar)
        Me.FbPanel1.Controls.Add(Me.ckbCancela1)
        Me.FbPanel1.Controls.Add(Me.btnLimpar)
        Me.FbPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FbPanel1.Location = New System.Drawing.Point(876, 23)
        Me.FbPanel1.Name = "FbPanel1"
        Me.FbPanel1.Size = New System.Drawing.Size(153, 109)
        Me.FbPanel1.TabIndex = 42
        '
        'btLimpar
        '
        Me.btLimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btLimpar.ActiveBorderThickness = 1
        Me.btLimpar.ActiveCornerRadius = 30
        Me.btLimpar.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btLimpar.ActiveForecolor = System.Drawing.Color.White
        Me.btLimpar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btLimpar.BackColor = System.Drawing.Color.Lavender
        Me.btLimpar.BackgroundImage = CType(resources.GetObject("btLimpar.BackgroundImage"), System.Drawing.Image)
        Me.btLimpar.ButtonText = "Limpar"
        Me.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btLimpar.IdleBorderThickness = 1
        Me.btLimpar.IdleCornerRadius = 20
        Me.btLimpar.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.btLimpar.IdleForecolor = System.Drawing.Color.Gainsboro
        Me.btLimpar.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btLimpar.Location = New System.Drawing.Point(17, 40)
        Me.btLimpar.Margin = New System.Windows.Forms.Padding(5)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(119, 40)
        Me.btLimpar.TabIndex = 78
        Me.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ckbCancela1
        '
        Me.ckbCancela1.AutoSize = True
        Me.ckbCancela1.ForeColor = System.Drawing.Color.Black
        Me.ckbCancela1.Location = New System.Drawing.Point(17, 84)
        Me.ckbCancela1.Name = "ckbCancela1"
        Me.ckbCancela1.Size = New System.Drawing.Size(119, 17)
        Me.ckbCancela1.TabIndex = 77
        Me.ckbCancela1.Text = "Atualiza Automático"
        Me.ckbCancela1.UseVisualStyleBackColor = True
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
        Me.btnLimpar.Location = New System.Drawing.Point(17, 6)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(119, 40)
        Me.btnLimpar.TabIndex = 76
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1029, 23)
        Me.Label1.TabIndex = 34
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCarregar
        '
        Me.btnCarregar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCarregar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarregar.ForeColor = System.Drawing.Color.White
        Me.btnCarregar.Location = New System.Drawing.Point(0, 132)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(1029, 23)
        Me.btnCarregar.TabIndex = 33
        Me.btnCarregar.Text = "Carregar"
        Me.btnCarregar.UseVisualStyleBackColor = False
        '
        'PVeiculo2
        '
        Me.PVeiculo2.BackColor = System.Drawing.Color.Navy
        Me.PVeiculo2.Controls.Add(Me.Label3)
        Me.PVeiculo2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PVeiculo2.Location = New System.Drawing.Point(0, 547)
        Me.PVeiculo2.Name = "PVeiculo2"
        Me.PVeiculo2.Size = New System.Drawing.Size(1029, 8)
        Me.PVeiculo2.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1029, 0)
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
        Me.dtGridTag.Location = New System.Drawing.Point(0, 155)
        Me.dtGridTag.Name = "dtGridTag"
        Me.dtGridTag.Size = New System.Drawing.Size(1029, 392)
        Me.dtGridTag.TabIndex = 41
        '
        'pnlRodape
        '
        Me.pnlRodape.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlRodape.Controls.Add(Me.Label2)
        Me.pnlRodape.Controls.Add(Me.dtGridStatusCancela)
        Me.pnlRodape.Controls.Add(Me.PictureBoxCancela1)
        Me.pnlRodape.Controls.Add(Me.LbControle)
        Me.pnlRodape.Controls.Add(Me.btnExcluir)
        Me.pnlRodape.Controls.Add(Me.btnRelatorio)
        Me.pnlRodape.Controls.Add(Me.btnAbrir)
        Me.pnlRodape.Controls.Add(Me.btnFechar)
        Me.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRodape.Location = New System.Drawing.Point(0, 417)
        Me.pnlRodape.Name = "pnlRodape"
        Me.pnlRodape.Size = New System.Drawing.Size(1029, 130)
        Me.pnlRodape.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(403, -8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 129)
        Me.Label2.TabIndex = 74
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtGridStatusCancela
        '
        Me.dtGridStatusCancela.AllowUserToAddRows = False
        Me.dtGridStatusCancela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridStatusCancela.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtGridStatusCancela.Location = New System.Drawing.Point(0, 0)
        Me.dtGridStatusCancela.Name = "dtGridStatusCancela"
        Me.dtGridStatusCancela.Size = New System.Drawing.Size(408, 114)
        Me.dtGridStatusCancela.TabIndex = 75
        '
        'PictureBoxCancela1
        '
        Me.PictureBoxCancela1.Location = New System.Drawing.Point(542, 19)
        Me.PictureBoxCancela1.Name = "PictureBoxCancela1"
        Me.PictureBoxCancela1.Size = New System.Drawing.Size(60, 22)
        Me.PictureBoxCancela1.TabIndex = 72
        Me.PictureBoxCancela1.TabStop = False
        '
        'LbControle
        '
        Me.LbControle.BackColor = System.Drawing.Color.Navy
        Me.LbControle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LbControle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbControle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbControle.ForeColor = System.Drawing.Color.White
        Me.LbControle.Location = New System.Drawing.Point(0, 114)
        Me.LbControle.Name = "LbControle"
        Me.LbControle.Size = New System.Drawing.Size(1029, 16)
        Me.LbControle.TabIndex = 32
        Me.LbControle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExcluir
        '
        Me.btnExcluir.ActiveBorderThickness = 1
        Me.btnExcluir.ActiveCornerRadius = 30
        Me.btnExcluir.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnExcluir.ActiveForecolor = System.Drawing.Color.White
        Me.btnExcluir.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnExcluir.BackColor = System.Drawing.Color.Gainsboro
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
        Me.btnExcluir.Location = New System.Drawing.Point(776, 69)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(80, 40)
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
        Me.btnRelatorio.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRelatorio.BackgroundImage = CType(resources.GetObject("btnRelatorio.BackgroundImage"), System.Drawing.Image)
        Me.btnRelatorio.ButtonText = "Relatório"
        Me.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelatorio.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnRelatorio.IdleBorderThickness = 1
        Me.btnRelatorio.IdleCornerRadius = 20
        Me.btnRelatorio.IdleFillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRelatorio.IdleForecolor = System.Drawing.Color.Gainsboro
        Me.btnRelatorio.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnRelatorio.Location = New System.Drawing.Point(676, 69)
        Me.btnRelatorio.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(90, 40)
        Me.btnRelatorio.TabIndex = 19
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAbrir
        '
        Me.btnAbrir.ActiveBorderThickness = 1
        Me.btnAbrir.ActiveCornerRadius = 30
        Me.btnAbrir.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.btnAbrir.ActiveForecolor = System.Drawing.Color.White
        Me.btnAbrir.ActiveLineColor = System.Drawing.Color.DarkGreen
        Me.btnAbrir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAbrir.BackgroundImage = CType(resources.GetObject("btnAbrir.BackgroundImage"), System.Drawing.Image)
        Me.btnAbrir.ButtonText = "Abrir Cancela"
        Me.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrir.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnAbrir.IdleBorderThickness = 1
        Me.btnAbrir.IdleCornerRadius = 20
        Me.btnAbrir.IdleFillColor = System.Drawing.Color.DarkCyan
        Me.btnAbrir.IdleForecolor = System.Drawing.Color.Gainsboro
        Me.btnAbrir.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnAbrir.Location = New System.Drawing.Point(421, 5)
        Me.btnAbrir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(75, 54)
        Me.btnAbrir.TabIndex = 63
        Me.btnAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFechar
        '
        Me.btnFechar.ActiveBorderThickness = 1
        Me.btnFechar.ActiveCornerRadius = 30
        Me.btnFechar.ActiveFillColor = System.Drawing.Color.OrangeRed
        Me.btnFechar.ActiveForecolor = System.Drawing.Color.White
        Me.btnFechar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFechar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnFechar.BackgroundImage = CType(resources.GetObject("btnFechar.BackgroundImage"), System.Drawing.Image)
        Me.btnFechar.ButtonText = "Fechar Cancela"
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnFechar.IdleBorderThickness = 1
        Me.btnFechar.IdleCornerRadius = 20
        Me.btnFechar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFechar.IdleForecolor = System.Drawing.Color.Gainsboro
        Me.btnFechar.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnFechar.Location = New System.Drawing.Point(421, 55)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 54)
        Me.btnFechar.TabIndex = 64
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 407)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1029, 10)
        Me.Panel1.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1029, 0)
        Me.Label11.TabIndex = 32
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtGridAutomacao
        '
        Me.dtGridAutomacao.AllowUserToOrderColumns = True
        Me.dtGridAutomacao.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtGridAutomacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridAutomacao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridAutomacao.GridColor = System.Drawing.SystemColors.Control
        Me.dtGridAutomacao.Location = New System.Drawing.Point(0, 155)
        Me.dtGridAutomacao.Name = "dtGridAutomacao"
        Me.dtGridAutomacao.Size = New System.Drawing.Size(1029, 252)
        Me.dtGridAutomacao.TabIndex = 44
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'FbGroupBox1
        '
        Me.FbGroupBox1.BackColor = System.Drawing.Color.Lavender
        Me.FbGroupBox1.Controls.Add(Me.rbAcesso)
        Me.FbGroupBox1.Controls.Add(Me.rbPortaria)
        Me.FbGroupBox1.Location = New System.Drawing.Point(3, 30)
        Me.FbGroupBox1.Name = "FbGroupBox1"
        Me.FbGroupBox1.Size = New System.Drawing.Size(131, 94)
        Me.FbGroupBox1.TabIndex = 17
        Me.FbGroupBox1.TabStop = False
        '
        'DtsFuncao1
        '
        Me.DtsFuncao1.DataSetName = "dtsFuncao"
        Me.DtsFuncao1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rbPortaria
        '
        Me.rbPortaria.AutoSize = True
        Me.rbPortaria.Campo = ""
        Me.rbPortaria.ControlDB = Nothing
        Me.rbPortaria.Location = New System.Drawing.Point(9, 56)
        Me.rbPortaria.Name = "rbPortaria"
        Me.rbPortaria.Size = New System.Drawing.Size(103, 17)
        Me.rbPortaria.TabIndex = 1
        Me.rbPortaria.TabStop = True
        Me.rbPortaria.Text = "Controle Portaria"
        Me.rbPortaria.UseVisualStyleBackColor = True
        Me.rbPortaria.Valor = Nothing
        Me.rbPortaria.ValorChecado = Nothing
        Me.rbPortaria.valorVazio = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Navy
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(139, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(5, 129)
        Me.Label12.TabIndex = 75
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbAcesso
        '
        Me.rbAcesso.AutoSize = True
        Me.rbAcesso.Campo = ""
        Me.rbAcesso.Checked = True
        Me.rbAcesso.ControlDB = Nothing
        Me.rbAcesso.Location = New System.Drawing.Point(9, 22)
        Me.rbAcesso.Name = "rbAcesso"
        Me.rbAcesso.Size = New System.Drawing.Size(102, 17)
        Me.rbAcesso.TabIndex = 2
        Me.rbAcesso.TabStop = True
        Me.rbAcesso.Text = "Controle Acesso"
        Me.rbAcesso.UseVisualStyleBackColor = True
        Me.rbAcesso.Valor = Nothing
        Me.rbAcesso.ValorChecado = Nothing
        Me.rbAcesso.valorVazio = False
        '
        'frmAutomacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1029, 555)
        Me.Controls.Add(Me.dtGridAutomacao)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlRodape)
        Me.Controls.Add(Me.dtGridTag)
        Me.Controls.Add(Me.PVeiculo2)
        Me.Controls.Add(Me.pnlTop)
        Me.Name = "frmAutomacao"
        Me.Text = "Automação"
        Me.pnlTop.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.FbPanel1.ResumeLayout(False)
        Me.FbPanel1.PerformLayout()
        Me.PVeiculo2.ResumeLayout(False)
        CType(Me.dtGridTag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRodape.ResumeLayout(False)
        CType(Me.dtGridStatusCancela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCancela1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtGridAutomacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FbGroupBox1.ResumeLayout(False)
        Me.FbGroupBox1.PerformLayout()
        CType(Me.DtsFuncao1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCarregar As Button
    Friend WithEvents PVeiculo2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents dtGridTag As DataGridView
    Friend WithEvents FbPanel1 As fbPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLeitorSaida As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLeitorEntrada As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCancela As TextBox
    Friend WithEvents dtfim As DateTimePicker
    Friend WithEvents dtini As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNumeroTAG As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents btLimpar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ckbCancela1 As CheckBox
    Friend WithEvents btnLimpar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pnlRodape As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtGridStatusCancela As DataGridView
    Friend WithEvents PictureBoxCancela1 As PictureBox
    Friend WithEvents LbControle As Label
    Friend WithEvents btnExcluir As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnRelatorio As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnAbrir As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnFechar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents dtGridAutomacao As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FbGroupBox1 As fbGroupBox
    Friend WithEvents DtsFuncao1 As dtsFuncao
    Friend WithEvents Label12 As Label
    Friend WithEvents rbPortaria As fbRadioButton
    Friend WithEvents rbAcesso As fbRadioButton
End Class
