<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesquisaVeiculo
    Inherits FeedAutomacao.frmPadraoPesquisa

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
        Me.FbLabel1 = New FeedAutomacao.fbLabel
        Me.txtNome = New FeedAutomacao.fbTextBox
        Me.txtPLaca = New FeedAutomacao.fbMaskBox
        Me.FbLabel4 = New FeedAutomacao.fbLabel
        Me.menuFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuFiltro
        '
        Me.menuFiltro.Controls.Add(Me.txtPLaca)
        Me.menuFiltro.Controls.Add(Me.FbLabel4)
        Me.menuFiltro.Controls.Add(Me.FbLabel1)
        Me.menuFiltro.Controls.Add(Me.txtNome)
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(468, 99)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtNome, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel1, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel4, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtPLaca, 0)
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel1.Location = New System.Drawing.Point(30, 53)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(38, 13)
        Me.FbLabel1.TabIndex = 17
        Me.FbLabel1.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(71, 50)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Requerido = False
        Me.txtNome.Size = New System.Drawing.Size(385, 20)
        Me.txtNome.TabIndex = 1
        '
        'txtPLaca
        '
        Me.txtPLaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPLaca.Location = New System.Drawing.Point(71, 28)
        Me.txtPLaca.Mask = "AAA-9999"
        Me.txtPLaca.Name = "txtPLaca"
        Me.txtPLaca.Requerido = False
        Me.txtPLaca.Size = New System.Drawing.Size(82, 20)
        Me.txtPLaca.TabIndex = 0
        '
        'FbLabel4
        '
        Me.FbLabel4.AutoSize = True
        Me.FbLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel4.Location = New System.Drawing.Point(31, 31)
        Me.FbLabel4.Name = "FbLabel4"
        Me.FbLabel4.Size = New System.Drawing.Size(37, 13)
        Me.FbLabel4.TabIndex = 20
        Me.FbLabel4.Text = "Placa:"
        '
        'frmPesquisaVeiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(468, 372)
        Me.controlFocus = Me.txtPLaca
        Me.Filtro = True
        Me.GridVisivel = True
        Me.Name = "frmPesquisaVeiculo"
        Me.Text = "Pesquisar Veículo"
        Me.ValVisivel = "Nome"
        Me.menuFiltro.ResumeLayout(False)
        Me.menuFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FbLabel1 As FeedAutomacao.fbLabel
    Friend WithEvents txtNome As FeedAutomacao.fbTextBox
    Friend WithEvents txtPLaca As FeedAutomacao.fbMaskBox
    Friend WithEvents FbLabel4 As FeedAutomacao.fbLabel

End Class
