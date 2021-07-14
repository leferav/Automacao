<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroConfiguracao
    Inherits FeedAutomacao.frmPadraoCadastroDados

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
        Me.txtNome = New FeedAutomacao.fbTextBox()
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.FbLabel3 = New FeedAutomacao.fbLabel()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.txtTabela = New FeedAutomacao.fbTextBox()
        Me.FbLabel4 = New FeedAutomacao.fbLabel()
        Me.txtTipoDados = New FeedAutomacao.fbTextBox()
        Me.FbLabel5 = New FeedAutomacao.fbLabel()
        Me.txtTamanho = New FeedAutomacao.fbTextBox()
        Me.FbLabel6 = New FeedAutomacao.fbLabel()
        Me.txtDecimal = New FeedAutomacao.fbTextBox()
        Me.txtDescricao = New System.Windows.Forms.RichTextBox()
        Me.FbLabel7 = New FeedAutomacao.fbLabel()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.pnlCampos.SuspendLayout()
        Me.pnlBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCampos
        '
        Me.pnlCampos.Controls.Add(Me.FbLabel7)
        Me.pnlCampos.Controls.Add(Me.txtDescricao)
        Me.pnlCampos.Controls.Add(Me.FbLabel6)
        Me.pnlCampos.Controls.Add(Me.txtDecimal)
        Me.pnlCampos.Controls.Add(Me.FbLabel5)
        Me.pnlCampos.Controls.Add(Me.txtTamanho)
        Me.pnlCampos.Controls.Add(Me.FbLabel4)
        Me.pnlCampos.Controls.Add(Me.txtTipoDados)
        Me.pnlCampos.Controls.Add(Me.FbLabel2)
        Me.pnlCampos.Controls.Add(Me.txtTabela)
        Me.pnlCampos.Controls.Add(Me.FbLabel1)
        Me.pnlCampos.Controls.Add(Me.txtNome)
        Me.pnlCampos.Size = New System.Drawing.Size(568, 159)
        '
        'pnlBarra
        '
        Me.pnlBarra.Controls.Add(Me.btnSalvar)
        Me.pnlBarra.Location = New System.Drawing.Point(0, 159)
        Me.pnlBarra.Size = New System.Drawing.Size(568, 53)
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.botaoClear = False
        Me.txtNome.Campo = ""
        Me.txtNome.CaracterTipo = "U"
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.ControlDB = Nothing
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(63, 11)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.NomeCampoMsg = "FbTextBox1"
        Me.txtNome.ReadOnly = True
        Me.txtNome.Requerido = False
        Me.txtNome.Size = New System.Drawing.Size(218, 20)
        Me.txtNome.TabIndex = 0
        Me.txtNome.Valor = Nothing
        Me.txtNome.valorVazio = ""
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel1.Location = New System.Drawing.Point(22, 13)
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
        Me.FbLabel3.Location = New System.Drawing.Point(19, 31)
        Me.FbLabel3.Name = "FbLabel3"
        Me.FbLabel3.Size = New System.Drawing.Size(38, 13)
        Me.FbLabel3.TabIndex = 5
        Me.FbLabel3.Text = "Nome:"
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel2.Location = New System.Drawing.Point(302, 13)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(43, 13)
        Me.FbLabel2.TabIndex = 3
        Me.FbLabel2.Text = "Tabela:"
        '
        'txtTabela
        '
        Me.txtTabela.BackColor = System.Drawing.Color.White
        Me.txtTabela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTabela.botaoClear = False
        Me.txtTabela.Campo = ""
        Me.txtTabela.CaracterTipo = "U"
        Me.txtTabela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTabela.ControlDB = Nothing
        Me.txtTabela.Enabled = False
        Me.txtTabela.Location = New System.Drawing.Point(351, 11)
        Me.txtTabela.Name = "txtTabela"
        Me.txtTabela.NomeCampoMsg = "FbTextBox1"
        Me.txtTabela.ReadOnly = True
        Me.txtTabela.Requerido = False
        Me.txtTabela.Size = New System.Drawing.Size(205, 20)
        Me.txtTabela.TabIndex = 2
        Me.txtTabela.Valor = Nothing
        Me.txtTabela.valorVazio = ""
        '
        'FbLabel4
        '
        Me.FbLabel4.AutoSize = True
        Me.FbLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel4.Location = New System.Drawing.Point(29, 39)
        Me.FbLabel4.Name = "FbLabel4"
        Me.FbLabel4.Size = New System.Drawing.Size(31, 13)
        Me.FbLabel4.TabIndex = 5
        Me.FbLabel4.Text = "Tipo:"
        '
        'txtTipoDados
        '
        Me.txtTipoDados.BackColor = System.Drawing.Color.White
        Me.txtTipoDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoDados.botaoClear = False
        Me.txtTipoDados.Campo = ""
        Me.txtTipoDados.CaracterTipo = "U"
        Me.txtTipoDados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoDados.ControlDB = Nothing
        Me.txtTipoDados.Enabled = False
        Me.txtTipoDados.Location = New System.Drawing.Point(63, 37)
        Me.txtTipoDados.Name = "txtTipoDados"
        Me.txtTipoDados.NomeCampoMsg = "FbTextBox1"
        Me.txtTipoDados.ReadOnly = True
        Me.txtTipoDados.Requerido = False
        Me.txtTipoDados.Size = New System.Drawing.Size(218, 20)
        Me.txtTipoDados.TabIndex = 4
        Me.txtTipoDados.Valor = Nothing
        Me.txtTipoDados.valorVazio = ""
        '
        'FbLabel5
        '
        Me.FbLabel5.AutoSize = True
        Me.FbLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel5.Location = New System.Drawing.Point(290, 39)
        Me.FbLabel5.Name = "FbLabel5"
        Me.FbLabel5.Size = New System.Drawing.Size(55, 13)
        Me.FbLabel5.TabIndex = 7
        Me.FbLabel5.Text = "Tamanho:"
        '
        'txtTamanho
        '
        Me.txtTamanho.BackColor = System.Drawing.Color.White
        Me.txtTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTamanho.botaoClear = False
        Me.txtTamanho.Campo = ""
        Me.txtTamanho.CaracterTipo = "U"
        Me.txtTamanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTamanho.ControlDB = Nothing
        Me.txtTamanho.Enabled = False
        Me.txtTamanho.Location = New System.Drawing.Point(351, 37)
        Me.txtTamanho.Name = "txtTamanho"
        Me.txtTamanho.NomeCampoMsg = "FbTextBox1"
        Me.txtTamanho.ReadOnly = True
        Me.txtTamanho.Requerido = False
        Me.txtTamanho.Size = New System.Drawing.Size(71, 20)
        Me.txtTamanho.TabIndex = 6
        Me.txtTamanho.Valor = Nothing
        Me.txtTamanho.valorVazio = ""
        '
        'FbLabel6
        '
        Me.FbLabel6.AutoSize = True
        Me.FbLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel6.Location = New System.Drawing.Point(431, 39)
        Me.FbLabel6.Name = "FbLabel6"
        Me.FbLabel6.Size = New System.Drawing.Size(48, 13)
        Me.FbLabel6.TabIndex = 9
        Me.FbLabel6.Text = "Decimal:"
        '
        'txtDecimal
        '
        Me.txtDecimal.BackColor = System.Drawing.Color.White
        Me.txtDecimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDecimal.botaoClear = False
        Me.txtDecimal.Campo = ""
        Me.txtDecimal.CaracterTipo = "U"
        Me.txtDecimal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDecimal.ControlDB = Nothing
        Me.txtDecimal.Enabled = False
        Me.txtDecimal.Location = New System.Drawing.Point(485, 37)
        Me.txtDecimal.Name = "txtDecimal"
        Me.txtDecimal.NomeCampoMsg = "FbTextBox1"
        Me.txtDecimal.ReadOnly = True
        Me.txtDecimal.Requerido = False
        Me.txtDecimal.Size = New System.Drawing.Size(71, 20)
        Me.txtDecimal.TabIndex = 8
        Me.txtDecimal.Valor = Nothing
        Me.txtDecimal.valorVazio = ""
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(63, 64)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(493, 89)
        Me.txtDescricao.TabIndex = 10
        Me.txtDescricao.Text = ""
        '
        'FbLabel7
        '
        Me.FbLabel7.AutoSize = True
        Me.FbLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel7.Location = New System.Drawing.Point(3, 67)
        Me.FbLabel7.Name = "FbLabel7"
        Me.FbLabel7.Size = New System.Drawing.Size(58, 13)
        Me.FbLabel7.TabIndex = 11
        Me.FbLabel7.Text = "Descrição:"
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Location = New System.Drawing.Point(404, 6)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(152, 44)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar (F2)"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'frmCadastroConfiguracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(568, 212)
        Me.Name = "frmCadastroConfiguracao"
        Me.Text = "Cadastro de Configuração"
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlCampos.PerformLayout()
        Me.pnlBarra.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtNome As fbTextBox
    Friend WithEvents FbLabel1 As fbLabel
    Friend WithEvents FbLabel3 As fbLabel
    Friend WithEvents FbLabel6 As fbLabel
    Friend WithEvents txtDecimal As fbTextBox
    Friend WithEvents FbLabel5 As fbLabel
    Friend WithEvents txtTamanho As fbTextBox
    Friend WithEvents FbLabel4 As fbLabel
    Friend WithEvents txtTipoDados As fbTextBox
    Friend WithEvents FbLabel2 As fbLabel
    Friend WithEvents txtTabela As fbTextBox
    Friend WithEvents FbLabel7 As fbLabel
    Friend WithEvents txtDescricao As RichTextBox
    Friend WithEvents btnSalvar As Button
End Class
