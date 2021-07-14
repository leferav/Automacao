<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fbExibirDados
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
        Me.FbPanel1 = New fbPanel
        Me.dgvDados = New fbGridview
        Me.btnInserir = New fbButton
        Me.btnEditar = New fbButton
        Me.btnExcluir = New fbButton
        Me.FbPanel1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FbPanel1
        '
        Me.FbPanel1.Controls.Add(Me.btnExcluir)
        Me.FbPanel1.Controls.Add(Me.btnEditar)
        Me.FbPanel1.Controls.Add(Me.btnInserir)
        Me.FbPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FbPanel1.Location = New System.Drawing.Point(0, 195)
        Me.FbPanel1.Name = "FbPanel1"
        Me.FbPanel1.Size = New System.Drawing.Size(373, 38)
        Me.FbPanel1.TabIndex = 0
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDados.Location = New System.Drawing.Point(0, 0)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(373, 195)
        Me.dgvDados.TabIndex = 1
        '
        'btnInserir
        '
        Me.btnInserir.Location = New System.Drawing.Point(21, 6)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(75, 23)
        Me.btnInserir.TabIndex = 0
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(134, 6)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(265, 6)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'fbExibirDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.FbPanel1)
        Me.Name = "fbExibirDados"
        Me.Size = New System.Drawing.Size(373, 233)
        Me.FbPanel1.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FbPanel1 As fbPanel
    Friend WithEvents btnExcluir As fbButton
    Friend WithEvents btnEditar As fbButton
    Friend WithEvents btnInserir As fbButton
    Friend WithEvents dgvDados As fbGridview

End Class
