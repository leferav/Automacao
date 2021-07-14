Public Class fbMaskBox
    Inherits MaskedTextBox

    Public Sub New()
        Me.BorderStyle = BorderStyle.FixedSingle
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

    Public Sub msb_BackColorChanged() Handles Me.EnabledChanged
        If Me.Enabled Then
            If _req = True Then
                Me.BackColor = Color.LightBlue 'System.Drawing.SystemColors.GradientActiveCaption
            Else
                Me.BackColor = Color.White
            End If
        Else
            Me.BackColor = Color.FromArgb(255, 212, 208, 200)
        End If
    End Sub

    <System.ComponentModel.Category("FeedBack")>
    Public ReadOnly Property ValorSemMascara() As String
        Get
            Dim sVal As String
            Me.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            sVal = Me.Text
            Me.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
            Return sVal.TrimEnd()
        End Get
    End Property

    Dim _NomeCampoMsg As String = ""
    <System.ComponentModel.Category("FeedBack")>
    Public Property NomeCampoMsg() As String
        Get
            If _NomeCampoMsg = "" Then _NomeCampoMsg = Me.Name.Replace("txt", "")
            Return _NomeCampoMsg
        End Get
        Set(ByVal value As String)
            _NomeCampoMsg = value
        End Set
    End Property

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

    <System.ComponentModel.Category("FeedBack")>
    Public Property DB As StandardControlDB

End Class
