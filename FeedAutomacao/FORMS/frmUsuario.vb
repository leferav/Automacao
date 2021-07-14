Public Class frmUsuario


    Dim dt As dtsCadAtendentes.TB_USUARIODataTable
    Dim dr As New dtsCadAtendentesTableAdapters.TB_USUARIOTableAdapter
    Dim row As dtsCadAtendentes.TB_USUARIORow

    Public Overrides Function Limpar() As Boolean
        row = Nothing
        txtNome.Clear()
        ckAtivo.Checked = True
        ckLogado.Enabled = False
        ckLogado.Checked = False
        txtSenha.Text = ""
        txtRepeteSenha.Text = ""
        cbbAtendente.ValorSelecionado = -1
        Return MyBase.Limpar()
    End Function

    Public Overrides Function Editar(ByVal IDSel As Integer) As Boolean
        ID = IDSel
        If IDSel <> -1 Then
            dt = dr.GetData()
            row = dt.FindByID(IDSel)
            If row IsNot Nothing Then

                If row.IsUsuarioNull = False Then
                    txtNome.Text = row.Usuario
                Else
                    txtNome.Text = ""
                End If

                If row.IsSenhaNull = False Then
                    txtSenha.Text = row.Senha
                Else
                    txtSenha.Text = ""
                End If

                txtRepeteSenha.Text = row.Senha

                If row.IsObservacaoNull = False Then
                    txtObservacao.Text = row.Observacao
                Else
                    txtObservacao.Text = ""
                End If

                If row.IsIDatendenteNull = False Then
                    cbbAtendente.ValorSelecionado = row.IDatendente
                Else
                    cbbAtendente.ValorSelecionado = -1
                End If

                ckAtivo.Checked = row.ativo

                ckLogado.Enabled = True
                ckLogado.Checked = False

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
                row = dt.NewTB_USUARIORow
            Else
                row = dt.FindByID(IDSel)
            End If

            row.Usuario = txtNome.Text
            row.Senha = txtSenha.Text
            row.Observacao = txtObservacao.Text
            row.ativo = ckAtivo.Checked
            row.IDatendente = cbbAtendente.ValorSelecionado

            If IDSel = -1 Then
                dt.AddTB_USUARIORow(row)
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
        If txtNome.Text = "" Then
            msgValida("USUARIO", txtNome)
            Return False
        ElseIf txtSenha.Text = "" Then
            msgValida("SENHA", txtSenha)
            Return False
        ElseIf txtRepeteSenha.Text = "" Then
            msgValida("REPITA SENHA", txtRepeteSenha)
            txtRepeteSenha.Focus()
            Return False
        ElseIf txtSenha.Text <> txtRepeteSenha.Text Then
            MsgBox("Senha Diferente!", MsgBoxStyle.Critical)
            txtRepeteSenha.Focus()
            Return False
        ElseIf cbbAtendente.ValorSelecionado = -1 Then
            msgValida("ATENDENTE", cbbAtendente)
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
        pesDados.FormularioPesquisa = My.Forms.frmPesquisaAtendentes
    End Sub

    Private Sub frmCadastroAtendentes_Load(sender As Object, e As EventArgs) Handles Me.Load
        pesDados.FormularioPesquisa = My.Forms.frmPesquisaAtendentes
    End Sub









End Class
