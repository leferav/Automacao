Public Class fbControler
    Inherits System.ComponentModel.Component

    Dim frm As frmPadraoCadastroDados = Nothing
    Dim iList As New List(Of Object)
    Public Property row As Object

    <System.ComponentModel.Category("FeedBack")>
    Public Property cancelaOperacao As Boolean = False

    <System.ComponentModel.Category("FeedBack")>
    Public Property dadosTabela As DataTable

    <System.ComponentModel.Category("FeedBack")>
    Public Property Tabela() As String

    <System.ComponentModel.Category("FeedBack")>
    Public Property CampoFoco() As Object

    <System.ComponentModel.Category("FeedBack")>
    Public Event antesdeSalvar(row As DataRow)

    <System.ComponentModel.Category("FeedBack")>
    Public Event antesdeEditar(row As DataRow)

    <System.ComponentModel.Category("FeedBack")>
    Public Event antesdeMoverParaRow()

    <System.ComponentModel.Category("FeedBack")>
    Public Event antesdeExcluir()

    <System.ComponentModel.Category("FeedBack")>
    Public Event antesdeCarregar()

    <System.ComponentModel.Category("FeedBack")>
    Public Event depoisdeCarregar()

    <System.ComponentModel.Category("FeedBack")>
    Public Event antesdeValidar()

    <System.ComponentModel.Category("FeedBack")>
    Public Event antesdeLimpar()


    Dim _id As Integer = -1
    <System.ComponentModel.Category("FeedBack")>
    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
            If gridCab IsNot Nothing Then
                gridCab.IDRelacionamento = _id
            End If
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property frmCadastro() As frmPadraoCadastroDados
        Get
            Return frm
        End Get
        Set(ByVal value As frmPadraoCadastroDados)
            frm = value
            If frm IsNot Nothing Then
                frm.Carrega()
            End If
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property gridCab() As fbGridDadosv2

    Dim _dados As Object
    <System.ComponentModel.Category("FeedBack")> _
    Public Property dadosDB() As Object
        Get
            Return _dados
        End Get
        Set(ByVal value As Object)
            _dados = value
        End Set
    End Property

    Dim _dadosC As Object
    <System.ComponentModel.Category("FeedBack")> _
    Public Property conDB() As Object
        Get
            Return _dadosC
        End Get
        Set(ByVal value As Object)
            _dadosC = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property listControles() As List(Of Object)
        Get
            Return iList
        End Get
        Set(ByVal value As List(Of Object))
            iList = value
        End Set
    End Property

    Public Overridable Function Salvar() As Boolean
        cancelaOperacao = False
        If Validar() = True Then
            If ID = -1 Then
                row = dadosDB.NewRow
            Else
                row = dadosDB.FindByID(ID)
            End If

            RaiseEvent antesdeMoverParaRow()
            If cancelaOperacao = True Then Return False

            For Each c As Object In iList
                If c.campo <> "" Then
                    row.Item(c.campo) = c.valor
                End If
            Next

            RaiseEvent antesdeSalvar(row)
            If cancelaOperacao = True Then Return False

            If ID = -1 Then
                dadosDB.rows.add(row)
            End If
            conDB.Update(dadosDB)
            retornoOperacao = True
        Else
            retornoOperacao = False
            Return False
        End If
    End Function

    <System.ComponentModel.Category("FeedBack")> _
    Public Property retornoOperacao As Boolean

    Public Overridable Function Limpar() As Boolean
        ID = -1
        For Each c As Object In iList
            If c.campo <> "" Then
                c.Valor = c.valorVazio
            End If
        Next
        RaiseEvent antesdeLimpar()
        Return True
    End Function

    Public Overridable Function Editar() As Boolean
        Carrega()
        row = dadosDB.FindByID(ID)
        If row IsNot Nothing Then

            For Each c As Object In iList
                If c.campo <> "" Then
                    If IsDBNull(row.Item(c.campo)) Then
                        c.valor = c.valorVazio
                    Else
                        c.valor = row.Item(c.campo)
                    End If
                End If
            Next

            RaiseEvent antesdeEditar(row)

            Return True
        End If
        Return False
    End Function

    Public Overridable Function Excluir(ByVal IDSel As Integer) As Boolean
        If IDSel <> -1 Then
            Try
                Carrega()
                row = dadosDB.FindByID(ID)
                If row IsNot Nothing Then
                    row.Delete()
                    conDB.Update(dadosDB)
                    Carrega()
                    msgExcluir()
                    Return True
                Else
                    MsgBox("Erro ao Excluir o Registro! Não foi Possivel Carregar a Row!", MsgBoxStyle.Critical)
                    Return False
                End If
            Catch ex As SqlClient.SqlException
                If ex.ErrorCode = -2146232060 Then
                    MsgBox("Erro ao Excluir o Registro Pois Esta Relacionado a Outro Registro! ", MsgBoxStyle.Critical)
                Else
                    MsgBox("Erro ao Excluir o Registro! " + ex.Message, MsgBoxStyle.Critical)
                End If
                Carrega()
                Return False
            End Try
        End If
    End Function

    Public Overridable Function Validar() As Boolean

        For Each c As Object In iList
            If c.campo <> "" AndAlso c.Requerido = True AndAlso c.valor = c.valorvazio Then
                msgValida(c.campo, c)
                Return False
            End If
        Next
        RaiseEvent antesdeValidar()
        Return Not cancelaOperacao
    End Function

    Public Overridable Sub Carrega(Optional ByVal IDParent As Integer = -1)
        RaiseEvent antesdeCarregar()
        If cancelaOperacao = True Then Exit Sub
        'If ID <> -1 Then
        Try
            dadosDB = conDB.GetData()
        Catch : End Try
        'Else
        '    dadosDB = Nothing
        'End If
        RaiseEvent depoisdeCarregar()
        dadosTabela = dadosDB
    End Sub




End Class
