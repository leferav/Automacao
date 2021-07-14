Public Class fbTextBox
    Inherits TextBox
    Friend WithEvents btnClear As Button

    Public Sub New()
        Me.BorderStyle = BorderStyle.FixedSingle
        If CaracterTipo = "U" Then
            Me.CharacterCasing = CharacterCasing.Upper
        ElseIf CaracterTipo = "L" Then
            Me.CharacterCasing = CharacterCasing.Lower
        Else
            Me.CharacterCasing = CharacterCasing.Normal
        End If

        Me.DB = New StandardControlDB(Me, "")
    End Sub

    <System.ComponentModel.Category("FeedBack")>
    Public Event ClickBotaoClear(sender As Object, e As EventArgs)

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

    <System.ComponentModel.Category("FeedBack")>
    Public Property CaracterTipo() As String = "U"


    Dim _botaoClear As Boolean = False
    <System.ComponentModel.Category("FeedBack")>
    Public Property botaoClear() As Boolean
        Get
            Return _botaoClear
        End Get
        Set(ByVal value As Boolean)
            _botaoClear = value
            If value Then
                MontaBotaoClear()
            Else
                DesmontaBotaoClear()
            End If
        End Set
    End Property

    Dim _campo As String = ""
    <System.ComponentModel.Category("FeedBack")>
    Public Property Campo() As String
        Get
            Return _campo
        End Get
        Set(ByVal value As String)
            _campo = value
        End Set
    End Property

    Dim _valor As Object
    <System.ComponentModel.Category("FeedBack")>
    Public Property Valor() As Object
        Get
            Return _valor
        End Get
        Set(ByVal value As Object)
            _valor = value
            ' Me.Text = Valor
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property valorVazio() As String = ""


    <System.ComponentModel.Category("FeedBack")>
    Public Property DB As StandardControlDB

    Dim _req As Boolean = False
    <System.ComponentModel.Category("FeedBack")> _
   Public Property Requerido() As Boolean
        Get
            Return _req
        End Get
        Set(ByVal value As Boolean)
            _req = value
            If _req = True AndAlso Me.Enabled Then
                Me.BackColor = Color.LightBlue
            ElseIf Me.Enabled Then
                If Me.BackColor = Color.LightBlue Then
                    Me.BackColor = Color.White
                End If
            End If
        End Set
    End Property

    Public Sub txt_BackColorChanged() Handles Me.EnabledChanged
        If Me.Enabled Then
            If Me._req Then
                Me.BackColor = Color.LightBlue
            Else
                Me.BackColor = Color.White
            End If
        Else
            Me.BackColor = Color.FromArgb(255, 212, 208, 200)
        End If
    End Sub

    Private Sub MontaBotaoClear()
        If _botaoClear Then
            Me.btnClear = New Button
            '
            'btnClear
            '
            Me.btnClear.BackColor = Me.BackColor 'System.Drawing.Color.Transparent
            Me.btnClear.BackgroundImage = My.Resources.closeIcon
            Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClear.FlatAppearance.BorderSize = 0
            Me.btnClear.FlatStyle = FlatStyle.Flat
            Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnClear.Location = New System.Drawing.Point(Me.Size.Width - 15, 5)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(10, 10)
            Me.btnClear.UseVisualStyleBackColor = False
            Me.Controls.Add(btnClear)
            AddHandler Me.btnClear.Click, AddressOf btnClear_Click
        End If
    End Sub

    Private Sub resizeTextBox(sender As Object, e As EventArgs) Handles Me.Resize
        If _botaoClear Then
            Me.btnClear.Location = New System.Drawing.Point(Me.Size.Width - 15, 5)
        End If
    End Sub

    Private Sub DesmontaBotaoClear()
        If _botaoClear Then
            Me.Controls.Remove(btnClear)
            btnClear.Dispose()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        RaiseEvent ClickBotaoClear(sender, e)
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'fbTextBox
        '
        Me.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ResumeLayout(False)

    End Sub

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

    ' <System.ComponentModel.Category("FeedBack")> _
    'Public Property TipoTexto() As CharacterCasing
    '     Get
    '         Return Me.CharacterCasing
    '     End Get
    '     Set(ByVal value As CharacterCasing)
    '         Me.CharacterCasing = value
    '     End Set
    ' End Property

End Class
