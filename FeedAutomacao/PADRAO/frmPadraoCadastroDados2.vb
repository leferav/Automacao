Imports System.Windows.Forms
Public Class frmPadraoCadastroDados2

    Dim _ID As Integer = -1
    Dim _IDRel As Integer = -1
    Dim _dados As New DataTable
    Dim _tab As fbTabPage = Nothing
    Dim _ShowDialog As Boolean = False


    <System.ComponentModel.Category("FeedBack")>
    Public Property ShowDialogs() As Boolean
        Get
            Return _ShowDialog
        End Get
        Set(value As Boolean)
            _ShowDialog = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property tabDados() As fbTabPage
        Get
            Return _tab
        End Get
        Set(ByVal value As fbTabPage)
            _tab = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property IDRelacionamento() As Integer
        Get
            Return _IDRel
        End Get
        Set(ByVal value As Integer)
            _IDRel = value
        End Set
    End Property

    Dim _par As String = ""
    <System.ComponentModel.Category("FeedBack")>
    Public Property Parametro() As String
        Get
            Return _par
        End Get
        Set(ByVal value As String)
            _par = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property Dados() As DataTable
        Get
            Return _dados
        End Get
        Set(ByVal value As DataTable)
            _dados = value
        End Set
    End Property

    Dim _campoF As Control = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property campoFoco() As Control
        Get
            Return _campoF
        End Get
        Set(ByVal value As Control)
            _campoF = value
        End Set
    End Property

#Region "BUTTON"

    Dim _btnF02 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property btnF02() As fbButtonVisual
        Get
            Return _btnF02
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF02 = value
        End Set
    End Property

    Dim _btnF03 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property btnF03() As fbButtonVisual
        Get
            Return _btnF03
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF03 = value
        End Set
    End Property

    Dim _btnF05 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property btnF05() As fbButtonVisual
        Get
            Return _btnF05
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF05 = value
        End Set
    End Property

    Dim _btnF06 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property btnF06() As fbButtonVisual
        Get
            Return _btnF06
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF06 = value
        End Set
    End Property

    Dim _btnF07 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property btnF07() As fbButtonVisual
        Get
            Return _btnF07
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF07 = value
        End Set
    End Property

    Dim _btnF08 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property btnF08() As fbButtonVisual
        Get
            Return _btnF08
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF08 = value
        End Set
    End Property

    Dim _btnF09 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property btnF09() As fbButtonVisual
        Get
            Return _btnF09
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF09 = value
        End Set
    End Property

    Dim _btnF10 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property btnF10() As fbButtonVisual
        Get
            Return _btnF10
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF10 = value
        End Set
    End Property

    Dim _btnF11 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property btnF11() As fbButtonVisual
        Get
            Return _btnF11
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF11 = value
        End Set
    End Property

    Dim _btnF12 As fbButtonVisual = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property btnF12() As fbButtonVisual
        Get
            Return _btnF12
        End Get
        Set(ByVal value As fbButtonVisual)
            _btnF12 = value
        End Set
    End Property

#End Region

    Dim _MSGSalva As Boolean = True
    <System.ComponentModel.Category("FeedBack")>
    Public Property ativaMSGSalvar() As Boolean
        Get
            Return _MSGSalva
        End Get
        Set(ByVal value As Boolean)
            _MSGSalva = value
        End Set
    End Property

    Dim _MSGFechaTela As Boolean = True
    <System.ComponentModel.Category("FeedBack")>
    Public Property ativaMSGFechaTela() As Boolean
        Get
            Return _MSGFechaTela
        End Get
        Set(ByVal value As Boolean)
            _MSGFechaTela = value
        End Set
    End Property

    Dim _MSGLimpa As Boolean = True
    <System.ComponentModel.Category("FeedBack")>
    Public Property ativaMSGLimpar() As Boolean
        Get
            Return _MSGLimpa
        End Get
        Set(ByVal value As Boolean)
            _MSGLimpa = value
        End Set
    End Property

    Dim _frmPai As frmPadraoSeleciona = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property frmPai() As frmPadraoSeleciona
        Get
            Return _frmPai
        End Get
        Set(ByVal value As frmPadraoSeleciona)
            _frmPai = value
        End Set
    End Property

    Public Overridable Function Salvar(ByVal IDSel As Integer) As Boolean
        Return Validar()
    End Function

    Public Overridable Function Limpar() As Boolean
        setaContexto()
        ID = -1
        fbControlDados.ID = ID
        fbControlDados.Limpar()
        Return False
    End Function

    Public Overridable Function Editar(ByVal IDSel As Integer) As Boolean
        setaContexto()
        ID = IDSel
        fbControlDados.ID = ID
        fbControlDados.Editar()
        Return False
    End Function

    Public Overridable Function Excluir(ByVal IDSel As Integer) As Boolean
        setaContexto()
        ID = IDSel
        fbControlDados.ID = ID
        fbControlDados.Excluir(ID)
        Return False
    End Function

    Public Overridable Function Validar() As Boolean

        Return False
    End Function

    Public Overridable Sub FecharTela()
        ShowDialogs = False
        Me.Close()
    End Sub

    Public Overridable Sub Carrega(Optional ByVal IDParent As Integer = -1)
        setaContexto()
        fbControlDados.Carrega()
    End Sub

    Public Overridable Sub salvandoDados()
        fbControlDados.ID = ID
        fbControlDados.Salvar()
        If Me.fbControlDados.retornoOperacao = True Then
            If Me.ID = -1 AndAlso Me._tipo = clTipoDados.TipoSalvar.MAX_ID Then
                Me.ID = fbControlDados.conDB.MAXID()
                fbControlDados.ID = Me.ID
            ElseIf Me._tipo = clTipoDados.TipoSalvar.FECHA_TELA Then
                FecharTela()
            End If
        End If
    End Sub

    Private Sub fbControlDados_antesdeSalvar(row As DataRow) Handles fbControlDados.antesdeSalvar
        If ID = -1 Then
            If Me.usarIDEmpresa = True Then row.Item("IDEmpresa") = My.Forms.frmPadrao.IDEmpresa
            If Me.campoIDUsuario <> "" Then row.Item(campoIDUsuario) = My.Forms.frmPadrao.IDUsuario
            If Me.campoRelacionamento <> "" Then row.Item(campoRelacionamento) = IDRelacionamento
        End If
    End Sub

    Public Overridable Sub setaContexto()

    End Sub

    Private Sub frmPadraoCadastroDados_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.MdiParent = Nothing
        If _frmPai IsNot Nothing Then
            Dim local As Point = _frmPai.Location
            _frmPai.Visible = True
            _frmPai.Filtrar()
            _frmPai.Location = local
            _frmPai.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub frmPadraoCadastro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.ShowDialogs Then aoIniciarTela()
    End Sub

    Private Sub fbBarra_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F5 Then
            If _btnF05 IsNot Nothing AndAlso _btnF05.Enabled = False Then
            Else
                If _MSGLimpa = True Then
                    If MsgBox("Deseja Limpar os Dados?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Me.Limpar()
                    End If
                Else
                    Me.Limpar()
                End If
            End If
        ElseIf e.KeyCode = Keys.F2 Then
            If _btnF02 IsNot Nothing AndAlso _btnF02.Enabled = False Then
            Else
                If _MSGSalva = True Then
                    If MsgBox("Deseja Salvar os Dados?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        salvandoDados()
                    End If
                Else
                    salvandoDados()
                End If
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            If _MSGFechaTela = True Then
                If MsgBox("Deseja Fechar o Formulário?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    FecharTela()
                End If
            Else
                FecharTela()
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            If _btnF06 IsNot Nothing AndAlso _btnF06.Enabled = False Then
            Else
                funcF6()
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
        ElseIf e.KeyCode = Keys.F3 Then
            If _btnF03 IsNot Nothing AndAlso _btnF03.Enabled = False Then
            Else
                funcF3()
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            If _btnF09 IsNot Nothing AndAlso _btnF09.Enabled = False Then
            Else
                funcF9()
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
                funcF12()
            End If
        ElseIf Not e.Modifiers = Keys.Shift AndAlso e.KeyCode = Keys.F4 Then
            If sender.activecontrol.GetType().Name = "fbLookUp" Then
                sender.activecontrol.abreFormLookUP()
            End If
        ElseIf e.Modifiers = Keys.Shift AndAlso e.KeyCode = Keys.F4 Then
            If sender.activecontrol.GetType().Name = "fbLookUp" Then
                sender.activecontrol.selectID = -1
            End If
        ElseIf _tab IsNot Nothing AndAlso e.Modifiers = Keys.Control AndAlso (e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.D1) Then
            If _tab.TabPages.Count > 0 AndAlso _tab.TabPages(0).Enabled = True Then
                _tab.SelectTab(0)
            End If
        ElseIf _tab IsNot Nothing AndAlso e.Modifiers = Keys.Control AndAlso (e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.D2) Then
            If _tab.TabPages.Count > 1 AndAlso _tab.TabPages(1).Enabled = True Then
                _tab.SelectTab(1)
            End If
        ElseIf _tab IsNot Nothing AndAlso e.Modifiers = Keys.Control AndAlso (e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.D3) Then
            If _tab.TabPages.Count > 2 AndAlso _tab.TabPages(2).Enabled = True Then
                _tab.SelectTab(2)
            End If
        ElseIf _tab IsNot Nothing AndAlso e.Modifiers = Keys.Control AndAlso (e.KeyCode = Keys.NumPad4 Or e.KeyCode = Keys.D4) Then
            If _tab.TabPages.Count > 3 AndAlso _tab.TabPages(3).Enabled = True Then
                _tab.SelectTab(3)
            End If
        ElseIf _tab IsNot Nothing AndAlso e.Modifiers = Keys.Control AndAlso (e.KeyCode = Keys.NumPad5 Or e.KeyCode = Keys.D5) Then
            If _tab.TabPages.Count > 4 AndAlso _tab.TabPages(4).Enabled = True Then
                _tab.SelectTab(4)
            End If
        ElseIf _tab IsNot Nothing AndAlso e.Modifiers = Keys.Control AndAlso (e.KeyCode = Keys.NumPad6 Or e.KeyCode = Keys.D6) Then
            If _tab.TabPages.Count > 5 AndAlso _tab.TabPages(5).Enabled = True Then
                _tab.SelectTab(5)
            End If
        ElseIf _tab IsNot Nothing AndAlso e.Modifiers = Keys.Control AndAlso (e.KeyCode = Keys.NumPad7 Or e.KeyCode = Keys.D7) Then
            If _tab.TabPages.Count > 6 AndAlso _tab.TabPages(6).Enabled = True Then
                _tab.SelectTab(6)
            End If
        ElseIf _tab IsNot Nothing AndAlso e.Modifiers = Keys.Control AndAlso (e.KeyCode = Keys.NumPad8 Or e.KeyCode = Keys.D8) Then
            If _tab.TabPages.Count > 7 AndAlso _tab.TabPages(7).Enabled = True Then
                _tab.SelectTab(7)
            End If
        ElseIf _tab IsNot Nothing AndAlso e.Modifiers = Keys.Control AndAlso (e.KeyCode = Keys.NumPad9 Or e.KeyCode = Keys.D9) Then
            If _tab.TabPages.Count > 8 AndAlso _tab.TabPages(8).Enabled = True Then
                _tab.SelectTab(8)
            End If
        End If
    End Sub

    Public Overridable Sub funcF3()

    End Sub

    Public Overridable Sub funcF6()

    End Sub

    Public Overridable Sub funcF7()

    End Sub

    Public Overridable Sub funcF8()

    End Sub

    Public Overridable Sub funcF9()

    End Sub

    Public Overridable Sub funcF10()

    End Sub

    Public Overridable Sub funcF11()

    End Sub

    Public Overridable Sub funcF12()

    End Sub

    Private Sub frmPadraoCadastroDados_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If _frmPai IsNot Nothing Then _frmPai.Visible = False
        If _campoF IsNot Nothing Then _campoF.Focus()
    End Sub

    Public Overrides Sub aoIniciarTela()
        If _frmPai IsNot Nothing Then _frmPai.Visible = False
        Carrega()
        If ID = -1 Then
            Limpar()
        Else
            Editar(ID)
        End If
        If _campoF IsNot Nothing Then _campoF.Focus()
    End Sub

    Dim _tipo As clTipoDados.TipoSalvar = clTipoDados.TipoSalvar.NADA_A_FAZER
    <System.ComponentModel.Category("FeedBack")>
    Public Property depoisDeSalvar() As clTipoDados.TipoSalvar
        Get
            Return _tipo
        End Get
        Set(ByVal value As clTipoDados.TipoSalvar)
            _tipo = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property usarIDEmpresa() As Boolean

    <System.ComponentModel.Category("FeedBack")>
    Public Property campoRelacionamento() As String

    <System.ComponentModel.Category("FeedBack")>
    Public Property campoIDUsuario() As String

End Class

Public Class clTipoDados
    Public Enum TipoSalvar
        NADA_A_FAZER
        MAX_ID
        FECHA_TELA
    End Enum
End Class
