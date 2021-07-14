Public Class frmLiberarSistema

    Dim IDsel As Integer = -1


    Private Sub setaform()
        lkpCliente.FormularioPesquisa = frmPesquisaCliente
    End Sub

    Public Overrides Sub Filtrar(Optional ByVal filtra As Boolean = True)
        Me.Cursor = Cursors.WaitCursor
        Dim filtro As String = ""


        If lkpCliente.SelectID <> -1 Then
            filtro += (" AND c.ID = ")
            filtro += (Convert.ToString(lkpCliente.SelectID))
        End If

        Dim AT As String = ""
        If rbA.Checked Then
            filtro += (" AND c.ativo = 1")
        ElseIf rbI.Checked Then
            filtro += (" AND c.ativo = 0")
        End If

        If rbSetorWMS.Checked Then
            filtro += (" AND c.TipoCliente = 1")
        ElseIf rbSetorCom.Checked Then
            filtro += (" AND c.TipoCliente = 2")
        End If

        Dim ssql As String = ""

        ssql += " SELECT TOP 200 c.ID,"
        ssql += "c.Nome as 'CLIENTE', c.Observacao as 'Fantasia', CASE WHEN tipoCliente = 1 then 'Armazém' when tipocliente = 2 then 'Comercial' end as 'Setor', "
        ssql += " convert(nvarchar,DataBloqueio,103) as 'Data Bloqueio',"
        ssql += " CASE WHEN DataBloqueio IS NULL then 'Trava Não Gerada' when DataBloqueio > getdate() and DATEDIFF(DAY,GETDATE(),DataBloqueio) <= 7 THEN 'Trava Prestes à Vencer' when DataBloqueio > getdate() then 'Trava Válida' ELSE 'Trava Vencida' END as 'TravaWMS',"
        ssql += " CASE WHEN DataBloqueio IS NULL then 'Trava Não Gerada' when DataBloqueio > getdate() and DATEDIFF(DAY,GETDATE(),DataBloqueio) <= 7 THEN 'Trava Prestes à Vencer' when DataBloqueio > getdate() then 'Trava Válida' ELSE 'Trava Vencida' END as 'TravaERP'"
        ssql += " FROM TB_CLIENTES c with (nolock)"
        ssql += " WHERE c.ID = c.Id "
        ssql += filtro
        ssql += " order by c.nome,c.DataCadastro "
        Dim dt = fbConnection.executaSelect(ssql)
        dgvDados.DataSource = dt
        Me.Cursor = Cursors.Arrow
    End Sub


    Public Overrides Sub setaDts()
        MyBase.setaDts()
        If dgvDados.ColumnCount > 1 Then
            dgvDados.Columns("CLIENTE").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvDados.Columns("Data Bloqueio").MinimumWidth = 110
            dgvDados.Columns("Data Bloqueio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDados.Columns("Fantasia").MinimumWidth = 150
            dgvDados.Columns("Fantasia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDados.Columns("Setor").MinimumWidth = 110
            dgvDados.Columns("Setor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDados.Columns("TravaWMS").MinimumWidth = 150
            dgvDados.Columns("TravaWMS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDados.Columns("TravaERP").MinimumWidth = 150
            dgvDados.Columns("TravaERP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For Each R As DataGridViewRow In dgvDados.Rows
                Select Case R.Cells("TravaWMS").Value
                    Case Is = "Trava Não Gerada"
                        R.DefaultCellStyle.BackColor = Color.White

                        R.DefaultCellStyle.ForeColor = Color.Black
                    Case Is = "Trava Válida"
                        R.DefaultCellStyle.BackColor = Color.DarkGreen
                        R.DefaultCellStyle.ForeColor = Color.White
                    Case Is = "Trava Vencida"
                        R.DefaultCellStyle.BackColor = Color.DarkRed
                        R.DefaultCellStyle.ForeColor = Color.White
                    Case Is = "Trava Prestes à Vencer"
                        R.DefaultCellStyle.BackColor = Color.DarkGoldenrod
                        R.DefaultCellStyle.ForeColor = Color.White
                End Select
            Next
        End If
    End Sub


    Private Sub lkpCliente_antesDeAbrir() Handles lkpCliente.antesDeAbrir
        setaform()
    End Sub

    Private Sub frmGerenciaClientesFeed_Load(sender As Object, e As EventArgs) Handles Me.Load
        setaform()
    End Sub

    Private Sub ckbSeleciona_CheckedChanged(sender As Object, e As EventArgs) Handles ckbSeleciona.CheckedChanged
        If ckbSeleciona.Checked Then
            For Each r As DataGridViewRow In dgvDados.Rows
                r.Cells("ck").Value = True
            Next
            ckbSeleciona.Text = "Desmarcar Todos"
        Else
            For Each r As DataGridViewRow In dgvDados.Rows
                r.Cells("ck").Value = False
            Next
            ckbSeleciona.Text = "Selecionar Todos"
        End If
    End Sub

    Private Sub rbt_CheckedChanged(sender As Object, e As EventArgs) Handles rbt.CheckedChanged, rbA.CheckedChanged, rbI.CheckedChanged
        Filtrar()
    End Sub

    Private Sub lkpCliente_Selecionando() Handles lkpCliente.Selecionando
        Filtrar()
    End Sub

    Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click
        'ANOMESDIA
        'ANO LE INVERSO
        'MES LE NORMAL
        'DIA LE INVERSO
        Dim ANO As String = txtDataBloqueio.Value.ToString("yyyy")
        Dim MES As String = txtDataBloqueio.Value.ToString("MM")
        Dim DIA As String = txtDataBloqueio.Value.ToString("dd")

        If ANO <> "" Then
            ANO = ANO.Replace("0", "P")
            ANO = ANO.Replace("1", "O")
            ANO = ANO.Replace("2", "I")
            ANO = ANO.Replace("3", "U")
            ANO = ANO.Replace("4", "Y")
            ANO = ANO.Replace("5", "T")
            ANO = ANO.Replace("6", "R")
            ANO = ANO.Replace("7", "E")
            ANO = ANO.Replace("8", "W")
            ANO = ANO.Replace("9", "Q")
        End If
        If MES <> "" Then
            MES = MES.Replace("0", "Q")
            MES = MES.Replace("1", "W")
            MES = MES.Replace("2", "E")
            MES = MES.Replace("3", "R")
            MES = MES.Replace("4", "T")
            MES = MES.Replace("5", "Y")
            MES = MES.Replace("6", "U")
            MES = MES.Replace("7", "I")
            MES = MES.Replace("8", "O")
            MES = MES.Replace("9", "P")
        End If
        If DIA <> "" Then
            DIA = DIA.Replace("0", "P")
            DIA = DIA.Replace("1", "O")
            DIA = DIA.Replace("2", "I")
            DIA = DIA.Replace("3", "U")
            DIA = DIA.Replace("4", "Y")
            DIA = DIA.Replace("5", "T")
            DIA = DIA.Replace("6", "R")
            DIA = DIA.Replace("7", "E")
            DIA = DIA.Replace("8", "W")
            DIA = DIA.Replace("9", "Q")
        End If

        Dim TravaFeed As String = ""
        TravaFeed = ANO + MES + DIA

        Dim DataBloqueio = clCrypto.Encrypt(txtDataBloqueio.Value)
        For Each r As DataGridViewRow In dgvDados.Rows
            If r.Cells("ck").Value Then
                If ckbCorrecao.Checked = False Then
                    fbConnection.executaCommand("UPDATE TB_CLIENTES SET DataBloqueio = '" + txtDataBloqueio.Value.ToString("yyyy-MM-dd") +
                            "', TravaWMS = '" + TravaFeed + "' , TravaERP = '" + TravaFeed +
                            "' ,DadosEmp = '" + DataBloqueio.ToString() + "' , Correcao = 0 WHERE ID = " + r.Cells("ID").Value.ToString())
                Else
                    fbConnection.executaCommand("UPDATE TB_CLIENTES SET DataBloqueio = '" + txtDataBloqueio.Value.ToString("yyyy-MM-dd") +
              "', TravaWMS = '" + TravaFeed + "' , TravaERP = '" + TravaFeed +
              "' ,DadosEmp = '" + DataBloqueio.ToString() + "' , Correcao = 1 WHERE ID = " + r.Cells("ID").Value.ToString())
                End If

            End If
        Next

        MsgBox("Chaves de Acesso Geradas com Sucesso para a Data de Bloqueio selecionada!", MsgBoxStyle.Information, "Aviso")
        Filtrar()
    End Sub

    Private Sub rbSetorTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbSetorTodos.CheckedChanged, rbSetorWMS.CheckedChanged, rbSetorCom.CheckedChanged
        Filtrar()
    End Sub
End Class