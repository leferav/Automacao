<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadPortaria
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadPortaria))
        Me.pnlRodape = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LbControle = New System.Windows.Forms.Label()
        Me.btnCadTAGs = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnLimpar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnExcluir = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnRelatorio = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTiket = New System.Windows.Forms.TextBox()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtDataSaida = New System.Windows.Forms.DateTimePicker()
        Me.dtAgendamento = New System.Windows.Forms.DateTimePicker()
        Me.dtDataEntrada = New System.Windows.Forms.DateTimePicker()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSolicitacao = New System.Windows.Forms.RadioButton()
        Me.rbEntrada = New System.Windows.Forms.RadioButton()
        Me.rbAgendamento = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbStatusVeiculos = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtProdutor = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelLat = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PVeiculo2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        'Me.DataSetRel1 = New FeedAutomacao.DataSetRel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TabPageEX1 = New Dotnetrix.Controls.TabPageEX()
        Me.TabPageEX2 = New Dotnetrix.Controls.TabPageEX()
        Me.pnlRodape.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PVeiculo2.SuspendLayout()
        'CType(Me.DataSetRel1, System.ComponentModel.ISupportInitialize).BeginInit()
        'Me.NF.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRodape
        '
        Me.pnlRodape.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlRodape.Controls.Add(Me.Panel3)
        Me.pnlRodape.Controls.Add(Me.LbControle)
        Me.pnlRodape.Controls.Add(Me.btnCadTAGs)
        Me.pnlRodape.Controls.Add(Me.btnLimpar)
        Me.pnlRodape.Controls.Add(Me.btnExcluir)
        Me.pnlRodape.Controls.Add(Me.btnRelatorio)
        Me.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRodape.Location = New System.Drawing.Point(0, 496)
        Me.pnlRodape.Name = "pnlRodape"
        Me.pnlRodape.Size = New System.Drawing.Size(864, 59)
        Me.pnlRodape.TabIndex = 25
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(8, 49)
        Me.Panel3.TabIndex = 47
        '
        'LbControle
        '
        Me.LbControle.BackColor = System.Drawing.Color.Navy
        Me.LbControle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LbControle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbControle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbControle.ForeColor = System.Drawing.Color.White
        Me.LbControle.Location = New System.Drawing.Point(0, 49)
        Me.LbControle.Name = "LbControle"
        Me.LbControle.Size = New System.Drawing.Size(864, 10)
        Me.LbControle.TabIndex = 32
        Me.LbControle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCadTAGs
        '
        Me.btnCadTAGs.ActiveBorderThickness = 1
        Me.btnCadTAGs.ActiveCornerRadius = 20
        Me.btnCadTAGs.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCadTAGs.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCadTAGs.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCadTAGs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.btnCadTAGs.Location = New System.Drawing.Point(334, 5)
        Me.btnCadTAGs.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCadTAGs.Name = "btnCadTAGs"
        Me.btnCadTAGs.Size = New System.Drawing.Size(208, 40)
        Me.btnCadTAGs.TabIndex = 22
        Me.btnCadTAGs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLimpar
        '
        Me.btnLimpar.ActiveBorderThickness = 1
        Me.btnLimpar.ActiveCornerRadius = 30
        Me.btnLimpar.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnLimpar.ActiveForecolor = System.Drawing.Color.White
        Me.btnLimpar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.btnLimpar.Location = New System.Drawing.Point(779, 4)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(71, 40)
        Me.btnLimpar.TabIndex = 24
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExcluir
        '
        Me.btnExcluir.ActiveBorderThickness = 1
        Me.btnExcluir.ActiveCornerRadius = 30
        Me.btnExcluir.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnExcluir.ActiveForecolor = System.Drawing.Color.White
        Me.btnExcluir.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnExcluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.btnExcluir.Location = New System.Drawing.Point(668, 5)
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
        Me.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.btnRelatorio.Location = New System.Drawing.Point(568, 5)
        Me.btnRelatorio.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(90, 40)
        Me.btnRelatorio.TabIndex = 19
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnlTop.Controls.Add(Me.Label7)
        Me.pnlTop.Controls.Add(Me.Label6)
        Me.pnlTop.Controls.Add(Me.txtTiket)
        Me.pnlTop.Controls.Add(Me.txtLote)
        Me.pnlTop.Controls.Add(Me.Panel5)
        Me.pnlTop.Controls.Add(Me.Panel4)
        Me.pnlTop.Controls.Add(Me.Label5)
        Me.pnlTop.Controls.Add(Me.Label4)
        Me.pnlTop.Controls.Add(Me.Label3)
        Me.pnlTop.Controls.Add(Me.dtDataSaida)
        Me.pnlTop.Controls.Add(Me.dtAgendamento)
        Me.pnlTop.Controls.Add(Me.dtDataEntrada)
        Me.pnlTop.Controls.Add(Me.lblstatus)
        Me.pnlTop.Controls.Add(Me.GroupBox1)
        Me.pnlTop.Controls.Add(Me.Panel2)
        Me.pnlTop.Controls.Add(Me.LbStatusVeiculos)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(864, 117)
        Me.pnlTop.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(425, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 477
        Me.Label7.Text = "Ticket:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(434, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 476
        Me.Label6.Text = "Lote:"
        '
        'txtTiket
        '
        Me.txtTiket.Location = New System.Drawing.Point(468, 53)
        Me.txtTiket.Name = "txtTiket"
        Me.txtTiket.Size = New System.Drawing.Size(94, 20)
        Me.txtTiket.TabIndex = 475
        Me.txtTiket.Text = "0"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(468, 27)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(145, 20)
        Me.txtLote.TabIndex = 474
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.Location = New System.Drawing.Point(415, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 105)
        Me.Panel5.TabIndex = 473
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Location = New System.Drawing.Point(163, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 105)
        Me.Panel4.TabIndex = 472
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 471
        Me.Label5.Text = "Data Saída:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 470
        Me.Label4.Text = "Data Agenda.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 469
        Me.Label3.Text = "Data Entrada:"
        '
        'dtDataSaida
        '
        Me.dtDataSaida.Checked = False
        Me.dtDataSaida.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDataSaida.Location = New System.Drawing.Point(251, 53)
        Me.dtDataSaida.Name = "dtDataSaida"
        Me.dtDataSaida.ShowCheckBox = True
        Me.dtDataSaida.Size = New System.Drawing.Size(144, 20)
        Me.dtDataSaida.TabIndex = 468
        '
        'dtAgendamento
        '
        Me.dtAgendamento.Checked = False
        Me.dtAgendamento.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAgendamento.Location = New System.Drawing.Point(251, 81)
        Me.dtAgendamento.Name = "dtAgendamento"
        Me.dtAgendamento.ShowCheckBox = True
        Me.dtAgendamento.Size = New System.Drawing.Size(144, 20)
        Me.dtAgendamento.TabIndex = 467
        '
        'dtDataEntrada
        '
        Me.dtDataEntrada.CustomFormat = "dd/MM/yyyy"
        Me.dtDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDataEntrada.Location = New System.Drawing.Point(268, 27)
        Me.dtDataEntrada.Name = "dtDataEntrada"
        Me.dtDataEntrada.Size = New System.Drawing.Size(110, 20)
        Me.dtDataEntrada.TabIndex = 466
        '
        'lblstatus
        '
        Me.lblstatus.BackColor = System.Drawing.Color.SteelBlue
        Me.lblstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.Lavender
        Me.lblstatus.Location = New System.Drawing.Point(666, 15)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(193, 32)
        Me.lblstatus.TabIndex = 465
        Me.lblstatus.Tag = "-1"
        Me.lblstatus.Text = "EM DIGITAÇÃO"
        Me.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbSolicitacao)
        Me.GroupBox1.Controls.Add(Me.rbEntrada)
        Me.GroupBox1.Controls.Add(Me.rbAgendamento)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 95)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
        '
        'rbSolicitacao
        '
        Me.rbSolicitacao.AutoSize = True
        Me.rbSolicitacao.Location = New System.Drawing.Point(6, 65)
        Me.rbSolicitacao.Name = "rbSolicitacao"
        Me.rbSolicitacao.Size = New System.Drawing.Size(132, 17)
        Me.rbSolicitacao.TabIndex = 53
        Me.rbSolicitacao.Text = "Solicitação de Veículo"
        Me.rbSolicitacao.UseVisualStyleBackColor = True
        '
        'rbEntrada
        '
        Me.rbEntrada.AutoSize = True
        Me.rbEntrada.Checked = True
        Me.rbEntrada.Location = New System.Drawing.Point(6, 19)
        Me.rbEntrada.Name = "rbEntrada"
        Me.rbEntrada.Size = New System.Drawing.Size(62, 17)
        Me.rbEntrada.TabIndex = 51
        Me.rbEntrada.TabStop = True
        Me.rbEntrada.Text = "Entrada"
        Me.rbEntrada.UseVisualStyleBackColor = True
        '
        'rbAgendamento
        '
        Me.rbAgendamento.AutoSize = True
        Me.rbAgendamento.Location = New System.Drawing.Point(6, 42)
        Me.rbAgendamento.Name = "rbAgendamento"
        Me.rbAgendamento.Size = New System.Drawing.Size(91, 17)
        Me.rbAgendamento.TabIndex = 52
        Me.rbAgendamento.Text = "Agendamento"
        Me.rbAgendamento.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(8, 105)
        Me.Panel2.TabIndex = 47
        '
        'LbStatusVeiculos
        '
        Me.LbStatusVeiculos.BackColor = System.Drawing.Color.Navy
        Me.LbStatusVeiculos.Dock = System.Windows.Forms.DockStyle.Top
        Me.LbStatusVeiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbStatusVeiculos.Location = New System.Drawing.Point(0, 0)
        Me.LbStatusVeiculos.Name = "LbStatusVeiculos"
        Me.LbStatusVeiculos.Size = New System.Drawing.Size(864, 12)
        Me.LbStatusVeiculos.TabIndex = 34
        Me.LbStatusVeiculos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        'Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        'Me.Panel1.Controls.Add(Me.lkpOrigem)
        'Me.Panel1.Controls.Add(Me.lkpProduto)
        'Me.Panel1.Controls.Add(Me.lkpVeiculo)
        'Me.Panel1.Controls.Add(Me.lkpProdutor)
        'Me.Panel1.Controls.Add(Me.lkpMotorista)
        'Me.Panel1.Controls.Add(Me.NF)
        'Me.Panel1.Controls.Add(Me.Label22)
        'Me.Panel1.Controls.Add(Me.Label21)
        'Me.Panel1.Controls.Add(Me.txtObservacao)
        'Me.Panel1.Controls.Add(Me.Label20)
        'Me.Panel1.Controls.Add(Me.Label19)
        'Me.Panel1.Controls.Add(Me.Label18)
        'Me.Panel1.Controls.Add(Me.Label17)
        'Me.Panel1.Controls.Add(Me.txtPesoL)
        'Me.Panel1.Controls.Add(Me.txtPeso)
        'Me.Panel1.Controls.Add(Me.txtVolume)
        'Me.Panel1.Controls.Add(Me.txtQtd)
        'Me.Panel1.Controls.Add(Me.txtProdutor)
        'Me.Panel1.Controls.Add(Me.Label16)
        'Me.Panel1.Controls.Add(Me.cbbGuia)
        'Me.Panel1.Controls.Add(Me.Label15)
        'Me.Panel1.Controls.Add(Me.Label14)
        'Me.Panel1.Controls.Add(Me.Label13)
        'Me.Panel1.Controls.Add(Me.cbbTipo)
        'Me.Panel1.Controls.Add(Me.cbbUnidade)
        'Me.Panel1.Controls.Add(Me.cbbTransportadora)
        'Me.Panel1.Controls.Add(Me.Label12)
        'Me.Panel1.Controls.Add(Me.Label10)
        'Me.Panel1.Controls.Add(Me.Label11)
        'Me.Panel1.Controls.Add(Me.Label9)
        'Me.Panel1.Controls.Add(Me.Label8)
        'Me.Panel1.Controls.Add(Me.PanelLat)
        'Me.Panel1.Controls.Add(Me.Label2)
        'Me.Panel1.Controls.Add(Me.PVeiculo2)
        'Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.Panel1.Location = New System.Drawing.Point(0, 117)
        'Me.Panel1.Name = "Panel1"
        'Me.Panel1.Size = New System.Drawing.Size(864, 379)
        'Me.Panel1.TabIndex = 28
        ''
        ''Label20
        ''
        'Me.Label20.AutoSize = True
        'Me.Label20.Location = New System.Drawing.Point(236, 187)
        'Me.Label20.Name = "Label20"
        'Me.Label20.Size = New System.Drawing.Size(78, 13)
        'Me.Label20.TabIndex = 497
        'Me.Label20.Text = "Peso Liq. (KG):"
        ''
        ''Label19
        ''
        'Me.Label19.AutoSize = True
        'Me.Label19.Location = New System.Drawing.Point(256, 162)
        'Me.Label19.Name = "Label19"
        'Me.Label19.Size = New System.Drawing.Size(58, 13)
        'Me.Label19.TabIndex = 496
        'Me.Label19.Text = "Peso (KG):"
        ''
        ''Label18
        ''
        'Me.Label18.AutoSize = True
        'Me.Label18.Location = New System.Drawing.Point(11, 184)
        'Me.Label18.Name = "Label18"
        'Me.Label18.Size = New System.Drawing.Size(70, 13)
        'Me.Label18.TabIndex = 495
        'Me.Label18.Text = "Volume (scs):"
        ''
        ''Label17
        ''
        'Me.Label17.AutoSize = True
        'Me.Label17.Location = New System.Drawing.Point(15, 157)
        'Me.Label17.Name = "Label17"
        'Me.Label17.Size = New System.Drawing.Size(65, 13)
        'Me.Label17.TabIndex = 494
        'Me.Label17.Text = "Quantidade:"
        ''
        ''txtPesoL
        ''
        'Me.txtPesoL.AceitaNegativo = True
        'Me.txtPesoL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.txtPesoL.CasasDecimais = 2
        'Me.txtPesoL.CulturaSistema = True
        'Me.txtPesoL.Location = New System.Drawing.Point(317, 183)
        'Me.txtPesoL.Name = "txtPesoL"
        'Me.txtPesoL.NomeCampoMsg = "fbNumericBox_v2"
        'Me.txtPesoL.Requerido = False
        'Me.txtPesoL.SeparadorDecimal = ","
        'Me.txtPesoL.SeparadorMilhar = "."
        'Me.txtPesoL.SimboloMoeda = "R$"
        'Me.txtPesoL.SimboloPercentual = "%"
        'Me.txtPesoL.Size = New System.Drawing.Size(100, 20)
        'Me.txtPesoL.TabIndex = 493
        'Me.txtPesoL.Text = "0,00"
        'Me.txtPesoL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        'Me.txtPesoL.ValorMaximo = 100000000
        'Me.txtPesoL.ValorMinimo = -100000000
        ''
        ''txtPeso
        ''
        'Me.txtPeso.AceitaNegativo = True
        'Me.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.txtPeso.CasasDecimais = 2
        'Me.txtPeso.CulturaSistema = True
        'Me.txtPeso.Location = New System.Drawing.Point(317, 158)
        'Me.txtPeso.Name = "txtPeso"
        'Me.txtPeso.NomeCampoMsg = "fbNumericBox_v2"
        'Me.txtPeso.Requerido = False
        'Me.txtPeso.SeparadorDecimal = ","
        'Me.txtPeso.SeparadorMilhar = "."
        'Me.txtPeso.SimboloMoeda = "R$"
        'Me.txtPeso.SimboloPercentual = "%"
        'Me.txtPeso.Size = New System.Drawing.Size(100, 20)
        'Me.txtPeso.TabIndex = 492
        'Me.txtPeso.Text = "0,00"
        'Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        'Me.txtPeso.ValorMaximo = 100000000
        'Me.txtPeso.ValorMinimo = -100000000
        ''
        ''txtVolume
        ''
        'Me.txtVolume.AceitaNegativo = True
        'Me.txtVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.txtVolume.CasasDecimais = 2
        'Me.txtVolume.CulturaSistema = True
        'Me.txtVolume.Location = New System.Drawing.Point(83, 182)
        'Me.txtVolume.Name = "txtVolume"
        'Me.txtVolume.NomeCampoMsg = "fbNumericBox_v2"
        'Me.txtVolume.Requerido = False
        'Me.txtVolume.SeparadorDecimal = ","
        'Me.txtVolume.SeparadorMilhar = "."
        'Me.txtVolume.SimboloMoeda = "R$"
        'Me.txtVolume.SimboloPercentual = "%"
        'Me.txtVolume.Size = New System.Drawing.Size(100, 20)
        'Me.txtVolume.TabIndex = 491
        'Me.txtVolume.Text = "0,00"
        'Me.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        'Me.txtVolume.ValorMaximo = 100000000
        'Me.txtVolume.ValorMinimo = -100000000
        ''
        ''txtQtd
        ''
        'Me.txtQtd.AceitaNegativo = True
        'Me.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.txtQtd.CasasDecimais = 2
        'Me.txtQtd.CulturaSistema = True
        'Me.txtQtd.Location = New System.Drawing.Point(83, 158)
        'Me.txtQtd.Name = "txtQtd"
        'Me.txtQtd.NomeCampoMsg = "fbNumericBox_v2"
        'Me.txtQtd.Requerido = False
        'Me.txtQtd.SeparadorDecimal = ","
        'Me.txtQtd.SeparadorMilhar = "."
        'Me.txtQtd.SimboloMoeda = "R$"
        'Me.txtQtd.SimboloPercentual = "%"
        'Me.txtQtd.Size = New System.Drawing.Size(100, 20)
        'Me.txtQtd.TabIndex = 490
        'Me.txtQtd.Text = "0,00"
        'Me.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        'Me.txtQtd.ValorMaximo = 100000000
        'Me.txtQtd.ValorMinimo = -100000000
        ''
        ''txtProdutor
        ''
        'Me.txtProdutor.Location = New System.Drawing.Point(543, 123)
        'Me.txtProdutor.Name = "txtProdutor"
        'Me.txtProdutor.Size = New System.Drawing.Size(304, 20)
        'Me.txtProdutor.TabIndex = 489
        ''
        ''Label16
        ''
        'Me.Label16.AutoSize = True
        'Me.Label16.Location = New System.Drawing.Point(504, 101)
        'Me.Label16.Name = "Label16"
        'Me.Label16.Size = New System.Drawing.Size(32, 13)
        'Me.Label16.TabIndex = 488
        'Me.Label16.Text = "Guia:"
        ''
        ''cbbGuia
        ''
        'Me.cbbGuia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        'Me.cbbGuia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        'Me.cbbGuia.BackColor = System.Drawing.SystemColors.Window
        'Me.cbbGuia.Campo = ""
        'Me.cbbGuia.campoDistinct = False
        'Me.cbbGuia.campoID = ""
        'Me.cbbGuia.campoRelacionamento = ""
        'Me.cbbGuia.campoSelecionavel = ""
        'Me.cbbGuia.campoSql = ""
        'Me.cbbGuia.carrega2Parametro = False
        'Me.cbbGuia.ComNoLock = True
        'Me.cbbGuia.ControlDB = Nothing
        'Me.cbbGuia.DisplayMember = "Texto"
        'Me.cbbGuia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        'Me.cbbGuia.Filtro = ""
        'Me.cbbGuia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        'Me.cbbGuia.FormattingEnabled = True
        'Me.cbbGuia.Location = New System.Drawing.Point(543, 97)
        'Me.cbbGuia.Name = "cbbGuia"
        'Me.cbbGuia.Requerido = False
        'Me.cbbGuia.Size = New System.Drawing.Size(304, 21)
        'Me.cbbGuia.TabelaRelacionamento = ""
        'Me.cbbGuia.TabIndex = 487
        'Me.cbbGuia.TextoSelecionar = ""
        'Me.cbbGuia.Valor = Nothing
        'Me.cbbGuia.ValorRelacionamento = ""
        'Me.cbbGuia.ValorSelecionado = "-1"
        'Me.cbbGuia.valorVazio = -1
        'Me.cbbGuia.ValueMember = "Valor"
        ''
        ''Label15
        ''
        'Me.Label15.AutoSize = True
        'Me.Label15.Location = New System.Drawing.Point(505, 74)
        'Me.Label15.Name = "Label15"
        'Me.Label15.Size = New System.Drawing.Size(31, 13)
        'Me.Label15.TabIndex = 486
        'Me.Label15.Text = "Tipo:"
        ''
        ''Label14
        ''
        'Me.Label14.AutoSize = True
        'Me.Label14.Location = New System.Drawing.Point(486, 47)
        'Me.Label14.Name = "Label14"
        'Me.Label14.Size = New System.Drawing.Size(50, 13)
        'Me.Label14.TabIndex = 485
        'Me.Label14.Text = "Unidade:"
        ''
        ''Label13
        ''
        'Me.Label13.AutoSize = True
        'Me.Label13.Location = New System.Drawing.Point(454, 20)
        'Me.Label13.Name = "Label13"
        'Me.Label13.Size = New System.Drawing.Size(82, 13)
        'Me.Label13.TabIndex = 484
        'Me.Label13.Text = "Transportadora:"
        ''
        ''cbbTipo
        ''
        'Me.cbbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        'Me.cbbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        'Me.cbbTipo.BackColor = System.Drawing.Color.SkyBlue
        'Me.cbbTipo.Campo = ""
        'Me.cbbTipo.campoDistinct = False
        'Me.cbbTipo.campoID = ""
        'Me.cbbTipo.campoRelacionamento = ""
        'Me.cbbTipo.campoSelecionavel = ""
        'Me.cbbTipo.campoSql = ""
        'Me.cbbTipo.carrega2Parametro = False
        'Me.cbbTipo.ComNoLock = True
        'Me.cbbTipo.ControlDB = Nothing
        'Me.cbbTipo.DisplayMember = "Texto"
        'Me.cbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        'Me.cbbTipo.Filtro = ""
        'Me.cbbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        'Me.cbbTipo.FormattingEnabled = True
        'Me.cbbTipo.Location = New System.Drawing.Point(543, 70)
        'Me.cbbTipo.Name = "cbbTipo"
        'Me.cbbTipo.Requerido = False
        'Me.cbbTipo.Size = New System.Drawing.Size(304, 21)
        'Me.cbbTipo.TabelaRelacionamento = ""
        'Me.cbbTipo.TabIndex = 483
        'Me.cbbTipo.TextoSelecionar = ""
        'Me.cbbTipo.Valor = Nothing
        'Me.cbbTipo.ValorRelacionamento = ""
        'Me.cbbTipo.ValorSelecionado = "-1"
        'Me.cbbTipo.valorVazio = -1
        'Me.cbbTipo.ValueMember = "Valor"
        ''
        ''cbbUnidade
        ''
        'Me.cbbUnidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        'Me.cbbUnidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        'Me.cbbUnidade.BackColor = System.Drawing.Color.SkyBlue
        'Me.cbbUnidade.Campo = ""
        'Me.cbbUnidade.campoDistinct = False
        'Me.cbbUnidade.campoID = ""
        'Me.cbbUnidade.campoRelacionamento = ""
        'Me.cbbUnidade.campoSelecionavel = ""
        'Me.cbbUnidade.campoSql = ""
        'Me.cbbUnidade.carrega2Parametro = False
        'Me.cbbUnidade.ComNoLock = True
        'Me.cbbUnidade.ControlDB = Nothing
        'Me.cbbUnidade.DisplayMember = "Texto"
        'Me.cbbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        'Me.cbbUnidade.Filtro = ""
        'Me.cbbUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        'Me.cbbUnidade.FormattingEnabled = True
        'Me.cbbUnidade.Location = New System.Drawing.Point(543, 43)
        'Me.cbbUnidade.Name = "cbbUnidade"
        'Me.cbbUnidade.Requerido = False
        'Me.cbbUnidade.Size = New System.Drawing.Size(304, 21)
        'Me.cbbUnidade.TabelaRelacionamento = ""
        'Me.cbbUnidade.TabIndex = 482
        'Me.cbbUnidade.TextoSelecionar = ""
        'Me.cbbUnidade.Valor = Nothing
        'Me.cbbUnidade.ValorRelacionamento = ""
        'Me.cbbUnidade.ValorSelecionado = "-1"
        'Me.cbbUnidade.valorVazio = -1
        'Me.cbbUnidade.ValueMember = "Valor"
        ''
        ''cbbTransportadora
        ''
        'Me.cbbTransportadora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        'Me.cbbTransportadora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        'Me.cbbTransportadora.BackColor = System.Drawing.Color.SkyBlue
        'Me.cbbTransportadora.Campo = ""
        'Me.cbbTransportadora.campoDistinct = False
        'Me.cbbTransportadora.campoID = ""
        'Me.cbbTransportadora.campoRelacionamento = ""
        'Me.cbbTransportadora.campoSelecionavel = ""
        'Me.cbbTransportadora.campoSql = ""
        'Me.cbbTransportadora.carrega2Parametro = False
        'Me.cbbTransportadora.ComNoLock = True
        'Me.cbbTransportadora.ControlDB = Nothing
        'Me.cbbTransportadora.DisplayMember = "Texto"
        'Me.cbbTransportadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        'Me.cbbTransportadora.Filtro = ""
        'Me.cbbTransportadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        'Me.cbbTransportadora.FormattingEnabled = True
        'Me.cbbTransportadora.Location = New System.Drawing.Point(543, 16)
        'Me.cbbTransportadora.Name = "cbbTransportadora"
        'Me.cbbTransportadora.Requerido = False
        'Me.cbbTransportadora.Size = New System.Drawing.Size(304, 21)
        'Me.cbbTransportadora.TabelaRelacionamento = ""
        'Me.cbbTransportadora.TabIndex = 481
        'Me.cbbTransportadora.TextoSelecionar = ""
        'Me.cbbTransportadora.Valor = Nothing
        'Me.cbbTransportadora.ValorRelacionamento = ""
        'Me.cbbTransportadora.ValorSelecionado = "-1"
        'Me.cbbTransportadora.valorVazio = -1
        'Me.cbbTransportadora.ValueMember = "Valor"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 480
        Me.Label12.Text = "Origem:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 477
        Me.Label10.Text = "Produto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 476
        Me.Label11.Text = "Veículo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 471
        Me.Label9.Text = "Domicílio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 470
        Me.Label8.Text = "Motorista:"
        '
        'PanelLat
        '
        Me.PanelLat.BackColor = System.Drawing.Color.Navy
        Me.PanelLat.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLat.Location = New System.Drawing.Point(0, 4)
        Me.PanelLat.Name = "PanelLat"
        Me.PanelLat.Size = New System.Drawing.Size(8, 367)
        Me.PanelLat.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(864, 4)
        Me.Label2.TabIndex = 40
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PVeiculo2
        '
        Me.PVeiculo2.BackColor = System.Drawing.Color.Navy
        Me.PVeiculo2.Controls.Add(Me.Label1)
        Me.PVeiculo2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PVeiculo2.Location = New System.Drawing.Point(0, 371)
        Me.PVeiculo2.Name = "PVeiculo2"
        Me.PVeiculo2.Size = New System.Drawing.Size(864, 8)
        Me.PVeiculo2.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(864, 0)
        Me.Label1.TabIndex = 32
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSetRel1
        '
        'Me.DataSetRel1.DataSetName = "DataSetRel"
        'Me.DataSetRel1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtObservacao
        ''
        'Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.txtObservacao.Campo = ""
        'Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        'Me.txtObservacao.ControlDB = Nothing
        'Me.txtObservacao.Location = New System.Drawing.Point(543, 157)
        'Me.txtObservacao.MaxLength = 500
        'Me.txtObservacao.Multiline = True
        'Me.txtObservacao.Name = "txtObservacao"
        'Me.txtObservacao.Requerido = False
        'Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Both
        'Me.txtObservacao.Size = New System.Drawing.Size(304, 47)
        'Me.txtObservacao.TabIndex = 498
        'Me.txtObservacao.Valor = Nothing
        'Me.txtObservacao.valorVazio = ""
        ''
        ''Label21
        ''
        'Me.Label21.AutoSize = True
        'Me.Label21.Location = New System.Drawing.Point(469, 161)
        'Me.Label21.Name = "Label21"
        'Me.Label21.Size = New System.Drawing.Size(68, 13)
        'Me.Label21.TabIndex = 499
        'Me.Label21.Text = "Observação:"
        ''
        ''Label22
        ''
        'Me.Label22.AutoSize = True
        'Me.Label22.Location = New System.Drawing.Point(486, 127)
        'Me.Label22.Name = "Label22"
        'Me.Label22.Size = New System.Drawing.Size(50, 13)
        'Me.Label22.TabIndex = 500
        'Me.Label22.Text = "Produtor:"
        ''
        ''NF
        ''
        'Me.NF.Controls.Add(Me.TabPageEX1)
        'Me.NF.Controls.Add(Me.TabPageEX2)
        'Me.NF.Dock = System.Windows.Forms.DockStyle.Bottom
        'Me.NF.Location = New System.Drawing.Point(8, 271)
        'Me.NF.Name = "NF"
        'Me.NF.SelectedIndex = 0
        'Me.NF.Size = New System.Drawing.Size(856, 100)
        'Me.NF.TabIndex = 501
        ''
        ''TabPageEX1
        ''
        'Me.TabPageEX1.BackColor = System.Drawing.SystemColors.Window
        'Me.TabPageEX1.Location = New System.Drawing.Point(4, 25)
        'Me.TabPageEX1.Name = "TabPageEX1"
        'Me.TabPageEX1.Size = New System.Drawing.Size(848, 71)
        'Me.TabPageEX1.TabIndex = 0
        'Me.TabPageEX1.Text = "NF"
        ''
        ''TabPageEX2
        ''
        'Me.TabPageEX2.Location = New System.Drawing.Point(4, 25)
        'Me.TabPageEX2.Name = "TabPageEX2"
        'Me.TabPageEX2.Size = New System.Drawing.Size(848, 71)
        'Me.TabPageEX2.TabIndex = 1
        'Me.TabPageEX2.Text = "Certificado"
        ''
        ''lkpMotorista
        ''
        'Me.lkpMotorista.ControlDB = Nothing
        'Me.lkpMotorista.DataTableSelect = Nothing
        'Me.lkpMotorista.FormularioPesquisa = Nothing
        'Me.lkpMotorista.LimpaTexto = True
        'Me.lkpMotorista.Location = New System.Drawing.Point(81, 17)
        'Me.lkpMotorista.Name = "lkpMotorista"
        'Me.lkpMotorista.NomeCampoMsg = "fbLookUp"
        'Me.lkpMotorista.Requerido = True
        'Me.lkpMotorista.SelectID = -1
        'Me.lkpMotorista.Size = New System.Drawing.Size(336, 20)
        'Me.lkpMotorista.TabIndex = 502
        ''
        ''lkpProdutor
        ''
        'Me.lkpProdutor.ControlDB = Nothing
        'Me.lkpProdutor.DataTableSelect = Nothing
        'Me.lkpProdutor.FormularioPesquisa = Nothing
        'Me.lkpProdutor.LimpaTexto = True
        'Me.lkpProdutor.Location = New System.Drawing.Point(81, 44)
        'Me.lkpProdutor.Name = "lkpProdutor"
        'Me.lkpProdutor.NomeCampoMsg = "fbLookUp"
        'Me.lkpProdutor.Requerido = True
        'Me.lkpProdutor.SelectID = -1
        'Me.lkpProdutor.Size = New System.Drawing.Size(336, 20)
        'Me.lkpProdutor.TabIndex = 503
        ''
        ''lkpVeiculo
        ''
        'Me.lkpVeiculo.ControlDB = Nothing
        'Me.lkpVeiculo.DataTableSelect = Nothing
        'Me.lkpVeiculo.FormularioPesquisa = Nothing
        'Me.lkpVeiculo.LimpaTexto = True
        'Me.lkpVeiculo.Location = New System.Drawing.Point(81, 71)
        'Me.lkpVeiculo.Name = "lkpVeiculo"
        'Me.lkpVeiculo.NomeCampoMsg = "fbLookUp"
        'Me.lkpVeiculo.Requerido = True
        'Me.lkpVeiculo.SelectID = -1
        'Me.lkpVeiculo.Size = New System.Drawing.Size(336, 20)
        'Me.lkpVeiculo.TabIndex = 504
        ''
        ''lkpProduto
        ''
        'Me.lkpProduto.ControlDB = Nothing
        'Me.lkpProduto.DataTableSelect = Nothing
        'Me.lkpProduto.FormularioPesquisa = Nothing
        'Me.lkpProduto.LimpaTexto = True
        'Me.lkpProduto.Location = New System.Drawing.Point(81, 97)
        'Me.lkpProduto.Name = "lkpProduto"
        'Me.lkpProduto.NomeCampoMsg = "fbLookUp"
        'Me.lkpProduto.Requerido = True
        'Me.lkpProduto.SelectID = -1
        'Me.lkpProduto.Size = New System.Drawing.Size(336, 20)
        'Me.lkpProduto.TabIndex = 505
        ''
        ''lkpOrigem
        ''
        'Me.lkpOrigem.ControlDB = Nothing
        'Me.lkpOrigem.DataTableSelect = Nothing
        'Me.lkpOrigem.FormularioPesquisa = Nothing
        'Me.lkpOrigem.LimpaTexto = True
        'Me.lkpOrigem.Location = New System.Drawing.Point(81, 123)
        'Me.lkpOrigem.Name = "lkpOrigem"
        'Me.lkpOrigem.NomeCampoMsg = "fbLookUp"
        'Me.lkpOrigem.Requerido = True
        'Me.lkpOrigem.SelectID = -1
        'Me.lkpOrigem.Size = New System.Drawing.Size(336, 20)
        'Me.lkpOrigem.TabIndex = 506
        ''
        ''frmCadPortaria
        ''
        'Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        'Me.ClientSize = New System.Drawing.Size(864, 555)
        'Me.ControlBox = False
        'Me.Controls.Add(Me.Panel1)
        'Me.Controls.Add(Me.pnlTop)
        'Me.Controls.Add(Me.pnlRodape)
        'Me.KeyPreview = True
        'Me.Name = "frmCadPortaria"
        'Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        'Me.Text = "Cadastro de Portaria"
        'Me.pnlRodape.ResumeLayout(False)
        'Me.pnlTop.ResumeLayout(False)
        'Me.pnlTop.PerformLayout()
        'Me.GroupBox1.ResumeLayout(False)
        'Me.GroupBox1.PerformLayout()
        'Me.Panel1.ResumeLayout(False)
        'Me.Panel1.PerformLayout()
        'Me.PVeiculo2.ResumeLayout(False)
        'CType(Me.DataSetRel1, System.ComponentModel.ISupportInitialize).EndInit()
        'Me.NF.ResumeLayout(False)
        'Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlRodape As Panel
    Friend WithEvents btnLimpar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnCadTAGs As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnExcluir As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnRelatorio As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pnlTop As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbStatusVeiculos As Label
    Friend WithEvents LbControle As Label
    Friend WithEvents PVeiculo2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelLat As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbSolicitacao As RadioButton
    Friend WithEvents rbEntrada As RadioButton
    Friend WithEvents rbAgendamento As RadioButton
    Friend WithEvents lblstatus As Label
    Friend WithEvents dtAgendamento As DateTimePicker
    Friend WithEvents dtDataEntrada As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtDataSaida As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTiket As TextBox
    Friend WithEvents txtLote As TextBox
    'Friend WithEvents DataSetRel1 As DataSetRel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtProdutor As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TabPageEX1 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents TabPageEX2 As Dotnetrix.Controls.TabPageEX
End Class
