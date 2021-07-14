<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelClientes
    Inherits FeedAutomacao.frmPadraoRelatorio

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelClientes))
        Me.cbbCliente = New FeedAutomacao.fbComboBox()
        Me.group1 = New FeedAutomacao.fbGroupBox()
        Me.rbAtv = New FeedAutomacao.fbRadioButton()
        Me.rbTodos = New FeedAutomacao.fbRadioButton()
        Me.rbIna = New FeedAutomacao.fbRadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.group1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbbCliente
        '
        Me.cbbCliente.AgrupadoPor = Nothing
        Me.cbbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbCliente.Campo = ""
        Me.cbbCliente.campoID = "ID"
        Me.cbbCliente.campoOrdem = Nothing
        Me.cbbCliente.campoRelacionamento = Nothing
        Me.cbbCliente.campoSelecionavel = "NOME"
        Me.cbbCliente.campoSql = Nothing
        Me.cbbCliente.campoSqlID = Nothing
        Me.cbbCliente.carrega2Parametro = False
        Me.cbbCliente.carregaClick = True
        Me.cbbCliente.comDistinct = False
        Me.cbbCliente.ControlDB = Nothing
        Me.cbbCliente.DisplayMember = "Texto"
        Me.cbbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbCliente.Filtro = Nothing
        Me.cbbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbCliente.FormattingEnabled = True
        Me.cbbCliente.Location = New System.Drawing.Point(72, 8)
        Me.cbbCliente.Name = "cbbCliente"
        Me.cbbCliente.NomeCampoMsg = "FbComboBox1"
        Me.cbbCliente.Ordena = Nothing
        Me.cbbCliente.Requerido = False
        Me.cbbCliente.Size = New System.Drawing.Size(245, 21)
        Me.cbbCliente.TabelaRelacionamento = "TB_CLIENTES"
        Me.cbbCliente.TabIndex = 3
        Me.cbbCliente.TextoSelecionar = "Selecione o Cliente"
        Me.cbbCliente.Valor = Nothing
        Me.cbbCliente.ValorRelacionamento = Nothing
        Me.cbbCliente.ValorSelecionado = "-1"
        Me.cbbCliente.valorVazio = -1
        Me.cbbCliente.ValueMember = "Valor"
        '
        'group1
        '
        Me.group1.Controls.Add(Me.rbAtv)
        Me.group1.Controls.Add(Me.rbTodos)
        Me.group1.Controls.Add(Me.rbIna)
        Me.group1.Location = New System.Drawing.Point(73, 35)
        Me.group1.Name = "group1"
        Me.group1.Size = New System.Drawing.Size(244, 67)
        Me.group1.TabIndex = 6
        Me.group1.TabStop = False
        Me.group1.Text = "Status"
        '
        'rbAtv
        '
        Me.rbAtv.AutoSize = True
        Me.rbAtv.Campo = ""
        Me.rbAtv.ControlDB = Nothing
        Me.rbAtv.Location = New System.Drawing.Point(12, 37)
        Me.rbAtv.Name = "rbAtv"
        Me.rbAtv.Size = New System.Drawing.Size(49, 17)
        Me.rbAtv.TabIndex = 9
        Me.rbAtv.Text = "Ativo"
        Me.rbAtv.UseVisualStyleBackColor = True
        Me.rbAtv.Valor = Nothing
        Me.rbAtv.ValorChecado = Nothing
        Me.rbAtv.valorVazio = False
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Campo = ""
        Me.rbTodos.Checked = True
        Me.rbTodos.ControlDB = Nothing
        Me.rbTodos.Location = New System.Drawing.Point(12, 14)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 8
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        Me.rbTodos.Valor = Nothing
        Me.rbTodos.ValorChecado = Nothing
        Me.rbTodos.valorVazio = False
        '
        'rbIna
        '
        Me.rbIna.AutoSize = True
        Me.rbIna.Campo = ""
        Me.rbIna.ControlDB = Nothing
        Me.rbIna.Location = New System.Drawing.Point(139, 12)
        Me.rbIna.Name = "rbIna"
        Me.rbIna.Size = New System.Drawing.Size(57, 17)
        Me.rbIna.TabIndex = 7
        Me.rbIna.Text = "Inativo"
        Me.rbIna.UseVisualStyleBackColor = True
        Me.rbIna.Valor = Nothing
        Me.rbIna.ValorChecado = Nothing
        Me.rbIna.valorVazio = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cliente:"
        '
        'frmRelClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(372, 144)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.group1)
        Me.Controls.Add(Me.cbbCliente)
        Me.Name = "frmRelClientes"
        Me.Text = "Relatório de Solicitações"
        Me.Controls.SetChildIndex(Me.cbbCliente, 0)
        Me.Controls.SetChildIndex(Me.group1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.group1.ResumeLayout(False)
        Me.group1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbbCliente As fbComboBox
    Friend WithEvents group1 As fbGroupBox
    Friend WithEvents rbTodos As fbRadioButton
    Friend WithEvents rbIna As fbRadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents rbAtv As fbRadioButton
End Class
