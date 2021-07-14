Public Class fbLookUp

    Dim _dt As DataRow = Nothing
    Dim _ID As Integer = -1
    Dim _frm As frmPadraoPesquisa
    Dim selecionandoID As Boolean = False

    <System.ComponentModel.Category("FeedBack")> _
    Public Event Selecionando()

    <System.ComponentModel.Category("FeedBack")> _
    Public Event antesDeAbrir()

    <System.ComponentModel.Category("FeedBack")> _
   Public Event Pesquisar(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public Sub New()
        InitializeComponent()
        Me.DB = New StandardControlDB(Me, -1)
        AddHandler Me.txt.TextChanged, AddressOf Me.alteraValor
    End Sub

    Protected Sub antesDeAbrirF(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent antesDeAbrir()
        LimpaTexto = False
    End Sub

    Protected Sub alteraValor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent Selecionando()
        LimpaTexto = True
        If _ID = -1 Then
            selecionandoID = False
            Me.btnLimpar.Visible = False
        ElseIf Me.Enabled Then
            Me.btnLimpar.Visible = True
        Else
            Me.btnLimpar.Visible = False
        End If
        Me.ToolTip1.SetToolTip(Me.txt, Me.txt.Text)
    End Sub

    Public Sub Pesquisa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent Pesquisar(sender, e)
    End Sub

    <System.ComponentModel.Category("FeedBack")>
    Public Property DataTableSelect() As DataRow
        Get
            Return _dt
        End Get
        Set(ByVal value As DataRow)
            _dt = value
            If selecionandoID = False Then
                If value IsNot Nothing Then
                    _ID = value.Item(0)
                    txt.Text = value.Item(1)
                    'Else
                    '    _ID = -1
                    '    txt.Clear()
                End If
            End If
        End Set
    End Property

    Public Property LimpaTexto As Boolean = True

    <System.ComponentModel.Category("FeedBack")> _
    Public Property SelectID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
            If _ID > 0 AndAlso _frm IsNot Nothing Then
                selecionandoID = True
                _frm.ID = _ID
                _frm.seleciona()
                If _frm.ID <> "-1" AndAlso _frm.daTaSelect.Rows.Count > 0 Then
                    _dt = _frm.daTaSelect.Rows(0)
                Else
                    _dt = Nothing
                End If
                txt.Text = _frm.ValVisivel
            ElseIf LimpaTexto Then
                txt.Clear()
                selecionandoID = False
            End If
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property FormularioPesquisa() As frmPadraoPesquisa
        Get
            Return _frm
        End Get
        Set(ByVal value As frmPadraoPesquisa)
            _frm = value
        End Set
    End Property

    Private Sub fbLookUp_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled Then
            If Me._req Then
                Me.txt.BackColor = Color.LightBlue 'System.Drawing.SystemColors.GradientActiveCaption
            Else
                Me.txt.BackColor = Color.White
            End If
        Else
            Me.txt.BackColor = Color.FromArgb(255, 212, 208, 200)
            Me.btnLimpar.Visible = False
        End If
    End Sub

    'Private Sub fbLookUp_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
    '    SetKeyUp(e)
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click, Me.Pesquisar
        abreFormLookUP()
    End Sub

    Public Sub abreFormLookUP()
        Try
            If _frm IsNot Nothing Then
                RaiseEvent antesDeAbrir()
                Me.FormularioPesquisa = _frm
                _frm.paiForm = Me.ParentForm
                Try
                    _frm.ShowDialog()
                Catch ex As Exception
                    _frm.Close()
                    _frm.ShowDialog()
                End Try
                If _frm.ID <> -1 Then
                    selecionandoID = True
                    _ID = _frm.ID
                    If Not IsNothing(_frm.daTaSelect) Then
                        _dt = _frm.daTaSelect.Rows(0)
                        If txt.Text = _frm.ValVisivel Then
                            RaiseEvent Selecionando()
                        End If
                        txt.Text = _frm.ValVisivel
                    End If
                Else
                    '_ID = -1
                    'Me.txt.Text = ""
                    _dt = Nothing
                End If
                If Me.ParentForm IsNot Nothing Then
                    Me.ParentForm.Focus()
                Else
                    My.Forms.frmMain2.Focus()
                End If
            Else
                MsgBox("Formulário de Pesquisa não Selecionado!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Public Sub SetKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Shift AndAlso e.KeyCode = Keys.F4 Then
            Me.SelectID = -1
        ElseIf e.KeyCode = Keys.F4 Then
            abreFormLookUP()
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
                Me.txt.BackColor = Color.LightBlue
                Me.txt.Requerido = True
            ElseIf Me.Enabled Then
                Me.txt.BackColor = Color.White
            End If
        End Set
    End Property

    Private Sub btnBuscar_GotFocus(sender As Object, e As System.EventArgs) Handles btnBuscar.GotFocus, txt.GotFocus
        If Me.btnBuscar.Focused OrElse Me.txt.Focused Then
            Me.btnBuscar.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub btnBuscar_LostFocus(sender As Object, e As System.EventArgs) Handles btnBuscar.LostFocus, txt.LostFocus
        If Me.btnBuscar.Focused = False AndAlso Me.txt.Focused = False Then
            Me.btnBuscar.BackColor = Color.White
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

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Me._ID = -1
        Me.txt.Text = ""
    End Sub

End Class
