Imports System.Text

Public Class frmGerenciaPortaria
    Dim idTiket As Integer = -1
    Dim status As Integer = 0
    Dim TIPOPORT As String = ""
    Dim TipoPortaria As Integer
    Dim data As String = ""
    Dim ssql As New StringBuilder
    Dim filtro As New StringBuilder

    Private Sub SetaForm()
        lkpProdutor.FormularioPesquisa = frmPesquisaDomicilio
    End Sub

    Public Overrides Sub Filtrar(Optional ByVal filtra As Boolean = True)
        If filtra Then
            Me.Cursor = Cursors.WaitCursor
            ssql.Remove(0, ssql.Length)
            filtro.Remove(0, filtro.Length)

            If rbSaida.Checked OrElse cbbDataFiltro.SelectedIndex = 3 Then
                filtro.Append(" WHERE STATUS = 5")
            ElseIf rbTodos.Checked Then
                filtro.Append(" WHERE N.STATUS < 11 ")
            ElseIf rbLiberaPesagem.Checked Then
                filtro.Append(" WHERE N.STATUS = 1 ")
            ElseIf rbOrdemPesagem.Checked Then
                filtro.Append(" WHERE N.STATUS = 2 ")
            ElseIf rbEntrada.Checked Then
                filtro.Append(" WHERE N.STATUS = 0 ")
            ElseIf rbPesagem1.Checked Then
                filtro.Append(" WHERE N.STATUS = 3 ")
            ElseIf rbPesagem2.Checked Then
                filtro.Append(" WHERE N.STATUS = 4 ")
            ElseIf rbLiberaBuscar.Checked Then
                filtro.Append(" WHERE N.STATUS = 6 ")
            ElseIf rbAgendado.Checked Then
                filtro.Append(" WHERE N.STATUS = 7 ")
            ElseIf rbSolicitado.Checked Then
                filtro.Append(" WHERE N.STATUS = 8 ")
            ElseIf rbFaturado.Checked Then
                filtro.Append(" WHERE N.STATUS = 9 ")
            ElseIf rbCancelado.Checked Then
                filtro.Append(" WHERE N.STATUS = 10 ")
            End If

            If rbTodosTipos.Checked Then
                filtro.Append(" AND ISNULL(N.TIPOPORTARIA,0) < 4 ")
            ElseIf rbTipoEntrada.Checked Then
                filtro.Append(" AND ISNULL(N.TIPOPORTARIA,0) = 0 ")
            ElseIf rbAgendamento.Checked Then
                filtro.Append(" AND ISNULL(N.TIPOPORTARIA,0) = 1 ")
            ElseIf rbSolicitacao.Checked Then
                filtro.Append(" AND ISNULL(N.TIPOPORTARIA,0) = 2 ")
            End If

            If lkpProdutor.SelectID <> -1 Then
                filtro.Append(setaWhere1(filtro.ToString()))
                filtro.Append("n.IDDomicilio = " + Convert.ToString(lkpProdutor.SelectID))
            End If

            If cbbTipo.ValorSelecionado <> -1 Then
                filtro.Append(setaWhere1(filtro.ToString()))
                filtro.Append("Tipo = ")
                filtro.Append(cbbTipo.ValorSelecionado.ToString())
                If cbbTipo.ValorSelecionado = 0 Then
                    If txtGuia.Text <> "" Then
                        filtro.Append(" AND n.IDGuiaEntrada IN (SELECT ID FROM TB_GCI g ") 'clFiltro.MontarNumeroGuia(txtGuia.Text)
                        clFiltro.FiltraNumLote(txtGuia.Text, filtro, "Numero", "g", False, True, False)
                        filtro.Append(")")
                    End If
                ElseIf cbbTipo.ValorSelecionado = 1 Then
                    If txtGuia.Text <> "" Then
                        filtro.Append(" AND n.IDGuiaSaida IN (SELECT ID FROM TB_GSBX g ") 'clFiltro.MontarNumeroGuia(txtGuia.Text)
                        clFiltro.FiltraNumLote(txtGuia.Text, filtro, "Numero", "g", False, True, False)
                        filtro.Append(")")
                    End If
                End If
            End If

            If cbbVeiculo.ValorSelecionado <> -1 Then
                filtro.Append(setaWhere1(filtro.ToString()))
                filtro.Append("n.IDVeiculo = ")
                filtro.Append(cbbVeiculo.ValorSelecionado.ToString())
            End If

            If dtDataInicial.Checked OrElse dtDataFinal.Checked Then

                If Me.cbbDataFiltro.SelectedIndex >= 0 Then
                    data = "isnull(dataAgendamento,dataEntrada) "

                    'If cbbDataFiltro.SelectedIndex = 0 Then
                    '    data = "dataEntrada "
                    'ElseIf cbbDataFiltro.SelectedIndex = 1 Then
                    '    data = "n.dataPesagem "
                    'ElseIf cbbDataFiltro.SelectedIndex = 2 Then
                    '    data = "n.dataPesagem2 "
                    'Else
                    '    data = "n.dataSaida "
                    'End If
                    filtro.Append(clFiltro.FiltrarData(dtDataInicial.Value, dtDataFinal.Value,
                                    dtDataInicial.Checked, dtDataFinal.Checked,
                                    data, filtro.ToString()))
                    Else
                        'MsgBox("Escolha o tipo da Data a Ser Filtrado!", MsgBoxStyle.Information, "Aviso")
                        cbbDataFiltro.Focus()
                        Exit Sub
                    End If
                End If

                ssql.Append("select ID,")
            If data <> "" Then
                Dim sql As String
                sql = "(CONVERT(varchar," + data + ",103) + ' ' +"
                sql += " SUBSTRING(CONVERT(varchar," + data + ",108),1,5)) as '"
                sql += cbbDataFiltro.SelectedItem.ToString().ToUpper()
                sql += "',"
                ssql.Append(sql)
                data = ""
            Else
                ssql.Append(" CASE WHEN ISNULL(TIPOPORTARIA,0) <> 0 THEN")
                ssql.Append(" (CONVERT(varchar,DATAAGENDAMENTO,103) + ' ' +")
                ssql.Append(" SUBSTRING(CONVERT(varchar,DATAAGENDAMENTO,108),1,5)) ELSE ")
                ssql.Append(" (CONVERT(varchar,DATAENTRADA,103) + ' ' +")
                ssql.Append(" SUBSTRING(CONVERT(varchar,DATAENTRADA,108),1,5)) end as 'ENTRADA',")
            End If
            ssql.Append("(SELECT placa FROM TB_VEICULO WHERE ID = n.IDVEICULO) as 'VEIC./PLACA', ")
            ssql.Append("(SELECT NOME FROM TB_PESSOA WHERE ID = n.IDMOTORISTA) as 'MOTORISTA',  ")
            ssql.Append("(SELECT Nome FROM TB_PESSOA WHERE ID = ")
            ssql.Append("(SELECT IDPessoa FROM TB_DOMICILIO WHERE ID = n.IDDOMICILIO)) as 'PRODUTOR', ")
            ssql.Append("(SELECT CodFazCli FROM TB_DOMICILIO WHERE ID = n.IDDOMICILIO) as 'DOM.', ")
            ssql.Append(" QUANTIDADE AS 'QTD.', ")
            ssql.Append("(SELECT NOME FROM TB_UNIDADE WHERE ID = n.IDUNIDADE) as 'UNIDADE', ")
            ssql.Append(" Case Tipo ")
            ssql.Append("WHEN 0 THEN 'RECEBIMENTO' ")
            ssql.Append("WHEN 1 THEN 'EMBARQUE' ")
            ssql.Append("WHEN 2 THEN 'PESAGEM' ")
            ssql.Append("WHEN 3 THEN 'OUTROS' ")
            ssql.Append("WHEN 4 THEN 'DESPEJO' ")
            ssql.Append("WHEN 5 THEN 'RESULTADO' ")
            ssql.Append(" END as TIPO,")
            ssql.Append(" Case Status ")
            ssql.Append("  WHEN 0 THEN 'ENTROU'")
            ssql.Append("  WHEN 1 THEN 'LIBERADO PESAGEM'")
            ssql.Append("  WHEN 2 THEN 'ORDEM PESAGEM'")
            ssql.Append("  WHEN 3 THEN '1ª PESAGEM'")
            ssql.Append("  WHEN 4 THEN '2ª PESAGEM'")
            ssql.Append("  WHEN 5 THEN 'SAIU'")
            ssql.Append("  WHEN 6 THEN 'LIBERADO BUSCAR'")
            ssql.Append("  WHEN 7 THEN 'AGENDADO'")
            ssql.Append("  WHEN 8 THEN 'SOLICITADO'")
            ssql.Append("  WHEN 9 THEN 'FATURADO'")
            ssql.Append("  WHEN 10 THEN 'CANCELADO'")
            ssql.Append(" END as STATUS, ")
            ssql.Append("IDTiket, status as st")
            ssql.Append(" FROM TB_PORTARIA n ")
            ssql.Append(filtro)
            ssql.Append(setaWhere1(filtro.ToString()))
            ssql.Append(" STATUS <> 9 AND IDEMPRESA = ")
            ssql.Append(My.Forms.frmPadrao.IDEmpresa.ToString())
            ssql.Append(" order by n.dataentrada, Status")
            Dim dt = fbConnection.executaSelect(ssql.ToString())
            dgvDados.DataSource = dt
            carregaGUIAGRID()
            Me.Cursor = Cursors.Arrow
            TIPOPORT = ""
        End If
    End Sub

    Public Overrides Sub Seleciona()
        MyBase.Seleciona()
        If Not IsDBNull(dgvDados.CurrentRow.Cells("IDTiket").Value) Then
            idTiket = dgvDados.CurrentRow.Cells("IDTiket").Value
        Else
            idTiket = -1
        End If
        status = dgvDados.CurrentRow.Cells("st").Value
        TIPOPORT = dgvDados.CurrentRow.Cells("TIPO").Value
    End Sub

    Public Function setaWhere1(ByVal _filtro As String, Optional ByVal semWhere As Boolean = True) As String
        Dim ret As String = ""
        If Trim(_filtro) = "" Then
            ret = " WHERE "
        Else
            ret = " AND "
        End If
        Return ret
    End Function

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click
        inserirF5()
    End Sub

    Public Overrides Sub inserirF5()
        MyBase.inserirF5()
        My.Forms.frmCadastroPortaria.IDGuia = -1
        My.Forms.frmCadastroPortaria.ID = -1
        If My.Forms.frmCadastroPortaria.Created = True Then
            My.Forms.frmCadastroPortaria.Close()
        End If
        My.Forms.frmCadastroPortaria.pnlCampos.Enabled = True
        My.Forms.frmCadastroPortaria.txtObservacao.Enabled = True
        My.Forms.frmCadastroPortaria.btnSalvar.Enabled = True
        'My.Forms.frmCadastroPortaria.dgvNota.Enabled = True
        frmMain2.abreForm(My.Forms.frmCadastroPortaria, "S", 1)
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        EditarF6(Me.dgvDados.idSel)
    End Sub

    Public Overrides Function EditarF6(ByVal IDSel As Integer) As Boolean
        If IDSel <> -1 Then
            My.Forms.frmCadastroPortaria.ID = IDSel
            If status = 0 OrElse status = 1 OrElse status = 2 Then
                My.Forms.frmCadastroPortaria.pnlCampos.Enabled = True
                My.Forms.frmCadastroPortaria.txtObservacao.Enabled = True
                My.Forms.frmCadastroPortaria.btnSalvar.Enabled = True
                'My.Forms.frmCadastroPortaria.dgvNota.Enabled = True
                frmMain2.abreForm(My.Forms.frmCadastroPortaria, "S", 1)
            Else
                My.Forms.frmCadastroPortaria.pnlCampos.Enabled = False
                My.Forms.frmCadastroPortaria.txtObservacao.Enabled = True
                My.Forms.frmCadastroPortaria.btnSalvar.Enabled = True
                'My.Forms.frmCadastroPortaria.dgvNota.Enabled = False
                frmMain2.abreForm(My.Forms.frmCadastroPortaria, "S", 1)
            End If
        Else
            MsgBox("Selecione um Registro para Edição!", MsgBoxStyle.Information, "Aviso")
        End If
        Return True
    End Function

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        ExcluirSFHITF2(Me.dgvDados.idSel)
    End Sub

    Public Overrides Function ExcluirSFHITF2(ByVal IDSel As Integer) As Boolean
        If IDSel <> -1 Then
            Try
                If MessageBox.Show("Deseja Excluir o Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim sql = "SELECT IDPORTARIA FROM TB_TIKET WHERE status <> 9 AND IDPORTARIA = " + Me.dgvDados.idSel.ToString()
                    Dim idPort = fbConnection.retornaValorUnico(sql)
                    If idPort Is Nothing Then
                        My.Forms.frmCadastroPortaria.ID = Me.dgvDados.idSel
                        My.Forms.frmCadastroPortaria.Excluir(Me.dgvDados.idSel)
                        Filtrar()
                        Return True
                    Else
                        MsgBox("O Registro não Pode Ser Excluído Pois Está Relacionado com o Ticket de Pesagem!", MsgBoxStyle.Critical, "Aviso")
                        Return False
                    End If
                End If
            Catch ex As SqlClient.SqlException
                If ex.ErrorCode = -2146232060 Then
                    MsgBox("Erro ao Excluir o Registro Pois Está Relacionado a Outro Registro! ", MsgBoxStyle.Critical)
                Else
                    MsgBox("Erro ao Excluir o Registro! " + ex.Message, MsgBoxStyle.Critical)
                End If
                Return False
            End Try
        End If
        Return False
    End Function

    Public Overrides Sub setaDts()
        MyBase.setaDts()
        If dgvDados.ColumnCount > 0 Then
            dgvDados.Columns("id").Visible = False
            dgvDados.Columns("st").Visible = False
            dgvDados.Columns("IDTiket").Visible = False
            dgvDados.Columns(1).Width = 110
            dgvDados.Columns("Veic./Placa").Width = 90
            dgvDados.Columns("PRODUTOR").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvDados.Columns("Motorista").Width = 120
            dgvDados.Columns("DOM.").Width = 50
            dgvDados.Columns("UNIDADE").Width = 80
            dgvDados.Columns("QTD.").Width = 60
            dgvDados.Columns("STATUS").Width = 80
            dgvDados.Columns("TIPO").Width = 100
        End If

        For Each R As DataGridViewRow In dgvDados.Rows
            Select Case R.Cells("status").Value
                Case Is = "ENTROU"
                    R.DefaultCellStyle.BackColor = Color.Teal
                    R.DefaultCellStyle.ForeColor = Color.Lavender
                Case Is = "1ª PESAGEM"
                    R.DefaultCellStyle.BackColor = Color.CornflowerBlue
                    R.DefaultCellStyle.ForeColor = Color.Lavender
                Case Is = "2ª PESAGEM"
                    R.DefaultCellStyle.BackColor = Color.Brown
                    R.DefaultCellStyle.ForeColor = Color.Lavender
                Case Is = "SAIU"
                    R.DefaultCellStyle.BackColor = Color.LemonChiffon
                    R.DefaultCellStyle.ForeColor = Color.Black
                Case Is = "AGENDADO"
                    R.DefaultCellStyle.BackColor = Color.BlanchedAlmond
                    R.DefaultCellStyle.ForeColor = Color.Black
                Case Is = "SOLICITADO"
                    R.DefaultCellStyle.BackColor = Color.AliceBlue
                    R.DefaultCellStyle.ForeColor = Color.Black
                Case Is = "LIBERADO PESAGEM"
                    R.DefaultCellStyle.BackColor = Color.LightBlue
                    R.DefaultCellStyle.ForeColor = Color.Black
                Case Is = "ORDEM PESAGEM"
                    R.DefaultCellStyle.BackColor = Color.LightSkyBlue
                    R.DefaultCellStyle.ForeColor = Color.Black
                Case Is = "LIBERADO BUSCAR"
                    R.DefaultCellStyle.BackColor = Color.LightCyan
                    R.DefaultCellStyle.ForeColor = Color.Black
                Case Is = "CANCELADO"
                    R.DefaultCellStyle.BackColor = Color.LightCoral
                    R.DefaultCellStyle.ForeColor = Color.Black
                Case Is = "FATURADO"
                    R.DefaultCellStyle.BackColor = Color.Navy
                    R.DefaultCellStyle.ForeColor = Color.Black
            End Select
        Next
    End Sub

    Private Sub frmPortaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlAux.Height = 0
        SetaForm()
        dgvDados.ContextMenuStrip = ContextMenuStrip1
        dtDataInicial.Value = Date.Now
        dtDataFinal.Value = Date.Now

    End Sub

    Private Sub btnPesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesar.Click
        funcF8()
    End Sub

    Public Overrides Sub funcF8()
        'MyBase.funcF8()
        'If Me.dgvDados.idSel <> -1 Then
        '    If status < 2 Then
        '        If idTiket = -1 Then
        '            Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.QueriesTableAdapter
        '            idTiket = dr.CopiaPortariaTiket(Me.dgvDados.idSel)
        '        End If
        '        My.Forms.frmCadastroTiket.ID = idTiket
        '        My.Forms.frmCadastroTiket.ShowDialog()
        '        Filtrar()
        '    Else
        '        MsgBox("Não é Possivel Pesar Caminhões que Estão na 2° Pesagem!", MsgBoxStyle.Information, "Aviso")
        '    End If
        'End If
    End Sub

    Public Overrides Sub funcF10()
        'If Me.dgvDados.idSel <> -1 Then
        '    If status = 4 OrElse TIPOPORT = "OUTROS" AndAlso status = 0 Then
        '        If MessageBox.Show("Deseja Realmente dar Saída nesse Veículo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes Then
        '            Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.QueriesTableAdapter
        '            dr.SaidaPortaria(Me.dgvDados.idSel)
        '            Filtrar()
        '        End If
        '    Else
        '        MsgBox("Apenas Veículos de 2° Pesagem Podem dar Saída!", MsgBoxStyle.Information, "Aviso")
        '    End If
        'Else
        '    MsgBox("Selecione um Registro Para dar Saída no Veículo!", MsgBoxStyle.Information, "Aviso")
        'End If
    End Sub

    Private Sub btnSaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaida.Click
        funcF10()
    End Sub
    'Vis. Guia
    Private Sub FbButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisGuia.Click
        funcF11()
    End Sub

    Public Overrides Sub funcF11()
        MyBase.funcF11()
        If pnlAux.Height = 125 Then
            pnlAux.Height = 0
            dgvGuia.DataSource = Nothing
        Else
            pnlAux.Height = 125
            carregaGUIAGRID()
        End If

    End Sub

    Private Sub carregaGUIAGRID()
        Dim ssql As New StringBuilder()
        ssql.Append("SELECT ID, NUMERO, (CONVERT(varchar,DATA,103) + ' ' +")
        ssql.Append("SUBSTRING(CONVERT(varchar,DATA,108),1,5)) as DATA, ")
        ssql.Append("(SELECT d.Nome FROM TB_DOMICILIO d WHERE d.ID = IDDomicilio) as PRODUTOR,")
        ssql.Append(" QUANTIDADE, PESO ")
        ssql.Append(" from TB_GSBX")
        ssql.Append(" WHERE status = 0")
        ssql.Append(" AND IDEMPRESA = ")
        ssql.Append(My.Forms.frmPadrao.IDEmpresa.ToString())
        ssql.Append(" order by Data")
        Dim dt = fbConnection.executaSelect(ssql.ToString())
        dgvGuia.DataSource = dt
        If dgvGuia.Columns.Count > 0 Then
            dgvGuia.Columns.Item("PRODUTOR").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    'Private Sub dgvGuia_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If dgvGuia.idSel <> -1 Then
    '        My.Forms.frmCadastroPortaria.ID = -1
    '        If My.Forms.frmCadastroPortaria.Created = True Then
    '            My.Forms.frmCadastroPortaria.Close()
    '        End If
    '        My.Forms.frmCadastroPortaria.IDGuia = dgvGuia.idSel
    '        My.Forms.frmCadastroPortaria.ShowDialog()
    '        Filtrar()
    '    End If
    'End Sub

    Private Sub menuPortaria_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPortaria.SizeChanged
        pnlAux.Height = menuPortaria.Height
    End Sub

    Private Sub cbbTipo_Selecionando() Handles cbbTipo.Selecionando
        txtGuia.Clear()
        If cbbTipo.ValorSelecionado = 0 Then
            txtGuia.Enabled = True
        ElseIf cbbTipo.ValorSelecionado = 1 Then
            txtGuia.Enabled = True
        Else
            txtGuia.Enabled = False
        End If
    End Sub

    Private Sub lkpProdutor_antesDeAbrir() Handles lkpProdutor.antesDeAbrir
        setaForm()
    End Sub

    Private Sub FbButtonVisual1_Click(sender As Object, e As EventArgs) Handles FbButtonVisual1.Click
        RelatorioF12()
    End Sub

    Public Overrides Sub RelatorioF12()
        My.Forms.frmMain2.abreForm(frmRelPortaria, "S", 1)
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged, rbEntrada.CheckedChanged,
        rbLiberaPesagem.CheckedChanged, rbOrdemPesagem.CheckedChanged, rbLiberaBuscar.CheckedChanged,
        rbPesagem1.CheckedChanged, rbPesagem2.CheckedChanged, rbSaida.CheckedChanged, rbSolicitacao.CheckedChanged,
        rbAgendamento.CheckedChanged, rbTodosTipos.CheckedChanged, rbTipoEntrada.CheckedChanged,
        rbAgendado.CheckedChanged, rbSolicitado.CheckedChanged, rbCancelado.CheckedChanged, rbFaturado.CheckedChanged

        If rbTodos.Checked Then
            Filtrar()
        ElseIf rbTodosTipos.Checked Then
            Filtrar()
        ElseIf rbEntrada.Checked Then
            Filtrar()
        ElseIf rbLiberaPesagem.Checked Then
            Filtrar()
        ElseIf rbOrdemPesagem.Checked Then
            Filtrar()
        ElseIf rbPesagem1.Checked Then
            Filtrar()
        ElseIf rbPesagem2.Checked Then
            Filtrar()
        ElseIf rbSaida.Checked Then
            Filtrar()
        ElseIf rbAgendado.Checked Then
            Filtrar()
        ElseIf rbSolicitado.Checked Then
            Filtrar()
        ElseIf rbLiberaBuscar.Checked Then
            Filtrar()
        ElseIf rbTipoEntrada.Checked Then
            Filtrar()
        ElseIf rbAgendamento.Checked Then
            Filtrar()
        ElseIf rbSolicitacao.Checked Then
            Filtrar()
        ElseIf rbFaturado.Checked Then
            Filtrar()
        ElseIf rbCancelado.Checked Then
            Filtrar()
        End If
    End Sub

    Private Sub EntradaAgendamento()
        If Me.dgvDados.idSel <> -1 Then
            If status = 7 OrElse status = 6 Then
                If MessageBox.Show("Deseja liberar a entrada deste veículo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes Then
                    'Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.QueriesTableAdapter
                    'dr.SaidaPortaria(Me.dgvDados.idSel)
                    Filtrar()
                End If
            Else
                MsgBox("!", MsgBoxStyle.Information, "Aviso")
            End If
        Else
            MsgBox("Selecione um registro para liberar a entrada do veículo!", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub OrdemPesar()
        If Me.dgvDados.idSel <> -1 Then
            If status = 1 Then
                If MessageBox.Show("Deseja mandar este veículo para pesagem?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes Then
                    'Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.QueriesTableAdapter
                    'dr.SaidaPortaria(Me.dgvDados.idSel)
                    Filtrar()
                End If
            Else
                MsgBox("!", MsgBoxStyle.Information, "Aviso")
            End If
        Else
            MsgBox("Selecione um registro para mandar o veículo para pesagem!", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub Faturar()
        If Me.dgvDados.idSel <> -1 Then
            If status = 4 Then
                If MessageBox.Show("Faturar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes Then
                    'Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.QueriesTableAdapter
                    'dr.SaidaPortaria(Me.dgvDados.idSel)
                    Filtrar()
                End If
            Else
                MsgBox("!", MsgBoxStyle.Information, "Aviso")
            End If
        Else
            MsgBox("Selecione um registro para Faturar!", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub LiberarBuscar()
        If Me.dgvDados.idSel <> -1 Then
            If status = 8 Then
                If MessageBox.Show("Deseja liberar este veículo para buscar a carga?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes Then
                    'Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.QueriesTableAdapter
                    'dr.SaidaPortaria(Me.dgvDados.idSel)
                    Filtrar()
                End If
            Else
                MsgBox("!", MsgBoxStyle.Information, "Aviso")
            End If
        Else
            MsgBox("Selecione um registro para liberar a entrada do veículo!", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub Cancelamento()
        If Me.dgvDados.idSel <> -1 Then
            If status = 7 Then
                If MessageBox.Show("Deseja cancelar este agendamento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes Then
                    'Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.QueriesTableAdapter
                    'dr.SaidaPortaria(Me.dgvDados.idSel)
                    Filtrar()
                End If
            ElseIf status = 8 Then
                If MessageBox.Show("Deseja cancelar esta solicitação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes Then
                    'Dim dr As New FeedComponentes.dtsArmazemSQLTableAdapters.QueriesTableAdapter
                    'dr.SaidaPortaria(Me.dgvDados.idSel)
                    Filtrar()
                End If
            Else
                MsgBox("!", MsgBoxStyle.Information, "Aviso")
            End If
        Else
            MsgBox("Selecione um registro para liberar a entrada do veículo!", MsgBoxStyle.Information, "Aviso")
        End If

    End Sub

    Private Sub SaidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaidaToolStripMenuItem.Click
        funcF10()
    End Sub

    Private Sub EntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaToolStripMenuItem.Click
        EntradaAgendamento()
    End Sub

    Private Sub OrdemPPesarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdemPPesarToolStripMenuItem.Click
        OrdemPesar()
    End Sub

    Private Sub FaturadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaturadoToolStripMenuItem.Click
        Faturar()
    End Sub

    Private Sub LiberarPBuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiberarPBuscarToolStripMenuItem.Click
        LiberarBuscar()
    End Sub

    Private Sub CancelamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CancelamentoToolStripMenuItem1.Click
        Cancelamento()
    End Sub
End Class