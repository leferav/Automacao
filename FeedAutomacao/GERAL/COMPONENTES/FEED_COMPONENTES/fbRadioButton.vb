Public Class fbRadioButton
    Inherits RadioButton

    Dim _valor As Object
    <System.ComponentModel.Category("FeedBack")>
    Public Property Valor() As Object
        Get
            Return _valor
        End Get
        Set(ByVal value As Object)
            _valor = value
            ' Me.Checked = _valor
        End Set
    End Property

    Dim _campo As String = ""
    <System.ComponentModel.Category("FeedBack")>
    Public Property Campo() As String
        Get
            Return _campo
        End Get
        Set(ByVal value As String)
            _campo = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property valorVazio() As Boolean

    'Private Sub fbRadioButton_CheckedChanged(sender As Object, e As System.EventArgs) Handles Me.CheckedChanged
    '    If Me._campo <> "" Then Me._valor = Me.Checked
    'End Sub

    <System.ComponentModel.Category("FeedBack")>
    Public Property ValorChecado() As String

    Private Sub fbRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Me.CheckedChanged
        If Me.Name <> "" AndAlso Not IsNothing(Me.ValorChecado) AndAlso Me.ValorChecado <> "" Then DirectCast(Me.Parent, fbRadioGroupBox).DisparaEvento(Me.Checked, Me.ValorChecado)
    End Sub

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

End Class
