<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fbLookUpTreeView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fbLookUpTreeView))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt = New fbTextBox
        Me.btnBuscar = New fbButton
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt.Location = New System.Drawing.Point(0, 0)
        Me.txt.Name = "txt"
        Me.txt.ReadOnly = True
        Me.txt.Size = New System.Drawing.Size(278, 20)
        Me.txt.TabIndex = 1
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
        Me.btnBuscar.Location = New System.Drawing.Point(278, 0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(39, 20)
        Me.btnBuscar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Selecionar")
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'fbLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.btnBuscar)
        Me.Name = "fbLookUp"
        Me.Size = New System.Drawing.Size(317, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscar As fbButton
    Friend WithEvents txt As fbTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
