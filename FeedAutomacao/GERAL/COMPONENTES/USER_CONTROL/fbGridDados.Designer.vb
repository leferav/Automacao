<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fbGridDados
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fbGridDados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPrint = New fbButton()
        Me.btndel = New fbButton()
        Me.btnEdit = New fbButton()
        Me.btnAdd = New fbButton()
        Me.dgvDados = New fbGridview()
        Me.pnlBarra = New fbPanel()
        Me.lblTo = New fbLabel()
        Me.lblTotReg = New fbLabel()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.White
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(200, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(35, 24)
        Me.btnPrint.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Imprimir")
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'btndel
        '
        Me.btndel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndel.BackColor = System.Drawing.Color.White
        Me.btndel.BackgroundImage = CType(resources.GetObject("btndel.BackgroundImage"), System.Drawing.Image)
        Me.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btndel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btndel.FlatAppearance.BorderSize = 0
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndel.Location = New System.Drawing.Point(241, 5)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(35, 24)
        Me.btndel.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btndel, "Excluir")
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.White
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(282, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(35, 24)
        Me.btnEdit.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnEdit, "Editar")
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(323, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(35, 24)
        Me.btnAdd.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Adicionar")
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.AllowUserToResizeRows = False
        Me.dgvDados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None
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
        Me.dgvDados.Size = New System.Drawing.Size(362, 171)
        Me.dgvDados.TabIndex = 2
        '
        'pnlBarra
        '
        Me.pnlBarra.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlBarra.Controls.Add(Me.lblTo)
        Me.pnlBarra.Controls.Add(Me.lblTotReg)
        Me.pnlBarra.Controls.Add(Me.btnPrint)
        Me.pnlBarra.Controls.Add(Me.btndel)
        Me.pnlBarra.Controls.Add(Me.btnEdit)
        Me.pnlBarra.Controls.Add(Me.btnAdd)
        Me.pnlBarra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBarra.Location = New System.Drawing.Point(0, 171)
        Me.pnlBarra.Name = "pnlBarra"
        Me.pnlBarra.Size = New System.Drawing.Size(362, 32)
        Me.pnlBarra.TabIndex = 1
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTo.Location = New System.Drawing.Point(98, 9)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(13, 13)
        Me.lblTo.TabIndex = 8
        Me.lblTo.Text = "0"
        '
        'lblTotReg
        '
        Me.lblTotReg.AutoSize = True
        Me.lblTotReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotReg.Location = New System.Drawing.Point(3, 9)
        Me.lblTotReg.Name = "lblTotReg"
        Me.lblTotReg.Size = New System.Drawing.Size(97, 13)
        Me.lblTotReg.TabIndex = 7
        Me.lblTotReg.Text = "Total Registros:"
        '
        'fbGridDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.pnlBarra)
        Me.Name = "fbGridDados"
        Me.Size = New System.Drawing.Size(362, 203)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBarra.ResumeLayout(False)
        Me.pnlBarra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBarra As fbPanel
    Friend WithEvents dgvDados As fbGridview
    Friend WithEvents btndel As fbButton
    Friend WithEvents btnEdit As fbButton
    Friend WithEvents btnAdd As fbButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnPrint As fbButton
    Friend WithEvents lblTo As fbLabel
    Friend WithEvents lblTotReg As fbLabel
End Class
