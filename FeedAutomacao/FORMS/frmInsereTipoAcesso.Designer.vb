<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInsereTipoAcesso
    Inherits frmPadraoCadastroDados

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsereTipoAcesso))
        Me.btnSalvar = New FeedAutomacao.fbButtonVisual()
        Me.btnExcluir = New FeedAutomacao.fbButtonVisual()
        Me.btnFecharTela = New FeedAutomacao.fbButtonVisual()
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.CbbTipoAcesso = New FeedAutomacao.fbComboBox()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.FbLabel3 = New FeedAutomacao.fbLabel()
        Me.txtIDUser = New FeedAutomacao.fbTextBox()
        Me.txtSenha = New FeedAutomacao.fbTextBox()
        Me.txtIP = New FeedAutomacao.fbTextBox()
        Me.FbLabel4 = New FeedAutomacao.fbLabel()
        Me.FbPanel1 = New FeedAutomacao.fbPanel()
        Me.FbPicturebox1 = New FeedAutomacao.fbPicturebox()
        Me.txtObs = New FeedAutomacao.fbTextBox()
        Me.pnlCampos.SuspendLayout()
        Me.pnlBarra.SuspendLayout()
        Me.FbPanel1.SuspendLayout()
        CType(Me.FbPicturebox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCampos
        '
        Me.pnlCampos.Controls.Add(Me.txtObs)
        Me.pnlCampos.Controls.Add(Me.FbPanel1)
        Me.pnlCampos.Controls.Add(Me.CbbTipoAcesso)
        Me.pnlCampos.Controls.Add(Me.FbLabel1)
        Me.pnlCampos.Size = New System.Drawing.Size(387, 196)
        '
        'pnlBarra
        '
        Me.pnlBarra.Controls.Add(Me.btnFecharTela)
        Me.pnlBarra.Controls.Add(Me.btnExcluir)
        Me.pnlBarra.Controls.Add(Me.btnSalvar)
        Me.pnlBarra.Location = New System.Drawing.Point(0, 196)
        Me.pnlBarra.Size = New System.Drawing.Size(387, 41)
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Lavender
        Me.btnSalvar.Location = New System.Drawing.Point(274, 3)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(104, 26)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.Lavender
        Me.btnExcluir.Location = New System.Drawing.Point(142, 3)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(108, 26)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir (F12)"
        '
        'btnFecharTela
        '
        Me.btnFecharTela.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFecharTela.ForeColor = System.Drawing.Color.Lavender
        Me.btnFecharTela.Location = New System.Drawing.Point(16, 2)
        Me.btnFecharTela.Name = "btnFecharTela"
        Me.btnFecharTela.Size = New System.Drawing.Size(108, 27)
        Me.btnFecharTela.TabIndex = 2
        Me.btnFecharTela.Text = "Fechar Tela (ESC)"
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel1.Location = New System.Drawing.Point(11, 11)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(40, 13)
        Me.FbLabel1.TabIndex = 2
        Me.FbLabel1.Text = "TIPO:"
        '
        'CbbTipoAcesso
        '
        Me.CbbTipoAcesso.AgrupadoPor = Nothing
        Me.CbbTipoAcesso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbbTipoAcesso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbbTipoAcesso.BackColor = System.Drawing.Color.LightBlue
        Me.CbbTipoAcesso.Campo = ""
        Me.CbbTipoAcesso.campoID = "ID"
        Me.CbbTipoAcesso.campoOrdem = Nothing
        Me.CbbTipoAcesso.campoRelacionamento = Nothing
        Me.CbbTipoAcesso.campoSelecionavel = "NOME"
        Me.CbbTipoAcesso.campoSql = Nothing
        Me.CbbTipoAcesso.campoSqlID = Nothing
        Me.CbbTipoAcesso.carrega2Parametro = False
        Me.CbbTipoAcesso.carregaClick = True
        Me.CbbTipoAcesso.comDistinct = False
        Me.CbbTipoAcesso.ControlDB = Nothing
        Me.CbbTipoAcesso.DisplayMember = "Texto"
        Me.CbbTipoAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbTipoAcesso.Filtro = Nothing
        Me.CbbTipoAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbbTipoAcesso.FormattingEnabled = True
        Me.CbbTipoAcesso.Location = New System.Drawing.Point(58, 7)
        Me.CbbTipoAcesso.Name = "CbbTipoAcesso"
        Me.CbbTipoAcesso.NomeCampoMsg = "FbComboBox1"
        Me.CbbTipoAcesso.Ordena = Nothing
        Me.CbbTipoAcesso.Requerido = True
        Me.CbbTipoAcesso.Size = New System.Drawing.Size(320, 21)
        Me.CbbTipoAcesso.TabelaRelacionamento = "TB_TIPO_ACESSO"
        Me.CbbTipoAcesso.TabIndex = 3
        Me.CbbTipoAcesso.TextoSelecionar = Nothing
        Me.CbbTipoAcesso.Valor = Nothing
        Me.CbbTipoAcesso.ValorRelacionamento = Nothing
        Me.CbbTipoAcesso.ValorSelecionado = "-1"
        Me.CbbTipoAcesso.valorVazio = -1
        Me.CbbTipoAcesso.ValueMember = "Valor"
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel2.Location = New System.Drawing.Point(3, 37)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(64, 13)
        Me.FbLabel2.TabIndex = 4
        Me.FbLabel2.Text = "ID/USER:"
        '
        'FbLabel3
        '
        Me.FbLabel3.AutoSize = True
        Me.FbLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel3.Location = New System.Drawing.Point(13, 64)
        Me.FbLabel3.Name = "FbLabel3"
        Me.FbLabel3.Size = New System.Drawing.Size(53, 13)
        Me.FbLabel3.TabIndex = 5
        Me.FbLabel3.Text = "SENHA:"
        '
        'txtIDUser
        '
        Me.txtIDUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDUser.botaoClear = False
        Me.txtIDUser.Campo = ""
        Me.txtIDUser.CaracterTipo = "N"
        Me.txtIDUser.ControlDB = Nothing
        Me.txtIDUser.Location = New System.Drawing.Point(69, 34)
        Me.txtIDUser.Name = "txtIDUser"
        Me.txtIDUser.NomeCampoMsg = "FbTextBox1"
        Me.txtIDUser.Requerido = False
        Me.txtIDUser.Size = New System.Drawing.Size(178, 20)
        Me.txtIDUser.TabIndex = 6
        Me.txtIDUser.Valor = Nothing
        Me.txtIDUser.valorVazio = ""
        Me.txtIDUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        '
        'txtSenha
        '
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSenha.botaoClear = False
        Me.txtSenha.Campo = ""
        Me.txtSenha.CaracterTipo = "N"
        Me.txtSenha.ControlDB = Nothing
        Me.txtSenha.Location = New System.Drawing.Point(69, 60)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.NomeCampoMsg = "FbTextBox1"
        Me.txtSenha.Requerido = False
        Me.txtSenha.Size = New System.Drawing.Size(178, 20)
        Me.txtSenha.TabIndex = 7
        Me.txtSenha.Valor = Nothing
        Me.txtSenha.valorVazio = ""
        Me.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        '
        'txtIP
        '
        Me.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIP.botaoClear = False
        Me.txtIP.Campo = ""
        Me.txtIP.CaracterTipo = "U"
        Me.txtIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIP.ControlDB = Nothing
        Me.txtIP.Location = New System.Drawing.Point(69, 8)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.NomeCampoMsg = "FbTextBox1"
        Me.txtIP.Requerido = False
        Me.txtIP.Size = New System.Drawing.Size(178, 20)
        Me.txtIP.TabIndex = 8
        Me.txtIP.Valor = Nothing
        Me.txtIP.valorVazio = ""
        '
        'FbLabel4
        '
        Me.FbLabel4.AutoSize = True
        Me.FbLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel4.Location = New System.Drawing.Point(40, 10)
        Me.FbLabel4.Name = "FbLabel4"
        Me.FbLabel4.Size = New System.Drawing.Size(23, 13)
        Me.FbLabel4.TabIndex = 9
        Me.FbLabel4.Text = "IP:"
        '
        'FbPanel1
        '
        Me.FbPanel1.BackColor = System.Drawing.Color.LightBlue
        Me.FbPanel1.Controls.Add(Me.FbPicturebox1)
        Me.FbPanel1.Controls.Add(Me.txtIDUser)
        Me.FbPanel1.Controls.Add(Me.FbLabel4)
        Me.FbPanel1.Controls.Add(Me.FbLabel2)
        Me.FbPanel1.Controls.Add(Me.txtIP)
        Me.FbPanel1.Controls.Add(Me.FbLabel3)
        Me.FbPanel1.Controls.Add(Me.txtSenha)
        Me.FbPanel1.Location = New System.Drawing.Point(3, 96)
        Me.FbPanel1.Name = "FbPanel1"
        Me.FbPanel1.Size = New System.Drawing.Size(375, 90)
        Me.FbPanel1.TabIndex = 10
        '
        'FbPicturebox1
        '
        Me.FbPicturebox1.BotaoDireitoManipulaImagem = True
        Me.FbPicturebox1.Image = CType(resources.GetObject("FbPicturebox1.Image"), System.Drawing.Image)
        Me.FbPicturebox1.Location = New System.Drawing.Point(265, 3)
        Me.FbPicturebox1.Name = "FbPicturebox1"
        Me.FbPicturebox1.Size = New System.Drawing.Size(100, 84)
        Me.FbPicturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FbPicturebox1.TabIndex = 10
        Me.FbPicturebox1.TabStop = False
        '
        'txtObs
        '
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.botaoClear = False
        Me.txtObs.Campo = ""
        Me.txtObs.CaracterTipo = "U"
        Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.ControlDB = Nothing
        Me.txtObs.Enabled = False
        Me.txtObs.Location = New System.Drawing.Point(58, 34)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.NomeCampoMsg = "FbTextBox1"
        Me.txtObs.Requerido = False
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(320, 56)
        Me.txtObs.TabIndex = 11
        Me.txtObs.Valor = Nothing
        Me.txtObs.valorVazio = ""
        '
        'frmInsereTipoAcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(387, 237)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInsereTipoAcesso"
        Me.Text = "Inserir Tipo Acesso"
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlCampos.PerformLayout()
        Me.pnlBarra.ResumeLayout(False)
        Me.FbPanel1.ResumeLayout(False)
        Me.FbPanel1.PerformLayout()
        CType(Me.FbPicturebox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tpDados As Dotnetrix.Controls.TabPageEX
    Friend WithEvents btnSalvar As fbButtonVisual
    Friend WithEvents btnExcluir As fbButtonVisual
    Friend WithEvents btnFecharTela As fbButtonVisual
    Friend WithEvents FbLabel1 As fbLabel
    Friend WithEvents txtSenha As fbTextBox
    Friend WithEvents txtIDUser As fbTextBox
    Friend WithEvents FbLabel3 As fbLabel
    Friend WithEvents FbLabel2 As fbLabel
    Friend WithEvents CbbTipoAcesso As fbComboBox
    Friend WithEvents FbPanel1 As fbPanel
    Friend WithEvents FbLabel4 As fbLabel
    Friend WithEvents txtIP As fbTextBox
    Friend WithEvents FbPicturebox1 As fbPicturebox
    Friend WithEvents txtObs As fbTextBox
End Class
