<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelPortaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelPortaria))
        Me.txtDataFim = New FeedAutomacao.fbDate()
        Me.Label3 = New FeedAutomacao.fbLabel()
        Me.Label7 = New FeedAutomacao.fbLabel()
        Me.txtData = New FeedAutomacao.fbDate()
        Me.FbGroupBox3 = New FeedAutomacao.fbGroupBox()
        Me.rbSaida = New FeedAutomacao.fbRadioButton()
        Me.rbEntrada = New FeedAutomacao.fbRadioButton()
        Me.rbPesagem2 = New FeedAutomacao.fbRadioButton()
        Me.rbPesagem1 = New FeedAutomacao.fbRadioButton()
        Me.rbTodos = New FeedAutomacao.fbRadioButton()
        Me.cbbVeiculo = New FeedAutomacao.fbComboBox()
        Me.FbLabel5 = New FeedAutomacao.fbLabel()
        Me.cbbTipo = New FeedAutomacao.fbComboBox()
        Me.FbLabel13 = New FeedAutomacao.fbLabel()
        Me.cbbDomicilio = New FeedAutomacao.fbComboBox()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.cbbFuncionario = New FeedAutomacao.fbComboBox()
        Me.FbLabel4 = New FeedAutomacao.fbLabel()
        Me.FbGroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDataFim
        '
        Me.txtDataFim.BackColor = System.Drawing.Color.White
        Me.txtDataFim.ControlDB = Nothing
        Me.txtDataFim.CustomFormat = "dd/MM/yyyy"
        Me.txtDataFim.DataAtual = False
        Me.txtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataFim.Location = New System.Drawing.Point(320, 99)
        Me.txtDataFim.Name = "txtDataFim"
        Me.txtDataFim.NomeCampoMsg = "DataFim"
        Me.txtDataFim.Requerido = False
        Me.txtDataFim.ShowCheckBox = True
        Me.txtDataFim.Size = New System.Drawing.Size(99, 20)
        Me.txtDataFim.TabIndex = 5
        Me.txtDataFim.Value = New Date(2011, 4, 19, 11, 22, 25, 564)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(260, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 185
        Me.Label3.Text = "Data Final:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(17, 102)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 182
        Me.Label7.Text = "Data Inicial:"
        '
        'txtData
        '
        Me.txtData.BackColor = System.Drawing.Color.White
        Me.txtData.ControlDB = Nothing
        Me.txtData.CustomFormat = "dd/MM/yyyy"
        Me.txtData.DataAtual = False
        Me.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtData.Location = New System.Drawing.Point(83, 99)
        Me.txtData.Name = "txtData"
        Me.txtData.NomeCampoMsg = "Data"
        Me.txtData.Requerido = False
        Me.txtData.ShowCheckBox = True
        Me.txtData.Size = New System.Drawing.Size(96, 20)
        Me.txtData.TabIndex = 4
        Me.txtData.Value = New Date(2011, 4, 19, 11, 22, 25, 626)
        '
        'FbGroupBox3
        '
        Me.FbGroupBox3.Controls.Add(Me.rbSaida)
        Me.FbGroupBox3.Controls.Add(Me.rbEntrada)
        Me.FbGroupBox3.Controls.Add(Me.rbPesagem2)
        Me.FbGroupBox3.Controls.Add(Me.rbPesagem1)
        Me.FbGroupBox3.Controls.Add(Me.rbTodos)
        Me.FbGroupBox3.Location = New System.Drawing.Point(81, 125)
        Me.FbGroupBox3.Name = "FbGroupBox3"
        Me.FbGroupBox3.Size = New System.Drawing.Size(336, 60)
        Me.FbGroupBox3.TabIndex = 7
        Me.FbGroupBox3.TabStop = False
        Me.FbGroupBox3.Text = "Status"
        '
        'rbSaida
        '
        Me.rbSaida.AutoSize = True
        Me.rbSaida.Campo = ""
        Me.rbSaida.ControlDB = Nothing
        Me.rbSaida.Location = New System.Drawing.Point(110, 38)
        Me.rbSaida.Name = "rbSaida"
        Me.rbSaida.Size = New System.Drawing.Size(54, 17)
        Me.rbSaida.TabIndex = 4
        Me.rbSaida.Text = "Saída"
        Me.rbSaida.UseVisualStyleBackColor = True
        Me.rbSaida.Valor = Nothing
        Me.rbSaida.ValorChecado = Nothing
        Me.rbSaida.valorVazio = False
        '
        'rbEntrada
        '
        Me.rbEntrada.AutoSize = True
        Me.rbEntrada.Campo = ""
        Me.rbEntrada.ControlDB = Nothing
        Me.rbEntrada.Location = New System.Drawing.Point(24, 38)
        Me.rbEntrada.Name = "rbEntrada"
        Me.rbEntrada.Size = New System.Drawing.Size(62, 17)
        Me.rbEntrada.TabIndex = 3
        Me.rbEntrada.Text = "Entrada"
        Me.rbEntrada.UseVisualStyleBackColor = True
        Me.rbEntrada.Valor = Nothing
        Me.rbEntrada.ValorChecado = Nothing
        Me.rbEntrada.valorVazio = False
        '
        'rbPesagem2
        '
        Me.rbPesagem2.AutoSize = True
        Me.rbPesagem2.Campo = ""
        Me.rbPesagem2.ControlDB = Nothing
        Me.rbPesagem2.Location = New System.Drawing.Point(226, 15)
        Me.rbPesagem2.Name = "rbPesagem2"
        Me.rbPesagem2.Size = New System.Drawing.Size(82, 17)
        Me.rbPesagem2.TabIndex = 2
        Me.rbPesagem2.Text = "2° Pesagem"
        Me.rbPesagem2.UseVisualStyleBackColor = True
        Me.rbPesagem2.Valor = Nothing
        Me.rbPesagem2.ValorChecado = Nothing
        Me.rbPesagem2.valorVazio = False
        '
        'rbPesagem1
        '
        Me.rbPesagem1.AutoSize = True
        Me.rbPesagem1.Campo = ""
        Me.rbPesagem1.ControlDB = Nothing
        Me.rbPesagem1.Location = New System.Drawing.Point(110, 15)
        Me.rbPesagem1.Name = "rbPesagem1"
        Me.rbPesagem1.Size = New System.Drawing.Size(82, 17)
        Me.rbPesagem1.TabIndex = 1
        Me.rbPesagem1.Text = "1ª Pesagem"
        Me.rbPesagem1.UseVisualStyleBackColor = True
        Me.rbPesagem1.Valor = Nothing
        Me.rbPesagem1.ValorChecado = Nothing
        Me.rbPesagem1.valorVazio = False
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Campo = ""
        Me.rbTodos.Checked = True
        Me.rbTodos.ControlDB = Nothing
        Me.rbTodos.Location = New System.Drawing.Point(24, 15)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 0
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        Me.rbTodos.Valor = Nothing
        Me.rbTodos.ValorChecado = Nothing
        Me.rbTodos.valorVazio = False
        '
        'cbbVeiculo
        '
        Me.cbbVeiculo.AgrupadoPor = Nothing
        Me.cbbVeiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbVeiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbVeiculo.BackColor = System.Drawing.Color.White
        Me.cbbVeiculo.Campo = ""
        Me.cbbVeiculo.campoID = "ID"
        Me.cbbVeiculo.campoOrdem = Nothing
        Me.cbbVeiculo.campoRelacionamento = Nothing
        Me.cbbVeiculo.campoSelecionavel = "PLACA"
        Me.cbbVeiculo.campoSql = Nothing
        Me.cbbVeiculo.campoSqlID = Nothing
        Me.cbbVeiculo.carrega2Parametro = False
        Me.cbbVeiculo.carregaClick = True
        Me.cbbVeiculo.comDistinct = False
        Me.cbbVeiculo.ControlDB = Nothing
        Me.cbbVeiculo.DisplayMember = "Texto"
        Me.cbbVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbVeiculo.Filtro = Nothing
        Me.cbbVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbVeiculo.FormattingEnabled = True
        Me.cbbVeiculo.Location = New System.Drawing.Point(83, 27)
        Me.cbbVeiculo.Name = "cbbVeiculo"
        Me.cbbVeiculo.NomeCampoMsg = "Veiculo"
        Me.cbbVeiculo.Ordena = Nothing
        Me.cbbVeiculo.Requerido = False
        Me.cbbVeiculo.Size = New System.Drawing.Size(336, 21)
        Me.cbbVeiculo.TabelaRelacionamento = "TB_VEICULO"
        Me.cbbVeiculo.TabIndex = 1
        Me.cbbVeiculo.TextoSelecionar = "Todos os Veículos"
        Me.cbbVeiculo.Valor = Nothing
        Me.cbbVeiculo.ValorRelacionamento = Nothing
        Me.cbbVeiculo.ValorSelecionado = "-1"
        Me.cbbVeiculo.valorVazio = -1
        Me.cbbVeiculo.ValueMember = "Valor"
        '
        'FbLabel5
        '
        Me.FbLabel5.AutoSize = True
        Me.FbLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel5.Location = New System.Drawing.Point(33, 30)
        Me.FbLabel5.Name = "FbLabel5"
        Me.FbLabel5.Size = New System.Drawing.Size(47, 13)
        Me.FbLabel5.TabIndex = 294
        Me.FbLabel5.Text = "Veículo:"
        '
        'cbbTipo
        '
        Me.cbbTipo.AgrupadoPor = Nothing
        Me.cbbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbTipo.BackColor = System.Drawing.Color.White
        Me.cbbTipo.Campo = ""
        Me.cbbTipo.campoID = "ID"
        Me.cbbTipo.campoOrdem = Nothing
        Me.cbbTipo.campoRelacionamento = "TIPO"
        Me.cbbTipo.campoSelecionavel = "VALOR"
        Me.cbbTipo.campoSql = Nothing
        Me.cbbTipo.campoSqlID = Nothing
        Me.cbbTipo.carrega2Parametro = False
        Me.cbbTipo.carregaClick = True
        Me.cbbTipo.comDistinct = False
        Me.cbbTipo.ControlDB = Nothing
        Me.cbbTipo.DisplayMember = "Texto"
        Me.cbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTipo.Filtro = Nothing
        Me.cbbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbTipo.FormattingEnabled = True
        Me.cbbTipo.Location = New System.Drawing.Point(83, 3)
        Me.cbbTipo.Name = "cbbTipo"
        Me.cbbTipo.NomeCampoMsg = "Tipo"
        Me.cbbTipo.Ordena = Nothing
        Me.cbbTipo.Requerido = False
        Me.cbbTipo.Size = New System.Drawing.Size(336, 21)
        Me.cbbTipo.TabelaRelacionamento = "TB_PARAMETRO"
        Me.cbbTipo.TabIndex = 0
        Me.cbbTipo.TextoSelecionar = "Todos os Tipos"
        Me.cbbTipo.Valor = Nothing
        Me.cbbTipo.ValorRelacionamento = "TIPO_PORTARIA_ENTRADA"
        Me.cbbTipo.ValorSelecionado = "-1"
        Me.cbbTipo.valorVazio = -1
        Me.cbbTipo.ValueMember = "Valor"
        '
        'FbLabel13
        '
        Me.FbLabel13.AutoSize = True
        Me.FbLabel13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel13.Location = New System.Drawing.Point(49, 6)
        Me.FbLabel13.Name = "FbLabel13"
        Me.FbLabel13.Size = New System.Drawing.Size(31, 13)
        Me.FbLabel13.TabIndex = 292
        Me.FbLabel13.Text = "Tipo:"
        '
        'cbbDomicilio
        '
        Me.cbbDomicilio.AgrupadoPor = Nothing
        Me.cbbDomicilio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbDomicilio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbDomicilio.BackColor = System.Drawing.Color.White
        Me.cbbDomicilio.Campo = ""
        Me.cbbDomicilio.campoID = "ID"
        Me.cbbDomicilio.campoOrdem = Nothing
        Me.cbbDomicilio.campoRelacionamento = Nothing
        Me.cbbDomicilio.campoSelecionavel = "Nome"
        Me.cbbDomicilio.campoSql = Nothing
        Me.cbbDomicilio.campoSqlID = Nothing
        Me.cbbDomicilio.carrega2Parametro = False
        Me.cbbDomicilio.carregaClick = True
        Me.cbbDomicilio.comDistinct = False
        Me.cbbDomicilio.ControlDB = Nothing
        Me.cbbDomicilio.DisplayMember = "Texto"
        Me.cbbDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbDomicilio.Filtro = Nothing
        Me.cbbDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbDomicilio.FormattingEnabled = True
        Me.cbbDomicilio.Location = New System.Drawing.Point(83, 51)
        Me.cbbDomicilio.Name = "cbbDomicilio"
        Me.cbbDomicilio.NomeCampoMsg = "Domicilio"
        Me.cbbDomicilio.Ordena = Nothing
        Me.cbbDomicilio.Requerido = False
        Me.cbbDomicilio.Size = New System.Drawing.Size(336, 21)
        Me.cbbDomicilio.TabelaRelacionamento = "TB_DOMICILIO"
        Me.cbbDomicilio.TabIndex = 2
        Me.cbbDomicilio.TextoSelecionar = "Todos os Domicilios"
        Me.cbbDomicilio.Valor = Nothing
        Me.cbbDomicilio.ValorRelacionamento = Nothing
        Me.cbbDomicilio.ValorSelecionado = "-1"
        Me.cbbDomicilio.valorVazio = -1
        Me.cbbDomicilio.ValueMember = "Valor"
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel2.Location = New System.Drawing.Point(28, 54)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(52, 13)
        Me.FbLabel2.TabIndex = 299
        Me.FbLabel2.Text = "Domicilio:"
        '
        'cbbFuncionario
        '
        Me.cbbFuncionario.AgrupadoPor = Nothing
        Me.cbbFuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbFuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbFuncionario.BackColor = System.Drawing.Color.White
        Me.cbbFuncionario.Campo = ""
        Me.cbbFuncionario.campoID = "ID"
        Me.cbbFuncionario.campoOrdem = Nothing
        Me.cbbFuncionario.campoRelacionamento = "IDTipoPessoa"
        Me.cbbFuncionario.campoSelecionavel = "Nome"
        Me.cbbFuncionario.campoSql = Nothing
        Me.cbbFuncionario.campoSqlID = Nothing
        Me.cbbFuncionario.carrega2Parametro = False
        Me.cbbFuncionario.carregaClick = True
        Me.cbbFuncionario.comDistinct = False
        Me.cbbFuncionario.ControlDB = Nothing
        Me.cbbFuncionario.DisplayMember = "Texto"
        Me.cbbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbFuncionario.Filtro = Nothing
        Me.cbbFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbFuncionario.FormattingEnabled = True
        Me.cbbFuncionario.Location = New System.Drawing.Point(83, 75)
        Me.cbbFuncionario.Name = "cbbFuncionario"
        Me.cbbFuncionario.NomeCampoMsg = "Funcionario"
        Me.cbbFuncionario.Ordena = Nothing
        Me.cbbFuncionario.Requerido = False
        Me.cbbFuncionario.Size = New System.Drawing.Size(336, 21)
        Me.cbbFuncionario.TabelaRelacionamento = "TB_PESSOA"
        Me.cbbFuncionario.TabIndex = 3
        Me.cbbFuncionario.TextoSelecionar = "Todos os Funcionários"
        Me.cbbFuncionario.Valor = Nothing
        Me.cbbFuncionario.ValorRelacionamento = "71"
        Me.cbbFuncionario.ValorSelecionado = "-1"
        Me.cbbFuncionario.valorVazio = -1
        Me.cbbFuncionario.ValueMember = "Valor"
        '
        'FbLabel4
        '
        Me.FbLabel4.AutoSize = True
        Me.FbLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel4.Location = New System.Drawing.Point(15, 78)
        Me.FbLabel4.Name = "FbLabel4"
        Me.FbLabel4.Size = New System.Drawing.Size(65, 13)
        Me.FbLabel4.TabIndex = 303
        Me.FbLabel4.Text = "Funcionário:"
        '
        'frmRelPortaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(423, 237)
        Me.Controls.Add(Me.cbbFuncionario)
        Me.Controls.Add(Me.FbLabel4)
        Me.Controls.Add(Me.cbbDomicilio)
        Me.Controls.Add(Me.FbLabel2)
        Me.Controls.Add(Me.FbGroupBox3)
        Me.Controls.Add(Me.cbbVeiculo)
        Me.Controls.Add(Me.FbLabel5)
        Me.Controls.Add(Me.cbbTipo)
        Me.Controls.Add(Me.FbLabel13)
        Me.Controls.Add(Me.txtDataFim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtData)
        Me.Name = "frmRelPortaria"
        Me.Text = "Relatório de Portaria"
        Me.Controls.SetChildIndex(Me.txtData, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtDataFim, 0)
        Me.Controls.SetChildIndex(Me.FbLabel13, 0)
        Me.Controls.SetChildIndex(Me.cbbTipo, 0)
        Me.Controls.SetChildIndex(Me.FbLabel5, 0)
        Me.Controls.SetChildIndex(Me.cbbVeiculo, 0)
        Me.Controls.SetChildIndex(Me.FbGroupBox3, 0)
        Me.Controls.SetChildIndex(Me.FbLabel2, 0)
        Me.Controls.SetChildIndex(Me.cbbDomicilio, 0)
        Me.Controls.SetChildIndex(Me.FbLabel4, 0)
        Me.Controls.SetChildIndex(Me.cbbFuncionario, 0)
        Me.FbGroupBox3.ResumeLayout(False)
        Me.FbGroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDataFim As FeedAutomacao.fbDate
    Friend WithEvents Label3 As FeedAutomacao.fbLabel
    Friend WithEvents Label7 As FeedAutomacao.fbLabel
    Friend WithEvents txtData As FeedAutomacao.fbDate
    Friend WithEvents FbGroupBox3 As FeedAutomacao.fbGroupBox
    Friend WithEvents rbPesagem2 As FeedAutomacao.fbRadioButton
    Friend WithEvents rbPesagem1 As FeedAutomacao.fbRadioButton
    Friend WithEvents rbTodos As FeedAutomacao.fbRadioButton
    Friend WithEvents cbbVeiculo As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel5 As FeedAutomacao.fbLabel
    Friend WithEvents cbbTipo As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel13 As FeedAutomacao.fbLabel
    Friend WithEvents cbbDomicilio As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel2 As FeedAutomacao.fbLabel
    Friend WithEvents cbbFuncionario As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel4 As FeedAutomacao.fbLabel
    Friend WithEvents rbSaida As FeedAutomacao.fbRadioButton
    Friend WithEvents rbEntrada As FeedAutomacao.fbRadioButton
End Class
