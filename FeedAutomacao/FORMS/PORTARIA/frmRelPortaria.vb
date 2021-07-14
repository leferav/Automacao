Public Class frmRelPortaria

    Dim st As Integer
    Dim tp As Integer

    Public Overrides Sub Relatorio()
        MyBase.Relatorio()

        If cbbTipo.ValorSelecionado = "CARGA" Then
            tp = 0
        ElseIf cbbTipo.ValorSelecionado = "DESCARGA" Then
            tp = 1
        ElseIf cbbTipo.ValorSelecionado = "OUTROS" Then
            tp = 2
        ElseIf cbbTipo.ValorSelecionado = "VISITA" Then
            tp = 3
        End If

        If rbTodos.Checked = True Then
            st = 9
        ElseIf rbEntrada.Checked = True Then
            st = 0
        ElseIf rbPesagem1.Checked = True Then
            st = 1
        ElseIf rbPesagem2.Checked = True Then
            st = 2
        ElseIf rbSaida.Checked = True Then
            st = 3
        End If

        Dim dtIni As DateTime
        If txtData.Checked = True Then
            dtIni = Convert.ToDateTime(txtData.Value.ToString("dd/MM/yyyy") + " 00:00:00")
        Else
            dtIni = "01/01/1900"
        End If

        Dim dtFim As DateTime
        If txtDataFim.Checked = True Then
            dtFim = Convert.ToDateTime(txtDataFim.Value.ToString("dd/MM/yyyy") + " 23:59:59")
        Else
            dtFim = "31/12/2200"
        End If




        Me.TipoRel = FeedAutomacao.TipoRel.Rel.RelControlePortariaTicket

        Dim tb As dtsRelPortaria.ControlePortariaCASEMGDataTable
        Dim tr As New dtsRelPortariaTableAdapters.ControlePortariaCASEMGTableAdapter
        tb = tr.GetData(dtIni, dtFim, tp, cbbDomicilio.ValorSelecionado, cbbVeiculo.ValorSelecionado, cbbFuncionario.ValorSelecionado)

        Dim tb2 As dtsRelPortaria.retornaDadosEmpresa2DataTable
        Dim tr2 As New dtsRelPortariaTableAdapters.retornaDadosEmpresa2TableAdapter
        tb2 = tr2.GetData(My.Forms.frmPadrao.IDEmpresa, dtIni, "")

        Me.DataSetRel.Tables.Add(tb)
        Me.DataSetRel.Tables.Add(tb2)




    End Sub

    Private Sub frmRelBalanca_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtData.Value = Date.Now
        txtDataFim.Value = Date.Now
        cbbDomicilio.ValorSelecionado = -1
        cbbTipo.ValorSelecionado = -1
        cbbFuncionario.ValorSelecionado = -1
        cbbVeiculo.ValorSelecionado = -1
        cbbDomicilio.Filtro = " ativo = 1 and IDEmpresa = " + My.Forms.frmPadrao.IDEmpresa.ToString()
        Dim sql = "SELECT IDTIPOFUNCIONARIO FROM TB_CONF_ARMAZEM WHERE IDEMPRESA = " + My.Forms.frmPadrao.IDEmpresa.ToString()
        cbbFuncionario.Filtro = "IDTipoPessoa = " + fbConnection.retornaValorUnico(sql).ToString()
    End Sub


End Class
