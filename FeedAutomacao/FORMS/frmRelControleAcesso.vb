Imports System.Data.SqlClient

Public Class frmRelControleAcesso
    Dim st As String
    Dim dtFim As Date
    Dim dtIni As Date

    Public Overrides Sub Relatorio()

        If txtIni.Checked Then
            dtIni = CDate(txtIni.Value.ToString("dd/MM/yyyy 00:00:00"))
        Else
            dtIni = CDate(Format("01/01/1900"))
        End If

        If txtFim.Checked Then
            dtFim = CDate(txtFim.Value.ToString("dd/MM/yyyy 23:59:59"))
        Else
            dtFim = CDate(Format("01/01/2222"))
        End If

        '    If rbAbertos.Checked Then
        '        st = 0
        '    ElseIf rbDev.Checked Then
        '        st = 1
        '    ElseIf rbTeste.Checked Then
        '        st = 2
        '    ElseIf rbFin.Checked Then
        '        st = 3
        '    ElseIf rbRef.checked Then
        '        st = 4
        '    ElseIf rbAt.Checked Then
        '        st = 5
        '    Else
        '        st = -1
        '    End If

        TipoRel = FeedAutomacao.TipoRel.Rel.RelControleAcesso
        MyBase.Relatorio()


        Dim tb As dtsRel.RelControleAcessoDataTable
        Dim tr As New dtsRelTableAdapters.RelControleAcessoTableAdapter
        tb = tr.GetData(cbbPessoa.ValorSelecionado, dtIni, dtFim)

        Dim tb1 As dtsRel.retornaDadosEmpresaDataTable
        Dim tr1 As New dtsRelTableAdapters.retornaDadosEmpresaTableAdapter
        tb1 = tr1.GetData(3)  'não esta pegando My.Forms.frmPadrao.IDEmpresa

        Me.DataSetRel.Tables.Add(tb)
        Me.DataSetRel.Tables.Add(tb1)





        '    If MsgBox("Deseja imprimir o relatório destacando a observação do desenvolvedor?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

        '        TipoRel = FeedAutomacaoAutomacao.TipoRel.Rel.updateRelSolicitaçõesComObs
        '        MyBase.Relatorio()

        '    Else

        '        TipoRel = FeedAutomacaoAutomacao.TipoRel.Rel.updateRelSolicitações
        '        MyBase.Relatorio()

        '    End If
    End Sub

    Private Sub frmRelSolicitacoes_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtIni.Value = Date.Now
        txtFim.Value = Date.Now
    End Sub

End Class
