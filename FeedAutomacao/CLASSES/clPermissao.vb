Public Class clPermissao

    Dim _insert As Boolean = True
    Public Property Insere() As Boolean
        Get
            Return _insert
        End Get
        Set(ByVal value As Boolean)
            _insert = value
        End Set
    End Property

    Dim _delete As Boolean = True
    Public Property Exclui() As Boolean
        Get
            Return _delete
        End Get
        Set(ByVal value As Boolean)
            _delete = value
        End Set
    End Property

    Dim _edit As Boolean = True
    Public Property Edita() As Boolean
        Get
            Return _edit
        End Get
        Set(ByVal value As Boolean)
            _edit = value
        End Set
    End Property

    Dim _vis As Boolean = True
    Public Property Visualiza() As Boolean
        Get
            Return _vis
        End Get
        Set(ByVal value As Boolean)
            _vis = value
        End Set
    End Property

    Dim _nav As Boolean = True
    Public Property Navega() As Boolean
        Get
            Return _nav
        End Get
        Set(ByVal value As Boolean)
            _nav = value
        End Set
    End Property


    Dim _menu As Boolean = True
    Public Property Menu() As Boolean
        Get
            Return _menu
        End Get
        Set(ByVal value As Boolean)
            _menu = value
        End Set
    End Property

    Dim _tela As String = ""
    Public Property Tela() As String
        Get
            Return _tela
        End Get
        Set(ByVal value As String)
            _tela = value
        End Set
    End Property

    Dim _atalho As String = ""
    Public Property Atalho() As String
        Get
            Return _atalho
        End Get
        Set(ByVal value As String)
            _atalho = value
        End Set
    End Property

    Dim _objeto As String = ""
    Public Property Objeto() As String
        Get
            Return _objeto
        End Get
        Set(ByVal value As String)
            _objeto = value
        End Set
    End Property


End Class
