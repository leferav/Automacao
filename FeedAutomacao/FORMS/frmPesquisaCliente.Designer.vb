<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesquisaCliente
    Inherits FeedAutomacao.frmPadraoPesquisa

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCliente = New FeedAutomacao.fbTextBox()
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
        Me.menuFiltro.Controls.Add(Me.txtCliente)
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(682, 88)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtCliente, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel1, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.lblCodigo, 0)
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.botaoClear = False
        Me.txtCliente.Campo = ""
        Me.txtCliente.CaracterTipo = "U"
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.ControlDB = Nothing
        Me.txtCliente.Location = New System.Drawing.Point(165, 31)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.NomeCampoMsg = "FbTextBox1"
        Me.txtCliente.Requerido = False
        Me.txtCliente.Size = New System.Drawing.Size(351, 20)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.Valor = Nothing
        Me.txtCliente.valorVazio = ""
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel1.Location = New System.Drawing.Point(120, 35)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(42, 13)
        Me.FbLabel1.TabIndex = 6
        Me.FbLabel1.Text = "Cliente:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.botaoClear = False
        Me.txtCodigo.Campo = ""
        Me.txtCodigo.CaracterTipo = "U"
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.ControlDB = Nothing
        Me.txtCodigo.Location = New System.Drawing.Point(55, 31)
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
        Me.lblCodigo.Location = New System.Drawing.Point(9, 35)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 8
        Me.lblCodigo.Text = "Código:"
        '
        'frmPesquisaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(682, 365)
        Me.Filtro = True
        Me.GridVisivel = True
        Me.Name = "frmPesquisaCliente"
        Me.Text = "Pesquisa Cliente"
        Me.menuFiltro.ResumeLayout(False)
        Me.menuFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FbLabel1 As fbLabel
    Friend WithEvents txtCliente As fbTextBox
    Friend WithEvents lblCodigo As fbLabel
    Friend WithEvents txtCodigo As fbTextBox
End Class
