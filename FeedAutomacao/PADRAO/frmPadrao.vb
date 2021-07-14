Imports System.IO
Imports System.Reflection
Imports Microsoft.Azure.Storage
Imports Microsoft.Azure.Storage.Blob


Public Class frmPadrao
    Dim _usuario As String = ""
    Dim _emp As String = ""
    Dim _IDUsuario As Integer = -1
    Dim _fun As String = ""
    Dim _IDUsuarioPessoa As Integer = -1
    Dim _IDEmp As Integer = -1
    Dim _perm As New clPermissao
    Dim _Lperm As New List(Of clPermissao)
    Dim _dtZim As Date

    Public Property volumeComQuebra As Boolean = False
    Public Property volumeSomenteInt As Boolean = False
    Public Property fat2Tabela As Boolean = False

    Public Property EditarTiket As Boolean = False
    Public Property ModeloImpTiketClassificacao As Boolean = False
    Public Property ImpressaoTiketClassificacao As Boolean = False
    Public Property ImprimeTiket2 As Boolean = False
    Public Property preContratoCompra As Boolean = False
    Public Property veTodasQuadras As Boolean = True
    Public Property IDUsuarioSupremo As Integer = -1
    Public Property IDDomicilioEmpresa As Integer = -1
    Public Property Tiket2Via As Boolean = False
    Public Property arrendondarPeso As Boolean = False
    Public Property controleSacariaAuto As Boolean = False
    Public Property tipoClassicaoGrid As Boolean = False
    Public Property VOLUME_HABILITADO As Boolean = True
    Public Property CodFilial As String = ""
    Public Property Class_Safra As Boolean = True
    Public Property Class_LotePadrao As Boolean = True
    Public Property Class_Padrao As Boolean = True
    Public Property Class_Arm_Amostra As Boolean = True
    Public Property Class_Umidade As Boolean = True
    Public Property Class_Loc_Amostra As Boolean = True
    Public Property TradingOfertaZerado As Boolean = False
    Public Property TradingLoteMaiorZero As Boolean = False
    Public Property liberaLoteCompleto As Boolean = False
    Public Property LIBERA_TRADING As Boolean = False
    Public Property VEFROTA As Boolean = False
    Public Property ObrigatorioNFBal As Boolean = False
    Public Property imprimeTiketSimples As Boolean = False
    Public Property travaSISTEMA_INS_EDIT As Boolean = False
    Public Property DadosEMP As String = ""
    Public Property TravaNumeroGuia As Boolean = False
    Public Property NFObrigatoriaTiket As Boolean = False
    Public Property travaEntradaFsical As Boolean = False
    Public Property GeraArquivoExportLote As Boolean = False
    Public Property NFMultiplasTransf As Boolean = False
    Public Property ImpressaContratoGrano As Integer = 0
    Public Property IMPRIMEGSBASE2VELOSO As Boolean = False
    Public Property IMPRIMEGSBXBASE2VELOSO As Boolean = False
    Public Property imprimeDocGuiaTextoBase2Veloso As Boolean = False
    Public Property IMPRIMEGSINICIALVERTICALBASE2F7 As Boolean = False
    Public Property imprimeGuiaEntradaVelosoBase2F3 As Boolean = False
    Public Property MostraVolumeRelFat As Boolean = True
    Public Property pclink As Boolean = False
    Public Property caminho_pclink As String = ""
    Public Property comando_pclink As String = ""
    Public Property IDTransportadora As Integer = -1
    Public Property GS_QtdZerada As Boolean = False
    Public Property PESO_SACA As Double = 60.0
    Public Property desdobraSEMQTD As Boolean = False
    Public Property ContratoSemPre As Boolean = False
    Public Property ImpressaoTiket2 As Boolean = False
    Public Property ImprimeGSIniTexto As Boolean = False
    Public Property ImprimeGSIniTexto2 As Boolean = False
    Public Property ImprimeGSFimTexto As Boolean = False
    Public Property imprimeGSBXMatricial2 As Boolean = False
    Public Property imprimeGRMatricial2 As Boolean = False
    Public Property ImprimeGRTexto As Boolean = False
    Public Property imprimeGSBXTexto2 As Boolean = False
    Public Property imprimeGTTexto As Boolean = False
    Public Property CobraAdcNoturno As Boolean = False
    Public Property IDTIPOPRODUTOR As Integer = -1
    Public Property IDTIPOGERAL As Integer = -1
    Public Property IDTipoConf As Integer = -1
    Public Property CertificadoDomicilioAutomatico As Boolean
    Public Property TamanhoRelatorio As Integer = 100
    Public Property ImprimeGuiaDePreenchimentoSaida As Boolean = False
    Public Property ImprimeGRTextoBal As Boolean = False
    Public Property InsereEntradasNaAmostra As Boolean = False
    Public Property RemocaoMultipla As Boolean = False
    Public Property TipoReserva As Integer = -1
    Public Property TiketModeloAuma As Boolean = False

    Public Property validaPesoSaida As Boolean = False

    Public Property senhaControladoria As String = ""

    Public Property TipoContratoJuridico As Integer
    Public Property ImprimeContratoAcessoriaSoma As Boolean




    '<System.ComponentModel.Category("FeedBack")> _
    'Public Property DATA_SERVER() As Date
    '    Get
    '        Return _dtZim
    '    End Get
    '    Set(ByVal value As Date)
    '        _dtZim = value
    '        travaSistema()
    '    End Set
    'End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property dataFat As Date

    <System.ComponentModel.Category("FeedBack")>
    Public Property IDUsuario() As Integer
        Get
            Return _IDUsuario
        End Get
        Set(ByVal value As Integer)
            _IDUsuario = value
        End Set
    End Property

    '<System.ComponentModel.Category("FeedBack")> _
    'Public Property IDUsuario() As Integer
    '    Get
    '        Return _IDUsuario
    '    End Get
    '    Set(ByVal value As Integer)
    '        _IDUsuario = value
    '        If _IDUsuario <> -1 Then
    '            setaPer()
    '        End If
    '    End Set
    'End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property IDUsuarioPessoa() As Integer
        Get
            Return _IDUsuarioPessoa
        End Get
        Set(ByVal value As Integer)
            _IDUsuarioPessoa = value
            If _IDUsuarioPessoa <> -1 Then
                Dim dt = fbConnection.executaSelect("SELECT Nome FROM TB_PESSOA WHERE ID = " + _IDUsuarioPessoa.ToString())
                If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                    _fun = dt.Rows(0).Item(0)
                End If
            End If
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property travaFeedBack As Boolean = False

    Public Property LogoEmpresaByte As Byte() = Nothing

    <System.ComponentModel.Category("FeedBack")> _
    Public Property IDEmpresa() As Integer
        Get
            Return _IDEmp
        End Get
        Set(ByVal value As Integer)
            _IDEmp = value
            If _IDEmp <> -1 Then
                Dim dt = fbConnection.executaSelect("SELECT Nome, Imagem, IDGrupo,ISNULL(FeedFisOK,0)," + _
                                                                    " ISNULL(codExterno,'') as CodigoFilial,  " + _
                                                                    " ISNULL(travaFeedBack,0) as travaFeedBack  " + _
                                                                    " FROM TB_EMPRESA WHERE ID = " + _IDEmp.ToString())
                If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                    _emp = dt.Rows(0).Item(0)
                    _retIDGrupo = dt.Rows(0).Item(2)
                    _efiscal = dt.Rows(0).Item(3)
                    If Not IsDBNull(dt.Rows(0).Item(1)) Then
                        LogoEmpresaByte = dt.Rows(0).Item(1)
                        Dim stmBLOBData As New MemoryStream(LogoEmpresaByte, True)
                        If stmBLOBData IsNot Nothing Then
                            _retImg = Image.FromStream(stmBLOBData)
                        Else
                            _retImg = Nothing
                        End If
                    End If
                    CodFilial = dt.Rows(0).Item("CodigoFilial")
                    travaFeedBack = dt.Rows(0).Item("travaFeedBack")
                End If
            End If
        End Set
    End Property

    Dim _retIDGrupo As Integer = -1
    Public ReadOnly Property IDGrupoEmpresa() As Integer
        Get
            Return _retIDGrupo
        End Get
    End Property

    Dim _efiscal As Boolean = False
    Public ReadOnly Property eFiscal() As Boolean
        Get
            Return _efiscal
        End Get
    End Property

    Dim _retImg As Image = Nothing
    Public ReadOnly Property ImageEmp() As Image
        Get
            Return _retImg
        End Get
    End Property

    Public ReadOnly Property NomeEmpresa() As String
        Get
            Return _emp
        End Get
    End Property

    Public ReadOnly Property NomeFuncionario() As String
        Get
            Return _fun
        End Get
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property Permissao() As clPermissao
        Get
            Return _perm
        End Get
        Set(ByVal value As clPermissao)
            _perm = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property listPermissao() As List(Of clPermissao)
        Get
            Return _Lperm
        End Get
        Set(ByVal value As List(Of clPermissao))
            _Lperm = value
        End Set
    End Property

    Dim _truncar As Boolean
    Public Property TruncarVol() As Boolean
        Get
            Return _truncar
        End Get
        Set(ByVal value As Boolean)
            _truncar = value
        End Set
    End Property

    Dim _arredondaPeso As Boolean
    Public Property arredonadaPeso() As Boolean
        Get
            Return _arredondaPeso
        End Get
        Set(ByVal value As Boolean)
            _arredondaPeso = value
        End Set
    End Property

    Dim _contratoAutomatico As Boolean
    Public Property contratoAutomatico() As Boolean
        Get
            Return _contratoAutomatico
        End Get
        Set(ByVal value As Boolean)
            _contratoAutomatico = value
        End Set
    End Property

    Dim _pesoTiket As Double = 0
    Public Property pesoTiketDivide() As Double
        Get
            Return _pesoTiket
        End Get
        Set(ByVal value As Double)
            _pesoTiket = value
        End Set
    End Property

    Dim _valorEmabalagemTiket As Double = 0
    Public Property valorEmbalagemTiketDivide() As Double
        Get
            Return _valorEmabalagemTiket
        End Get
        Set(ByVal value As Double)
            _valorEmabalagemTiket = value
        End Set
    End Property

    Dim _IDUsuarioTipo As Integer = -1
    <System.ComponentModel.Category("FeedBack")> _
    Public Property IDUsuarioTipo() As Integer
        Get
            Return _IDUsuarioTipo
        End Get
        Set(ByVal value As Integer)
            _IDUsuarioTipo = value
        End Set
    End Property

    Public Function retornaLogoFeed() As Byte()
        Dim ms As MemoryStream = New MemoryStream()
        My.Resources.feed.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
        Dim bytBLOBData(ms.Length - 1) As Byte
        ms.Position = 0
        ms.Read(bytBLOBData, 0, ms.Length)

        Return bytBLOBData
    End Function

    'Public Sub setaPer()
    '    Dim dr As New dtsMenuPerTableAdapters.retornaDadosPermissaoTableAdapter
    '    Dim dt = dr.GetData(Me.IDEmpresa, -1, Me.IDUsuario, 4)
    '    If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
    '        setaListaPer(dt)
    '    Else
    '        dt = dr.GetData(Me.IDEmpresa, Me.IDUsuarioTipo, -1, 4)
    '        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
    '            setaListaPer(dt)
    '        End If
    '    End If
    'End Sub

    'Private Sub setaListaPer(ByVal tabela As dtsMenuPer.retornaDadosPermissaoDataTable)
    '    _Lperm.Clear()
    '    For Each dt As dtsMenuPer.retornaDadosPermissaoRow In tabela.Rows
    '        Dim per As New clPermissao
    '        per.Edita = dt.Editar
    '        per.Exclui = dt.Excluir
    '        per.Insere = dt.Inserir
    '        per.Navega = dt.Navegar
    '        per.Visualiza = dt.Visualizar
    '        per.Menu = dt.Iniciar
    '        per.Tela = dt.nomeForm
    '        per.Atalho = dt.Atalho
    '        per.Objeto = dt.Objeto
    '        _Lperm.Add(per)
    '    Next
    'End Sub

    Private Function setaItem(ByVal item As String) As Boolean
        If item = "S" Then
            Return True
        ElseIf item = "N" Then
            Return False
        End If
    End Function

    'Private Function setaTabela(ByVal item As Integer) As String
    '    Dim s As String = "#"
    '    Dim drT As New dtsGeralGTableAdapters.TB_TELATableAdapter
    '    Dim dt = drT.GetDataByID(item)
    '    If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
    '        s = dt.Rows(0).Item(1) + "#" + dt.Rows(0).Item(2)
    '    End If
    '    Return s
    'End Function

    Public Sub setaVisForm(ByVal frm As frmPadrao, Optional ByVal hide As Boolean = False)
        'If hide = True Then
        '    frm.Close()
        '    'frm.Visible = False
        'Else
        '    'frm.Visible = True
        '    If frm.IsMdiChild = True Then
        '        frm.BringToFront()
        '        My.Forms.frmMain2.ActivateMdiChild(frm)
        '    Else
        '        frm.MdiParent = My.Forms.frmMain2
        '        Me.Cursor = Cursors.Arrow
        '        frm.Show()
        '    End If
        'End If
    End Sub

    Private Sub frmPadrao_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Private Sub frmPadrao_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.BackColor = My.Settings.corSystema
    End Sub

    'Dim dtTrava As Date = "01/01/2000"
    'Dim IDOnline As Integer = fbConnection.retornaValorUnico("select ISNULL(IDEmpresaOnline,-1)  from TB_ATUALIZACAO")
    'Dim DadosEMPOnline As String = ""
    'Dim dtTravaOnline As Date = "01/01/2000"

    'Private Sub travaSistema()
    '    Me.travaSISTEMA_INS_EDIT = True

    '    'Dim t2017 = clCrypto.Encrypt("10/01/2222")
    '    'update tb_conf_armazem set DadosEmp = 'DSa7B3qfoOIYNBA2SvAjE0cBMLlqfqmx2mf1qiZv4Ag=' < - 10/01/2222
    '    Dim DataVerificacao As Date = fbConnection.retornaValorUnico("SELECT ISNULL(DataVerificacao,'01/01/1900') FROM TB_ATUALIZACAO")

    '    If DataVerificacao.ToString("dd/MM/yyyy") <> Date.Now.ToString("dd/MM/yyyy") Then
    '        If IDOnline = -1 Then
    '            Dim CNPJEmpresa As String = fbConnection.retornaValorUnico("SELECT TOP 1 CNPJ FROM TB_EMPRESA")
    '            IDOnline = fbConnectionCRM.retornaValorUnico("SELECT ISNULL(ID,-1) FROM TB_CLIENTES WHERE CNPJ = '" + CNPJEmpresa.ToString() + "'")
    '            fbConnection.executaCommand("UPDATE TB_ATUALIZACAO SET IDEmpresaOnline =" + IDOnline.ToString())
    '        End If
    '        DadosEMPOnline = fbConnectionCRM.retornaValorUnico("SELECT ISNULL(DadosEmp,'') FROM TB_CLIENTES WHERE ID =" + IDOnline.ToString())
    '        Dim Correcao As Boolean
    '        Correcao = fbConnectionCRM.retornaValorUnico("SELECT ISNULL(Correcao,0) FROM TB_CLIENTES WHERE ID =" + IDOnline.ToString())
    '        If DadosEMPOnline <> Nothing AndAlso DadosEMPOnline <> "" Then
    '            fbConnection.executaCommand("UPDATE TB_ATUALIZACAO SET DataVerificacao = '" + Date.Now.ToString("dd/MM/yyyy") + "'")
    '            Try
    '                dtTrava = clCrypto.Decrypt(Me.DadosEMP)
    '                dtTravaOnline = clCrypto.Decrypt(DadosEMPOnline)

    '                If dtTravaOnline > dtTrava OrElse Correcao Then
    '                    Dim TravaFeedWeb As String
    '                    TravaFeedWeb = fbConnectionCRM.retornaValorUnico("SELECT ISNULL(TravaWMS, '') from TB_CLIENTES WHERE ID = " + IDOnline.ToString())

    '                    Dim TravaFeedWebERP As String
    '                    TravaFeedWebERP = fbConnectionCRM.retornaValorUnico("SELECT ISNULL(TravaERP, '') from TB_CLIENTES WHERE ID = " + IDOnline.ToString())

    '                    fbConnection.executaCommand("UPDATE TB_CONF_ARMAZEM SET DADOSEMP = '" + DadosEMPOnline + "'")
    '                    fbConnection.executaCommand("UPDATE TB_ATUALIZACAO SET TravaFeedBack = '" + TravaFeedWeb + "'")

    '                    dtTrava = dtTravaOnline
    '                End If

    '                If dtTrava > Date.Now Then
    '                    If dtTrava = dtTravaOnline Then
    '                        Me.travaSISTEMA_INS_EDIT = False
    '                    End If
    '                End If
    '            Catch ex As Exception

    '            End Try

    '        Else

    '            fbConnection.executaCommand("UPDATE TB_ATUALIZACAO SET DataVerificacao = '" + Date.Now.ToString("dd/MM/yyyy") + "'")
    '            Try
    '                dtTrava = clCrypto.Decrypt(Me.DadosEMP)

    '                If dtTrava > Date.Now Then
    '                    If dtTrava > Me.DATA_SERVER Then
    '                        Me.travaSISTEMA_INS_EDIT = False
    '                    End If
    '                End If
    '            Catch ex As Exception
    '                ' Me.travaSISTEMA_INS_EDIT = True
    '            End Try

    '        End If
    '    Else
    '        If DadosEMPOnline <> Nothing AndAlso DadosEMPOnline <> "" Then
    '            Try
    '                dtTrava = clCrypto.Decrypt(Me.DadosEMP)
    '                dtTravaOnline = clCrypto.Decrypt(DadosEMPOnline)

    '                If dtTrava > Date.Now Then
    '                    If dtTrava = dtTravaOnline Then
    '                        Me.travaSISTEMA_INS_EDIT = False
    '                    End If
    '                End If
    '            Catch ex As Exception
    '                ' Me.travaSISTEMA_INS_EDIT = True
    '            End Try
    '        Else
    '            Try
    '                dtTrava = clCrypto.Decrypt(Me.DadosEMP)

    '                If dtTrava > Date.Now Then
    '                    If dtTrava > Me.DATA_SERVER Then
    '                        Me.travaSISTEMA_INS_EDIT = False
    '                    End If
    '                End If
    '            Catch ex As Exception
    '                ' Me.travaSISTEMA_INS_EDIT = True
    '            End Try
    '        End If
    '    End If

    '    If Me.travaSISTEMA_INS_EDIT = True Then
    '        Dim sconX = "Data Source=feedback-nu.database.windows.net;Initial Catalog=dbFeedNutrace;Persist Security Info=True;User ID=Feedback;Password=Gc6j3gtq62;Connect Timeout=180;Encrypt=False; Language=Brazilian"
    '        Dim _email_ASSS As String = ""
    '        _email_ASSS += "EMPRESA: " & Me.NomeEmpresa & Environment.NewLine
    '        _email_ASSS += "USUARIO: " & Me.Usuario & Environment.NewLine
    '        _email_ASSS += "DATA: " & Date.Now.ToString("yyyy-MM-ddTHH:mm:ss") & Environment.NewLine

    '        Try
    '            Dim icom As String = "insert into tb_log_emp values ('"
    '            icom += "ENTRAR SISTEMA: " & Me.NomeEmpresa & "','"
    '            icom += _email_ASSS & " - EEE: " & Me.DadosEMP & "',dbo.GETDATE());"

    '            Dim isql As New SqlClient.SqlConnection(sconX)
    '            If (isql.State = ConnectionState.Open) Then isql.Close()
    '            isql.Open()
    '            Dim carregat As New SqlClient.SqlCommand(icom, isql)
    '            carregat.CommandType = CommandType.Text
    '            carregat.ExecuteNonQuery()

    '        Catch : End Try

    '        Dim iVERSAOF As String = ""
    '        Dim iVERSAOL As String = ""
    '        Dim iVERSAO As String = ""

    '        Try

    '            iVERSAOL = fbConnection.retornaValorUnico("select max(ID) from tb_lote")
    '            iVERSAOF = fbConnection.retornaValorUnico("select max(datafaturamento) from tb_faturamento")
    '            iVERSAO = fbConnection.retornaValorUnico("select top 1 versao from tb_atualizacao")

    '            'FODE O BANCO
    '            'Dim isql = "sp_msforeachtable 'ALTER TABLE ? DISABLE TRIGGER all';"
    '            'fbConnection.executaCommand(isql)
    '            'isql = "set identity_insert tb_lote off;"
    '            'fbConnection.executaCommand(isql)
    '            'isql = "set identity_insert tb_lote_localizacao off;"
    '            'fbConnection.executaCommand(isql)
    '            'isql = "set identity_insert tb_faturamento_pessoa_analitico off;"
    '            'fbConnection.executaCommand(isql)

    '        Catch : End Try

    '        _email_ASSS += "DATA FAT: " & iVERSAOF & Environment.NewLine
    '        _email_ASSS += "MAX ID LOTE: " & iVERSAOL & Environment.NewLine
    '        _email_ASSS += "VER BANCO: " & iVERSAO & Environment.NewLine

    '        Try
    '            Dim icom As String = "insert into tb_log_emp values ('"
    '            icom += "ENTROU SISTEMA: " & Me.NomeEmpresa & "','"
    '            icom += _email_ASSS & " - EEE: " & Me.DATA_SERVER.ToString("yyyy-MM-dd") & "',dbo.GETDATE());"

    '            Dim isql As New SqlClient.SqlConnection(sconX)
    '            If (isql.State = ConnectionState.Open) Then isql.Close()
    '            isql.Open()
    '            Dim carregat As New SqlClient.SqlCommand(icom, isql)
    '            carregat.CommandType = CommandType.Text
    '            carregat.ExecuteNonQuery()

    '        Catch : End Try
    '    End If
    'End Sub



    Public Overridable Sub aoIniciarTela()

    End Sub

    Public Function salvaComTransaction(tableAdapter As Object, tabela As Object,
                                        Optional ByVal timeOut As Integer = 9000000) As Boolean
        Dim tableAdapterType As Type = tableAdapter.[GetType]()
        Dim adapter As SqlClient.SqlDataAdapter = DirectCast(tableAdapterType.GetProperty("Adapter",
                                       BindingFlags.Instance Or BindingFlags.NonPublic).GetValue(tableAdapter, Nothing), 
                                        SqlClient.SqlDataAdapter)

        Dim conn As New SqlClient.SqlConnection(My.Settings.FeedAutomacaoConnectionString)

        Dim trans As SqlClient.SqlTransaction = Nothing
        Try
            conn.Open()
            trans = conn.BeginTransaction

            adapter.InsertCommand.Connection = trans.Connection
            adapter.UpdateCommand.Connection = trans.Connection
            adapter.DeleteCommand.Connection = trans.Connection

            adapter.InsertCommand.Transaction = trans
            adapter.UpdateCommand.Transaction = trans
            adapter.DeleteCommand.Transaction = trans

            adapter.InsertCommand.CommandTimeout = timeOut
            adapter.UpdateCommand.CommandTimeout = timeOut
            adapter.DeleteCommand.CommandTimeout = timeOut

            adapter.Update(tabela)

            trans.Commit()
        Catch ex As SqlClient.SqlException
            trans.Rollback()
            MsgBox("Ocorreu um Erro Durante a Transação: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return True
    End Function

    Public Function salvaComTransactionMAXIDUsuario(tableAdapter As Object,
                                                    tabela As Object,
                                                    _IDUsuario As Integer,
                                                    Optional ByVal timeOut As Integer = 9000000) As Integer
        Dim iID As Integer = -1
        Dim tableAdapterType As Type = tableAdapter.[GetType]()
        Dim adapter As SqlClient.SqlDataAdapter = DirectCast(tableAdapterType.GetProperty("Adapter",
                                       BindingFlags.Instance Or BindingFlags.NonPublic).GetValue(tableAdapter, Nothing),
                                        SqlClient.SqlDataAdapter)

        Dim conn As New SqlClient.SqlConnection(My.Settings.FeedAutomacaoConnectionString)
        Dim trans As SqlClient.SqlTransaction = Nothing
        Try
            conn.Open()
            trans = conn.BeginTransaction

            adapter.InsertCommand.Connection = trans.Connection
            adapter.UpdateCommand.Connection = trans.Connection
            adapter.DeleteCommand.Connection = trans.Connection

            adapter.InsertCommand.Transaction = trans
            adapter.UpdateCommand.Transaction = trans
            adapter.DeleteCommand.Transaction = trans

            adapter.InsertCommand.CommandTimeout = timeOut
            adapter.UpdateCommand.CommandTimeout = timeOut
            adapter.DeleteCommand.CommandTimeout = timeOut

            adapter.Update(tabela)

            trans.Commit()

            iID = tableAdapter.MAXID(_IDUsuario)

        Catch ex As SqlClient.SqlException
            trans.Rollback()
            MsgBox("Ocorreu um Erro Durante a Transação: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return iID
    End Function





End Class