<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelecionaContexto2
    Inherits FeedAutomacao.frmPadrao

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelecionaContexto2))
        Me.cbbConta = New FeedAutomacao.fbComboBox()
        Me.btnInserir = New FeedAutomacao.fbButtonVisual()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCidade = New FeedAutomacao.fbLabel()
        Me.lblIE = New FeedAutomacao.fbLabel()
        Me.lblCNPJ = New FeedAutomacao.fbLabel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbbConta
        '
        Me.cbbConta.AgrupadoPor = Nothing
        Me.cbbConta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbConta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbConta.Campo = ""
        Me.cbbConta.campoID = "ID"
        Me.cbbConta.campoOrdem = Nothing
        Me.cbbConta.campoRelacionamento = Nothing
        Me.cbbConta.campoSelecionavel = "Fantasia"
        Me.cbbConta.campoSql = Nothing
        Me.cbbConta.campoSqlID = Nothing
        Me.cbbConta.carrega2Parametro = False
        Me.cbbConta.carregaClick = True
        Me.cbbConta.comDistinct = False
        Me.cbbConta.ControlDB = Nothing
        Me.cbbConta.DisplayMember = "Texto"
        Me.cbbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbConta.Filtro = Nothing
        Me.cbbConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbbConta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbConta.FormattingEnabled = True
        Me.cbbConta.Location = New System.Drawing.Point(58, 146)
        Me.cbbConta.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbConta.Name = "cbbConta"
        Me.cbbConta.NomeCampoMsg = "Conta"
        Me.cbbConta.Ordena = Nothing
        Me.cbbConta.Requerido = False
        Me.cbbConta.Size = New System.Drawing.Size(350, 24)
        Me.cbbConta.TabelaRelacionamento = "TB_EMPRESA"
        Me.cbbConta.TabIndex = 200
        Me.cbbConta.TextoSelecionar = "Selecione a Empresa"
        Me.cbbConta.Valor = Nothing
        Me.cbbConta.ValorRelacionamento = Nothing
        Me.cbbConta.ValorSelecionado = "-1"
        Me.cbbConta.valorVazio = -1
        Me.cbbConta.ValueMember = "Valor"
        '
        'btnInserir
        '
        Me.btnInserir.BackColor = System.Drawing.Color.SteelBlue
        Me.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserir.ForeColor = System.Drawing.Color.White
        Me.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInserir.Location = New System.Drawing.Point(268, 260)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(139, 29)
        Me.btnInserir.TabIndex = 202
        Me.btnInserir.Text = "Selecionar (F2)"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblCidade)
        Me.GroupBox1.Controls.Add(Me.lblIE)
        Me.GroupBox1.Controls.Add(Me.lblCNPJ)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 80)
        Me.GroupBox1.TabIndex = 207
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'lblCidade
        '
        Me.lblCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        Me.lblCidade.ForeColor = System.Drawing.Color.DarkGray
        Me.lblCidade.Location = New System.Drawing.Point(6, 55)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(269, 21)
        Me.lblCidade.TabIndex = 2
        Me.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIE
        '
        Me.lblIE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIE.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        Me.lblIE.ForeColor = System.Drawing.Color.DarkGray
        Me.lblIE.Location = New System.Drawing.Point(6, 31)
        Me.lblIE.Name = "lblIE"
        Me.lblIE.Size = New System.Drawing.Size(269, 21)
        Me.lblIE.TabIndex = 1
        Me.lblIE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCNPJ
        '
        Me.lblCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        Me.lblCNPJ.ForeColor = System.Drawing.Color.DarkGray
        Me.lblCNPJ.Location = New System.Drawing.Point(6, 12)
        Me.lblCNPJ.Name = "lblCNPJ"
        Me.lblCNPJ.Size = New System.Drawing.Size(269, 19)
        Me.lblCNPJ.TabIndex = 0
        Me.lblCNPJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'frmSelecionaContexto2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(462, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnInserir)
        Me.Controls.Add(Me.cbbConta)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmSelecionaContexto2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = ""
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbbConta As FeedAutomacao.fbComboBox
    Friend WithEvents btnInserir As FeedAutomacao.fbButtonVisual
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCidade As fbLabel
    Friend WithEvents lblIE As fbLabel
    Friend WithEvents lblCNPJ As fbLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
