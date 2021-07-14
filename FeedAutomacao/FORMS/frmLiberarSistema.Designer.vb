<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLiberarSistema
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
        Me.lkpCliente = New FeedAutomacao.fbLookUp()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLiberar = New FeedAutomacao.fbButtonVisual()
        Me.rbt = New FeedAutomacao.fbRadioButton()
        Me.rbA = New FeedAutomacao.fbRadioButton()
        Me.rbI = New FeedAutomacao.fbRadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtData = New FeedAutomacao.fbLabel()
        Me.txtDataBloqueio = New FeedAutomacao.fbDate()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckbSeleciona = New System.Windows.Forms.CheckBox()
        Me.ckbCorrecao = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbSetorTodos = New FeedAutomacao.fbRadioButton()
        Me.rbSetorCom = New FeedAutomacao.fbRadioButton()
        Me.rbSetorWMS = New FeedAutomacao.fbRadioButton()
        Me.pnlCampos.SuspendLayout()
        Me.pnlBarra.SuspendLayout()
        Me.menuFiltro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCampos
        '
        Me.pnlCampos.Location = New System.Drawing.Point(0, 127)
        Me.pnlCampos.Size = New System.Drawing.Size(998, 335)
        '
        'pnlAux
        '
        Me.pnlAux.Dock = System.Windows.Forms.DockStyle.None
        Me.pnlAux.Location = New System.Drawing.Point(0, 279)
        Me.pnlAux.Size = New System.Drawing.Size(935, 50)
        '
        'pnlBarra
        '
        Me.pnlBarra.Controls.Add(Me.ckbCorrecao)
        Me.pnlBarra.Controls.Add(Me.GroupBox2)
        Me.pnlBarra.Controls.Add(Me.btnLiberar)
        Me.pnlBarra.Location = New System.Drawing.Point(0, 483)
        Me.pnlBarra.Size = New System.Drawing.Size(998, 53)
        '
        'pnlStatus
        '
        Me.pnlStatus.Location = New System.Drawing.Point(0, 462)
        Me.pnlStatus.Size = New System.Drawing.Size(998, 21)
        '
        'menuFiltro
        '
        Me.menuFiltro.Controls.Add(Me.GroupBox3)
        Me.menuFiltro.Controls.Add(Me.ckbSeleciona)
        Me.menuFiltro.Controls.Add(Me.GroupBox1)
        Me.menuFiltro.Controls.Add(Me.Label1)
        Me.menuFiltro.Controls.Add(Me.lkpCliente)
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(998, 127)
        Me.menuFiltro.Controls.SetChildIndex(Me.lkpCliente, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.Label1, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.ckbSeleciona, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.GroupBox3, 0)
        '
        'lkpCliente
        '
        Me.lkpCliente.ControlDB = Nothing
        Me.lkpCliente.DataTableSelect = Nothing
        Me.lkpCliente.FormularioPesquisa = Nothing
        Me.lkpCliente.LimpaTexto = True
        Me.lkpCliente.Location = New System.Drawing.Point(59, 32)
        Me.lkpCliente.Name = "lkpCliente"
        Me.lkpCliente.NomeCampoMsg = "fbLookUp"
        Me.lkpCliente.Requerido = False
        Me.lkpCliente.SelectID = -1
        Me.lkpCliente.Size = New System.Drawing.Size(587, 20)
        Me.lkpCliente.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cliente:"
        '
        'btnLiberar
        '
        Me.btnLiberar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnLiberar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiberar.ForeColor = System.Drawing.Color.White
        Me.btnLiberar.Location = New System.Drawing.Point(846, 6)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(147, 41)
        Me.btnLiberar.TabIndex = 0
        Me.btnLiberar.Text = "Liberar"
        '
        'rbt
        '
        Me.rbt.AutoSize = True
        Me.rbt.Campo = ""
        Me.rbt.Checked = True
        Me.rbt.ControlDB = Nothing
        Me.rbt.Location = New System.Drawing.Point(6, 16)
        Me.rbt.Name = "rbt"
        Me.rbt.Size = New System.Drawing.Size(55, 17)
        Me.rbt.TabIndex = 8
        Me.rbt.TabStop = True
        Me.rbt.Text = "Todos"
        Me.rbt.UseVisualStyleBackColor = True
        Me.rbt.Valor = Nothing
        Me.rbt.ValorChecado = Nothing
        Me.rbt.valorVazio = False
        '
        'rbA
        '
        Me.rbA.AutoSize = True
        Me.rbA.Campo = ""
        Me.rbA.ControlDB = Nothing
        Me.rbA.Location = New System.Drawing.Point(6, 36)
        Me.rbA.Name = "rbA"
        Me.rbA.Size = New System.Drawing.Size(49, 17)
        Me.rbA.TabIndex = 9
        Me.rbA.Text = "Ativo"
        Me.rbA.UseVisualStyleBackColor = True
        Me.rbA.Valor = Nothing
        Me.rbA.ValorChecado = Nothing
        Me.rbA.valorVazio = False
        '
        'rbI
        '
        Me.rbI.AutoSize = True
        Me.rbI.Campo = ""
        Me.rbI.ControlDB = Nothing
        Me.rbI.Location = New System.Drawing.Point(6, 56)
        Me.rbI.Name = "rbI"
        Me.rbI.Size = New System.Drawing.Size(62, 17)
        Me.rbI.TabIndex = 10
        Me.rbI.Text = "Inativos"
        Me.rbI.UseVisualStyleBackColor = True
        Me.rbI.Valor = Nothing
        Me.rbI.ValorChecado = Nothing
        Me.rbI.valorVazio = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbt)
        Me.GroupBox1.Controls.Add(Me.rbI)
        Me.GroupBox1.Controls.Add(Me.rbA)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(916, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(80, 77)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtData.Location = New System.Drawing.Point(13, 17)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(91, 13)
        Me.txtData.TabIndex = 13
        Me.txtData.Text = "Data Bloqueio:"
        '
        'txtDataBloqueio
        '
        Me.txtDataBloqueio.BackColor = System.Drawing.Color.White
        Me.txtDataBloqueio.ControlDB = Nothing
        Me.txtDataBloqueio.CustomFormat = "dd/MM/yyyy"
        Me.txtDataBloqueio.DataAtual = False
        Me.txtDataBloqueio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataBloqueio.Location = New System.Drawing.Point(105, 14)
        Me.txtDataBloqueio.Name = "txtDataBloqueio"
        Me.txtDataBloqueio.NomeCampoMsg = "FbDate1"
        Me.txtDataBloqueio.Requerido = False
        Me.txtDataBloqueio.Size = New System.Drawing.Size(105, 20)
        Me.txtDataBloqueio.TabIndex = 12
        Me.txtDataBloqueio.Value = New Date(2020, 1, 16, 0, 0, 0, 0)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDataBloqueio)
        Me.GroupBox2.Controls.Add(Me.txtData)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(615, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 40)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'ckbSeleciona
        '
        Me.ckbSeleciona.AutoSize = True
        Me.ckbSeleciona.Location = New System.Drawing.Point(59, 58)
        Me.ckbSeleciona.Name = "ckbSeleciona"
        Me.ckbSeleciona.Size = New System.Drawing.Size(106, 17)
        Me.ckbSeleciona.TabIndex = 12
        Me.ckbSeleciona.Text = "Seleciona Todos"
        Me.ckbSeleciona.UseVisualStyleBackColor = True
        '
        'ckbCorrecao
        '
        Me.ckbCorrecao.AutoSize = True
        Me.ckbCorrecao.Location = New System.Drawing.Point(497, 22)
        Me.ckbCorrecao.Name = "ckbCorrecao"
        Me.ckbCorrecao.Size = New System.Drawing.Size(110, 17)
        Me.ckbCorrecao.TabIndex = 13
        Me.ckbCorrecao.Text = "Correção de Data"
        Me.ckbCorrecao.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbSetorTodos)
        Me.GroupBox3.Controls.Add(Me.rbSetorCom)
        Me.GroupBox3.Controls.Add(Me.rbSetorWMS)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(828, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(88, 77)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Setor"
        '
        'rbSetorTodos
        '
        Me.rbSetorTodos.AutoSize = True
        Me.rbSetorTodos.Campo = ""
        Me.rbSetorTodos.Checked = True
        Me.rbSetorTodos.ControlDB = Nothing
        Me.rbSetorTodos.Location = New System.Drawing.Point(6, 16)
        Me.rbSetorTodos.Name = "rbSetorTodos"
        Me.rbSetorTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbSetorTodos.TabIndex = 8
        Me.rbSetorTodos.TabStop = True
        Me.rbSetorTodos.Text = "Todos"
        Me.rbSetorTodos.UseVisualStyleBackColor = True
        Me.rbSetorTodos.Valor = Nothing
        Me.rbSetorTodos.ValorChecado = Nothing
        Me.rbSetorTodos.valorVazio = False
        '
        'rbSetorCom
        '
        Me.rbSetorCom.AutoSize = True
        Me.rbSetorCom.Campo = ""
        Me.rbSetorCom.ControlDB = Nothing
        Me.rbSetorCom.Location = New System.Drawing.Point(6, 56)
        Me.rbSetorCom.Name = "rbSetorCom"
        Me.rbSetorCom.Size = New System.Drawing.Size(71, 17)
        Me.rbSetorCom.TabIndex = 10
        Me.rbSetorCom.Text = "Comercial"
        Me.rbSetorCom.UseVisualStyleBackColor = True
        Me.rbSetorCom.Valor = Nothing
        Me.rbSetorCom.ValorChecado = Nothing
        Me.rbSetorCom.valorVazio = False
        '
        'rbSetorWMS
        '
        Me.rbSetorWMS.AutoSize = True
        Me.rbSetorWMS.Campo = ""
        Me.rbSetorWMS.ControlDB = Nothing
        Me.rbSetorWMS.Location = New System.Drawing.Point(6, 36)
        Me.rbSetorWMS.Name = "rbSetorWMS"
        Me.rbSetorWMS.Size = New System.Drawing.Size(68, 17)
        Me.rbSetorWMS.TabIndex = 9
        Me.rbSetorWMS.Text = "Armazém"
        Me.rbSetorWMS.UseVisualStyleBackColor = True
        Me.rbSetorWMS.Valor = Nothing
        Me.rbSetorWMS.ValorChecado = Nothing
        Me.rbSetorWMS.valorVazio = False
        '
        'frmLiberarSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(998, 536)
        Me.ColunaSelecionavel = True
        Me.ControlBox = False
        Me.Name = "frmLiberarSistema"
        Me.Text = "Liberação de Sistema"
        Me.veMenuFiltro = True
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlBarra.ResumeLayout(False)
        Me.pnlBarra.PerformLayout()
        Me.menuFiltro.ResumeLayout(False)
        Me.menuFiltro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lkpCliente As fbLookUp
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLiberar As fbButtonVisual
    Friend WithEvents rbA As fbRadioButton
    Friend WithEvents rbt As fbRadioButton
    Friend WithEvents rbI As fbRadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDataBloqueio As fbDate
    Friend WithEvents txtData As fbLabel
    Friend WithEvents ckbSeleciona As CheckBox
    Friend WithEvents ckbCorrecao As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbSetorTodos As fbRadioButton
    Friend WithEvents rbSetorCom As fbRadioButton
    Friend WithEvents rbSetorWMS As fbRadioButton
End Class
