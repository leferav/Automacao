Public Class fbMenuFlex

    Dim tamanho As Integer = 0

    Dim _hint As New fbToolTip

    Dim s As String = ""

    Public Property Hint() As String
        Get
            Return s
        End Get
        Set(ByVal value As String)
            s = value
            _hint.SetToolTip(Button1, "Retrair " + s)
        End Set
    End Property

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _hint.ToolTipTitle = ""
        _hint.ToolTipIcon = ToolTipIcon.None
        _hint.SetToolTip(Button1, "Retrair " + s)
        Button1.Text = ""
        Button1.FlatAppearance.BorderSize = 0
        Button1.BackColor = Color.WhiteSmoke
        Panel1.BackColor = Color.LightSteelBlue
        Button1.Tag = "<<"
        If Button1.Dock = DockStyle.Right Then
            Button1.Image = My.Resources._1302694967_previous
        ElseIf Button1.Dock = DockStyle.Left Then
            Button1.Image = My.Resources._1302694947_next
        End If
    End Sub

    Public Property Direcao() As DockStyle
        Get
            Return Button1.Dock
        End Get
        Set(ByVal value As DockStyle)
            Button1.Dock = value
            If Button1.Dock = DockStyle.Right Then
                Button1.Image = My.Resources._1302694967_previous
            ElseIf Button1.Dock = DockStyle.Left Then
                Button1.Image = My.Resources._1302694947_next
            End If
        End Set
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Dock = DockStyle.Left Then
            Button1.SendToBack()
        ElseIf Button1.Dock = DockStyle.Right Then
            Button1.BringToFront()
        End If
        TrataTamanho()
    End Sub

    Public Sub TrataTamanho(Optional ByVal diminuir As Boolean = False)
        If Button1.Tag = "<<" Then
            tamanho = Me.Width
            Me.Width = 25
            Button1.Tag = ">>"
            If Button1.Dock = DockStyle.Right Then
                Button1.Image = My.Resources._1302694947_next
            ElseIf Button1.Dock = DockStyle.Left Then
                Button1.Image = My.Resources._1302694967_previous
            End If
            _hint.SetToolTip(Button1, "Expandir " + s)
        Else
            Me.Width = tamanho
            Button1.Tag = "<<"
            If Button1.Dock = DockStyle.Right Then
                Button1.Image = My.Resources._1302694967_previous
            ElseIf Button1.Dock = DockStyle.Left Then
                Button1.Image = My.Resources._1302694947_next
            End If
            _hint.SetToolTip(Button1, "Retrair " + s)
        End If
    End Sub

    Private Sub PanelFlex_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If Button1.Dock = DockStyle.Right Then
            Button1.SendToBack()
        ElseIf Button1.Dock = DockStyle.Left Then
            Button1.BringToFront()
        End If
    End Sub
End Class
