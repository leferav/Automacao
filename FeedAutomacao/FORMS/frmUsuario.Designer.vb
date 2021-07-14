<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.txtNome = New FeedAutomacao.fbTextBox()
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.FbLabel3 = New FeedAutomacao.fbLabel()
        Me.txtSenha = New FeedAutomacao.fbTextBox()
        Me.txtRepeteSenha = New FeedAutomacao.fbTextBox()
        Me.FbLabel4 = New FeedAutomacao.fbLabel()
        Me.FbLabel5 = New FeedAutomacao.fbLabel()
        Me.FbPanel1 = New FeedAutomacao.fbPanel()
        Me.txtObservacao = New FeedAutomacao.fbTextBox()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.cbbAtendente = New FeedAutomacao.fbComboBox()
        Me.FbLabel6 = New FeedAutomacao.fbLabel()
        Me.ckAtivo = New FeedAutomacao.fbCheckBox()
        Me.ckLogado = New FeedAutomacao.fbCheckBox()
        Me.menuFiltro.SuspendLayout()
        Me.pnlCampos.SuspendLayout()
        Me.pnlBarra.SuspendLayout()
        Me.FbPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuFiltro
        '
        Me.menuFiltro.Controls.Add(Me.FbLabel3)
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(636, 57)
        Me.menuFiltro.Controls.SetChildIndex(Me.pesDados, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel3, 0)
        '
        'pesDados
        '
        Me.pesDados.Location = New System.Drawing.Point(63, 29)
        Me.pesDados.Size = New System.Drawing.Size(565, 20)
        '
        'pnlCampos
        '
        Me.pnlCampos.Controls.Add(Me.ckLogado)
        Me.pnlCampos.Controls.Add(Me.ckAtivo)
        Me.pnlCampos.Controls.Add(Me.FbLabel6)
        Me.pnlCampos.Controls.Add(Me.cbbAtendente)
        Me.pnlCampos.Controls.Add(Me.FbLabel2)
        Me.pnlCampos.Controls.Add(Me.txtObservacao)
        Me.pnlCampos.Controls.Add(Me.FbPanel1)
        Me.pnlCampos.Location = New System.Drawing.Point(0, 57)
        Me.pnlCampos.Size = New System.Drawing.Size(636, 108)
        '
        'FbBarra1
        '
        Me.FbBarra1.frmCadastro = Me
        Me.FbBarra1.Location = New System.Drawing.Point(58, 3)
        '
        'pnlBarra
        '
        Me.pnlBarra.Location = New System.Drawing.Point(0, 165)
        Me.pnlBarra.Size = New System.Drawing.Size(636, 53)
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.LightBlue
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.botaoClear = False
        Me.txtNome.Campo = ""
        Me.txtNome.CaracterTipo = "U"
        Me.txtNome.ControlDB = Nothing
        Me.txtNome.Location = New System.Drawing.Point(140, 6)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.NomeCampoMsg = "FbTextBox1"
        Me.txtNome.Requerido = True
        Me.txtNome.Size = New System.Drawing.Size(136, 20)
        Me.txtNome.TabIndex = 0
        Me.txtNome.Valor = Nothing
        Me.txtNome.valorVazio = ""
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel1.Location = New System.Drawing.Point(100, 10)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(38, 13)
        Me.FbLabel1.TabIndex = 1
        Me.FbLabel1.Text = "Nome:"
        '
        'FbLabel3
        '
        Me.FbLabel3.AutoSize = True
        Me.FbLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel3.Location = New System.Drawing.Point(15, 32)
        Me.FbLabel3.Name = "FbLabel3"
        Me.FbLabel3.Size = New System.Drawing.Size(46, 13)
        Me.FbLabel3.TabIndex = 5
        Me.FbLabel3.Text = "Usuario:"
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.LightBlue
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSenha.botaoClear = False
        Me.txtSenha.Campo = ""
        Me.txtSenha.CaracterTipo = "U"
        Me.txtSenha.ControlDB = Nothing
        Me.txtSenha.Location = New System.Drawing.Point(140, 32)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.NomeCampoMsg = "FbTextBox1"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Requerido = True
        Me.txtSenha.Size = New System.Drawing.Size(136, 20)
        Me.txtSenha.TabIndex = 4
        Me.txtSenha.Valor = Nothing
        Me.txtSenha.valorVazio = ""
        '
        'txtRepeteSenha
        '
        Me.txtRepeteSenha.BackColor = System.Drawing.Color.LightBlue
        Me.txtRepeteSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRepeteSenha.botaoClear = False
        Me.txtRepeteSenha.Campo = ""
        Me.txtRepeteSenha.CaracterTipo = "U"
        Me.txtRepeteSenha.ControlDB = Nothing
        Me.txtRepeteSenha.Location = New System.Drawing.Point(140, 58)
        Me.txtRepeteSenha.Name = "txtRepeteSenha"
        Me.txtRepeteSenha.NomeCampoMsg = "FbTextBox1"
        Me.txtRepeteSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepeteSenha.Requerido = True
        Me.txtRepeteSenha.Size = New System.Drawing.Size(136, 20)
        Me.txtRepeteSenha.TabIndex = 5
        Me.txtRepeteSenha.Valor = Nothing
        Me.txtRepeteSenha.valorVazio = ""
        '
        'FbLabel4
        '
        Me.FbLabel4.AutoSize = True
        Me.FbLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel4.Location = New System.Drawing.Point(97, 34)
        Me.FbLabel4.Name = "FbLabel4"
        Me.FbLabel4.Size = New System.Drawing.Size(41, 13)
        Me.FbLabel4.TabIndex = 6
        Me.FbLabel4.Text = "Senha:"
        '
        'FbLabel5
        '
        Me.FbLabel5.AutoSize = True
        Me.FbLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel5.Location = New System.Drawing.Point(55, 61)
        Me.FbLabel5.Name = "FbLabel5"
        Me.FbLabel5.Size = New System.Drawing.Size(84, 13)
        Me.FbLabel5.TabIndex = 7
        Me.FbLabel5.Text = "Repita a Senha:"
        '
        'FbPanel1
        '
        Me.FbPanel1.BackColor = System.Drawing.SystemColors.Window
        Me.FbPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FbPanel1.Controls.Add(Me.txtSenha)
        Me.FbPanel1.Controls.Add(Me.FbLabel5)
        Me.FbPanel1.Controls.Add(Me.txtNome)
        Me.FbPanel1.Controls.Add(Me.FbLabel4)
        Me.FbPanel1.Controls.Add(Me.FbLabel1)
        Me.FbPanel1.Controls.Add(Me.txtRepeteSenha)
        Me.FbPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FbPanel1.Name = "FbPanel1"
        Me.FbPanel1.Size = New System.Drawing.Size(286, 95)
        Me.FbPanel1.TabIndex = 8
        '
        'txtObservacao
        '
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacao.botaoClear = False
        Me.txtObservacao.Campo = ""
        Me.txtObservacao.CaracterTipo = "U"
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.ControlDB = Nothing
        Me.txtObservacao.Location = New System.Drawing.Point(365, 5)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.NomeCampoMsg = "FbTextBox1"
        Me.txtObservacao.Requerido = False
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObservacao.Size = New System.Drawing.Size(263, 50)
        Me.txtObservacao.TabIndex = 9
        Me.txtObservacao.Valor = Nothing
        Me.txtObservacao.valorVazio = ""
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel2.Location = New System.Drawing.Point(296, 8)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(68, 13)
        Me.FbLabel2.TabIndex = 10
        Me.FbLabel2.Text = "Observação:"
        '
        'cbbAtendente
        '
        Me.cbbAtendente.AgrupadoPor = Nothing
        Me.cbbAtendente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbAtendente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbAtendente.BackColor = System.Drawing.Color.LightBlue
        Me.cbbAtendente.Campo = ""
        Me.cbbAtendente.campoID = "ID"
        Me.cbbAtendente.campoOrdem = Nothing
        Me.cbbAtendente.campoRelacionamento = Nothing
        Me.cbbAtendente.campoSelecionavel = "NOME"
        Me.cbbAtendente.campoSql = Nothing
        Me.cbbAtendente.campoSqlID = Nothing
        Me.cbbAtendente.carrega2Parametro = False
        Me.cbbAtendente.carregaClick = True
        Me.cbbAtendente.comDistinct = False
        Me.cbbAtendente.ControlDB = Nothing
        Me.cbbAtendente.DisplayMember = "Texto"
        Me.cbbAtendente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbAtendente.Filtro = Nothing
        Me.cbbAtendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbAtendente.FormattingEnabled = True
        Me.cbbAtendente.Location = New System.Drawing.Point(365, 63)
        Me.cbbAtendente.Name = "cbbAtendente"
        Me.cbbAtendente.NomeCampoMsg = "FbComboBox1"
        Me.cbbAtendente.Ordena = Nothing
        Me.cbbAtendente.Requerido = True
        Me.cbbAtendente.Size = New System.Drawing.Size(263, 21)
        Me.cbbAtendente.TabelaRelacionamento = "TB_ATENDENTES"
        Me.cbbAtendente.TabIndex = 11
        Me.cbbAtendente.TextoSelecionar = "Selecione o Atendente"
        Me.cbbAtendente.Valor = Nothing
        Me.cbbAtendente.ValorRelacionamento = Nothing
        Me.cbbAtendente.ValorSelecionado = "-1"
        Me.cbbAtendente.valorVazio = -1
        Me.cbbAtendente.ValueMember = "Valor"
        '
        'FbLabel6
        '
        Me.FbLabel6.AutoSize = True
        Me.FbLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel6.Location = New System.Drawing.Point(303, 66)
        Me.FbLabel6.Name = "FbLabel6"
        Me.FbLabel6.Size = New System.Drawing.Size(62, 13)
        Me.FbLabel6.TabIndex = 12
        Me.FbLabel6.Text = "Atendente :"
        '
        'ckAtivo
        '
        Me.ckAtivo.AutoSize = True
        Me.ckAtivo.Campo = ""
        Me.ckAtivo.ControlDB = Nothing
        Me.ckAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ckAtivo.Location = New System.Drawing.Point(581, 89)
        Me.ckAtivo.Name = "ckAtivo"
        Me.ckAtivo.Size = New System.Drawing.Size(47, 17)
        Me.ckAtivo.TabIndex = 13
        Me.ckAtivo.Text = "Ativo"
        Me.ckAtivo.UseVisualStyleBackColor = True
        Me.ckAtivo.Valor = Nothing
        Me.ckAtivo.valorVazio = False
        '
        'ckLogado
        '
        Me.ckLogado.AutoSize = True
        Me.ckLogado.Campo = ""
        Me.ckLogado.ControlDB = Nothing
        Me.ckLogado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ckLogado.Location = New System.Drawing.Point(365, 88)
        Me.ckLogado.Name = "ckLogado"
        Me.ckLogado.Size = New System.Drawing.Size(59, 17)
        Me.ckLogado.TabIndex = 14
        Me.ckLogado.Text = "Logado"
        Me.ckLogado.UseVisualStyleBackColor = True
        Me.ckLogado.Valor = Nothing
        Me.ckLogado.valorVazio = False
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(636, 218)
        Me.Name = "frmUsuario"
        Me.Text = "Cadastro de Usuários"
        Me.menuFiltro.ResumeLayout(False)
        Me.menuFiltro.PerformLayout()
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlCampos.PerformLayout()
        Me.pnlBarra.ResumeLayout(False)
        Me.FbPanel1.ResumeLayout(False)
        Me.FbPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtNome As fbTextBox
    Friend WithEvents FbLabel1 As fbLabel
    Friend WithEvents FbLabel3 As fbLabel
    Friend WithEvents FbPanel1 As fbPanel
    Friend WithEvents txtSenha As fbTextBox
    Friend WithEvents FbLabel5 As fbLabel
    Friend WithEvents FbLabel4 As fbLabel
    Friend WithEvents txtRepeteSenha As fbTextBox
    Friend WithEvents FbLabel2 As fbLabel
    Friend WithEvents txtObservacao As fbTextBox
    Friend WithEvents FbLabel6 As fbLabel
    Friend WithEvents cbbAtendente As fbComboBox
    Friend WithEvents ckAtivo As fbCheckBox
    Friend WithEvents ckLogado As fbCheckBox
End Class
