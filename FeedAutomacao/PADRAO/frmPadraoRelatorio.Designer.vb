<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPadraoRelatorio
    Inherits frmPadrao

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
        Me.btnRelatorio = New fbButtonVisual()
        Me.FbPanel1 = New fbPanel()
        Me.FbPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorio.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRelatorio.ForeColor = System.Drawing.Color.White
        Me.btnRelatorio.Location = New System.Drawing.Point(150, 4)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(136, 27)
        Me.btnRelatorio.TabIndex = 0
        Me.btnRelatorio.Text = "Gerar Relatório (F12)"
        '
        'FbPanel1
        '
        Me.FbPanel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.FbPanel1.Controls.Add(Me.btnRelatorio)
        Me.FbPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FbPanel1.Location = New System.Drawing.Point(0, 239)
        Me.FbPanel1.Name = "FbPanel1"
        Me.FbPanel1.Size = New System.Drawing.Size(292, 34)
        Me.FbPanel1.TabIndex = 1
        '
        'frmPadraoRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.FbPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPadraoRelatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FbPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRelatorio As fbButtonVisual
    Friend WithEvents FbPanel1 As fbPanel

End Class
