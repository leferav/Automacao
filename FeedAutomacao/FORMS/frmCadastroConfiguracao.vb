Public Class frmCadastroConfiguracao


    Dim dt As dtsMapeamentoConf.TB_MAP_CONFDataTable
    Dim dr As New dtsMapeamentoConfTableAdapters.TB_MAP_CONFTableAdapter
    Dim row As dtsMapeamentoConf.TB_MAP_CONFRow

    Public Overrides Function Limpar() As Boolean
        row = Nothing
        txtNome.Clear()
        txtTipoDados.Clear()
        txtTabela.Clear()
        txtTamanho.Clear()
        txtDecimal.Clear()
        txtDescricao.Clear()

        Return MyBase.Limpar()
    End Function

    Public Overrides Function Editar(ByVal IDSel As Integer) As Boolean
        ID = IDSel
        If IDSel <> -1 Then
            dt = dr.GetData()
            row = dt.FindByID(IDSel)
            If row IsNot Nothing Then
                txtNome.Text = row.Nome
                txtNome.CharacterCasing = CharacterCasing.Normal
                txtTipoDados.Text = row.TipoDados
                txtTipoDados.CharacterCasing = CharacterCasing.Normal
                txtTabela.Text = row.Tabela
                txtTamanho.Text = row.Tamanho
                If row.Is_DecimalNull = False Then
                    txtDecimal.Text = row._Decimal
                Else
                    txtDecimal.Text = 0
                End If

                txtDescricao.Text = row.Descricao
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
                row = dt.NewTB_MAP_CONFRow
            Else
                row = dt.FindByID(IDSel)
            End If

            row.Nome = txtNome.Text
            row.TipoDados = txtTipoDados.Text
            row.Tabela = txtTabela.Text
            row.Tamanho = txtTamanho.Text
            row._Decimal = txtDecimal.Text
            row.Descricao = txtDescricao.Text

            If IDSel = -1 Then
                dt.AddTB_MAP_CONFRow(row)
            End If
            dr.Update(dt)
            msgSalvar()
            Return True
        End If
        Return False
    End Function

    Public Overrides Sub Carrega(Optional ByVal IDParent As Integer = -1)
        MyBase.Carrega(IDParent)
        dt = dr.GetData()
        Dados = dt
    End Sub

    Public Overridable Sub salvandoDados()
        Salvar(ID)
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        salvandoDados()
    End Sub

    Private Sub frmCadastroConfiguracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmPai = frmGerenciaDeConfiguracoes
    End Sub
End Class
