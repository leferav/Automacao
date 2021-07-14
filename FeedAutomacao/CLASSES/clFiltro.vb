Imports System.Text

Public Class clFiltro

    Public Function setaWhere1(ByVal _filtro As String, Optional ByVal semWhere As Boolean = True) As String
        Dim ret As String = ""
        If Trim(_filtro) = "" Then
            ret = " WHERE "
        Else
            ret = " AND "
        End If
        Return ret
    End Function

    Public Shared Function FiltrarData(ByVal DataInicial As Date, ByVal DataFinal As Date, _
                                      ByVal dtDe As Boolean, ByVal dtAte As Boolean, _
                                      ByVal campo As String, Optional ByVal _filtro As String = "")
        Dim filtro As New StringBuilder

        If dtDe OrElse dtAte Then
            If Trim(_filtro) = "" Then
                filtro.Append(" WHERE ")
            Else
                filtro.Append(" AND ")
            End If
        Else
            Return ""
        End If

        If dtDe Then
            Dim dtIni As Date
            dtIni = CDate(DataInicial.ToString("dd/MM/yyyy") + " 00:00:00")
            If dtAte Then
                filtro.Append(campo)
                filtro.Append(" >= '")
                filtro.Append(dtIni)
                filtro.Append("'")
            Else
                filtro.Append(campo)
                filtro.Append(" >= '" + dtIni.ToString() + "'")
                'filtro.Append(" BETWEEN '" + dtIni.ToString() + "'")  AND " + dtIni + " 23:59:59'")
            End If
        End If

        If dtAte Then
            Dim dtFim As Date
            dtFim = CDate(DataFinal.ToString("dd/MM/yyyy") + " 23:59:59")
            If dtDe Then
                filtro.Append(" AND ")
                filtro.Append(campo)
                filtro.Append(" <= '")
                filtro.Append(dtFim)
                filtro.Append("'")
            Else
                filtro.Append(campo)
                filtro.Append(" <= '")
                filtro.Append(dtFim)
                filtro.Append("'")
            End If
        End If
        Return filtro.ToString()
    End Function

    Public Shared Function FiltraNumLote(ByVal Lote As String, ByVal filtro As StringBuilder, _
                                         Optional ByVal Campo As String = "Numero", _
                                         Optional ByVal RefTabela As String = "", _
                                         Optional ByVal SemClausula As Boolean = False, _
                                         Optional ByVal setaWhere As Boolean = True, _
                                         Optional ByVal setaAnd As Boolean = True) As String

        If SemClausula = False AndAlso setaWhere Then 'AndAlso Trim(filtro.ToString()) = ""
            filtro.Append(" WHERE ")
        ElseIf SemClausula = False AndAlso setaAnd Then
            filtro.Append(" AND ")
        End If

        If RefTabela <> "" Then
            filtro.Append(RefTabela)
            filtro.Append(".")
        End If

        If Lote.Length > 2 AndAlso IsNumeric(Lote.Substring(0, 1)) = False AndAlso IsNumeric(Lote.Substring(1, 2)) = False Then
            Dim numLote, codLote As String
            codLote = Lote.Substring(0, 2)
            numLote = Lote.Substring(2)
            Dim count = 0
            Dim LoteLoc As String
            Do While numLote.Substring(count).StartsWith("0")
                LoteLoc = numLote.Substring(count + 1)
                count += 1
            Loop
            If count = 0 Then
                Lote = numLote
            End If
            filtro.Append("NUMERO LIKE '%")
            filtro.Append(codLote)
            filtro.Append("%'")
            If numLote <> "" Then
                filtro.Append(" AND ")
                If RefTabela <> "" Then
                    filtro.Append(RefTabela)
                    filtro.Append(".")
                End If
                filtro.Append("NUMERO LIKE '%")
                filtro.Append(numLote)
                filtro.Append("%'")
            End If
        Else 'If Lote.Length = 1 Then
            filtro.Append("NUMERO LIKE '%")
            filtro.Append(Lote)
            filtro.Append("%'")
        End If
        If Campo <> "Numero" Then
            filtro.Replace("NUMERO", "ORIGEM")
        End If
        Return filtro.ToString()
    End Function

    Public Shared Function MontarNumeroGuia(ByVal Numero As String) As String
        If Numero <> "" Then
            If Numero.Length > 2 Then
                Dim numLote, codLote As String
                codLote = Numero.Substring(0, 2)
                If IsNumeric(codLote.Substring(0)) OrElse IsNumeric(codLote.Substring(1)) Then
                    Return ""
                End If
                numLote = Numero.Substring(2)
                If numLote.Contains("/") Then
                    numLote.Replace("/", "")
                End If
                Dim tam As String = ""
                Dim numTemp As String
                numTemp = numLote.Substring(0, numLote.Length - 1)
                While numTemp.Length + tam.Length < 7
                    tam += "0"
                End While
                numLote = tam + numLote
                Numero = codLote + numLote
            End If
        End If
        Return Numero
    End Function

    'Public Shared Function FiltraNumLote(ByVal Lote As String, _
    '                                     Optional ByVal RefTabela As String = "", _
    '                                     Optional ByVal SemClausula As Boolean = False, _
    '                                     Optional ByVal setaWhere As Boolean = True, _
    '                                     Optional ByVal setaAnd As Boolean = True) As String

    '    Dim filtro As New StringBuilder

    '    If SemClausula = False AndAlso Trim(filtro.ToString()) = "" AndAlso setaWhere Then
    '        filtro.Append(" WHERE ")
    '    ElseIf SemClausula = False AndAlso setaAnd Then
    '        filtro.Append(" AND ")
    '    End If

    '    If RefTabela <> "" Then
    '        filtro.Append(RefTabela)
    '        filtro.Append(".")
    '    End If

    '    Lote = Trim(Lote)

    '    If Lote.Length >= 2 Then
    '        Dim numLote, codLote As String
    '        codLote = Lote.Substring(0, 2)
    '        numLote = Lote.Substring(2)
    '        Dim count = 0
    '        Dim LoteLoc As String
    '        Do While numLote.Substring(count).StartsWith("0")
    '            LoteLoc = numLote.Substring(count + 1)
    '            count += 1
    '        Loop
    '        If count = 0 Then
    '            Lote = numLote
    '        End If
    '        filtro.Append("NUMERO LIKE '%")
    '        filtro.Append(codLote)
    '        filtro.Append("%'")
    '        If numLote <> "" Then
    '            filtro.Append(" AND NUMERO LIKE '%")
    '            filtro.Append(Lote)
    '            filtro.Append("%'")
    '        End If
    '    ElseIf Lote.Length = 1 Then
    '        filtro.Append("NUMERO LIKE '%")
    '        filtro.Append(Lote)
    '        filtro.Append("%'")
    '    End If
    '    Return filtro.ToString()
    'End Function

End Class
