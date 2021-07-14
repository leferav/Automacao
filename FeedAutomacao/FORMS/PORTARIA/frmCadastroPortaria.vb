Public Class frmCadastroPortaria

    Dim dt As dtsTabelas.TB_PORTARIADataTable
    Dim dr As New dtsTabelasTableAdapters.TB_PORTARIATableAdapter
    Dim row As dtsTabelas.TB_PORTARIARow
    Public IDGuia As Integer = -1
    Public edt As Boolean = False
    Private idTransp As Integer = -1
    Private IDTipoMot As Integer
    Private IDTipoGeral As Integer
    Private IDTipoProd As Integer
    Private msg As Boolean = True

    Public Overrides Function Limpar() As Boolean
        setaForm()
        edt = False
        dtDataSaida.Enabled = False
        dtDataSaida.Checked = False
        cbbGuia.Enabled = False
        txtQtd.Text = 0
        txtTiket.Text = 0
        txtLote.Text = ""
        txtObservacao.Clear()
        lblstatus.Text = "EM DIGITAÇÃO"
        txtPeso1.Text = 0
        txtPeso2.Text = 0
        txtPeso.Text = 0
        txtPesoL.Text = 0
        txtVolume.Text = 0
        dtDataEntrada.Value = Date.Now
        dtDataPesagem1.Value = Date.Now
        dtDataPesagem2.Value = Date.Now
        dtOrdemPesagem.Value = Date.Now
        dtLiberarPesagem.Value = Date.Now
        dtAgendamento.Value = Date.Now
        dtFaturamento.Value = Date.Now
        dtDataSaida.Value = Date.Now
        dtOrdemPesagem.Checked = False
        dtLiberarPesagem.Checked = False
        dtAgendamento.Checked = False
        dtFaturamento.Checked = False
        dtDataEntrada.Checked = False
        dtDataPesagem1.Checked = False
        dtDataPesagem2.Checked = False
        dtDataSaida.Checked = False
        'dgvNota.IDRelacionamento = -1
        'dgvNota.DataTable = Nothing
        cbbGuia.ValorSelecionado = -1
        cbbTipo.ValorSelecionado = -1
        lkpOrigem.Enabled = True
        idTransp = fbConnection.retornaValorUnico("SELECT IDTRANSPORTADORA FROM TB_CONF_ARMAZEM WHERE IDEMPRESA = " + My.Forms.frmPadrao.IDEmpresa.ToString())
        cbbTransportadora.ValorSelecionado = idTransp
        cbbUnidade.ValorSelecionado = -1
        lkpMotorista.SelectID = -1
        lkpProduto.SelectID = -1
        lkpProdutor.SelectID = -1
        lkpVeiculo.SelectID = -1
        lkpOrigem.SelectID = -1
        txtPesoLiqPeso.Text = 0
        cbbTAG.ValorSelecionado = -1
        If IDGuia <> -1 Then
            Dim ssql As String = "SELECT IDDomicilio, IDVeiculo, Data, Quantidade, Peso from TB_GSBX WHERE ID = " + IDGuia.ToString()
            Dim dt As DataTable = fbConnection.executaSelect(ssql)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                lkpProdutor.SelectID = dt.Rows(0).Item("IDDomicilio")
                cbbGuia.ValorSelecionado = IDGuia
                cbbTipo.ValorSelecionado = "1"
                If Not IsDBNull(dt.Rows(0).Item("IDVeiculo")) Then lkpVeiculo.SelectID = dt.Rows(0).Item("IDVeiculo")
                If Not IsDBNull(dt.Rows(0).Item("Data")) Then dtDataSaida.Value = dt.Rows(0).Item("Data")
                'If Not IsDBNull(dt.Rows(0).Item("Quantidade")) Then txtQtd.Text = dt.Rows(0).Item("Quantidade")
                If Not IsDBNull(dt.Rows(0).Item("Peso")) Then txtPeso2.Text = dt.Rows(0).Item("Peso")
            End If
        End If
        lkpVeiculo.Focus()
        'dgvCert.DataSource = Nothing
        Return MyBase.Limpar()

    End Function

    Public Sub setaForm()
        lkpMotorista.FormularioPesquisa = frmPesquisaPessoa
        lkpVeiculo.FormularioPesquisa = frmPesquisaVeiculo
        lkpProdutor.FormularioPesquisa = frmPesquisaDomicilio
        lkpProduto.FormularioPesquisa = frmPesquisaItem2
        lkpOrigem.FormularioPesquisa = frmPesquisaDomicilio
        cbbTulha.FormularioPesquisa = frmPesquisaTulha
        'dgvNota.Formulario = frmTicketNota
        cbbUnidade.Filtro = "IDEmpresa = -1 or IDEmpresa = " & My.Forms.frmPadrao.IDEmpresa
    End Sub

    Public Overrides Function Editar(ByVal IDSel As Integer) As Boolean
        If IDGuia <> -1 AndAlso IDSel <> -1 Then
            ID = IDSel
            dt = dr.GetDataByIDGE(IDGuia)
            row = dt.FindByID(IDSel)
        ElseIf IDSel <> -1 Then
            ID = IDSel
            dt = dr.GetDataByIDPortaria(IDSel)
            row = dt.FindByID(IDSel)
        Else
            MsgBox("Selecione um Registro para Carregar!", MsgBoxStyle.Critical)
        End If

        If row IsNot Nothing Then
            setaForm()
            edt = True
            'cbbTipo.ValorSelecionado = -1 
            lkpVeiculo.SelectID = row.IDVeiculo
            lkpMotorista.SelectID = row.IDMotorista
            lkpProdutor.SelectID = row.IDDomicilio

            If row.IsLOTENull = False Then
                txtLote.Text = row.LOTE
            Else
                txtLote.Text = ""
            End If

            If row.IsTipoPortariaNull = False Then
                If row.TipoPortaria = 0 Then
                    rbEntrada.Checked = True
                    txtLote.Enabled = False
                    txtLote.Text = ""
                ElseIf row.TipoPortaria = 1 Then
                    rbAgendamento.Checked = True
                    txtLote.Enabled = False
                    txtLote.Text = ""
                ElseIf row.TipoPortaria = 2 Then
                    rbSolicitacao.Checked = True
                    txtLote.Enabled = True
                    If row.IsLOTENull = False Then
                        txtLote.Text = row.LOTE
                    Else
                        txtLote.Text = ""
                    End If
                Else
                    rbEntrada.Checked = True
                    txtLote.Enabled = False
                    txtLote.Text = ""
                End If
            Else
                rbEntrada.Checked = True
                txtLote.Enabled = False
                txtLote.Text = ""
            End If

            lblstatus.Text = ""
            If row.Status = 0 Then
                lblstatus.Text = "ENTROU"
                lblstatus.Tag = 0
            ElseIf row.Status = 1 Then
                lblstatus.Text = "PESAGEM LIBERADA"
                lblstatus.Tag = 1
            ElseIf row.Status = 2 Then
                lblstatus.Text = "ORDEM DE PESAGEM"
                lblstatus.Tag = 2
            ElseIf row.Status = 3 Then
                lblstatus.Text = "PRIMEIRA PESAGEM"
                lblstatus.Tag = 3
            ElseIf row.Status = 4 Then
                lblstatus.Text = "SEGUNDA PESAGEM"
                lblstatus.Tag = 4
            ElseIf row.Status = 5 Then
                lblstatus.Text = "SAIU"
                lblstatus.Tag = 5
            ElseIf row.Status = 6 Then
                lblstatus.Text = "LIBERADO PARA BUSCAR"
                lblstatus.Tag = 6
            ElseIf row.Status = 7 Then
                lblstatus.Text = "AGENDADO"
                lblstatus.Tag = 7
            ElseIf row.Status = 8 Then
                lblstatus.Text = "SOLICITADO"
                lblstatus.Tag = 8
            ElseIf row.Status = 9 Then
                lblstatus.Text = "FATURADO"
                lblstatus.Tag = 9
            ElseIf row.Status = 10 Then
                lblstatus.Text = "CANCELADO"
                lblstatus.Tag = 10
            End If

            If row.Status = 1 Then
                dtLiberarPesagem.Enabled = False
                dtLiberarPesagem.Checked = True
            ElseIf row.Status = 2 Then
                dtLiberarPesagem.Enabled = False
                dtLiberarPesagem.Checked = True
                dtOrdemPesagem.Enabled = False
                dtOrdemPesagem.Checked = True
            ElseIf row.Status = 3 Then
                dtLiberarPesagem.Enabled = False
                dtLiberarPesagem.Checked = True
                dtOrdemPesagem.Enabled = False
                dtOrdemPesagem.Checked = True
                dtDataPesagem1.Enabled = False
                dtDataPesagem1.Checked = True
            ElseIf row.Status = 4 Then
                dtLiberarPesagem.Enabled = False
                dtLiberarPesagem.Checked = True
                dtOrdemPesagem.Enabled = False
                dtOrdemPesagem.Checked = True
                dtDataPesagem1.Enabled = False
                dtDataPesagem1.Checked = True
                dtDataPesagem2.Enabled = False
                dtDataPesagem2.Checked = True
            ElseIf row.Status = 5 Then
                dtLiberarPesagem.Enabled = False
                dtLiberarPesagem.Checked = True
                dtOrdemPesagem.Enabled = False
                dtOrdemPesagem.Checked = True
                dtDataPesagem1.Enabled = False
                dtDataPesagem1.Checked = True
                dtDataPesagem2.Enabled = False
                dtDataPesagem2.Checked = True
                dtDataSaida.Enabled = False
                dtDataSaida.Checked = True
            End If

            If row.IsIDTagNull = False Then
                cbbTAG.ValorSelecionado = row.IDTag
            Else
                cbbTAG.ValorSelecionado = -1
            End If

            If row.IsIDTulhaNull = False Then
                cbbTulha.SelectID = row.IDTulha
            Else
                cbbTulha.SelectID = -1
            End If

            If row.Status >= 3 Then
                txtPesoLiqPeso.Text = Math.Abs((txtPeso1.Text - txtPeso2.Text))
            Else
                txtPesoLiqPeso.Text = 0
            End If

            If row.IsDestinoNull = False Then
                row.Observacao += vbCrLf + "Destino: " + row.Destino
            End If

            If row.IsIDUnidadeNull = False Then
                cbbUnidade.ValorSelecionado = row.IDUnidade
            Else
                cbbUnidade.ValorSelecionado = -1
            End If
            If row.IsIDTiketNull = False Then
                txtTiket.Text = row.IDTiket
            Else
                txtTiket.Text = 0
            End If
            dtDataEntrada.Value = row.DataEntrada
            cbbTipo.ValorSelecionado = row.Tipo

            txtObservacao.Text = row.Observacao
            If row.IsOrigemNull = False AndAlso row.Origem <> "" AndAlso row.Observacao.Contains("Origem") = False Then
                txtObservacao.Text += vbCrLf + "Origem: " + row.Origem
            End If
            If row.IsIDOrigemNull = False Then
                Dim sql = "SELECT NOME FROM TB_PESSOA WHERE ID = " + row.IDOrigem.ToString()
                If txtObservacao.Text <> "" AndAlso txtObservacao.Text.Contains("Origem") = False Then
                    txtObservacao.Text += vbCrLf
                End If
                If txtObservacao.Text.Contains("Origem") = False Then
                    txtObservacao.Text += "Origem: " + fbConnection.retornaValorUnico(sql)
                End If
            End If
            If row.IsIDOrigemDestinoNull = False Then
                lkpOrigem.SelectID = row.IDOrigemDestino
            Else
                lkpOrigem.SelectID = -1
            End If
            txtPeso1.Text = row.Peso1
            txtPeso2.Text = row.Peso2
            If row.IsPesoLiquidoNull = False Then
                txtPesoL.Text = row.PesoLiquido
            Else
                txtPesoL.Text = 0
            End If
            If row.IsVolumeNull = False Then
                txtVolume.Text = row.Volume
            Else
                txtVolume.Text = 0
            End If

            If row.IsIDGuiaEntradaNull = False Then
                cbbGuia.ValorSelecionado = row.IDGuiaEntrada
            Else
                cbbGuia.ValorSelecionado = -1
            End If

            If row.IsIDGuiaSaidaNull = False Then
                cbbGuia.ValorSelecionado = row.IDGuiaSaida
            Else
                cbbGuia.ValorSelecionado = -1
            End If

            If row.IsIDGuiaServicoNull = False Then
                cbbGuia.ValorSelecionado = row.IDGuiaServico
            Else
                cbbGuia.ValorSelecionado = -1
            End If

            If row.IsIDProdutoNull = False Then
                lkpProduto.SelectID = row.IDProduto
            Else
                lkpProduto.SelectID = -1
            End If

            If row.IsIDTransportadoraNull = False Then
                cbbTransportadora.ValorSelecionado = row.IDTransportadora
            Else
                cbbTransportadora.ValorSelecionado = -1
            End If

            If row.IsDataOrdemPesagemNull = False Then
                dtOrdemPesagem.Value = row.DataOrdemPesagem
                dtOrdemPesagem.Checked = True
            Else
                dtOrdemPesagem.Checked = False
            End If

            If Not row.IsDataPesagemNull Then
                dtDataPesagem1.Value = row.DataPesagem
                dtDataPesagem1.Checked = True
            Else
                dtDataPesagem1.Checked = False
            End If

            If row.IsDataPesagem2Null = False Then
                dtDataPesagem2.Value = row.DataPesagem2
                dtDataPesagem2.Checked = True
            Else
                dtDataPesagem2.Checked = False
            End If

            If row.IsDataSaidaNull = False Then
                dtDataSaida.Value = row.DataSaida
                dtDataSaida.Checked = True
            Else
                dtDataSaida.Checked = False
            End If

            If Not row.IsPesoLiquidoNull Then txtPeso.Text = row.PesoLiquido

            If Not row.IsQuantidadeNull Then txtQtd.Text = row.Quantidade

            If row.IsDataAgendamentoNull = False Then
                dtAgendamento.Value = row.DataAgendamento
                dtAgendamento.Checked = True
            Else
                dtAgendamento.Checked = False
            End If

            If row.IsDataLiberaPesagemNull = False Then
                dtLiberarPesagem.Value = row.DataLiberaPesagem
                dtLiberarPesagem.Checked = True
            Else
                dtLiberarPesagem.Checked = False
            End If

            If row.IsDataFaturamentoNull = False Then
                dtFaturamento.Value = row.DataFaturamento
                dtFaturamento.Checked = True
            Else
                dtFaturamento.Checked = False
            End If




        Else
            MsgBox("Erro ao Carregar o Registro!", MsgBoxStyle.Critical)
        End If
        IDGuia = -1
        Return MyBase.Editar(IDSel)
    End Function


    Public Overrides Sub Carrega(Optional ByVal IDParent As Integer = -1)
        MyBase.Carrega(IDParent)
        dt = dr.GetDataByIDPortaria(ID)
    End Sub

    Public Overrides Function Excluir(ByVal IDSel As Integer) As Boolean
        If IDSel <> -1 Then
            Try
                'Carrega()
                'row = dt.FindByID(IDSel)
                'row.Delete()
                'dr.Update(dt)
                Dim SQL As String
                Dim st As Integer
                Editar(IDSel)
                If row.IsIDGuiaEntradaNull = False Then
                    Sql = "SELECT status from TB_GCI WHERE ID = " + row.IDGuiaEntrada.ToString()
                    st = fbConnection.retornaValorUnico(Sql)
                    If st = 1 Then
                        MsgBox("Não é Possivel Excluir a Portaria Vinculada a Guia de Entrada Fechada!", MsgBoxStyle.Critical)
                        Return False
                    Else
                        Sql = "update TB_GCI set IDTicket = NULL where ID = " + row.IDGuiaEntrada.ToString()
                        fbConnection.executaCommand(Sql)
                    End If
                End If
                If row.IsIDGuiaSaidaNull = False Then
                    Sql = "SELECT status from tb_gsbx WHERE ID = " + row.IDGuiaSaida.ToString()
                    st = fbConnection.retornaValorUnico(Sql)
                    If st = 1 Then
                        MsgBox("Não é Possivel Excluir a Portaria Vinculada a Guia de Saída Fechada!", MsgBoxStyle.Critical)
                        Return False
                    Else
                        Sql = "update tb_gsbx set IDTiket = NULL where ID = " + row.IDGuiaSaida.ToString()
                        fbConnection.executaCommand(Sql)
                    End If
                End If

                If row.IsIDTiketNull = False Then
                    SQL = "UPDATE TB_TIKET SET STATUS = 9 WHERE ID = " + row.IDTiket.ToString()
                    'sql += vbCrLf
                    ''sql += "delete from TB_TIKET_NOTA where IDTiket = " + row.ID.ToString()
                    'sql += vbCrLf
                    'sql += "delete from tb_portaria where ID = " + row.IDPortaria.ToString()
                    fbConnection.executaCommand(SQL)
                End If
                SQL = "update TB_PORTARIA set STATUS = 9 where ID = " + row.ID.ToString()
                'row = dt.FindByID(IDSel)
                'row.Delete()
                'dr.Update(dt)
                fbConnection.executaCommand(Sql)
                Carrega()
                msgExcluir()
                Return True
            Catch ex As SqlClient.SqlException
                If ex.ErrorCode = -2146232060 Then
                    MsgBox("Erro ao Excluir o Registro Pois Está Relacionado a Outro Registro! ", MsgBoxStyle.Critical)
                Else
                    MsgBox("Erro ao Excluir o Registro! " + ex.Message, MsgBoxStyle.Critical)
                End If
                Return False
            End Try
        End If
    End Function

    Public Overrides Function Salvar(ByVal IDSel As Integer) As Boolean
        If MyBase.Salvar(IDSel) = True Then
            If IDSel = -1 Then
                row = dt.NewTB_PORTARIARow
            Else
                Carrega()
                row = dt.FindByID(IDSel)

                Dim sql = "SELECT ID FROM TB_TIKET WHERE IDPORTARIA = " + IDSel.ToString()
                Dim IDTiket As Nullable(Of Integer) = fbConnection.retornaValorUnico(sql)
                'If IDTiket.HasValue Then
                '    Dim dtT As FeedComponentes.dtsArmazem5.TB_TIKETDataTable
                '    Dim drT As New FeedComponentes.dtsArmazem5TableAdapters.TB_TIKETTableAdapter
                '    Dim rowT As FeedComponentes.dtsArmazem5.TB_TIKETRow

                '    dtT = drT.GetDataByIDTiket(IDTiket.Value)
                '    rowT = dtT.FindByID(IDTiket.Value)
                '    rowT.IDMotorista = lkpMotorista.SelectID
                '    rowT.IDVeiculo = lkpVeiculo.SelectID
                '    rowT.IDTransportadora = cbbTransportadora.ValorSelecionado
                '    rowT.IDProduto = lkpProduto.SelectID
                '    rowT.IDUnidade = cbbUnidade.ValorSelecionado
                '    rowT.IDDomicilio = lkpProdutor.SelectID
                '    rowT.IDOrigemDestino = lkpOrigem.SelectID
                '    rowT.Tipo = cbbTipo.ValorSelecionado
                '    'rowT.OC = txtOC.Text '.ToString().Replace(Chr(13), " ").Replace(Chr(10), "")
                '    rowT.Observacao = txtObservacao.Text
                '    rowT.Quantidade = txtQtd.Text
                '    If cbbTipo.ValorSelecionado = 0 AndAlso cbbGuia.ValorSelecionado <> -1 Then
                '        rowT.IDGuiaEntrada = cbbGuia.ValorSelecionado
                '    ElseIf cbbTipo.ValorSelecionado = 1 AndAlso cbbGuia.ValorSelecionado <> -1 Then
                '        rowT.IDGuiaSaida = cbbGuia.ValorSelecionado
                '    ElseIf (cbbTipo.ValorSelecionado = 4 OrElse cbbTipo.ValorSelecionado = 5) AndAlso cbbGuia.ValorSelecionado <> -1 Then
                '        rowT.IDGuiaServico = cbbGuia.ValorSelecionado
                '    Else
                '        rowT.IsIDGuiaServicoNull()
                '    End If
                '    drT.Update(dtT)

                '    row.IDTiket = IDTiket.Value
                'End If
                If row.Tipo <> cbbTipo.ValorSelecionado Then
                    If cbbTipo.ValorSelecionado = 0 Then
                        sql = "UPDATE TB_PORTARIA SET IDGuiaSaida = NULL WHERE ID = " + ID.ToString()
                    ElseIf cbbTipo.ValorSelecionado = 1 Then
                        sql = "UPDATE TB_PORTARIA SET IDGuiaEntrada = NULL WHERE ID = " + ID.ToString()
                    Else
                        sql = "UPDATE TB_PORTARIA SET IDGuiaSaida = NULL, IDGuiaEntrada = NULL WHERE ID = " + ID.ToString()
                    End If
                    fbConnection.executaCommand(sql)
                End If
            End If
            row.IDEmpresa = My.Forms.frmPadrao.IDEmpresa
            row.IDVeiculo = lkpVeiculo.SelectID
            row.IDFuncionario = My.Forms.frmPadrao.IDUsuarioPessoa
            row.IDProduto = lkpProduto.SelectID

            row.IDOrigemDestino = lkpOrigem.SelectID
            'row.OC = txtOC.Text.ToString().Replace(Chr(13), " ").Replace(Chr(10), "")
            row.Observacao = txtObservacao.Text
            row.Quantidade = txtQtd.Text
            row.Peso1 = txtPeso1.Text
            row.Peso2 = txtPeso2.Text
            row.Peso = txtPeso.Text
            row.PesoLiquido = txtPesoL.Text
            row.Volume = txtVolume.Text
            If cbbTAG.ValorSelecionado <> -1 Then row.IDTag = cbbTAG.ValorSelecionado

            row.IDTulha = cbbTulha.SelectID

            If lkpProdutor.SelectID <> -1 Then
                row.IDDomicilio = lkpProdutor.SelectID
            End If

            If cbbUnidade.ValorSelecionado <> -1 Then
                row.IDUnidade = cbbUnidade.ValorSelecionado
            End If
            row.DataEntrada = dtDataEntrada.Value
            row.Tipo = cbbTipo.ValorSelecionado
            row.IDUsuario = My.Forms.frmPadrao.IDUsuario
            row.IDEmpresa = My.Forms.frmPadrao.IDEmpresa
            row.LOTE = txtLote.Text

            If lkpMotorista.SelectID <> -1 Then row.IDMotorista = lkpMotorista.SelectID
            If cbbTransportadora.ValorSelecionado <> -1 Then row.IDTransportadora = cbbTransportadora.ValorSelecionado
            If lkpProduto.SelectID <> -1 Then row.IDProduto = lkpProduto.SelectID

            If cbbTipo.ValorSelecionado = 1 AndAlso cbbGuia.ValorSelecionado <> -1 Then 'Tipo => Saida
                row.IDGuiaSaida = cbbGuia.ValorSelecionado
            ElseIf cbbTipo.ValorSelecionado = 0 AndAlso cbbGuia.ValorSelecionado <> -1 Then
                row.IDGuiaEntrada = cbbGuia.ValorSelecionado
            ElseIf (cbbTipo.ValorSelecionado = 4 OrElse cbbTipo.ValorSelecionado = 5) AndAlso cbbGuia.ValorSelecionado <> -1 Then
                row.IDGuiaServico = cbbGuia.ValorSelecionado
            Else
                row.SetIDGuiaServicoNull()
            End If

            If txtPeso1.Text <> 0 Then row.DataPesagem = dtDataPesagem1.Value
            If txtPeso2.Text <> 0 Then row.DataPesagem2 = dtDataPesagem2.Value

            If row.Peso1 <> 0 AndAlso row.Peso2 <> 0 Then
                row.PesoLiquido = (row.Peso1 - row.Peso2)
            End If

            '    If dtAgendamento.Checked Then

            'End If

            '    If dtOrdemPesagem.Checked Then
            '        row.DataOrdemPesagem = dtOrdemPesagem.Value
            '    End If

            '    If dtLiberarPesagem.Checked Then
            '        row.DataLiberaPesagem = dtLiberarPesagem.Value
            '    End If

            '    If dtFaturamento.Checked Then
            '        row.DataFaturamento = dtFaturamento.Value
            '    End If

            If rbEntrada.Checked Then
                row.TipoPortaria = 0
                row.Status = 0
            ElseIf rbAgendamento.Checked Then
                row.DataAgendamento = dtAgendamento.Value
                row.TipoPortaria = 1
                row.Status = 7
            Else
                row.TipoPortaria = 2
                row.Status = 8
                row.DataAgendamento = dtAgendamento.Value
            End If

            'If dtDataSaida.Checked Then
            '        row.DataSaida = dtDataSaida.Value
            '        row.Status = 3
            '    ElseIf dtDataPesagem2.Checked Then
            '        row.Status = 2
            '    ElseIf dtDataPesagem1.Checked Then
            '        row.Status = 1
            '    Else
            '        row.Status = 0
            '    End If

            If IDSel = -1 Then
                dt.AddTB_PORTARIARow(row)
            End If
            dr.Update(dt)
            If msg Then
                msgSalvar()
            End If
            If IDSel = -1 Then
                IDSel = dr.MAXID()
                ID = IDSel
            End If
            edt = True
            Me.Close()
            Return True
        End If
        Return False

    End Function

    Public Overrides Function Validar() As Boolean
        If lkpVeiculo.Requerido = True AndAlso lkpVeiculo.SelectID = -1 Then
            msgValida("Veículo", lkpVeiculo)
            Return False
        ElseIf lkpMotorista.Requerido = True AndAlso lkpMotorista.SelectID = -1 Then
            msgValida("Motorista", lkpMotorista)
            Return False
        ElseIf cbbTransportadora.Requerido = True AndAlso cbbTransportadora.ValorSelecionado = -1 Then
            msgValida("Transportadora", lkpMotorista)
            Return False
        ElseIf lkpProduto.Requerido = True AndAlso lkpProduto.SelectID = -1 Then
            msgValida("Produto", lkpProduto)
            Return False
        ElseIf lkpProdutor.Requerido = True AndAlso lkpProdutor.SelectID = -1 Then
            msgValida("Produtor", lkpProdutor)
            Return False
        ElseIf cbbTipo.ValorSelecionado = -1 Then
            msgValida("Tipo", cbbTipo)
            Return False
            'ElseIf cbbTipo.ValorSelecionado = 1 AndAlso cbbGuia.ValorSelecionado = -1 Then
            '    msgValida("Guia de Embarque", cbbGuia)
            '    Return False
        ElseIf cbbUnidade.Requerido = True AndAlso cbbUnidade.ValorSelecionado = -1 Then
            msgValida("Unidade", cbbUnidade)
            Return False
        ElseIf cbbTAG.ValorSelecionado = -1 Then
            msgValida("TAG", cbbTAG)
            Return False
        ElseIf cbbTipo.ValorSelecionado = 0 OrElse cbbTipo.ValorSelecionado = 1 Then
            If lkpOrigem.SelectID = -1 Then
                msgValida(lblOrigemDest.Text.Replace(":", ""), lkpOrigem)
                Return False
            End If
        ElseIf cbbTipo.ValorSelecionado = 1 AndAlso txtQtd.Text = 0 Then
            msgValida("Quantidade", txtQtd)
            Return False
        End If
        Return True
    End Function

    Private Sub btnSalva_Click(sender As Object, e As EventArgs) Handles btnSalva.Click
        salvandoDados()
    End Sub

    Public Overrides Sub salvandoDados()
        If Salvar(ID) Then
            Editar(ID)
            'dgvNota.btnAdd.Focus()
        End If
    End Sub

    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
        FecharTela()
    End Sub

    Private Sub lkpVeiculo_antesDeAbrir() Handles lkpVeiculo.antesDeAbrir
        setaForm()
    End Sub

    Private Sub lkpVeiculo_Selecionando() Handles lkpVeiculo.Selecionando
        If lkpVeiculo.SelectID <> -1 AndAlso edt = False Then
            Dim IDvcl As Integer = lkpVeiculo.SelectID
            Dim drSQL As New dtsArmazemSQLTableAdapters.GetSugVeicTableAdapter
            Dim dtSQL As dtsArmazemSQL.GetSugVeicDataTable
            Dim rowSug As dtsArmazemSQL.GetSugVeicRow

            dtSQL = drSQL.GetData(IDvcl)
            If dtSQL IsNot Nothing AndAlso dtSQL.Rows.Count > 0 Then
                rowSug = dtSQL.Rows(0)

                If rowSug.IsIDMOTORISTANull = False AndAlso lkpMotorista.SelectID = -1 Then
                    lkpMotorista.SelectID = rowSug.IDMOTORISTA
                End If

                If rowSug.IsIDTRANSPNull = False AndAlso cbbTransportadora.ValorSelecionado = -1 Then    '= idTransp OrElse cbbTransportadora.ValorSelecionado = -1 Then
                    cbbTransportadora.ValorSelecionado = rowSug.IDTRANSP
                End If

                If rowSug.IsIDPRODUTORNull = False AndAlso lkpProdutor.SelectID = -1 Then
                    Dim sql = "SELECT ID FROM TB_DOMICILIO WHERE ID = " + rowSug.IDPRODUTOR.ToString() + " AND IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString()
                    If fbConnection.retornaValorUnico(sql) IsNot Nothing Then
                        lkpProdutor.SelectID = rowSug.IDPRODUTOR
                    Else
                        lkpProdutor.SelectID = -1
                    End If
                End If

                If rowSug.IsIDPRODUTONull = False AndAlso lkpProduto.SelectID = -1 Then
                    Dim sql = "SELECT ID FROM TB_ITEM WHERE ID = " + rowSug.IDPRODUTO.ToString() + " AND IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString()
                    If fbConnection.retornaValorUnico(sql) IsNot Nothing Then
                        lkpProduto.SelectID = rowSug.IDPRODUTO
                    Else
                        lkpProduto.SelectID = -1
                    End If
                End If

                If lkpMotorista.SelectID = -1 Then
                    lkpMotorista.Focus()
                ElseIf cbbTransportadora.ValorSelecionado = -1 Then
                    cbbTransportadora.Focus()
                ElseIf lkpProduto.SelectID = -1 Then
                    lkpProduto.Focus()
                ElseIf lkpProdutor.SelectID = -1 Then
                    lkpProdutor.Focus()
                Else
                    cbbTipo.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub dgvNota_executaAcao()
        Editar(ID)
    End Sub

    Private Sub frmCadastroPortaria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sql = "SELECT IDTIPOMOTORISTA, IDTIPOGERAL, IDTIPOPRODUTOR FROM TB_CONF_ARMAZEM WHERE IDEMPRESA = " + My.Forms.frmPadrao.IDEmpresa.ToString()
        Dim dtLoc As DataTable = fbConnection.executaSelect(sql)
        If dtLoc IsNot Nothing AndAlso dtLoc.Rows.Count > 0 Then
            IDTipoMot = dtLoc.Rows(0).Item(0)
            IDTipoGeral = dtLoc.Rows(0).Item(1)
            IDTipoProd = dtLoc.Rows(0).Item(2)
        End If
        carregaTAG()
        'Me.frmPai = My.Forms.frmGerenciaPortaria
        'FbTabPage1.SelectedTab = TabPageEX1
    End Sub

    Private Sub lkpProdutor_antesDeAbrir() Handles lkpProdutor.antesDeAbrir
        frmPesquisaDomicilio.txtDomicilio.Visible = False
        frmPesquisaDomicilio.txtProdutor.Visible = False
        frmPesquisaDomicilio.lblDom.Visible = False
        frmPesquisaDomicilio.lblProdutor.Visible = False
        frmPesquisaDomicilio.menuFiltro.Height = 77
        setaForm()
    End Sub

    Private Sub lkpProdutor_Selecionando() Handles lkpProdutor.Selecionando
        If lkpProdutor.SelectID <> -1 Then
            If ID <> -1 Then
                If lkpProdutor.SelectID <> row.IDDomicilio Then
                    Dim sql = "SELECT TOP 1 ID FROM TB_PORTARIA_CERTIFICACAO WHERE IDPORTARIA = " + ID.ToString()
                    Dim idCert As Nullable(Of Integer) = fbConnection.retornaValorUnico(sql)
                End If
            End If
            txtProdutor.Text = clFiscal.pesquisaNomePessoa(lkpProdutor.DataTableSelect.Item("IDPessoa"))
            cbbTipo.ValorSelecionado = -1
        Else
            txtProdutor.Clear()
        End If
    End Sub

    'Private Sub txtQtd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtd.TextChanged, txtPeso.TextChanged
    '    clArmazem.verificaSacas(txtPeso.Text, txtQtd.Text, cbbUnidade.ValorSelecionado,
    '                            txtVolume, txtPesoL)
    'End Sub

    'Private Sub cbbUnidade_Selecionado() Handles cbbUnidade.Selecionando
    '    clArmazem.verificaSacas(txtPeso.Text, txtQtd.Text, cbbUnidade.ValorSelecionado,
    '                             txtVolume, txtPesoL)
    'End Sub

    'Private Sub cbbTipo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbTipo.Leave
    '    Select Case cbbTipo.Text
    '        Case "RECEBIMENTO" 'Entrada
    '            cbbGuia.ValorSelecionado = -1
    '            cbbGuia.Enabled = False
    '            cbbUnidade.Focus()
    '        Case "EMBARQUE" ' Saida
    '            cbbGuia.TabelaRelacionamento = "TB_GSBX"
    '            cbbGuia.Filtro = "IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString() + " AND STATUS = 0 AND IDDomicilio = " + lkpProdutor.SelectID.ToString()
    '            cbbGuia.ValorSelecionado = -1
    '            cbbGuia.Enabled = True
    '            cbbGuia.Focus()
    '        Case "PESAGEM" 'Pesagem
    '            cbbGuia.ValorSelecionado = -1
    '            cbbGuia.Enabled = False
    '            cbbUnidade.Focus()
    '        Case "OUTROS" 'Outros
    '            cbbGuia.ValorSelecionado = -1
    '            cbbGuia.Enabled = False
    '            cbbUnidade.Focus()
    '        Case -1
    '            cbbGuia.Enabled = False
    '    End Select
    'End Sub


    Private Sub cbbTipo_Selecionando() Handles cbbTipo.Selecionando
        txtQtd.Enabled = False
        txtQtd.Requerido = False
        cbbGuia.Enabled = False
        cbbGuia.ValorSelecionado = -1
        'lblOrigemDest.Location = New Point(50, 171)
        lblOrigemDest.Text = "Origem:"
        Select Case cbbTipo.ValorSelecionado
            Case 0 '"RECEBIMENTO" 'Entrada  
                lblOrigemDest.Text = "Destino:"
                cbbGuia.Enabled = True
                cbbGuia.Requerido = False
                txtQtd.Enabled = True
                txtQtd.Requerido = True
                lkpOrigem.Requerido = True
                cbbGuia.TabelaRelacionamento = "TB_GCI"
                cbbGuia.Filtro = "STATUS = 0 AND IDDomicilio = " + lkpProdutor.SelectID.ToString() _
                + " AND ID NOT IN (SELECT IDGuiaEntrada FROM TB_PORTARIA where IDGuiaEntrada IS Not NULL AND IDEMPRESA = " _
                + My.Forms.frmPadrao.IDEmpresa.ToString() + ")"
                If cbbTipo.DroppedDown = False Then
                    cbbUnidade.Focus()
                End If
                If lkpOrigem.SelectID = -1 Then
                    lkpOrigem.SelectID = lkpProdutor.SelectID
                End If
            Case 1 '"EMBARQUE" ' Saida
                'lblOrigemDest.Location = New Point(47, 171)
                lblOrigemDest.Text = "Destino:"
                cbbGuia.Requerido = False
                txtQtd.Enabled = True
                txtQtd.Requerido = True
                lkpOrigem.Requerido = True
                cbbGuia.TabelaRelacionamento = "TB_GSBX"
                cbbGuia.campoSql = "CONVERT(VARCHAR,NUMERO) +' - ' + CONVERT(VARCHAR,VOLUME) + ' (SCS)'"
                cbbGuia.Filtro = "IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString()
                cbbGuia.Filtro += " AND IDDomicilio = " + lkpProdutor.SelectID.ToString() _
                '+" AND ID NOT IN (SELECT IDGUIASAIDA FROM TB_PORTARIA where IDGuiaSaida IS Not NULL AND IDEMPRESA = " _
                '+ My.Forms.frmPadrao.IDEmpresa.ToString()
                'cbbGuia.Filtro += " AND ID <> " + ID.ToString() + ")"
                cbbGuia.Filtro += " AND IDGUIARELACIONADA IS NULL AND STATUS = 0"
                'cbbGuia.Filtro += " AND ((IDGuiaRelacionada is not null and Status = 1 or status = 9)"
                'cbbGuia.Filtro += " OR (IDGuiaRelacionada is null and Status = 0))"
                cbbGuia.Enabled = True
                If cbbTipo.DroppedDown = False Then
                    cbbGuia.Focus()
                End If
            Case 2 '"PESAGEM" 'Pesagem
                lkpOrigem.Requerido = False
                If cbbTipo.DroppedDown = False Then
                    cbbUnidade.Focus()
                End If
            Case 3 '"OUTROS" 'Outros
                lkpProdutor.Requerido = False
                cbbUnidade.Requerido = False
                cbbTransportadora.Requerido = False
                lkpProduto.Requerido = False
                txtQtd.Requerido = False
                lkpOrigem.Requerido = False
                'If cbbTipo.DroppedDown = False Then
                '    cbbUnidade.Focus()
                'End If
            Case 4 'Despejo
                cbbGuia.Requerido = False
                cbbGuia.Enabled = True
                txtQtd.Enabled = True
                txtQtd.Requerido = True
                cbbGuia.TabelaRelacionamento = "TB_GUIA_SERVICO"
                cbbGuia.campoSql = "CONVERT(VARCHAR,NUMERO) + ' - ' + CONVERT(VARCHAR,VOLUME) + ' (SCS)'"
                cbbGuia.Filtro = "IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString()
                cbbGuia.Filtro += " AND IDDomicilio = " + lkpProdutor.SelectID.ToString()
                cbbGuia.Filtro += " AND status = 0 AND ativo = 1"
                If cbbTipo.DroppedDown = False Then
                    cbbGuia.Focus()
                End If
            Case 5 'Resultado
                cbbGuia.Requerido = False
                cbbGuia.Enabled = True
                txtQtd.Enabled = True
                txtQtd.Requerido = True
                cbbGuia.TabelaRelacionamento = "TB_GUIA_SERVICO"
                cbbGuia.campoSql = "CONVERT(VARCHAR,NUMERO) + ' - ' + CONVERT(VARCHAR,VOLUME) + ' (SCS)'"
                cbbGuia.Filtro = "IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString()
                cbbGuia.Filtro += " AND IDDomicilio = " + lkpProdutor.SelectID.ToString()
                cbbGuia.Filtro += " AND status = 0 AND ativo = 1"
                If cbbTipo.DroppedDown = False Then
                    cbbGuia.Focus()
                End If
        End Select
    End Sub

    'Private Sub cbbTipo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbTipo.DropDownClosed

    'End Sub

    Private Sub FbButtonVisual1_Click(sender As System.Object, e As System.EventArgs) Handles FbButtonVisual1.Click
        funcF8()
    End Sub

    Private Sub lkpMotorista_antesDeAbrir() Handles lkpMotorista.antesDeAbrir
        frmPesquisaPessoa.Condicao = " AND (IDTIPOPESSOA = " + IDTipoMot.ToString()
        frmPesquisaPessoa.Condicao += " OR IDTIPOPESSOA = " + IDTipoGeral.ToString() + ")"
        setaForm()
    End Sub

    'Private Sub lkpVeiculo_antesDeAbrir() Handles lkpVeiculo.antesDeAbrir
    '    frmPesquisaVeiculo.Condicao = " AND ID NOT IN (SELECT p.IDVEICULO from TB_PORTARIA p WHERE p.STATUS <> 3 AND p.IDEMPRESA = " _
    '                                    + My.Forms.frmPadrao.IDEmpresa.ToString() + ")"
    'End Sub

    Private Sub lkpProduto_antesDeAbrir() Handles lkpProduto.antesDeAbrir
        frmPesquisaItem2.Condicao = " AND TIPO = 'P' AND servProducao = 0"
        setaForm()
    End Sub

    Private Sub lkpOrigem_antesDeAbrir() Handles lkpOrigem.antesDeAbrir
        setaForm()
    End Sub

    Private Sub lkpOrigem_Selecionando() Handles lkpOrigem.Selecionando
        If lkpOrigem.SelectID <> -1 Then
            txtProdutorOrigem.Text = clFiscal.pesquisaNomePessoa(lkpOrigem.DataTableSelect.Item("IDPessoa"))
        Else
            txtProdutorOrigem.Clear()
        End If
    End Sub

    Private Sub cbbGuia_Selecionando() Handles cbbGuia.Selecionando
        If cbbTipo.ValorSelecionado = 1 Then
            If cbbGuia.ValorSelecionado <> -1 Then
                Dim sql As String = "SELECT Observacao, IDDestinoDom FROM TB_GSBX WHERE ID = " + cbbGuia.ValorSelecionado.ToString()
                Dim dtLoc As DataTable = fbConnection.executaSelect(sql)
                If dtLoc IsNot Nothing AndAlso dtLoc.Rows.Count > 0 Then
                    'txtOC.Text = dtLoc.Rows(0).Item(0).ToString().Replace(Chr(13), " ").Replace(Chr(10), "")
                    If IsDBNull(dtLoc.Rows(0).Item(1)) = False Then
                        lkpOrigem.SelectID = dtLoc.Rows(0).Item(1)
                        lkpOrigem.Enabled = False
                    End If
                    'txtOC.ReadOnly = True
                End If
            Else
                lkpOrigem.SelectID = -1
                lkpOrigem.Enabled = True
                'txtOC.ReadOnly = False
                'txtOC.Clear()
            End If
        Else
            lkpOrigem.Enabled = True
            'txtOC.Enabled = True
        End If
    End Sub

    Private Sub txtPeso2_TextChanged(sender As Object, e As System.EventArgs)
        If txtPeso2.Text > 0 Then
            cbbGuia.Enabled = False
        Else
            cbbGuia.Enabled = True
        End If
    End Sub

    Private Sub rbEntrada_CheckedChanged(sender As Object, e As EventArgs) Handles rbEntrada.CheckedChanged, rbAgendamento.CheckedChanged, rbSolicitacao.CheckedChanged
        If rbEntrada.Checked = True Then
            lblDtagendamento.Text = "Data Agendamento:"
            dtAgendamento.Enabled = False
            txtLote.Enabled = False
        ElseIf rbAgendamento.Checked = True Then
            lblDtagendamento.Text = "Data Agendamento:"
            dtAgendamento.Enabled = True
            txtLote.Enabled = False
        Else
            lblDtagendamento.Text = "Data Solicitação:"
            dtAgendamento.Enabled = True
            txtLote.Enabled = True
        End If
    End Sub

    Private Sub cbbTAG_Selecionando() Handles cbbTAG.Selecionando
        carregaTAG()
    End Sub

    Private Sub cbbTAG_DropDown(sender As Object, e As EventArgs) Handles cbbTAG.DropDown
        carregaTAG()
    End Sub

    Public Sub carregaTAG()
        Dim sql As String
        sql = $"IDTAG =         (SELECT P.IDTAG FROM TB_PORTARIA P WITH(NOLOCK) WHERE P.ID = {ID}) OR "
        sql += "IDTag NOT IN    (SELECT ISNULL(P.IDTAG, -1) FROM TB_PESSOA P WITH(NOLOCK)) AND "
        sql += "IDTag NOT IN    (SELECT ISNULL(P.IDTAG, -1) FROM TB_PORTARIA P WITH(NOLOCK))"

        Dim sql1 As String
        sql1 = $"(IDTAG NOT IN (SELECT isnull(P.IDTAG,-1) FROM TB_PORTARIA P WITH(NOLOCK))) AND "
        sql1 += "(IDTAG NOT IN (SELECT isnull(P.IDTAG,-1) FROM TB_PESSOA P WITH(NOLOCK)))"

        If ID <> -1 AndAlso row.IsIDTagNull = False Then
            cbbTAG.Filtro = sql
        Else
            cbbTAG.Filtro = sql1
        End If
    End Sub


    Private Sub lblstatus_TextChanged(sender As Object, e As EventArgs) Handles lblstatus.TextChanged
        If lblstatus.Text = "EM DIGITAÇÃO" Then
            lblstatus.BackColor = Color.SteelBlue
            lblstatus.Tag = 0

        ElseIf lblstatus.Text = "ENTROU" Then
            lblstatus.BackColor = Color.DarkCyan
            lblstatus.Tag = 0

        ElseIf lblstatus.Text = "PESAGEM LIBERADA" Then
            lblstatus.BackColor = Color.Firebrick
            lblstatus.Tag = 1
        ElseIf lblstatus.Text = "ORDEM DE PESAGEM" Then
            lblstatus.BackColor = Color.Firebrick
            lblstatus.Tag = 2
        ElseIf lblstatus.Text = "PRIMEIRA PESAGEM" Then
            lblstatus.BackColor = Color.Firebrick
            lblstatus.Tag = 3
        ElseIf lblstatus.Text = "SEGUNDA  PESAGEM" Then
            lblstatus.BackColor = Color.Firebrick
            lblstatus.Tag = 4
        ElseIf lblstatus.Text = "SAIU" Then
            lblstatus.BackColor = Color.Firebrick
            lblstatus.Tag = 5
        ElseIf lblstatus.Text = "LIBERADO PARA BUSCAR" Then
            lblstatus.BackColor = Color.Firebrick
            lblstatus.Tag = 6
        ElseIf lblstatus.Text = "AGENDADO" Then
            lblstatus.BackColor = Color.Firebrick
            lblstatus.Tag = 7
        ElseIf lblstatus.Text = "SOLICITADO" Then
            lblstatus.BackColor = Color.Firebrick
            lblstatus.Tag = 8
        ElseIf lblstatus.Text = "FATURADO" Then
            lblstatus.BackColor = Color.Firebrick
            lblstatus.Tag = 9
        ElseIf lblstatus.Text = "CANCELADO" Then
            lblstatus.BackColor = Color.Firebrick
            lblstatus.Tag = 10
        End If
        lblstatus.ForeColor = Color.Lavender
    End Sub

    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        Dim IDTicket As String = "select ISNULL(idTiket,0) from TB_PORTARIA where id = " + ID.ToString()
        imprimeTiketCASEMG(ID, fbConnection.retornaValorUnico(IDTicket))
    End Sub

    Public Shared Sub imprimeTiketCASEMG(ByVal id As Integer, ByVal IDTicket As Integer)
        Dim dts As New DataSet

        Dim tb As dtsRelPortaria.TICKETCASEMGDataTable
        Dim tr As New dtsRelPortariaTableAdapters.TICKETCASEMGTableAdapter
        tb = tr.GetData(IDTicket)

        Dim tb1 As dtsRelPortaria.relAutomacaoControlePortariaTicketDataTable
        Dim tr1 As New dtsRelPortariaTableAdapters.relAutomacaoControlePortariaTicketTableAdapter
        tb1 = tr1.GetData(id)

        Dim tb2 As dtsRelPortaria.retornaDadosEmpresa2DataTable
        Dim tr2 As New dtsRelPortariaTableAdapters.retornaDadosEmpresa2TableAdapter
        tb2 = tr2.GetData(My.Forms.frmPadrao.IDEmpresa, Date.Now, "")

        dts.Tables.Add(tb)
        dts.Tables.Add(tb1)
        dts.Tables.Add(tb2)

        My.Forms.frmGeraRelatorio.TipoRel = TipoRel.Rel.RelControlePortariaTicket
        My.Forms.frmGeraRelatorio.DataSetRel = dts
        My.Forms.frmGeraRelatorio.ShowDialog()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If MessageBox.Show("Confirma a Saída?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes Then
            fbConnection.retornaValorUnico("update TB_PORTARIA set IDTag = NULL , DataSaida = getdate() where id = " + ID.ToString())
            Editar(ID)
            Me.Close()
        End If
    End Sub
End Class