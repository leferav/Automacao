<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroTelaReferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroTelaReferencia))
        Me.txtTipo = New FeedAutomacao.fbTextBox()
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.txtObservacao = New FeedAutomacao.fbTextBox()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.txtNumeroTela = New FeedAutomacao.fbTextBox()
        Me.FbLabel3 = New FeedAutomacao.fbLabel()
        Me.txtTabela = New FeedAutomacao.fbTextBox()
        Me.FbLabel4 = New FeedAutomacao.fbLabel()
        Me.FbLabel5 = New FeedAutomacao.fbLabel()
        Me.cbbSistema = New FeedAutomacao.fbComboBox()
        Me.FbGroupBox1 = New FeedAutomacao.fbGroupBox()
        Me.menuFiltro.SuspendLayout()
        Me.pnlCampos.SuspendLayout()
        Me.pnlBarra.SuspendLayout()
        Me.FbGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuFiltro
        '
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(687, 57)
        Me.menuFiltro.Controls.SetChildIndex(Me.pesDados, 0)
        '
        'pesDados
        '
        Me.pesDados.Size = New System.Drawing.Size(655, 20)
        '
        'pnlCampos
        '
        Me.pnlCampos.Controls.Add(Me.FbGroupBox1)
        Me.pnlCampos.Controls.Add(Me.FbLabel2)
        Me.pnlCampos.Controls.Add(Me.txtObservacao)
        Me.pnlCampos.Location = New System.Drawing.Point(0, 57)
        Me.pnlCampos.Size = New System.Drawing.Size(687, 178)
        '
        'FbBarra1
        '
        Me.FbBarra1.frmCadastro = Me
        Me.FbBarra1.Location = New System.Drawing.Point(139, 3)
        Me.FbBarra1.Size = New System.Drawing.Size(563, 44)
        '
        'pnlBarra
        '
        Me.pnlBarra.Location = New System.Drawing.Point(0, 235)
        Me.pnlBarra.Size = New System.Drawing.Size(687, 53)
        '
        'txtTipo
        '
        Me.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipo.botaoClear = False
        Me.txtTipo.Campo = ""
        Me.txtTipo.CaracterTipo = "U"
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.ControlDB = Nothing
        Me.txtTipo.Location = New System.Drawing.Point(65, 19)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.NomeCampoMsg = "FbTextBox1"
        Me.txtTipo.Requerido = False
        Me.txtTipo.Size = New System.Drawing.Size(321, 20)
        Me.txtTipo.TabIndex = 0
        Me.txtTipo.Valor = Nothing
        Me.txtTipo.valorVazio = ""
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel1.Location = New System.Drawing.Point(18, 19)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(41, 13)
        Me.FbLabel1.TabIndex = 1
        Me.FbLabel1.Text = "Nome :"
        '
        'txtObservacao
        '
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacao.botaoClear = False
        Me.txtObservacao.Campo = ""
        Me.txtObservacao.CaracterTipo = "U"
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.ControlDB = Nothing
        Me.txtObservacao.Location = New System.Drawing.Point(104, 97)
        Me.txtObservacao.MaxLength = 900
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.NomeCampoMsg = "FbTextBox2"
        Me.txtObservacao.Requerido = False
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(568, 70)
        Me.txtObservacao.TabIndex = 2
        Me.txtObservacao.Valor = Nothing
        Me.txtObservacao.valorVazio = ""
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel2.Location = New System.Drawing.Point(3, 99)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(99, 13)
        Me.FbLabel2.TabIndex = 3
        Me.FbLabel2.Text = "Função/Descrição:"
        '
        'txtNumeroTela
        '
        Me.txtNumeroTela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroTela.botaoClear = False
        Me.txtNumeroTela.Campo = ""
        Me.txtNumeroTela.CaracterTipo = "U"
        Me.txtNumeroTela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroTela.ControlDB = Nothing
        Me.txtNumeroTela.Location = New System.Drawing.Point(447, 19)
        Me.txtNumeroTela.Name = "txtNumeroTela"
        Me.txtNumeroTela.NomeCampoMsg = "FbTextBox1"
        Me.txtNumeroTela.Requerido = False
        Me.txtNumeroTela.Size = New System.Drawing.Size(205, 20)
        Me.txtNumeroTela.TabIndex = 4
        Me.txtNumeroTela.Valor = Nothing
        Me.txtNumeroTela.valorVazio = ""
        '
        'FbLabel3
        '
        Me.FbLabel3.AutoSize = True
        Me.FbLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel3.Location = New System.Drawing.Point(415, 19)
        Me.FbLabel3.Name = "FbLabel3"
        Me.FbLabel3.Size = New System.Drawing.Size(25, 13)
        Me.FbLabel3.TabIndex = 5
        Me.FbLabel3.Text = "N° :"
        '
        'txtTabela
        '
        Me.txtTabela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTabela.botaoClear = False
        Me.txtTabela.Campo = ""
        Me.txtTabela.CaracterTipo = "U"
        Me.txtTabela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTabela.ControlDB = Nothing
        Me.txtTabela.Location = New System.Drawing.Point(65, 45)
        Me.txtTabela.Name = "txtTabela"
        Me.txtTabela.NomeCampoMsg = "FbTextBox1"
        Me.txtTabela.Requerido = False
        Me.txtTabela.Size = New System.Drawing.Size(321, 20)
        Me.txtTabela.TabIndex = 6
        Me.txtTabela.Valor = Nothing
        Me.txtTabela.valorVazio = ""
        '
        'FbLabel4
        '
        Me.FbLabel4.AutoSize = True
        Me.FbLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel4.Location = New System.Drawing.Point(13, 47)
        Me.FbLabel4.Name = "FbLabel4"
        Me.FbLabel4.Size = New System.Drawing.Size(46, 13)
        Me.FbLabel4.TabIndex = 7
        Me.FbLabel4.Text = "Tabela :"
        '
        'FbLabel5
        '
        Me.FbLabel5.AutoSize = True
        Me.FbLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel5.Location = New System.Drawing.Point(390, 51)
        Me.FbLabel5.Name = "FbLabel5"
        Me.FbLabel5.Size = New System.Drawing.Size(50, 13)
        Me.FbLabel5.TabIndex = 9
        Me.FbLabel5.Text = "Sistema :"
        '
        'cbbSistema
        '
        Me.cbbSistema.AgrupadoPor = Nothing
        Me.cbbSistema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbSistema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbSistema.BackColor = System.Drawing.Color.LightBlue
        Me.cbbSistema.Campo = ""
        Me.cbbSistema.campoID = "ID"
        Me.cbbSistema.campoOrdem = Nothing
        Me.cbbSistema.campoRelacionamento = Nothing
        Me.cbbSistema.campoSelecionavel = "NOME"
        Me.cbbSistema.campoSql = Nothing
        Me.cbbSistema.campoSqlID = Nothing
        Me.cbbSistema.carrega2Parametro = False
        Me.cbbSistema.carregaClick = True
        Me.cbbSistema.comDistinct = False
        Me.cbbSistema.ControlDB = Nothing
        Me.cbbSistema.DisplayMember = "Texto"
        Me.cbbSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSistema.Filtro = Nothing
        Me.cbbSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbSistema.FormattingEnabled = True
        Me.cbbSistema.Location = New System.Drawing.Point(447, 45)
        Me.cbbSistema.Name = "cbbSistema"
        Me.cbbSistema.NomeCampoMsg = "FbComboBox1"
        Me.cbbSistema.Ordena = Nothing
        Me.cbbSistema.Requerido = True
        Me.cbbSistema.Size = New System.Drawing.Size(204, 21)
        Me.cbbSistema.TabelaRelacionamento = "TB_TIPO_SISTEMA"
        Me.cbbSistema.TabIndex = 69
        Me.cbbSistema.TextoSelecionar = "Selecione o Tipo do Sistema"
        Me.cbbSistema.Valor = Nothing
        Me.cbbSistema.ValorRelacionamento = Nothing
        Me.cbbSistema.ValorSelecionado = "-1"
        Me.cbbSistema.valorVazio = -1
        Me.cbbSistema.ValueMember = "Valor"
        '
        'FbGroupBox1
        '
        Me.FbGroupBox1.Controls.Add(Me.txtTipo)
        Me.FbGroupBox1.Controls.Add(Me.cbbSistema)
        Me.FbGroupBox1.Controls.Add(Me.FbLabel5)
        Me.FbGroupBox1.Controls.Add(Me.FbLabel1)
        Me.FbGroupBox1.Controls.Add(Me.txtNumeroTela)
        Me.FbGroupBox1.Controls.Add(Me.FbLabel4)
        Me.FbGroupBox1.Controls.Add(Me.FbLabel3)
        Me.FbGroupBox1.Controls.Add(Me.txtTabela)
        Me.FbGroupBox1.Location = New System.Drawing.Point(7, 4)
        Me.FbGroupBox1.Name = "FbGroupBox1"
        Me.FbGroupBox1.Size = New System.Drawing.Size(666, 85)
        Me.FbGroupBox1.TabIndex = 70
        Me.FbGroupBox1.TabStop = False
        Me.FbGroupBox1.Text = "Dados da Tela"
        '
        'frmCadastroTelaReferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(687, 288)
        Me.Name = "frmCadastroTelaReferencia"
        Me.Text = "Cadastro de Tela"
        Me.menuFiltro.ResumeLayout(False)
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlCampos.PerformLayout()
        Me.pnlBarra.ResumeLayout(False)
        Me.FbGroupBox1.ResumeLayout(False)
        Me.FbGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtTipo As fbTextBox
    Friend WithEvents FbLabel1 As fbLabel
    Friend WithEvents FbLabel2 As fbLabel
    Friend WithEvents txtObservacao As fbTextBox
    Friend WithEvents FbLabel3 As fbLabel
    Friend WithEvents txtNumeroTela As fbTextBox
    Friend WithEvents FbLabel4 As fbLabel
    Friend WithEvents txtTabela As fbTextBox
    Friend WithEvents FbLabel5 As fbLabel
    Friend WithEvents cbbSistema As fbComboBox
    Friend WithEvents FbGroupBox1 As fbGroupBox
End Class
