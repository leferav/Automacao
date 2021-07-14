Imports System.ComponentModel
Imports System.Drawing

Public Class fbMenu
    Inherits Panel

    Private sTexto As String
    Dim bit As Integer
    Private iTamanho As Integer
    Dim p1, p2 As Point
    Dim _hint As New fbToolTip
    Public Sub New()
        InitializeComponent()
        pnlTopo.BackColor = Color.DimGray
        pnlFecha.BackColor = Color.DimGray
        pnlFechhar.BackColor = Color.DimGray
        pnlIcone.BackColor = Color.DimGray
        Me.BackColor = Color.WhiteSmoke
        pnlFecha.SendToBack()
        pnlFecha.Cursor = Cursors.Hand
        verImagem()
        _hint.ToolTipIcon = ToolTipIcon.None
        _hint.ToolTipTitle = ""
    End Sub

    <System.ComponentModel.Category("FeedBack")> _
    Public Property Texto() As String
        Get
            Return lblTitulo.Text
        End Get
        Set(ByVal value As String)
            lblTitulo.Text = value
            Me.Refresh()
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property Fechar() As Boolean
        Get
            Return pnlFecha.Visible
        End Get
        Set(ByVal value As Boolean)
            pnlFecha.Visible = value
            pnlFechhar.BackColor = Color.SteelBlue
            Me.Refresh()
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property Icone() As Image
        Get
            Return pnlIcone.BackgroundImage
        End Get
        Set(ByVal value As Image)
            If value IsNot Nothing Then
                pnlIcone.BackgroundImage = value
                pnlIcone.Visible = True
            Else
                pnlIcone.BackgroundImage = Nothing
                pnlIcone.Visible = False
            End If
            Me.Refresh()
        End Set
    End Property

    Dim _panel As New Panel
    Public Property Parente() As Panel
        Get
            Return _panel
        End Get
        Set(ByVal value As Panel)
            _panel = value
        End Set
    End Property

    Dim s As String = ""

    Public Property Hint() As String
        Get
            Return s
        End Get
        Set(ByVal value As String)
            s = value
            verImagem()
        End Set
    End Property

    Private Sub btnFechar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlFecha.Click
        trataTamanho()
    End Sub

    Private Sub lblTitulo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTitulo.Click
        trataTamanho()
    End Sub

    Private Sub btnFechar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlFecha.MouseHover
        pnlFecha.SendToBack()
        pnlFecha.Cursor = Cursors.Hand
        verImagem()
    End Sub

    Private Sub lblTitulo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTitulo.MouseHover
        lblTitulo.Cursor = Cursors.Hand
        setToolTipTitulo()
    End Sub

    Private Sub btnFechar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlFecha.MouseLeave
        pnlFecha.Cursor = Cursors.Arrow

        verImagem()

        _hint.SetToolTip(pnlFecha, "")
    End Sub

    Private Sub lblTitulo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTitulo.MouseLeave
        lblTitulo.Cursor = Cursors.Arrow

        setToolTipTitulo()

        _hint.SetToolTip(lblTitulo, "")
    End Sub

    Private Sub verImagem()
        If Me.Height = 25 Then
            pnlFecha.Tag = ">>"
            pnlFecha.BackgroundImage = My.Resources._1302696679_kdevelop_down
            pnlFecha.BackgroundImageLayout = ImageLayout.Center
            _hint.SetToolTip(pnlFecha, "Expandir " + s)
        Else
            pnlFecha.Tag = "<<"
            pnlFecha.BackgroundImage = My.Resources._1302696706_1uparrow
            pnlFecha.BackgroundImageLayout = ImageLayout.Center
            _hint.SetToolTip(pnlFecha, "Retrair " + s)
        End If
    End Sub

    Private Sub setToolTipTitulo()
        If Me.Height = 25 Then
            _hint.SetToolTip(lblTitulo, "Expandir " + s)
        Else
            _hint.SetToolTip(lblTitulo, "Retrair " + s)
        End If
    End Sub

    Public Sub trataTamanho(Optional ByVal diminui As Boolean = False, _
                            Optional ByVal tamanhoNormal As Boolean = False)
        Dim t = Parente.Height
        If diminui = True Then
            If Me.Height <> 25 Then
                iTamanho = Me.Height
                Me.Height = 25
                If Parente IsNot Nothing Then Parente.Height = t - iTamanho + 25
                verImagem()
            End If
        ElseIf tamanhoNormal = True Then
            If iTamanho <> 0 Then Me.Height = iTamanho
            If Parente IsNot Nothing Then Parente.Height = t + iTamanho - 25
            verImagem()
        Else
            If Me.Height = 25 Then
                If iTamanho <> 0 Then Me.Height = iTamanho
                If Parente IsNot Nothing Then Parente.Height = t + iTamanho - 25
                verImagem()
            Else
                iTamanho = Me.Height
                Me.Height = 25
                If Parente IsNot Nothing Then Parente.Height = t - iTamanho + 25
                verImagem()
            End If
        End If
    End Sub

    Private Sub pnlTopo_Click(sender As Object, e As EventArgs) Handles pnlTopoTopo.Click
        trataTamanho()
    End Sub

End Class
