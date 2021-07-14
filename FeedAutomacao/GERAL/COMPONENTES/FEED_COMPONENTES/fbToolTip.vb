Public Class fbToolTip
    Inherits ToolTip

    Public Sub New()
        Me.BackColor = Color.FromName("GradientActiveCaption")
        Me.ToolTipIcon = ToolTipIcon.Info
        Me.ToolTipTitle = "Aviso"
    End Sub

End Class
