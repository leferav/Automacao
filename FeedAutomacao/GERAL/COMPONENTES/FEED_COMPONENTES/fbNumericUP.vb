Public Class fbNumericUP
    Inherits NumericUpDown

    Public Sub New()
        Me.DB = New StandardControlDB(Me, 0)
    End Sub


    <System.ComponentModel.Category("FeedBack")>
    Public Property DB As StandardControlDB

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
                If Me.BackColor = Color.LightBlue Then
                    Me.BackColor = Color.White
                End If
            End If
        End Set
    End Property



    Dim _valor As Object
    <System.ComponentModel.Category("FeedBack")> _
    Public Property Valor() As Object
        Get
            Return _valor
        End Get
        Set(ByVal value As Object)
            _valor = value
            Me.Value = _valor
        End Set
    End Property

    Dim _campo As String = ""
    <System.ComponentModel.Category("FeedBack")> _
    Public Property Campo() As String
        Get
            Return _campo
        End Get
        Set(ByVal value As String)
            _campo = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property valorVazio() As Double = 0

    Private Sub fbNumericUP_ValueChanged(sender As Object, e As System.EventArgs) Handles Me.ValueChanged
        If Me._campo <> "" Then Me._valor = Me.Value
    End Sub

    Dim _NomeCampoMsg As String = ""
    <System.ComponentModel.Category("FeedBack")>
    Public Property NomeCampoMsg() As String
        Get
            If _NomeCampoMsg = "" Then _NomeCampoMsg = Me.Name.Replace("nud", "")
            Return _NomeCampoMsg
        End Get
        Set(ByVal value As String)
            _NomeCampoMsg = value
        End Set
    End Property

End Class

