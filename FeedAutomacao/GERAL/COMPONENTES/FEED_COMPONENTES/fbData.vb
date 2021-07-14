Public Class fbData
    Inherits DateTimePicker

    Public Sub New()
        Me.DB = New StandardControlDB(Me, Date.Now, Date.Now)
    End Sub

    Private Sub fbData_ValueChanged(sender As Object, e As EventArgs) Handles Me.ValueChanged
        Me.Update()
    End Sub

    <System.ComponentModel.Category("FeedBack")>
    Public Property DB As StandardControlDB



    Dim _req As Boolean = False
    <System.ComponentModel.Category("FeedBack")>
    Public Property Requerido() As Boolean
        Get
            Return _req
        End Get
        Set(ByVal value As Boolean)
            _req = value
            If _req = True Then
                Me.BackColor = Color.MediumSpringGreen
            Else
                Me.BackColor = Color.White
            End If
        End Set
    End Property

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

End Class
