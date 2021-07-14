Public Class frmPadraoSeleciona
    Dim habilita As Boolean = False
    Dim _pnl As Boolean = True
    Dim vlrPnl As Integer = 10
    Private _filtra As Boolean = False

    Private Sub frmPadraoSeleciona_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.WindowState = FormWindowState.Maximized
        Me.Filtrar(_filtra)
        _filtra = True
    End Sub

    'Private Sub frmPadraoSeleciona_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    '    If Me.WindowState <> FormWindowState.Maximized Then
    '        Me.WindowState = FormWindowState.Maximized
    '    End If
    '    Me.Filtrar(_filtra)
    '    _filtra = True
    'End Sub

    Private Sub frmPadraoSeleciona_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        menuFiltro.trataTamanho(False, True)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    <System.ComponentModel.Category("FeedBack")> _
    Public Property pnlDados() As Boolean
        Get
            Return _pnl
        End Get
        Set(ByVal value As Boolean)
            _pnl = value
            If value = False Then
                vlrPnl = pnlAux.Height
                pnlAux.Height = 0
            Else
                pnlAux.Height = IIf(vlrPnl = 0, 10, vlrPnl)
            End If
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property ColunaSelecionavel() As Boolean
        Get
            Return dgvDados.ColunaSeleciona
        End Get
        Set(ByVal value As Boolean)
            dgvDados.ColunaSeleciona = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property veMenuFiltro() As Boolean
        Get
            Return menuFiltro.Visible
        End Get
        Set(ByVal value As Boolean)
            menuFiltro.Visible = value
        End Set
    End Property


    Public Overridable Sub Filtrar(Optional ByVal filtra As Boolean = True)
        Me.dgvDados.idSel = -1
    End Sub

    Public Overridable Sub Seleciona()

    End Sub

    Public Overridable Sub FormatarCelula(sender As Object, e As DataGridViewCellFormattingEventArgs)

    End Sub

    Public Overridable Sub setaDts()
        lbLinhas.Text = FormatNumber(dgvDados.RowCount, 0)
    End Sub

    Public Overridable Sub SelectGrid(ByVal rowSelect As DataGridViewRow)

    End Sub

    Public Overridable Sub cellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs)

    End Sub


    Public Overridable Sub cellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Public Overridable Sub cellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Filtrar()
    End Sub

    Private Sub dgvDados_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDados.CellEndEdit
        cellEndEdit(sender, e)
    End Sub

    Private Sub dgvDados_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvDados.CellValidating
        cellValidating(sender, e)
    End Sub

    Private Sub dgvDados_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDados.CellValueChanged
        cellValueChanged(sender, e)
    End Sub

    Private Sub dgvDados_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDados.CellEnter
        Seleciona()
    End Sub

    Private Sub dgvDados_DataSourceChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDados.DataSourceChanged
        setaDts()
    End Sub

    Public Function setaWhere(ByVal _filtro As String, Optional ByVal semWhere As Boolean = True) As String
        Dim ret As String = ""
        If semWhere = True Then
            ret = " AND "
        Else
            If Trim(_filtro) = "" Then
                ret = " WHERE "
            Else
                ret = " AND "
            End If
        End If
        Return ret
    End Function

    Private Sub dgvDados_selecionaCol(ByVal row As DataGridViewRow) Handles dgvDados.selecionaCol
        SelectGrid(row)
    End Sub

    Private Sub fbBarra_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F5 Then
            If _btnF05 IsNot Nothing AndAlso _btnF05.Enabled = False Then
            Else
                inserirF5()
            End If
        ElseIf e.KeyCode = Keys.Home Then
            Filtrar()
        ElseIf Not e.Modifiers = Keys.Shift AndAlso e.KeyCode = Keys.F2 Then
            If _btnF02 IsNot Nothing AndAlso _btnF02.Enabled = False Then
            Else
                SalvarF2(Me.dgvDados.idSel)
            End If
        ElseIf e.Modifiers = Keys.Shift AndAlso e.KeyCode = Keys.F2 Then
            ExcluirSFHITF2(Me.dgvDados.idSel)
        ElseIf e.KeyCode = Keys.F3 Then
            If _btnF03 IsNot Nothing AndAlso _btnF03.Enabled = False Then
            Else
                funcF3()
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            If _btnF06 IsNot Nothing AndAlso _btnF06.Enabled = False Then
            Else
                EditarF6(Me.dgvDados.idSel)
            End If
        ElseIf e.KeyCode = Keys.F7 Then
            If _btnF07 IsNot Nothing AndAlso _btnF07.Enabled = False Then
            Else
                funcF7()
            End If
        ElseIf e.KeyCode = Keys.F8 Then
            If _btnF08 IsNot Nothing AndAlso _btnF08.Enabled = False Then
            Else
                funcF8()
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            If _btnF09 IsNot Nothing AndAlso _btnF09.Enabled = False Then
            Else
                PesquisaF9()
            End If
        ElseIf e.KeyCode = Keys.F10 Then
            If _btnF10 IsNot Nothing AndAlso _btnF10.Enabled = False Then
            Else
                funcF10()
            End If
        ElseIf e.KeyCode = Keys.F11 Then
            If _btnF11 IsNot Nothing AndAlso _btnF11.Enabled = False Then
            Else
                funcF11()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            If _btnF12 IsNot Nothing AndAlso _btnF12.Enabled = False Then
            Else
                RelatorioF12()
            End If
        ElseIf Not e.Modifiers = Keys.Shift AndAlso e.KeyCode = Keys.F4 Then
            If sender.activecontrol.GetType().Name = "fbLookUp" Then
                sender.activecontrol.abreFormLookUP()
            End If
        ElseIf e.Modifiers = Keys.Shift AndAlso e.KeyCode = Keys.F4 Then
            If sender.activecontrol.GetType().Name = "fbLookUp" Then
                sender.activecontrol.selectID = -1
            End If
        End If
    End Sub

    Public Overridable Sub inserirF5()
        Exit Sub
    End Sub

    Public Overridable Function SalvarF2(ByVal IDSel As Integer) As Boolean
        Return False
    End Function

    Public Overridable Function EditarF6(ByVal IDSel As Integer) As Boolean
        Return False
    End Function

    Public Overridable Function ExcluirSFHITF2(ByVal IDSel As Integer) As Boolean
        Return False
    End Function

    Public Overridable Sub RelatorioF12()

    End Sub

    Public Overridable Sub PesquisaF9()
        If menuFiltro.Height = 25 Then
            menuFiltro.trataTamanho(False, True)
            If c IsNot Nothing Then c.Focus()
        Else
            menuFiltro.trataTamanho(True, False)
        End If
    End Sub

    Public Overridable Sub funcF3()

    End Sub

    Public Overridable Sub funcF7()

    End Sub

    Public Overridable Sub funcF8()

    End Sub

    Public Overridable Sub funcF10()

    End Sub

    Public Overridable Sub funcF11()

    End Sub

    Dim c As Control = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property controlPesquisa() As Control
        Get
            Return c
        End Get
        Set(ByVal value As Control)
            c = value
        End Set
    End Property

    Private Sub dgvDados_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvDados.MouseDoubleClick
        If _btnF06 IsNot Nothing AndAlso _btnF06.Enabled = False Then
        Else
            EditarF6(Me.dgvDados.idSel)
        End If
    End Sub

#Region "BUTTON"

    Dim _btnF02 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property btnF02() As fbButtonVisual
        Get
            Return _btnF02
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF02 = value
        End Set
    End Property

    Dim _btnF03 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property btnF03() As fbButtonVisual
        Get
            Return _btnF03
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF03 = value
        End Set
    End Property

    Dim _btnF05 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property btnF05() As fbButtonVisual
        Get
            Return _btnF05
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF05 = value
        End Set
    End Property

    Dim _btnF06 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property btnF06() As fbButtonVisual
        Get
            Return _btnF06
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF06 = value
        End Set
    End Property

    Dim _btnF07 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property btnF07() As fbButtonVisual
        Get
            Return _btnF07
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF07 = value
        End Set
    End Property

    Dim _btnF08 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property btnF08() As fbButtonVisual
        Get
            Return _btnF08
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF08 = value
        End Set
    End Property

    Dim _btnF09 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property btnF09() As fbButtonVisual
        Get
            Return _btnF09
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF09 = value
        End Set
    End Property

    Dim _btnF10 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property btnF10() As fbButtonVisual
        Get
            Return _btnF10
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF10 = value
        End Set
    End Property

    Dim _btnF11 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property btnF11() As fbButtonVisual
        Get
            Return _btnF11
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF11 = value
        End Set
    End Property

    Dim _btnF12 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property btnF12() As fbButtonVisual
        Get
            Return _btnF12
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF12 = value
        End Set
    End Property

#End Region

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Try
        '    If dgvDados.RowCount > 0 Then
        '        If MsgBox("Deseja Gerar os Dados no Excel?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '            clGeral.Grid2Excel(dgvDados, True)
        '        End If
        '    End If
        'Catch : End Try
    End Sub

    Private Sub dgvDados_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDados.CellFormatting
        FormatarCelula(sender, e)
    End Sub

End Class
