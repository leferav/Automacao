Public Class frmPadraoCadastro

    Dim _ID As Integer = -1
    Dim _dados As New DataTable
    Dim _tab As fbTabPage = Nothing

    <System.ComponentModel.Category("FeedBack")> _
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property tabDados() As fbTabPage
        Get
            Return _tab
        End Get
        Set(ByVal value As fbTabPage)
            _tab = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property abreNovo As Boolean = False

    <System.ComponentModel.Category("FeedBack")> _
    Public Property Dados() As DataTable
        Get
            Return _dados
        End Get
        Set(ByVal value As DataTable)
            _dados = value
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

    Public Overridable Function Salvar(ByVal IDSel As Integer) As Boolean
        Return Validar()
    End Function

    Public Overridable Function Limpar() As Boolean
        ID = -1
        If pesDados.SelectID <> -1 Then pesDados.SelectID = -1
        Me.LimparControles(Me.pnlCampos)
        Return False
    End Function

    Public Sub LimparControles(ByVal ctrlParent As Control)
        LimpaControles(ctrlParent)
        If _campoF IsNot Nothing Then _campoF.Focus()
    End Sub
    Public Sub LimpaControles(ByVal ctrlParent As Control)
        Dim ctrl As Control
        For Each ctrl In ctrlParent.Controls
            'Try
            '    CType(ctrl, Object).DB.Limpar()
            'Catch ex As Exception
            'End Try

            If TypeOf ctrl Is fbTextBox Then
                CType(ctrl, fbTextBox).Text = ""

            ElseIf TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = ""

            ElseIf TypeOf ctrl Is fbMaskBox Then
                CType(ctrl, fbMaskBox).Text = ""

            ElseIf TypeOf ctrl Is MaskedTextBox Then
                CType(ctrl, MaskedTextBox).Text = ""

            ElseIf TypeOf ctrl Is fbNumericBox Then
                CType(ctrl, fbNumericBox).Text = 0

            ElseIf TypeOf ctrl Is fbComboBox Then
                CType(ctrl, fbComboBox).ValorSelecionado = -1

            ElseIf TypeOf ctrl Is fbData Then
                CType(ctrl, fbData).Value = Date.Now

            ElseIf TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Value = Date.Now

            ElseIf TypeOf ctrl Is fbDate Then
                CType(ctrl, fbDate).Value = Date.Now

            ElseIf TypeOf ctrl Is fbNumericUP Then
                CType(ctrl, fbNumericUP).Value = 0

            ElseIf TypeOf ctrl Is fbCheckBox Then
                CType(ctrl, fbCheckBox).Checked = False

            ElseIf TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False

            ElseIf TypeOf ctrl Is fbPicturebox Then
                CType(ctrl, fbPicturebox).Image = Nothing

            ElseIf TypeOf ctrl Is PictureBox Then
                CType(ctrl, PictureBox).Image = Nothing

            ElseIf TypeOf ctrl Is fbNumericBox_v2 Then
                CType(ctrl, fbNumericBox_v2).Text = "0"

            ElseIf TypeOf ctrl Is NumericUpDown Then
                CType(ctrl, NumericUpDown).Value = 0

            ElseIf TypeOf ctrl Is fbLookUp Then
                CType(ctrl, fbLookUp).SelectID = -1

                'ElseIf TypeOf ctrl Is fbLookUpTreeView Then
                '    CType(ctrl, fbLookUpTreeView).SelectID = -1

            End If
            If ctrl.HasChildren Then
                LimpaControles(ctrl)
            End If
        Next
    End Sub

    Public Overridable Function Editar(ByVal IDSel As Integer) As Boolean
        If _campoF IsNot Nothing Then _campoF.Focus()
        Return False
    End Function

    Public Overridable Function Excluir(ByVal IDSel As Integer) As Boolean

        Return False
    End Function

    Public Overridable Function Validar() As Boolean
        erro = True
        Return ValidarObrigatorio(Me.pnlCampos)
    End Function

    Dim erro As Boolean = True
    Private Function ValidarObrigatorio(ByVal controle As Control) As Boolean
        For Each ctrl As Control In controle.Controls.OfType(Of Control).OrderBy(Function(b) b.TabIndex)
            If TypeOf ctrl Is fbLabel = False AndAlso TypeOf ctrl Is Label = False Then
                If TypeOf ctrl Is fbTextBox Then
                    Dim c As fbTextBox = CType(ctrl, fbTextBox)
                    If c.Requerido AndAlso c.Text = "" Then
                        msgValida(c.NomeCampoMsg, c)
                        erro = False
                        Exit For
                    End If
                ElseIf TypeOf ctrl Is fbMaskBox Then
                    Dim c As fbMaskBox = CType(ctrl, fbMaskBox)
                    If c.Requerido AndAlso c.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace("(", "").Replace(")", "") = "" Then
                        msgValida(c.NomeCampoMsg, c)
                        erro = False
                        Exit For
                    End If
                ElseIf TypeOf ctrl Is fbNumericBox Then
                    Dim c As fbNumericBox = CType(ctrl, fbNumericBox)
                    If c.Requerido AndAlso c.Text = 0 Then
                        msgValida(c.NomeCampoMsg, c)
                        erro = False
                        Exit For
                    End If
                ElseIf TypeOf ctrl Is fbComboBox Then
                    Dim c As fbComboBox = CType(ctrl, fbComboBox)
                    If c.Requerido AndAlso c.ValorSelecionado = -1 Then
                        msgValida(c.NomeCampoMsg, c)
                        erro = False
                        Exit For
                    End If
                ElseIf TypeOf ctrl Is fbNumericBox_v2 Then
                    Dim c As fbNumericBox_v2 = CType(ctrl, fbNumericBox_v2)
                    If c.Requerido AndAlso c.Text = 0 Then
                        msgValida(c.NomeCampoMsg, c)
                        erro = False
                        Exit For
                    End If
                ElseIf TypeOf ctrl Is fbLookUp Then
                    Dim c As fbLookUp = CType(ctrl, fbLookUp)
                    If c.Requerido AndAlso c.SelectID = -1 Then
                        msgValida(c.NomeCampoMsg, c)
                        erro = False
                        Exit For
                    End If
                ElseIf TypeOf ctrl Is fbLookUpTreeView Then
                    Dim c As fbLookUpTreeView = CType(ctrl, fbLookUpTreeView)
                    'If c.Requerido AndAlso c.SelectID = -1 Then
                    '    msgValida(c.NomeCampoMsg, c)
                    erro = False
                        Exit For
                    'End If
                ElseIf TypeOf ctrl Is fbData Then
                    Dim c As fbData = CType(ctrl, fbData)
                    If c.Requerido AndAlso c.Checked = False Then
                        msgValida(c.NomeCampoMsg, c)
                        erro = False
                        Exit For
                    End If
                ElseIf TypeOf ctrl Is fbNumericUP Then
                    Dim c As fbNumericUP = CType(ctrl, fbNumericUP)
                    If c.Requerido AndAlso c.Value = 0 Then
                        msgValida(c.NomeCampoMsg, c)
                        erro = False
                        Exit For
                    End If
                    'ElseIf TypeOf ctrl Is fbTabPage Then
                    '    For Each ct As Control In DirectCast(ctrl, fbTabPage).Controls.OfType(Of Control).OrderBy(Function(b) b.TabIndex)
                    '        For Each ct2 As Control In ct.Controls.OfType(Of Control).OrderBy(Function(b) b.TabIndex)
                    '            If TypeOf ct2 Is fbTextBox Then
                    '                Dim c As fbTextBox = CType(ct2, fbTextBox)
                    '                If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                    DirectCast(ctrl, fbTabPage).SelectedTab = ct
                    '                    Return False
                    '                End If
                    '            ElseIf TypeOf ct2 Is fbMaskBox Then
                    '                Dim c As fbMaskBox = CType(ct2, fbMaskBox)
                    '                If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                    DirectCast(ctrl, fbTabPage).SelectedTab = ct
                    '                    Return False
                    '                End If
                    '            ElseIf TypeOf ct2 Is fbNumericBox Then
                    '                Dim c As fbNumericBox = CType(ct2, fbNumericBox)
                    '                If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                    DirectCast(ctrl, fbTabPage).SelectedTab = ct
                    '                    Return False
                    '                End If
                    '            ElseIf TypeOf ct2 Is fbComboBox Then
                    '                Dim c As fbComboBox = CType(ct2, fbComboBox)
                    '                If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                    DirectCast(ctrl, fbTabPage).SelectedTab = ct
                    '                    Return False
                    '                End If
                    '            ElseIf TypeOf ct2 Is fbNumericBox_v2 Then
                    '                Dim c As fbNumericBox_v2 = CType(ct2, fbNumericBox_v2)
                    '                If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                    DirectCast(ctrl, fbTabPage).SelectedTab = ct
                    '                    Return False
                    '                End If
                    '            ElseIf TypeOf ct2 Is fbLookUp Then
                    '                Dim c As fbLookUp = CType(ct2, fbLookUp)
                    '                If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                    DirectCast(ctrl, fbTabPage).SelectedTab = ct
                    '                    Return False
                    '                End If
                    '            ElseIf TypeOf ct2 Is fbLookUpTreeView Then
                    '                Dim c As fbLookUpTreeView = CType(ct2, fbLookUpTreeView)
                    '                If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                    DirectCast(ctrl, fbTabPage).SelectedTab = ct
                    '                    Return False
                    '                End If
                    '            ElseIf TypeOf ct2 Is fbData Then
                    '                Dim c As fbData = CType(ct2, fbData)
                    '                If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                    DirectCast(ctrl, fbTabPage).SelectedTab = ct
                    '                    Return False
                    '                End If
                    '            ElseIf TypeOf ct2 Is fbNumericUP Then
                    '                Dim c As fbNumericUP = CType(ct2, fbNumericUP)
                    '                If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                    DirectCast(ctrl, fbTabPage).SelectedTab = ct
                    '                    Return False
                    '                End If
                    '            End If
                    '        Next
                    '        If ct.HasChildren Then
                    '            If ValidarObrigatorio(ct) = False Then Return False
                    '        End If
                    '    Next
                    'ElseIf TypeOf ctrl Is fbGroupBox OrElse TypeOf ctrl Is fbRadioGroupBox Then
                    '    For Each ct2 As Control In ctrl.Controls.OfType(Of Control).OrderBy(Function(b) b.TabIndex)
                    '        If TypeOf ct2 Is fbTextBox Then
                    '            Dim c As fbTextBox = CType(ct2, fbTextBox)
                    '            If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                Return False
                    '            End If
                    '        ElseIf TypeOf ct2 Is fbMaskBox Then
                    '            Dim c As fbMaskBox = CType(ct2, fbMaskBox)
                    '            If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                Return False
                    '            End If
                    '        ElseIf TypeOf ct2 Is fbNumericBox Then
                    '            Dim c As fbNumericBox = CType(ct2, fbNumericBox)
                    '            If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                Return False
                    '            End If
                    '        ElseIf TypeOf ct2 Is fbComboBox Then
                    '            Dim c As fbComboBox = CType(ct2, fbComboBox)
                    '            If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                Return False
                    '            End If
                    '        ElseIf TypeOf ct2 Is fbNumericBox_v2 Then
                    '            Dim c As fbNumericBox_v2 = CType(ct2, fbNumericBox_v2)
                    '            If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                Return False
                    '            End If
                    '        ElseIf TypeOf ct2 Is fbLookUp Then
                    '            Dim c As fbLookUp = CType(ct2, fbLookUp)
                    '            If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                Return False
                    '            End If
                    '        ElseIf TypeOf ct2 Is fbLookUpTreeView Then
                    '            Dim c As fbLookUpTreeView = CType(ct2, fbLookUpTreeView)
                    '            If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                Return False
                    '            End If
                    '        ElseIf TypeOf ct2 Is fbData Then
                    '            Dim c As fbData = CType(ct2, fbData)
                    '            If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                Return False
                    '            End If
                    '        ElseIf TypeOf ct2 Is fbNumericUP Then
                    '            Dim c As fbNumericUP = CType(ct2, fbNumericUP)
                    '            If c.Requerido AndAlso c.DB.ValidaVazio(c.NomeCampoMsg) = False Then
                    '                Return False
                    '            End If
                    '        End If
                    '    Next
                    '    If ctrl.HasChildren Then
                    '        If ValidarObrigatorio(ctrl) = False Then Return False
                    '    End If
                End If
            End If
            If ctrl.HasChildren AndAlso erro Then
                ValidarObrigatorio(ctrl)
            End If
        Next
        Return erro
    End Function

    Public Overridable Sub Carrega(Optional ByVal IDParent As Integer = -1)

    End Sub

    Private Sub frmPadraoCadastro_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmPadraoCadastro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FbBarra1.frmCadastro = Me
        menuFiltro.trataTamanho(True)
        If abreNovo = True Then FbBarra1.eNovo()
    End Sub

    Private Sub pesDados_Selecionando() Handles pesDados.Selecionando
        If pesDados.SelectID = -1 Then
            Me.Limpar()
        Else
            Me.Editar(pesDados.SelectID)
        End If
    End Sub

    Public Overridable Sub FecharTela()
        Me.Close()
    End Sub

    Private Sub fbBarra_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.FbBarra1.eNovo()
        ElseIf Not e.Modifiers = Keys.Shift AndAlso e.KeyCode = Keys.F2 Then
            Me.FbBarra1.eSalva()
        ElseIf e.Modifiers = Keys.Shift AndAlso e.KeyCode = Keys.F2 Then
            Me.FbBarra1.eExclui()
        ElseIf e.KeyCode = Keys.Escape AndAlso FbBarra1.btnCancela.Enabled Then
            Me.FbBarra1.eCancela()
        ElseIf e.KeyCode = Keys.Escape AndAlso Not FbBarra1.btnCancela.Enabled Then
            If MessageBox.Show("Deseja Fechar o Formulário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                FecharTela()
            End If
        ElseIf e.KeyCode = Keys.F7 Then
            Me.FbBarra1.eVolta()
        ElseIf e.KeyCode = Keys.F8 Then
            Me.FbBarra1.eAvanca()
        ElseIf e.KeyCode = Keys.F6 Then
            Me.FbBarra1.eEditar()
        ElseIf e.KeyCode = Keys.Home AndAlso Me.FbBarra1.btnCancela.Enabled = False Then
            Me.FbBarra1.ePrimeiro()
        ElseIf e.KeyCode = Keys.End AndAlso Me.FbBarra1.btnCancela.Enabled = False Then
            Me.FbBarra1.eUltimo()
        ElseIf e.KeyCode = Keys.F9 Then
            PesquisaF9()
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

    Private Sub PesquisaF9()
        If menuFiltro.Height = 25 Then
            menuFiltro.trataTamanho(False, True)
            pesDados.abreFormLookUP()
        Else
            menuFiltro.trataTamanho(True, False)
        End If
    End Sub

    'Private Sub frmPadraoCadastro_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    '    If Me.WindowState <> FormWindowState.Normal Then
    '        Me.WindowState = FormWindowState.Normal
    '    End If
    'End Sub

End Class
