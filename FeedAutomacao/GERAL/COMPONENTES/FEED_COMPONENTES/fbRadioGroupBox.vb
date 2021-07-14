Public Class fbRadioGroupBox
    Inherits Dotnetrix.Controls.GroupBoxEX

    Public Sub New()
        Me.DB = New StandardControlDB(Me, "")
    End Sub

    Private ValorAntes As String

    <System.ComponentModel.Category("FeedBack")>
    Public Event MudaValor(ByRef ValorAntes As String, ByRef ValorDepois As String)

    <System.ComponentModel.Category("FeedBack")>
    Public Property DB As StandardControlDB

    <System.ComponentModel.Category("FeedBack")>
    Public Property ValorSelecionado() As String
        Get
            Return BuscaSelecionado()
        End Get
        Set(ByVal value As String)
            SetaFilhos(value)
        End Set
    End Property

    Public Sub DisparaEvento(chk As Boolean, val As String)
        RaiseEvent MudaValor(val, BuscaSelecionado())
    End Sub

    Private Function BuscaSelecionado() As String
        For Each filho In Me.Controls
            If TypeOf filho Is fbRadioButton Then
                If DirectCast(filho, fbRadioButton).Checked Then
                    Return DirectCast(filho, fbRadioButton).ValorChecado
                End If
            End If
        Next
        Return ""
    End Function

    Private Sub SetaFilhos(val As String)
        For Each filho In Me.Controls
            If TypeOf filho Is fbRadioButton Then
                If DirectCast(filho, fbRadioButton).ValorChecado = val And DirectCast(filho, fbRadioButton).Name <> "" Then
                    If DirectCast(filho, fbRadioButton).Checked = False Then _
                            DirectCast(filho, fbRadioButton).Checked = True
                Else
                    DirectCast(filho, fbRadioButton).Checked = False
                End If
            End If
        Next
    End Sub


End Class