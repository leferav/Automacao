<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroTipoAcesso
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
        Me.txtTipo = New FeedAutomacao.fbTextBox()
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.txtObservacao = New FeedAutomacao.fbTextBox()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.menuFiltro.SuspendLayout()
        Me.pnlCampos.SuspendLayout()
        Me.pnlBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuFiltro
        '
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(558, 57)
        Me.menuFiltro.Controls.SetChildIndex(Me.pesDados, 0)
        '
        'pnlCampos
        '
        Me.pnlCampos.Controls.Add(Me.FbLabel2)
        Me.pnlCampos.Controls.Add(Me.txtObservacao)
        Me.pnlCampos.Controls.Add(Me.FbLabel1)
        Me.pnlCampos.Controls.Add(Me.txtTipo)
        Me.pnlCampos.Location = New System.Drawing.Point(0, 57)
        Me.pnlCampos.Size = New System.Drawing.Size(558, 126)
        '
        'FbBarra1
        '
        Me.FbBarra1.frmCadastro = Me
        '
        'pnlBarra
        '
        Me.pnlBarra.Location = New System.Drawing.Point(0, 183)
        '
        'txtTipo
        '
        Me.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipo.botaoClear = False
        Me.txtTipo.Campo = ""
        Me.txtTipo.CaracterTipo = "U"
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.ControlDB = Nothing
        Me.txtTipo.Location = New System.Drawing.Point(98, 7)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.NomeCampoMsg = "FbTextBox1"
        Me.txtTipo.Requerido = False
        Me.txtTipo.Size = New System.Drawing.Size(448, 20)
        Me.txtTipo.TabIndex = 0
        Me.txtTipo.Valor = Nothing
        Me.txtTipo.valorVazio = ""
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel1.Location = New System.Drawing.Point(11, 10)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(84, 13)
        Me.FbLabel1.TabIndex = 1
        Me.FbLabel1.Text = "Tipo de Acesso:"
        '
        'txtObservacao
        '
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacao.botaoClear = False
        Me.txtObservacao.Campo = ""
        Me.txtObservacao.CaracterTipo = "U"
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.ControlDB = Nothing
        Me.txtObservacao.Location = New System.Drawing.Point(98, 38)
        Me.txtObservacao.MaxLength = 900
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.NomeCampoMsg = "FbTextBox2"
        Me.txtObservacao.Requerido = False
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(448, 70)
        Me.txtObservacao.TabIndex = 2
        Me.txtObservacao.Valor = Nothing
        Me.txtObservacao.valorVazio = ""
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel2.Location = New System.Drawing.Point(27, 40)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(68, 13)
        Me.FbLabel2.TabIndex = 3
        Me.FbLabel2.Text = "Observação:"
        '
        'frmCadastroTipoAcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(558, 236)
        Me.Name = "frmCadastroTipoAcesso"
        Me.Text = "Tipo de Acesso"
        Me.menuFiltro.ResumeLayout(False)
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlCampos.PerformLayout()
        Me.pnlBarra.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtTipo As fbTextBox
    Friend WithEvents FbLabel1 As fbLabel
    Friend WithEvents FbLabel2 As fbLabel
    Friend WithEvents txtObservacao As fbTextBox
End Class
