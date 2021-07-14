<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGerenciaDeConfiguracoes
    Inherits FeedAutomacao.frmPadraoSeleciona

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnEditar = New FeedAutomacao.fbButtonVisual()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNome = New FeedAutomacao.fbTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescricao = New FeedAutomacao.fbTextBox()
        Me.pnlCampos.SuspendLayout()
        Me.pnlBarra.SuspendLayout()
        Me.menuFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCampos
        '
        Me.pnlCampos.Location = New System.Drawing.Point(0, 105)
        Me.pnlCampos.Size = New System.Drawing.Size(1165, 357)
        '
        'pnlAux
        '
        Me.pnlAux.Location = New System.Drawing.Point(0, 347)
        Me.pnlAux.Size = New System.Drawing.Size(1165, 10)
        '
        'pnlBarra
        '
        Me.pnlBarra.Controls.Add(Me.btnEditar)
        Me.pnlBarra.Location = New System.Drawing.Point(0, 483)
        Me.pnlBarra.Size = New System.Drawing.Size(1165, 53)
        '
        'pnlStatus
        '
        Me.pnlStatus.Location = New System.Drawing.Point(0, 462)
        Me.pnlStatus.Size = New System.Drawing.Size(1165, 21)
        '
        'menuFiltro
        '
        Me.menuFiltro.Controls.Add(Me.Label1)
        Me.menuFiltro.Controls.Add(Me.txtDescricao)
        Me.menuFiltro.Controls.Add(Me.Label6)
        Me.menuFiltro.Controls.Add(Me.txtNome)
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(1165, 105)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtNome, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.Label6, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtDescricao, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.Label1, 0)
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(14, 6)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(123, 41)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar(F6)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.botaoClear = False
        Me.txtNome.Campo = ""
        Me.txtNome.CaracterTipo = "U"
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.ControlDB = Nothing
        Me.txtNome.Location = New System.Drawing.Point(72, 29)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.NomeCampoMsg = "FbTextBox1"
        Me.txtNome.Requerido = False
        Me.txtNome.Size = New System.Drawing.Size(186, 20)
        Me.txtNome.TabIndex = 21
        Me.txtNome.Valor = Nothing
        Me.txtNome.valorVazio = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescricao.botaoClear = False
        Me.txtDescricao.Campo = ""
        Me.txtDescricao.CaracterTipo = "U"
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.ControlDB = Nothing
        Me.txtDescricao.Location = New System.Drawing.Point(72, 55)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.NomeCampoMsg = "FbTextBox1"
        Me.txtDescricao.Requerido = False
        Me.txtDescricao.Size = New System.Drawing.Size(424, 20)
        Me.txtDescricao.TabIndex = 23
        Me.txtDescricao.Valor = Nothing
        Me.txtDescricao.valorVazio = ""
        '
        'frmGerenciaDeConfiguracoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1165, 536)
        Me.Name = "frmGerenciaDeConfiguracoes"
        Me.Text = "Gerência de Configurações"
        Me.veMenuFiltro = True
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlBarra.ResumeLayout(False)
        Me.menuFiltro.ResumeLayout(False)
        Me.menuFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEditar As fbButtonVisual
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNome As fbTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescricao As fbTextBox
End Class
