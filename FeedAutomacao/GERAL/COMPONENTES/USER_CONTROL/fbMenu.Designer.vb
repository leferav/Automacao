<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fbMenu
    Inherits Panel

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
        Me.pnlDireita = New fbPanel()
        Me.pnlEsquerda = New fbPanel()
        Me.pnlFundo = New fbPanel()
        Me.pnlTopo = New fbPanel()
        Me.Panel2 = New fbPanel()
        Me.lblTitulo = New fbLabel()
        Me.pnlTopoTopo = New fbPanel()
        Me.pnlFechhar = New fbPanel()
        Me.pnlFecha = New fbPanel()
        Me.Panel3 = New fbPanel()
        Me.pnlIcone = New fbPanel()
        Me.pnlTopo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlFechhar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDireita
        '
        Me.pnlDireita.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDireita.Location = New System.Drawing.Point(119, 0)
        Me.pnlDireita.Name = "pnlDireita"
        Me.pnlDireita.Size = New System.Drawing.Size(2, 80)
        Me.pnlDireita.TabIndex = 3
        '
        'pnlEsquerda
        '
        Me.pnlEsquerda.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlEsquerda.Location = New System.Drawing.Point(0, 0)
        Me.pnlEsquerda.Name = "pnlEsquerda"
        Me.pnlEsquerda.Size = New System.Drawing.Size(2, 80)
        Me.pnlEsquerda.TabIndex = 2
        '
        'pnlFundo
        '
        Me.pnlFundo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlFundo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFundo.Location = New System.Drawing.Point(2, 78)
        Me.pnlFundo.Name = "pnlFundo"
        Me.pnlFundo.Size = New System.Drawing.Size(117, 2)
        Me.pnlFundo.TabIndex = 1
        '
        'pnlTopo
        '
        Me.pnlTopo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlTopo.Controls.Add(Me.Panel2)
        Me.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopo.Location = New System.Drawing.Point(2, 0)
        Me.pnlTopo.Name = "pnlTopo"
        Me.pnlTopo.Size = New System.Drawing.Size(117, 25)
        Me.pnlTopo.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lblTitulo)
        Me.Panel2.Controls.Add(Me.pnlTopoTopo)
        Me.Panel2.Controls.Add(Me.pnlFechhar)
        Me.Panel2.Controls.Add(Me.pnlIcone)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(117, 25)
        Me.Panel2.TabIndex = 7
        '
        'lblTitulo
        '
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(25, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(64, 20)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "T"
        '
        'pnlTopoTopo
        '
        Me.pnlTopoTopo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopoTopo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.pnlTopoTopo.Location = New System.Drawing.Point(25, 0)
        Me.pnlTopoTopo.Name = "pnlTopoTopo"
        Me.pnlTopoTopo.Size = New System.Drawing.Size(64, 5)
        Me.pnlTopoTopo.TabIndex = 9
        '
        'pnlFechhar
        '
        Me.pnlFechhar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlFechhar.Controls.Add(Me.pnlFecha)
        Me.pnlFechhar.Controls.Add(Me.Panel3)
        Me.pnlFechhar.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlFechhar.Location = New System.Drawing.Point(89, 0)
        Me.pnlFechhar.Name = "pnlFechhar"
        Me.pnlFechhar.Size = New System.Drawing.Size(28, 25)
        Me.pnlFechhar.TabIndex = 8
        '
        'pnlFecha
        '
        Me.pnlFecha.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFecha.Location = New System.Drawing.Point(0, 0)
        Me.pnlFecha.Name = "pnlFecha"
        Me.pnlFecha.Size = New System.Drawing.Size(24, 25)
        Me.pnlFecha.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(24, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(4, 25)
        Me.Panel3.TabIndex = 6
        '
        'pnlIcone
        '
        Me.pnlIcone.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlIcone.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlIcone.Location = New System.Drawing.Point(0, 0)
        Me.pnlIcone.Name = "pnlIcone"
        Me.pnlIcone.Size = New System.Drawing.Size(25, 25)
        Me.pnlIcone.TabIndex = 7
        '
        'fbMenu
        '
        Me.Controls.Add(Me.pnlTopo)
        Me.Controls.Add(Me.pnlFundo)
        Me.Controls.Add(Me.pnlEsquerda)
        Me.Controls.Add(Me.pnlDireita)
        Me.Name = "clpnlMenu"
        Me.Size = New System.Drawing.Size(121, 80)
        Me.pnlTopo.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlFechhar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlDireita As fbPanel
    Friend WithEvents pnlEsquerda As fbPanel
    Friend WithEvents pnlFundo As fbPanel
    Friend WithEvents pnlTopo As fbPanel
    Friend WithEvents Panel2 As fbPanel
    Friend WithEvents lblTitulo As fbLabel
    Friend WithEvents pnlTopoTopo As fbPanel
    Friend WithEvents pnlFechhar As fbPanel
    Friend WithEvents pnlFecha As fbPanel
    Friend WithEvents Panel3 As fbPanel
    Friend WithEvents pnlIcone As fbPanel

End Class
