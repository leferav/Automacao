<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGerenciaPortaria
    Inherits frmPadraoSeleciona

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGerenciaPortaria))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnInserir = New FeedAutomacao.fbButtonVisual()
        Me.btnEditar = New FeedAutomacao.fbButtonVisual()
        Me.btnExcluir = New FeedAutomacao.fbButtonVisual()
        Me.cbbTipo = New FeedAutomacao.fbComboBox()
        Me.FbLabel13 = New FeedAutomacao.fbLabel()
        Me.cbbVeiculo = New FeedAutomacao.fbComboBox()
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.FbGroupBox1 = New FeedAutomacao.fbGroupBox()
        Me.rbCancelado = New FeedAutomacao.fbRadioButton()
        Me.rbFaturado = New FeedAutomacao.fbRadioButton()
        Me.rbSolicitado = New FeedAutomacao.fbRadioButton()
        Me.rbAgendado = New FeedAutomacao.fbRadioButton()
        Me.rbLiberaBuscar = New FeedAutomacao.fbRadioButton()
        Me.rbOrdemPesagem = New FeedAutomacao.fbRadioButton()
        Me.rbLiberaPesagem = New FeedAutomacao.fbRadioButton()
        Me.rbSaida = New FeedAutomacao.fbRadioButton()
        Me.rbPesagem2 = New FeedAutomacao.fbRadioButton()
        Me.rbPesagem1 = New FeedAutomacao.fbRadioButton()
        Me.rbEntrada = New FeedAutomacao.fbRadioButton()
        Me.rbTodos = New FeedAutomacao.fbRadioButton()
        Me.btnPesar = New FeedAutomacao.fbButtonVisual()
        Me.btnSaida = New FeedAutomacao.fbButtonVisual()
        Me.btnVisGuia = New FeedAutomacao.fbButtonVisual()
        Me.menuPortaria = New FeedAutomacao.fbMenu()
        Me.FbPanel1 = New FeedAutomacao.fbPanel()
        Me.dgvGuia = New FeedAutomacao.fbGridview()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.dtDataInicial = New FeedAutomacao.fbDate()
        Me.fbLabel20 = New FeedAutomacao.fbLabel()
        Me.dtDataFinal = New FeedAutomacao.fbDate()
        Me.cbbDataFiltro = New System.Windows.Forms.ComboBox()
        Me.FbLabel3 = New FeedAutomacao.fbLabel()
        Me.FbLabel16 = New FeedAutomacao.fbLabel()
        Me.lkpProdutor = New FeedAutomacao.fbLookUp()
        Me.FbLabel4 = New FeedAutomacao.fbLabel()
        Me.txtGuia = New FeedAutomacao.fbTextBox()
        Me.FbButtonVisual1 = New FeedAutomacao.fbButtonVisual()
        Me.rbTipoEntrada = New FeedAutomacao.fbRadioButton()
        Me.rbAgendamento = New FeedAutomacao.fbRadioButton()
        Me.rbSolicitacao = New FeedAutomacao.fbRadioButton()
        Me.FbGroupBox2 = New FeedAutomacao.fbGroupBox()
        Me.rbTodosTipos = New FeedAutomacao.fbRadioButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdemPPesarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaturadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiberarPBuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelamentoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlCampos.SuspendLayout()
        Me.pnlAux.SuspendLayout()
        Me.pnlBarra.SuspendLayout()
        Me.menuFiltro.SuspendLayout()
        Me.FbGroupBox1.SuspendLayout()
        Me.menuPortaria.SuspendLayout()
        Me.FbPanel1.SuspendLayout()
        CType(Me.dgvGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FbGroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCampos
        '
        Me.pnlCampos.Location = New System.Drawing.Point(0, 162)
        Me.pnlCampos.Size = New System.Drawing.Size(864, 357)
        '
        'pnlAux
        '
        Me.pnlAux.Controls.Add(Me.menuPortaria)
        Me.pnlAux.Location = New System.Drawing.Point(0, 232)
        Me.pnlAux.Size = New System.Drawing.Size(864, 125)
        '
        'pnlBarra
        '
        Me.pnlBarra.Controls.Add(Me.FbButtonVisual1)
        Me.pnlBarra.Controls.Add(Me.btnVisGuia)
        Me.pnlBarra.Controls.Add(Me.btnSaida)
        Me.pnlBarra.Controls.Add(Me.btnPesar)
        Me.pnlBarra.Controls.Add(Me.btnEditar)
        Me.pnlBarra.Controls.Add(Me.btnExcluir)
        Me.pnlBarra.Controls.Add(Me.btnInserir)
        Me.pnlBarra.Location = New System.Drawing.Point(0, 540)
        Me.pnlBarra.Size = New System.Drawing.Size(864, 35)
        Me.pnlBarra.TabIndex = 1
        '
        'pnlStatus
        '
        Me.pnlStatus.Location = New System.Drawing.Point(0, 519)
        Me.pnlStatus.Size = New System.Drawing.Size(864, 21)
        '
        'menuFiltro
        '
        Me.menuFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.menuFiltro.Controls.Add(Me.FbGroupBox2)
        Me.menuFiltro.Controls.Add(Me.FbLabel4)
        Me.menuFiltro.Controls.Add(Me.FbLabel16)
        Me.menuFiltro.Controls.Add(Me.lkpProdutor)
        Me.menuFiltro.Controls.Add(Me.txtGuia)
        Me.menuFiltro.Controls.Add(Me.FbLabel3)
        Me.menuFiltro.Controls.Add(Me.cbbDataFiltro)
        Me.menuFiltro.Controls.Add(Me.fbLabel20)
        Me.menuFiltro.Controls.Add(Me.dtDataFinal)
        Me.menuFiltro.Controls.Add(Me.FbLabel2)
        Me.menuFiltro.Controls.Add(Me.dtDataInicial)
        Me.menuFiltro.Controls.Add(Me.FbGroupBox1)
        Me.menuFiltro.Controls.Add(Me.cbbVeiculo)
        Me.menuFiltro.Controls.Add(Me.cbbTipo)
        Me.menuFiltro.Controls.Add(Me.FbLabel13)
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(864, 162)
        Me.menuFiltro.TabIndex = 0
        Me.menuFiltro.Texto = "Filtrar - Gerenciamento de Portaria"
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel13, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.cbbTipo, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.cbbVeiculo, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbGroupBox1, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.dtDataInicial, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel2, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.dtDataFinal, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.fbLabel20, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.cbbDataFiltro, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel3, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtGuia, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.lkpProdutor, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel16, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel4, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbGroupBox2, 0)
        '
        'btnInserir
        '
        Me.btnInserir.BackColor = System.Drawing.Color.SteelBlue
        Me.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserir.ForeColor = System.Drawing.Color.White
        Me.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInserir.Location = New System.Drawing.Point(5, 3)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(96, 29)
        Me.btnInserir.TabIndex = 0
        Me.btnInserir.Text = "Novo (F5)"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(112, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(96, 29)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar (F6)"
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.SteelBlue
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Location = New System.Drawing.Point(219, 3)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(119, 29)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir (SF+F2)"
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
        Me.cbbTipo.Location = New System.Drawing.Point(46, 107)
        Me.cbbTipo.Name = "cbbTipo"
        Me.cbbTipo.NomeCampoMsg = "Tipo"
        Me.cbbTipo.Ordena = Nothing
        Me.cbbTipo.Requerido = False
        Me.cbbTipo.Size = New System.Drawing.Size(161, 21)
        Me.cbbTipo.TabelaRelacionamento = "TB_PARAMETRO"
        Me.cbbTipo.TabIndex = 2
        Me.cbbTipo.TextoSelecionar = "Selecione o Tipo"
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
        Me.FbLabel13.Location = New System.Drawing.Point(14, 111)
        Me.FbLabel13.Name = "FbLabel13"
        Me.FbLabel13.Size = New System.Drawing.Size(31, 13)
        Me.FbLabel13.TabIndex = 287
        Me.FbLabel13.Text = "Tipo:"
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
        Me.cbbVeiculo.Location = New System.Drawing.Point(355, 107)
        Me.cbbVeiculo.Name = "cbbVeiculo"
        Me.cbbVeiculo.NomeCampoMsg = "Veiculo"
        Me.cbbVeiculo.Ordena = Nothing
        Me.cbbVeiculo.Requerido = False
        Me.cbbVeiculo.Size = New System.Drawing.Size(154, 21)
        Me.cbbVeiculo.TabelaRelacionamento = "TB_VEICULO"
        Me.cbbVeiculo.TabIndex = 1
        Me.cbbVeiculo.TextoSelecionar = "Selecione o Veículo"
        Me.cbbVeiculo.Valor = Nothing
        Me.cbbVeiculo.ValorRelacionamento = Nothing
        Me.cbbVeiculo.ValorSelecionado = "-1"
        Me.cbbVeiculo.valorVazio = -1
        Me.cbbVeiculo.ValueMember = "Valor"
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel1.Location = New System.Drawing.Point(18, 132)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(47, 13)
        Me.FbLabel1.TabIndex = 289
        Me.FbLabel1.Text = "Veículo:"
        '
        'FbGroupBox1
        '
        Me.FbGroupBox1.Controls.Add(Me.rbCancelado)
        Me.FbGroupBox1.Controls.Add(Me.rbFaturado)
        Me.FbGroupBox1.Controls.Add(Me.rbSolicitado)
        Me.FbGroupBox1.Controls.Add(Me.rbAgendado)
        Me.FbGroupBox1.Controls.Add(Me.rbLiberaBuscar)
        Me.FbGroupBox1.Controls.Add(Me.rbOrdemPesagem)
        Me.FbGroupBox1.Controls.Add(Me.rbLiberaPesagem)
        Me.FbGroupBox1.Controls.Add(Me.rbSaida)
        Me.FbGroupBox1.Controls.Add(Me.rbPesagem2)
        Me.FbGroupBox1.Controls.Add(Me.rbPesagem1)
        Me.FbGroupBox1.Controls.Add(Me.rbEntrada)
        Me.FbGroupBox1.Controls.Add(Me.rbTodos)
        Me.FbGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FbGroupBox1.Location = New System.Drawing.Point(497, 25)
        Me.FbGroupBox1.Name = "FbGroupBox1"
        Me.FbGroupBox1.Size = New System.Drawing.Size(365, 112)
        Me.FbGroupBox1.TabIndex = 7
        Me.FbGroupBox1.TabStop = False
        Me.FbGroupBox1.Text = "Status"
        '
        'rbCancelado
        '
        Me.rbCancelado.AutoSize = True
        Me.rbCancelado.Campo = ""
        Me.rbCancelado.ControlDB = Nothing
        Me.rbCancelado.Location = New System.Drawing.Point(242, 91)
        Me.rbCancelado.Name = "rbCancelado"
        Me.rbCancelado.Size = New System.Drawing.Size(76, 17)
        Me.rbCancelado.TabIndex = 11
        Me.rbCancelado.Text = "Cancelado"
        Me.rbCancelado.UseVisualStyleBackColor = True
        Me.rbCancelado.Valor = Nothing
        Me.rbCancelado.ValorChecado = Nothing
        Me.rbCancelado.valorVazio = False
        '
        'rbFaturado
        '
        Me.rbFaturado.AutoSize = True
        Me.rbFaturado.Campo = ""
        Me.rbFaturado.ControlDB = Nothing
        Me.rbFaturado.Location = New System.Drawing.Point(154, 68)
        Me.rbFaturado.Name = "rbFaturado"
        Me.rbFaturado.Size = New System.Drawing.Size(67, 17)
        Me.rbFaturado.TabIndex = 10
        Me.rbFaturado.Text = "Faturado"
        Me.rbFaturado.UseVisualStyleBackColor = True
        Me.rbFaturado.Valor = Nothing
        Me.rbFaturado.ValorChecado = Nothing
        Me.rbFaturado.valorVazio = False
        '
        'rbSolicitado
        '
        Me.rbSolicitado.AutoSize = True
        Me.rbSolicitado.Campo = ""
        Me.rbSolicitado.ControlDB = Nothing
        Me.rbSolicitado.Location = New System.Drawing.Point(242, 46)
        Me.rbSolicitado.Name = "rbSolicitado"
        Me.rbSolicitado.Size = New System.Drawing.Size(71, 17)
        Me.rbSolicitado.TabIndex = 9
        Me.rbSolicitado.Text = "Solicitado"
        Me.rbSolicitado.UseVisualStyleBackColor = True
        Me.rbSolicitado.Valor = Nothing
        Me.rbSolicitado.ValorChecado = Nothing
        Me.rbSolicitado.valorVazio = False
        '
        'rbAgendado
        '
        Me.rbAgendado.AutoSize = True
        Me.rbAgendado.Campo = ""
        Me.rbAgendado.ControlDB = Nothing
        Me.rbAgendado.Location = New System.Drawing.Point(242, 23)
        Me.rbAgendado.Name = "rbAgendado"
        Me.rbAgendado.Size = New System.Drawing.Size(74, 17)
        Me.rbAgendado.TabIndex = 8
        Me.rbAgendado.Text = "Agendado"
        Me.rbAgendado.UseVisualStyleBackColor = True
        Me.rbAgendado.Valor = Nothing
        Me.rbAgendado.ValorChecado = Nothing
        Me.rbAgendado.valorVazio = False
        '
        'rbLiberaBuscar
        '
        Me.rbLiberaBuscar.AutoSize = True
        Me.rbLiberaBuscar.Campo = ""
        Me.rbLiberaBuscar.ControlDB = Nothing
        Me.rbLiberaBuscar.Location = New System.Drawing.Point(242, 69)
        Me.rbLiberaBuscar.Name = "rbLiberaBuscar"
        Me.rbLiberaBuscar.Size = New System.Drawing.Size(117, 17)
        Me.rbLiberaBuscar.TabIndex = 7
        Me.rbLiberaBuscar.Text = "Liberado P/ Buscar"
        Me.rbLiberaBuscar.UseVisualStyleBackColor = True
        Me.rbLiberaBuscar.Valor = Nothing
        Me.rbLiberaBuscar.ValorChecado = Nothing
        Me.rbLiberaBuscar.valorVazio = False
        '
        'rbOrdemPesagem
        '
        Me.rbOrdemPesagem.AutoSize = True
        Me.rbOrdemPesagem.Campo = ""
        Me.rbOrdemPesagem.ControlDB = Nothing
        Me.rbOrdemPesagem.Location = New System.Drawing.Point(20, 91)
        Me.rbOrdemPesagem.Name = "rbOrdemPesagem"
        Me.rbOrdemPesagem.Size = New System.Drawing.Size(118, 17)
        Me.rbOrdemPesagem.TabIndex = 6
        Me.rbOrdemPesagem.Text = "Ordem P/ Pesagem"
        Me.rbOrdemPesagem.UseVisualStyleBackColor = True
        Me.rbOrdemPesagem.Valor = Nothing
        Me.rbOrdemPesagem.ValorChecado = Nothing
        Me.rbOrdemPesagem.valorVazio = False
        '
        'rbLiberaPesagem
        '
        Me.rbLiberaPesagem.AutoSize = True
        Me.rbLiberaPesagem.Campo = ""
        Me.rbLiberaPesagem.ControlDB = Nothing
        Me.rbLiberaPesagem.Location = New System.Drawing.Point(20, 68)
        Me.rbLiberaPesagem.Name = "rbLiberaPesagem"
        Me.rbLiberaPesagem.Size = New System.Drawing.Size(128, 17)
        Me.rbLiberaPesagem.TabIndex = 5
        Me.rbLiberaPesagem.Text = "Liberado P/ Pesagem"
        Me.rbLiberaPesagem.UseVisualStyleBackColor = True
        Me.rbLiberaPesagem.Valor = Nothing
        Me.rbLiberaPesagem.ValorChecado = Nothing
        Me.rbLiberaPesagem.valorVazio = False
        '
        'rbSaida
        '
        Me.rbSaida.AutoSize = True
        Me.rbSaida.Campo = ""
        Me.rbSaida.ControlDB = Nothing
        Me.rbSaida.Location = New System.Drawing.Point(154, 91)
        Me.rbSaida.Name = "rbSaida"
        Me.rbSaida.Size = New System.Drawing.Size(46, 17)
        Me.rbSaida.TabIndex = 2
        Me.rbSaida.Text = "Saiu"
        Me.rbSaida.UseVisualStyleBackColor = True
        Me.rbSaida.Valor = Nothing
        Me.rbSaida.ValorChecado = Nothing
        Me.rbSaida.valorVazio = False
        '
        'rbPesagem2
        '
        Me.rbPesagem2.AutoSize = True
        Me.rbPesagem2.Campo = ""
        Me.rbPesagem2.ControlDB = Nothing
        Me.rbPesagem2.Location = New System.Drawing.Point(154, 45)
        Me.rbPesagem2.Name = "rbPesagem2"
        Me.rbPesagem2.Size = New System.Drawing.Size(82, 17)
        Me.rbPesagem2.TabIndex = 4
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
        Me.rbPesagem1.Location = New System.Drawing.Point(154, 23)
        Me.rbPesagem1.Name = "rbPesagem1"
        Me.rbPesagem1.Size = New System.Drawing.Size(82, 17)
        Me.rbPesagem1.TabIndex = 1
        Me.rbPesagem1.Text = "1ª Pesagem"
        Me.rbPesagem1.UseVisualStyleBackColor = True
        Me.rbPesagem1.Valor = Nothing
        Me.rbPesagem1.ValorChecado = Nothing
        Me.rbPesagem1.valorVazio = False
        '
        'rbEntrada
        '
        Me.rbEntrada.AutoSize = True
        Me.rbEntrada.Campo = ""
        Me.rbEntrada.ControlDB = Nothing
        Me.rbEntrada.Location = New System.Drawing.Point(20, 45)
        Me.rbEntrada.Name = "rbEntrada"
        Me.rbEntrada.Size = New System.Drawing.Size(56, 17)
        Me.rbEntrada.TabIndex = 3
        Me.rbEntrada.Text = "Entrou"
        Me.rbEntrada.UseVisualStyleBackColor = True
        Me.rbEntrada.Valor = Nothing
        Me.rbEntrada.ValorChecado = Nothing
        Me.rbEntrada.valorVazio = False
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Campo = ""
        Me.rbTodos.Checked = True
        Me.rbTodos.ControlDB = Nothing
        Me.rbTodos.Location = New System.Drawing.Point(20, 22)
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
        'btnPesar
        '
        Me.btnPesar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPesar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesar.ForeColor = System.Drawing.Color.White
        Me.btnPesar.Location = New System.Drawing.Point(349, 3)
        Me.btnPesar.Name = "btnPesar"
        Me.btnPesar.Size = New System.Drawing.Size(90, 29)
        Me.btnPesar.TabIndex = 3
        Me.btnPesar.Text = "Pesar (F8)"
        '
        'btnSaida
        '
        Me.btnSaida.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSaida.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaida.ForeColor = System.Drawing.Color.White
        Me.btnSaida.Location = New System.Drawing.Point(450, 3)
        Me.btnSaida.Name = "btnSaida"
        Me.btnSaida.Size = New System.Drawing.Size(100, 29)
        Me.btnSaida.TabIndex = 4
        Me.btnSaida.Text = "Saida (F10)"
        '
        'btnVisGuia
        '
        Me.btnVisGuia.BackColor = System.Drawing.Color.SteelBlue
        Me.btnVisGuia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVisGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisGuia.ForeColor = System.Drawing.Color.White
        Me.btnVisGuia.Location = New System.Drawing.Point(561, 3)
        Me.btnVisGuia.Name = "btnVisGuia"
        Me.btnVisGuia.Size = New System.Drawing.Size(104, 29)
        Me.btnVisGuia.TabIndex = 5
        Me.btnVisGuia.Text = "Vis. GS (F11)"
        '
        'menuPortaria
        '
        Me.menuPortaria.BackColor = System.Drawing.Color.WhiteSmoke
        Me.menuPortaria.Controls.Add(Me.FbPanel1)
        Me.menuPortaria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.menuPortaria.Fechar = True
        Me.menuPortaria.Hint = ""
        Me.menuPortaria.Icone = Nothing
        Me.menuPortaria.Location = New System.Drawing.Point(0, 0)
        Me.menuPortaria.Name = "menuPortaria"
        Me.menuPortaria.Size = New System.Drawing.Size(864, 125)
        Me.menuPortaria.TabIndex = 0
        Me.menuPortaria.Texto = "Guia de Saída"
        '
        'FbPanel1
        '
        Me.FbPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FbPanel1.Controls.Add(Me.dgvGuia)
        Me.FbPanel1.Location = New System.Drawing.Point(3, 26)
        Me.FbPanel1.Name = "FbPanel1"
        Me.FbPanel1.Size = New System.Drawing.Size(858, 96)
        Me.FbPanel1.TabIndex = 4
        '
        'dgvGuia
        '
        Me.dgvGuia.AllowUserToAddRows = False
        Me.dgvGuia.AllowUserToDeleteRows = False
        Me.dgvGuia.AllowUserToResizeRows = False
        Me.dgvGuia.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvGuia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGuia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGuia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuia.colunaID = "ID"
        Me.dgvGuia.ColunaSeleciona = False
        Me.dgvGuia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGuia.idSel = -1
        Me.dgvGuia.Location = New System.Drawing.Point(0, 0)
        Me.dgvGuia.MultiSelect = False
        Me.dgvGuia.Name = "dgvGuia"
        Me.dgvGuia.ReadOnly = True
        Me.dgvGuia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvGuia.RowHeadersVisible = False
        Me.dgvGuia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGuia.Size = New System.Drawing.Size(858, 96)
        Me.dgvGuia.TabIndex = 0
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel2.Location = New System.Drawing.Point(177, 75)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(24, 13)
        Me.FbLabel2.TabIndex = 307
        Me.FbLabel2.Text = "De:"
        '
        'dtDataInicial
        '
        Me.dtDataInicial.BackColor = System.Drawing.Color.White
        Me.dtDataInicial.ControlDB = Nothing
        Me.dtDataInicial.CustomFormat = "dd/MM/yyyy "
        Me.dtDataInicial.DataAtual = True
        Me.dtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDataInicial.Location = New System.Drawing.Point(202, 71)
        Me.dtDataInicial.Name = "dtDataInicial"
        Me.dtDataInicial.NomeCampoMsg = "dtDataInicial"
        Me.dtDataInicial.Requerido = False
        Me.dtDataInicial.ShowCheckBox = True
        Me.dtDataInicial.Size = New System.Drawing.Size(99, 20)
        Me.dtDataInicial.TabIndex = 5
        Me.dtDataInicial.Value = New Date(2012, 8, 2, 0, 0, 0, 0)
        '
        'fbLabel20
        '
        Me.fbLabel20.AutoSize = True
        Me.fbLabel20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fbLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fbLabel20.Location = New System.Drawing.Point(322, 75)
        Me.fbLabel20.Name = "fbLabel20"
        Me.fbLabel20.Size = New System.Drawing.Size(26, 13)
        Me.fbLabel20.TabIndex = 309
        Me.fbLabel20.Text = "Até:"
        '
        'dtDataFinal
        '
        Me.dtDataFinal.BackColor = System.Drawing.Color.White
        Me.dtDataFinal.ControlDB = Nothing
        Me.dtDataFinal.CustomFormat = "dd/MM/yyyy "
        Me.dtDataFinal.DataAtual = True
        Me.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDataFinal.Location = New System.Drawing.Point(350, 71)
        Me.dtDataFinal.Name = "dtDataFinal"
        Me.dtDataFinal.NomeCampoMsg = "dtDataFinal"
        Me.dtDataFinal.Requerido = False
        Me.dtDataFinal.ShowCheckBox = True
        Me.dtDataFinal.Size = New System.Drawing.Size(99, 20)
        Me.dtDataFinal.TabIndex = 6
        Me.dtDataFinal.Value = New Date(2012, 8, 2, 0, 0, 0, 0)
        '
        'cbbDataFiltro
        '
        Me.cbbDataFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbDataFiltro.FormattingEnabled = True
        Me.cbbDataFiltro.Items.AddRange(New Object() {"Entrada", "1ª Pesagem", "2ª Pesagem", "Saída"})
        Me.cbbDataFiltro.Location = New System.Drawing.Point(67, 71)
        Me.cbbDataFiltro.Name = "cbbDataFiltro"
        Me.cbbDataFiltro.Size = New System.Drawing.Size(100, 21)
        Me.cbbDataFiltro.TabIndex = 4
        Me.cbbDataFiltro.Text = "Entrada"
        '
        'FbLabel3
        '
        Me.FbLabel3.AutoSize = True
        Me.FbLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel3.Location = New System.Drawing.Point(14, 75)
        Me.FbLabel3.Name = "FbLabel3"
        Me.FbLabel3.Size = New System.Drawing.Size(52, 13)
        Me.FbLabel3.TabIndex = 311
        Me.FbLabel3.Text = "Data Por:"
        '
        'FbLabel16
        '
        Me.FbLabel16.AutoSize = True
        Me.FbLabel16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel16.Location = New System.Drawing.Point(11, 42)
        Me.FbLabel16.Name = "FbLabel16"
        Me.FbLabel16.Size = New System.Drawing.Size(54, 13)
        Me.FbLabel16.TabIndex = 313
        Me.FbLabel16.Text = "Domicílio:"
        '
        'lkpProdutor
        '
        Me.lkpProdutor.ControlDB = Nothing
        Me.lkpProdutor.DataTableSelect = Nothing
        Me.lkpProdutor.FormularioPesquisa = Nothing
        Me.lkpProdutor.LimpaTexto = True
        Me.lkpProdutor.Location = New System.Drawing.Point(67, 39)
        Me.lkpProdutor.Name = "lkpProdutor"
        Me.lkpProdutor.NomeCampoMsg = "fbLookUp"
        Me.lkpProdutor.Requerido = False
        Me.lkpProdutor.SelectID = -1
        Me.lkpProdutor.Size = New System.Drawing.Size(382, 20)
        Me.lkpProdutor.TabIndex = 0
        '
        'FbLabel4
        '
        Me.FbLabel4.AutoSize = True
        Me.FbLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel4.Location = New System.Drawing.Point(209, 111)
        Me.FbLabel4.Name = "FbLabel4"
        Me.FbLabel4.Size = New System.Drawing.Size(32, 13)
        Me.FbLabel4.TabIndex = 315
        Me.FbLabel4.Text = "Guia:"
        '
        'txtGuia
        '
        Me.txtGuia.BackColor = System.Drawing.Color.White
        Me.txtGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuia.botaoClear = False
        Me.txtGuia.Campo = ""
        Me.txtGuia.CaracterTipo = "U"
        Me.txtGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuia.ControlDB = Nothing
        Me.txtGuia.Enabled = False
        Me.txtGuia.Location = New System.Drawing.Point(243, 107)
        Me.txtGuia.Name = "txtGuia"
        Me.txtGuia.NomeCampoMsg = "Guia"
        Me.txtGuia.Requerido = False
        Me.txtGuia.Size = New System.Drawing.Size(95, 20)
        Me.txtGuia.TabIndex = 3
        Me.txtGuia.Valor = Nothing
        Me.txtGuia.valorVazio = ""
        '
        'FbButtonVisual1
        '
        Me.FbButtonVisual1.BackColor = System.Drawing.Color.DarkCyan
        Me.FbButtonVisual1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FbButtonVisual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FbButtonVisual1.ForeColor = System.Drawing.Color.White
        Me.FbButtonVisual1.Location = New System.Drawing.Point(700, 3)
        Me.FbButtonVisual1.Name = "FbButtonVisual1"
        Me.FbButtonVisual1.Size = New System.Drawing.Size(161, 29)
        Me.FbButtonVisual1.TabIndex = 6
        Me.FbButtonVisual1.Text = "Relatório Controle Portaria"
        '
        'rbTipoEntrada
        '
        Me.rbTipoEntrada.AutoSize = True
        Me.rbTipoEntrada.Campo = ""
        Me.rbTipoEntrada.ControlDB = Nothing
        Me.rbTipoEntrada.Location = New System.Drawing.Point(11, 40)
        Me.rbTipoEntrada.Name = "rbTipoEntrada"
        Me.rbTipoEntrada.Size = New System.Drawing.Size(62, 17)
        Me.rbTipoEntrada.TabIndex = 1
        Me.rbTipoEntrada.Text = "Entrada"
        Me.rbTipoEntrada.UseVisualStyleBackColor = True
        Me.rbTipoEntrada.Valor = Nothing
        Me.rbTipoEntrada.ValorChecado = Nothing
        Me.rbTipoEntrada.valorVazio = False
        '
        'rbAgendamento
        '
        Me.rbAgendamento.AutoSize = True
        Me.rbAgendamento.Campo = ""
        Me.rbAgendamento.ControlDB = Nothing
        Me.rbAgendamento.Location = New System.Drawing.Point(11, 63)
        Me.rbAgendamento.Name = "rbAgendamento"
        Me.rbAgendamento.Size = New System.Drawing.Size(91, 17)
        Me.rbAgendamento.TabIndex = 2
        Me.rbAgendamento.Text = "Agendamento"
        Me.rbAgendamento.UseVisualStyleBackColor = True
        Me.rbAgendamento.Valor = Nothing
        Me.rbAgendamento.ValorChecado = Nothing
        Me.rbAgendamento.valorVazio = False
        '
        'rbSolicitacao
        '
        Me.rbSolicitacao.AutoSize = True
        Me.rbSolicitacao.Campo = ""
        Me.rbSolicitacao.ControlDB = Nothing
        Me.rbSolicitacao.Location = New System.Drawing.Point(11, 86)
        Me.rbSolicitacao.Name = "rbSolicitacao"
        Me.rbSolicitacao.Size = New System.Drawing.Size(77, 17)
        Me.rbSolicitacao.TabIndex = 3
        Me.rbSolicitacao.Text = "Solicitação"
        Me.rbSolicitacao.UseVisualStyleBackColor = True
        Me.rbSolicitacao.Valor = Nothing
        Me.rbSolicitacao.ValorChecado = Nothing
        Me.rbSolicitacao.valorVazio = False
        '
        'FbGroupBox2
        '
        Me.FbGroupBox2.Controls.Add(Me.rbSolicitacao)
        Me.FbGroupBox2.Controls.Add(Me.rbAgendamento)
        Me.FbGroupBox2.Controls.Add(Me.rbTipoEntrada)
        Me.FbGroupBox2.Controls.Add(Me.rbTodosTipos)
        Me.FbGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.FbGroupBox2.Location = New System.Drawing.Point(390, 25)
        Me.FbGroupBox2.Name = "FbGroupBox2"
        Me.FbGroupBox2.Size = New System.Drawing.Size(107, 112)
        Me.FbGroupBox2.TabIndex = 8
        Me.FbGroupBox2.TabStop = False
        Me.FbGroupBox2.Text = "Tipo Portaria"
        '
        'rbTodosTipos
        '
        Me.rbTodosTipos.AutoSize = True
        Me.rbTodosTipos.Campo = ""
        Me.rbTodosTipos.Checked = True
        Me.rbTodosTipos.ControlDB = Nothing
        Me.rbTodosTipos.Location = New System.Drawing.Point(11, 17)
        Me.rbTodosTipos.Name = "rbTodosTipos"
        Me.rbTodosTipos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodosTipos.TabIndex = 0
        Me.rbTodosTipos.TabStop = True
        Me.rbTodosTipos.Text = "Todos"
        Me.rbTodosTipos.UseVisualStyleBackColor = True
        Me.rbTodosTipos.Valor = Nothing
        Me.rbTodosTipos.ValorChecado = Nothing
        Me.rbTodosTipos.valorVazio = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradaToolStripMenuItem, Me.OrdemPPesarToolStripMenuItem, Me.FaturadoToolStripMenuItem, Me.SaidaToolStripMenuItem, Me.LiberarPBuscarToolStripMenuItem, Me.CancelamentoToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 136)
        '
        'EntradaToolStripMenuItem
        '
        Me.EntradaToolStripMenuItem.Name = "EntradaToolStripMenuItem"
        Me.EntradaToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.EntradaToolStripMenuItem.Text = "Entrada"
        '
        'OrdemPPesarToolStripMenuItem
        '
        Me.OrdemPPesarToolStripMenuItem.Name = "OrdemPPesarToolStripMenuItem"
        Me.OrdemPPesarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.OrdemPPesarToolStripMenuItem.Text = "Ordem P/ Pesar"
        '
        'FaturadoToolStripMenuItem
        '
        Me.FaturadoToolStripMenuItem.Name = "FaturadoToolStripMenuItem"
        Me.FaturadoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.FaturadoToolStripMenuItem.Text = "Faturado"
        '
        'SaidaToolStripMenuItem
        '
        Me.SaidaToolStripMenuItem.Name = "SaidaToolStripMenuItem"
        Me.SaidaToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SaidaToolStripMenuItem.Text = "Saída"
        '
        'LiberarPBuscarToolStripMenuItem
        '
        Me.LiberarPBuscarToolStripMenuItem.Name = "LiberarPBuscarToolStripMenuItem"
        Me.LiberarPBuscarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LiberarPBuscarToolStripMenuItem.Text = "Liberar P/ Buscar"
        '
        'CancelamentoToolStripMenuItem1
        '
        Me.CancelamentoToolStripMenuItem1.Name = "CancelamentoToolStripMenuItem1"
        Me.CancelamentoToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.CancelamentoToolStripMenuItem1.Text = "Cancelamento"
        '
        'frmGerenciaPortaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 575)
        Me.controlPesquisa = Me.cbbVeiculo
        Me.Name = "frmGerenciaPortaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "2.1.Gerência de Portaria"
        Me.veMenuFiltro = True
        Me.Controls.SetChildIndex(Me.pnlBarra, 0)
        Me.Controls.SetChildIndex(Me.menuFiltro, 0)
        Me.Controls.SetChildIndex(Me.pnlStatus, 0)
        Me.Controls.SetChildIndex(Me.pnlCampos, 0)
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlAux.ResumeLayout(False)
        Me.pnlBarra.ResumeLayout(False)
        Me.menuFiltro.ResumeLayout(False)
        Me.menuFiltro.PerformLayout()
        Me.FbGroupBox1.ResumeLayout(False)
        Me.FbGroupBox1.PerformLayout()
        Me.menuPortaria.ResumeLayout(False)
        Me.FbPanel1.ResumeLayout(False)
        CType(Me.dgvGuia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FbGroupBox2.ResumeLayout(False)
        Me.FbGroupBox2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInserir As FeedAutomacao.fbButtonVisual
    Friend WithEvents btnEditar As FeedAutomacao.fbButtonVisual
    Friend WithEvents btnExcluir As FeedAutomacao.fbButtonVisual
    Friend WithEvents cbbTipo As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel13 As FeedAutomacao.fbLabel
    Friend WithEvents FbGroupBox1 As FeedAutomacao.fbGroupBox
    Friend WithEvents rbEntrada As FeedAutomacao.fbRadioButton
    Friend WithEvents rbTodos As FeedAutomacao.fbRadioButton
    Friend WithEvents cbbVeiculo As FeedAutomacao.fbComboBox
    Friend WithEvents FbLabel1 As FeedAutomacao.fbLabel
    Friend WithEvents rbPesagem2 As FeedAutomacao.fbRadioButton
    Friend WithEvents rbPesagem1 As FeedAutomacao.fbRadioButton
    Friend WithEvents rbSaida As FeedAutomacao.fbRadioButton
    Friend WithEvents btnPesar As FeedAutomacao.fbButtonVisual
    Friend WithEvents btnSaida As FeedAutomacao.fbButtonVisual
    Friend WithEvents btnVisGuia As FeedAutomacao.fbButtonVisual
    Friend WithEvents menuPortaria As FeedAutomacao.fbMenu
    Friend WithEvents FbPanel1 As FeedAutomacao.fbPanel
    Friend WithEvents dgvGuia As FeedAutomacao.fbGridview
    Friend WithEvents FbLabel2 As FeedAutomacao.fbLabel
    Friend WithEvents dtDataInicial As FeedAutomacao.fbDate
    Friend WithEvents fbLabel20 As FeedAutomacao.fbLabel
    Friend WithEvents dtDataFinal As FeedAutomacao.fbDate
    Friend WithEvents cbbDataFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents FbLabel3 As FeedAutomacao.fbLabel
    Friend WithEvents FbLabel16 As FeedAutomacao.fbLabel
    Friend WithEvents lkpProdutor As FeedAutomacao.fbLookUp
    Friend WithEvents FbLabel4 As FeedAutomacao.fbLabel
    Friend WithEvents txtGuia As FeedAutomacao.fbTextBox
    Friend WithEvents FbButtonVisual1 As FeedAutomacao.fbButtonVisual
    Friend WithEvents rbLiberaBuscar As fbRadioButton
    Friend WithEvents rbOrdemPesagem As fbRadioButton
    Friend WithEvents rbLiberaPesagem As fbRadioButton
    Friend WithEvents FbGroupBox2 As fbGroupBox
    Friend WithEvents rbSolicitacao As fbRadioButton
    Friend WithEvents rbAgendamento As fbRadioButton
    Friend WithEvents rbTipoEntrada As fbRadioButton
    Friend WithEvents rbTodosTipos As fbRadioButton
    Friend WithEvents rbSolicitado As fbRadioButton
    Friend WithEvents rbAgendado As fbRadioButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdemPPesarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaturadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rbCancelado As fbRadioButton
    Friend WithEvents rbFaturado As fbRadioButton
    Friend WithEvents LiberarPBuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelamentoToolStripMenuItem1 As ToolStripMenuItem
End Class
