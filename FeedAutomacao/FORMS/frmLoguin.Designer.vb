<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoguin
    Inherits FeedAutomacao.frmPadrao

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoguin))
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FbButton2 = New FeedAutomacao.fbButton()
        Me.txtUsuario = New FeedAutomacao.fbTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FbButton3 = New FeedAutomacao.fbButton()
        Me.txtSenha = New FeedAutomacao.fbTextBox()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.FbButton1 = New FeedAutomacao.fbButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Verdana", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbLabel1.ForeColor = System.Drawing.Color.Navy
        Me.FbLabel1.Location = New System.Drawing.Point(60, 5)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(192, 73)
        Me.FbLabel1.TabIndex = 0
        Me.FbLabel1.Text = "Login"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.FbButton2)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(36, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 45)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'FbButton2
        '
        Me.FbButton2.BackColor = System.Drawing.Color.Navy
        Me.FbButton2.BackgroundImage = CType(resources.GetObject("FbButton2.BackgroundImage"), System.Drawing.Image)
        Me.FbButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButton2.Enabled = False
        Me.FbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FbButton2.ForeColor = System.Drawing.Color.Transparent
        Me.FbButton2.Location = New System.Drawing.Point(3, 7)
        Me.FbButton2.Name = "FbButton2"
        Me.FbButton2.Size = New System.Drawing.Size(35, 33)
        Me.FbButton2.TabIndex = 5
        Me.FbButton2.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.botaoClear = False
        Me.txtUsuario.Campo = ""
        Me.txtUsuario.CaracterTipo = "U"
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.ControlDB = Nothing
        Me.txtUsuario.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtUsuario.Location = New System.Drawing.Point(45, 16)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.NomeCampoMsg = "FbTextBox1"
        Me.txtUsuario.Requerido = False
        Me.txtUsuario.Size = New System.Drawing.Size(227, 20)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUsuario.Valor = Nothing
        Me.txtUsuario.valorVazio = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.FbButton3)
        Me.GroupBox2.Controls.Add(Me.txtSenha)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 45)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'FbButton3
        '
        Me.FbButton3.BackColor = System.Drawing.Color.Navy
        Me.FbButton3.BackgroundImage = CType(resources.GetObject("FbButton3.BackgroundImage"), System.Drawing.Image)
        Me.FbButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButton3.Enabled = False
        Me.FbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FbButton3.ForeColor = System.Drawing.Color.Transparent
        Me.FbButton3.Location = New System.Drawing.Point(3, 7)
        Me.FbButton3.Name = "FbButton3"
        Me.FbButton3.Size = New System.Drawing.Size(35, 33)
        Me.FbButton3.TabIndex = 6
        Me.FbButton3.UseVisualStyleBackColor = False
        '
        'txtSenha
        '
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.botaoClear = False
        Me.txtSenha.Campo = ""
        Me.txtSenha.CaracterTipo = "U"
        Me.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSenha.ControlDB = Nothing
        Me.txtSenha.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtSenha.Location = New System.Drawing.Point(45, 15)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.NomeCampoMsg = "FbTextBox1"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Requerido = False
        Me.txtSenha.Size = New System.Drawing.Size(227, 20)
        Me.txtSenha.TabIndex = 2
        Me.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSenha.Valor = Nothing
        Me.txtSenha.valorVazio = ""
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel2.ForeColor = System.Drawing.Color.Navy
        Me.FbLabel2.Location = New System.Drawing.Point(178, 70)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(130, 13)
        Me.FbLabel2.TabIndex = 4
        Me.FbLabel2.Text = "FeedSystem® Automação"
        '
        'FbButton1
        '
        Me.FbButton1.BackColor = System.Drawing.Color.Navy
        Me.FbButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbButton1.ForeColor = System.Drawing.Color.White
        Me.FbButton1.Location = New System.Drawing.Point(37, 209)
        Me.FbButton1.Name = "FbButton1"
        Me.FbButton1.Size = New System.Drawing.Size(271, 37)
        Me.FbButton1.TabIndex = 0
        Me.FbButton1.Text = "login"
        Me.FbButton1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(310, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "X"
        '
        'frmLoguin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(339, 283)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FbButton1)
        Me.Controls.Add(Me.FbLabel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FbLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmLoguin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FbLabel1 As fbLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtUsuario As fbTextBox
    Friend WithEvents txtSenha As fbTextBox
    Friend WithEvents FbLabel2 As fbLabel
    Friend WithEvents FbButton1 As fbButton
    Friend WithEvents FbButton2 As fbButton
    Friend WithEvents FbButton3 As fbButton
    Friend WithEvents Label1 As Label
End Class
