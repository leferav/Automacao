<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPadraoPesquisa
    Inherits frmPadrao

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.menuFiltro = New fbMenu()
        Me.btnFiltrar = New fbButtonVisual()
        Me.FbPanel1 = New fbPanel()
        Me.FbButtonVisual1 = New fbButtonVisual()
        Me.btnCancelar = New fbButtonVisual()
        Me.btnSelecionar = New fbButtonVisual()
        Me.dgvDados = New fbGridview()
        Me.menuFiltro.SuspendLayout()
        Me.FbPanel1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.menuFiltro.Size = New System.Drawing.Size(526, 88)
        Me.menuFiltro.TabIndex = 0
        Me.menuFiltro.Texto = "Filtros"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnFiltrar.ForeColor = System.Drawing.Color.White
        Me.btnFiltrar.Location = New System.Drawing.Point(0, 64)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(526, 24)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Text = "Carregar (HOME)"
        '
        'FbPanel1
        '
        Me.FbPanel1.Controls.Add(Me.FbButtonVisual1)
        Me.FbPanel1.Controls.Add(Me.btnCancelar)
        Me.FbPanel1.Controls.Add(Me.btnSelecionar)
        Me.FbPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FbPanel1.Location = New System.Drawing.Point(0, 360)
        Me.FbPanel1.Name = "FbPanel1"
        Me.FbPanel1.Size = New System.Drawing.Size(526, 37)
        Me.FbPanel1.TabIndex = 1
        '
        'FbButtonVisual1
        '
        Me.FbButtonVisual1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FbButtonVisual1.BackColor = System.Drawing.Color.MidnightBlue
        Me.FbButtonVisual1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButtonVisual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FbButtonVisual1.ForeColor = System.Drawing.Color.White
        Me.FbButtonVisual1.Location = New System.Drawing.Point(166, 5)
        Me.FbButtonVisual1.Name = "FbButtonVisual1"
        Me.FbButtonVisual1.Size = New System.Drawing.Size(114, 27)
        Me.FbButtonVisual1.TabIndex = 2
        Me.FbButtonVisual1.Text = "Novo (F5)"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.Maroon
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(285, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(114, 27)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar (ESC)"
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelecionar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelecionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSelecionar.ForeColor = System.Drawing.Color.White
        Me.btnSelecionar.Location = New System.Drawing.Point(404, 5)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(114, 27)
        Me.btnSelecionar.TabIndex = 0
        Me.btnSelecionar.Text = "Selecionar (ENT)"
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
        Me.dgvDados.Location = New System.Drawing.Point(0, 88)
        Me.dgvDados.MultiSelect = False
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDados.RowHeadersVisible = False
        Me.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDados.Size = New System.Drawing.Size(526, 272)
        Me.dgvDados.TabIndex = 2
        '
        'frmPadraoPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(526, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.FbPanel1)
        Me.Controls.Add(Me.menuFiltro)
        Me.KeyPreview = True
        Me.Name = "frmPadraoPesquisa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pesquisa"
        Me.menuFiltro.ResumeLayout(False)
        Me.FbPanel1.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FbPanel1 As fbPanel
    Friend WithEvents dgvDados As fbGridview
    Friend WithEvents btnCancelar As fbButtonVisual
    Friend WithEvents btnSelecionar As fbButtonVisual
    Protected Friend WithEvents menuFiltro As fbMenu
    Friend WithEvents btnFiltrar As fbButtonVisual
    Friend WithEvents FbButtonVisual1 As fbButtonVisual
End Class
