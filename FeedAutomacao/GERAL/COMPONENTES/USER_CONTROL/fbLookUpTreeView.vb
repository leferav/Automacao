Public Class fbLookUpTreeView

    Dim _dt As DataRow = Nothing
    Dim _ID As Integer = -1
    'Dim _frm As FrmSelecionaContaContabil

    <System.ComponentModel.Category("FeedBack")> _
    Public Event Selecionando()

    <System.ComponentModel.Category("FeedBack")> _
    Public Event antesDeAbrir()


    Public Sub New()
        InitializeComponent()

        AddHandler Me.txt.TextChanged, AddressOf Me.alteraValor
    End Sub

    Protected Sub alteraValor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent Selecionando()
    End Sub

    <System.ComponentModel.Category("FeedBack")> _
    Public ReadOnly Property DataTableSelect() As DataRow
        Get
            Return _dt
        End Get
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property SelectID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
            'If _ID > 0 Then
            '    txt.Text = _frm.retornaNome(_ID)
            'Else
            '    txt.Clear()
            'End If
        End Set
    End Property

    '<System.ComponentModel.Category("FeedBack")> _
    'Public Property FormularioPesquisa() As FrmSelecionaContaContabil
    '    Get
    '        Return _frm
    '    End Get
    '    Set(ByVal value As FrmSelecionaContaContabil)
    '        _frm = value
    '    End Set
    'End Property

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    '    RaiseEvent antesDeAbrir()
    '    If _frm IsNot Nothing Then
    '        _frm.ShowDialog()
    '        If _frm.ID <> -1 Then
    '            _ID = _frm.ID
    '            txt.Text = _frm.nomeConta
    '        Else
    '            _ID = -1
    '            Me.txt.Text = ""
    '            _dt = Nothing
    '        End If
    '    Else
    '        MsgBox("Formulário de Pesquisa não Selecionado!", MsgBoxStyle.Information)
    '    End If
    'End Sub

    Dim _req As Boolean = False
    <System.ComponentModel.Category("FeedBack")> _
    Public Property Requerido() As Boolean
        Get
            Return _req
        End Get
        Set(ByVal value As Boolean)
            _req = value
            If _req = True Then
                Me.txt.BackColor = Color.LightBlue
            Else
                Me.txt.BackColor = Color.White
            End If
        End Set
    End Property

    Dim _hint As New ToolTip

    Private Sub txt_MouseHover(sender As Object, e As System.EventArgs) Handles txt.MouseHover
        _hint.SetToolTip(txt, txt.Text)
    End Sub
    Private Sub txt_TextChanged(sender As Object, e As System.EventArgs) Handles txt.TextChanged
        _hint.SetToolTip(txt, txt.Text)
    End Sub

    Dim _NomeCampoMsg As String = ""
    <System.ComponentModel.Category("FeedBack")>
    Public Property NomeCampoMsg() As String
        Get
            If _NomeCampoMsg = "" Then _NomeCampoMsg = Me.Name.Replace("txt", "")
            Return _NomeCampoMsg
        End Get
        Set(ByVal value As String)
            _NomeCampoMsg = value
        End Set
    End Property

    Dim _controlDB As fbControler
    <System.ComponentModel.Category("FeedBack")>
    Public Property ControlDB() As fbControler
        Get
            Return _controlDB
        End Get
        Set(ByVal value As fbControler)
            _controlDB = value
            If _controlDB IsNot Nothing Then
                _controlDB.listControles.Add(Me)
            End If
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property DB As StandardControlDB

End Class
