<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPadraoSeleciona
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.menuFiltro = New FeedAutomacao.fbMenu()
        Me.btnFiltrar = New FeedAutomacao.fbButtonVisual()
        Me.pnlCampos = New FeedAutomacao.fbPanel()
        Me.pnlGrid = New FeedAutomacao.fbPanel()
        Me.dgvDados = New FeedAutomacao.fbGridview()
        Me.pnlAux = New FeedAutomacao.fbPanel()
        Me.pnlStatus = New FeedAutomacao.fbPanel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lbLinhas = New FeedAutomacao.fbLabel()
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.pnlBarra = New FeedAutomacao.fbPanel()
        Me.menuFiltro.SuspendLayout()
        Me.pnlCampos.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuFiltro
        '
        Me.menuFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.menuFiltro.Controls.Add(Me.btnFiltrar)
        Me.menuFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Hint = ""
        Me.menuFiltro.Icone = Nothing
        Me.menuFiltro.Location = New System.Drawing.Point(0, 0)
        Me.menuFiltro.Name = "menuFiltro"
        Me.menuFiltro.Size = New System.Drawing.Size(558, 63)
        Me.menuFiltro.TabIndex = 1
        Me.menuFiltro.Texto = "Filtrar"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnFiltrar.ForeColor = System.Drawing.Color.White
        Me.btnFiltrar.Location = New System.Drawing.Point(0, 40)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(558, 23)
        Me.btnFiltrar.TabIndex = 5
        Me.btnFiltrar.Text = "Carregar (HOME)"
        '
        'pnlCampos
        '
        Me.pnlCampos.AutoScroll = True
        Me.pnlCampos.Controls.Add(Me.pnlGrid)
        Me.pnlCampos.Controls.Add(Me.pnlAux)
        Me.pnlCampos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCampos.Location = New System.Drawing.Point(0, 63)
        Me.pnlCampos.Name = "pnlCampos"
        Me.pnlCampos.Size = New System.Drawing.Size(558, 279)
        Me.pnlCampos.TabIndex = 2
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.dgvDados)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 0)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(558, 147)
        Me.pnlGrid.TabIndex = 3
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.AllowUserToResizeRows = False
        Me.dgvDados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.colunaID = "ID"
        Me.dgvDados.ColunaSeleciona = False
        Me.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDados.idSel = -1
        Me.dgvDados.Location = New System.Drawing.Point(0, 0)
        Me.dgvDados.MultiSelect = False
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDados.RowHeadersVisible = False
        Me.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDados.Size = New System.Drawing.Size(558, 147)
        Me.dgvDados.TabIndex = 0
        '
        'pnlAux
        '
        Me.pnlAux.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAux.Location = New System.Drawing.Point(0, 147)
        Me.pnlAux.Name = "pnlAux"
        Me.pnlAux.Size = New System.Drawing.Size(558, 132)
        Me.pnlAux.TabIndex = 2
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlStatus.Controls.Add(Me.LinkLabel1)
        Me.pnlStatus.Controls.Add(Me.lbLinhas)
        Me.pnlStatus.Controls.Add(Me.FbLabel1)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 342)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(558, 21)
        Me.pnlStatus.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.Lavender
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Lavender
        Me.LinkLabel1.Location = New System.Drawing.Point(377, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(178, 15)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Exportar Dados para Excel"
        '
        'lbLinhas
        '
        Me.lbLinhas.AutoSize = True
        Me.lbLinhas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbLinhas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbLinhas.ForeColor = System.Drawing.Color.Lavender
        Me.lbLinhas.Location = New System.Drawing.Point(114, 4)
        Me.lbLinhas.Name = "lbLinhas"
        Me.lbLinhas.Size = New System.Drawing.Size(14, 13)
        Me.lbLinhas.TabIndex = 1
        Me.lbLinhas.Text = "0"
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FbLabel1.ForeColor = System.Drawing.Color.Lavender
        Me.FbLabel1.Location = New System.Drawing.Point(3, 4)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(115, 13)
        Me.FbLabel1.TabIndex = 0
        Me.FbLabel1.Text = "Total de Registros:"
        '
        'pnlBarra
        '
        Me.pnlBarra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBarra.Location = New System.Drawing.Point(0, 363)
        Me.pnlBarra.Name = "pnlBarra"
        Me.pnlBarra.Size = New System.Drawing.Size(558, 53)
        Me.pnlBarra.TabIndex = 2
        '
        'frmPadraoSeleciona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(558, 416)
        Me.Controls.Add(Me.pnlCampos)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.menuFiltro)
        Me.Controls.Add(Me.pnlBarra)
        Me.KeyPreview = True
        Me.Name = "frmPadraoSeleciona"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuFiltro.ResumeLayout(False)
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents pnlCampos As fbPanel
    Friend WithEvents pnlGrid As fbPanel
    Protected Friend WithEvents pnlAux As fbPanel
    Protected Friend WithEvents pnlBarra As fbPanel
    Friend WithEvents btnFiltrar As fbButtonVisual
    Friend WithEvents dgvDados As fbGridview
    Friend WithEvents lbLinhas As fbLabel
    Friend WithEvents FbLabel1 As fbLabel
    Public WithEvents pnlStatus As fbPanel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Public WithEvents menuFiltro As fbMenu
End Class
