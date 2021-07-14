Public Class fbNumericUpDown
    Inherits NumericUpDown

    Public Sub New()
        Me.Value = 0
    End Sub

    Private Sub fbNumericBox_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled = True Then
            If _req = True Then
                Me.BackColor = Color.LightBlue 'System.Drawing.SystemColors.GradientActiveCaption
            Else
                Me.BackColor = Color.White
            End If
        Else
            Me.BackColor = Color.LightGray
        End If
    End Sub

    Dim _req As Boolean = False
    <System.ComponentModel.Category("FeedBack")> _
    Public Property Requerido() As Boolean
        Get
            Return _req
        End Get
        Set(ByVal value As Boolean)
            _req = value
            If _req = True AndAlso Me.Enabled Then
                Me.BackColor = Color.LightBlue 'System.Drawing.SystemColors.GradientActiveCaption
            ElseIf Me.Enabled Then
                Me.BackColor = Color.White
            End If
        End Set
    End Property

End Class
