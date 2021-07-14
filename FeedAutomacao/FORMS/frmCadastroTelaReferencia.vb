Public Class frmCadastroTelaReferencia


    Dim dt As dtsTipoAcesso.TB_TIPO_TELADataTable
    Dim dr As New dtsTipoAcessoTableAdapters.TB_TIPO_TELATableAdapter
    Dim row As dtsTipoAcesso.TB_TIPO_TELARow

    Public Overrides Function Limpar() As Boolean
        row = Nothing
        txtTipo.Clear()
        txtObservacao.Clear()
        Return MyBase.Limpar()
    End Function

    Public Overrides Function Editar(ByVal IDSel As Integer) As Boolean
        ID = IDSel
        If IDSel <> -1 Then
            dt = dr.GetData()
            row = dt.FindByID(IDSel)
            If row IsNot Nothing Then
                txtTipo.Text = row.Nome
                txtObservacao.Text = row.Observacao
                If row.IsCODNull = False Then
                    txtNumeroTela.Text = row.COD
                Else
                    txtNumeroTela.Text = ""
                End If

                If row.IsNomeTabelaNull = False Then
                    txtTabela.Text = row.NomeTabela
                Else
                    txtTabela.Text = ""
                End If

                If row.IsIDTipoSistemaNull = False Then
                    cbbSistema.ValorSelecionado = row.IDTipoSistema
                Else
                    cbbSistema.ValorSelecionado = -1
                End If

            Else
                    MsgBox("Erro ao Carregar o Registro!", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Selecione um Registro para Carregar!", MsgBoxStyle.Critical)
        End If
        Return MyBase.Editar(IDSel)
    End Function

    Public Overrides Function Salvar(ByVal IDSel As Integer) As Boolean
        If MyBase.Salvar(IDSel) = True Then
            If IDSel = -1 Then
                row = dt.NewTB_TIPO_TELARow
            Else
                row = dt.FindByID(IDSel)
            End If


            row.Nome = txtTipo.Text
            row.Observacao = txtObservacao.Text
            row.COD = txtNumeroTela.Text
            row.NomeTabela = txtTabela.Text
            row.IDTipoSistema = cbbSistema.ValorSelecionado


            If IDSel = -1 Then
                dt.AddTB_TIPO_TELARow(row)
            End If
            dr.Update(dt)
            msgSalvar()
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
                Carrega()
                msgExcluir()
                Return True
            Catch ex As SqlClient.SqlException
                If ex.ErrorCode = -2146232060 Then
                    MsgBox("Erro ao Excluir o Registro Pois Esta Relacionado a Outro Registro! ", MsgBoxStyle.Critical)
                Else
                    MsgBox("Erro ao Excluir o Registro! " + ex.Message, MsgBoxStyle.Critical)
                End If
                Carrega()
                Return False
            End Try
            Return False
        End If

    End Function


    Public Overrides Function Validar() As Boolean
        If txtTipo.Text = "" Then
            msgValida("Nome", txtTipo)
        ElseIf cbbSistema.ValorSelecionado = -1 Then
            msgValida("Sistema", cbbSistema)
            Return False
        End If
        Return True
    End Function

    Public Overrides Sub Carrega(Optional ByVal IDParent As Integer = -1)
        MyBase.Carrega(IDParent)
        dt = dr.GetData()
        Dados = dt
    End Sub

    Private Sub pesDados_antesDeAbrir() Handles pesDados.antesDeAbrir
        pesDados.FormularioPesquisa = My.Forms.frmPesquisaTipoTela
    End Sub

    Private Sub frmCadastroTipoAcesso_Load(sender As Object, e As EventArgs) Handles Me.Load
        pesDados.FormularioPesquisa = My.Forms.frmPesquisaTipoTela
    End Sub
End Class
