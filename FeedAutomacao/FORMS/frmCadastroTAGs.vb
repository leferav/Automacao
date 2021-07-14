Imports System.Data.SqlClient
Public Class frmCadastroTAGs
    Public Shared sCon As New SqlClient.SqlConnection(My.Settings.FeedAutomacaoConnectionString)

    Private Sub frmGerenciaTag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PopulacbxTipoPessoa()
        'LimparConsulta()

        rbTodos.Checked = True
        pnlTop.Visible = True
        txtLeituraTag.Visible = False
        txtNumeroTAG.Visible = False

        mostrarTagsCadastradas()
        'mostrarTagsLidas()
        'CarregaRegistros()
    End Sub

    Public Function mostrarTagsCadastradas(Optional ByVal filtro As Boolean = True)

        'Dim TAG_LIDA As String = "select TOP 1 TAG from TB_AUTOMACAO_TAG_LIDA order by id desc"
        'Dim exc1 = cldBancoDados.executaSelect(TAG_LIDA)
        'If exc1.Rows(0).Item("TAG") <> "" Then
        '    Dim tag = exc1.Rows(0).Item("TAG")
        '    Dim return_status As Integer = fbConnection.retornaValorUnico($"execute Automacao_VericaTAGs '{tag}' ")
        '    ' Dim executa As Integer = fbConnection.retornaValorUnico(return_status)

        '    Select Case return_status
        '        Case 1
        '            'MsgBox($"Tag de fechamento: {tag}", MsgBoxStyle.Information)
        '            'txtInfTAG.Text = "Tag: " + tag + " Ação de Fechamento!!"
        '            'txtInfTAG.BackColor = Color.Orange

        '        Case 2
        '            'MsgBox($"Tag cadastrada: {tag}", MsgBoxStyle.Information)
        '            Dim sSql2 As String
        '            sSql2 = "select TOP 1 p.Nome from TB_AUTOMACAO_TAG_LIDA tl"
        '            sSql2 += " inner join TB_AUTOMACAO_TAG t on t.tag = tl.tag"
        '            sSql2 += " inner join TB_PESSOA p on p.ID = t.IDPessoa"
        '            sSql2 += " order by tl.Id desc"
        '            Dim exec2 = cldBancoDados.executaSelect(sSql2)
        '            If exec2.Rows(0).Item("Nome") <> "" Then
        '                Dim NomeTag = exec2.Rows(0).Item("Nome")
        '                'txtInfTAG.Text = "Seja bem vindo! " + NomeTag
        '                'txtInfTAG.BackColor = Color.Green

        '            End If

        '        Case 3
        '            'MsgBox($"Tag cadastrada disponível: {tag}", MsgBoxStyle.Information)
        '            'txtInfTAG.Text = "Tag: " + tag + " Cadastrada Disponivel. "
        '            'txtInfTAG.BackColor = Color.RoyalBlue
        '        Case Else
        '            'MsgBox($"Tag não cadastrada : {tag}", MsgBoxStyle.Critical)
        '            'txtInfTAG.Text = "Tag: " + tag + " Não Cadastrada!!"
        '            'txtInfTAG.BackColor = Color.OrangeRed
        '    End Select
        'Else
        '    MsgBox("Erro na Leitura da TAG!", MsgBoxStyle.Critical)
        'End If

        Dim sql As String
        If rbTodos.Checked Then
            sql = "select p.Nome, t.Numero, p.IDTag, t.tag from TB_PESSOA p "
            sql += " inner join TB_AUTOMACAO_TAG t on p.IDTag = t.IDTag and p.IDTag is not null"
        Else
            If rbTAGsDisponíveis.Checked Then
                sql = "select p.Nome, t.Numero, p.IDTag, t.tag from TB_PESSOA p "
                sql += " inner join TB_AUTOMACAO_TAG t on p.IDTag = t.IDTag and p.IDTag is not null"
            Else
                sql = "select p.Nome, t.Numero, p.IDTag, t.tag from TB_PESSOA p "
                sql += " inner join TB_AUTOMACAO_TAG t on p.IDTag = t.IDTag and p.IDTag is not null"
            End If
        End If
        Dim exc = fbConnection.executaSelect(sql)
        dtGridTag.DataSource = exc
        Return Nothing
    End Function

    Private Sub btnCadTAGs_Click(sender As Object, e As EventArgs) Handles btnCadTAGs.Click
        Try
            Dim sql As String = "SELECT top 1* FROM TB_AUTOMACAO_TAG_LIDA order by id desc"
            Dim cmd As SqlCommand = New SqlCommand(sql, sCon)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            txtLeituraTag.Visible = True
            txtNumeroTAG.Visible = True
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                LbDataLeituraTag.Text = "Data da Leitura: " + dt.Rows(0).Item("DataLeitura")
                txtLeituraTag.Text = dt.Rows(0).Item("TAG")
            Else
                MsgBox("Tag não cadastrada no banco de dados!", MsgBoxStyle.Information)
            End If

            Dim sql1 As String = "select top 1 Numero From TB_AUTOMACAO_TAG order by IDTag desc"
            Dim cmd1 As SqlCommand = New SqlCommand(sql1, sCon)
            Dim da1 As SqlDataAdapter = New SqlDataAdapter(cmd1)
            Dim dt1 As DataTable = New DataTable
            da1.Fill(dt1)
            If dt1.Rows.Count > 0 Then
                txtNumeroTAG.Text = dt1.Rows(0).Item("Numero") + 1
            Else
                MsgBox("Erro no Numero da TAG!", MsgBoxStyle.Information)
            End If



            If MessageBox.Show("Deseja cadastrar a TAG?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                sCon.Open()
                Dim cmd2 As New SqlCommand
                cmd2 = New Data.SqlClient.SqlCommand("INSERT INTO TB_AUTOMACAO_TAG (TAG, Numero) VALUES (@field1, @field2)", sCon)
                With cmd2
                    .Parameters.AddWithValue("@field1", txtLeituraTag.Text)
                    .Parameters.AddWithValue("@field2", txtNumeroTAG.Text)
                End With
                cmd2.ExecuteNonQuery()
                cmd2.Dispose()
                MsgBox("Tag Cadastrado!", MsgBoxStyle.Information)
            Else
            End If
            txtLeituraTag.Visible = False
            txtNumeroTAG.Visible = False
            sCon.Close()
            LbDataLeituraTag.Text = ""
            txtNumeroTAG.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
            sCon.Close()
        End Try
        sCon.Close()
        txtLeituraTag.Visible = False
        txtNumeroTAG.Visible = False
        LbDataLeituraTag.Text = ""
        txtNumeroTAG.Text = ""
        mostrarTagsCadastradas()
        'mostrarTagsLidas()

    End Sub


    Public Sub Excluir(ByVal IDSel As Integer)

        Dim sql As String = ""
        Dim sql_agenda As String = ""
        Dim sql_os As String = ""

        If MsgBox("Confirma exclusão do Cliente ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql_agenda += $"select * FROM dbo.agenda WHERE id_cliente = {IDSel} "
            Dim exc_agenda = fbConnection.executaSelect(sql_agenda)
            sql_os += $"select * FROM dbo.tb_os WHERE id_cliente = {IDSel} "
            Dim exc_os = fbConnection.executaSelect(sql_os)
            If ((exc_agenda.Rows.Count = 0) And (exc_os.Rows.Count = 0)) Then
                sql += $"DELETE FROM tb_cliente WHERE id_cliente = {IDSel} "
                Dim exc = fbConnection.executaCommand(sql)
                MsgBox("Dados excluídos com sucesso!")
            Else
                MsgBox("Existem regitro(s) lançado(s) na tabela AGENDA ou OS, relacionados a este cliente. Exclusão não pode ser realizada!")
            End If
        End If

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Me.Close()
    End Sub

    Private Sub frmGerenciaCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub dtGridTag_DataSourceChanged(sender As Object, e As EventArgs) Handles dtGridTag.DataSourceChanged
        dtGridTag.Columns("TAG").Width = 100
        dtGridTag.Columns("Nome").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        mostrarTagsCadastradas()
    End Sub

    Private Sub rbTAGsUtilizadas_CheckedChanged(sender As Object, e As EventArgs) Handles rbTAGsUtilizadas.CheckedChanged
        mostrarTagsCadastradas()
    End Sub
End Class
