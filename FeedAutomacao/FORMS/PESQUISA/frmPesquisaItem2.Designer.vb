<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesquisaItem2
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
        Me.txtNome = New FeedAutomacao.fbTextBox()
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.txtCodServ = New FeedAutomacao.fbTextBox()
        Me.gbTipo = New FeedAutomacao.fbGroupBox()
        Me.rbServico = New FeedAutomacao.fbRadioButton()
        Me.rbProduto = New FeedAutomacao.fbRadioButton()
        Me.menuFiltro.SuspendLayout()
        Me.gbTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuFiltro
        '
        Me.menuFiltro.Controls.Add(Me.gbTipo)
        Me.menuFiltro.Controls.Add(Me.txtCodServ)
        Me.menuFiltro.Controls.Add(Me.FbLabel2)
        Me.menuFiltro.Controls.Add(Me.txtNome)
        Me.menuFiltro.Controls.Add(Me.FbLabel1)
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(566, 104)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel1, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtNome, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel2, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtCodServ, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.gbTipo, 0)
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.botaoClear = False
        Me.txtNome.Campo = ""
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.ControlDB = Nothing
        Me.txtNome.Location = New System.Drawing.Point(77, 54)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.NomeCampoMsg = "Nome"
        Me.txtNome.Requerido = False
        Me.txtNome.Size = New System.Drawing.Size(373, 20)
        Me.txtNome.TabIndex = 1
        Me.txtNome.Valor = Nothing
        Me.txtNome.valorVazio = ""
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel1.Location = New System.Drawing.Point(37, 57)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(38, 13)
        Me.FbLabel1.TabIndex = 6
        Me.FbLabel1.Text = "Nome:"
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel2.Location = New System.Drawing.Point(4, 33)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(71, 13)
        Me.FbLabel2.TabIndex = 8
        Me.FbLabel2.Text = "Cód. Serviço:"
        '
        'txtCodServ
        '
        Me.txtCodServ.BackColor = System.Drawing.Color.White
        Me.txtCodServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodServ.botaoClear = False
        Me.txtCodServ.Campo = ""
        Me.txtCodServ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodServ.ControlDB = Nothing
        Me.txtCodServ.Location = New System.Drawing.Point(77, 30)
        Me.txtCodServ.MaxLength = 14
        Me.txtCodServ.Name = "txtCodServ"
        Me.txtCodServ.NomeCampoMsg = "CodServ"
        Me.txtCodServ.Requerido = False
        Me.txtCodServ.Size = New System.Drawing.Size(81, 20)
        Me.txtCodServ.TabIndex = 0
        Me.txtCodServ.Valor = Nothing
        Me.txtCodServ.valorVazio = ""
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.rbServico)
        Me.gbTipo.Controls.Add(Me.rbProduto)
        Me.gbTipo.Location = New System.Drawing.Point(456, 26)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(107, 52)
        Me.gbTipo.TabIndex = 2
        Me.gbTipo.TabStop = False
        Me.gbTipo.Text = "Tipo"
        '
        'rbServico
        '
        Me.rbServico.AutoSize = True
        Me.rbServico.Campo = ""
        Me.rbServico.ControlDB = Nothing
        Me.rbServico.Location = New System.Drawing.Point(14, 32)
        Me.rbServico.Name = "rbServico"
        Me.rbServico.Size = New System.Drawing.Size(61, 17)
        Me.rbServico.TabIndex = 1
        Me.rbServico.Text = "Serviço"
        Me.rbServico.UseVisualStyleBackColor = True
        Me.rbServico.Valor = Nothing
        Me.rbServico.ValorChecado = Nothing
        Me.rbServico.valorVazio = False
        '
        'rbProduto
        '
        Me.rbProduto.AutoSize = True
        Me.rbProduto.Campo = ""
        Me.rbProduto.Checked = True
        Me.rbProduto.ControlDB = Nothing
        Me.rbProduto.Location = New System.Drawing.Point(14, 14)
        Me.rbProduto.Name = "rbProduto"
        Me.rbProduto.Size = New System.Drawing.Size(62, 17)
        Me.rbProduto.TabIndex = 0
        Me.rbProduto.TabStop = True
        Me.rbProduto.Text = "Produto"
        Me.rbProduto.UseVisualStyleBackColor = True
        Me.rbProduto.Valor = Nothing
        Me.rbProduto.ValorChecado = Nothing
        Me.rbProduto.valorVazio = False
        '
        'frmPesquisaItem2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.campoFoco = Me.txtCodServ
        Me.ClientSize = New System.Drawing.Size(566, 396)
        Me.controlFocus = Me.txtNome
        Me.Filtro = True
        Me.GridVisivel = True
        Me.Name = "frmPesquisaItem2"
        Me.Text = "Pesquisar Produto/Serviço"
        Me.menuFiltro.ResumeLayout(False)
        Me.menuFiltro.PerformLayout()
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNome As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel1 As FeedAutomacao.fbLabel
    Friend WithEvents FbLabel2 As FeedAutomacao.fbLabel
    Friend WithEvents txtCodServ As FeedAutomacao.fbTextBox
    Friend WithEvents gbTipo As FeedAutomacao.fbGroupBox
    Friend WithEvents rbServico As FeedAutomacao.fbRadioButton
    Friend WithEvents rbProduto As FeedAutomacao.fbRadioButton

End Class
