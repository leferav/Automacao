<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fbLookUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fbLookUp))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBuscar = New fbButton()
        Me.btnLimpar = New fbButton()
        Me.txt = New fbTextBox()
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
        Me.btnBuscar.Location = New System.Drawing.Point(285, 0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(32, 20)
        Me.btnBuscar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Selecionar")
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLimpar.BackgroundImage = CType(resources.GetObject("btnLimpar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpar.Location = New System.Drawing.Point(253, 0)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(32, 20)
        Me.btnLimpar.TabIndex = 2
        Me.btnLimpar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnLimpar, "Limpar")
        Me.btnLimpar.UseVisualStyleBackColor = False
        Me.btnLimpar.Visible = False
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt.botaoClear = False
        Me.txt.Campo = ""
        Me.txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt.ControlDB = Nothing
        Me.txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt.Location = New System.Drawing.Point(0, 0)
        Me.txt.Name = "txt"
        Me.txt.NomeCampoMsg = ""
        Me.txt.ReadOnly = True
        Me.txt.Requerido = False
        Me.txt.Size = New System.Drawing.Size(285, 20)
        Me.txt.TabIndex = 1
        Me.txt.TabStop = False
        Me.txt.Valor = Nothing
        Me.txt.valorVazio = ""
        '
        'fbLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnLimpar)
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
    Friend WithEvents btnLimpar As fbButton
End Class
