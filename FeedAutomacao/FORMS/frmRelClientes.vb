Public Class frmRelClientes
    Dim st As String

    Public Overrides Sub Relatorio()


        If rbAtv.Checked Then
            st = 1
        ElseIf rbIna.Checked Then
            st = 0
        Else
            st = -1
        End If

        Dim tb1 As dtsCadastroCliente.imprimeEmpresaDataTable
        Dim tr2 As New dtsCadastroClienteTableAdapters.imprimeEmpresaTableAdapter
        tb1 = tr2.GetData()

        Dim tb As dtsCadastroCliente.impClienteDataTable
        Dim tr As New dtsCadastroClienteTableAdapters.impClienteTableAdapter
        tb = tr.GetData(cbbCliente.ValorSelecionado, st)

        Me.DataSetRel.Tables.Add(tb)
        Me.DataSetRel.Tables.Add(tb1)


        TipoRel = FeedAutomacao.TipoRel.Rel.updateClientes

        MyBase.Relatorio()

    End Sub

End Class
