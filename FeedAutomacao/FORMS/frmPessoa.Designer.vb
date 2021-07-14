<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPessoa
    Inherits FeedAutomacao.frmPadraoCadastro

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPessoa))
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.txtNome = New FeedAutomacao.fbTextBox()
        Me.FbLabel3 = New FeedAutomacao.fbLabel()
        Me.cbbTipoCad = New FeedAutomacao.fbComboBox()
        Me.FbLabel4 = New FeedAutomacao.fbLabel()
        Me.txtCGC = New FeedAutomacao.fbMaskBox()
        Me.cbbTipoPessoa = New FeedAutomacao.fbComboBox()
        Me.FbLabel5 = New FeedAutomacao.fbLabel()
        Me.pesContaCont = New FeedAutomacao.fbLookUpTreeView()
        Me.FbLabel6 = New FeedAutomacao.fbLabel()
        Me.tpeEmpresa = New FeedAutomacao.fbTabPage()
        Me.TabPageEX4 = New Dotnetrix.Controls.TabPageEX()
        Me.FbLabel45 = New FeedAutomacao.fbLabel()
        Me.txtAdicNoturno = New System.Windows.Forms.NumericUpDown()
        Me.FbLabel44 = New FeedAutomacao.fbLabel()
        Me.txtHrExtra = New System.Windows.Forms.NumericUpDown()
        Me.txtVlrHora = New FeedAutomacao.fbNumericBox()
        Me.lblVlrHora = New FeedAutomacao.fbLabel()
        Me.FbLabel43 = New FeedAutomacao.fbLabel()
        Me.txtComissao = New System.Windows.Forms.NumericUpDown()
        Me.FbLabel38 = New FeedAutomacao.fbLabel()
        Me.txtAdmissao = New FeedAutomacao.fbDate()
        Me.cbbCargo = New FeedAutomacao.fbComboBox()
        Me.FbLabel36 = New FeedAutomacao.fbLabel()
        Me.cbbSetor = New FeedAutomacao.fbComboBox()
        Me.FbLabel35 = New FeedAutomacao.fbLabel()
        Me.TabPageEX6 = New Dotnetrix.Controls.TabPageEX()
        Me.dgvLote = New FeedAutomacao.fbGridDados()
        Me.TabPageEX7 = New Dotnetrix.Controls.TabPageEX()
        Me.dgvRedeSocial = New FeedAutomacao.fbGridDados()
        Me.tpeEndereco = New Dotnetrix.Controls.TabPageEX()
        Me.txtNumero = New FeedAutomacao.fbTextBox()
        Me.btnBuscarCep = New FeedAutomacao.fbButtonVisual()
        Me.btnBuscaCep = New FeedAutomacao.fbButtonVisual()
        Me.FbLabel21 = New FeedAutomacao.fbLabel()
        Me.FbLabel20 = New FeedAutomacao.fbLabel()
        Me.txtComplemento = New FeedAutomacao.fbTextBox()
        Me.FbLabel19 = New FeedAutomacao.fbLabel()
        Me.txtBairro = New FeedAutomacao.fbTextBox()
        Me.FbLabel18 = New FeedAutomacao.fbLabel()
        Me.txtLogradouro = New FeedAutomacao.fbTextBox()
        Me.txtCidade = New FeedAutomacao.fbComboBox()
        Me.FbLabel17 = New FeedAutomacao.fbLabel()
        Me.txtEstado = New FeedAutomacao.fbComboBox()
        Me.FbLabel16 = New FeedAutomacao.fbLabel()
        Me.FbLabel15 = New FeedAutomacao.fbLabel()
        Me.txtCEP = New FeedAutomacao.fbMaskBox()
        Me.tpeInfComplementar = New Dotnetrix.Controls.TabPageEX()
        Me.FbGroupBox5 = New FeedAutomacao.fbGroupBox()
        Me.FbLabel53 = New FeedAutomacao.fbLabel()
        Me.txtBairroInterv = New FeedAutomacao.fbTextBox()
        Me.FbButtonVisual3 = New FeedAutomacao.fbButtonVisual()
        Me.FbButtonVisual4 = New FeedAutomacao.fbButtonVisual()
        Me.cbbCidadeInterv = New FeedAutomacao.fbComboBox()
        Me.FbLabel50 = New FeedAutomacao.fbLabel()
        Me.cbbEstadoInterv = New FeedAutomacao.fbComboBox()
        Me.FbLabel51 = New FeedAutomacao.fbLabel()
        Me.FbLabel52 = New FeedAutomacao.fbLabel()
        Me.txtCepInterv = New FeedAutomacao.fbMaskBox()
        Me.cbbEstadoCivilInterv = New FeedAutomacao.fbComboBox()
        Me.FbLabel49 = New FeedAutomacao.fbLabel()
        Me.FbLabel48 = New FeedAutomacao.fbLabel()
        Me.txtCPFInteerv = New FeedAutomacao.fbMaskBox()
        Me.FbLabel47 = New FeedAutomacao.fbLabel()
        Me.txtEnderecoInterv = New FeedAutomacao.fbTextBox()
        Me.FbLabel46 = New FeedAutomacao.fbLabel()
        Me.txtInterveniente = New FeedAutomacao.fbTextBox()
        Me.FbLabel40 = New FeedAutomacao.fbLabel()
        Me.txtCel2 = New FeedAutomacao.fbMaskBox()
        Me.FbLabel41 = New FeedAutomacao.fbLabel()
        Me.txtTelCom = New FeedAutomacao.fbMaskBox()
        Me.FbGroupBox4 = New FeedAutomacao.fbGroupBox()
        Me.rbInativo = New FeedAutomacao.fbRadioButton()
        Me.rbAtivo = New FeedAutomacao.fbRadioButton()
        Me.btnLimpar = New FeedAutomacao.fbButtonVisual()
        Me.FbLabel27 = New FeedAutomacao.fbLabel()
        Me.txtCel = New FeedAutomacao.fbMaskBox()
        Me.ptbImagem = New FeedAutomacao.fbPicturebox()
        Me.FbLabel26 = New FeedAutomacao.fbLabel()
        Me.txtTelefone = New FeedAutomacao.fbMaskBox()
        Me.FbLabel22 = New FeedAutomacao.fbLabel()
        Me.txtEmail = New FeedAutomacao.fbTextBox()
        Me.tpeConf = New Dotnetrix.Controls.TabPageEX()
        Me.FbLabel55 = New FeedAutomacao.fbLabel()
        Me.lkpDomicilio = New FeedAutomacao.fbLookUp()
        Me.ckbSenar = New FeedAutomacao.fbCheckBox()
        Me.ckbFunRural = New FeedAutomacao.fbCheckBox()
        Me.ckbICMS = New FeedAutomacao.fbCheckBox()
        Me.FbLabel28 = New FeedAutomacao.fbLabel()
        Me.txtObs = New FeedAutomacao.fbTextBox()
        Me.ckbFiscal = New FeedAutomacao.fbCheckBox()
        Me.cbbTipoFiscal = New FeedAutomacao.fbComboBox()
        Me.FbLabel7 = New FeedAutomacao.fbLabel()
        Me.TabPageEX2 = New Dotnetrix.Controls.TabPageEX()
        Me.FbGroupBox3 = New FeedAutomacao.fbGroupBox()
        Me.txtRg = New FeedAutomacao.fbTextBox()
        Me.FbLabel32 = New FeedAutomacao.fbLabel()
        Me.txtRGexp = New FeedAutomacao.fbTextBox()
        Me.FbLabel33 = New FeedAutomacao.fbLabel()
        Me.FbLabel34 = New FeedAutomacao.fbLabel()
        Me.txtDataExpRG = New FeedAutomacao.fbDate()
        Me.FbGroupBox2 = New FeedAutomacao.fbGroupBox()
        Me.txtCTPSSerie = New FeedAutomacao.fbTextBox()
        Me.txtCTPS = New FeedAutomacao.fbTextBox()
        Me.FbLabel13 = New FeedAutomacao.fbLabel()
        Me.FbLabel25 = New FeedAutomacao.fbLabel()
        Me.txtCTPSPis = New FeedAutomacao.fbTextBox()
        Me.FbLabel29 = New FeedAutomacao.fbLabel()
        Me.FbGroupBox1 = New FeedAutomacao.fbGroupBox()
        Me.txtCNH = New FeedAutomacao.fbTextBox()
        Me.FbLabel11 = New FeedAutomacao.fbLabel()
        Me.FbLabel14 = New FeedAutomacao.fbLabel()
        Me.txtDataHabilitacao = New FeedAutomacao.fbDate()
        Me.FbLabel23 = New FeedAutomacao.fbLabel()
        Me.txtDataVencimentoHab = New FeedAutomacao.fbDate()
        Me.txtCNHTipoCarteira = New FeedAutomacao.fbTextBox()
        Me.FbLabel24 = New FeedAutomacao.fbLabel()
        Me.TabPageEX3 = New Dotnetrix.Controls.TabPageEX()
        Me.FbLabel54 = New FeedAutomacao.fbLabel()
        Me.txtProfissao = New FeedAutomacao.fbTextBox()
        Me.FbLabel39 = New FeedAutomacao.fbLabel()
        Me.txtSenha = New FeedAutomacao.fbTextBox()
        Me.FbLabel37 = New FeedAutomacao.fbLabel()
        Me.txtDataNasc = New FeedAutomacao.fbDate()
        Me.FbLabel31 = New FeedAutomacao.fbLabel()
        Me.txtMae = New FeedAutomacao.fbTextBox()
        Me.FbLabel30 = New FeedAutomacao.fbLabel()
        Me.txtPai = New FeedAutomacao.fbTextBox()
        Me.TabPageEX5 = New Dotnetrix.Controls.TabPageEX()
        Me.dgvDom = New FeedAutomacao.fbGridview()
        Me.TabPageEX8 = New Dotnetrix.Controls.TabPageEX()
        Me.dgvAgente = New FeedAutomacao.fbGridDados()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.FbLabel8 = New FeedAutomacao.fbLabel()
        Me.FbLabel9 = New FeedAutomacao.fbLabel()
        Me.txtFantasia = New FeedAutomacao.fbTextBox()
        Me.FbLabel12 = New FeedAutomacao.fbLabel()
        Me.txtIE = New FeedAutomacao.fbTextBox()
        Me.txtCodigo = New FeedAutomacao.fbTextBox()
        Me.FbButtonVisual1 = New FeedAutomacao.fbButtonVisual()
        Me.FbButtonVisual2 = New FeedAutomacao.fbButtonVisual()
        Me.TAG = New System.Windows.Forms.Label()
        Me.cbbTAG = New FeedAutomacao.fbComboBox()
        Me.menuFiltro.SuspendLayout()
        Me.pnlCampos.SuspendLayout()
        Me.pnlBarra.SuspendLayout()
        Me.tpeEmpresa.SuspendLayout()
        Me.TabPageEX4.SuspendLayout()
        CType(Me.txtAdicNoturno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComissao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageEX6.SuspendLayout()
        Me.TabPageEX7.SuspendLayout()
        Me.tpeEndereco.SuspendLayout()
        Me.tpeInfComplementar.SuspendLayout()
        Me.FbGroupBox5.SuspendLayout()
        Me.FbGroupBox4.SuspendLayout()
        CType(Me.ptbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpeConf.SuspendLayout()
        Me.TabPageEX2.SuspendLayout()
        Me.FbGroupBox3.SuspendLayout()
        Me.FbGroupBox2.SuspendLayout()
        Me.FbGroupBox1.SuspendLayout()
        Me.TabPageEX3.SuspendLayout()
        Me.TabPageEX5.SuspendLayout()
        CType(Me.dgvDom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageEX8.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuFiltro
        '
        Me.menuFiltro.Controls.Add(Me.FbLabel12)
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(719, 55)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel12, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.pesDados, 0)
        '
        'pesDados
        '
        Me.pesDados.Location = New System.Drawing.Point(72, 29)
        Me.pesDados.Size = New System.Drawing.Size(626, 20)
        Me.pesDados.TabIndex = 0
        '
        'pnlCampos
        '
        Me.pnlCampos.Controls.Add(Me.cbbTAG)
        Me.pnlCampos.Controls.Add(Me.TAG)
        Me.pnlCampos.Controls.Add(Me.txtCodigo)
        Me.pnlCampos.Controls.Add(Me.txtIE)
        Me.pnlCampos.Controls.Add(Me.FbLabel9)
        Me.pnlCampos.Controls.Add(Me.txtFantasia)
        Me.pnlCampos.Controls.Add(Me.FbLabel8)
        Me.pnlCampos.Controls.Add(Me.FbLabel2)
        Me.pnlCampos.Controls.Add(Me.tpeEmpresa)
        Me.pnlCampos.Controls.Add(Me.cbbTipoPessoa)
        Me.pnlCampos.Controls.Add(Me.FbLabel5)
        Me.pnlCampos.Controls.Add(Me.txtCGC)
        Me.pnlCampos.Controls.Add(Me.FbLabel4)
        Me.pnlCampos.Controls.Add(Me.cbbTipoCad)
        Me.pnlCampos.Controls.Add(Me.FbLabel3)
        Me.pnlCampos.Controls.Add(Me.FbLabel1)
        Me.pnlCampos.Controls.Add(Me.txtNome)
        Me.pnlCampos.Location = New System.Drawing.Point(0, 55)
        Me.pnlCampos.Size = New System.Drawing.Size(719, 391)
        Me.pnlCampos.TabIndex = 0
        '
        'FbBarra1
        '
        Me.FbBarra1.CampoFoco = Me.txtNome
        Me.FbBarra1.frmCadastro = Me
        Me.FbBarra1.Location = New System.Drawing.Point(35, 5)
        Me.FbBarra1.Size = New System.Drawing.Size(541, 44)
        '
        'pnlBarra
        '
        Me.pnlBarra.Controls.Add(Me.FbButtonVisual1)
        Me.pnlBarra.Controls.Add(Me.FbButtonVisual2)
        Me.pnlBarra.Location = New System.Drawing.Point(0, 446)
        Me.pnlBarra.Size = New System.Drawing.Size(719, 53)
        Me.pnlBarra.Controls.SetChildIndex(Me.FbButtonVisual2, 0)
        Me.pnlBarra.Controls.SetChildIndex(Me.FbButtonVisual1, 0)
        Me.pnlBarra.Controls.SetChildIndex(Me.FbBarra1, 0)
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel1.Location = New System.Drawing.Point(32, 9)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(38, 13)
        Me.FbLabel1.TabIndex = 9
        Me.FbLabel1.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.LightBlue
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.botaoClear = False
        Me.txtNome.Campo = ""
        Me.txtNome.CaracterTipo = "U"
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.ControlDB = Nothing
        Me.txtNome.Location = New System.Drawing.Point(72, 6)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.NomeCampoMsg = "Nome"
        Me.txtNome.Requerido = True
        Me.txtNome.Size = New System.Drawing.Size(626, 20)
        Me.txtNome.TabIndex = 0
        Me.txtNome.Valor = Nothing
        Me.txtNome.valorVazio = ""
        '
        'FbLabel3
        '
        Me.FbLabel3.AutoSize = True
        Me.FbLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel3.Location = New System.Drawing.Point(39, 55)
        Me.FbLabel3.Name = "FbLabel3"
        Me.FbLabel3.Size = New System.Drawing.Size(31, 13)
        Me.FbLabel3.TabIndex = 12
        Me.FbLabel3.Text = "Tipo:"
        '
        'cbbTipoCad
        '
        Me.cbbTipoCad.AgrupadoPor = Nothing
        Me.cbbTipoCad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbTipoCad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbTipoCad.BackColor = System.Drawing.Color.LightBlue
        Me.cbbTipoCad.Campo = ""
        Me.cbbTipoCad.campoID = ""
        Me.cbbTipoCad.campoOrdem = Nothing
        Me.cbbTipoCad.campoRelacionamento = "TIPO"
        Me.cbbTipoCad.campoSelecionavel = "VALOR"
        Me.cbbTipoCad.campoSql = Nothing
        Me.cbbTipoCad.campoSqlID = Nothing
        Me.cbbTipoCad.carrega2Parametro = False
        Me.cbbTipoCad.carregaClick = True
        Me.cbbTipoCad.comDistinct = False
        Me.cbbTipoCad.ControlDB = Nothing
        Me.cbbTipoCad.DisplayMember = "Texto"
        Me.cbbTipoCad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTipoCad.Filtro = Nothing
        Me.cbbTipoCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbTipoCad.FormattingEnabled = True
        Me.cbbTipoCad.Location = New System.Drawing.Point(72, 52)
        Me.cbbTipoCad.Name = "cbbTipoCad"
        Me.cbbTipoCad.NomeCampoMsg = "TipoCad"
        Me.cbbTipoCad.Ordena = Nothing
        Me.cbbTipoCad.Requerido = True
        Me.cbbTipoCad.Size = New System.Drawing.Size(225, 21)
        Me.cbbTipoCad.TabelaRelacionamento = "TB_PARAMETRO"
        Me.cbbTipoCad.TabIndex = 2
        Me.cbbTipoCad.TextoSelecionar = "Tipo de Pessoa"
        Me.cbbTipoCad.Valor = Nothing
        Me.cbbTipoCad.ValorRelacionamento = "PES"
        Me.cbbTipoCad.ValorSelecionado = "-1"
        Me.cbbTipoCad.valorVazio = -1
        Me.cbbTipoCad.ValueMember = "Valor"
        '
        'FbLabel4
        '
        Me.FbLabel4.AutoSize = True
        Me.FbLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel4.Location = New System.Drawing.Point(399, 55)
        Me.FbLabel4.Name = "FbLabel4"
        Me.FbLabel4.Size = New System.Drawing.Size(62, 13)
        Me.FbLabel4.TabIndex = 14
        Me.FbLabel4.Text = "CNPJ/CPF:"
        '
        'txtCGC
        '
        Me.txtCGC.BackColor = System.Drawing.Color.LightBlue
        Me.txtCGC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCGC.ControlDB = Nothing
        Me.txtCGC.DB = Nothing
        Me.txtCGC.Location = New System.Drawing.Point(464, 52)
        Me.txtCGC.Mask = "99,999,999/9999-99"
        Me.txtCGC.Name = "txtCGC"
        Me.txtCGC.NomeCampoMsg = "CGC"
        Me.txtCGC.Requerido = True
        Me.txtCGC.Size = New System.Drawing.Size(234, 20)
        Me.txtCGC.TabIndex = 3
        Me.txtCGC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'cbbTipoPessoa
        '
        Me.cbbTipoPessoa.AgrupadoPor = Nothing
        Me.cbbTipoPessoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbTipoPessoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbTipoPessoa.BackColor = System.Drawing.Color.LightBlue
        Me.cbbTipoPessoa.Campo = ""
        Me.cbbTipoPessoa.campoID = "ID"
        Me.cbbTipoPessoa.campoOrdem = Nothing
        Me.cbbTipoPessoa.campoRelacionamento = Nothing
        Me.cbbTipoPessoa.campoSelecionavel = "Nome"
        Me.cbbTipoPessoa.campoSql = Nothing
        Me.cbbTipoPessoa.campoSqlID = Nothing
        Me.cbbTipoPessoa.carrega2Parametro = False
        Me.cbbTipoPessoa.carregaClick = True
        Me.cbbTipoPessoa.comDistinct = False
        Me.cbbTipoPessoa.ControlDB = Nothing
        Me.cbbTipoPessoa.DisplayMember = "Texto"
        Me.cbbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTipoPessoa.Filtro = Nothing
        Me.cbbTipoPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbTipoPessoa.FormattingEnabled = True
        Me.cbbTipoPessoa.Location = New System.Drawing.Point(72, 77)
        Me.cbbTipoPessoa.Name = "cbbTipoPessoa"
        Me.cbbTipoPessoa.NomeCampoMsg = "TipoPessoa"
        Me.cbbTipoPessoa.Ordena = Nothing
        Me.cbbTipoPessoa.Requerido = True
        Me.cbbTipoPessoa.Size = New System.Drawing.Size(225, 21)
        Me.cbbTipoPessoa.TabelaRelacionamento = "TB_TIPO_PESSOA"
        Me.cbbTipoPessoa.TabIndex = 5
        Me.cbbTipoPessoa.TextoSelecionar = "Selecione um Grupo de Pessoa"
        Me.cbbTipoPessoa.Valor = Nothing
        Me.cbbTipoPessoa.ValorRelacionamento = Nothing
        Me.cbbTipoPessoa.ValorSelecionado = "-1"
        Me.cbbTipoPessoa.valorVazio = -1
        Me.cbbTipoPessoa.ValueMember = "Valor"
        '
        'FbLabel5
        '
        Me.FbLabel5.AutoSize = True
        Me.FbLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel5.Location = New System.Drawing.Point(20, 82)
        Me.FbLabel5.Name = "FbLabel5"
        Me.FbLabel5.Size = New System.Drawing.Size(39, 13)
        Me.FbLabel5.TabIndex = 16
        Me.FbLabel5.Text = "Grupo:"
        '
        'pesContaCont
        '
        Me.pesContaCont.ControlDB = Nothing
        Me.pesContaCont.DB = Nothing
        Me.pesContaCont.Location = New System.Drawing.Point(84, 30)
        Me.pesContaCont.Name = "pesContaCont"
        Me.pesContaCont.NomeCampoMsg = "fbLookUp"
        Me.pesContaCont.Requerido = False
        Me.pesContaCont.SelectID = -1
        Me.pesContaCont.Size = New System.Drawing.Size(510, 20)
        Me.pesContaCont.TabIndex = 1
        '
        'FbLabel6
        '
        Me.FbLabel6.AutoSize = True
        Me.FbLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel6.Location = New System.Drawing.Point(4, 33)
        Me.FbLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FbLabel6.Name = "FbLabel6"
        Me.FbLabel6.Size = New System.Drawing.Size(79, 13)
        Me.FbLabel6.TabIndex = 162
        Me.FbLabel6.Text = "Conta Contábil:"
        '
        'tpeEmpresa
        '
        Me.tpeEmpresa.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatTab
        Me.tpeEmpresa.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tpeEmpresa.Controls.Add(Me.tpeConf)
        Me.tpeEmpresa.Controls.Add(Me.TabPageEX4)
        Me.tpeEmpresa.Controls.Add(Me.TabPageEX6)
        Me.tpeEmpresa.Controls.Add(Me.TabPageEX7)
        Me.tpeEmpresa.Controls.Add(Me.tpeEndereco)
        Me.tpeEmpresa.Controls.Add(Me.tpeInfComplementar)
        Me.tpeEmpresa.Controls.Add(Me.TabPageEX2)
        Me.tpeEmpresa.Controls.Add(Me.TabPageEX3)
        Me.tpeEmpresa.Controls.Add(Me.TabPageEX5)
        Me.tpeEmpresa.Controls.Add(Me.TabPageEX8)
        Me.tpeEmpresa.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tpeEmpresa.Location = New System.Drawing.Point(0, 171)
        Me.tpeEmpresa.Name = "tpeEmpresa"
        Me.tpeEmpresa.SelectedIndex = 5
        Me.tpeEmpresa.Size = New System.Drawing.Size(719, 220)
        Me.tpeEmpresa.TabIndex = 10
        Me.tpeEmpresa.UseVisualStyles = False
        '
        'TabPageEX4
        '
        Me.TabPageEX4.Controls.Add(Me.FbLabel45)
        Me.TabPageEX4.Controls.Add(Me.txtAdicNoturno)
        Me.TabPageEX4.Controls.Add(Me.FbLabel44)
        Me.TabPageEX4.Controls.Add(Me.txtHrExtra)
        Me.TabPageEX4.Controls.Add(Me.txtVlrHora)
        Me.TabPageEX4.Controls.Add(Me.lblVlrHora)
        Me.TabPageEX4.Controls.Add(Me.FbLabel43)
        Me.TabPageEX4.Controls.Add(Me.txtComissao)
        Me.TabPageEX4.Controls.Add(Me.FbLabel38)
        Me.TabPageEX4.Controls.Add(Me.txtAdmissao)
        Me.TabPageEX4.Controls.Add(Me.cbbCargo)
        Me.TabPageEX4.Controls.Add(Me.FbLabel36)
        Me.TabPageEX4.Controls.Add(Me.cbbSetor)
        Me.TabPageEX4.Controls.Add(Me.FbLabel35)
        Me.TabPageEX4.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEX4.Name = "TabPageEX4"
        Me.TabPageEX4.Size = New System.Drawing.Size(690, 191)
        Me.TabPageEX4.TabIndex = 6
        Me.TabPageEX4.Text = "Dados Emp."
        '
        'FbLabel45
        '
        Me.FbLabel45.AutoSize = True
        Me.FbLabel45.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel45.Location = New System.Drawing.Point(185, 120)
        Me.FbLabel45.Name = "FbLabel45"
        Me.FbLabel45.Size = New System.Drawing.Size(89, 13)
        Me.FbLabel45.TabIndex = 283
        Me.FbLabel45.Text = "Adic.Noturno (%):"
        '
        'txtAdicNoturno
        '
        Me.txtAdicNoturno.DecimalPlaces = 2
        Me.txtAdicNoturno.Location = New System.Drawing.Point(280, 117)
        Me.txtAdicNoturno.Name = "txtAdicNoturno"
        Me.txtAdicNoturno.Size = New System.Drawing.Size(52, 20)
        Me.txtAdicNoturno.TabIndex = 282
        '
        'FbLabel44
        '
        Me.FbLabel44.AutoSize = True
        Me.FbLabel44.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel44.Location = New System.Drawing.Point(209, 94)
        Me.FbLabel44.Name = "FbLabel44"
        Me.FbLabel44.Size = New System.Drawing.Size(65, 13)
        Me.FbLabel44.TabIndex = 281
        Me.FbLabel44.Text = "Hr.Extra (%):"
        '
        'txtHrExtra
        '
        Me.txtHrExtra.DecimalPlaces = 2
        Me.txtHrExtra.Location = New System.Drawing.Point(280, 91)
        Me.txtHrExtra.Name = "txtHrExtra"
        Me.txtHrExtra.Size = New System.Drawing.Size(52, 20)
        Me.txtHrExtra.TabIndex = 280
        '
        'txtVlrHora
        '
        Me.txtVlrHora.BackColor = System.Drawing.Color.White
        Me.txtVlrHora.ColorNumerosNegativos = System.Drawing.Color.Red
        Me.txtVlrHora.ControlDB = Nothing
        Me.txtVlrHora.CurrencySimbol = True
        Me.txtVlrHora.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtVlrHora.DB = Nothing
        Me.txtVlrHora.DigitosDespuesDelSimboloDecimal = 2
        Me.txtVlrHora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVlrHora.isCurrencySimbol = True
        Me.txtVlrHora.isNegativeValue = False
        Me.txtVlrHora.Location = New System.Drawing.Point(68, 91)
        Me.txtVlrHora.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtVlrHora.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.txtVlrHora.MudarCorBloqueio = True
        Me.txtVlrHora.MudarCorFoco = False
        Me.txtVlrHora.Name = "txtVlrHora"
        Me.txtVlrHora.NegativeNumberColor = System.Drawing.Color.Red
        Me.txtVlrHora.NomeCampoMsg = "CurrencyBox"
        Me.txtVlrHora.PermiteCurrencySimbol = True
        Me.txtVlrHora.PermiteNumerosNegativos = False
        Me.txtVlrHora.QtdDigitos = 2
        Me.txtVlrHora.Requerido = False
        Me.txtVlrHora.ShowThousandSeparator = False
        Me.txtVlrHora.Size = New System.Drawing.Size(110, 20)
        Me.txtVlrHora.TabIndex = 278
        Me.txtVlrHora.Text = "0,00"
        Me.txtVlrHora.ValorMaximo = 1000000.0R
        Me.txtVlrHora.ValorMinimo = -1000000.0R
        '
        'lblVlrHora
        '
        Me.lblVlrHora.AutoSize = True
        Me.lblVlrHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblVlrHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblVlrHora.Location = New System.Drawing.Point(17, 98)
        Me.lblVlrHora.Name = "lblVlrHora"
        Me.lblVlrHora.Size = New System.Drawing.Size(48, 13)
        Me.lblVlrHora.TabIndex = 279
        Me.lblVlrHora.Text = "Vlr Hora:"
        '
        'FbLabel43
        '
        Me.FbLabel43.AutoSize = True
        Me.FbLabel43.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel43.Location = New System.Drawing.Point(205, 67)
        Me.FbLabel43.Name = "FbLabel43"
        Me.FbLabel43.Size = New System.Drawing.Size(72, 13)
        Me.FbLabel43.TabIndex = 277
        Me.FbLabel43.Text = "Comissão (%):"
        '
        'txtComissao
        '
        Me.txtComissao.DecimalPlaces = 2
        Me.txtComissao.Location = New System.Drawing.Point(280, 64)
        Me.txtComissao.Name = "txtComissao"
        Me.txtComissao.Size = New System.Drawing.Size(52, 20)
        Me.txtComissao.TabIndex = 276
        '
        'FbLabel38
        '
        Me.FbLabel38.AutoSize = True
        Me.FbLabel38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel38.Location = New System.Drawing.Point(11, 67)
        Me.FbLabel38.Name = "FbLabel38"
        Me.FbLabel38.Size = New System.Drawing.Size(55, 13)
        Me.FbLabel38.TabIndex = 255
        Me.FbLabel38.Text = "Admissão:"
        Me.FbLabel38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAdmissao
        '
        Me.txtAdmissao.BackColor = System.Drawing.Color.White
        Me.txtAdmissao.ControlDB = Nothing
        Me.txtAdmissao.CustomFormat = "dd/MM/yyyy"
        Me.txtAdmissao.DataAtual = False
        Me.txtAdmissao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtAdmissao.Location = New System.Drawing.Point(68, 64)
        Me.txtAdmissao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdmissao.Name = "txtAdmissao"
        Me.txtAdmissao.NomeCampoMsg = "Admissao"
        Me.txtAdmissao.Requerido = False
        Me.txtAdmissao.Size = New System.Drawing.Size(110, 20)
        Me.txtAdmissao.TabIndex = 254
        Me.txtAdmissao.Value = New Date(2012, 8, 7, 9, 33, 57, 170)
        '
        'cbbCargo
        '
        Me.cbbCargo.AgrupadoPor = Nothing
        Me.cbbCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbCargo.BackColor = System.Drawing.Color.White
        Me.cbbCargo.Campo = ""
        Me.cbbCargo.campoID = "ID"
        Me.cbbCargo.campoOrdem = Nothing
        Me.cbbCargo.campoRelacionamento = Nothing
        Me.cbbCargo.campoSelecionavel = "Nome"
        Me.cbbCargo.campoSql = Nothing
        Me.cbbCargo.campoSqlID = Nothing
        Me.cbbCargo.carrega2Parametro = False
        Me.cbbCargo.carregaClick = True
        Me.cbbCargo.comDistinct = False
        Me.cbbCargo.ControlDB = Nothing
        Me.cbbCargo.DisplayMember = "Texto"
        Me.cbbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbCargo.Filtro = Nothing
        Me.cbbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbCargo.FormattingEnabled = True
        Me.cbbCargo.Location = New System.Drawing.Point(68, 36)
        Me.cbbCargo.Name = "cbbCargo"
        Me.cbbCargo.NomeCampoMsg = "Cargo"
        Me.cbbCargo.Ordena = Nothing
        Me.cbbCargo.Requerido = False
        Me.cbbCargo.Size = New System.Drawing.Size(526, 21)
        Me.cbbCargo.TabelaRelacionamento = "TB_CARGO"
        Me.cbbCargo.TabIndex = 33
        Me.cbbCargo.TextoSelecionar = "Selecione o Cargo"
        Me.cbbCargo.Valor = Nothing
        Me.cbbCargo.ValorRelacionamento = Nothing
        Me.cbbCargo.ValorSelecionado = "-1"
        Me.cbbCargo.valorVazio = -1
        Me.cbbCargo.ValueMember = "Valor"
        '
        'FbLabel36
        '
        Me.FbLabel36.AutoSize = True
        Me.FbLabel36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel36.Location = New System.Drawing.Point(28, 39)
        Me.FbLabel36.Name = "FbLabel36"
        Me.FbLabel36.Size = New System.Drawing.Size(38, 13)
        Me.FbLabel36.TabIndex = 34
        Me.FbLabel36.Text = "Cargo:"
        '
        'cbbSetor
        '
        Me.cbbSetor.AgrupadoPor = Nothing
        Me.cbbSetor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbSetor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbSetor.BackColor = System.Drawing.Color.White
        Me.cbbSetor.Campo = ""
        Me.cbbSetor.campoID = "ID"
        Me.cbbSetor.campoOrdem = Nothing
        Me.cbbSetor.campoRelacionamento = Nothing
        Me.cbbSetor.campoSelecionavel = "Nome"
        Me.cbbSetor.campoSql = Nothing
        Me.cbbSetor.campoSqlID = Nothing
        Me.cbbSetor.carrega2Parametro = False
        Me.cbbSetor.carregaClick = True
        Me.cbbSetor.comDistinct = False
        Me.cbbSetor.ControlDB = Nothing
        Me.cbbSetor.DisplayMember = "Texto"
        Me.cbbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSetor.Filtro = Nothing
        Me.cbbSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbSetor.FormattingEnabled = True
        Me.cbbSetor.Location = New System.Drawing.Point(68, 10)
        Me.cbbSetor.Name = "cbbSetor"
        Me.cbbSetor.NomeCampoMsg = "Setor"
        Me.cbbSetor.Ordena = Nothing
        Me.cbbSetor.Requerido = False
        Me.cbbSetor.Size = New System.Drawing.Size(526, 21)
        Me.cbbSetor.TabelaRelacionamento = "TB_SETOR_PRODUCAO"
        Me.cbbSetor.TabIndex = 31
        Me.cbbSetor.TextoSelecionar = "Selecione o Setor"
        Me.cbbSetor.Valor = Nothing
        Me.cbbSetor.ValorRelacionamento = Nothing
        Me.cbbSetor.ValorSelecionado = "-1"
        Me.cbbSetor.valorVazio = -1
        Me.cbbSetor.ValueMember = "Valor"
        '
        'FbLabel35
        '
        Me.FbLabel35.AutoSize = True
        Me.FbLabel35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel35.Location = New System.Drawing.Point(30, 13)
        Me.FbLabel35.Name = "FbLabel35"
        Me.FbLabel35.Size = New System.Drawing.Size(35, 13)
        Me.FbLabel35.TabIndex = 32
        Me.FbLabel35.Text = "Setor:"
        '
        'TabPageEX6
        '
        Me.TabPageEX6.Controls.Add(Me.dgvLote)
        Me.TabPageEX6.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEX6.Name = "TabPageEX6"
        Me.TabPageEX6.Size = New System.Drawing.Size(690, 191)
        Me.TabPageEX6.TabIndex = 8
        Me.TabPageEX6.Text = "Financeiro"
        '
        'dgvLote
        '
        Me.dgvLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvLote.campoID = "ID"
        Me.dgvLote.camposVisiveis = Nothing
        Me.dgvLote.DataTable = Nothing
        Me.dgvLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLote.Formulario = Nothing
        Me.dgvLote.FormularioPai = Nothing
        Me.dgvLote.FormularioPaiCad = Nothing
        Me.dgvLote.IDItem = -1
        Me.dgvLote.IDRelacionamento = -1
        Me.dgvLote.liberaEditar = True
        Me.dgvLote.liberaExcluir = True
        Me.dgvLote.liberaInserir = True
        Me.dgvLote.Location = New System.Drawing.Point(0, 0)
        Me.dgvLote.Name = "dgvLote"
        Me.dgvLote.Parametro = ""
        Me.dgvLote.SalvarDadosForm = False
        Me.dgvLote.showPrint = False
        Me.dgvLote.Size = New System.Drawing.Size(690, 191)
        Me.dgvLote.SqlDados = ""
        Me.dgvLote.TabIndex = 2
        Me.dgvLote.textPrint = ""
        Me.dgvLote.TotalRegistrosVisivel = True
        Me.dgvLote.usarSalvar = True
        Me.dgvLote.visualizarBarra = True
        '
        'TabPageEX7
        '
        Me.TabPageEX7.Controls.Add(Me.dgvRedeSocial)
        Me.TabPageEX7.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEX7.Name = "TabPageEX7"
        Me.TabPageEX7.Size = New System.Drawing.Size(690, 191)
        Me.TabPageEX7.TabIndex = 9
        Me.TabPageEX7.Text = "Redes Sociais"
        '
        'dgvRedeSocial
        '
        Me.dgvRedeSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvRedeSocial.campoID = "ID"
        Me.dgvRedeSocial.camposVisiveis = Nothing
        Me.dgvRedeSocial.DataTable = Nothing
        Me.dgvRedeSocial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRedeSocial.Formulario = Nothing
        Me.dgvRedeSocial.FormularioPai = Nothing
        Me.dgvRedeSocial.FormularioPaiCad = Nothing
        Me.dgvRedeSocial.IDItem = -1
        Me.dgvRedeSocial.IDRelacionamento = -1
        Me.dgvRedeSocial.liberaEditar = True
        Me.dgvRedeSocial.liberaExcluir = True
        Me.dgvRedeSocial.liberaInserir = True
        Me.dgvRedeSocial.Location = New System.Drawing.Point(0, 0)
        Me.dgvRedeSocial.Name = "dgvRedeSocial"
        Me.dgvRedeSocial.Parametro = ""
        Me.dgvRedeSocial.SalvarDadosForm = False
        Me.dgvRedeSocial.showPrint = False
        Me.dgvRedeSocial.Size = New System.Drawing.Size(690, 191)
        Me.dgvRedeSocial.SqlDados = ""
        Me.dgvRedeSocial.TabIndex = 3
        Me.dgvRedeSocial.textPrint = ""
        Me.dgvRedeSocial.TotalRegistrosVisivel = False
        Me.dgvRedeSocial.usarSalvar = True
        Me.dgvRedeSocial.visualizarBarra = True
        '
        'tpeEndereco
        '
        Me.tpeEndereco.Controls.Add(Me.txtNumero)
        Me.tpeEndereco.Controls.Add(Me.btnBuscarCep)
        Me.tpeEndereco.Controls.Add(Me.btnBuscaCep)
        Me.tpeEndereco.Controls.Add(Me.FbLabel21)
        Me.tpeEndereco.Controls.Add(Me.FbLabel20)
        Me.tpeEndereco.Controls.Add(Me.txtComplemento)
        Me.tpeEndereco.Controls.Add(Me.FbLabel19)
        Me.tpeEndereco.Controls.Add(Me.txtBairro)
        Me.tpeEndereco.Controls.Add(Me.FbLabel18)
        Me.tpeEndereco.Controls.Add(Me.txtLogradouro)
        Me.tpeEndereco.Controls.Add(Me.txtCidade)
        Me.tpeEndereco.Controls.Add(Me.FbLabel17)
        Me.tpeEndereco.Controls.Add(Me.txtEstado)
        Me.tpeEndereco.Controls.Add(Me.FbLabel16)
        Me.tpeEndereco.Controls.Add(Me.FbLabel15)
        Me.tpeEndereco.Controls.Add(Me.txtCEP)
        Me.tpeEndereco.Location = New System.Drawing.Point(4, 25)
        Me.tpeEndereco.Name = "tpeEndereco"
        Me.tpeEndereco.Size = New System.Drawing.Size(690, 191)
        Me.tpeEndereco.TabIndex = 0
        Me.tpeEndereco.Text = "End."
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.botaoClear = False
        Me.txtNumero.Campo = ""
        Me.txtNumero.CaracterTipo = "U"
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.ControlDB = Nothing
        Me.txtNumero.Location = New System.Drawing.Point(512, 56)
        Me.txtNumero.MaxLength = 100
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.NomeCampoMsg = "Bairro"
        Me.txtNumero.Requerido = False
        Me.txtNumero.Size = New System.Drawing.Size(82, 20)
        Me.txtNumero.TabIndex = 52
        Me.txtNumero.Valor = Nothing
        Me.txtNumero.valorVazio = ""
        '
        'btnBuscarCep
        '
        Me.btnBuscarCep.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBuscarCep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCep.ForeColor = System.Drawing.Color.White
        Me.btnBuscarCep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarCep.Location = New System.Drawing.Point(484, 32)
        Me.btnBuscarCep.Name = "btnBuscarCep"
        Me.btnBuscarCep.Size = New System.Drawing.Size(82, 20)
        Me.btnBuscarCep.TabIndex = 51
        Me.btnBuscarCep.Text = "Buscar Cep."
        '
        'btnBuscaCep
        '
        Me.btnBuscaCep.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBuscaCep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaCep.ForeColor = System.Drawing.Color.White
        Me.btnBuscaCep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscaCep.Location = New System.Drawing.Point(145, 8)
        Me.btnBuscaCep.Name = "btnBuscaCep"
        Me.btnBuscaCep.Size = New System.Drawing.Size(82, 20)
        Me.btnBuscaCep.TabIndex = 1
        Me.btnBuscaCep.Text = "Buscar Inf."
        '
        'FbLabel21
        '
        Me.FbLabel21.AutoSize = True
        Me.FbLabel21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel21.Location = New System.Drawing.Point(485, 60)
        Me.FbLabel21.Name = "FbLabel21"
        Me.FbLabel21.Size = New System.Drawing.Size(25, 13)
        Me.FbLabel21.TabIndex = 5
        Me.FbLabel21.Text = "Nº.:"
        '
        'FbLabel20
        '
        Me.FbLabel20.AutoSize = True
        Me.FbLabel20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel20.Location = New System.Drawing.Point(274, 82)
        Me.FbLabel20.Name = "FbLabel20"
        Me.FbLabel20.Size = New System.Drawing.Size(74, 13)
        Me.FbLabel20.TabIndex = 50
        Me.FbLabel20.Text = "Complemento:"
        '
        'txtComplemento
        '
        Me.txtComplemento.BackColor = System.Drawing.Color.White
        Me.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComplemento.botaoClear = False
        Me.txtComplemento.Campo = ""
        Me.txtComplemento.CaracterTipo = "U"
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.ControlDB = Nothing
        Me.txtComplemento.Location = New System.Drawing.Point(350, 79)
        Me.txtComplemento.MaxLength = 100
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.NomeCampoMsg = "Complemento"
        Me.txtComplemento.Requerido = False
        Me.txtComplemento.Size = New System.Drawing.Size(244, 20)
        Me.txtComplemento.TabIndex = 7
        Me.txtComplemento.Valor = Nothing
        Me.txtComplemento.valorVazio = ""
        '
        'FbLabel19
        '
        Me.FbLabel19.AutoSize = True
        Me.FbLabel19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel19.Location = New System.Drawing.Point(32, 81)
        Me.FbLabel19.Name = "FbLabel19"
        Me.FbLabel19.Size = New System.Drawing.Size(37, 13)
        Me.FbLabel19.TabIndex = 48
        Me.FbLabel19.Text = "Bairro:"
        '
        'txtBairro
        '
        Me.txtBairro.BackColor = System.Drawing.Color.LightBlue
        Me.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBairro.botaoClear = False
        Me.txtBairro.Campo = ""
        Me.txtBairro.CaracterTipo = "U"
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.ControlDB = Nothing
        Me.txtBairro.Location = New System.Drawing.Point(72, 79)
        Me.txtBairro.MaxLength = 100
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.NomeCampoMsg = "Bairro"
        Me.txtBairro.Requerido = True
        Me.txtBairro.Size = New System.Drawing.Size(155, 20)
        Me.txtBairro.TabIndex = 6
        Me.txtBairro.Valor = Nothing
        Me.txtBairro.valorVazio = ""
        '
        'FbLabel18
        '
        Me.FbLabel18.AutoSize = True
        Me.FbLabel18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel18.Location = New System.Drawing.Point(5, 59)
        Me.FbLabel18.Name = "FbLabel18"
        Me.FbLabel18.Size = New System.Drawing.Size(64, 13)
        Me.FbLabel18.TabIndex = 46
        Me.FbLabel18.Text = "Logradouro:"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.BackColor = System.Drawing.Color.LightBlue
        Me.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogradouro.botaoClear = False
        Me.txtLogradouro.Campo = ""
        Me.txtLogradouro.CaracterTipo = "U"
        Me.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogradouro.ControlDB = Nothing
        Me.txtLogradouro.Location = New System.Drawing.Point(72, 56)
        Me.txtLogradouro.MaxLength = 200
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.NomeCampoMsg = "Logradouro"
        Me.txtLogradouro.Requerido = True
        Me.txtLogradouro.Size = New System.Drawing.Size(407, 20)
        Me.txtLogradouro.TabIndex = 4
        Me.txtLogradouro.Valor = Nothing
        Me.txtLogradouro.valorVazio = ""
        '
        'txtCidade
        '
        Me.txtCidade.AgrupadoPor = Nothing
        Me.txtCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtCidade.BackColor = System.Drawing.Color.LightBlue
        Me.txtCidade.Campo = ""
        Me.txtCidade.campoID = "CODIGO"
        Me.txtCidade.campoOrdem = Nothing
        Me.txtCidade.campoRelacionamento = Nothing
        Me.txtCidade.campoSelecionavel = "NOME"
        Me.txtCidade.campoSql = Nothing
        Me.txtCidade.campoSqlID = Nothing
        Me.txtCidade.carrega2Parametro = False
        Me.txtCidade.carregaClick = True
        Me.txtCidade.comDistinct = False
        Me.txtCidade.ControlDB = Nothing
        Me.txtCidade.DisplayMember = "Texto"
        Me.txtCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCidade.Filtro = Nothing
        Me.txtCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtCidade.FormattingEnabled = True
        Me.txtCidade.Location = New System.Drawing.Point(279, 31)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.NomeCampoMsg = "txtCidade"
        Me.txtCidade.Ordena = Nothing
        Me.txtCidade.Requerido = True
        Me.txtCidade.Size = New System.Drawing.Size(200, 21)
        Me.txtCidade.TabelaRelacionamento = "TB_CIDADE"
        Me.txtCidade.TabIndex = 3
        Me.txtCidade.TextoSelecionar = "Selecione a Cidade"
        Me.txtCidade.Valor = Nothing
        Me.txtCidade.ValorRelacionamento = Nothing
        Me.txtCidade.ValorSelecionado = "-1"
        Me.txtCidade.valorVazio = -1
        Me.txtCidade.ValueMember = "Valor"
        '
        'FbLabel17
        '
        Me.FbLabel17.AutoSize = True
        Me.FbLabel17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel17.Location = New System.Drawing.Point(234, 35)
        Me.FbLabel17.Name = "FbLabel17"
        Me.FbLabel17.Size = New System.Drawing.Size(43, 13)
        Me.FbLabel17.TabIndex = 44
        Me.FbLabel17.Text = "Cidade:"
        '
        'txtEstado
        '
        Me.txtEstado.AgrupadoPor = Nothing
        Me.txtEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtEstado.BackColor = System.Drawing.Color.LightBlue
        Me.txtEstado.Campo = ""
        Me.txtEstado.campoID = "CODIGO"
        Me.txtEstado.campoOrdem = Nothing
        Me.txtEstado.campoRelacionamento = Nothing
        Me.txtEstado.campoSelecionavel = "NOME"
        Me.txtEstado.campoSql = Nothing
        Me.txtEstado.campoSqlID = Nothing
        Me.txtEstado.carrega2Parametro = False
        Me.txtEstado.carregaClick = True
        Me.txtEstado.comDistinct = False
        Me.txtEstado.ControlDB = Nothing
        Me.txtEstado.DisplayMember = "Texto"
        Me.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtEstado.Filtro = Nothing
        Me.txtEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtEstado.FormattingEnabled = True
        Me.txtEstado.Location = New System.Drawing.Point(72, 31)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.NomeCampoMsg = "txtEstado"
        Me.txtEstado.Ordena = Nothing
        Me.txtEstado.Requerido = True
        Me.txtEstado.Size = New System.Drawing.Size(155, 21)
        Me.txtEstado.TabelaRelacionamento = "TB_ESTADO"
        Me.txtEstado.TabIndex = 2
        Me.txtEstado.TextoSelecionar = "Selecione o Estado"
        Me.txtEstado.Valor = Nothing
        Me.txtEstado.ValorRelacionamento = Nothing
        Me.txtEstado.ValorSelecionado = "-1"
        Me.txtEstado.valorVazio = -1
        Me.txtEstado.ValueMember = "Valor"
        '
        'FbLabel16
        '
        Me.FbLabel16.AutoSize = True
        Me.FbLabel16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel16.Location = New System.Drawing.Point(26, 34)
        Me.FbLabel16.Name = "FbLabel16"
        Me.FbLabel16.Size = New System.Drawing.Size(43, 13)
        Me.FbLabel16.TabIndex = 42
        Me.FbLabel16.Text = "Estado:"
        '
        'FbLabel15
        '
        Me.FbLabel15.AutoSize = True
        Me.FbLabel15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel15.Location = New System.Drawing.Point(38, 11)
        Me.FbLabel15.Name = "FbLabel15"
        Me.FbLabel15.Size = New System.Drawing.Size(31, 13)
        Me.FbLabel15.TabIndex = 40
        Me.FbLabel15.Text = "CEP:"
        '
        'txtCEP
        '
        Me.txtCEP.BackColor = System.Drawing.Color.LightBlue
        Me.txtCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCEP.ControlDB = Nothing
        Me.txtCEP.DB = Nothing
        Me.txtCEP.Location = New System.Drawing.Point(72, 8)
        Me.txtCEP.Mask = "99,999-999"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.NomeCampoMsg = "CEP"
        Me.txtCEP.Requerido = True
        Me.txtCEP.Size = New System.Drawing.Size(70, 20)
        Me.txtCEP.TabIndex = 0
        Me.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'tpeInfComplementar
        '
        Me.tpeInfComplementar.Controls.Add(Me.FbGroupBox5)
        Me.tpeInfComplementar.Controls.Add(Me.FbLabel40)
        Me.tpeInfComplementar.Controls.Add(Me.txtCel2)
        Me.tpeInfComplementar.Controls.Add(Me.FbLabel41)
        Me.tpeInfComplementar.Controls.Add(Me.txtTelCom)
        Me.tpeInfComplementar.Controls.Add(Me.FbGroupBox4)
        Me.tpeInfComplementar.Controls.Add(Me.btnLimpar)
        Me.tpeInfComplementar.Controls.Add(Me.FbLabel27)
        Me.tpeInfComplementar.Controls.Add(Me.txtCel)
        Me.tpeInfComplementar.Controls.Add(Me.ptbImagem)
        Me.tpeInfComplementar.Controls.Add(Me.FbLabel26)
        Me.tpeInfComplementar.Controls.Add(Me.txtTelefone)
        Me.tpeInfComplementar.Controls.Add(Me.FbLabel22)
        Me.tpeInfComplementar.Controls.Add(Me.txtEmail)
        Me.tpeInfComplementar.Location = New System.Drawing.Point(4, 25)
        Me.tpeInfComplementar.Name = "tpeInfComplementar"
        Me.tpeInfComplementar.Size = New System.Drawing.Size(690, 191)
        Me.tpeInfComplementar.TabIndex = 3
        Me.tpeInfComplementar.Text = "Inf. Cpl."
        '
        'FbGroupBox5
        '
        Me.FbGroupBox5.Controls.Add(Me.FbLabel53)
        Me.FbGroupBox5.Controls.Add(Me.txtBairroInterv)
        Me.FbGroupBox5.Controls.Add(Me.FbButtonVisual3)
        Me.FbGroupBox5.Controls.Add(Me.FbButtonVisual4)
        Me.FbGroupBox5.Controls.Add(Me.cbbCidadeInterv)
        Me.FbGroupBox5.Controls.Add(Me.FbLabel50)
        Me.FbGroupBox5.Controls.Add(Me.cbbEstadoInterv)
        Me.FbGroupBox5.Controls.Add(Me.FbLabel51)
        Me.FbGroupBox5.Controls.Add(Me.FbLabel52)
        Me.FbGroupBox5.Controls.Add(Me.txtCepInterv)
        Me.FbGroupBox5.Controls.Add(Me.cbbEstadoCivilInterv)
        Me.FbGroupBox5.Controls.Add(Me.FbLabel49)
        Me.FbGroupBox5.Controls.Add(Me.FbLabel48)
        Me.FbGroupBox5.Controls.Add(Me.txtCPFInteerv)
        Me.FbGroupBox5.Controls.Add(Me.FbLabel47)
        Me.FbGroupBox5.Controls.Add(Me.txtEnderecoInterv)
        Me.FbGroupBox5.Controls.Add(Me.FbLabel46)
        Me.FbGroupBox5.Controls.Add(Me.txtInterveniente)
        Me.FbGroupBox5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FbGroupBox5.Location = New System.Drawing.Point(0, 76)
        Me.FbGroupBox5.Name = "FbGroupBox5"
        Me.FbGroupBox5.Size = New System.Drawing.Size(690, 115)
        Me.FbGroupBox5.TabIndex = 200
        Me.FbGroupBox5.TabStop = False
        Me.FbGroupBox5.Text = "Interveniente / Responsável"
        '
        'FbLabel53
        '
        Me.FbLabel53.AutoSize = True
        Me.FbLabel53.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel53.Location = New System.Drawing.Point(499, 68)
        Me.FbLabel53.Name = "FbLabel53"
        Me.FbLabel53.Size = New System.Drawing.Size(37, 13)
        Me.FbLabel53.TabIndex = 203
        Me.FbLabel53.Text = "Bairro:"
        '
        'txtBairroInterv
        '
        Me.txtBairroInterv.BackColor = System.Drawing.Color.White
        Me.txtBairroInterv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBairroInterv.botaoClear = False
        Me.txtBairroInterv.Campo = ""
        Me.txtBairroInterv.CaracterTipo = "U"
        Me.txtBairroInterv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairroInterv.ControlDB = Nothing
        Me.txtBairroInterv.Location = New System.Drawing.Point(538, 65)
        Me.txtBairroInterv.MaxLength = 100
        Me.txtBairroInterv.Name = "txtBairroInterv"
        Me.txtBairroInterv.NomeCampoMsg = "Interveniente"
        Me.txtBairroInterv.Requerido = False
        Me.txtBairroInterv.Size = New System.Drawing.Size(152, 20)
        Me.txtBairroInterv.TabIndex = 202
        Me.txtBairroInterv.Valor = Nothing
        Me.txtBairroInterv.valorVazio = ""
        '
        'FbButtonVisual3
        '
        Me.FbButtonVisual3.BackColor = System.Drawing.Color.SteelBlue
        Me.FbButtonVisual3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButtonVisual3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbButtonVisual3.ForeColor = System.Drawing.Color.White
        Me.FbButtonVisual3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FbButtonVisual3.Location = New System.Drawing.Point(597, 41)
        Me.FbButtonVisual3.Name = "FbButtonVisual3"
        Me.FbButtonVisual3.Size = New System.Drawing.Size(82, 20)
        Me.FbButtonVisual3.TabIndex = 201
        Me.FbButtonVisual3.Text = "Buscar Cep."
        '
        'FbButtonVisual4
        '
        Me.FbButtonVisual4.BackColor = System.Drawing.Color.SteelBlue
        Me.FbButtonVisual4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButtonVisual4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbButtonVisual4.ForeColor = System.Drawing.Color.White
        Me.FbButtonVisual4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FbButtonVisual4.Location = New System.Drawing.Point(141, 41)
        Me.FbButtonVisual4.Name = "FbButtonVisual4"
        Me.FbButtonVisual4.Size = New System.Drawing.Size(82, 20)
        Me.FbButtonVisual4.TabIndex = 195
        Me.FbButtonVisual4.Text = "Buscar Inf."
        '
        'cbbCidadeInterv
        '
        Me.cbbCidadeInterv.AgrupadoPor = Nothing
        Me.cbbCidadeInterv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbCidadeInterv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbCidadeInterv.BackColor = System.Drawing.Color.White
        Me.cbbCidadeInterv.Campo = ""
        Me.cbbCidadeInterv.campoID = "CODIGO"
        Me.cbbCidadeInterv.campoOrdem = Nothing
        Me.cbbCidadeInterv.campoRelacionamento = Nothing
        Me.cbbCidadeInterv.campoSelecionavel = "NOME"
        Me.cbbCidadeInterv.campoSql = Nothing
        Me.cbbCidadeInterv.campoSqlID = Nothing
        Me.cbbCidadeInterv.carrega2Parametro = False
        Me.cbbCidadeInterv.carregaClick = True
        Me.cbbCidadeInterv.comDistinct = False
        Me.cbbCidadeInterv.ControlDB = Nothing
        Me.cbbCidadeInterv.DisplayMember = "Texto"
        Me.cbbCidadeInterv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbCidadeInterv.Filtro = Nothing
        Me.cbbCidadeInterv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbCidadeInterv.FormattingEnabled = True
        Me.cbbCidadeInterv.Location = New System.Drawing.Point(452, 41)
        Me.cbbCidadeInterv.Name = "cbbCidadeInterv"
        Me.cbbCidadeInterv.NomeCampoMsg = "txtCidade"
        Me.cbbCidadeInterv.Ordena = Nothing
        Me.cbbCidadeInterv.Requerido = False
        Me.cbbCidadeInterv.Size = New System.Drawing.Size(141, 21)
        Me.cbbCidadeInterv.TabelaRelacionamento = "TB_CIDADE"
        Me.cbbCidadeInterv.TabIndex = 197
        Me.cbbCidadeInterv.TextoSelecionar = "Selecione a Cidade"
        Me.cbbCidadeInterv.Valor = Nothing
        Me.cbbCidadeInterv.ValorRelacionamento = Nothing
        Me.cbbCidadeInterv.ValorSelecionado = "-1"
        Me.cbbCidadeInterv.valorVazio = -1
        Me.cbbCidadeInterv.ValueMember = "Valor"
        '
        'FbLabel50
        '
        Me.FbLabel50.AutoSize = True
        Me.FbLabel50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel50.Location = New System.Drawing.Point(407, 45)
        Me.FbLabel50.Name = "FbLabel50"
        Me.FbLabel50.Size = New System.Drawing.Size(43, 13)
        Me.FbLabel50.TabIndex = 200
        Me.FbLabel50.Text = "Cidade:"
        '
        'cbbEstadoInterv
        '
        Me.cbbEstadoInterv.AgrupadoPor = Nothing
        Me.cbbEstadoInterv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbEstadoInterv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbEstadoInterv.BackColor = System.Drawing.Color.White
        Me.cbbEstadoInterv.Campo = ""
        Me.cbbEstadoInterv.campoID = "CODIGO"
        Me.cbbEstadoInterv.campoOrdem = Nothing
        Me.cbbEstadoInterv.campoRelacionamento = Nothing
        Me.cbbEstadoInterv.campoSelecionavel = "NOME"
        Me.cbbEstadoInterv.campoSql = Nothing
        Me.cbbEstadoInterv.campoSqlID = Nothing
        Me.cbbEstadoInterv.carrega2Parametro = False
        Me.cbbEstadoInterv.carregaClick = True
        Me.cbbEstadoInterv.comDistinct = False
        Me.cbbEstadoInterv.ControlDB = Nothing
        Me.cbbEstadoInterv.DisplayMember = "Texto"
        Me.cbbEstadoInterv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbEstadoInterv.Filtro = Nothing
        Me.cbbEstadoInterv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbEstadoInterv.FormattingEnabled = True
        Me.cbbEstadoInterv.Location = New System.Drawing.Point(273, 41)
        Me.cbbEstadoInterv.Name = "cbbEstadoInterv"
        Me.cbbEstadoInterv.NomeCampoMsg = "txtEstado"
        Me.cbbEstadoInterv.Ordena = Nothing
        Me.cbbEstadoInterv.Requerido = False
        Me.cbbEstadoInterv.Size = New System.Drawing.Size(127, 21)
        Me.cbbEstadoInterv.TabelaRelacionamento = "TB_ESTADO"
        Me.cbbEstadoInterv.TabIndex = 196
        Me.cbbEstadoInterv.TextoSelecionar = "Selecione o Estado"
        Me.cbbEstadoInterv.Valor = Nothing
        Me.cbbEstadoInterv.ValorRelacionamento = Nothing
        Me.cbbEstadoInterv.ValorSelecionado = "-1"
        Me.cbbEstadoInterv.valorVazio = -1
        Me.cbbEstadoInterv.ValueMember = "Valor"
        '
        'FbLabel51
        '
        Me.FbLabel51.AutoSize = True
        Me.FbLabel51.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel51.Location = New System.Drawing.Point(227, 44)
        Me.FbLabel51.Name = "FbLabel51"
        Me.FbLabel51.Size = New System.Drawing.Size(43, 13)
        Me.FbLabel51.TabIndex = 199
        Me.FbLabel51.Text = "Estado:"
        '
        'FbLabel52
        '
        Me.FbLabel52.AutoSize = True
        Me.FbLabel52.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel52.Location = New System.Drawing.Point(35, 44)
        Me.FbLabel52.Name = "FbLabel52"
        Me.FbLabel52.Size = New System.Drawing.Size(31, 13)
        Me.FbLabel52.TabIndex = 198
        Me.FbLabel52.Text = "CEP:"
        '
        'txtCepInterv
        '
        Me.txtCepInterv.BackColor = System.Drawing.Color.White
        Me.txtCepInterv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCepInterv.ControlDB = Nothing
        Me.txtCepInterv.DB = Nothing
        Me.txtCepInterv.Location = New System.Drawing.Point(68, 41)
        Me.txtCepInterv.Mask = "99,999-999"
        Me.txtCepInterv.Name = "txtCepInterv"
        Me.txtCepInterv.NomeCampoMsg = "CEP"
        Me.txtCepInterv.Requerido = False
        Me.txtCepInterv.Size = New System.Drawing.Size(70, 20)
        Me.txtCepInterv.TabIndex = 194
        Me.txtCepInterv.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'cbbEstadoCivilInterv
        '
        Me.cbbEstadoCivilInterv.AgrupadoPor = Nothing
        Me.cbbEstadoCivilInterv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbEstadoCivilInterv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbEstadoCivilInterv.BackColor = System.Drawing.Color.White
        Me.cbbEstadoCivilInterv.Campo = ""
        Me.cbbEstadoCivilInterv.campoID = ""
        Me.cbbEstadoCivilInterv.campoOrdem = Nothing
        Me.cbbEstadoCivilInterv.campoRelacionamento = "TIPO"
        Me.cbbEstadoCivilInterv.campoSelecionavel = "VALOR"
        Me.cbbEstadoCivilInterv.campoSql = Nothing
        Me.cbbEstadoCivilInterv.campoSqlID = Nothing
        Me.cbbEstadoCivilInterv.carrega2Parametro = False
        Me.cbbEstadoCivilInterv.carregaClick = True
        Me.cbbEstadoCivilInterv.comDistinct = False
        Me.cbbEstadoCivilInterv.ControlDB = Nothing
        Me.cbbEstadoCivilInterv.DisplayMember = "Texto"
        Me.cbbEstadoCivilInterv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbEstadoCivilInterv.Filtro = Nothing
        Me.cbbEstadoCivilInterv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbEstadoCivilInterv.FormattingEnabled = True
        Me.cbbEstadoCivilInterv.Location = New System.Drawing.Point(68, 89)
        Me.cbbEstadoCivilInterv.Name = "cbbEstadoCivilInterv"
        Me.cbbEstadoCivilInterv.NomeCampoMsg = "TipoCad"
        Me.cbbEstadoCivilInterv.Ordena = Nothing
        Me.cbbEstadoCivilInterv.Requerido = False
        Me.cbbEstadoCivilInterv.Size = New System.Drawing.Size(161, 21)
        Me.cbbEstadoCivilInterv.TabelaRelacionamento = "TB_PARAMETRO"
        Me.cbbEstadoCivilInterv.TabIndex = 192
        Me.cbbEstadoCivilInterv.TextoSelecionar = "Selecione um Estado Civil"
        Me.cbbEstadoCivilInterv.Valor = Nothing
        Me.cbbEstadoCivilInterv.ValorRelacionamento = "FOLHA_PES_ESTCIV"
        Me.cbbEstadoCivilInterv.ValorSelecionado = "-1"
        Me.cbbEstadoCivilInterv.valorVazio = -1
        Me.cbbEstadoCivilInterv.ValueMember = "Valor"
        '
        'FbLabel49
        '
        Me.FbLabel49.AutoSize = True
        Me.FbLabel49.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel49.Location = New System.Drawing.Point(16, 93)
        Me.FbLabel49.Name = "FbLabel49"
        Me.FbLabel49.Size = New System.Drawing.Size(50, 13)
        Me.FbLabel49.TabIndex = 193
        Me.FbLabel49.Text = "Est. Civil:"
        '
        'FbLabel48
        '
        Me.FbLabel48.AutoSize = True
        Me.FbLabel48.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel48.Location = New System.Drawing.Point(479, 20)
        Me.FbLabel48.Name = "FbLabel48"
        Me.FbLabel48.Size = New System.Drawing.Size(30, 13)
        Me.FbLabel48.TabIndex = 191
        Me.FbLabel48.Text = "CPF:"
        '
        'txtCPFInteerv
        '
        Me.txtCPFInteerv.BackColor = System.Drawing.Color.White
        Me.txtCPFInteerv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCPFInteerv.ControlDB = Nothing
        Me.txtCPFInteerv.DB = Nothing
        Me.txtCPFInteerv.Location = New System.Drawing.Point(511, 17)
        Me.txtCPFInteerv.Mask = "999,999,999-99"
        Me.txtCPFInteerv.Name = "txtCPFInteerv"
        Me.txtCPFInteerv.NomeCampoMsg = "CGC"
        Me.txtCPFInteerv.Requerido = False
        Me.txtCPFInteerv.Size = New System.Drawing.Size(155, 20)
        Me.txtCPFInteerv.TabIndex = 190
        Me.txtCPFInteerv.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'FbLabel47
        '
        Me.FbLabel47.AutoSize = True
        Me.FbLabel47.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel47.Location = New System.Drawing.Point(10, 68)
        Me.FbLabel47.Name = "FbLabel47"
        Me.FbLabel47.Size = New System.Drawing.Size(56, 13)
        Me.FbLabel47.TabIndex = 189
        Me.FbLabel47.Text = "Endereço:"
        '
        'txtEnderecoInterv
        '
        Me.txtEnderecoInterv.BackColor = System.Drawing.Color.White
        Me.txtEnderecoInterv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEnderecoInterv.botaoClear = False
        Me.txtEnderecoInterv.Campo = ""
        Me.txtEnderecoInterv.CaracterTipo = "U"
        Me.txtEnderecoInterv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnderecoInterv.ControlDB = Nothing
        Me.txtEnderecoInterv.Location = New System.Drawing.Point(68, 65)
        Me.txtEnderecoInterv.MaxLength = 100
        Me.txtEnderecoInterv.Name = "txtEnderecoInterv"
        Me.txtEnderecoInterv.NomeCampoMsg = "Interveniente"
        Me.txtEnderecoInterv.Requerido = False
        Me.txtEnderecoInterv.Size = New System.Drawing.Size(404, 20)
        Me.txtEnderecoInterv.TabIndex = 188
        Me.txtEnderecoInterv.Valor = Nothing
        Me.txtEnderecoInterv.valorVazio = ""
        '
        'FbLabel46
        '
        Me.FbLabel46.AutoSize = True
        Me.FbLabel46.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel46.Location = New System.Drawing.Point(28, 21)
        Me.FbLabel46.Name = "FbLabel46"
        Me.FbLabel46.Size = New System.Drawing.Size(38, 13)
        Me.FbLabel46.TabIndex = 187
        Me.FbLabel46.Text = "Nome:"
        '
        'txtInterveniente
        '
        Me.txtInterveniente.BackColor = System.Drawing.Color.White
        Me.txtInterveniente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInterveniente.botaoClear = False
        Me.txtInterveniente.Campo = ""
        Me.txtInterveniente.CaracterTipo = "U"
        Me.txtInterveniente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInterveniente.ControlDB = Nothing
        Me.txtInterveniente.Location = New System.Drawing.Point(68, 17)
        Me.txtInterveniente.MaxLength = 100
        Me.txtInterveniente.Name = "txtInterveniente"
        Me.txtInterveniente.NomeCampoMsg = "Interveniente"
        Me.txtInterveniente.Requerido = False
        Me.txtInterveniente.Size = New System.Drawing.Size(404, 20)
        Me.txtInterveniente.TabIndex = 186
        Me.txtInterveniente.Valor = Nothing
        Me.txtInterveniente.valorVazio = ""
        '
        'FbLabel40
        '
        Me.FbLabel40.AutoSize = True
        Me.FbLabel40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel40.Location = New System.Drawing.Point(256, 55)
        Me.FbLabel40.Name = "FbLabel40"
        Me.FbLabel40.Size = New System.Drawing.Size(51, 13)
        Me.FbLabel40.TabIndex = 177
        Me.FbLabel40.Text = "Celular 2:"
        '
        'txtCel2
        '
        Me.txtCel2.BackColor = System.Drawing.Color.White
        Me.txtCel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCel2.ControlDB = Nothing
        Me.txtCel2.DB = Nothing
        Me.txtCel2.Location = New System.Drawing.Point(313, 52)
        Me.txtCel2.Mask = "(99) 99999-9999"
        Me.txtCel2.Name = "txtCel2"
        Me.txtCel2.NomeCampoMsg = "Cel2"
        Me.txtCel2.Requerido = False
        Me.txtCel2.Size = New System.Drawing.Size(159, 20)
        Me.txtCel2.TabIndex = 175
        Me.txtCel2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'FbLabel41
        '
        Me.FbLabel41.AutoSize = True
        Me.FbLabel41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel41.Location = New System.Drawing.Point(7, 55)
        Me.FbLabel41.Name = "FbLabel41"
        Me.FbLabel41.Size = New System.Drawing.Size(56, 13)
        Me.FbLabel41.TabIndex = 176
        Me.FbLabel41.Text = "Comercial:"
        '
        'txtTelCom
        '
        Me.txtTelCom.BackColor = System.Drawing.Color.White
        Me.txtTelCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelCom.ControlDB = Nothing
        Me.txtTelCom.DB = Nothing
        Me.txtTelCom.Location = New System.Drawing.Point(68, 52)
        Me.txtTelCom.Mask = "(99) 9999-9999"
        Me.txtTelCom.Name = "txtTelCom"
        Me.txtTelCom.NomeCampoMsg = "TelCom"
        Me.txtTelCom.Requerido = False
        Me.txtTelCom.Size = New System.Drawing.Size(155, 20)
        Me.txtTelCom.TabIndex = 174
        Me.txtTelCom.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'FbGroupBox4
        '
        Me.FbGroupBox4.Controls.Add(Me.rbInativo)
        Me.FbGroupBox4.Controls.Add(Me.rbAtivo)
        Me.FbGroupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FbGroupBox4.Location = New System.Drawing.Point(617, 5)
        Me.FbGroupBox4.Name = "FbGroupBox4"
        Me.FbGroupBox4.Size = New System.Drawing.Size(70, 57)
        Me.FbGroupBox4.TabIndex = 173
        Me.FbGroupBox4.TabStop = False
        Me.FbGroupBox4.Text = "Status"
        '
        'rbInativo
        '
        Me.rbInativo.AutoSize = True
        Me.rbInativo.Campo = ""
        Me.rbInativo.ControlDB = Nothing
        Me.rbInativo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbInativo.Location = New System.Drawing.Point(8, 35)
        Me.rbInativo.Name = "rbInativo"
        Me.rbInativo.Size = New System.Drawing.Size(57, 17)
        Me.rbInativo.TabIndex = 1
        Me.rbInativo.Text = "Inativo"
        Me.rbInativo.UseVisualStyleBackColor = True
        Me.rbInativo.Valor = Nothing
        Me.rbInativo.ValorChecado = Nothing
        Me.rbInativo.valorVazio = False
        '
        'rbAtivo
        '
        Me.rbAtivo.AutoSize = True
        Me.rbAtivo.Campo = ""
        Me.rbAtivo.Checked = True
        Me.rbAtivo.ControlDB = Nothing
        Me.rbAtivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbAtivo.Location = New System.Drawing.Point(8, 14)
        Me.rbAtivo.Name = "rbAtivo"
        Me.rbAtivo.Size = New System.Drawing.Size(49, 17)
        Me.rbAtivo.TabIndex = 0
        Me.rbAtivo.TabStop = True
        Me.rbAtivo.Text = "Ativo"
        Me.rbAtivo.UseVisualStyleBackColor = True
        Me.rbAtivo.Valor = Nothing
        Me.rbAtivo.ValorChecado = Nothing
        Me.rbAtivo.valorVazio = False
        '
        'btnLimpar
        '
        Me.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLimpar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.White
        Me.btnLimpar.Location = New System.Drawing.Point(1592, 126)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(98, 23)
        Me.btnLimpar.TabIndex = 56
        Me.btnLimpar.Text = "Limpar"
        '
        'FbLabel27
        '
        Me.FbLabel27.AutoSize = True
        Me.FbLabel27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel27.Location = New System.Drawing.Point(265, 31)
        Me.FbLabel27.Name = "FbLabel27"
        Me.FbLabel27.Size = New System.Drawing.Size(42, 13)
        Me.FbLabel27.TabIndex = 53
        Me.FbLabel27.Text = "Celular:"
        '
        'txtCel
        '
        Me.txtCel.BackColor = System.Drawing.Color.White
        Me.txtCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCel.ControlDB = Nothing
        Me.txtCel.DB = Nothing
        Me.txtCel.Location = New System.Drawing.Point(313, 28)
        Me.txtCel.Mask = "(99) 99999-9999"
        Me.txtCel.Name = "txtCel"
        Me.txtCel.NomeCampoMsg = "Cel"
        Me.txtCel.Requerido = False
        Me.txtCel.Size = New System.Drawing.Size(159, 20)
        Me.txtCel.TabIndex = 2
        Me.txtCel.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'ptbImagem
        '
        Me.ptbImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbImagem.BotaoDireitoManipulaImagem = True
        Me.ptbImagem.Location = New System.Drawing.Point(488, 5)
        Me.ptbImagem.Name = "ptbImagem"
        Me.ptbImagem.Size = New System.Drawing.Size(111, 67)
        Me.ptbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbImagem.TabIndex = 51
        Me.ptbImagem.TabStop = False
        '
        'FbLabel26
        '
        Me.FbLabel26.AutoSize = True
        Me.FbLabel26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel26.Location = New System.Drawing.Point(11, 31)
        Me.FbLabel26.Name = "FbLabel26"
        Me.FbLabel26.Size = New System.Drawing.Size(52, 13)
        Me.FbLabel26.TabIndex = 50
        Me.FbLabel26.Text = "Telefone:"
        '
        'txtTelefone
        '
        Me.txtTelefone.BackColor = System.Drawing.Color.White
        Me.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefone.ControlDB = Nothing
        Me.txtTelefone.DB = Nothing
        Me.txtTelefone.Location = New System.Drawing.Point(68, 28)
        Me.txtTelefone.Mask = "(99) 9999-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.NomeCampoMsg = "Telefone"
        Me.txtTelefone.Requerido = False
        Me.txtTelefone.Size = New System.Drawing.Size(155, 20)
        Me.txtTelefone.TabIndex = 1
        Me.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'FbLabel22
        '
        Me.FbLabel22.AutoSize = True
        Me.FbLabel22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel22.Location = New System.Drawing.Point(28, 8)
        Me.FbLabel22.Name = "FbLabel22"
        Me.FbLabel22.Size = New System.Drawing.Size(35, 13)
        Me.FbLabel22.TabIndex = 48
        Me.FbLabel22.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.botaoClear = False
        Me.txtEmail.Campo = ""
        Me.txtEmail.CaracterTipo = "U"
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.ControlDB = Nothing
        Me.txtEmail.Location = New System.Drawing.Point(68, 5)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.NomeCampoMsg = "Email"
        Me.txtEmail.Requerido = False
        Me.txtEmail.Size = New System.Drawing.Size(404, 20)
        Me.txtEmail.TabIndex = 0
        Me.txtEmail.Valor = Nothing
        Me.txtEmail.valorVazio = ""
        '
        'tpeConf
        '
        Me.tpeConf.Controls.Add(Me.FbLabel55)
        Me.tpeConf.Controls.Add(Me.lkpDomicilio)
        Me.tpeConf.Controls.Add(Me.ckbSenar)
        Me.tpeConf.Controls.Add(Me.ckbFunRural)
        Me.tpeConf.Controls.Add(Me.ckbICMS)
        Me.tpeConf.Controls.Add(Me.FbLabel28)
        Me.tpeConf.Controls.Add(Me.txtObs)
        Me.tpeConf.Controls.Add(Me.ckbFiscal)
        Me.tpeConf.Controls.Add(Me.cbbTipoFiscal)
        Me.tpeConf.Controls.Add(Me.pesContaCont)
        Me.tpeConf.Controls.Add(Me.FbLabel6)
        Me.tpeConf.Controls.Add(Me.FbLabel7)
        Me.tpeConf.Location = New System.Drawing.Point(4, 25)
        Me.tpeConf.Name = "tpeConf"
        Me.tpeConf.Size = New System.Drawing.Size(711, 191)
        Me.tpeConf.TabIndex = 1
        Me.tpeConf.Text = "Conf."
        '
        'FbLabel55
        '
        Me.FbLabel55.AutoSize = True
        Me.FbLabel55.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel55.Location = New System.Drawing.Point(16, 150)
        Me.FbLabel55.Name = "FbLabel55"
        Me.FbLabel55.Size = New System.Drawing.Size(66, 13)
        Me.FbLabel55.TabIndex = 295
        Me.FbLabel55.Text = "Dom Cobrar:"
        '
        'lkpDomicilio
        '
        Me.lkpDomicilio.ControlDB = Nothing
        Me.lkpDomicilio.DataTableSelect = Nothing
        Me.lkpDomicilio.FormularioPesquisa = Nothing
        Me.lkpDomicilio.LimpaTexto = True
        Me.lkpDomicilio.Location = New System.Drawing.Point(84, 146)
        Me.lkpDomicilio.Name = "lkpDomicilio"
        Me.lkpDomicilio.NomeCampoMsg = "fbLookUp"
        Me.lkpDomicilio.Requerido = False
        Me.lkpDomicilio.SelectID = -1
        Me.lkpDomicilio.Size = New System.Drawing.Size(509, 20)
        Me.lkpDomicilio.TabIndex = 294
        '
        'ckbSenar
        '
        Me.ckbSenar.AutoSize = True
        Me.ckbSenar.Campo = ""
        Me.ckbSenar.ControlDB = Nothing
        Me.ckbSenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ckbSenar.Location = New System.Drawing.Point(502, 55)
        Me.ckbSenar.Name = "ckbSenar"
        Me.ckbSenar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckbSenar.Size = New System.Drawing.Size(92, 17)
        Me.ckbSenar.TabIndex = 278
        Me.ckbSenar.Text = "Incide SENAR"
        Me.ckbSenar.UseVisualStyleBackColor = True
        Me.ckbSenar.Valor = Nothing
        Me.ckbSenar.valorVazio = False
        '
        'ckbFunRural
        '
        Me.ckbFunRural.AutoSize = True
        Me.ckbFunRural.Campo = ""
        Me.ckbFunRural.ControlDB = Nothing
        Me.ckbFunRural.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ckbFunRural.Location = New System.Drawing.Point(353, 55)
        Me.ckbFunRural.Name = "ckbFunRural"
        Me.ckbFunRural.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckbFunRural.Size = New System.Drawing.Size(114, 17)
        Me.ckbFunRural.TabIndex = 277
        Me.ckbFunRural.Text = "Incide FUNRURAL"
        Me.ckbFunRural.UseVisualStyleBackColor = True
        Me.ckbFunRural.Valor = Nothing
        Me.ckbFunRural.valorVazio = False
        '
        'ckbICMS
        '
        Me.ckbICMS.AutoSize = True
        Me.ckbICMS.Campo = ""
        Me.ckbICMS.ControlDB = Nothing
        Me.ckbICMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ckbICMS.Location = New System.Drawing.Point(237, 55)
        Me.ckbICMS.Name = "ckbICMS"
        Me.ckbICMS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckbICMS.Size = New System.Drawing.Size(81, 17)
        Me.ckbICMS.TabIndex = 276
        Me.ckbICMS.Text = "Incide ICMS"
        Me.ckbICMS.UseVisualStyleBackColor = True
        Me.ckbICMS.Valor = Nothing
        Me.ckbICMS.valorVazio = False
        '
        'FbLabel28
        '
        Me.FbLabel28.AutoSize = True
        Me.FbLabel28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel28.Location = New System.Drawing.Point(50, 79)
        Me.FbLabel28.Name = "FbLabel28"
        Me.FbLabel28.Size = New System.Drawing.Size(32, 13)
        Me.FbLabel28.TabIndex = 165
        Me.FbLabel28.Text = "Obs.:"
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.White
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.botaoClear = False
        Me.txtObs.Campo = ""
        Me.txtObs.CaracterTipo = "U"
        Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.ControlDB = Nothing
        Me.txtObs.Location = New System.Drawing.Point(84, 76)
        Me.txtObs.MaxLength = 200
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.NomeCampoMsg = "Obs"
        Me.txtObs.Requerido = False
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(510, 49)
        Me.txtObs.TabIndex = 164
        Me.txtObs.Valor = Nothing
        Me.txtObs.valorVazio = ""
        '
        'ckbFiscal
        '
        Me.ckbFiscal.AutoSize = True
        Me.ckbFiscal.Campo = ""
        Me.ckbFiscal.ControlDB = Nothing
        Me.ckbFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ckbFiscal.Location = New System.Drawing.Point(84, 55)
        Me.ckbFiscal.Name = "ckbFiscal"
        Me.ckbFiscal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckbFiscal.Size = New System.Drawing.Size(118, 17)
        Me.ckbFiscal.TabIndex = 163
        Me.ckbFiscal.Text = "Gerar Dados Fiscais"
        Me.ckbFiscal.UseVisualStyleBackColor = True
        Me.ckbFiscal.Valor = Nothing
        Me.ckbFiscal.valorVazio = False
        Me.ckbFiscal.Visible = False
        '
        'cbbTipoFiscal
        '
        Me.cbbTipoFiscal.AgrupadoPor = Nothing
        Me.cbbTipoFiscal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbTipoFiscal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbTipoFiscal.BackColor = System.Drawing.Color.White
        Me.cbbTipoFiscal.Campo = ""
        Me.cbbTipoFiscal.campoID = "ID"
        Me.cbbTipoFiscal.campoOrdem = Nothing
        Me.cbbTipoFiscal.campoRelacionamento = Nothing
        Me.cbbTipoFiscal.campoSelecionavel = "Nome"
        Me.cbbTipoFiscal.campoSql = Nothing
        Me.cbbTipoFiscal.campoSqlID = Nothing
        Me.cbbTipoFiscal.carrega2Parametro = False
        Me.cbbTipoFiscal.carregaClick = True
        Me.cbbTipoFiscal.comDistinct = False
        Me.cbbTipoFiscal.ControlDB = Nothing
        Me.cbbTipoFiscal.DisplayMember = "Texto"
        Me.cbbTipoFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTipoFiscal.Filtro = Nothing
        Me.cbbTipoFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbTipoFiscal.FormattingEnabled = True
        Me.cbbTipoFiscal.Location = New System.Drawing.Point(84, 5)
        Me.cbbTipoFiscal.Name = "cbbTipoFiscal"
        Me.cbbTipoFiscal.NomeCampoMsg = "TipoFiscal"
        Me.cbbTipoFiscal.Ordena = Nothing
        Me.cbbTipoFiscal.Requerido = False
        Me.cbbTipoFiscal.Size = New System.Drawing.Size(510, 21)
        Me.cbbTipoFiscal.TabelaRelacionamento = "TB_TIPO_CLIENTE"
        Me.cbbTipoFiscal.TabIndex = 0
        Me.cbbTipoFiscal.TextoSelecionar = "Selecione o Tipo Fiscal"
        Me.cbbTipoFiscal.Valor = Nothing
        Me.cbbTipoFiscal.ValorRelacionamento = Nothing
        Me.cbbTipoFiscal.ValorSelecionado = "-1"
        Me.cbbTipoFiscal.valorVazio = -1
        Me.cbbTipoFiscal.ValueMember = "Valor"
        '
        'FbLabel7
        '
        Me.FbLabel7.AutoSize = True
        Me.FbLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel7.Location = New System.Drawing.Point(22, 8)
        Me.FbLabel7.Name = "FbLabel7"
        Me.FbLabel7.Size = New System.Drawing.Size(61, 13)
        Me.FbLabel7.TabIndex = 30
        Me.FbLabel7.Text = "Tipo Fiscal:"
        '
        'TabPageEX2
        '
        Me.TabPageEX2.Controls.Add(Me.FbGroupBox3)
        Me.TabPageEX2.Controls.Add(Me.FbGroupBox2)
        Me.TabPageEX2.Controls.Add(Me.FbGroupBox1)
        Me.TabPageEX2.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEX2.Name = "TabPageEX2"
        Me.TabPageEX2.Size = New System.Drawing.Size(690, 191)
        Me.TabPageEX2.TabIndex = 4
        Me.TabPageEX2.Text = "Outras Inf."
        '
        'FbGroupBox3
        '
        Me.FbGroupBox3.Controls.Add(Me.txtRg)
        Me.FbGroupBox3.Controls.Add(Me.FbLabel32)
        Me.FbGroupBox3.Controls.Add(Me.txtRGexp)
        Me.FbGroupBox3.Controls.Add(Me.FbLabel33)
        Me.FbGroupBox3.Controls.Add(Me.FbLabel34)
        Me.FbGroupBox3.Controls.Add(Me.txtDataExpRG)
        Me.FbGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FbGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbGroupBox3.Location = New System.Drawing.Point(0, 83)
        Me.FbGroupBox3.Name = "FbGroupBox3"
        Me.FbGroupBox3.Size = New System.Drawing.Size(690, 41)
        Me.FbGroupBox3.TabIndex = 279
        Me.FbGroupBox3.TabStop = False
        Me.FbGroupBox3.Text = "Dados do RG"
        '
        'txtRg
        '
        Me.txtRg.BackColor = System.Drawing.Color.White
        Me.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRg.botaoClear = False
        Me.txtRg.Campo = ""
        Me.txtRg.CaracterTipo = "U"
        Me.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRg.ControlDB = Nothing
        Me.txtRg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRg.Location = New System.Drawing.Point(68, 16)
        Me.txtRg.MaxLength = 20
        Me.txtRg.Name = "txtRg"
        Me.txtRg.NomeCampoMsg = "Rg"
        Me.txtRg.Requerido = False
        Me.txtRg.Size = New System.Drawing.Size(178, 20)
        Me.txtRg.TabIndex = 7
        Me.txtRg.Valor = Nothing
        Me.txtRg.valorVazio = ""
        '
        'FbLabel32
        '
        Me.FbLabel32.AutoSize = True
        Me.FbLabel32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel32.Location = New System.Drawing.Point(39, 19)
        Me.FbLabel32.Name = "FbLabel32"
        Me.FbLabel32.Size = New System.Drawing.Size(26, 13)
        Me.FbLabel32.TabIndex = 267
        Me.FbLabel32.Text = "RG:"
        '
        'txtRGexp
        '
        Me.txtRGexp.BackColor = System.Drawing.Color.White
        Me.txtRGexp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRGexp.botaoClear = False
        Me.txtRGexp.Campo = ""
        Me.txtRGexp.CaracterTipo = "U"
        Me.txtRGexp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRGexp.ControlDB = Nothing
        Me.txtRGexp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRGexp.Location = New System.Drawing.Point(509, 16)
        Me.txtRGexp.MaxLength = 6
        Me.txtRGexp.Name = "txtRGexp"
        Me.txtRGexp.NomeCampoMsg = "RGexp"
        Me.txtRGexp.Requerido = False
        Me.txtRGexp.Size = New System.Drawing.Size(85, 20)
        Me.txtRGexp.TabIndex = 8
        Me.txtRGexp.Valor = Nothing
        Me.txtRGexp.valorVazio = ""
        '
        'FbLabel33
        '
        Me.FbLabel33.AutoSize = True
        Me.FbLabel33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel33.Location = New System.Drawing.Point(459, 19)
        Me.FbLabel33.Name = "FbLabel33"
        Me.FbLabel33.Size = New System.Drawing.Size(48, 13)
        Me.FbLabel33.TabIndex = 269
        Me.FbLabel33.Text = "Org.Exp:"
        '
        'FbLabel34
        '
        Me.FbLabel34.AutoSize = True
        Me.FbLabel34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel34.Location = New System.Drawing.Point(303, 19)
        Me.FbLabel34.Name = "FbLabel34"
        Me.FbLabel34.Size = New System.Drawing.Size(54, 13)
        Me.FbLabel34.TabIndex = 271
        Me.FbLabel34.Text = "Data Exp:"
        Me.FbLabel34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDataExpRG
        '
        Me.txtDataExpRG.BackColor = System.Drawing.Color.White
        Me.txtDataExpRG.ControlDB = Nothing
        Me.txtDataExpRG.CustomFormat = "dd/MM/yyyy"
        Me.txtDataExpRG.DataAtual = False
        Me.txtDataExpRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataExpRG.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataExpRG.Location = New System.Drawing.Point(360, 16)
        Me.txtDataExpRG.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDataExpRG.Name = "txtDataExpRG"
        Me.txtDataExpRG.NomeCampoMsg = "DataExpRG"
        Me.txtDataExpRG.Requerido = False
        Me.txtDataExpRG.Size = New System.Drawing.Size(95, 20)
        Me.txtDataExpRG.TabIndex = 9
        Me.txtDataExpRG.Value = New Date(2012, 8, 7, 9, 33, 57, 154)
        '
        'FbGroupBox2
        '
        Me.FbGroupBox2.Controls.Add(Me.txtCTPSSerie)
        Me.FbGroupBox2.Controls.Add(Me.txtCTPS)
        Me.FbGroupBox2.Controls.Add(Me.FbLabel13)
        Me.FbGroupBox2.Controls.Add(Me.FbLabel25)
        Me.FbGroupBox2.Controls.Add(Me.txtCTPSPis)
        Me.FbGroupBox2.Controls.Add(Me.FbLabel29)
        Me.FbGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FbGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbGroupBox2.Location = New System.Drawing.Point(0, 42)
        Me.FbGroupBox2.Name = "FbGroupBox2"
        Me.FbGroupBox2.Size = New System.Drawing.Size(690, 41)
        Me.FbGroupBox2.TabIndex = 278
        Me.FbGroupBox2.TabStop = False
        Me.FbGroupBox2.Text = "Dados da Carteira de Trabalho"
        '
        'txtCTPSSerie
        '
        Me.txtCTPSSerie.BackColor = System.Drawing.Color.White
        Me.txtCTPSSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTPSSerie.botaoClear = False
        Me.txtCTPSSerie.Campo = ""
        Me.txtCTPSSerie.CaracterTipo = "U"
        Me.txtCTPSSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCTPSSerie.ControlDB = Nothing
        Me.txtCTPSSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTPSSerie.Location = New System.Drawing.Point(212, 16)
        Me.txtCTPSSerie.MaxLength = 5
        Me.txtCTPSSerie.Name = "txtCTPSSerie"
        Me.txtCTPSSerie.NomeCampoMsg = "CTPSSerie"
        Me.txtCTPSSerie.Requerido = False
        Me.txtCTPSSerie.Size = New System.Drawing.Size(34, 20)
        Me.txtCTPSSerie.TabIndex = 5
        Me.txtCTPSSerie.Valor = Nothing
        Me.txtCTPSSerie.valorVazio = ""
        '
        'txtCTPS
        '
        Me.txtCTPS.BackColor = System.Drawing.Color.White
        Me.txtCTPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTPS.botaoClear = False
        Me.txtCTPS.Campo = ""
        Me.txtCTPS.CaracterTipo = "U"
        Me.txtCTPS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCTPS.ControlDB = Nothing
        Me.txtCTPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTPS.Location = New System.Drawing.Point(68, 16)
        Me.txtCTPS.MaxLength = 20
        Me.txtCTPS.Name = "txtCTPS"
        Me.txtCTPS.NomeCampoMsg = "CTPS"
        Me.txtCTPS.Requerido = False
        Me.txtCTPS.Size = New System.Drawing.Size(103, 20)
        Me.txtCTPS.TabIndex = 4
        Me.txtCTPS.Valor = Nothing
        Me.txtCTPS.valorVazio = ""
        '
        'FbLabel13
        '
        Me.FbLabel13.AutoSize = True
        Me.FbLabel13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel13.Location = New System.Drawing.Point(28, 19)
        Me.FbLabel13.Name = "FbLabel13"
        Me.FbLabel13.Size = New System.Drawing.Size(38, 13)
        Me.FbLabel13.TabIndex = 170
        Me.FbLabel13.Text = "CTPS:"
        '
        'FbLabel25
        '
        Me.FbLabel25.AutoSize = True
        Me.FbLabel25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel25.Location = New System.Drawing.Point(175, 19)
        Me.FbLabel25.Name = "FbLabel25"
        Me.FbLabel25.Size = New System.Drawing.Size(34, 13)
        Me.FbLabel25.TabIndex = 259
        Me.FbLabel25.Text = "Série:"
        '
        'txtCTPSPis
        '
        Me.txtCTPSPis.BackColor = System.Drawing.Color.White
        Me.txtCTPSPis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTPSPis.botaoClear = False
        Me.txtCTPSPis.Campo = ""
        Me.txtCTPSPis.CaracterTipo = "U"
        Me.txtCTPSPis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCTPSPis.ControlDB = Nothing
        Me.txtCTPSPis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTPSPis.Location = New System.Drawing.Point(360, 16)
        Me.txtCTPSPis.MaxLength = 15
        Me.txtCTPSPis.Name = "txtCTPSPis"
        Me.txtCTPSPis.NomeCampoMsg = "CTPSPis"
        Me.txtCTPSPis.Requerido = False
        Me.txtCTPSPis.Size = New System.Drawing.Size(234, 20)
        Me.txtCTPSPis.TabIndex = 6
        Me.txtCTPSPis.Valor = Nothing
        Me.txtCTPSPis.valorVazio = ""
        '
        'FbLabel29
        '
        Me.FbLabel29.AutoSize = True
        Me.FbLabel29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel29.Location = New System.Drawing.Point(330, 19)
        Me.FbLabel29.Name = "FbLabel29"
        Me.FbLabel29.Size = New System.Drawing.Size(27, 13)
        Me.FbLabel29.TabIndex = 261
        Me.FbLabel29.Text = "PIS:"
        '
        'FbGroupBox1
        '
        Me.FbGroupBox1.Controls.Add(Me.txtCNH)
        Me.FbGroupBox1.Controls.Add(Me.FbLabel11)
        Me.FbGroupBox1.Controls.Add(Me.FbLabel14)
        Me.FbGroupBox1.Controls.Add(Me.txtDataHabilitacao)
        Me.FbGroupBox1.Controls.Add(Me.FbLabel23)
        Me.FbGroupBox1.Controls.Add(Me.txtDataVencimentoHab)
        Me.FbGroupBox1.Controls.Add(Me.txtCNHTipoCarteira)
        Me.FbGroupBox1.Controls.Add(Me.FbLabel24)
        Me.FbGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FbGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.FbGroupBox1.Name = "FbGroupBox1"
        Me.FbGroupBox1.Size = New System.Drawing.Size(690, 42)
        Me.FbGroupBox1.TabIndex = 277
        Me.FbGroupBox1.TabStop = False
        Me.FbGroupBox1.Text = "Dados de Habilitação"
        '
        'txtCNH
        '
        Me.txtCNH.BackColor = System.Drawing.Color.White
        Me.txtCNH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCNH.botaoClear = False
        Me.txtCNH.Campo = ""
        Me.txtCNH.CaracterTipo = "U"
        Me.txtCNH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCNH.ControlDB = Nothing
        Me.txtCNH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNH.Location = New System.Drawing.Point(68, 15)
        Me.txtCNH.MaxLength = 20
        Me.txtCNH.Name = "txtCNH"
        Me.txtCNH.NomeCampoMsg = "CNH"
        Me.txtCNH.Requerido = False
        Me.txtCNH.Size = New System.Drawing.Size(109, 20)
        Me.txtCNH.TabIndex = 0
        Me.txtCNH.Valor = Nothing
        Me.txtCNH.valorVazio = ""
        '
        'FbLabel11
        '
        Me.FbLabel11.AutoSize = True
        Me.FbLabel11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel11.Location = New System.Drawing.Point(33, 18)
        Me.FbLabel11.Name = "FbLabel11"
        Me.FbLabel11.Size = New System.Drawing.Size(33, 13)
        Me.FbLabel11.TabIndex = 166
        Me.FbLabel11.Text = "CNH:"
        '
        'FbLabel14
        '
        Me.FbLabel14.AutoSize = True
        Me.FbLabel14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel14.Location = New System.Drawing.Point(325, 18)
        Me.FbLabel14.Name = "FbLabel14"
        Me.FbLabel14.Size = New System.Drawing.Size(33, 13)
        Me.FbLabel14.TabIndex = 253
        Me.FbLabel14.Text = "Hab.:"
        Me.FbLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDataHabilitacao
        '
        Me.txtDataHabilitacao.BackColor = System.Drawing.Color.White
        Me.txtDataHabilitacao.ControlDB = Nothing
        Me.txtDataHabilitacao.CustomFormat = "dd/MM/yyyy"
        Me.txtDataHabilitacao.DataAtual = False
        Me.txtDataHabilitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataHabilitacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataHabilitacao.Location = New System.Drawing.Point(360, 15)
        Me.txtDataHabilitacao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDataHabilitacao.Name = "txtDataHabilitacao"
        Me.txtDataHabilitacao.NomeCampoMsg = "DataHabilitacao"
        Me.txtDataHabilitacao.Requerido = False
        Me.txtDataHabilitacao.Size = New System.Drawing.Size(95, 20)
        Me.txtDataHabilitacao.TabIndex = 2
        Me.txtDataHabilitacao.Value = New Date(2012, 8, 7, 9, 33, 57, 154)
        '
        'FbLabel23
        '
        Me.FbLabel23.AutoSize = True
        Me.FbLabel23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel23.Location = New System.Drawing.Point(458, 17)
        Me.FbLabel23.Name = "FbLabel23"
        Me.FbLabel23.Size = New System.Drawing.Size(38, 13)
        Me.FbLabel23.TabIndex = 255
        Me.FbLabel23.Text = "Venc.:"
        Me.FbLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDataVencimentoHab
        '
        Me.txtDataVencimentoHab.BackColor = System.Drawing.Color.White
        Me.txtDataVencimentoHab.ControlDB = Nothing
        Me.txtDataVencimentoHab.CustomFormat = "dd/MM/yyyy"
        Me.txtDataVencimentoHab.DataAtual = False
        Me.txtDataVencimentoHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataVencimentoHab.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataVencimentoHab.Location = New System.Drawing.Point(498, 14)
        Me.txtDataVencimentoHab.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDataVencimentoHab.Name = "txtDataVencimentoHab"
        Me.txtDataVencimentoHab.NomeCampoMsg = "DataVencimentoHab"
        Me.txtDataVencimentoHab.Requerido = False
        Me.txtDataVencimentoHab.Size = New System.Drawing.Size(96, 20)
        Me.txtDataVencimentoHab.TabIndex = 3
        Me.txtDataVencimentoHab.Value = New Date(2012, 8, 7, 9, 33, 57, 154)
        '
        'txtCNHTipoCarteira
        '
        Me.txtCNHTipoCarteira.BackColor = System.Drawing.Color.White
        Me.txtCNHTipoCarteira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCNHTipoCarteira.botaoClear = False
        Me.txtCNHTipoCarteira.Campo = ""
        Me.txtCNHTipoCarteira.CaracterTipo = "U"
        Me.txtCNHTipoCarteira.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCNHTipoCarteira.ControlDB = Nothing
        Me.txtCNHTipoCarteira.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNHTipoCarteira.Location = New System.Drawing.Point(214, 14)
        Me.txtCNHTipoCarteira.MaxLength = 2
        Me.txtCNHTipoCarteira.Name = "txtCNHTipoCarteira"
        Me.txtCNHTipoCarteira.NomeCampoMsg = "CNHTipoCarteira"
        Me.txtCNHTipoCarteira.Requerido = False
        Me.txtCNHTipoCarteira.Size = New System.Drawing.Size(32, 20)
        Me.txtCNHTipoCarteira.TabIndex = 1
        Me.txtCNHTipoCarteira.Valor = Nothing
        Me.txtCNHTipoCarteira.valorVazio = ""
        '
        'FbLabel24
        '
        Me.FbLabel24.AutoSize = True
        Me.FbLabel24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel24.Location = New System.Drawing.Point(182, 17)
        Me.FbLabel24.Name = "FbLabel24"
        Me.FbLabel24.Size = New System.Drawing.Size(29, 13)
        Me.FbLabel24.TabIndex = 257
        Me.FbLabel24.Text = "Cat.:"
        '
        'TabPageEX3
        '
        Me.TabPageEX3.Controls.Add(Me.FbLabel54)
        Me.TabPageEX3.Controls.Add(Me.txtProfissao)
        Me.TabPageEX3.Controls.Add(Me.FbLabel39)
        Me.TabPageEX3.Controls.Add(Me.txtSenha)
        Me.TabPageEX3.Controls.Add(Me.FbLabel37)
        Me.TabPageEX3.Controls.Add(Me.txtDataNasc)
        Me.TabPageEX3.Controls.Add(Me.FbLabel31)
        Me.TabPageEX3.Controls.Add(Me.txtMae)
        Me.TabPageEX3.Controls.Add(Me.FbLabel30)
        Me.TabPageEX3.Controls.Add(Me.txtPai)
        Me.TabPageEX3.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEX3.Name = "TabPageEX3"
        Me.TabPageEX3.Size = New System.Drawing.Size(690, 191)
        Me.TabPageEX3.TabIndex = 5
        Me.TabPageEX3.Text = "Inf. Pessoais"
        '
        'FbLabel54
        '
        Me.FbLabel54.AutoSize = True
        Me.FbLabel54.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel54.Location = New System.Drawing.Point(302, 54)
        Me.FbLabel54.Name = "FbLabel54"
        Me.FbLabel54.Size = New System.Drawing.Size(53, 13)
        Me.FbLabel54.TabIndex = 281
        Me.FbLabel54.Text = "Profissao:"
        '
        'txtProfissao
        '
        Me.txtProfissao.BackColor = System.Drawing.Color.White
        Me.txtProfissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProfissao.botaoClear = False
        Me.txtProfissao.Campo = ""
        Me.txtProfissao.CaracterTipo = "U"
        Me.txtProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProfissao.ControlDB = Nothing
        Me.txtProfissao.Location = New System.Drawing.Point(361, 50)
        Me.txtProfissao.MaxLength = 100
        Me.txtProfissao.Name = "txtProfissao"
        Me.txtProfissao.NomeCampoMsg = "Mae"
        Me.txtProfissao.Requerido = False
        Me.txtProfissao.Size = New System.Drawing.Size(234, 20)
        Me.txtProfissao.TabIndex = 280
        Me.txtProfissao.Valor = Nothing
        Me.txtProfissao.valorVazio = ""
        '
        'FbLabel39
        '
        Me.FbLabel39.AutoSize = True
        Me.FbLabel39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel39.Location = New System.Drawing.Point(24, 57)
        Me.FbLabel39.Name = "FbLabel39"
        Me.FbLabel39.Size = New System.Drawing.Size(41, 13)
        Me.FbLabel39.TabIndex = 279
        Me.FbLabel39.Text = "Senha:"
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.White
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSenha.botaoClear = False
        Me.txtSenha.Campo = ""
        Me.txtSenha.CaracterTipo = "U"
        Me.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSenha.ControlDB = Nothing
        Me.txtSenha.Location = New System.Drawing.Point(68, 54)
        Me.txtSenha.MaxLength = 100
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.NomeCampoMsg = "Senha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Requerido = False
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 278
        Me.txtSenha.Valor = Nothing
        Me.txtSenha.valorVazio = ""
        '
        'FbLabel37
        '
        Me.FbLabel37.AutoSize = True
        Me.FbLabel37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel37.Location = New System.Drawing.Point(2, 10)
        Me.FbLabel37.Name = "FbLabel37"
        Me.FbLabel37.Size = New System.Drawing.Size(64, 13)
        Me.FbLabel37.TabIndex = 277
        Me.FbLabel37.Text = "Data Nasc.:"
        Me.FbLabel37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDataNasc
        '
        Me.txtDataNasc.BackColor = System.Drawing.Color.White
        Me.txtDataNasc.ControlDB = Nothing
        Me.txtDataNasc.CustomFormat = "dd/MM/yyyy"
        Me.txtDataNasc.DataAtual = False
        Me.txtDataNasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataNasc.Location = New System.Drawing.Point(68, 7)
        Me.txtDataNasc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDataNasc.Name = "txtDataNasc"
        Me.txtDataNasc.NomeCampoMsg = "DataNasc"
        Me.txtDataNasc.Requerido = False
        Me.txtDataNasc.Size = New System.Drawing.Size(85, 20)
        Me.txtDataNasc.TabIndex = 276
        Me.txtDataNasc.Value = New Date(2012, 8, 7, 9, 33, 57, 295)
        '
        'FbLabel31
        '
        Me.FbLabel31.AutoSize = True
        Me.FbLabel31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel31.Location = New System.Drawing.Point(326, 13)
        Me.FbLabel31.Name = "FbLabel31"
        Me.FbLabel31.Size = New System.Drawing.Size(31, 13)
        Me.FbLabel31.TabIndex = 275
        Me.FbLabel31.Text = "Mãe:"
        '
        'txtMae
        '
        Me.txtMae.BackColor = System.Drawing.Color.White
        Me.txtMae.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMae.botaoClear = False
        Me.txtMae.Campo = ""
        Me.txtMae.CaracterTipo = "U"
        Me.txtMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMae.ControlDB = Nothing
        Me.txtMae.Location = New System.Drawing.Point(360, 10)
        Me.txtMae.MaxLength = 100
        Me.txtMae.Name = "txtMae"
        Me.txtMae.NomeCampoMsg = "Mae"
        Me.txtMae.Requerido = False
        Me.txtMae.Size = New System.Drawing.Size(234, 20)
        Me.txtMae.TabIndex = 273
        Me.txtMae.Valor = Nothing
        Me.txtMae.valorVazio = ""
        '
        'FbLabel30
        '
        Me.FbLabel30.AutoSize = True
        Me.FbLabel30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel30.Location = New System.Drawing.Point(40, 34)
        Me.FbLabel30.Name = "FbLabel30"
        Me.FbLabel30.Size = New System.Drawing.Size(25, 13)
        Me.FbLabel30.TabIndex = 274
        Me.FbLabel30.Text = "Pai:"
        '
        'txtPai
        '
        Me.txtPai.BackColor = System.Drawing.Color.White
        Me.txtPai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPai.botaoClear = False
        Me.txtPai.Campo = ""
        Me.txtPai.CaracterTipo = "U"
        Me.txtPai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPai.ControlDB = Nothing
        Me.txtPai.Location = New System.Drawing.Point(68, 31)
        Me.txtPai.MaxLength = 100
        Me.txtPai.Name = "txtPai"
        Me.txtPai.NomeCampoMsg = "Pai"
        Me.txtPai.Requerido = False
        Me.txtPai.Size = New System.Drawing.Size(178, 20)
        Me.txtPai.TabIndex = 272
        Me.txtPai.Valor = Nothing
        Me.txtPai.valorVazio = ""
        '
        'TabPageEX5
        '
        Me.TabPageEX5.Controls.Add(Me.dgvDom)
        Me.TabPageEX5.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEX5.Name = "TabPageEX5"
        Me.TabPageEX5.Size = New System.Drawing.Size(690, 191)
        Me.TabPageEX5.TabIndex = 7
        Me.TabPageEX5.Text = "Domicílios"
        '
        'dgvDom
        '
        Me.dgvDom.AllowUserToAddRows = False
        Me.dgvDom.AllowUserToDeleteRows = False
        Me.dgvDom.AllowUserToResizeRows = False
        Me.dgvDom.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDom.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDom.colunaID = "ID"
        Me.dgvDom.ColunaSeleciona = False
        Me.dgvDom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDom.idSel = -1
        Me.dgvDom.Location = New System.Drawing.Point(0, 0)
        Me.dgvDom.MultiSelect = False
        Me.dgvDom.Name = "dgvDom"
        Me.dgvDom.ReadOnly = True
        Me.dgvDom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDom.RowHeadersVisible = False
        Me.dgvDom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDom.Size = New System.Drawing.Size(690, 191)
        Me.dgvDom.TabIndex = 0
        '
        'TabPageEX8
        '
        Me.TabPageEX8.Controls.Add(Me.dgvAgente)
        Me.TabPageEX8.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEX8.Name = "TabPageEX8"
        Me.TabPageEX8.Size = New System.Drawing.Size(690, 191)
        Me.TabPageEX8.TabIndex = 10
        Me.TabPageEX8.Text = "Referentes"
        '
        'dgvAgente
        '
        Me.dgvAgente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvAgente.campoID = "ID"
        Me.dgvAgente.camposVisiveis = Nothing
        Me.dgvAgente.DataTable = Nothing
        Me.dgvAgente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAgente.Formulario = Nothing
        Me.dgvAgente.FormularioPai = Nothing
        Me.dgvAgente.FormularioPaiCad = Nothing
        Me.dgvAgente.IDItem = -1
        Me.dgvAgente.IDRelacionamento = -1
        Me.dgvAgente.liberaEditar = True
        Me.dgvAgente.liberaExcluir = True
        Me.dgvAgente.liberaInserir = True
        Me.dgvAgente.Location = New System.Drawing.Point(0, 0)
        Me.dgvAgente.Name = "dgvAgente"
        Me.dgvAgente.Parametro = ""
        Me.dgvAgente.SalvarDadosForm = False
        Me.dgvAgente.showPrint = False
        Me.dgvAgente.Size = New System.Drawing.Size(690, 191)
        Me.dgvAgente.SqlDados = ""
        Me.dgvAgente.TabIndex = 4
        Me.dgvAgente.textPrint = ""
        Me.dgvAgente.TotalRegistrosVisivel = False
        Me.dgvAgente.usarSalvar = True
        Me.dgvAgente.visualizarBarra = True
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel2.Location = New System.Drawing.Point(419, 108)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(43, 13)
        Me.FbLabel2.TabIndex = 165
        Me.FbLabel2.Text = "Código:"
        '
        'FbLabel8
        '
        Me.FbLabel8.AutoSize = True
        Me.FbLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel8.Location = New System.Drawing.Point(435, 82)
        Me.FbLabel8.Name = "FbLabel8"
        Me.FbLabel8.Size = New System.Drawing.Size(26, 13)
        Me.FbLabel8.TabIndex = 167
        Me.FbLabel8.Text = "RG:"
        '
        'FbLabel9
        '
        Me.FbLabel9.AutoSize = True
        Me.FbLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel9.Location = New System.Drawing.Point(20, 32)
        Me.FbLabel9.Name = "FbLabel9"
        Me.FbLabel9.Size = New System.Drawing.Size(50, 13)
        Me.FbLabel9.TabIndex = 171
        Me.FbLabel9.Text = "Fantasia:"
        '
        'txtFantasia
        '
        Me.txtFantasia.BackColor = System.Drawing.Color.White
        Me.txtFantasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFantasia.botaoClear = False
        Me.txtFantasia.Campo = ""
        Me.txtFantasia.CaracterTipo = "U"
        Me.txtFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFantasia.ControlDB = Nothing
        Me.txtFantasia.Location = New System.Drawing.Point(72, 29)
        Me.txtFantasia.MaxLength = 100
        Me.txtFantasia.Name = "txtFantasia"
        Me.txtFantasia.NomeCampoMsg = "Fantasia"
        Me.txtFantasia.Requerido = False
        Me.txtFantasia.Size = New System.Drawing.Size(626, 20)
        Me.txtFantasia.TabIndex = 1
        Me.txtFantasia.Valor = Nothing
        Me.txtFantasia.valorVazio = ""
        '
        'FbLabel12
        '
        Me.FbLabel12.AutoSize = True
        Me.FbLabel12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel12.Location = New System.Drawing.Point(25, 32)
        Me.FbLabel12.Name = "FbLabel12"
        Me.FbLabel12.Size = New System.Drawing.Size(45, 13)
        Me.FbLabel12.TabIndex = 172
        Me.FbLabel12.Text = "Pessoa:"
        '
        'txtIE
        '
        Me.txtIE.BackColor = System.Drawing.Color.White
        Me.txtIE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIE.botaoClear = False
        Me.txtIE.Campo = ""
        Me.txtIE.CaracterTipo = "U"
        Me.txtIE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIE.ControlDB = Nothing
        Me.txtIE.Location = New System.Drawing.Point(464, 78)
        Me.txtIE.MaxLength = 100
        Me.txtIE.Name = "txtIE"
        Me.txtIE.NomeCampoMsg = "IE"
        Me.txtIE.Requerido = False
        Me.txtIE.Size = New System.Drawing.Size(234, 20)
        Me.txtIE.TabIndex = 7
        Me.txtIE.Valor = Nothing
        Me.txtIE.valorVazio = ""
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.botaoClear = False
        Me.txtCodigo.Campo = ""
        Me.txtCodigo.CaracterTipo = "U"
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.ControlDB = Nothing
        Me.txtCodigo.Location = New System.Drawing.Point(464, 104)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.NomeCampoMsg = "Codigo"
        Me.txtCodigo.Requerido = False
        Me.txtCodigo.Size = New System.Drawing.Size(234, 20)
        Me.txtCodigo.TabIndex = 4
        Me.txtCodigo.Valor = Nothing
        Me.txtCodigo.valorVazio = ""
        '
        'FbButtonVisual1
        '
        Me.FbButtonVisual1.BackColor = System.Drawing.Color.SteelBlue
        Me.FbButtonVisual1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButtonVisual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbButtonVisual1.ForeColor = System.Drawing.Color.White
        Me.FbButtonVisual1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FbButtonVisual1.Location = New System.Drawing.Point(633, 5)
        Me.FbButtonVisual1.Name = "FbButtonVisual1"
        Me.FbButtonVisual1.Size = New System.Drawing.Size(52, 44)
        Me.FbButtonVisual1.TabIndex = 172
        Me.FbButtonVisual1.Text = "Etiqueta"
        '
        'FbButtonVisual2
        '
        Me.FbButtonVisual2.BackColor = System.Drawing.Color.SteelBlue
        Me.FbButtonVisual2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButtonVisual2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbButtonVisual2.ForeColor = System.Drawing.Color.White
        Me.FbButtonVisual2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FbButtonVisual2.Location = New System.Drawing.Point(578, 5)
        Me.FbButtonVisual2.Name = "FbButtonVisual2"
        Me.FbButtonVisual2.Size = New System.Drawing.Size(52, 44)
        Me.FbButtonVisual2.TabIndex = 173
        Me.FbButtonVisual2.Text = "Ficha"
        '
        'TAG
        '
        Me.TAG.AutoSize = True
        Me.TAG.Location = New System.Drawing.Point(22, 108)
        Me.TAG.Name = "TAG"
        Me.TAG.Size = New System.Drawing.Size(47, 13)
        Me.TAG.TabIndex = 173
        Me.TAG.Text = "N° TAG:"
        '
        'cbbTAG
        '
        Me.cbbTAG.AgrupadoPor = Nothing
        Me.cbbTAG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbTAG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbTAG.BackColor = System.Drawing.Color.LightBlue
        Me.cbbTAG.Campo = ""
        Me.cbbTAG.campoID = "IDTag"
        Me.cbbTAG.campoOrdem = Nothing
        Me.cbbTAG.campoRelacionamento = Nothing
        Me.cbbTAG.campoSelecionavel = "Numero"
        Me.cbbTAG.campoSql = Nothing
        Me.cbbTAG.campoSqlID = Nothing
        Me.cbbTAG.carrega2Parametro = False
        Me.cbbTAG.carregaClick = True
        Me.cbbTAG.comDistinct = False
        Me.cbbTAG.ControlDB = Nothing
        Me.cbbTAG.DisplayMember = "Texto"
        Me.cbbTAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTAG.Filtro = Nothing
        Me.cbbTAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbTAG.FormattingEnabled = True
        Me.cbbTAG.Location = New System.Drawing.Point(72, 103)
        Me.cbbTAG.Name = "cbbTAG"
        Me.cbbTAG.NomeCampoMsg = "TAG"
        Me.cbbTAG.Ordena = Nothing
        Me.cbbTAG.Requerido = True
        Me.cbbTAG.Size = New System.Drawing.Size(225, 21)
        Me.cbbTAG.TabelaRelacionamento = "TB_AUTOMACAO_TAG"
        Me.cbbTAG.TabIndex = 175
        Me.cbbTAG.TextoSelecionar = "Selecione a TAG"
        Me.cbbTAG.Valor = Nothing
        Me.cbbTAG.ValorRelacionamento = Nothing
        Me.cbbTAG.ValorSelecionado = "-1"
        Me.cbbTAG.valorVazio = -1
        Me.cbbTAG.ValueMember = "Valor"
        '
        'frmPessoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.campoFoco = Me.txtNome
        Me.ClientSize = New System.Drawing.Size(719, 499)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPessoa"
        Me.Text = "1.1.3.Cadastro de Pessoa"
        Me.menuFiltro.ResumeLayout(False)
        Me.menuFiltro.PerformLayout()
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlCampos.PerformLayout()
        Me.pnlBarra.ResumeLayout(False)
        Me.tpeEmpresa.ResumeLayout(False)
        Me.TabPageEX4.ResumeLayout(False)
        Me.TabPageEX4.PerformLayout()
        CType(Me.txtAdicNoturno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrExtra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComissao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageEX6.ResumeLayout(False)
        Me.TabPageEX7.ResumeLayout(False)
        Me.tpeEndereco.ResumeLayout(False)
        Me.tpeEndereco.PerformLayout()
        Me.tpeInfComplementar.ResumeLayout(False)
        Me.tpeInfComplementar.PerformLayout()
        Me.FbGroupBox5.ResumeLayout(False)
        Me.FbGroupBox5.PerformLayout()
        Me.FbGroupBox4.ResumeLayout(False)
        Me.FbGroupBox4.PerformLayout()
        CType(Me.ptbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpeConf.ResumeLayout(False)
        Me.tpeConf.PerformLayout()
        Me.TabPageEX2.ResumeLayout(False)
        Me.FbGroupBox3.ResumeLayout(False)
        Me.FbGroupBox3.PerformLayout()
        Me.FbGroupBox2.ResumeLayout(False)
        Me.FbGroupBox2.PerformLayout()
        Me.FbGroupBox1.ResumeLayout(False)
        Me.FbGroupBox1.PerformLayout()
        Me.TabPageEX3.ResumeLayout(False)
        Me.TabPageEX3.PerformLayout()
        Me.TabPageEX5.ResumeLayout(False)
        CType(Me.dgvDom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageEX8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbbTipoCad As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel3 As FeedAutomacao.fbLabel
    Friend WithEvents FbLabel1 As FeedAutomacao.fbLabel
    Friend WithEvents txtNome As FeedAutomacao.fbTextBox
    Friend WithEvents txtCGC As FeedAutomacao.fbMaskBox
    Friend WithEvents FbLabel4 As FeedAutomacao.fbLabel
    Friend WithEvents cbbTipoPessoa As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel5 As FeedAutomacao.fbLabel
    Friend WithEvents pesContaCont As FeedAutomacao.fbLookUpTreeView
    Friend WithEvents FbLabel6 As FeedAutomacao.fbLabel
    Friend WithEvents tpeEmpresa As FeedAutomacao.fbTabPage
    Friend WithEvents tpeEndereco As Dotnetrix.Controls.TabPageEX
    Friend WithEvents FbLabel21 As FeedAutomacao.fbLabel
    Friend WithEvents FbLabel20 As FeedAutomacao.fbLabel
    Friend WithEvents txtComplemento As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel19 As FeedAutomacao.fbLabel
    Friend WithEvents txtBairro As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel18 As FeedAutomacao.fbLabel
    Friend WithEvents txtLogradouro As FeedAutomacao.fbTextBox
    Friend WithEvents txtCidade As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel17 As FeedAutomacao.fbLabel
    Friend WithEvents txtEstado As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel16 As FeedAutomacao.fbLabel
    Friend WithEvents FbLabel15 As FeedAutomacao.fbLabel
    Friend WithEvents txtCEP As FeedAutomacao.fbMaskBox
    Friend WithEvents tpeInfComplementar As Dotnetrix.Controls.TabPageEX
    Friend WithEvents FbLabel27 As FeedAutomacao.fbLabel
    Friend WithEvents txtCel As FeedAutomacao.fbMaskBox
    Friend WithEvents ptbImagem As FeedAutomacao.fbPicturebox
    Friend WithEvents FbLabel26 As FeedAutomacao.fbLabel
    Friend WithEvents txtTelefone As FeedAutomacao.fbMaskBox
    Friend WithEvents FbLabel22 As FeedAutomacao.fbLabel
    Friend WithEvents txtEmail As FeedAutomacao.fbTextBox
    Friend WithEvents tpeConf As Dotnetrix.Controls.TabPageEX
    Friend WithEvents cbbTipoFiscal As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel7 As FeedAutomacao.fbLabel
    Friend WithEvents FbLabel2 As FeedAutomacao.fbLabel
    Friend WithEvents FbLabel9 As FeedAutomacao.fbLabel
    Friend WithEvents txtFantasia As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel8 As FeedAutomacao.fbLabel
    Friend WithEvents btnBuscaCep As FeedAutomacao.fbButtonVisual
    Friend WithEvents FbLabel12 As FeedAutomacao.fbLabel
    Friend WithEvents btnLimpar As FeedAutomacao.fbButtonVisual
    Friend WithEvents txtIE As FeedAutomacao.fbTextBox
    Friend WithEvents txtCodigo As FeedAutomacao.fbTextBox
    Friend WithEvents TabPageEX1 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents btnBuscarCep As FeedAutomacao.fbButtonVisual
    Friend WithEvents TabPageEX2 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents FbGroupBox3 As FeedAutomacao.fbGroupBox
    Friend WithEvents txtRg As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel32 As FeedAutomacao.fbLabel
    Friend WithEvents txtRGexp As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel33 As FeedAutomacao.fbLabel
    Friend WithEvents FbLabel34 As FeedAutomacao.fbLabel
    Friend WithEvents txtDataExpRG As FeedAutomacao.fbDate
    Friend WithEvents FbGroupBox2 As FeedAutomacao.fbGroupBox
    Friend WithEvents txtCTPSSerie As FeedAutomacao.fbTextBox
    Friend WithEvents txtCTPS As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel13 As FeedAutomacao.fbLabel
    Friend WithEvents FbLabel25 As FeedAutomacao.fbLabel
    Friend WithEvents txtCTPSPis As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel29 As FeedAutomacao.fbLabel
    Friend WithEvents FbGroupBox1 As FeedAutomacao.fbGroupBox
    Friend WithEvents txtCNH As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel11 As FeedAutomacao.fbLabel
    Friend WithEvents FbLabel14 As FeedAutomacao.fbLabel
    Friend WithEvents txtDataHabilitacao As FeedAutomacao.fbDate
    Friend WithEvents FbLabel23 As FeedAutomacao.fbLabel
    Friend WithEvents txtDataVencimentoHab As FeedAutomacao.fbDate
    Friend WithEvents txtCNHTipoCarteira As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel24 As FeedAutomacao.fbLabel
    Friend WithEvents TabPageEX3 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents FbLabel37 As FeedAutomacao.fbLabel
    Friend WithEvents txtDataNasc As FeedAutomacao.fbDate
    Friend WithEvents FbLabel31 As FeedAutomacao.fbLabel
    Friend WithEvents txtMae As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel30 As FeedAutomacao.fbLabel
    Friend WithEvents txtPai As FeedAutomacao.fbTextBox
    Friend WithEvents TabPageEX4 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents FbLabel38 As FeedAutomacao.fbLabel
    Friend WithEvents txtAdmissao As FeedAutomacao.fbDate
    Friend WithEvents cbbCargo As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel36 As FeedAutomacao.fbLabel
    Friend WithEvents cbbSetor As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel35 As FeedAutomacao.fbLabel
    Friend WithEvents FbGroupBox4 As FeedAutomacao.fbGroupBox
    Friend WithEvents rbInativo As FeedAutomacao.fbRadioButton
    Friend WithEvents rbAtivo As FeedAutomacao.fbRadioButton
    Friend WithEvents ckbFiscal As FeedAutomacao.fbCheckBox
    Friend WithEvents FbButtonVisual1 As FeedAutomacao.fbButtonVisual
    Friend WithEvents FbLabel39 As FeedAutomacao.fbLabel
    Friend WithEvents txtSenha As FeedAutomacao.fbTextBox
    Friend WithEvents TabPageEX5 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents FbButtonVisual2 As FeedAutomacao.fbButtonVisual
    Friend WithEvents FbLabel28 As FeedAutomacao.fbLabel
    Friend WithEvents txtObs As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel40 As FeedAutomacao.fbLabel
    Friend WithEvents txtCel2 As FeedAutomacao.fbMaskBox
    Friend WithEvents FbLabel41 As FeedAutomacao.fbLabel
    Friend WithEvents txtTelCom As FeedAutomacao.fbMaskBox
    Friend WithEvents dgvDom As FeedAutomacao.fbGridview
    Friend WithEvents TabPageEX6 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents dgvLote As FeedAutomacao.fbGridDados
    Friend WithEvents ckbSenar As FeedAutomacao.fbCheckBox
    Friend WithEvents ckbFunRural As FeedAutomacao.fbCheckBox
    Friend WithEvents ckbICMS As FeedAutomacao.fbCheckBox
    Friend WithEvents FbLabel43 As FeedAutomacao.fbLabel
    Friend WithEvents txtComissao As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtVlrHora As FeedAutomacao.fbNumericBox
    Friend WithEvents lblVlrHora As FeedAutomacao.fbLabel
    Friend WithEvents FbLabel45 As FeedAutomacao.fbLabel
    Friend WithEvents txtAdicNoturno As System.Windows.Forms.NumericUpDown
    Friend WithEvents FbLabel44 As FeedAutomacao.fbLabel
    Friend WithEvents txtHrExtra As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtNumero As fbTextBox
    Friend WithEvents FbGroupBox5 As fbGroupBox
    Friend WithEvents cbbEstadoCivilInterv As fbComboBox
    Friend WithEvents FbLabel49 As fbLabel
    Friend WithEvents FbLabel48 As fbLabel
    Friend WithEvents txtCPFInteerv As fbMaskBox
    Friend WithEvents FbLabel47 As fbLabel
    Friend WithEvents txtEnderecoInterv As fbTextBox
    Friend WithEvents FbLabel46 As fbLabel
    Friend WithEvents txtInterveniente As fbTextBox
    Friend WithEvents FbButtonVisual3 As fbButtonVisual
    Friend WithEvents FbButtonVisual4 As fbButtonVisual
    Friend WithEvents cbbCidadeInterv As fbComboBox
    Friend WithEvents FbLabel50 As fbLabel
    Friend WithEvents cbbEstadoInterv As fbComboBox
    Friend WithEvents FbLabel51 As fbLabel
    Friend WithEvents FbLabel52 As fbLabel
    Friend WithEvents txtCepInterv As fbMaskBox
    Friend WithEvents FbLabel53 As fbLabel
    Friend WithEvents txtBairroInterv As fbTextBox
    Friend WithEvents FbLabel54 As fbLabel
    Friend WithEvents txtProfissao As fbTextBox
    Friend WithEvents FbLabel55 As fbLabel
    Friend WithEvents lkpDomicilio As fbLookUp
    Friend WithEvents TabPageEX7 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents dgvRedeSocial As fbGridDados
    Friend WithEvents TabPageEX8 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents dgvAgente As fbGridDados
    Friend WithEvents TAG As Label
    Friend WithEvents cbbTAG As fbComboBox
End Class
