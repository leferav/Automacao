<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fbGridViewST
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvDados = New fbGridviewCad()
        Me.pnlStatus = New fbPanel()
        Me.lbLinhas = New fbLabel()
        Me.FbLabel1 = New fbLabel()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgvDados.ColunaSeleciona = False
        Me.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDados.Location = New System.Drawing.Point(0, 0)
        Me.dgvDados.MultiSelect = False
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDados.RowHeadersVisible = False
        Me.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDados.Size = New System.Drawing.Size(488, 289)
        Me.dgvDados.TabIndex = 0
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlStatus.Controls.Add(Me.lbLinhas)
        Me.pnlStatus.Controls.Add(Me.FbLabel1)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 289)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(488, 21)
        Me.pnlStatus.TabIndex = 1
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
        'fbGridViewST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.pnlStatus)
        Me.Name = "fbGridViewST"
        Me.Size = New System.Drawing.Size(488, 310)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvDados As fbGridviewCad
    Public WithEvents pnlStatus As fbPanel
    Friend WithEvents lbLinhas As fbLabel
    Friend WithEvents FbLabel1 As fbLabel

End Class
