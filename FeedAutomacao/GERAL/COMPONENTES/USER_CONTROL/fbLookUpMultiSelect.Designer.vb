<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fbLookUpMultiSelect
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fbLookUpMultiSelect))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBuscar = New fbButton
        Me.txt = New fbTextBox
        Me.FbPanel2 = New fbPanel
        Me.pnlExp = New fbPanel
        Me.dgvDados = New fbGridview
        Me.FbPanel3 = New fbPanel
        Me.FbButton3 = New fbButton
        Me.FbButton2 = New fbButton
        Me.FbButton1 = New fbButton
        Me.pnlpes = New fbPanel
        Me.FbButton4 = New fbButton
        Me.FbTextBox1 = New fbTextBox
        Me.FbPanel2.SuspendLayout()
        Me.pnlExp.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FbPanel3.SuspendLayout()
        Me.pnlpes.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.Location = New System.Drawing.Point(361, 0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(39, 20)
        Me.btnBuscar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Selecionar")
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt.Location = New System.Drawing.Point(0, 0)
        Me.txt.Name = "txt"
        Me.txt.ReadOnly = True
        Me.txt.Size = New System.Drawing.Size(400, 20)
        Me.txt.TabIndex = 1
        '
        'FbPanel2
        '
        Me.FbPanel2.Controls.Add(Me.btnBuscar)
        Me.FbPanel2.Controls.Add(Me.txt)
        Me.FbPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FbPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FbPanel2.Name = "FbPanel2"
        Me.FbPanel2.Size = New System.Drawing.Size(400, 20)
        Me.FbPanel2.TabIndex = 4
        '
        'pnlExp
        '
        Me.pnlExp.BackColor = System.Drawing.Color.Maroon
        Me.pnlExp.Controls.Add(Me.dgvDados)
        Me.pnlExp.Controls.Add(Me.FbPanel3)
        Me.pnlExp.Controls.Add(Me.pnlpes)
        Me.pnlExp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlExp.Location = New System.Drawing.Point(0, 20)
        Me.pnlExp.Name = "pnlExp"
        Me.pnlExp.Size = New System.Drawing.Size(400, 280)
        Me.pnlExp.TabIndex = 5
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.AllowUserToResizeRows = False
        Me.dgvDados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.colunaID = "ID"
        Me.dgvDados.ColunaSeleciona = True
        Me.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDados.idSel = -1
        Me.dgvDados.Location = New System.Drawing.Point(0, 28)
        Me.dgvDados.MultiSelect = False
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDados.RowHeadersVisible = False
        Me.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDados.Size = New System.Drawing.Size(400, 222)
        Me.dgvDados.TabIndex = 3
        '
        'FbPanel3
        '
        Me.FbPanel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.FbPanel3.Controls.Add(Me.FbButton3)
        Me.FbPanel3.Controls.Add(Me.FbButton2)
        Me.FbPanel3.Controls.Add(Me.FbButton1)
        Me.FbPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FbPanel3.Location = New System.Drawing.Point(0, 250)
        Me.FbPanel3.Name = "FbPanel3"
        Me.FbPanel3.Size = New System.Drawing.Size(400, 30)
        Me.FbPanel3.TabIndex = 2
        '
        'FbButton3
        '
        Me.FbButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FbButton3.Location = New System.Drawing.Point(19, 4)
        Me.FbButton3.Name = "FbButton3"
        Me.FbButton3.Size = New System.Drawing.Size(120, 23)
        Me.FbButton3.TabIndex = 2
        Me.FbButton3.Text = "Selecionar Todos"
        Me.FbButton3.UseVisualStyleBackColor = True
        '
        'FbButton2
        '
        Me.FbButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FbButton2.Location = New System.Drawing.Point(145, 4)
        Me.FbButton2.Name = "FbButton2"
        Me.FbButton2.Size = New System.Drawing.Size(110, 23)
        Me.FbButton2.TabIndex = 1
        Me.FbButton2.Text = "Limpar Seleção"
        Me.FbButton2.UseVisualStyleBackColor = True
        '
        'FbButton1
        '
        Me.FbButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FbButton1.BackColor = System.Drawing.Color.SteelBlue
        Me.FbButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FbButton1.Location = New System.Drawing.Point(308, 3)
        Me.FbButton1.Name = "FbButton1"
        Me.FbButton1.Size = New System.Drawing.Size(89, 23)
        Me.FbButton1.TabIndex = 0
        Me.FbButton1.Text = "OK"
        Me.FbButton1.UseVisualStyleBackColor = False
        '
        'pnlpes
        '
        Me.pnlpes.BackColor = System.Drawing.Color.LightSlateGray
        Me.pnlpes.Controls.Add(Me.FbButton4)
        Me.pnlpes.Controls.Add(Me.FbTextBox1)
        Me.pnlpes.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlpes.Location = New System.Drawing.Point(0, 0)
        Me.pnlpes.Name = "pnlpes"
        Me.pnlpes.Size = New System.Drawing.Size(400, 28)
        Me.pnlpes.TabIndex = 0
        '
        'FbButton4
        '
        Me.FbButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FbButton4.BackColor = System.Drawing.Color.SteelBlue
        Me.FbButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FbButton4.Location = New System.Drawing.Point(335, 3)
        Me.FbButton4.Name = "FbButton4"
        Me.FbButton4.Size = New System.Drawing.Size(62, 23)
        Me.FbButton4.TabIndex = 1
        Me.FbButton4.Text = "Filtrar"
        Me.FbButton4.UseVisualStyleBackColor = False
        '
        'FbTextBox1
        '
        Me.FbTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FbTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FbTextBox1.Location = New System.Drawing.Point(10, 4)
        Me.FbTextBox1.Name = "FbTextBox1"
        Me.FbTextBox1.Size = New System.Drawing.Size(319, 20)
        Me.FbTextBox1.TabIndex = 0
        '
        'fbLookUpMultiSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlExp)
        Me.Controls.Add(Me.FbPanel2)
        Me.Name = "fbLookUpMultiSelect"
        Me.Size = New System.Drawing.Size(400, 300)
        Me.FbPanel2.ResumeLayout(False)
        Me.FbPanel2.PerformLayout()
        Me.pnlExp.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FbPanel3.ResumeLayout(False)
        Me.pnlpes.ResumeLayout(False)
        Me.pnlpes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscar As fbButton
    Friend WithEvents txt As fbTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FbPanel2 As fbPanel
    Friend WithEvents pnlExp As fbPanel
    Friend WithEvents FbPanel3 As fbPanel
    Friend WithEvents FbButton3 As fbButton
    Friend WithEvents FbButton2 As fbButton
    Friend WithEvents FbButton1 As fbButton
    Friend WithEvents pnlpes As fbPanel
    Friend WithEvents FbButton4 As fbButton
    Friend WithEvents FbTextBox1 As fbTextBox
    Friend WithEvents dgvDados As fbGridview

End Class
