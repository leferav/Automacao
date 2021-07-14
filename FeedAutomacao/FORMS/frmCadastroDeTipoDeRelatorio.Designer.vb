<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroDeTipoDeRelatorio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroDeTipoDeRelatorio))
        Me.btnFecharTela = New FeedAutomacao.fbButtonVisual()
        Me.FbGroupBox2 = New FeedAutomacao.fbGroupBox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.FbButtonVisual1 = New FeedAutomacao.fbButtonVisual()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtObs = New FeedAutomacao.fbTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbbTipoSistema = New FeedAutomacao.fbComboBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtNomeProcedimento = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCodRel = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNomeRelatorio = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlCampos.SuspendLayout()
        Me.FbGroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCampos
        '
        Me.pnlCampos.Controls.Add(Me.FbGroupBox2)
        Me.pnlCampos.Size = New System.Drawing.Size(794, 581)
        '
        'pnlBarra
        '
        Me.pnlBarra.BackColor = System.Drawing.Color.White
        Me.pnlBarra.Dock = System.Windows.Forms.DockStyle.None
        Me.pnlBarra.Location = New System.Drawing.Point(0, 546)
        Me.pnlBarra.Size = New System.Drawing.Size(794, 46)
        '
        'btnFecharTela
        '
        Me.btnFecharTela.BackColor = System.Drawing.Color.Green
        Me.btnFecharTela.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFecharTela.ForeColor = System.Drawing.Color.Lavender
        Me.btnFecharTela.Location = New System.Drawing.Point(41, 534)
        Me.btnFecharTela.Name = "btnFecharTela"
        Me.btnFecharTela.Size = New System.Drawing.Size(190, 39)
        Me.btnFecharTela.TabIndex = 2
        Me.btnFecharTela.Text = "Cancelar (ESC)"
        '
        'FbGroupBox2
        '
        Me.FbGroupBox2.Controls.Add(Me.btnFecharTela)
        Me.FbGroupBox2.Controls.Add(Me.BunifuFlatButton1)
        Me.FbGroupBox2.Controls.Add(Me.FbButtonVisual1)
        Me.FbGroupBox2.Controls.Add(Me.BunifuCustomLabel5)
        Me.FbGroupBox2.Controls.Add(Me.txtObs)
        Me.FbGroupBox2.Controls.Add(Me.GroupBox4)
        Me.FbGroupBox2.Controls.Add(Me.BunifuCustomLabel4)
        Me.FbGroupBox2.Controls.Add(Me.GroupBox3)
        Me.FbGroupBox2.Controls.Add(Me.BunifuCustomLabel3)
        Me.FbGroupBox2.Controls.Add(Me.GroupBox2)
        Me.FbGroupBox2.Controls.Add(Me.GroupBox1)
        Me.FbGroupBox2.Controls.Add(Me.BunifuCustomLabel2)
        Me.FbGroupBox2.Controls.Add(Me.BunifuCustomLabel1)
        Me.FbGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FbGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.FbGroupBox2.Name = "FbGroupBox2"
        Me.FbGroupBox2.Size = New System.Drawing.Size(794, 581)
        Me.FbGroupBox2.TabIndex = 28
        Me.FbGroupBox2.TabStop = False
        Me.FbGroupBox2.Text = "Dados"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Salvar"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(497, 533)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(269, 39)
        Me.BunifuFlatButton1.TabIndex = 3
        Me.BunifuFlatButton1.Text = "Salvar"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FbButtonVisual1
        '
        Me.FbButtonVisual1.BackColor = System.Drawing.Color.Black
        Me.FbButtonVisual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbButtonVisual1.ForeColor = System.Drawing.Color.White
        Me.FbButtonVisual1.Location = New System.Drawing.Point(759, 12)
        Me.FbButtonVisual1.Name = "FbButtonVisual1"
        Me.FbButtonVisual1.Size = New System.Drawing.Size(21, 23)
        Me.FbButtonVisual1.TabIndex = 95
        Me.FbButtonVisual1.Text = "X"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(314, 374)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(174, 20)
        Me.BunifuCustomLabel5.TabIndex = 94
        Me.BunifuCustomLabel5.Text = "Informações Adicionais"
        '
        'txtObs
        '
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.botaoClear = False
        Me.txtObs.Campo = ""
        Me.txtObs.CaracterTipo = "U"
        Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.ControlDB = Nothing
        Me.txtObs.Location = New System.Drawing.Point(41, 399)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.NomeCampoMsg = "FbTextBox1"
        Me.txtObs.Requerido = False
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(725, 130)
        Me.txtObs.TabIndex = 93
        Me.txtObs.Valor = Nothing
        Me.txtObs.valorVazio = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbbTipoSistema)
        Me.GroupBox4.Location = New System.Drawing.Point(384, 152)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(382, 84)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'cbbTipoSistema
        '
        Me.cbbTipoSistema.AgrupadoPor = Nothing
        Me.cbbTipoSistema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbTipoSistema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbTipoSistema.BackColor = System.Drawing.Color.LightBlue
        Me.cbbTipoSistema.Campo = ""
        Me.cbbTipoSistema.campoID = "ID"
        Me.cbbTipoSistema.campoOrdem = Nothing
        Me.cbbTipoSistema.campoRelacionamento = Nothing
        Me.cbbTipoSistema.campoSelecionavel = "NOME"
        Me.cbbTipoSistema.campoSql = Nothing
        Me.cbbTipoSistema.campoSqlID = Nothing
        Me.cbbTipoSistema.carrega2Parametro = False
        Me.cbbTipoSistema.carregaClick = True
        Me.cbbTipoSistema.comDistinct = False
        Me.cbbTipoSistema.ControlDB = Nothing
        Me.cbbTipoSistema.DisplayMember = "Texto"
        Me.cbbTipoSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTipoSistema.Filtro = Nothing
        Me.cbbTipoSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbTipoSistema.FormattingEnabled = True
        Me.cbbTipoSistema.Location = New System.Drawing.Point(8, 41)
        Me.cbbTipoSistema.Name = "cbbTipoSistema"
        Me.cbbTipoSistema.NomeCampoMsg = "FbComboBox1"
        Me.cbbTipoSistema.Ordena = Nothing
        Me.cbbTipoSistema.Requerido = True
        Me.cbbTipoSistema.Size = New System.Drawing.Size(350, 24)
        Me.cbbTipoSistema.TabelaRelacionamento = "TB_TIPO_SISTEMA"
        Me.cbbTipoSistema.TabIndex = 69
        Me.cbbTipoSistema.TextoSelecionar = "Selecione o Tipo do Sistema"
        Me.cbbTipoSistema.Valor = Nothing
        Me.cbbTipoSistema.ValorRelacionamento = Nothing
        Me.cbbTipoSistema.ValorSelecionado = "-1"
        Me.cbbTipoSistema.valorVazio = -1
        Me.cbbTipoSistema.ValueMember = "Valor"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(545, 129)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(67, 20)
        Me.BunifuCustomLabel4.TabIndex = 7
        Me.BunifuCustomLabel4.Text = "Sistema"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtNomeProcedimento)
        Me.GroupBox3.Location = New System.Drawing.Point(41, 277)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(725, 84)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'txtNomeProcedimento
        '
        Me.txtNomeProcedimento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNomeProcedimento.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNomeProcedimento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNomeProcedimento.HintForeColor = System.Drawing.Color.Empty
        Me.txtNomeProcedimento.HintText = ""
        Me.txtNomeProcedimento.isPassword = False
        Me.txtNomeProcedimento.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNomeProcedimento.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNomeProcedimento.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNomeProcedimento.LineThickness = 3
        Me.txtNomeProcedimento.Location = New System.Drawing.Point(18, 31)
        Me.txtNomeProcedimento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomeProcedimento.Name = "txtNomeProcedimento"
        Me.txtNomeProcedimento.Size = New System.Drawing.Size(683, 31)
        Me.txtNomeProcedimento.TabIndex = 1
        Me.txtNomeProcedimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(303, 251)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(202, 20)
        Me.BunifuCustomLabel3.TabIndex = 5
        Me.BunifuCustomLabel3.Text = "Procedimento Armazenado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCodRel)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(329, 84)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'txtCodRel
        '
        Me.txtCodRel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodRel.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCodRel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodRel.HintForeColor = System.Drawing.Color.Empty
        Me.txtCodRel.HintText = ""
        Me.txtCodRel.isPassword = False
        Me.txtCodRel.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCodRel.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCodRel.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCodRel.LineThickness = 3
        Me.txtCodRel.Location = New System.Drawing.Point(39, 30)
        Me.txtCodRel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodRel.Name = "txtCodRel"
        Me.txtCodRel.Size = New System.Drawing.Size(276, 31)
        Me.txtCodRel.TabIndex = 1
        Me.txtCodRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNomeRelatorio)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 84)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txtNomeRelatorio
        '
        Me.txtNomeRelatorio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNomeRelatorio.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNomeRelatorio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNomeRelatorio.HintForeColor = System.Drawing.Color.Empty
        Me.txtNomeRelatorio.HintText = ""
        Me.txtNomeRelatorio.isPassword = False
        Me.txtNomeRelatorio.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNomeRelatorio.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNomeRelatorio.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNomeRelatorio.LineThickness = 3
        Me.txtNomeRelatorio.Location = New System.Drawing.Point(19, 30)
        Me.txtNomeRelatorio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomeRelatorio.Name = "txtNomeRelatorio"
        Me.txtNomeRelatorio.Size = New System.Drawing.Size(685, 31)
        Me.txtNomeRelatorio.TabIndex = 1
        Me.txtNomeRelatorio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(131, 129)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(152, 20)
        Me.BunifuCustomLabel2.TabIndex = 2
        Me.BunifuCustomLabel2.Text = "Código Do Relatório"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(314, 19)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(141, 20)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Nome do Relatório"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'frmCadastroDeTipoDeRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(794, 581)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadastroDeTipoDeRelatorio"
        Me.Text = "Cadastro De Relatórios "
        Me.pnlCampos.ResumeLayout(False)
        Me.FbGroupBox2.ResumeLayout(False)
        Me.FbGroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tpDados As Dotnetrix.Controls.TabPageEX
    Friend WithEvents btnFecharTela As fbButtonVisual
    Friend WithEvents FbGroupBox2 As fbGroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtNomeProcedimento As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCodRel As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNomeRelatorio As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbbTipoSistema As fbComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtObs As fbTextBox
    Friend WithEvents FbButtonVisual1 As fbButtonVisual
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
