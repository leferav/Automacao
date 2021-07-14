Public Class fbNumericBox
    Inherits CurrencyBox.CurrencyBox

    Public Sub New()
        Me.MaxValue = 100000000000
        Me.MinValue = -100000000000
        CorOriginal = Me.BackColor
        FonteOriginal = Me.ForeColor
    End Sub

    <System.ComponentModel.Category("FeedBack")>
    Public Property MudarCorBloqueio() As Boolean = True
    Private Property CorOriginal() As Color
    Private Property FonteOriginal() As Color


    <System.ComponentModel.Category("FeedBack")> _
       Public Property QtdDigitos() As Integer
        Get
            Return Me.DecimalDigits
        End Get
        Set(ByVal value As Integer)
            Me.DecimalDigits = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
   Public Property isCurrencySimbol() As Boolean
        Get
            Return Me.CurrencySimbol
        End Get
        Set(ByVal value As Boolean)
            Me.CurrencySimbol = value
            Me.Text = 0
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
     Public Property isNegativeValue() As Boolean
        Get
            Return Me.AllowsNegativeNumbers
        End Get
        Set(ByVal value As Boolean)
            Me.AllowsNegativeNumbers = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
      Public Property ValorMaximo() As Double
        Get
            Return Me.MaxValue
        End Get
        Set(ByVal value As Double)
            Me.MaxValue = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
      Public Property ValorMinimo() As Double
        Get
            Return Me.MinValue
        End Get
        Set(ByVal value As Double)
            Me.MinValue = value
        End Set
    End Property

    Private Sub fbNumericBox_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        If MudarCorBloqueio Then
            If Me.Enabled = True Then
                If _req = True Then
                    Me.BackColor = Color.LightBlue 'System.Drawing.SystemColors.GradientActiveCaption
                Else
                    Me.BackColor = Color.White
                End If
            Else
                Me.BackColor = Color.LightGray
            End If
        Else
            Me.BackColor = CorOriginal
            Me.ForeColor = FonteOriginal
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
                If Me.BackColor = Color.LightBlue Then
                    Me.BackColor = Color.White
                End If
            End If
        End Set
    End Property

    Dim _focu As Boolean = False
    <System.ComponentModel.Category("FeedBack")> _
    Public Property MudarCorFoco() As Boolean
        Get
            Return _focu
        End Get
        Set(ByVal value As Boolean)
            _focu = value
        End Set
    End Property

    Private Sub fbNumericBox_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
        If _focu Then
            If _focu Then
                Me.BackColor = Color.DarkCyan
                Me.ForeColor = Color.Lavender
            ElseIf Me.Enabled Then
                Me.BackColor = Color.White
                Me.ForeColor = Color.Black
            End If
        End If
    End Sub

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
