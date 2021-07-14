Public Module clUtil

    Public Sub msgExcluir()
        MsgBox("Dados Excluídos com Sucesso!", MsgBoxStyle.Information)
    End Sub

    Public Sub msgSalvar()
        MsgBox("Dados Salvos com Sucesso!", MsgBoxStyle.Information)
    End Sub

    Public Sub msgValida(ByVal Campo As String, ByVal control As Control)
        MsgBox("Campo " + Campo + " não pode Estar em Branco!", MsgBoxStyle.Information)
        control.Focus()
    End Sub

    Public Sub msgValidaNum(ByVal Campo As String, ByVal control As Control)
        MsgBox("Campo " + Campo + " Deve Ser Maior que 0!", MsgBoxStyle.Information)
        control.Focus()
    End Sub

End Module
