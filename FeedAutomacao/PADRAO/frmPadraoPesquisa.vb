Public Class frmPadraoPesquisa

    Public ID As Integer = -1
    Dim _valID As String = "ID"
    Dim _val As String = ""
    Dim dtSel As DataTable


    <System.ComponentModel.Category("FeedBack")> _
    Public Property ValID() As String
        Get
            Return _valID
        End Get
        Set(ByVal value As String)
            _valID = value
        End Set
    End Property

    Dim _carregaDados As Boolean = True
    <System.ComponentModel.Category("FeedBack")> _
    Public Property CarregaDados() As Boolean
        Get
            Return _carregaDados
        End Get
        Set(ByVal value As Boolean)
            _carregaDados = value
        End Set
    End Property

    Dim _campoF As Control = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property campoFoco() As Control
        Get
            Return _campoF
        End Get
        Set(ByVal value As Control)
            _campoF = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property Filtro() As Boolean
        Get
            Return menuFiltro.Visible
        End Get
        Set(ByVal value As Boolean)
            menuFiltro.Visible = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property ValVisivel() As String
        Get
            Return _val
        End Get
        Set(ByVal value As String)
            _val = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
   Public Property GridVisivel() As Boolean
        Get
            Return dgvDados.Visible
        End Get
        Set(ByVal value As Boolean)
            dgvDados.Visible = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property daTaSelect() As DataTable
        Get
            Return dtSel
        End Get
        Set(ByVal value As DataTable)
            dtSel = value
        End Set
    End Property

    Dim _form As Form
    <System.ComponentModel.Category("FeedBack")> _
    Public Property paiForm() As Form
        Get
            Return _form
        End Get
        Set(ByVal value As Form)
            _form = value
        End Set
    End Property

    Private Sub fecha()
        'ID = -1
        Me.dgvDados.DataSource = Nothing
        Me.Close()
        'Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'ID = -1
        fecha()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecionar.Click
        seleciona()
        'Me.Hide()
    End Sub

    Public Overridable Sub carrega(Optional ByVal filtro As String = "")

    End Sub

    Public Overridable Sub seleciona()

    End Sub

    Public Overridable Sub setaValor()
        ID = dgvDados.CurrentRow.Cells(_valID).Value
    End Sub

    Public Overridable Sub arrumaGrid()
        dgvDados.Columns(ValID).Visible = False
    End Sub

    Private Sub dgvDados_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvDados.CellEnter
        setaValor()
    End Sub

    'Private Sub frmPadraoPesquisa_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
    '    If _campoF IsNot Nothing Then
    '        _campoF.Focus()
    '    Else
    '        If c IsNot Nothing Then c.Focus()
    '    End If
    'End Sub

    Private Sub frmPadraoPesquisa_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate
        If _form IsNot Nothing Then
            Me._form.Focus()
        End If
    End Sub

    Private Sub frmBusca_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        limpaFiltro()
        If _carregaDados Then
            carrega()
        End If
        menuFiltro.trataTamanho(False, True)
        If _campoF IsNot Nothing Then
            _campoF.Focus()
        Else
            If c IsNot Nothing Then c.Focus()
        End If
    End Sub

    Dim _frmBARRA As frmPadraoCadastro = Nothing
    Dim _frmNORMAL As frmPadraoCadastroDados = Nothing

    <System.ComponentModel.Category("FeedBack")>
    Public Property FormularioCadastroBARRA() As frmPadraoCadastro
        Get
            Return _frmBARRA
        End Get
        Set(ByVal value As frmPadraoCadastro)
            _frmBARRA = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property FormularioCadastro() As frmPadraoCadastroDados
        Get
            Return _frmNORMAL
        End Get
        Set(ByVal value As frmPadraoCadastroDados)
            _frmNORMAL = value
        End Set
    End Property

    Private Sub FbButtonVisual1_Click(sender As Object, e As EventArgs) Handles FbButtonVisual1.Click
        If _frmBARRA IsNot Nothing AndAlso _frmNORMAL Is Nothing Then
            _frmBARRA.ID = -1
            _frmBARRA.abreNovo = True
            _frmBARRA.ShowDialog()
        ElseIf _frmBARRA Is Nothing AndAlso _frmNORMAL IsNot Nothing Then
            _frmNORMAL.ID = -1
            _frmNORMAL.Limpar()
            _frmNORMAL.ShowDialog()
        End If
    End Sub

    Private Sub limpaFiltro()
        For Each r As Object In menuFiltro.Controls
            If r.GetType().Name = "fbTextBox" Then
                r.clear()
            ElseIf r.GetType().Name = "fbMaskBox" Then
                r.clear()
            ElseIf r.GetType().Name = "fbNumericBox" Then
                r.text = 0
            End If
        Next
    End Sub

    Private Sub dgvDados_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDados.DataSourceChanged
        If dgvDados.ColumnCount > 0 Then
            arrumaGrid()
        End If
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        carrega()
    End Sub

    Private Sub dgvDados_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDados.CellMouseDoubleClick
        seleciona()
    End Sub

    Private Sub dgvDados_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvDados.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            seleciona()
            'e.SuppressKeyPress = False       
        Else
            e.SuppressKeyPress = False
        End If
    End Sub

    Private Sub frmPadraoPesquisa_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            fecha()
        ElseIf e.KeyCode = Keys.Down Then
            Dim cb As Boolean = False
            For Each c As Control In Me.menuFiltro.Controls
                If c.Name.Contains("cbb") Then
                    If c.Focused Then
                        cb = True
                    End If
                End If
            Next
            If cb = False Then
                dgvDados.Focus()
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            PesquisaF9()
        ElseIf e.KeyCode = Keys.Home Then
            carrega()
        End If
    End Sub

    Dim c As Control = Nothing
    Public Property controlFocus() As Control
        Get
            Return c
        End Get
        Set(ByVal value As Control)
            c = value
        End Set
    End Property

    Public Overridable Sub PesquisaF9()
        If menuFiltro.Height = 25 Then
            menuFiltro.trataTamanho(False, True)
            If c IsNot Nothing Then c.Focus()
        Else
            menuFiltro.trataTamanho(True, False)
        End If
    End Sub

    Dim _cond As String
    Public Property Condicao() As String
        Get
            Return _cond
        End Get
        Set(ByVal value As String)
            _cond = value
        End Set
    End Property

    Private Sub frmPadraoPesquisa_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            seleciona()
            fecha()
        End If
    End Sub

    Private Sub frmPadraoPesquisa_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub



    Public Overridable Sub FormatarCelula(sender As Object, e As DataGridViewCellFormattingEventArgs)

    End Sub



End Class
