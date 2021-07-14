Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Imports System.Text

Public Class clValidacao

    Public Shared Function ValidaCPF(ByVal vrCPF As String) As Boolean
        Dim valor As String = vrCPF.Replace(".", "")
        valor = valor.Replace("-", "")
        If valor.Length <> 11 Then
            Return False
        End If
        If valor = "00000000000" Then
            Return True
        End If
        Dim igual As Boolean = True
        Dim iWi As Integer = 1
        While iWi < 11 AndAlso igual
            If valor(iWi) <> valor(0) Then

                igual = False
            End If
            iWi += 1
        End While
        If igual OrElse valor = "12345678909" Then
            Return False
        End If
        Dim numeros As Integer() = New Integer(10) {}
        For i As Integer = 0 To 10
            numeros(i) = Integer.Parse(valor(i).ToString())
        Next
        Dim soma As Integer = 0
        For i As Integer = 0 To 8
            soma += (10 - i) * numeros(i)
        Next
        Dim resultado As Integer = soma Mod 11
        If resultado = 1 OrElse resultado = 0 Then
            If numeros(9) <> 0 Then
                Return False
            End If
        ElseIf numeros(9) <> 11 - resultado Then
            Return False
        End If
        soma = 0
        For i As Integer = 0 To 9
            soma += (11 - i) * numeros(i)
        Next
        resultado = soma Mod 11
        If resultado = 1 OrElse resultado = 0 Then
            If numeros(10) <> 0 Then
                Return False
            End If
        ElseIf numeros(10) <> 11 - resultado Then
            Return False
        End If
        Return True

    End Function

    Public Shared Function ValidaCNPJ(ByVal vrCNPJ As String) As Boolean
        Dim CNPJ As String = vrCNPJ.Replace(".", "")
        CNPJ = CNPJ.Replace("/", "")
        CNPJ = CNPJ.Replace("-", "")

        Dim digitos As Integer(), soma As Integer(), resultado As Integer()
        Dim nrDig As Integer
        Dim ftmt As String
        Dim CNPJOk As Boolean()
        ftmt = "6543298765432"

        digitos = New Integer(13) {}
        soma = New Integer(1) {}
        soma(0) = 0
        soma(1) = 0
        resultado = New Integer(1) {}
        resultado(0) = 0
        resultado(1) = 0
        CNPJOk = New Boolean(1) {}
        CNPJOk(0) = False
        CNPJOk(1) = False

        If CNPJ = "00000000000000" Then
            Return True
        End If

        Try
            For nrDig = 0 To 13
                digitos(nrDig) = Integer.Parse(CNPJ.Substring(nrDig, 1))
                If nrDig <= 11 Then
                    soma(0) += (digitos(nrDig) * Integer.Parse(ftmt.Substring(nrDig + 1, 1)))
                End If
                If nrDig <= 12 Then
                    soma(1) += (digitos(nrDig) * Integer.Parse(ftmt.Substring(nrDig, 1)))
                End If
            Next

            For nrDig = 0 To 1
                resultado(nrDig) = (soma(nrDig) Mod 11)
                If (resultado(nrDig) = 0) OrElse (resultado(nrDig) = 1) Then
                    CNPJOk(nrDig) = (digitos(12 + nrDig) = 0)
                Else
                    CNPJOk(nrDig) = (digitos(12 + nrDig) = (11 - resultado(nrDig)))
                End If
            Next

            Return (CNPJOk(0) AndAlso CNPJOk(1))
        Catch
            Return False
        End Try
    End Function

    Public Shared Function existCNPJ_CPF(ByVal valor As String, ByVal tabela As String, ByVal ID As Integer, _
                                         Optional ByVal TB_Relacionamento As String = "", _
                                         Optional ByVal IDRel As String = "", _
                                         Optional ByVal IDRelValor As Integer = 0) As Boolean
        Dim ssql As String = ""
        valor = valor.Replace(".", "").Replace("-", "").Replace("/", "")
        If valor <> "00000000000" And valor <> "00000000000000" Then
            If tabela.Contains("nolock") = False Then
                tabela += " with (nolock) "
            End If
            If TB_Relacionamento.Contains("nolock") = False Then
                TB_Relacionamento += " with (nolock) "
            End If
            If tabela.Contains("TB_CLIENTES") OrElse tabela.Contains("TB_SEGURADORA") Then
                ssql = "SELECT ID FROM " + tabela + " WHERE CNPJ LIKE '%" + valor + "%' "
            ElseIf tabela.Contains("TB_TRANSPORTADORA") Then
                ssql = "SELECT ID FROM " + tabela + " WHERE CIC LIKE '%" + valor + "%' "
            Else
                ssql = "SELECT ID FROM " + tabela + " WHERE CGC LIKE '%" + valor + "%' "
            End If

            Dim IDTab As Nullable(Of Integer) = fbConnection.retornaValorUnico(ssql)
            If IDTab.HasValue Then
                If TB_Relacionamento <> "" AndAlso IDRel <> "" Then
                    ssql += " AND " + IDRel + " IN (SELECT ID FROM " + TB_Relacionamento + " WHERE ID = " _
                    + IDRelValor.ToString() + ")"
                    IDTab = fbConnection.retornaValorUnico(ssql)
                    If IDTab.HasValue Then
                        Return True
                    Else
                        Return False
                    End If
                End If
                If IDTab = ID Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If
        End If
        Return True
    End Function

    Public Shared Function existNome(ByVal nome As String, ByVal tabela As String, ByVal IDreg As Integer, _
                                     Optional ByVal IDEmpresa As Boolean = False) As Boolean
        Dim ssql As New StringBuilder
        ssql.Append("SELECT ID FROM ")
        ssql.Append(tabela)
        If tabela.Contains("nolock") = False Then
            ssql.Append(" with (nolock) ")
        End If
        ssql.Append(" WHERE Nome = '")
        ssql.Append(nome.ToString().Trim())
        ssql.Append("'")
        If IDEmpresa Then
            ssql.Append(" AND IDEmpresa = ")
            ssql.Append(My.Forms.frmPadrao.IDEmpresa.ToString())
        End If
        Dim id = fbConnection.retornaValorUnico(ssql.ToString())
        If id IsNot Nothing Then
            If IDreg = id Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Verifica se Existe um campo no Banco de Dados. A Cláusula Incial deve ser String
    ''' </summary>
 '   ''' <param name="campo: Campo String"></param> 
    ''' <param name="tabela"></param>
    ''' <param name="valor"></param>
    ''' <param name="IDreg"></param>
    ''' <param name="IDEmpresa"></param>
    ''' <param name="Condicao"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function existCampo(ByVal campo As String, ByVal tabela As String, ByVal valor As String, _
                                      ByVal IDreg As Integer, Optional ByVal IDEmpresa As Boolean = False, _
                                      Optional ByVal Condicao As String = "") As Boolean
        Dim ssql As New StringBuilder
        ssql.Append("SELECT ID FROM ")
        ssql.Append(tabela)
        If tabela.Contains("nolock") = False Then
            ssql.Append(" with (nolock) ")
        End If
        ssql.Append(" WHERE ")
        ssql.Append(campo)
        ssql.Append(" = '")
        ssql.Append(valor)
        ssql.Append("'")
        If IDEmpresa Then
            ssql.Append(" AND IDEmpresa = ")
            ssql.Append(My.Forms.frmPadrao.IDEmpresa.ToString())
        End If
        ssql.Append(Condicao)
        Dim id = fbConnection.retornaValorUnico(ssql.ToString())
        If id IsNot Nothing Then
            If IDreg = id Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Public Shared Function existDomicilio(ByVal IDProdutor As Integer, ByVal NomeDom As String, _
                                      ByVal IDreg As Integer, Optional ByVal IDEmpresa As Boolean = False, _
                                      Optional ByVal Condicao As String = "") As Boolean
        Dim ssql As New StringBuilder
        ssql.Append("SELECT ID FROM TB_DOMICILIO with (nolock) ")
        ssql.Append(" WHERE IDPessoa = ")
        ssql.Append(IDProdutor.ToString())
        ssql.Append(" AND NOME = '")
        ssql.Append(NomeDom)
        ssql.Append("'")
        If IDEmpresa Then
            ssql.Append(" AND IDEmpresa = ")
            ssql.Append(My.Forms.frmPadrao.IDEmpresa.ToString())
        End If
        ssql.Append(Condicao)
        Dim id = fbConnection.retornaValorUnico(ssql.ToString())
        If id IsNot Nothing Then
            If IDreg = id Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Public Shared Function existUsuario(ByVal valor As String, ByVal ID As Integer) As Boolean
        Dim ssql As String = ""
        ssql = "SELECT ID FROM TB_USUARIO with (nolock) WHERE USUARIO = '" + valor + "'"
        Dim IDUsu As Nullable(Of Integer) = fbConnection.retornaValorUnico(ssql)
        If IDUsu.HasValue Then
            If IDUsu = ID Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Public Shared Function existCFOP(ByVal valor As String) As Boolean
        Dim ssql As String = ""
        ssql = "SELECT ID FROM TB_CFOP with (nolock) WHERE CODIGO = '" + valor + "'"
        Dim dt As DataTable = fbConnection.executaSelect(ssql)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            If Not IsDBNull(dt.Rows(0).Item(0)) Then
                Return True
            End If
        End If
        Return False
    End Function

#Region "Validar Email"
    Public Shared Function ValidarEmail(ByVal email As String) As Boolean
        Dim padraoRegex As String = "^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\." &
       "(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$"
        Dim verifica As New Regex(padraoRegex, RegexOptions.IgnorePatternWhitespace)
        Dim valida As Boolean = False
        valida = verifica.IsMatch(email)
        Return valida
    End Function
#End Region

#Region "Validar Data"
    Public Shared Function ValidarData(ByVal data As String, Optional ByVal DifAnos As Integer = -1) As Boolean
        Dim dt As DateTime
        If DateTime.TryParseExact(data, "dd/MM/yyyy", CultureInfo.CurrentCulture, Nothing, dt) = False Then
            Return False
        ElseIf DifAnos <> -1 Then
            Dim anos As Integer
            anos = DateDiff(DateInterval.Year, CDate(data), Date.Now.Date)
            If anos > DifAnos Then
                Return False
            End If
        End If
        Return True
    End Function
#End Region

    ' <DllImport("DllInscE32.dll")> _
    'Public Shared Function ConsisteInscricaoEstadual(ByVal vInsc As String, ByVal vUF As String) As Integer

    'End Function


    Public Shared Sub msgExcluir()
        MsgBox("Dados Excluídos com Sucesso!", MsgBoxStyle.Information)
    End Sub

    Public Shared Sub msgSalvar()
        MsgBox("Dados Salvos com Sucesso!", MsgBoxStyle.Information)
    End Sub

    Public Shared Sub msgValida(ByVal Campo As String, ByVal control As Control)
        MsgBox("Campo " + Campo + " não pode Estar em Branco!", MsgBoxStyle.Information)
        control.Focus()
    End Sub

    Public Shared Sub msgValidaNum(ByVal Campo As String, ByVal control As Control)
        MsgBox("Campo " + Campo + " Deve Ser Maior que 0!", MsgBoxStyle.Information)
        control.Focus()
    End Sub


End Class