Imports System.ComponentModel
Public Class frmSelecionaContexto2
    Public empresaSel As Integer = -1

    Private Sub escolhe()
        empresaSel = cbbConta.ValorSelecionado
        If empresaSel <> -1 Then
            Me.Close()
        End If
    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click
        escolhe()
    End Sub

    Private Sub frmSelecionaContexto2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F2 Then
            escolhe()
        ElseIf e.KeyCode = Keys.Enter Then
            escolhe()
        End If
    End Sub

    Private Sub frmSelecionaConta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        empresaSel = -1
        cbbConta.Filtro = "ID in (SELECT IDEmpresa FROM TB_USUARIO_EMPRESA WHERE IDUsuario = " + My.Forms.frmPadrao.IDUsuario.ToString() + ")"
        cbbConta.carregaTabela()
        If cbbConta.DataSource IsNot Nothing AndAlso cbbConta.DataSource.rows.count > 0 Then
            If cbbConta.DataSource.rows.count = 2 Then
                empresaSel = cbbConta.DataSource.rows(1).item("ID")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub cbbConta_Selecionando() Handles cbbConta.Selecionando
        If cbbConta.ValorSelecionado <> -1 Then
            Dim sql As String = $"SELECT isnull(CNPJ,'') as CNPJ, ISNULL(IE,'') AS IE , ISNULL(CIDADE,'') AS CIDADE FROM TB_EMPRESA WITH (NOLOCK) WHERE ID = {cbbConta.ValorSelecionado}"
            Dim exc As DataTable = fbConnection.executaSelect(sql)
            If exc IsNot Nothing AndAlso exc.Rows.Count > 0 Then
                GroupBox1.Visible = True
                lblCidade.Text = "CIDADE: " & exc.Rows(0).Item("CIDADE").ToString.ToUpper()
                lblIE.Text = "IE: " & exc.Rows(0).Item("IE").ToString
                lblCNPJ.Text = "CNPJ: " & FormatarCpfCnpj(exc.Rows(0).Item("CNPJ").ToString)
            End If
        End If
    End Sub

    Public Shared Function FormatarCpfCnpj(ByVal strCpfCnpj As String) As String
        If strCpfCnpj.Length <= 11 Then
            Dim mtpCpf As MaskedTextProvider = New MaskedTextProvider("000\.000\.000-00")
            mtpCpf.[Set](ZerosEsquerda(strCpfCnpj, 11))
            Return mtpCpf.ToString()
        Else
            Dim mtpCnpj As MaskedTextProvider = New MaskedTextProvider("00\.000\.000/0000-00")
            mtpCnpj.[Set](ZerosEsquerda(strCpfCnpj, 11))
            Return mtpCnpj.ToString()
        End If
    End Function

    Public Shared Function ZerosEsquerda(ByVal strString As String, ByVal intTamanho As Integer) As String
        Dim strResult As String = ""

        For intCont As Integer = 1 To (intTamanho - strString.Length)
            strResult += "0"
        Next

        Return strResult & strString
    End Function
End Class
