<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGerenciaDeRelatorios
    Inherits FeedAutomacao.frmPadraoSeleciona

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
        Me.btnNovo = New FeedAutomacao.fbButtonVisual()
        Me.btnEditar = New FeedAutomacao.fbButtonVisual()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbTms = New FeedAutomacao.fbRadioButton()
        Me.RtbTodos = New FeedAutomacao.fbRadioButton()
        Me.rbERP = New FeedAutomacao.fbRadioButton()
        Me.rbwms = New FeedAutomacao.fbRadioButton()
        Me.txtNomeRel = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnexarImagemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesanexarImagemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlCampos.SuspendLayout()
        Me.pnlBarra.SuspendLayout()
        Me.menuFiltro.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCampos
        '
        Me.pnlCampos.Location = New System.Drawing.Point(0, 115)
        Me.pnlCampos.Size = New System.Drawing.Size(935, 347)
        '
        'pnlAux
        '
        Me.pnlAux.Location = New System.Drawing.Point(0, 297)
        Me.pnlAux.Size = New System.Drawing.Size(935, 50)
        '
        'pnlBarra
        '
        Me.pnlBarra.Controls.Add(Me.btnEditar)
        Me.pnlBarra.Controls.Add(Me.btnNovo)
        Me.pnlBarra.Location = New System.Drawing.Point(0, 483)
        Me.pnlBarra.Size = New System.Drawing.Size(935, 53)
        '
        'pnlStatus
        '
        Me.pnlStatus.Location = New System.Drawing.Point(0, 462)
        Me.pnlStatus.Size = New System.Drawing.Size(935, 21)
        '
        'menuFiltro
        '
        Me.menuFiltro.Controls.Add(Me.Label1)
        Me.menuFiltro.Controls.Add(Me.txtNomeRel)
        Me.menuFiltro.Controls.Add(Me.GroupBox2)
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(935, 115)
        Me.menuFiltro.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtNomeRel, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.Label1, 0)
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.Location = New System.Drawing.Point(3, 6)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(123, 41)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo (F5)"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(132, 6)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(123, 41)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar (F6)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.rbTms)
        Me.GroupBox2.Controls.Add(Me.RtbTodos)
        Me.GroupBox2.Controls.Add(Me.rbERP)
        Me.GroupBox2.Controls.Add(Me.rbwms)
        Me.GroupBox2.Location = New System.Drawing.Point(768, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(161, 57)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo Sistema"
        '
        'rbTms
        '
        Me.rbTms.AutoSize = True
        Me.rbTms.Campo = ""
        Me.rbTms.ControlDB = Nothing
        Me.rbTms.Location = New System.Drawing.Point(67, 39)
        Me.rbTms.Name = "rbTms"
        Me.rbTms.Size = New System.Drawing.Size(48, 17)
        Me.rbTms.TabIndex = 11
        Me.rbTms.Text = "TMS"
        Me.rbTms.UseVisualStyleBackColor = True
        Me.rbTms.Valor = Nothing
        Me.rbTms.ValorChecado = Nothing
        Me.rbTms.valorVazio = False
        '
        'RtbTodos
        '
        Me.RtbTodos.AutoSize = True
        Me.RtbTodos.Campo = ""
        Me.RtbTodos.Checked = True
        Me.RtbTodos.ControlDB = Nothing
        Me.RtbTodos.Location = New System.Drawing.Point(6, 16)
        Me.RtbTodos.Name = "RtbTodos"
        Me.RtbTodos.Size = New System.Drawing.Size(55, 17)
        Me.RtbTodos.TabIndex = 8
        Me.RtbTodos.TabStop = True
        Me.RtbTodos.Text = "Todos"
        Me.RtbTodos.UseVisualStyleBackColor = True
        Me.RtbTodos.Valor = Nothing
        Me.RtbTodos.ValorChecado = Nothing
        Me.RtbTodos.valorVazio = False
        '
        'rbERP
        '
        Me.rbERP.AutoSize = True
        Me.rbERP.Campo = ""
        Me.rbERP.ControlDB = Nothing
        Me.rbERP.Location = New System.Drawing.Point(6, 39)
        Me.rbERP.Name = "rbERP"
        Me.rbERP.Size = New System.Drawing.Size(47, 17)
        Me.rbERP.TabIndex = 10
        Me.rbERP.Text = "ERP"
        Me.rbERP.UseVisualStyleBackColor = True
        Me.rbERP.Valor = Nothing
        Me.rbERP.ValorChecado = Nothing
        Me.rbERP.valorVazio = False
        '
        'rbwms
        '
        Me.rbwms.AutoSize = True
        Me.rbwms.Campo = ""
        Me.rbwms.ControlDB = Nothing
        Me.rbwms.Location = New System.Drawing.Point(67, 16)
        Me.rbwms.Name = "rbwms"
        Me.rbwms.Size = New System.Drawing.Size(52, 17)
        Me.rbwms.TabIndex = 9
        Me.rbwms.Text = "WMS"
        Me.rbwms.UseVisualStyleBackColor = True
        Me.rbwms.Valor = Nothing
        Me.rbwms.ValorChecado = Nothing
        Me.rbwms.valorVazio = False
        '
        'txtNomeRel
        '
        Me.txtNomeRel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNomeRel.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNomeRel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNomeRel.HintForeColor = System.Drawing.Color.Empty
        Me.txtNomeRel.HintText = ""
        Me.txtNomeRel.isPassword = False
        Me.txtNomeRel.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNomeRel.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNomeRel.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNomeRel.LineThickness = 3
        Me.txtNomeRel.Location = New System.Drawing.Point(65, 26)
        Me.txtNomeRel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomeRel.Name = "txtNomeRel"
        Me.txtNomeRel.Size = New System.Drawing.Size(392, 31)
        Me.txtNomeRel.TabIndex = 13
        Me.txtNomeRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Relatório:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnexarImagemToolStripMenuItem, Me.DesanexarImagemToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 48)
        '
        'AnexarImagemToolStripMenuItem
        '
        Me.AnexarImagemToolStripMenuItem.Name = "AnexarImagemToolStripMenuItem"
        Me.AnexarImagemToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AnexarImagemToolStripMenuItem.Text = "Anexar Imagem"
        '
        'DesanexarImagemToolStripMenuItem
        '
        Me.DesanexarImagemToolStripMenuItem.Name = "DesanexarImagemToolStripMenuItem"
        Me.DesanexarImagemToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DesanexarImagemToolStripMenuItem.Text = "Desanexar Imagem"
        '
        'frmGerenciaDeRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(935, 536)
        Me.Name = "frmGerenciaDeRelatorios"
        Me.Text = "Gerência de Relatórios"
        Me.veMenuFiltro = True
        Me.Controls.SetChildIndex(Me.pnlBarra, 0)
        Me.Controls.SetChildIndex(Me.menuFiltro, 0)
        Me.Controls.SetChildIndex(Me.pnlStatus, 0)
        Me.Controls.SetChildIndex(Me.pnlCampos, 0)
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlBarra.ResumeLayout(False)
        Me.menuFiltro.ResumeLayout(False)
        Me.menuFiltro.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEditar As fbButtonVisual
    Friend WithEvents btnNovo As fbButtonVisual
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RtbTodos As fbRadioButton
    Friend WithEvents rbERP As fbRadioButton
    Friend WithEvents rbwms As fbRadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomeRel As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents rbTms As fbRadioButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AnexarImagemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesanexarImagemToolStripMenuItem As ToolStripMenuItem
End Class
