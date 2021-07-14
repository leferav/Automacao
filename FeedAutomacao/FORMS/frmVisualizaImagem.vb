Public Class frmVisualizaImagem

    Public Caminho As String

    Private Sub frmVisualizaImagem_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        pbImagem.Image = Nothing
    End Sub

    Private Sub frmVisulizarImagem_Load(sender As Object, e As EventArgs) Handles Me.Load
        pbImagem.Image = New Drawing.Bitmap(Caminho)
    End Sub

End Class
