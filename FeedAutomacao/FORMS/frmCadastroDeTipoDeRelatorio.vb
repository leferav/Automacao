Imports System.Windows.Forms
Imports System.IO
Public Class frmCadastroDeTipoDeRelatorio
    Dim DtRel As dtsTipoAcesso.TB_TIPO_RELATORIODataTable
    Dim DrRel As New dtsTipoAcessoTableAdapters.TB_TIPO_RELATORIOTableAdapter
    Friend rowRel As dtsTipoAcesso.TB_TIPO_RELATORIORow
    Dim msg As Boolean = True

    Private Sub setaForm()

    End Sub

    Public Overrides Function Limpar() As Boolean
        MyBase.Limpar()
        txtNomeRelatorio.Text = ""
        txtCodRel.Text = ""
        txtNomeProcedimento.Text = ""
        txtObs.Text = ""
        cbbTipoSistema.ValorSelecionado = -1
        Return True
    End Function

    Public Overrides Function Editar(ByVal IDSel As Integer) As Boolean
        ID = IDSel
        If IDSel <> -1 Then
            DtRel = DrRel.GetDataByID(IDSel)
            rowRel = DtRel.FindByID(IDSel)

            If rowRel.IsNomeNull = False Then
                txtNomeRelatorio.Text = rowRel.Nome
            Else
                txtNomeRelatorio.Text = ""
            End If

            If rowRel.IsProcedimentoNull = False Then
                txtNomeProcedimento.Text = rowRel.Procedimento
            Else
                txtNomeProcedimento.Text = ""
            End If

            If rowRel.IsCODNull = False Then
                txtCodRel.Text = rowRel.COD
            Else
                txtCodRel.Text = ""
            End If


            If rowRel.IstipoSistemaNull = False Then
                cbbTipoSistema.ValorSelecionado = rowRel.tipoSistema
            Else
                cbbTipoSistema.ValorSelecionado = -1
            End If

            If rowRel.IsDescricaoNull = False Then
                txtObs.Text = rowRel.Descricao
            Else
                txtObs.Text = ""
            End If


        Else
            MsgBox("Erro ao Carregar o Registro!", MsgBoxStyle.Critical)
        End If

        Return MyBase.Editar(IDSel)
    End Function



    Public Overrides Function Salvar(ByVal IDSel As Integer) As Boolean
        If Validar() = True Then
            If MyBase.Salvar(IDSel) = True Then
                Carrega()
                If IDSel = -1 Then
                    Carrega()
                    rowRel = DtRel.NewTB_TIPO_RELATORIORow
                Else
                    Carrega()
                    rowRel = DtRel.FindByID(IDSel)
                End If

                rowRel.Nome = txtNomeRelatorio.Text
                rowRel.Procedimento = txtNomeProcedimento.Text
                rowRel.COD = txtCodRel.Text
                rowRel.Descricao = txtObs.Text
                rowRel.tipoSistema = cbbTipoSistema.ValorSelecionado

                If IDSel = -1 Then
                    DtRel.AddTB_TIPO_RELATORIORow(rowRel)
                End If

                DrRel.Update(DtRel)
                If msg Then
                    msgSalvar()
                End If
                If IDSel = -1 Then
                    IDSel = DrRel.MAXID
                End If
                ID = IDSel
                Return True
            End If
            Return False
        End If

    End Function

    Public Overrides Function Validar() As Boolean
        If txtNomeRelatorio.Text = "" Then
            ErrorProvider1.SetError(txtNomeRelatorio, "Preencha o Nome do relatório!")
            MsgBox("O campo Nome do Relatório Não pode Estar Em Branco!", MsgBoxStyle.Information)
            Return False
        End If
        If txtCodRel.Text = "" Then
            ErrorProvider1.SetError(txtCodRel, "Informe o Codigo do Relatório!")
            MsgBox("O campo COD do Relatório Não pode Estar Em Branco!", MsgBoxStyle.Information)
            Return False
        End If
        Return True
        Return MyBase.Validar()
    End Function


    Public Overrides Function Excluir(ByVal IDSel As Integer) As Boolean

        If IDSel <> -1 Then
            Try
                rowRel = DtRel.FindByID(IDSel)
                'row.Delete()
                DrRel.Update(DtRel)
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
        DtRel = DrRel.GetDataByID(ID)
    End Sub


    Public Overridable Sub F12()
        MyBase.funcF12()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs)
        salvandoDados()
    End Sub


    Public Overridable Sub Esc()
        ShowDialogs = False
        Me.Close()
    End Sub

    Private Sub btnFecharTela_Click(sender As Object, e As EventArgs) Handles btnFecharTela.Click
        Esc()
    End Sub

    Private Sub FbButtonVisual1_Click_1(sender As Object, e As EventArgs) Handles FbButtonVisual1.Click
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        salvandoDados()
    End Sub

    Private Sub frmCadastroDeTipoDeRelatorio_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmPai = frmGerenciaDeRelatorios
    End Sub
End Class
