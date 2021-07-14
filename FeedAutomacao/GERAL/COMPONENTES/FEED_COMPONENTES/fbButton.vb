Public Class fbButton
    Inherits Button

    Public Sub New()
        Me.FlatStyle = FlatStyle.Flat
        Me.Cursor = Cursors.Hand
        Me.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold, GraphicsUnit.Point)
    End Sub

End Class
