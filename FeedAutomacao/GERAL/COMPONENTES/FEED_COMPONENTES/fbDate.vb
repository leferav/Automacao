Public Class fbDate
    Inherits DateTimePicker

    Dim _req As Boolean = False
    <System.ComponentModel.Category("FeedBack")> _
   Public Property Requerido() As Boolean
        Get
            Return _req
        End Get
        Set(ByVal value As Boolean)
            _req = value
            If _req = True AndAlso Me.Enabled Then
                Me.BackColor = Color.LightBlue
            ElseIf Me.Enabled Then
                Me.BackColor = Color.White
            End If
        End Set
    End Property

    Dim _dtAtl As Boolean = False
    <System.ComponentModel.Category("FeedBack")> _
    Public Property DataAtual() As Boolean
        Get
            Return _dtAtl
        End Get
        Set(ByVal value As Boolean)
            _dtAtl = value
        End Set
    End Property

    'Private Sub fbDate_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
    '    If Me.Checked AndAlso Me.DataAtual Then
    '        Me.Value = Date.Now
    '    End If
    'End Sub

    Public Sub New()
        Me.Value = Date.Now
        Me.DB = New StandardControlDB(Me, Date.Now, Date.Now)
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
