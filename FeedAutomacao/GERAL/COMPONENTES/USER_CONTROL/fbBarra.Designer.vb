<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fbBarra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fbBarra))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCancela = New fbButton
        Me.btnExclui = New fbButton
        Me.btnSalva = New fbButton
        Me.btnEdita = New fbButton
        Me.btnNovo = New fbButton
        Me.btnFim = New fbButton
        Me.btnAvanca = New fbButton
        Me.btnVolta = New fbButton
        Me.btnInicio = New fbButton
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolTip1.IsBalloon = True
        '
        'btnCancela
        '
        Me.btnCancela.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancela.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancela.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancela.Image = CType(resources.GetObject("btnCancela.Image"), System.Drawing.Image)
        Me.btnCancela.Location = New System.Drawing.Point(480, 0)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(60, 44)
        Me.btnCancela.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.btnCancela, "Cancelar (ESC)")
        Me.btnCancela.UseVisualStyleBackColor = False
        '
        'btnExclui
        '
        Me.btnExclui.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExclui.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExclui.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExclui.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExclui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnExclui.Image = CType(resources.GetObject("btnExclui.Image"), System.Drawing.Image)
        Me.btnExclui.Location = New System.Drawing.Point(420, 0)
        Me.btnExclui.Name = "btnExclui"
        Me.btnExclui.Size = New System.Drawing.Size(60, 44)
        Me.btnExclui.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnExclui, "Excluir (SHIFT+F2)")
        Me.btnExclui.UseVisualStyleBackColor = False
        '
        'btnSalva
        '
        Me.btnSalva.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalva.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalva.Image = CType(resources.GetObject("btnSalva.Image"), System.Drawing.Image)
        Me.btnSalva.Location = New System.Drawing.Point(360, 0)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(60, 44)
        Me.btnSalva.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnSalva, "Salvar (F2)")
        Me.btnSalva.UseVisualStyleBackColor = False
        '
        'btnEdita
        '
        Me.btnEdita.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEdita.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdita.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEdita.Image = CType(resources.GetObject("btnEdita.Image"), System.Drawing.Image)
        Me.btnEdita.Location = New System.Drawing.Point(300, 0)
        Me.btnEdita.Name = "btnEdita"
        Me.btnEdita.Size = New System.Drawing.Size(60, 44)
        Me.btnEdita.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnEdita, "Editar (F6)")
        Me.btnEdita.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(240, 0)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(60, 44)
        Me.btnNovo.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnNovo, "Inserir (F5)")
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnFim
        '
        Me.btnFim.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnFim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFim.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnFim.Image = CType(resources.GetObject("btnFim.Image"), System.Drawing.Image)
        Me.btnFim.Location = New System.Drawing.Point(180, 0)
        Me.btnFim.Name = "btnFim"
        Me.btnFim.Size = New System.Drawing.Size(60, 44)
        Me.btnFim.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnFim, "Ultimo (END)")
        Me.btnFim.UseVisualStyleBackColor = False
        '
        'btnAvanca
        '
        Me.btnAvanca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAvanca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvanca.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAvanca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvanca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAvanca.Image = CType(resources.GetObject("btnAvanca.Image"), System.Drawing.Image)
        Me.btnAvanca.Location = New System.Drawing.Point(120, 0)
        Me.btnAvanca.Name = "btnAvanca"
        Me.btnAvanca.Size = New System.Drawing.Size(60, 44)
        Me.btnAvanca.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnAvanca, "Avançar (F8)")
        Me.btnAvanca.UseVisualStyleBackColor = False
        '
        'btnVolta
        '
        Me.btnVolta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnVolta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolta.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnVolta.Image = CType(resources.GetObject("btnVolta.Image"), System.Drawing.Image)
        Me.btnVolta.Location = New System.Drawing.Point(60, 0)
        Me.btnVolta.Name = "btnVolta"
        Me.btnVolta.Size = New System.Drawing.Size(60, 44)
        Me.btnVolta.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnVolta, "Voltar (F7)")
        Me.btnVolta.UseVisualStyleBackColor = False
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), System.Drawing.Image)
        Me.btnInicio.Location = New System.Drawing.Point(0, 0)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(60, 44)
        Me.btnInicio.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnInicio, "Primeiro (HOME)")
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'fbBarra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.btnExclui)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.btnEdita)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnFim)
        Me.Controls.Add(Me.btnAvanca)
        Me.Controls.Add(Me.btnVolta)
        Me.Controls.Add(Me.btnInicio)
        Me.Name = "fbBarra"
        Me.Size = New System.Drawing.Size(540, 44)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInicio As fbButton
    Friend WithEvents btnVolta As fbButton
    Friend WithEvents btnAvanca As fbButton
    Friend WithEvents btnFim As fbButton
    Friend WithEvents btnNovo As fbButton
    Friend WithEvents btnEdita As fbButton
    Friend WithEvents btnSalva As fbButton
    Friend WithEvents btnExclui As fbButton
    Friend WithEvents btnCancela As fbButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
