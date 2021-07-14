<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesquisaPessoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesquisaPessoa))
        Me.txtCGC = New FeedAutomacao.fbMaskBox()
        Me.FbLabel4 = New FeedAutomacao.fbLabel()
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.txtNome = New FeedAutomacao.fbTextBox()
        Me.cbbTipoPessoa = New FeedAutomacao.fbComboBox()
        Me.FbLabel5 = New FeedAutomacao.fbLabel()
        Me.cbInativo = New FeedAutomacao.fbCheckBox()
        Me.FbLabel8 = New FeedAutomacao.fbLabel()
        Me.txtCodigo = New FeedAutomacao.fbTextBox()
        Me.txtFant = New FeedAutomacao.fbTextBox()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.menuFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuFiltro
        '
        Me.menuFiltro.Controls.Add(Me.FbLabel2)
        Me.menuFiltro.Controls.Add(Me.txtFant)
        Me.menuFiltro.Controls.Add(Me.txtCodigo)
        Me.menuFiltro.Controls.Add(Me.FbLabel8)
        Me.menuFiltro.Controls.Add(Me.cbInativo)
        Me.menuFiltro.Controls.Add(Me.cbbTipoPessoa)
        Me.menuFiltro.Controls.Add(Me.FbLabel5)
        Me.menuFiltro.Controls.Add(Me.txtCGC)
        Me.menuFiltro.Controls.Add(Me.FbLabel4)
        Me.menuFiltro.Controls.Add(Me.FbLabel1)
        Me.menuFiltro.Controls.Add(Me.txtNome)
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(616, 127)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtNome, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel1, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel4, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtCGC, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel5, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.cbbTipoPessoa, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.cbInativo, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel8, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtFant, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel2, 0)
        '
        'txtCGC
        '
        Me.txtCGC.BackColor = System.Drawing.Color.White
        Me.txtCGC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCGC.ControlDB = Nothing
        Me.txtCGC.DB = Nothing
        Me.txtCGC.Location = New System.Drawing.Point(81, 53)
        Me.txtCGC.Name = "txtCGC"
        Me.txtCGC.NomeCampoMsg = "CGC"
        Me.txtCGC.Requerido = False
        Me.txtCGC.Size = New System.Drawing.Size(133, 20)
        Me.txtCGC.TabIndex = 2
        '
        'FbLabel4
        '
        Me.FbLabel4.AutoSize = True
        Me.FbLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel4.Location = New System.Drawing.Point(17, 56)
        Me.FbLabel4.Name = "FbLabel4"
        Me.FbLabel4.Size = New System.Drawing.Size(62, 13)
        Me.FbLabel4.TabIndex = 18
        Me.FbLabel4.Text = "CNPJ/CPF:"
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel1.Location = New System.Drawing.Point(41, 32)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(38, 13)
        Me.FbLabel1.TabIndex = 17
        Me.FbLabel1.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.botaoClear = False
        Me.txtNome.Campo = ""
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.ControlDB = Nothing
        Me.txtNome.Location = New System.Drawing.Point(81, 29)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.NomeCampoMsg = "Nome"
        Me.txtNome.Requerido = False
        Me.txtNome.Size = New System.Drawing.Size(332, 20)
        Me.txtNome.TabIndex = 0
        Me.txtNome.Valor = Nothing
        Me.txtNome.valorVazio = ""
        '
        'cbbTipoPessoa
        '
        Me.cbbTipoPessoa.AgrupadoPor = Nothing
        Me.cbbTipoPessoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbTipoPessoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbTipoPessoa.BackColor = System.Drawing.Color.White
        Me.cbbTipoPessoa.Campo = ""
        Me.cbbTipoPessoa.campoID = "ID"
        Me.cbbTipoPessoa.campoOrdem = Nothing
        Me.cbbTipoPessoa.campoRelacionamento = ""
        Me.cbbTipoPessoa.campoSelecionavel = "Nome"
        Me.cbbTipoPessoa.campoSql = Nothing
        Me.cbbTipoPessoa.campoSqlID = Nothing
        Me.cbbTipoPessoa.carrega2Parametro = False
        Me.cbbTipoPessoa.comDistinct = False
        Me.cbbTipoPessoa.ControlDB = Nothing
        Me.cbbTipoPessoa.DisplayMember = "Texto"
        Me.cbbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTipoPessoa.Filtro = Nothing
        Me.cbbTipoPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbTipoPessoa.FormattingEnabled = True
        Me.cbbTipoPessoa.Location = New System.Drawing.Point(265, 53)
        Me.cbbTipoPessoa.Name = "cbbTipoPessoa"
        Me.cbbTipoPessoa.NomeCampoMsg = "TipoPessoa"
        Me.cbbTipoPessoa.Ordena = Nothing
        Me.cbbTipoPessoa.Requerido = False
        Me.cbbTipoPessoa.Size = New System.Drawing.Size(278, 21)
        Me.cbbTipoPessoa.TabelaRelacionamento = "TB_TIPO_PESSOA"
        Me.cbbTipoPessoa.TabIndex = 3
        Me.cbbTipoPessoa.TextoSelecionar = "Selecione um Grupo de Pessoa"
        Me.cbbTipoPessoa.Valor = Nothing
        Me.cbbTipoPessoa.ValorRelacionamento = ""
        Me.cbbTipoPessoa.ValorSelecionado = "-1"
        Me.cbbTipoPessoa.valorVazio = -1
        Me.cbbTipoPessoa.ValueMember = "Valor"
        '
        'FbLabel5
        '
        Me.FbLabel5.AutoSize = True
        Me.FbLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel5.Location = New System.Drawing.Point(224, 57)
        Me.FbLabel5.Name = "FbLabel5"
        Me.FbLabel5.Size = New System.Drawing.Size(39, 13)
        Me.FbLabel5.TabIndex = 20
        Me.FbLabel5.Text = "Grupo:"
        '
        'cbInativo
        '
        Me.cbInativo.AutoSize = True
        Me.cbInativo.Campo = ""
        Me.cbInativo.ControlDB = Nothing
        Me.cbInativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbInativo.Location = New System.Drawing.Point(464, 78)
        Me.cbInativo.Name = "cbInativo"
        Me.cbInativo.Size = New System.Drawing.Size(55, 17)
        Me.cbInativo.TabIndex = 5
        Me.cbInativo.Text = "Inativo"
        Me.cbInativo.UseVisualStyleBackColor = True
        Me.cbInativo.Valor = Nothing
        Me.cbInativo.valorVazio = False
        Me.cbInativo.Visible = False
        '
        'FbLabel8
        '
        Me.FbLabel8.AutoSize = True
        Me.FbLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel8.Location = New System.Drawing.Point(419, 32)
        Me.FbLabel8.Name = "FbLabel8"
        Me.FbLabel8.Size = New System.Drawing.Size(43, 13)
        Me.FbLabel8.TabIndex = 327
        Me.FbLabel8.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.botaoClear = False
        Me.txtCodigo.Campo = ""
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.ControlDB = Nothing
        Me.txtCodigo.Location = New System.Drawing.Point(464, 29)
        Me.txtCodigo.MaxLength = 100
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.NomeCampoMsg = "Codigo"
        Me.txtCodigo.Requerido = False
        Me.txtCodigo.Size = New System.Drawing.Size(79, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Valor = Nothing
        Me.txtCodigo.valorVazio = ""
        '
        'txtFant
        '
        Me.txtFant.BackColor = System.Drawing.Color.White
        Me.txtFant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFant.botaoClear = False
        Me.txtFant.Campo = ""
        Me.txtFant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFant.ControlDB = Nothing
        Me.txtFant.Location = New System.Drawing.Point(81, 77)
        Me.txtFant.MaxLength = 100
        Me.txtFant.Name = "txtFant"
        Me.txtFant.NomeCampoMsg = "Fant"
        Me.txtFant.Requerido = False
        Me.txtFant.Size = New System.Drawing.Size(332, 20)
        Me.txtFant.TabIndex = 4
        Me.txtFant.Valor = Nothing
        Me.txtFant.valorVazio = ""
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel2.Location = New System.Drawing.Point(29, 80)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(50, 13)
        Me.FbLabel2.TabIndex = 329
        Me.FbLabel2.Text = "Fantasia:"
        '
        'frmPesquisaPessoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.campoFoco = Me.txtNome
        Me.ClientSize = New System.Drawing.Size(616, 420)
        Me.controlFocus = Me.txtNome
        Me.Filtro = True
        Me.GridVisivel = True
        Me.Name = "frmPesquisaPessoa"
        Me.Text = "Pequisar Pessoa"
        Me.ValVisivel = "Nome"
        Me.menuFiltro.ResumeLayout(False)
        Me.menuFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCGC As FeedAutomacao.fbMaskBox
    Friend WithEvents FbLabel4 As FeedAutomacao.fbLabel
    Friend WithEvents FbLabel1 As FeedAutomacao.fbLabel
    Friend WithEvents txtNome As FeedAutomacao.fbTextBox
    Friend WithEvents cbbTipoPessoa As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel5 As FeedAutomacao.fbLabel
    Friend WithEvents cbInativo As FeedAutomacao.fbCheckBox
    Friend WithEvents FbLabel8 As FeedAutomacao.fbLabel
    Friend WithEvents txtCodigo As FeedAutomacao.fbTextBox
    Friend WithEvents FbLabel2 As FeedAutomacao.fbLabel
    Friend WithEvents txtFant As FeedAutomacao.fbTextBox

End Class
