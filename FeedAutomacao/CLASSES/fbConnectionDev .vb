Imports System.Data.SqlClient

Public Class fbConnectionDev

    Public Shared sCon2 As New SqlClient.SqlConnection(My.Settings.FeedAutomacaoConnectionString)

    Public Shared Function executaSelect(ByVal sql As String,
                                         Optional ByVal TIMEOUT As Integer = 180) As DataTable
        If sql <> "" Then
            Dim sConBACK As New SqlClient.SqlConnection(My.Settings.FeedAutomacaoConnectionString)
            Dim dt As New DataTable
            Try

                sConBACK.Open()
                If sConBACK.State = ConnectionState.Open Then
                    Dim carregat As New SqlDataAdapter(sql, sConBACK)
                    carregat.SelectCommand.CommandTimeout = TIMEOUT
                    carregat.Fill(dt)
                End If
            Catch ex As SqlClient.SqlException
                If Not ex.Message.Contains("Deadlock") Then MsgBox("Erro na Conexão: " + ex.Message)
            Finally
                Try
                    sConBACK.Close()
                    sConBACK.Dispose()
                Catch : End Try
            End Try
            Return dt
        Else
            Return Nothing
        End If
        Return Nothing
    End Function

    Public Shared Function retornaValorArray(ByVal sql As String) As List(Of Object)
        Dim registro As SqlDataReader = Nothing
        Dim obj As New List(Of Object)
        Dim dt As New DataTable
        Try
            If (sCon2.State = ConnectionState.Open) Then sCon2.Close()
            sCon2.Open()
            Dim carregat As New SqlDataAdapter(sql, sCon2)
            carregat.SelectCommand.CommandTimeout = 180
            carregat.Fill(dt)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Columns.Count - 1
                    obj.Add(dt.Rows(0).Item(i))
                Next
            End If
            Return obj
        Catch ex As SqlClient.SqlException
            MsgBox("Erro na Conexão: " + ex.Message)
            Return obj
        Finally
            sCon2.Close()
        End Try
    End Function

    Public Shared Function executaCommand(ByVal sql As String)
        Dim trans As SqlTransaction = Nothing
        Try
            If (sCon2.State = ConnectionState.Open) Then sCon2.Close()
            sCon2.Open()
            trans = sCon2.BeginTransaction
            Dim carregat As New SqlCommand(sql, sCon2, trans)
            carregat.CommandType = CommandType.Text
            If carregat.ExecuteNonQuery() > 0 Then
                trans.Commit()
                carregat.Dispose()
                Return True
            Else
                trans.Rollback()
                carregat.Dispose()
                Return False
            End If
        Catch ex As SqlClient.SqlException
            MsgBox("Erro na Conexão: " + ex.Message)
            trans.Rollback()
            Return False
        Finally
            trans.Dispose()
            sCon2.Close()
        End Try
    End Function

    Public Shared Function executaCommandNoBanco(ByVal sql As String, Optional ByVal numParametros As Integer = 0,
                                                 Optional ByVal parametroNome As List(Of String) = Nothing,
                                                 Optional ByVal parametroValor As List(Of Object) = Nothing,
                                                 Optional ByVal parametroTipo As List(Of SqlDbType) = Nothing)
        Dim trans As SqlTransaction = Nothing
        Try
            If (sCon2.State = ConnectionState.Open) Then sCon2.Close()
            sCon2.Open()
            trans = sCon2.BeginTransaction
            Dim carregat As New SqlCommand(sql, sCon2, trans)
            carregat.CommandType = CommandType.StoredProcedure
            If numParametros <> 0 Then
                Dim index As Integer = 0
                Do While numParametros > 0
                    If parametroValor IsNot Nothing Then
                        If parametroValor.Item(index) <> 0 Then
                            Dim par As New SqlParameter
                            par.ParameterName = parametroNome.Item(index)
                            par.DbType = parametroTipo.Item(index)
                            par.Value = parametroValor.Item(index)
                            carregat.Parameters.Add(par)
                        End If
                    End If
                    index += 1
                    numParametros -= 1
                Loop
            End If
            If carregat.ExecuteNonQuery() > 0 Then
                trans.Commit()
                carregat.Dispose()
                Return True
            Else
                trans.Rollback()
                carregat.Dispose()
                Return False
            End If
        Catch ex As SqlClient.SqlException
            MsgBox("Erro na Conexão: " + ex.Message)
            trans.Rollback()
            Return False
        Finally
            trans.Dispose()
            sCon2.Close()
        End Try
    End Function

    Public Shared Function retornaValorUnico(ByVal sql As String)
        Try
            If (sCon2.State = ConnectionState.Open) Then sCon2.Close()
            sCon2.Open()
            Dim carregat As New SqlCommand(sql, sCon2)
            Dim registro = carregat.ExecuteScalar()
            carregat.Dispose()
            Return registro
        Catch ex As SqlClient.SqlException
            MsgBox("Erro na Conexão: " + ex.Message)
            Return False
        Finally
            sCon2.Close()
        End Try
    End Function

    Public Shared Function retornaValorUnicoMenos1(ByVal sql As String)
        Try
            If (sCon2.State = ConnectionState.Open) Then sCon2.Close()
            sCon2.Open()
            Dim carregat As New SqlCommand(sql, sCon2)
            Dim registro = carregat.ExecuteScalar()
            carregat.Dispose()
            If registro Is Nothing Then registro = -1
            Return registro
        Catch ex As SqlClient.SqlException
            MsgBox("Erro na Conexão: " + ex.Message)
            Return False
        Finally
            sCon2.Close()
        End Try
    End Function

    Public Shared Function retornaValorUnicoValor(ByVal sql As String, valor As Object) As Object
        Try
            If (sCon2.State = ConnectionState.Open) Then sCon2.Close()
            sCon2.Open()
            Dim carregat As New SqlCommand(sql, sCon2)
            Dim registro = carregat.ExecuteScalar()
            carregat.Dispose()
            If registro Is Nothing Then registro = valor
            Return registro
        Catch ex As SqlClient.SqlException
            MsgBox("Erro na Conexão: " + ex.Message)
            Return False
        Finally
            sCon2.Close()
        End Try
    End Function

    Public Shared Function retornaConsulta(ByVal sql As String)
        Dim registro As SqlDataReader = Nothing
        Try
            If (sCon2.State = ConnectionState.Open) Then sCon2.Close()
            sCon2.Open()
            Dim carregat As New SqlCommand(sql, sCon2)
            registro = carregat.ExecuteReader(CommandBehavior.CloseConnection)
            carregat.Dispose()
            Return registro
        Catch ex As SqlClient.SqlException
            MsgBox("Erro na Conexão: " + ex.Message)
            Return False
        End Try
    End Function

End Class
