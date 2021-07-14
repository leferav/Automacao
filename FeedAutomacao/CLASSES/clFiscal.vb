Imports System.Threading

Public Class clFiscal

    'Public Shared Sub ImprimiRequisicao(ByVal IDReq As Integer, ByVal FINANCEIRO As Integer)
    '    If liberaImprimir(IDReq) = True Then
    '        Dim dts As New DataSet

    '        Dim tb As dtsRelatorio.ImprimeRequisicaoDataTable
    '        Dim tr As New dtsRelatorioTableAdapters.ImprimeRequisicaoTableAdapter
    '        Dim tbI As dtsRelatorio.ImprimeRequisicaoItemDataTable
    '        Dim trI As New dtsRelatorioTableAdapters.ImprimeRequisicaoItemTableAdapter

    '        tb = tr.GetData(IDReq)
    '        tbI = trI.GetData(IDReq, My.Forms.frmPadrao.IDUsuario, My.Forms.frmPadrao.IDEmpresa, FINANCEIRO)

    '        dts.Tables.Add(tb)
    '        dts.Tables.Add(tbI)

    '        My.Forms.frmGeraRelatorio.TipoRel = TipoRel.Rel.ImprimiRequisicao
    '        My.Forms.frmGeraRelatorio.DataSetRel = dts
    '        My.Forms.frmGeraRelatorio.ShowDialog()
    '    End If

    'End Sub

    'Public Shared Function GeraRequisicaoViagem(ByVal IDviagem As Integer, ByVal Valor As Double, _
    '                                            ByVal tipo As String, ByVal pessoa As Integer) As Integer
    '    Dim ssql As String = ""

    '    Dim achaConf As String = ""
    '    achaConf += " SELECT ViagemSelecionaContaContabil FROM TB_TRANSPORTE_CONFIGURACAO "
    '    achaConf += " WHERE IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString()
    '    Dim PegaValor = fbConnection.executaSelect(achaConf)
    '    Dim SelecionaConta As String = "N"
    '    If PegaValor IsNot Nothing AndAlso PegaValor.Rows.Count > 0 AndAlso _
    '    Not IsDBNull(PegaValor.Rows(0).Item(0)) Then
    '        SelecionaConta = PegaValor.Rows(0).Item(0)
    '    End If

    '    Dim achaConfVeiculo As String = ""
    '    achaConfVeiculo += " SELECT tipoprop FROM TB_VEICULO WHERE ID = "
    '    achaConfVeiculo += " (SELECT IDVeiculo FROM TB_VIAGEM WHERE ID = " + IDviagem.ToString() + ")"
    '    Dim PegaValorVeicu = fbConnection.executaSelect(achaConfVeiculo)
    '    Dim TipoVeiculo As String = "N"
    '    If PegaValorVeicu IsNot Nothing AndAlso PegaValorVeicu.Rows.Count > 0 AndAlso _
    '    Not IsDBNull(PegaValorVeicu.Rows(0).Item(0)) Then
    '        TipoVeiculo = PegaValorVeicu.Rows(0).Item(0)
    '    End If

    '    Dim achaPessoaPedagio As String = ""
    '    achaPessoaPedagio += " SELECT viagemIDPessoaPedagio FROM TB_TRANSPORTE_CONFIGURACAO "
    '    achaPessoaPedagio += " WHERE IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString()
    '    Dim ExecPessoaPedagio = fbConnection.executaSelect(achaPessoaPedagio)
    '    Dim _IDPessoaPedagio As Integer = -1
    '    If ExecPessoaPedagio IsNot Nothing AndAlso ExecPessoaPedagio.Rows.Count > 0 AndAlso _
    '    Not IsDBNull(ExecPessoaPedagio.Rows(0).Item(0)) AndAlso tipo = "PED" Then
    '        pessoa = ExecPessoaPedagio.Rows(0).Item(0)
    '    End If

    '    Dim dtr As New FeedComponentes.dtsFeedTranspTableAdapters.QueriesTableAdapter

    '    Dim IDContaContab As Integer = -1

    '    'If SelecionaConta = "T" Or (SelecionaConta = "P" AndAlso TipoVeiculo = "P") Or _
    '    '(SelecionaConta = "O" AndAlso TipoVeiculo = "T") Then
    '    '    My.Forms.frmDavidMoska.tipo = tipo
    '    '    My.Forms.frmDavidMoska.ShowDialog()
    '    '    IDContaContab = My.Forms.frmDavidMoska.IDConta.ToString()
    '    'End If

    '    Return dtr.geraRequisicaoViagem(IDviagem, Valor, tipo, pessoa, _
    '                                    My.Forms.frmPadrao.IDUsuario, IDContaContab)

    'End Function

    'Public Shared Function GeraRequisicao(ByVal IDAcertoviagem As Integer, ByVal Valor As Double, _
    '                                      ByVal tipo As String, ByVal pessoa As Integer, _
    '                                      ByVal MotoristaViagem As String) As Integer
    '    Dim ssql As String = ""

    '    Dim achaConf As String = ""
    '    achaConf += " SELECT ViagemSelecionaContaContabil FROM TB_TRANSPORTE_CONFIGURACAO "
    '    achaConf += " WHERE IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString()
    '    Dim PegaValor = fbConnection.executaSelect(achaConf)
    '    Dim SelecionaConta As String = "N"
    '    If PegaValor IsNot Nothing AndAlso PegaValor.Rows.Count > 0 AndAlso _
    '    Not IsDBNull(PegaValor.Rows(0).Item(0)) Then
    '        SelecionaConta = PegaValor.Rows(0).Item(0)
    '    End If

    '    Dim achaConfVeiculo As String = ""
    '    achaConfVeiculo += " SELECT tipoprop FROM TB_VEICULO WHERE ID = "
    '    achaConfVeiculo += " (SELECT IDVeiculo FROM TB_VIAGEM WHERE ID = "
    '    achaConfVeiculo += " (SELECT TOP(1) IDViagem FROM TB_ACERTO_VIAGEM_VIAGEM "
    '    achaConfVeiculo += " WHERE IDAcertoViagem =" + IDAcertoviagem.ToString() + "))"
    '    Dim PegaValorVeicu = fbConnection.executaSelect(achaConfVeiculo)
    '    Dim TipoVeiculo As String = "N"
    '    If PegaValorVeicu IsNot Nothing AndAlso PegaValorVeicu.Rows.Count > 0 AndAlso _
    '    Not IsDBNull(PegaValorVeicu.Rows(0).Item(0)) Then
    '        TipoVeiculo = PegaValorVeicu.Rows(0).Item(0)
    '    End If

    '    Dim achaPessoaPedagio As String = ""
    '    achaPessoaPedagio += " SELECT viagemIDPessoaPedagio FROM TB_TRANSPORTE_CONFIGURACAO "
    '    achaPessoaPedagio += " WHERE IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString()
    '    Dim ExecPessoaPedagio = fbConnection.executaSelect(achaPessoaPedagio)
    '    Dim _IDPessoaPedagio As Integer = -1
    '    If ExecPessoaPedagio IsNot Nothing AndAlso ExecPessoaPedagio.Rows.Count > 0 AndAlso _
    '    Not IsDBNull(ExecPessoaPedagio.Rows(0).Item(0)) AndAlso tipo = "PED" Then
    '        pessoa = ExecPessoaPedagio.Rows(0).Item(0)
    '    End If


    '    Dim dtr As New dtsFeedTranspTableAdapters.QueriesTableAdapter

    '    Dim IDContaContab As Integer = -1

    '    'If SelecionaConta = "T" Or (SelecionaConta = "P" AndAlso TipoVeiculo = "P") Or _
    '    '(SelecionaConta = "O" AndAlso TipoVeiculo = "T") Then
    '    '    My.Forms.frmDavidMoska.tipo = tipo
    '    '    My.Forms.frmDavidMoska.ShowDialog()
    '    '    IDContaContab = My.Forms.frmDavidMoska.IDConta.ToString()
    '    'End If

    '    Return dtr.geraRequisicaoAcertoViagem(IDAcertoviagem, Valor, tipo, pessoa, _
    '                                    My.Forms.frmPadrao.IDUsuario, IDContaContab, MotoristaViagem)

    'End Function

    Shared Function liberaImprimir(ByVal ID As Integer) As Boolean
        Dim ssql As String = ""
        ssql = "SELECT libera,tipo FROM TB_REQUISICAO WHERE inutilizavel <> 'S' AND ID = " + ID.ToString()
        Dim dt1 As DataTable = fbConnection.executaSelect(ssql)
        If dt1 IsNot Nothing AndAlso dt1.Rows.Count > 0 Then
            Dim val As Integer = dt1.Rows(0).Item(0)
            Dim Tipo As Integer = dt1.Rows(0).Item(1)
            If val = 1 Then
                Return True
            Else
                If Tipo = 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        End If
        Return False
    End Function


    Public Shared Function buscaEstado(ByVal id As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select NOME from TB_ESTADO WHERE CODIGO = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function pesquisaCodPessoa(ByVal id As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select ID from TB_PESSOA WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function pesquisaGuia(ByVal id As Integer) As Integer
        Dim bt As Integer = -1
        Dim dt = fbConnection.executaSelect("select ID from TB_APURA_GUIA WHERE IDApura = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function retornaSaldoEstoque(ByVal data As DateTime) As Double
        Dim bt As Double = 0
        Dim dt = fbConnection.executaSelect("select SUM(Saldo) from TB_SALDO_ITEM WHERE IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function pesquisaNomePessoa(ByVal id As Integer) As String
        Dim nome As String = fbConnection.retornaValorUnico("select Nome from TB_PESSOA WHERE ID = " + id.ToString())
        If nome IsNot Nothing Then
            Return nome
        End If
        Return ""
    End Function

    Public Shared Function pesquisaDadosPessoa(ByVal id As Integer, ByVal Campo As String) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select " + Campo + " from TB_PESSOA WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function pesquisaTelefonePessoa(ByVal id As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select Telefone from TB_PESSOA WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaCFOP(ByVal id As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select codigo from TB_CFOP WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscacodigoUnidade(ByVal id As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select codigo from TB_UNIDADE WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function


    Public Shared Function buscaIndiceApuracao() As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select Apura_IPI from TB_CONFIGURACAO WHERE IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function


    Public Shared Function buscaSigla(ByVal id As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select TOP(1) sigla from TB_ESTADO WHERE CODIGO = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaSiglaEstado(ByVal Nome As String) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select Top(1) sigla from TB_ESTADO WHERE NOME = '" + Nome + "'")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaCidade(ByVal id As Integer, ByVal estado As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select NOME from TB_CIDADE WHERE CODIGO = " + id.ToString() + " AND CODEstado = " + estado.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaCodPais(ByVal codCid As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select codPais from TB_IBGE_CEP WHERE CODIGOMUNI = " + codCid.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaNomePais(ByVal id As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select nomePais from TB_IBGE_CEP WHERE CODIGOMUNI = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaNomeEstado(ByVal sigla As String) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select NOMEUF from TB_IBGE_CEP WHERE sigla = '" + sigla + "'")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function pesquisaUnidadeItem(ByVal sigla As String) As Integer
        Dim bt As Integer = -1
        Dim dt = fbConnection.executaSelect("select ID from TB_UNIDADE WHERE codigo = '" + sigla + "'")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function retornaQtdEstoque(ByVal IDItem As Integer) As Double
        Dim bt As Double = 1
        Dim dt = fbConnection.executaSelect("select Saldo from TB_SALDO_ITEM WHERE IDItem = " + IDItem.ToString() + " AND IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaCodEstado(ByVal sigla As String) As Integer
        Dim bt As Integer = -1
        Dim dt = fbConnection.executaSelect("select CODIGOUF from TB_IBGE_CEP WHERE sigla = '" + sigla + "'")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaCodEstadoNome(ByVal sigla As String) As Integer
        Dim bt As Integer = -1
        Dim dt = fbConnection.executaSelect("select CODIGO from TB_ESTADO WHERE NOME = '" + sigla + "'")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaCodCidade(ByVal nome As String, ByVal codEstado As Integer) As Integer
        Dim bt As Integer = -1
        Dim dt = fbConnection.executaSelect("select CODIGO from TB_CIDADE WHERE NOME = '" + nome + "' AND codEstado = " + codEstado.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function pesquisaCliente(ByVal cnpj As String) As DataRow
        Dim bt As DataRow = Nothing
        Dim dt = fbConnection.executaSelect("select ID,Nome from TB_PESSOA WHERE CGC LIKE '%" + cnpj + "%'")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0)
        End If
        Return bt
    End Function

    Public Shared Function pesquisaTransporte(ByVal cnpj As String) As DataRow
        Dim bt As DataRow = Nothing
        Dim dt = fbConnection.executaSelect("select ID,Nome from TB_TRANSPORTADORA WHERE CIC LIKE '%" + cnpj + "%'")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0)
        End If
        Return bt
    End Function

    Public Shared Function retornaCFOPID(ByVal cod As String) As Integer
        Dim bt As Integer = -1
        Dim dt = fbConnection.executaSelect("select ID from TB_CFOP WHERE Codigo = '" + cod + "'")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function pesquisaItem(ByVal nome As String) As DataRow
        Dim bt As DataRow = Nothing
        Dim dt = fbConnection.executaSelect("select ID,Nome from TB_ITEM WHERE Nome LIKE '%" + nome + "%'")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0)
        End If
        Return bt
    End Function


    Public Shared Function buscaUnidade(ByVal id As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select codigo from TB_UNIDADE WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaCodRota(ByVal id As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select codRota from TB_ROTA WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaUFEmpresa() As Integer
        Dim bt As Integer = -1
        Dim dt = fbConnection.executaSelect("select codEstado from TB_EMPRESA WHERE ID = " + My.Forms.frmPadrao.IDEmpresa.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            If Not IsDBNull(dt.Rows(0).Item(0)) Then bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaCNPJEmpresa() As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select CNPJ from TB_EMPRESA WHERE ID = " + My.Forms.frmPadrao.IDEmpresa.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            If Not IsDBNull(dt.Rows(0).Item(0)) Then bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaCidadeEmpresa() As Integer
        Dim bt As Integer = -1
        Dim dt = fbConnection.executaSelect("select codCidade from TB_EMPRESA WHERE ID = " + My.Forms.frmPadrao.IDEmpresa.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            If Not IsDBNull(dt.Rows(0).Item(0)) Then bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaEstadoEmpresa() As Integer
        Dim bt As Integer = -1
        Dim dt = fbConnection.executaSelect("select codEstado from TB_EMPRESA WHERE ID = " + My.Forms.frmPadrao.IDEmpresa.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            If Not IsDBNull(dt.Rows(0).Item(0)) Then bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaTipoCliente(ByVal id As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select Nome from TB_TIPO_CLIENTE WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaIDTipoCliente(ByVal id As Integer) As String
        Dim IDT As Integer = -1
        Dim dt = fbConnection.executaSelect("select IDTipoFiscal from TB_PESSOA WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0).Item(0)) Then
            IDT = dt.Rows(0).Item(0)
        End If
        Return IDT
    End Function

    Public Shared Function buscaNomeTipoCliente(ByVal id As Integer) As String
        Dim IDT As String = ""
        Dim dt = fbConnection.executaSelect("select Nome from TB_TIPO_CLIENTE WHERE ID IN (select IDTipoFiscal from TB_PESSOA WHERE ID = " + id.ToString() + ")")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0).Item(0)) Then
            IDT = dt.Rows(0).Item(0)
        End If
        Return IDT
    End Function

    Public Shared Function buscaCodCidadePessoa(ByVal id As Integer) As String
        Dim IDT As Integer = -1
        Dim dt = fbConnection.executaSelect("select codCidade from TB_PESSOA WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            IDT = dt.Rows(0).Item(0)
        End If
        Return IDT
    End Function

    Public Shared Function buscaCodEstadoPessoa(ByVal id As Integer) As String
        Dim IDT As Integer = -1
        Dim dt = fbConnection.executaSelect("select codEstado from TB_PESSOA WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            IDT = dt.Rows(0).Item(0)
        End If
        Return IDT
    End Function

    Public Shared Function buscaNomeEstadoPessoa(ByVal id As Integer) As String
        Dim IDT As String = ""
        Dim dt = fbConnection.executaSelect("SELECT NOME FROM TB_ESTADO WHERE CODIGO IN (select codEstado from TB_PESSOA WHERE ID = " + id.ToString() + ")")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            IDT = dt.Rows(0).Item(0)
        End If
        Return IDT
    End Function

    Public Shared Function buscaTipoItem(ByVal id As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select Nome from TB_TIPO_ITEM WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaIDTipoItem(ByVal id As Integer) As Integer
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select IDTipoItem from TB_ITEM WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function buscaNomeItem(ByVal id As Integer) As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select Nome from TB_ITEM WHERE ID = " + id.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function verificaLegislacao(ByVal cfop As Integer, _
                                              ByVal tpProd As Integer, _
                                              ByVal tpCliente As Integer, _
                                              ByVal UFOrigem As Integer, _
                                              ByVal UFDestino As Integer, _
                                              ByVal TipoRel As String) As Integer
        Dim ssql As String = "SELECT ID FROM TB_LEGISLACAO WHERE "
        ssql += " IDCFOP = " + cfop.ToString()
        ssql += " AND IDTipoItem = " + tpProd.ToString()
        ssql += " AND IDTipoCliente = " + tpCliente.ToString()
        ssql += " AND Origem = " + UFOrigem.ToString()
        ssql += " AND Destino = " + UFDestino.ToString()
        ssql += " AND Tipo_Leg = '" + TipoRel + "'"

        Dim dt = fbConnection.executaSelect(ssql)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        End If
        Return 0
    End Function

    Public Shared Function verificaLegislacao(ByVal cfop As Integer, _
                                              ByVal tpProd As Integer, _
                                              ByVal tpCliente As Integer, _
                                              ByVal Cidade As Integer, _
                                              ByVal TipoRel As String) As Integer
        Dim ssql As String = "SELECT ID FROM TB_LEGISLACAO WHERE "
        ssql += " CFOP = " + cfop.ToString()
        ssql += " AND TipoProduto = " + tpProd.ToString()
        ssql += " AND TipoCliente = " + tpCliente.ToString()
        ssql += " AND ISSQN_Cidade = " + Cidade.ToString()
        ssql += " AND Tipo_Leg = '" + TipoRel + "'"

        Dim dt = fbConnection.executaSelect(ssql)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        End If
        Return 0
    End Function


    'Public Shared Function calculaExpressao(ByVal campo As String, _
    '                                  ByVal LegRow As FeedComponentes.dts123.TB_LEGISLACAORow, _
    '                                  ByVal qtd As Double, ByVal unitario As Double, _
    '                                  ByVal total As Double) As Double
    '    Dim sExpReal As String

    '    Try
    '        sExpReal = Trim(campo)
    '        sExpReal = sExpReal.ToUpper()
    '        If sExpReal <> "" Then
    '            'ICMS
    '            If (sExpReal.Contains("PICMSSTRET")) Then
    '                sExpReal = sExpReal.Replace("PICMSSTRET", LegRow.ICMS_RET_Ali)
    '            End If

    '            If (sExpReal.Contains("PICMSSTDEST")) Then
    '                sExpReal = sExpReal.Replace("PICMSSTDEST", LegRow.ICMS_DEST_Ali)
    '            End If

    '            If (sExpReal.Contains("PICMSST")) Then
    '                sExpReal = sExpReal.Replace("PICMSST", LegRow.ICMSST_Aliquota)
    '            End If

    '            If (sExpReal.Contains("PICMS")) Then
    '                sExpReal = sExpReal.Replace("PICMS", LegRow.ICMS_Aliquota)
    '            End If

    '            If (sExpReal.Contains("PMVAST")) Then
    '                sExpReal = sExpReal.Replace("PMVAST", LegRow.ICMSST_pMVAST)
    '            End If

    '            If (sExpReal.Contains("PREDBCST")) Then
    '                sExpReal = sExpReal.Replace("PREDBCST", LegRow.ICMSST_Red_BC)
    '            End If

    '            If (sExpReal.Contains("PREDBC")) Then
    '                sExpReal = sExpReal.Replace("PREDBC", LegRow.ICMS_Red_BC)
    '            End If

    '            If (sExpReal.Contains("PCREDSN")) Then
    '                sExpReal = sExpReal.Replace("PCREDSN", LegRow.SN_Aliquota)
    '            End If

    '            If (sExpReal.Contains("VCREDICMSSN")) Then
    '                sExpReal = sExpReal.Replace("PCREDSN", _
    '                                            (calculaExpressao(LegRow.SN_EXP_vCred, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("PBCOP")) Then
    '                sExpReal = sExpReal.Replace("PBCOP", LegRow.ICMSPart_BC)
    '            End If

    '            If (sExpReal.Contains("VBCICMSSTDEST")) Then
    '                sExpReal = sExpReal.Replace("VBCICMSSTDEST", _
    '                                            (calculaExpressao(LegRow.ICMSDEST_EXP_Base, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VBCICMSSTRET")) Then
    '                sExpReal = sExpReal.Replace("VBCICMSSTRET", _
    '                                            (calculaExpressao(LegRow.ICMSRET_EXP_Base, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VBCICMSST")) Then
    '                sExpReal = sExpReal.Replace("VBCICMSST", _
    '                                            (calculaExpressao(LegRow.ICMSST_EXP_Base, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VBCICMS")) Then
    '                sExpReal = sExpReal.Replace("VBCICMS", _
    '                                            (calculaExpressao(LegRow.ICMS_EXP_Base, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VICMSSTDEST")) Then
    '                sExpReal = sExpReal.Replace("VICMSSTDEST", _
    '                                            (calculaExpressao(LegRow.ICMSDEST_EXP_Valor, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VICMSSTRET")) Then
    '                sExpReal = sExpReal.Replace("VICMSSTRET", _
    '                                            (calculaExpressao(LegRow.ICMSRET_EXP_Valor, _
    '                                                               LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VICMSST")) Then
    '                sExpReal = sExpReal.Replace("VICMSST", _
    '                                            (calculaExpressao(LegRow.ICMSST_EXP_Valor, _
    '                                                            LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VICMS")) Then
    '                sExpReal = sExpReal.Replace("VICMS", _
    '                                            (calculaExpressao(LegRow.ICMS_EXP_Valor, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            'IPI
    '            If (sExpReal.Contains("PIPI")) Then
    '                sExpReal = sExpReal.Replace("PIPI", LegRow.IPI_Aliquota)
    '            End If

    '            If (sExpReal.Contains("BCIPI")) Then
    '                sExpReal = sExpReal.Replace("BCIPI", _
    '                                            (calculaExpressao(LegRow.IPI_EXP_Base, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VUNDIPI")) Then
    '                sExpReal = sExpReal.Replace("VUNDIPI", LegRow.IPI)
    '            End If

    '            If (sExpReal.Contains("VQTDIPI")) Then
    '                sExpReal = sExpReal.Replace("VQTDIPI", _
    '                                            (calculaExpressao(LegRow.IPI_EXP_QTD, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VIPI")) Then
    '                sExpReal = sExpReal.Replace("VIPI", _
    '                                            (calculaExpressao(LegRow.IPI_EXP_Valor, _
    '                                                               LegRow, qtd, unitario, total)))
    '            End If

    '            'PIS
    '            If (sExpReal.Contains("PPISST")) Then
    '                sExpReal = sExpReal.Replace("PPISST", LegRow.PISST_Aliquota)
    '            End If

    '            If (sExpReal.Contains("VBCPISST")) Then
    '                sExpReal = sExpReal.Replace("VBCPISST", _
    '                                            (calculaExpressao(LegRow.PISST_EXP_Base, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VUNDPISST")) Then
    '                sExpReal = sExpReal.Replace("VUNDPISST", LegRow.PISST)
    '            End If

    '            If (sExpReal.Contains("VQTDPISST")) Then
    '                sExpReal = sExpReal.Replace("VQTDPISST", _
    '                                            (calculaExpressao(LegRow.PISST_EXP_QTD, _
    '                                                            LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VPISST")) Then
    '                sExpReal = sExpReal.Replace("VPISST", _
    '                                            (calculaExpressao(LegRow.PISST_EXP_Valor, _
    '                                                               LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("PPIS")) Then
    '                sExpReal = sExpReal.Replace("PPIS", LegRow.PIS_Aliquota)
    '            End If

    '            If (sExpReal.Contains("VBCPIS")) Then
    '                sExpReal = sExpReal.Replace("VBCPIS", _
    '                                            (calculaExpressao(LegRow.PIS_EXP_Base, _
    '                                                            LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VUNDPIS")) Then
    '                sExpReal = sExpReal.Replace("VUNDPIS", LegRow.PIS)
    '            End If

    '            If (sExpReal.Contains("VQTDPIS")) Then
    '                sExpReal = sExpReal.Replace("VQTDPIS", _
    '                                            (calculaExpressao(LegRow.PIS_EXP_QTD, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VPIS")) Then
    '                sExpReal = sExpReal.Replace("VPIS", _
    '                                            (calculaExpressao(LegRow.PIS_EXP_Valor, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            'COFINS
    '            If (sExpReal.Contains("PCOFINSST")) Then
    '                sExpReal = sExpReal.Replace("PCOFINSST", LegRow.COFINSST_Aliquota)
    '            End If

    '            If (sExpReal.Contains("VBCCOFINSST")) Then
    '                sExpReal = sExpReal.Replace("VBCCOFINSST", _
    '                                            (calculaExpressao(LegRow.COFINSST_EXP_Base, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VUNDCOFINSST")) Then
    '                sExpReal = sExpReal.Replace("VUNDCOFINSST", LegRow.COFINSST)
    '            End If

    '            If (sExpReal.Contains("VQTDCOFINSST")) Then
    '                sExpReal = sExpReal.Replace("VQTDCOFINSST", _
    '                                            (calculaExpressao(LegRow.COFINSST_EXP_QTD, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VCOFINSST")) Then
    '                sExpReal = sExpReal.Replace("VCOFINSST", _
    '                                            (calculaExpressao(LegRow.COFINSST_EXP_Valor, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("PCOFINS")) Then
    '                sExpReal = sExpReal.Replace("PCOFINS", LegRow.COFINS_Aliquota)
    '            End If

    '            If (sExpReal.Contains("VBCCOFINS")) Then
    '                sExpReal = sExpReal.Replace("VBCCOFINS", _
    '                                            (calculaExpressao(LegRow.COFINS_EXP_Base, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VUNDCOFINS")) Then
    '                sExpReal = sExpReal.Replace("VUNDCOFINS", LegRow.COFINS)
    '            End If

    '            If (sExpReal.Contains("VQTDCOFINS")) Then
    '                sExpReal = sExpReal.Replace("VQTDCOFINS", (calculaExpressao(LegRow.COFINS_EXP_QTD, _
    '                                                                            LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VCOFINS")) Then
    '                sExpReal = sExpReal.Replace("VCOFINS", (calculaExpressao(LegRow.COFINS_EXP_Valor, _
    '                                                                        LegRow, qtd, unitario, total)))
    '            End If

    '            'VALOR
    '            If (sExpReal.Contains("QTD")) Then
    '                sExpReal = sExpReal.Replace("QTD", qtd)
    '            End If

    '            If (sExpReal.Contains("VLRUNIT")) Then
    '                sExpReal = sExpReal.Replace("VLRUNIT", unitario)
    '            End If

    '            If (sExpReal.Contains("SUBTOT")) Then
    '                sExpReal = sExpReal.Replace("SUBTOT", total)
    '            End If

    '            'ISSQN
    '            If (sExpReal.Contains("PISSQN")) Then
    '                sExpReal = sExpReal.Replace("PISSQN", LegRow.ISSQN_Aliquota)
    '            End If

    '            If (sExpReal.Contains("VBCISSQN")) Then
    '                sExpReal = sExpReal.Replace("VBCISSQN", _
    '                                            (calculaExpressao(LegRow.ISSQN_EXP_BC, LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VPISISSQN")) Then
    '                sExpReal = sExpReal.Replace("VPISISSQN", _
    '                                            (calculaExpressao(LegRow.ISSQN_EXP_PIS, LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VCOFINSISSQN")) Then
    '                sExpReal = sExpReal.Replace("VCOFINSISSQN", _
    '                                            (calculaExpressao(LegRow.ISSQN_EXP_COFINS, LegRow, qtd, unitario, total)))

    '            End If
    '            If (sExpReal.Contains("VISSQN")) Then
    '                sExpReal = sExpReal.Replace("VISSQN", _
    '                                            (calculaExpressao(LegRow.ISSQN_EXP_Valor, LegRow, qtd, unitario, total)))
    '            End If

    '        Else
    '            Return "0"
    '        End If
    '        Return ExecuteFormula(sExpReal)
    '    Catch ex As Exception
    '        MsgBox("Erro no Calculo de Impostos! Verifique o Cadastro de Legislação! Erro: " + sExpReal, MsgBoxStyle.Critical)
    '        Return "0"
    '    End Try
    'End Function

    'Public Shared Function calculaExpressaoEntrada(ByVal campo As String, _
    '                                 ByVal LegRow As FeedComponentes.dtsFiscal2.TB_LEGISLACAO_ENTRADARow, _
    '                                 ByVal qtd As Double, ByVal unitario As Double, _
    '                                 ByVal total As Double) As Double
    '    Dim sExpReal As String

    '    Try
    '        sExpReal = Trim(campo)
    '        sExpReal = sExpReal.ToUpper()
    '        If sExpReal <> "" Then


    '            'PIS
    '            If (sExpReal.Contains("PPISST")) Then
    '                sExpReal = sExpReal.Replace("PPISST", LegRow.PISST_Aliquota)
    '            End If

    '            If (sExpReal.Contains("VBCPISST")) Then
    '                sExpReal = sExpReal.Replace("VBCPISST", _
    '                                            (calculaExpressaoEntrada(LegRow.PISST_EXP_Base, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VUNDPISST")) Then
    '                sExpReal = sExpReal.Replace("VUNDPISST", LegRow.PISST)
    '            End If

    '            If (sExpReal.Contains("VQTDPISST")) Then
    '                sExpReal = sExpReal.Replace("VQTDPISST", _
    '                                            (calculaExpressaoEntrada(LegRow.PISST_EXP_QTD, _
    '                                                            LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VPISST")) Then
    '                sExpReal = sExpReal.Replace("VPISST", _
    '                                            (calculaExpressaoEntrada(LegRow.PISST_EXP_Valor, _
    '                                                               LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("PPIS")) Then
    '                sExpReal = sExpReal.Replace("PPIS", LegRow.PIS_Aliquota)
    '            End If

    '            If (sExpReal.Contains("VBCPIS")) Then
    '                sExpReal = sExpReal.Replace("VBCPIS", _
    '                                            (calculaExpressaoEntrada(LegRow.PIS_EXP_Base, _
    '                                                            LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VUNDPIS")) Then
    '                sExpReal = sExpReal.Replace("VUNDPIS", LegRow.PIS)
    '            End If

    '            If (sExpReal.Contains("VQTDPIS")) Then
    '                sExpReal = sExpReal.Replace("VQTDPIS", _
    '                                            (calculaExpressaoEntrada(LegRow.PIS_EXP_QTD, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VPIS")) Then
    '                sExpReal = sExpReal.Replace("VPIS", _
    '                                            (calculaExpressaoEntrada(LegRow.PIS_EXP_Valor, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            'COFINS
    '            If (sExpReal.Contains("PCOFINSST")) Then
    '                sExpReal = sExpReal.Replace("PCOFINSST", LegRow.COFINSST_Aliquota)
    '            End If

    '            If (sExpReal.Contains("VBCCOFINSST")) Then
    '                sExpReal = sExpReal.Replace("VBCCOFINSST", _
    '                                            (calculaExpressaoEntrada(LegRow.COFINSST_EXP_Base, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VUNDCOFINSST")) Then
    '                sExpReal = sExpReal.Replace("VUNDCOFINSST", LegRow.COFINSST)
    '            End If

    '            If (sExpReal.Contains("VQTDCOFINSST")) Then
    '                sExpReal = sExpReal.Replace("VQTDCOFINSST", _
    '                                            (calculaExpressaoEntrada(LegRow.COFINSST_EXP_QTD, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VCOFINSST")) Then
    '                sExpReal = sExpReal.Replace("VCOFINSST", _
    '                                            (calculaExpressaoEntrada(LegRow.COFINSST_EXP_Valor, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("PCOFINS")) Then
    '                sExpReal = sExpReal.Replace("PCOFINS", LegRow.COFINS_Aliquota)
    '            End If

    '            If (sExpReal.Contains("VBCCOFINS")) Then
    '                sExpReal = sExpReal.Replace("VBCCOFINS", _
    '                                            (calculaExpressaoEntrada(LegRow.COFINS_EXP_Base, _
    '                                                              LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VUNDCOFINS")) Then
    '                sExpReal = sExpReal.Replace("VUNDCOFINS", LegRow.COFINS)
    '            End If

    '            If (sExpReal.Contains("VQTDCOFINS")) Then
    '                sExpReal = sExpReal.Replace("VQTDCOFINS", (calculaExpressaoEntrada(LegRow.COFINS_EXP_QTD, _
    '                                                                            LegRow, qtd, unitario, total)))
    '            End If

    '            If (sExpReal.Contains("VCOFINS")) Then
    '                sExpReal = sExpReal.Replace("VCOFINS", (calculaExpressaoEntrada(LegRow.COFINS_EXP_Valor, _
    '                                                                        LegRow, qtd, unitario, total)))
    '            End If

    '            'VALOR
    '            If (sExpReal.Contains("QTD")) Then
    '                sExpReal = sExpReal.Replace("QTD", qtd)
    '            End If

    '            If (sExpReal.Contains("VLRUNIT")) Then
    '                sExpReal = sExpReal.Replace("VLRUNIT", unitario)
    '            End If

    '            If (sExpReal.Contains("SUBTOT")) Then
    '                sExpReal = sExpReal.Replace("SUBTOT", total)
    '            End If

    '        Else
    '            Return "0"
    '        End If
    '        Return ExecuteFormula(sExpReal)
    '    Catch ex As Exception
    '        MsgBox("Erro no Calculo de Impostos! Verifique o Cadastro de Legislação! Erro: " + sExpReal, MsgBoxStyle.Critical)
    '        Return "0"
    '    End Try
    'End Function

    Public Shared Function ExecuteFormula(ByVal strFormula As String) As Double
        Dim intPos As Integer
        Dim intQtdParentesis As Long = Nothing
        Dim intPosParOpen As Integer
        Dim intQtdParOpen As Long
        Dim intPosParClose As Integer
        Dim intQtdParClose As Long
        Dim strFormulaTemp As String
        Dim strOperator1 As String
        Dim strOperator2 As String
        Dim dblResultTemp As Double

        'Excludes the spaces
        strFormula = strFormula.Replace(" ", "")

        'Excludes the digits grouping symbol
        strFormula = strFormula.Replace(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator, "")

        'Prepares the negative numbers
        strFormula = strFormula.Replace("+-", "+#")
        strFormula = strFormula.Replace("--", "-#")
        strFormula = strFormula.Replace("*-", "*#")
        strFormula = strFormula.Replace("/-", "/#")
        strFormula = strFormula.Replace("^-", "^#")
        If strFormula.IndexOf("-") = 0 Then strFormula = "#" & strFormula.Substring(1)

        'Gets the amount of opening parentesis
        intQtdParOpen = 0
        intPos = strFormula.IndexOf("(")
        intPosParOpen = intPos
        Do While intPos > -1
            intQtdParOpen += 1
            intPos = strFormula.IndexOf("(", intPos + 1)
        Loop

        'Gets the amount of closing parentesis
        intQtdParClose = 0
        intPos = strFormula.IndexOf(")")
        intPosParClose = intPos
        Do While intPos > -1
            intQtdParClose += 1
            intPosParClose = intPos
            intPos = strFormula.IndexOf(")", intPos + 1)
        Loop

        'Check if the amount of parentesis are equal
        If intQtdParOpen <> intQtdParClose Then
            Throw New System.Exception("The amount of parentheses is different in the formula.")
        End If

        'Executes the formula
        If intPosParOpen > -1 Then
            strFormulaTemp = strFormula.Substring(intPosParOpen + 1, intPosParClose - intPosParOpen - 1)
            dblResultTemp = ExecuteFormula(strFormulaTemp)
            strFormulaTemp = strFormula.Replace("(" & strFormulaTemp & ")", dblResultTemp.ToString)
            Return ExecuteFormula(strFormulaTemp)
        ElseIf strFormula.IndexOf("+") > -1 Then
            'Addition
            intPos = strFormula.IndexOf("+")
            strOperator1 = strFormula.Substring(0, intPos)
            strOperator2 = strFormula.Substring(intPos + 1)
            Return ExecuteFormula(strOperator1) + ExecuteFormula(strOperator2)
        ElseIf strFormula.IndexOf("-") > -1 Then
            'Subtraction
            intPos = strFormula.IndexOf("-")
            strOperator1 = strFormula.Substring(0, intPos)
            strOperator2 = strFormula.Substring(intPos + 1)
            Return ExecuteFormula(strOperator1) - ExecuteFormula(strOperator2)
        ElseIf strFormula.IndexOf("*") > -1 Then
            'Multiplication
            intPos = strFormula.IndexOf("*")
            strOperator1 = strFormula.Substring(0, intPos)
            strOperator2 = strFormula.Substring(intPos + 1)
            Return ExecuteFormula(strOperator1) * ExecuteFormula(strOperator2)
        ElseIf strFormula.IndexOf("/") > -1 Then
            'Division
            intPos = strFormula.IndexOf("/")
            strOperator1 = strFormula.Substring(0, intPos)
            strOperator2 = strFormula.Substring(intPos + 1)
            Return ExecuteFormula(strOperator1) / ExecuteFormula(strOperator2)
        ElseIf strFormula.IndexOf("^") > -1 Then
            'Exponentiation
            intPos = strFormula.IndexOf("^")
            strOperator1 = strFormula.Substring(0, intPos)
            strOperator2 = strFormula.Substring(intPos + 1)
            Return ExecuteFormula(strOperator1) ^ ExecuteFormula(strOperator2)
        Else
            'Returns the negative numbers
            strFormula = strFormula.Replace("#", "-")
            'Check if the value is numeric
            If Not IsNumeric(strFormula) Then
                MsgBox("Erro no Calculo da Formula Verifique os Operadores e as Variaveis: (" + strFormula + ")", MsgBoxStyle.Critical)
                Return 0
            End If
            'Returns the value
            Return CDbl(strFormula)
        End If
    End Function

    'Public Shared Sub salvaNumeroNota(ByVal Amb As Integer, ByVal Serie As Integer)
    '    Dim dr As New FeedComponentes.dts123TableAdapters.TB_NOTA_NUMEROTableAdapter
    '    dr.AtualizaNumero(My.Forms.frmPadrao.IDEmpresa, Serie, Amb)
    'End Sub

    'Public Shared Sub salvaNumeroCTe(ByVal Amb As Integer, ByVal Serie As Integer)
    '    Dim dr As New FeedComponentes.dtsCTeTableAdapters.TB_CTE_NUMEROTableAdapter
    '    dr.AtualizaNumero(My.Forms.frmPadrao.IDEmpresa, Serie, Amb)
    'End Sub

    'Public Shared Function retornaNumeroCTe(ByVal Amb As Integer, ByVal Serie As Integer) As Double
    '    Dim dr As New FeedComponentes.dtsCTeTableAdapters.TB_CTE_NUMEROTableAdapter
    '    Return dr.RetornaNumero(My.Forms.frmPadrao.IDEmpresa, Serie, Amb)
    'End Function

    'Public Shared Sub salvaNumeroCTRC(ByVal Serie As Integer)
    '    Dim dr As New FeedComponentes.dtsFeedTranspGTableAdapters.TB_CTRC_NUMEROTableAdapter
    '    dr.AtualizaNumero(My.Forms.frmPadrao.IDEmpresa, Serie)
    'End Sub

    'Public Shared Sub salvaNumeroMinuta(ByVal Serie As Integer)
    '    Dim dr As New FeedComponentes.dtsFeedTranspGTableAdapters.TB_CTRC_MINUTA_NUMEROTableAdapter
    '    dr.AtualizaNota(My.Forms.frmPadrao.IDEmpresa, Serie)
    'End Sub

    Public Shared Function pesquisaNumeroNota(ByVal Amb As Integer, ByVal Serie As Integer, ByVal InsereNumero As Boolean) As Integer
        Dim ssql As String = ""
        ssql += "EXEC PesquisaNumero "
        ssql += My.Forms.frmPadrao.IDEmpresa.ToString() + ","
        ssql += Amb.ToString() + "," + Serie.ToString() & ", " & CInt(InsereNumero)
        Dim dt = fbConnection.executaSelect(ssql)
        Dim i = dt.Rows(0).Item(0)
        Return i
    End Function


    Public Shared Function pesquisaNumeroCTRC(ByVal Serie As Integer) As Integer
        Dim ssql As String = ""
        ssql += " EXEC PesquisaNumeroCTRC "
        ssql += My.Forms.frmPadrao.IDEmpresa.ToString() + "," + Serie.ToString()
        Dim dt = fbConnection.executaSelect(ssql)
        Dim i = dt.Rows(0).Item(0)
        Return i
    End Function

    Public Shared Function pesquisaNumeroMinuta() As Integer
        Dim ssql As String = ""
        ssql += "EXEC PesquisaNumeroMinuta "
        ssql += My.Forms.frmPadrao.IDEmpresa.ToString()
        Dim dt = fbConnection.executaSelect(ssql)
        Dim i = dt.Rows(0).Item(0)
        Return i
    End Function

    Public Shared Function pesquisaNumeroCTe(ByVal Amb As Integer, ByVal Serie As Integer) As Integer
        Dim ssql As String = ""
        ssql += "EXEC PesquisaNumeroCTe "
        ssql += My.Forms.frmPadrao.IDEmpresa.ToString() + ","
        ssql += Amb.ToString() + "," + Serie.ToString()
        Dim dt = fbConnection.executaSelect(ssql)
        Dim i = dt.Rows(0).Item(0)
        Return i
    End Function

    Public Shared Function retornaPastaNFe() As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select TOP 1 pasta FROM TB_NOTA_CONFIGURACAO WHERE IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function retornaPastaCTe() As String
        Dim bt As String = ""
        Dim dt = fbConnection.executaSelect("select TOP 1 pasta FROM TB_CTE_CONFIGURACAO WHERE IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

End Class
