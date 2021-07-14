Imports System.Windows.Forms
Public Class frmInsereTipoAcesso
    Dim dt As dtsTipoAcesso.TB_ACESSO_CLIENTESDataTable
    Dim dr As New dtsTipoAcessoTableAdapters.TB_ACESSO_CLIENTESTableAdapter
    Friend row As dtsTipoAcesso.TB_ACESSO_CLIENTESRow
    Dim msg As Boolean = True

    Private Sub setaForm()



    End Sub



    Public Overrides Function Limpar() As Boolean
        MyBase.Limpar()

        CbbTipoAcesso.ValorSelecionado = -1
        txtIDUser.Text = ""
        txtIP.Text = ""
        txtSenha.Text = ""

        Return MyBase.Limpar()
    End Function

    Public Overrides Function Editar(ByVal IDSel As Integer) As Boolean

        ID = IDSel
        If IDSel <> -1 Then
            dt = dr.GetDataByID(IDSel)
            row = dt.FindByID(IDSel)


            If row.IsIDTipoAcessoNull = False Then
                CbbTipoAcesso.ValorSelecionado = row.IDTipoAcesso
            Else
                CbbTipoAcesso.ValorSelecionado = -1
            End If

            If row.IsID_USERNull = False Then
                txtIDUser.Text = row.ID_USER
            Else
                txtIDUser.Text = ""
            End If

            If row.IsIPNull = False Then
                txtIP.Text = row.IP
            Else
                txtIP.Text = ""
            End If

            If row.IsSenhaNull = False Then
                txtSenha.Text = row.Senha
            Else
                txtSenha.Text = ""
            End If

            If row.IsobsNull = False Then
                txtObs.Text = row.obs
            Else
                txtObs.Text = ""
            End If


            Carrega()
        Else
            MsgBox("Erro ao Carregar o Registro!", MsgBoxStyle.Critical)
        End If
        Return MyBase.Editar(IDSel)
    End Function



    Public Overrides Function Salvar(ByVal IDSel As Integer) As Boolean
        If MyBase.Salvar(IDSel) = True Then
            Carrega()
            If IDSel = -1 Then
                Carrega()
                row = dt.NewTB_ACESSO_CLIENTESRow
            Else
                Carrega()
                row = dt.FindByID(IDSel)
            End If

            row.IDCliente = IDRelacionamento
            row.IDTipoAcesso = CbbTipoAcesso.ValorSelecionado
            row.ID_USER = txtIDUser.Text
            row.IP = txtIP.Text
            row.Senha = txtSenha.Text
            row.obs = txtObs.Text


            If IDSel = -1 Then
                dt.AddTB_ACESSO_CLIENTESRow(row)
            End If

            dr.Update(dt)
            If msg Then
                msgSalvar()
                Esc()
            End If
            If IDSel = -1 Then
                IDSel = dr.MAXID
                ID = IDSel
            End If
            Return True
        End If
        Return False
    End Function



    Public Overrides Function Excluir(ByVal IDSel As Integer) As Boolean

        If IDSel <> -1 Then
            Try
                Carrega()
                row = dt.FindByID(IDSel)
                row.Delete()
                dr.Update(dt)
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

        Return MyBase.Excluir(IDSel)
    End Function



    Public Overrides Sub Carrega(Optional ByVal IDParent As Integer = -1)
        MyBase.Carrega(IDParent)
        dt = dr.GetDataByID(ID)

        Dim sql As String = "Select A.ID,"
        sql += "c.NOME AS 'ACESSO',"
        sql += "A.IP AS 'IP',"
        sql += "A.ID_USER AS 'ID/USUÁRIO',"
        sql += "A.SENHA AS 'SENHA',"
        sql += "A.obs as 'INF.ACESSO'"
        sql += "  From TB_ACESSO_CLIENTES A "
        sql += " INNER JOIN TB_CLIENTES T ON A.IDCLIENTE = T.ID  "
        sql += " INNER JOIN TB_TIPO_ACESSO c ON C.ID = A.IDTIPOACESSO "
        sql += "  WHERE A.IDCliente =" + IDRelacionamento.ToString()
        Dados = fbConnection.executaSelect(sql)


    End Sub





    Public Overridable Sub F12()
        MyBase.funcF12()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        salvandoDados()
    End Sub


    Public Overridable Sub Esc()
        ShowDialogs = False
        Me.Close()
    End Sub

    Private Sub btnFecharTela_Click(sender As Object, e As EventArgs) Handles btnFecharTela.Click
        Esc()
    End Sub

    Private Sub CbbTipoAcesso_Selecionando() Handles CbbTipoAcesso.Selecionando
        If CbbTipoAcesso.ValorSelecionado <> -1 Then
            Dim bombinha As String = "SELECT isnull(X.Observacao,'') as 'obs' FROM TB_TIPO_ACESSO X with (nolock) WHERE X.ID =" + CbbTipoAcesso.ValorSelecionado.ToString()
            Dim traz_dados = fbConnection.executaSelect(bombinha)
            If traz_dados IsNot Nothing AndAlso traz_dados.Rows.Count > 0 Then
                txtObs.Text = traz_dados.Rows(0).Item("obs")
            End If
        End If


    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Excluir(ID)
    End Sub
End Class
