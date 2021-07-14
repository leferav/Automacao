Imports System.Net
Imports System.Net.Http
Imports System.Runtime.InteropServices



Public Class frmAutomacao
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr,
                                   ByVal wMsg As Integer,
                                   ByVal wParam As Integer,
                                   ByVal lParam As Integer)

    End Sub

    Public Const sqlIP As String = "select top 1 e.IPCancela from TB_AUTOMACAO_TAG_LIDA tl inner join TB_AUTOMACAO_EQUIPAMENTOS e on e.IPRFID_1 = tl.IP order by tl.Id desc"



    Dim UDPsender As New Sockets.UdpClient(0)
    Dim cmd As String

    Private Sub frmAutomacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ckbCancela1.Checked = False
        'PictureBoxCancela1.Visible = False
        Timer1.Stop()
        mostrarDados()
        mostrarStatusCancela()


    End Sub

    Private Sub mostrarDados()
        Try
            Filtrar()
            mostrarStatusCancela()

        Catch ex As Exception
            MsgBox("Erro ao mostrar dados da Leitura da Cancela" + ex.Message)
        End Try
    End Sub

    Private Sub mostrarStatusCancela()
        Try
            Dim sql As String
            sql = "select NomeCancela, NomeRFID_1, NomeRFID_2 from TB_AUTOMACAO_EQUIPAMENTOS where Status = 1"
            Dim exc = fbConnection.executaSelect(sql)
            dtGridStatusCancela.DataSource = exc

            'Dim exec = cldBancoDados.executaSelect(sqlIP)
            'Dim Endereco = exec.Rows(0).Item("IPCancela")
            'Dim PingCancela As Boolean = My.Computer.Network.Ping(Endereco)

            dtGridStatusCancela.CurrentRow.DefaultCellStyle.BackColor = Color.WhiteSmoke
            Dim x As Integer
            For x = 0 To dtGridStatusCancela.Rows.Count - 1
                Dim idCancela As Integer = x + 1
                Dim sqlPing As String = $"select IPCancela from TB_AUTOMACAO_EQUIPAMENTOS where id = {idCancela} "
                Dim execPing = fbConnection.executaSelect(sqlPing)
                Dim EnderecoPing = execPing.Rows(0).Item("IPCancela")
                Dim PingCancela As Boolean = My.Computer.Network.Ping(EnderecoPing)
                If dtGridStatusCancela.Rows(x).Selected Then
                    dtGridStatusCancela.Rows(x).DefaultCellStyle.BackColor = Color.OrangeRed
                Else
                    If PingCancela = False Then
                        dtGridStatusCancela.Rows(x).DefaultCellStyle.BackColor = Color.Red
                    Else
                        dtGridStatusCancela.Rows(x).DefaultCellStyle.BackColor = Color.LimeGreen
                    End If
                End If

            Next


        Catch ex As Exception
            MsgBox("Erro ao mostrar Status da Cancela / Leitora!" + ex.Message)
        End Try
    End Sub

    Private Sub dtGridAutomacao_DataSourceChanged(sender As Object, e As EventArgs) Handles dtGridAutomacao.DataSourceChanged
        dtGridAutomacao.Columns("Data").Width = 110
        dtGridAutomacao.Columns("NumTAG").Width = 60
        dtGridAutomacao.Columns("Nome").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dtGridAutomacao.Columns("Nome Cancela").Width = 130
        dtGridAutomacao.Columns("Leitor Entrada").Width = 130
        dtGridAutomacao.Columns("Leitor Saida").Width = 130
        dtGridAutomacao.Columns("Status").Width = 60
    End Sub



    Public Sub envioComando(comand As String, Optional ByVal TIMEOUT As Integer = 20)
        Dim exec = fbConnection.executaSelect(sqlIP)
        If exec.Rows(0).Item("IPCancela") <> "" Then
            Dim Endereco = exec.Rows(0).Item("IPCancela")
            Dim uriBuilder = New UriBuilder($"http://{Endereco}/{comand}/ManualSof")
            Dim uri = uriBuilder.Uri
            Dim client = New HttpClient()
            Try
                Dim taskGet = client.GetAsync(uri)
                Dim PingCancela As Boolean = My.Computer.Network.Ping(Endereco)
                If PingCancela = False Then
                    MsgBox("Cancela desconectada!!!!!")
                Else
                    Dim response = taskGet.Result
                    Try
                        Dim taskResp = response.Content.ReadAsStringAsync()
                        taskResp.Wait()
                        Dim msgRetorno = ""
                        msgRetorno = taskResp.Result()
                    Catch ex As Exception
                        MsgBox($"Erro ao enviar comando: {ex.Message}", MsgBoxStyle.Critical)
                    Finally
                        If response IsNot Nothing Then response.Dispose()
                    End Try
                End If

            Catch ex As Exception
                Throw New Exception("Erro ao conectar com a Cancela!!! " + ex.Message)
            Finally
                If client IsNot Nothing Then client.Dispose()
            End Try
        End If
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        envioComando("H")
        'mostrarDados()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        envioComando("L")
        'mostrarDados()
    End Sub




    Private Sub ckbCancela1_CheckedChanged(sender As Object, e As EventArgs) Handles ckbCancela1.CheckedChanged
        If ckbCancela1.Checked = True Then
            Timer1.Start()
            PictureBoxCancela1.Visible = True
            mostrarStatusCancela()
            btnAbrir.Visible = False
            btnFechar.Visible = False
        Else
            Timer1.Stop()
            PictureBoxCancela1.Visible = False
            Dim x As Integer
            For x = 0 To dtGridStatusCancela.Rows.Count - 1
                dtGridStatusCancela.Rows(x).DefaultCellStyle.BackColor = Color.WhiteSmoke
            Next
            btnAbrir.Visible = True
            btnFechar.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mostrarDados()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Me.Close()
    End Sub

    Private Sub btnCarregar_Click(sender As Object, e As EventArgs) Handles btnCarregar.Click
        mostrarDados()
    End Sub

    Private Sub dtGridStatusCancela_DataSourceChanged(sender As Object, e As EventArgs) Handles dtGridStatusCancela.DataSourceChanged
        dtGridStatusCancela.Columns("NomeCancela").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dtGridStatusCancela.Columns("NomeRFID_1").Width = 125
        dtGridStatusCancela.Columns("NomeRFID_2").Width = 125

    End Sub



    Public Function Filtrar(Optional ByVal filtro As Boolean = True)
        Dim sql As String = ""

        sql = "SELECT  "
        sql += "c.Data, "
        sql += "t.Numero as NumTAG,"
        sql += "p.Nome, "
        sql += "e.NomeCancela As 'Nome Cancela', "
        sql += "e.NomeRFID_1 as 'Leitor Entrada', "
        sql += "e.NomeRFID_2 as 'Leitor Saida', "
        sql += "c.StatusCancela as Status "
        sql += "From TB_AUTOMACAO_TAG_LIDA tl "
        sql += "inner Join TB_AUTOMACAO_TAG t on tl.tag = t.tag "
        sql += "inner Join TB_PESSOA p on p.IDTag = t.IDTag "
        sql += "inner Join TB_AUTOMACAO_EQUIPAMENTOS e on e.IPRFID_1 = tl.IP "
        sql += "inner Join TB_AUTOMACAO_CANCELA c on c.idTAG = t.IDTag  and c.IDTagLida = tl.Id "


        If txtNome.Text <> "" Then
            sql += $"and p.Nome like '%{txtNome.Text}%' "
        End If

        If dtini.Checked = True Then
            sql += " AND Data >= '" + dtini.Value.ToString("dd/MM/yyyy 00:00:00") + "'"
        End If

        If dtfim.Checked = True Then
            sql += " AND Data <= '" + dtfim.Value.ToString("dd/MM/yyyy 23:59:59") + "'"
        End If

        If TxtNumeroTAG.Text <> "" Then
            sql += $"and t.Numero like '%{TxtNumeroTAG.Text}%' "
        End If

        If txtCancela.Text <> "" Then
            sql += $"and e.NomeCancela like '%{txtCancela.Text}%' "
        End If

        If txtLeitorEntrada.Text <> "" Then
            sql += $"and e.NomeRFID_1 like '%{txtLeitorEntrada.Text}%' "
        End If


        sql += "order by Data desc"

        Dim exc = fbConnection.executaSelect(sql)
        dtGridAutomacao.DataSource = exc

        Return Nothing
    End Function



    Public Function FiltrarPortaria(Optional ByVal filtro As Boolean = True)
        Dim sql As String = ""

        sql = "SELECT  "
        sql += "c.Data, "
        sql += "t.Numero as NumTAG, "
        sql += "tk.Numero As NumTicket, "
        sql += "e.NomeCancela As 'Nome Cancela', "
        sql += "e.NomeRFID_1 as 'Leitor Entrada', "
        sql += "e.NomeRFID_2 as 'Leitor Saida', "
        sql += "c.StatusCancela as Status "
        sql += "From TB_AUTOMACAO_TAG_LIDA tl "
        sql += "inner Join TB_AUTOMACAO_TAG t on tl.tag = t.tag "
        sql += "inner Join TB_PORTARIA p on p.IDTag = t.IDTag "
        sql += "Left Join TB_TIKET tk on tk.ID = p.IDTiket "
        sql += "inner Join TB_AUTOMACAO_EQUIPAMENTOS e on e.IPRFID_1 = tl.IP "
        sql += "inner Join TB_AUTOMACAO_CANCELA c on c.idTAG = t.IDTag  and c.IDTagLida = tl.Id "


        If txtNome.Text <> "" Then
            sql += $"and p.Nome like '%{txtNome.Text}%' "
        End If

        If dtini.Checked = True Then
            sql += " AND Data >= '" + dtini.Value.ToString("dd/MM/yyyy 00:00:00") + "'"
        End If

        If dtfim.Checked = True Then
            sql += " AND Data <= '" + dtfim.Value.ToString("dd/MM/yyyy 23:59:59") + "'"
        End If

        If TxtNumeroTAG.Text <> "" Then
            sql += $"and t.Numero like '%{TxtNumeroTAG.Text}%' "
        End If

        If txtCancela.Text <> "" Then
            sql += $"and e.NomeCancela like '%{txtCancela.Text}%' "
        End If

        If txtLeitorEntrada.Text <> "" Then
            sql += $"and e.NomeRFID_1 like '%{txtLeitorEntrada.Text}%' "
        End If


        sql += "order by Data desc"

        Dim exc = fbConnection.executaSelect(sql)
        dtGridAutomacao.DataSource = exc

        Return Nothing
    End Function

    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged
        Filtrar()
        FiltrarPortaria()
    End Sub

    Private Sub txtCancela_TextChanged(sender As Object, e As EventArgs) Handles txtCancela.TextChanged
        Filtrar()
        FiltrarPortaria()
    End Sub

    Private Sub txtLeitorEntrada_TextChanged(sender As Object, e As EventArgs) Handles txtLeitorEntrada.TextChanged
        Filtrar()
        FiltrarPortaria()
    End Sub

    Private Sub TxtNumeroTAG_TextChanged(sender As Object, e As EventArgs) Handles TxtNumeroTAG.TextChanged
        Filtrar()
        FiltrarPortaria()
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        txtNome.Text = ""
        TxtNumeroTAG.Text = ""
        txtCancela.Text = ""
        txtLeitorEntrada.Text = ""
        txtLeitorSaida.Text = ""
        dtini.Value = "31/12/1999"

    End Sub

    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        My.Forms.frmRelControleAcesso.ShowDialog()
    End Sub
End Class
