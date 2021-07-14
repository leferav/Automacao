Public Class frmCadastroTipoAcesso


    Dim dt As dtsTipoAcesso.TB_TIPO_ACESSODataTable
    Dim dr As New dtsTipoAcessoTableAdapters.TB_TIPO_ACESSOTableAdapter
    Dim row As dtsTipoAcesso.TB_TIPO_ACESSORow

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
                row = dt.NewTB_TIPO_ACESSORow
            Else
                row = dt.FindByID(IDSel)
            End If

            row.Nome = txtTipo.Text
            row.Observacao = txtObservacao.Text

            If IDSel = -1 Then
                dt.AddTB_TIPO_ACESSORow(row)
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
            Return False
        End If
        Return True
    End Function

    Public Overrides Sub Carrega(Optional ByVal IDParent As Integer = -1)
        MyBase.Carrega(IDParent)
        dt = dr.GetData()
        Dados = dt
    End Sub

End Class
