<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroClientesResponsaveis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroClientesResponsaveis))
        Me.btnSalvar = New FeedAutomacao.fbButtonVisual()
        Me.btnExcluir = New FeedAutomacao.fbButtonVisual()
        Me.btnFecharTela = New FeedAutomacao.fbButtonVisual()
        Me.txtNomeResponsavel = New FeedAutomacao.fbTextBox()
        Me.txtCargoResposavel = New FeedAutomacao.fbTextBox()
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.txtTel = New FeedAutomacao.fbMaskBox()
        Me.txtWhats = New FeedAutomacao.fbMaskBox()
        Me.FbPicturebox1 = New FeedAutomacao.fbPicturebox()
        Me.FbLabel3 = New FeedAutomacao.fbLabel()
        Me.txtEmail = New FeedAutomacao.fbTextBox()
        Me.FbLabel4 = New FeedAutomacao.fbLabel()
        Me.txtSkype = New FeedAutomacao.fbTextBox()
        Me.FbPicturebox2 = New FeedAutomacao.fbPicturebox()
        Me.pnlCampos.SuspendLayout()
        Me.pnlBarra.SuspendLayout()
        CType(Me.FbPicturebox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FbPicturebox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCampos
        '
        Me.pnlCampos.Controls.Add(Me.FbPicturebox2)
        Me.pnlCampos.Controls.Add(Me.txtSkype)
        Me.pnlCampos.Controls.Add(Me.FbLabel4)
        Me.pnlCampos.Controls.Add(Me.txtEmail)
        Me.pnlCampos.Controls.Add(Me.FbLabel3)
        Me.pnlCampos.Controls.Add(Me.FbPicturebox1)
        Me.pnlCampos.Controls.Add(Me.txtWhats)
        Me.pnlCampos.Controls.Add(Me.txtTel)
        Me.pnlCampos.Controls.Add(Me.FbLabel2)
        Me.pnlCampos.Controls.Add(Me.FbLabel1)
        Me.pnlCampos.Controls.Add(Me.txtCargoResposavel)
        Me.pnlCampos.Controls.Add(Me.txtNomeResponsavel)
        Me.pnlCampos.Size = New System.Drawing.Size(513, 135)
        '
        'pnlBarra
        '
        Me.pnlBarra.Controls.Add(Me.btnFecharTela)
        Me.pnlBarra.Controls.Add(Me.btnExcluir)
        Me.pnlBarra.Controls.Add(Me.btnSalvar)
        Me.pnlBarra.Location = New System.Drawing.Point(0, 135)
        Me.pnlBarra.Size = New System.Drawing.Size(513, 41)
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Lavender
        Me.btnSalvar.Location = New System.Drawing.Point(366, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(140, 34)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.Lavender
        Me.btnExcluir.Location = New System.Drawing.Point(187, 3)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(170, 33)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir (F12)"
        '
        'btnFecharTela
        '
        Me.btnFecharTela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFecharTela.ForeColor = System.Drawing.Color.Lavender
        Me.btnFecharTela.Location = New System.Drawing.Point(16, 2)
        Me.btnFecharTela.Name = "btnFecharTela"
        Me.btnFecharTela.Size = New System.Drawing.Size(157, 35)
        Me.btnFecharTela.TabIndex = 2
        Me.btnFecharTela.Text = "Fechar Tela (ESC)"
        '
        'txtNomeResponsavel
        '
        Me.txtNomeResponsavel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomeResponsavel.botaoClear = False
        Me.txtNomeResponsavel.Campo = ""
        Me.txtNomeResponsavel.ControlDB = Nothing
        Me.txtNomeResponsavel.Location = New System.Drawing.Point(61, 8)
        Me.txtNomeResponsavel.Name = "txtNomeResponsavel"
        Me.txtNomeResponsavel.NomeCampoMsg = "FbTextBox1"
        Me.txtNomeResponsavel.Requerido = False
        Me.txtNomeResponsavel.Size = New System.Drawing.Size(445, 20)
        Me.txtNomeResponsavel.TabIndex = 0
        Me.txtNomeResponsavel.Valor = Nothing
        Me.txtNomeResponsavel.valorVazio = ""
        '
        'txtCargoResposavel
        '
        Me.txtCargoResposavel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargoResposavel.botaoClear = False
        Me.txtCargoResposavel.Campo = ""
        Me.txtCargoResposavel.ControlDB = Nothing
        Me.txtCargoResposavel.Location = New System.Drawing.Point(61, 30)
        Me.txtCargoResposavel.Name = "txtCargoResposavel"
        Me.txtCargoResposavel.NomeCampoMsg = "FbTextBox1"
        Me.txtCargoResposavel.Requerido = False
        Me.txtCargoResposavel.Size = New System.Drawing.Size(444, 20)
        Me.txtCargoResposavel.TabIndex = 1
        Me.txtCargoResposavel.Valor = Nothing
        Me.txtCargoResposavel.valorVazio = ""
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel1.Location = New System.Drawing.Point(15, 10)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(43, 13)
        Me.FbLabel1.TabIndex = 2
        Me.FbLabel1.Text = "Nome:"
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel2.Location = New System.Drawing.Point(14, 34)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(44, 13)
        Me.FbLabel2.TabIndex = 3
        Me.FbLabel2.Text = "Cargo:"
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.White
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTel.ControlDB = Nothing
        Me.txtTel.DB = Nothing
        Me.txtTel.Location = New System.Drawing.Point(61, 55)
        Me.txtTel.Mask = "(99)9-9999-9999"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.NomeCampoMsg = "FbMaskBox1"
        Me.txtTel.Requerido = False
        Me.txtTel.Size = New System.Drawing.Size(172, 20)
        Me.txtTel.TabIndex = 6
        Me.txtTel.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'txtWhats
        '
        Me.txtWhats.BackColor = System.Drawing.Color.White
        Me.txtWhats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWhats.ControlDB = Nothing
        Me.txtWhats.DB = Nothing
        Me.txtWhats.Location = New System.Drawing.Point(61, 81)
        Me.txtWhats.Mask = "(99)9-9999-9999"
        Me.txtWhats.Name = "txtWhats"
        Me.txtWhats.NomeCampoMsg = "FbMaskBox1"
        Me.txtWhats.Requerido = False
        Me.txtWhats.Size = New System.Drawing.Size(172, 20)
        Me.txtWhats.TabIndex = 7
        Me.txtWhats.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'FbPicturebox1
        '
        Me.FbPicturebox1.BackColor = System.Drawing.Color.DimGray
        Me.FbPicturebox1.BackgroundImage = Global.FeedAutomacao.My.Resources.Resources.zap
        Me.FbPicturebox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FbPicturebox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FbPicturebox1.BotaoDireitoManipulaImagem = True
        Me.FbPicturebox1.InitialImage = Nothing
        Me.FbPicturebox1.Location = New System.Drawing.Point(26, 79)
        Me.FbPicturebox1.Name = "FbPicturebox1"
        Me.FbPicturebox1.Size = New System.Drawing.Size(30, 22)
        Me.FbPicturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FbPicturebox1.TabIndex = 8
        Me.FbPicturebox1.TabStop = False
        '
        'FbLabel3
        '
        Me.FbLabel3.AutoSize = True
        Me.FbLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel3.Location = New System.Drawing.Point(29, 57)
        Me.FbLabel3.Name = "FbLabel3"
        Me.FbLabel3.Size = New System.Drawing.Size(29, 13)
        Me.FbLabel3.TabIndex = 9
        Me.FbLabel3.Text = "Tel:"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.botaoClear = False
        Me.txtEmail.Campo = ""
        Me.txtEmail.ControlDB = Nothing
        Me.txtEmail.Location = New System.Drawing.Point(61, 107)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.NomeCampoMsg = "FbTextBox1"
        Me.txtEmail.Requerido = False
        Me.txtEmail.Size = New System.Drawing.Size(444, 20)
        Me.txtEmail.TabIndex = 10
        Me.txtEmail.Valor = Nothing
        Me.txtEmail.valorVazio = ""
        '
        'FbLabel4
        '
        Me.FbLabel4.AutoSize = True
        Me.FbLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel4.Location = New System.Drawing.Point(17, 111)
        Me.FbLabel4.Name = "FbLabel4"
        Me.FbLabel4.Size = New System.Drawing.Size(41, 13)
        Me.FbLabel4.TabIndex = 11
        Me.FbLabel4.Text = "Email:"
        '
        'txtSkype
        '
        Me.txtSkype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSkype.botaoClear = False
        Me.txtSkype.Campo = ""
        Me.txtSkype.ControlDB = Nothing
        Me.txtSkype.Location = New System.Drawing.Point(277, 80)
        Me.txtSkype.Name = "txtSkype"
        Me.txtSkype.NomeCampoMsg = "FbTextBox1"
        Me.txtSkype.Requerido = False
        Me.txtSkype.Size = New System.Drawing.Size(228, 20)
        Me.txtSkype.TabIndex = 12
        Me.txtSkype.Valor = Nothing
        Me.txtSkype.valorVazio = ""
        '
        'FbPicturebox2
        '
        Me.FbPicturebox2.BackColor = System.Drawing.Color.DimGray
        Me.FbPicturebox2.BackgroundImage = Global.FeedAutomacao.My.Resources.Resources.skp
        Me.FbPicturebox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FbPicturebox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FbPicturebox2.BotaoDireitoManipulaImagem = False
        Me.FbPicturebox2.InitialImage = Nothing
        Me.FbPicturebox2.Location = New System.Drawing.Point(242, 79)
        Me.FbPicturebox2.Name = "FbPicturebox2"
        Me.FbPicturebox2.Size = New System.Drawing.Size(31, 23)
        Me.FbPicturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FbPicturebox2.TabIndex = 13
        Me.FbPicturebox2.TabStop = False
        '
        'frmCadastroClientesResponsaveis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(513, 176)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadastroClientesResponsaveis"
        Me.Text = "Responsáveis"
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlCampos.PerformLayout()
        Me.pnlBarra.ResumeLayout(False)
        CType(Me.FbPicturebox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FbPicturebox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tpDados As Dotnetrix.Controls.TabPageEX
    Friend WithEvents btnSalvar As fbButtonVisual
    Friend WithEvents btnExcluir As fbButtonVisual
    Friend WithEvents btnFecharTela As fbButtonVisual
    Friend WithEvents FbLabel1 As fbLabel
    Friend WithEvents txtCargoResposavel As fbTextBox
    Friend WithEvents txtNomeResponsavel As fbTextBox
    Friend WithEvents FbLabel2 As fbLabel
    Friend WithEvents txtTel As fbMaskBox
    Friend WithEvents txtWhats As fbMaskBox
    Friend WithEvents FbPicturebox1 As fbPicturebox
    Friend WithEvents FbLabel4 As fbLabel
    Friend WithEvents txtEmail As fbTextBox
    Friend WithEvents FbLabel3 As fbLabel
    Friend WithEvents txtSkype As fbTextBox
    Friend WithEvents FbPicturebox2 As fbPicturebox
End Class
