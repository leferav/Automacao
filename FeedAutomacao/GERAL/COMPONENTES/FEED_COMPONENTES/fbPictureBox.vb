Public Class fbPicturebox
    Inherits PictureBox

    Private WithEvents MnCont As ContextMenu
    Public Sub New()
        Me.DB = New StandardControlDB(Me, Nothing)
        MnCont = New ContextMenu
        MnCont.MenuItems.Add("Carregar Imagem", AddressOf CarregaImagem)
        MnCont.MenuItems.Add("Limpar Imagem", AddressOf LimpaImagem)
        Me.BotaoDireitoManipulaImagem = True
    End Sub

    <System.ComponentModel.Category("FeedBack")>
    Public Property DB As StandardControlDB

    <System.ComponentModel.Category("FeedBack")>
    Private _BotaoDireitoManipulaImagem As Boolean
    Public Property BotaoDireitoManipulaImagem() As Boolean
        Get
            Return _BotaoDireitoManipulaImagem
        End Get
        Set(ByVal value As Boolean)
            _BotaoDireitoManipulaImagem = value
        End Set
    End Property


    Private Sub LimpaImagem(sender As Object, e As EventArgs)
        Me.Image = Nothing
    End Sub

    Private Sub CarregaImagem(sender As Object, e As EventArgs)
        Dim c = buscaCaminhoImagem()
        If c <> "" Then
            Me.ImageLocation = c
        End If
    End Sub

    Private Sub ClicaDireito(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If _BotaoDireitoManipulaImagem Then
            If e.Button = MouseButtons.Right Then
                MnCont.Show(Me, New Point(0, 0))
            End If
        End If
    End Sub

    Private Function buscaCaminhoImagem() As String
        Dim cmh As String = ""
        Dim ofd As New OpenFileDialog
        ofd.Multiselect = False
        ofd.Filter = "Imagem no Formato JPG (*.JPG)|*.JPG|Imagem no Formato BMP (*.BMP)|*.BMP|Imagem no Formato GIF (*.GIF)|*.GIF|Imagem no Formato PNG (*.PNG)|*.PNG"
        ofd.ShowDialog()
        If ofd.FileName <> "" AndAlso System.IO.File.Exists(ofd.FileName) Then
            cmh = ofd.FileName
        End If
        Return cmh
    End Function

End Class
