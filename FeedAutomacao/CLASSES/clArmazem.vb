Public Class clArmazem

    Public Shared Function buscaCorredor(ByVal idQuadra As Integer) As Integer
        Dim id As Nullable(Of Integer)
        id = fbConnection.retornaValorUnico("select IDCorredor from TB_LOC_QUADRA WHERE ID = " + idQuadra.ToString())
        If id.HasValue Then
            Return id.Value
        Else
            Return -1
        End If
    End Function

    Public Shared Function buscaGalpao(ByVal idCorredor As Integer) As String
        Dim id As Nullable(Of Integer)
        id = fbConnection.retornaValorUnico("select IDGalpao from TB_LOC_CORREDOR WHERE ID = " + idCorredor.ToString())
        If id.HasValue Then
            Return id.Value
        Else
            Return -1
        End If
    End Function

    Public Shared Function retornaPesoUnidade() As Double
        Dim val As Double = 60
        Dim ssql As String = ""
        ssql = "select (valorKG+valorEmbKG) FROM TB_UNIDADE WHERE ID IN "
        ssql += "(SELECT TOP 1 IDUnidadeSaca from tb_CONF_ARMAZEM WHERE IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString() + ")"
        Dim dt As DataTable = fbConnection.executaSelect(ssql)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            val = dt.Rows(0).Item(0)
        End If
        Return val
    End Function

    Public Shared Function buscaArmazem(ByVal idGalpao As Integer) As String
        Dim id As Nullable(Of Integer)
        id = fbConnection.retornaValorUnico("select IDArmazem from TB_LOC_GALPAO WHERE ID = " + idGalpao.ToString())
        If id.HasValue Then
            Return id.Value
        Else
            Return -1
        End If
    End Function

    Public Shared Function buscaNumGE(ByVal ID As Integer) As String
        Dim str As String
        str = fbConnection.retornaValorUnico("select Numero from TB_GSBX WHERE ID = " + ID.ToString())
        Return str
    End Function

    'Public Shared Function retornaValorTabela(ByVal IDServico As Integer, _
    '                                          ByVal idDomicilio As Integer, _
    '                                          Optional ByVal IDLote As Integer = -1) As Double
    '    Dim bt As Double = 0
    '    Dim dr As New dtsArmazemSQLTableAdapters.QueriesTableAdapter
    '    bt = dr.retornaTabServ(IDServico, idDomicilio, My.Forms.frmPadrao.IDEmpresa, IDLote)
    '    Return bt
    'End Function

    Public Shared Function buscaValorServ(ByVal ID As Integer) As Double
        Dim bt As Double = 0
        Dim dt = fbConnection.executaSelect("select valor from TB_ITEM WHERE ID = " + ID.ToString())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0).Item(0)) Then
            bt = dt.Rows(0).Item(0)
        End If
        Return bt
    End Function

    Public Shared Function verificaCorredor(ByVal idGalpao As Integer, ByVal idArmazem As Integer, ByVal Nome As String, ByVal IDSel As Integer) As Boolean
        Dim IDCor As Nullable(Of Integer) = fbConnection.retornaValorUnico("select ID from TB_LOC_CORREDOR WHERE Nome LIKE '" + Nome + "' AND IDGalpao = " + idGalpao.ToString())
        If IDCor IsNot Nothing Then
            Dim IDGal As Nullable(Of Integer) = fbConnection.retornaValorUnico("select ID from TB_LOC_GALPAO WHERE IDArmazem = " + idArmazem.ToString())
            If IDGal IsNot Nothing Then
                If IDSel = IDCor Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Public Shared Function verificaGalpao(ByVal idArmazem As Integer, ByVal Nome As String, ByVal IDSel As Integer) As Boolean
        Dim IDGal As Nullable(Of Integer) = fbConnection.retornaValorUnico("select ID from TB_LOC_GALPAO WHERE Nome LIKE '" + Nome + "' AND IDArmazem = " + idArmazem.ToString())
        If IDGal IsNot Nothing Then
            If IDSel = IDGal Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Public Shared Function verificaQuadra(ByVal idCorredor As Integer, ByVal idArmazem As Integer, ByVal idGalpao As Integer, ByVal Nome As String, ByVal IDSel As Integer) As Boolean
        Dim IDqd As Nullable(Of Integer) = fbConnection.retornaValorUnico("select ID from TB_LOC_QUADRA WHERE Nome LIKE '" + Nome + "' AND IDCorredor = " + idCorredor.ToString())
        If IDqd IsNot Nothing Then
            Dim IDCor As Nullable(Of Integer) = fbConnection.retornaValorUnico("select ID from TB_LOC_CORREDOR WHERE IDGalpao = " + idGalpao.ToString())
            If IDCor IsNot Nothing Then
                Dim IDGal As Nullable(Of Integer) = fbConnection.retornaValorUnico("select ID from TB_LOC_GALPAO WHERE IDArmazem = " + idArmazem.ToString())
                If IDGal IsNot Nothing Then
                    If IDSel = IDqd Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return True
                End If
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Public Shared Function verificaArmazem(ByVal Nome As String, ByVal IDSel As Integer) As Boolean
        Dim IDArm As Nullable(Of Integer) = fbConnection.retornaValorUnico("select ID from TB_ARMAZEM WHERE Nome LIKE '" + Nome + "' and IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString())
        If IDArm IsNot Nothing Then
            If IDSel = IDArm Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    'Public Shared Sub verificaSacas(ByVal _peso As Double, ByVal _qtd As Double, _
    '                          ByVal _IDUnidade As Integer, _
    '                          ByVal txtVol As fbNumericBox, _
    '                          ByVal txtPesoLiq As fbNumericBox)
    '    If _peso <> 0 AndAlso _qtd <> 0 AndAlso _IDUnidade <> -1 Then
    '        Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.calculaUnidadeArmTableAdapter

    '        Dim dt = dr.GetData(_IDUnidade, My.Forms.frmPadrao.IDEmpresa, _
    '                   _qtd, _peso, My.Forms.frmPadrao.TruncarVol)
    '        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
    '            If Not IsDBNull(dt.Rows(0).Item("totSacas")) Then
    '                Dim v As Double = dt.Rows(0).Item("totSacas")
    '                If My.Forms.frmPadrao.volumeComQuebra = False Then
    '                    If My.Forms.frmPadrao.volumeSomenteInt = False Then
    '                        'txtVol.Text = v
    '                        If txtVol.Text.Contains(",") Then
    '                            If CDec(txtVol.Text.Substring(txtVol.Text.IndexOf(","), 2)) >= 0.5 Then
    '                                v = RoundUpperInteger(v)
    '                            Else
    '                                v = Math.Floor(v)
    '                                If v = 0 Then
    '                                    v = 1
    '                                End If
    '                            End If
    '                        End If
    '                    Else
    '                        v = Math.Round(v)
    '                    End If
    '                End If
    '                If txtVol.Focused = False Then txtVol.Text = v
    '            Else
    '                txtVol.Text = 0
    '            End If
    '            If Not IsDBNull(dt.Rows(0).Item("PesoReal")) Then
    '                txtPesoLiq.Text = dt.Rows(0).Item("PesoReal")
    '            Else
    '                txtPesoLiq.Text = 0
    '            End If
    '        Else
    '            txtVol.Text = 0
    '            txtPesoLiq.Text = 0
    '        End If
    '    Else
    '        txtVol.Text = 0
    '        txtPesoLiq.Text = 0
    '    End If
    'End Sub

    'Public Shared Sub verificaSacasPesoL(ByVal _peso As Double, ByVal _qtd As Double, _
    '                         ByVal _IDUnidade As Integer, _
    '                         ByVal txtPesoLiq As fbNumericBox)
    '    If _peso <> 0 AndAlso _qtd <> 0 AndAlso _IDUnidade <> -1 Then
    '        Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.calculaUnidadeArmTableAdapter

    '        Dim dt = dr.GetData(_IDUnidade, My.Forms.frmPadrao.IDEmpresa, _
    '                   _qtd, _peso, My.Forms.frmPadrao.TruncarVol)
    '        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
    '            If Not IsDBNull(dt.Rows(0).Item("PesoReal")) Then
    '                txtPesoLiq.Text = dt.Rows(0).Item("PesoReal")
    '            Else
    '                txtPesoLiq.Text = 0
    '            End If
    '        Else
    '            txtPesoLiq.Text = 0
    '        End If
    '    Else
    '        txtPesoLiq.Text = 0
    '    End If
    'End Sub

    'Public Shared Function verificaSacasPesoL(ByVal _peso As Double, ByVal _qtd As Double, _
    '                         ByVal _IDUnidade As Integer)
    '    Dim PesoLiq As Decimal
    '    If _peso <> 0 AndAlso _qtd <> 0 AndAlso _IDUnidade <> -1 Then
    '        Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.calculaUnidadeArmTableAdapter

    '        Dim dt = dr.GetData(_IDUnidade, My.Forms.frmPadrao.IDEmpresa, _
    '                   _qtd, _peso, My.Forms.frmPadrao.TruncarVol)
    '        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
    '            If Not IsDBNull(dt.Rows(0).Item("PesoReal")) Then
    '                PesoLiq = dt.Rows(0).Item("PesoReal")
    '            Else
    '                PesoLiq = 0
    '            End If
    '        Else
    '            PesoLiq = 0
    '        End If
    '    Else
    '        PesoLiq = 0
    '    End If
    '    Return PesoLiq
    'End Function

    'Public Shared Function verificaSacas(ByVal _peso As Double, ByVal _qtd As Double, _
    '                          ByVal _IDUnidade As Integer, _
    '                          vol As Double, _
    '                          pesoLiq As Double) As List(Of Double)

    '    Dim dblArray As New List(Of Double)
    '    If _peso <> 0 AndAlso _qtd <> 0 AndAlso _IDUnidade <> -1 Then
    '        Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.calculaUnidadeArmTableAdapter

    '        Dim dt = dr.GetData(_IDUnidade, My.Forms.frmPadrao.IDEmpresa, _
    '                   _qtd, _peso, My.Forms.frmPadrao.TruncarVol)
    '        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
    '            If Not IsDBNull(dt.Rows(0).Item("totSacas")) Then
    '                Dim totScs As Double = dt.Rows(0).Item("totSacas")
    '                If My.Forms.frmPadrao.volumeComQuebra = False Then
    '                    Dim str As String = totScs.ToString()
    '                    If str.Contains(".") Then
    '                        If CDec(str.Substring(str.IndexOf("."), 2)) >= 0.5 Then
    '                            totScs = RoundUpperInteger(totScs)
    '                        Else
    '                            totScs = Math.Floor(totScs)
    '                            If totScs = 0 Then
    '                                totScs = 1
    '                            End If
    '                            vol = totScs
    '                        End If
    '                    Else
    '                        vol = totScs
    '                    End If
    '                End If
    '            End If
    '            'If Not IsDBNull(dt.Rows(0).Item("totSacas")) Then
    '            '    Dim v As Double = dt.Rows(0).Item("totSacas")
    '            '    If My.Forms.frmPadrao.volumeComQuebra = False Then v = RoundUpperInteger(v)
    '            '    vol = v
    '            'Else
    '            '    vol = 0
    '            'End If
    '            If Not IsDBNull(dt.Rows(0).Item("PesoReal")) Then
    '                pesoLiq = dt.Rows(0).Item("PesoReal")
    '            Else
    '                pesoLiq = 0
    '            End If
    '        Else
    '            vol = 0
    '            pesoLiq = 0
    '        End If
    '    Else
    '        vol = 0
    '        pesoLiq = 0
    '    End If
    '    dblArray.Add(vol)
    '    dblArray.Add(pesoLiq)
    '    Return dblArray
    'End Function

    Public Shared Function calcMediaPeso(ByVal Und As Integer, ByVal Qtd As Decimal) As Decimal
        Dim sql = "SELECT (valorKG+valorEmbKG) FROM TB_UNIDADE WHERE ID = " + Und.ToString()
        Try
            Dim x = fbConnection.retornaValorUnico(sql)
            Dim peso As Nullable(Of Decimal) = x 'fbConnection.retornaValorUnico(sql)
            If peso.HasValue AndAlso peso.Value <> 0 Then
                peso = peso.Value * Qtd
                Return peso.Value
            Else
                Return 0
            End If
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function calcMediaPesoPL(ByVal Und As Integer, ByVal Qtd As Double, ByVal PESOL As Double) As Decimal
        Dim sql = "SELECT valorEmbKG FROM TB_UNIDADE WHERE ID = " + Und.ToString()
        Try
            Dim x = fbConnection.retornaValorUnico(sql)
            Dim peso As Nullable(Of Decimal) = x 'fbConnection.retornaValorUnico(sql)
            If peso.HasValue AndAlso peso.Value <> 0 Then
                peso = (peso.Value * Qtd) + PESOL
                Return peso.Value
            Else
                ''fazer mod para retornar o peso liq caso o peso da embalagem seja 0
                Return PESOL
            End If
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function calcPesoLiq(ByVal IDUnd As Integer, ByVal Vol As Double, ByVal Peso As Double) As Decimal
        Dim sql = "SELECT valorEmbKG FROM TB_UNIDADE WHERE ID = " + IDUnd.ToString()
        Try
            Dim vrlEmb As Nullable(Of Decimal) = fbConnection.retornaValorUnico(sql)
            If vrlEmb.HasValue AndAlso vrlEmb.Value <> 0 Then
                Return (Peso - (vrlEmb.Value * Vol))
            Else
                ''fazer mod para retornar o peso liq caso o peso da embalagem seja 0
                Return Peso
            End If
        Catch
            Return 0
        End Try
    End Function


    'Public Shared Function verificaVolumeScs(ByVal _peso As Double, ByVal _IDUnidade As Integer) As Decimal
    '    Dim Vol As Decimal = 0
    '    If _peso > 0 AndAlso _IDUnidade <> -1 Then
    '        Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.QueriesTableAdapter
    '        Vol = dr.calculaVolume(_IDUnidade, My.Forms.frmPadrao.IDEmpresa, _peso, My.Forms.frmPadrao.TruncarVol)
    '    End If
    '    Return Vol
    'End Function

    'Public Shared Function verificaQtdPeso(ByVal _Volume As Double, ByVal _IDUnidade As Integer) As List(Of Decimal)
    '    Dim list As New List(Of Decimal)
    '    If _Volume > 0 AndAlso _IDUnidade <> -1 Then
    '        Dim sql = "SELECT valorKG, valorEmbKG FROM TB_UNIDADE WHERE ID = " + _IDUnidade.ToString()
    '        Dim dtLoc As DataTable
    '        Dim peso As Decimal
    '        Dim pesoLiq As Decimal
    '        Dim qtdEmb As Decimal
    '        'Dim str As String
    '        Try
    '            dtLoc = fbConnection.executaSelect(sql)
    '            If dtLoc IsNot Nothing AndAlso dtLoc.Rows.Count > 0 Then
    '                pesoLiq = _Volume * 60
    '                'peso =  peso
    '                qtdEmb = (pesoLiq / CDec(dtLoc.Rows(0).Item(0)))
    '                'str = qtdEmb.ToString()
    '                'If str.Contains(",") Then
    '                'If CDec(str.Substring(str.IndexOf(","), 2)) >= 0.5 Then
    '                qtdEmb = RoundUpperInteger(qtdEmb)
    '                'Else
    '                '    qtdEmb = Math.Floor(qtdEmb)
    '                '    If qtdEmb = 0 Then
    '                '        qtdEmb = 1
    '                '    End If
    '                'End If
    '                'End If
    '                peso = pesoLiq + (qtdEmb * CDec(dtLoc.Rows(0).Item(1)))
    '                list.Add(peso)
    '                list.Add(pesoLiq)
    '                list.Add(qtdEmb)

    '                Return list
    '            End If
    '        Catch ex As SqlClient.SqlException
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    '    End If
    '    list.Add(0)
    '    list.Add(0)
    '    list.Add(0)

    '    Return list
    'End Function

    Public Shared Function retornaUnidadeBagPadrao() As Integer
        Dim sql = "SELECT TOP 1 IDUnidadeBagPadrao FROM TB_CONF_ARMAZEM WHERE IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString()
        Try
            Dim x = fbConnection.retornaValorUnico(sql)
            Dim val As Nullable(Of Integer) = x
            If val.HasValue Then
                Return val
            Else
                Return -1
            End If
        Catch
            Return -1
        End Try
    End Function

    Public Shared Function retornaPesoUnidadeComEmb(ByVal IDUnidade As Integer, ByVal Qtd As Integer) As Double
        Dim sql = "SELECT (valorKG+valorEmbKG) FROM TB_UNIDADE WHERE ID = " + IDUnidade.ToString()
        Dim peso As Decimal
        Try
            peso = (fbConnection.retornaValorUnico(sql) * Qtd)
            If peso > 0 Then
                Return peso
            Else
                Return 0
            End If
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function retornaPesoUnidade(IDUnidade As Integer) As Double
        Dim sql = "SELECT valorKG FROM TB_UNIDADE WHERE ID = " + IDUnidade.ToString()
        Try
            Dim x = fbConnection.retornaValorUnico(sql)
            Dim peso As Nullable(Of Decimal) = x
            If peso.HasValue AndAlso peso.Value <> 0 Then
                Return peso.Value
            Else
                Return 1
            End If
        Catch
            Return 1
        End Try
    End Function

    Public Shared Function calcMediaPesoBalanca(ByVal totQtd As Integer, totPeso As Double,
                                                ByVal Qtd As Integer) As Decimal
        Dim ret As Double = 0
        If totQtd > 0 AndAlso totPeso > 0 Then
            ret = ((Qtd * totPeso) / totQtd)
        End If
        Return ret
    End Function

    Public Shared Function calcMediaPesoBalanca(ByVal totQtd As Double, totPeso As Double,
                                                ByVal Qtd As Double) As Double
        Dim ret As Double = 0
        If totQtd > 0 AndAlso totPeso > 0 Then
            ret = ((Qtd * totPeso) / totQtd)
        End If
        Return ret
    End Function

    Public Shared Function calcMediaPesoUnidadePadrao(ByVal Qtd As Integer) As Decimal
        Dim sql = "SELECT (valorKG+valorEmbKG) FROM TB_UNIDADE WHERE ID = " +
                  "(SELECT TOP 1 IDUNIDADESACA FROM TB_CONF_ARMAZEM WHERE IDEMPRESA = " +
                  My.Forms.frmPadrao.IDEmpresa.ToString() + ")"
        Dim peso As Nullable(Of Decimal) = fbConnection.retornaValorUnico(sql)
        If peso.HasValue AndAlso peso.Value <> 0 Then
            peso = peso.Value * Qtd
            Return peso.Value
        Else
            Return 0
        End If
    End Function

    Public Shared Sub atualizaGE(ByVal Peso As Double, ByVal Vol As Double,
                                 ByVal PesoL As Double, ByVal ID As Integer)
        Dim ssql As String = ""
        ssql += " UPDATE TB_GCI SET VOLUME = " + Vol.ToString().Replace(",", ".") +
                ", PESO = " + Peso.ToString().Replace(",", ".") + ", PESOLIQUIDO = " + PesoL.ToString().Replace(",", ".")
        ssql += " WHERE ID = " + ID.ToString() + " AND status <> 1"
        fbConnection.executaCommand(ssql)
    End Sub

    Public Shared Function verificaCert(ByVal idCert As Integer, ByVal IDDomicilio As Integer) As Boolean
        Dim idCer As Nullable(Of Integer) = fbConnection.retornaValorUnico("select ID from TB_DOMICILIO_CERTIFICACAO WHERE IDCertificacao = " + idCert.ToString() + " AND IDDomicilio = " + IDDomicilio.ToString())
        If idCer IsNot Nothing Then
            MsgBox("A Certificação Já Está Inserida Neste Domicílio!", MsgBoxStyle.Information, "Aviso")
            Return False
        Else
            Return True
        End If
    End Function

    'Public Shared Function validaSaldoWarrant(ByVal IDProdutor As Integer, _
    '                                          ByVal IdLoteLocalizacao As Integer, _
    '                                          ByVal ID As Integer) As clRetornoValidacaoWarrant
    '    Dim ret As New clRetornoValidacaoWarrant

    '    Dim qry As New FeedComponentes.dtsArmazemValidacaoTableAdapters.QueriesTableAdapter
    '    Dim valret As Double = qry.ValidaSaldoWarrant(IDProdutor, IdLoteLocalizacao)

    '    If valret = -1 Or valret = -333 Then
    '        ret.Valida = True
    '        ret.Quantidade = 0
    '    ElseIf valret = 0 Then
    '        ret.Valida = False
    '        ret.Quantidade = 0
    '        If ID = -1 Then
    '            MsgBox("O Lote não pode Ser Utilizado pois a Quantidade Máxima do Produtor Está Warrantada!", MsgBoxStyle.Exclamation)
    '        End If
    '    Else
    '        ret.Valida = True
    '        ret.Quantidade = valret
    '    End If
    '        Return ret
    'End Function

    Public Shared Function validaSaldoWarQtd(ByVal IDProdutor As Integer, ByVal QtdRet As Integer,
                                                  Optional ByVal ID As Integer = -1, Optional ByVal QtdExist As Integer = 0) As Boolean
        Dim sql = "SELECT SALDO FROM TB_WARRANT_QTD WHERE IDPESSOA = " + IDProdutor.ToString()
        Dim saldo As Nullable(Of Integer) = fbConnection.retornaValorUnico(sql)
        If saldo.HasValue Then
            sql = "SELECT SUM(VOLUME) FROM TB_LOTE_LOCALIZACAO where IDLote IN (select ID from TB_LOTE where IDDomicilio IN (select ID from TB_DOMICILIO where IDPessoa IN (select ID from TB_PESSOA where ID = " + IDProdutor.ToString() + ")))"
            Dim total = fbConnection.retornaValorUnico(sql)
            If total IsNot Nothing Then
                Dim resTotal As Integer
                If ID = -1 Then
                    resTotal = (total - QtdRet)
                Else
                    resTotal = ((total - QtdRet) + QtdExist)
                End If
                If resTotal >= saldo.Value Then
                    Return True
                Else
                    resTotal = (total - saldo.Value)
                    If resTotal > 0 Then
                        MsgBox("A Quantidade Máxima Permitida para o Produtor é de " + resTotal.ToString() + "!" + vbCrLf + "A Quantidade Restante se Econtra em Warrant Atualmente!", MsgBoxStyle.Information, "Aviso")
                        Return False
                    Else
                        MsgBox("Não Há Saldo Disponível para este Produtor!" + vbCrLf + "A Quantidade Restante se Econtra em Warrant Atualmente!", MsgBoxStyle.Information, "Aviso")
                        Return False
                    End If
                End If
            End If
        End If
        Return True
    End Function

    Public Shared Function BuscarLote(ByVal Lote As String) As String
        If Lote <> "" Then
            If Lote.Length > 2 Then
                Dim sql, numLote, codLote As String
                codLote = Lote.Substring(0, 2)
                If IsNumeric(codLote.Substring(0)) OrElse IsNumeric(codLote.Substring(1)) Then
                    Return ""
                End If
                numLote = Lote.Substring(2)
                If numLote.Contains("/") Then
                    Dim tam As String = ""
                    Dim numTemp As String
                    numTemp = numLote.Substring(0, numLote.IndexOf("/"))
                    While numTemp.Length + tam.Length < 8
                        tam += "0"
                    End While
                    numLote = tam + numLote
                ElseIf codLote.Contains("T") Then
                    Dim tam As String = ""
                    Dim numTemp As String
                    numTemp = numLote.Substring(0)
                    While numTemp.Length + tam.Length < 8
                        tam += "0"
                    End While
                    numLote = tam + numLote
                Else
                    MsgBox("Lote Inválido ou não Especificado!", MsgBoxStyle.Information, "Aviso")
                    Return ""
                End If
                sql = "SELECT ID,volume,Peso,Quantidade,data,NUMERO FROM TB_LOTE WHERE NUMERO LIKE '%" + codLote + "%' AND NUMERO LIKE '%" + numLote + "'"
                Return sql
                'Dim dadosLote As DataTable = fbConnection.executaSelect(sql)
                'If dadosLote IsNot Nothing AndAlso dadosLote.Rows.Count > 0 Then
                '    Dim lista As New List(Of String)
                '    lista.Add(dadosLote.Rows(0).Item("Peso"))
                '    lista.Add(dadosLote.Rows(0).Item("volume"))
                '    lista.Add(dadosLote.Rows(0).Item("ID"))
                '    lista.Add(dadosLote.Rows(0).Item("data"))
                '    lista.Add(dadosLote.Rows(0).Item("Numero"))
                '    Return lista
                'Else
                '    MsgBox("Lote não Encontrado!", MsgBoxStyle.Information, "Aviso")
                '    Return ""
                'End If
            Else
                Return ""
            End If
        End If
        Return ""
    End Function

    'Public Shared Function retornaNumTitulo() As String
    '    Dim str As String = ""
    '    Dim dr As New FeedComponentes.dtsTranspFaturamentoTableAdapters.QueriesTableAdapter
    '    str = dr.PesquisaConfTransFatuTiutNum(My.Forms.frmPadrao.IDEmpresa)
    '    Return str
    'End Function

    '    Public Shared Function retornaNumTituloReq() As String
    '        Dim str As String = ""
    '        Dim dr As New FeedComponentes.dtsFinanceiroTableAdapters.QueriesTableAdapter
    '        str = dr.PesquisaFatuTituloNumReq(My.Forms.frmPadrao.IDEmpresa)
    '        Return str
    '    End Function

End Class

Public Class clRetornoValidacaoWarrant

    Dim libera As Boolean = False
    Public Property Valida() As Boolean
        Get
            Return libera
        End Get
        Set(ByVal value As Boolean)
            libera = value
        End Set
    End Property

    Dim qtd As Double = 0
    Public Property Quantidade() As Double
        Get
            Return qtd
        End Get
        Set(ByVal value As Double)
            qtd = value
        End Set
    End Property
End Class

