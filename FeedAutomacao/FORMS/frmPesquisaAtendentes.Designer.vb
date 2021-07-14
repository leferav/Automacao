<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPesquisaAtendentes
    Inherits FeedAutomacao.frmPadraoPesquisa

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
        Me.txtCodigo = New FeedAutomacao.fbTextBox()
        Me.lblCodigo = New FeedAutomacao.fbLabel()
        Me.menuFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuFiltro
        '
        Me.menuFiltro.Controls.Add(Me.lblCodigo)
        Me.menuFiltro.Controls.Add(Me.txtCodigo)
        Me.menuFiltro.Controls.Add(Me.FbLabel1)
        Me.menuFiltro.Controls.Add(Me.txtNome)
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(520, 82)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtNome, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel1, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.lblCodigo, 0)
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.botaoClear = False
        Me.txtNome.Campo = ""
        Me.txtNome.ControlDB = Nothing
        Me.txtNome.Location = New System.Drawing.Point(159, 27)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.NomeCampoMsg = "FbTextBox1"
        Me.txtNome.Requerido = False
        Me.txtNome.Size = New System.Drawing.Size(227, 20)
        Me.txtNome.TabIndex = 5
        Me.txtNome.Valor = Nothing
        Me.txtNome.valorVazio = ""
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel1.Location = New System.Drawing.Point(114, 30)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(38, 13)
        Me.FbLabel1.TabIndex = 6
        Me.FbLabel1.Text = "Nome:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.botaoClear = False
        Me.txtCodigo.Campo = ""
        Me.txtCodigo.ControlDB = Nothing
        Me.txtCodigo.Location = New System.Drawing.Point(49, 26)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.NomeCampoMsg = "FbTextBox1"
        Me.txtCodigo.Requerido = False
        Me.txtCodigo.Size = New System.Drawing.Size(63, 20)
        Me.txtCodigo.TabIndex = 7
        Me.txtCodigo.Valor = Nothing
        Me.txtCodigo.valorVazio = ""
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCodigo.Location = New System.Drawing.Point(3, 29)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(29, 13)
        Me.lblCodigo.TabIndex = 8
        Me.lblCodigo.Text = "Cod:"
        '
        'frmPesquisaAtendentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(520, 365)
        Me.Filtro = True
        Me.GridVisivel = True
        Me.Name = "frmPesquisaAtendentes"
        Me.Text = "Pesquisa Atendentes"
        Me.menuFiltro.ResumeLayout(False)
        Me.menuFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FbLabel1 As fbLabel
    Friend WithEvents txtNome As fbTextBox
    Friend WithEvents lblCodigo As fbLabel
    Friend WithEvents txtCodigo As fbTextBox
End Class
