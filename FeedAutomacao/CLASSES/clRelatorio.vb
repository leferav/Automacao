Public Class clRelatorio

    Public Shared Function buscaEstadoEmpresa() As Integer
        Dim sql1 As String = " Select codEstado from TB_EMPRESA WHERE "
        sql1 += " ID = " + My.Forms.frmPadrao.IDEmpresa.ToString()
        Dim dt = fbConnection.executaSelect(sql1)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        End If
        Return 0
    End Function


    Public Shared Function buscaViagemManifesto(ByVal IDManifesto As Integer) As Integer
        Dim sql1 As String = " Select IDViagem from TB_MANIFESTO_VIAGEM WHERE "
        sql1 += " ID = " + IDManifesto.ToString()
        Dim dt = fbConnection.executaSelect(sql1)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        End If
        Return -1
    End Function

    Public Shared Function buscaDataManifesto(ByVal IDManifesto As Integer) As Integer
        Dim sql1 As String = " Select data from TB_MANIFESTO_VIAGEM WHERE "
        sql1 += " ID = " + IDManifesto.ToString()
        Dim dt = fbConnection.executaSelect(sql1)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        End If
        Return -1
    End Function

    Public Shared Function retornaCaminhoImpressaoUsuario() As String
        Dim sql1 As String = " Select caminhoImpressao from TB_USUARIO WHERE "
        sql1 += " ID = " + My.Forms.frmPadrao.IDUsuario.ToString()
        Dim dt = fbConnection.executaSelect(sql1)
        If dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0).Item(0)) Then
            Return dt.Rows(0).Item(0)
        End If
        Return ""
    End Function

    Public Shared Function retornaCTRCNota(ByVal IDNota As Integer, ByVal TIPO As String) As Integer
        Dim sql1 As String = " SELECT IDCTRC FROM "
        If TIPO = "NF" Then
            sql1 += " TB_CTRC_NOTA_PAPEL"
        Else
            sql1 += " TB_CTRC_NOTA_NFE"
        End If
        sql1 += " WHERE ID = " + IDNota.ToString()
        Dim dt = fbConnection.executaSelect(sql1)
        If dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0).Item(0)) Then
            Return dt.Rows(0).Item(0)
        End If
        Return -1
    End Function



End Class
