Public Class FrmSplash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            RectangleShape2.Width += 6
            If RectangleShape2.Width >= 300 Then
                Timer1.Stop()
                chamaLoguin()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub


    Public Sub chamaLoguin()
        Me.Close()
    End Sub

End Class