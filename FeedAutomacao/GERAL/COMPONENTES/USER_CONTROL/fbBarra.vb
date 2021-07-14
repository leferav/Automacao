Imports System.ComponentModel

Public Class fbBarra
    Dim contador As Integer = 0
    Dim frm As frmPadraoCadastro = Nothing
    Dim _panel As fbPanel
    Dim _control As Control
    Friend WithEvents _dados As DataTable


    <System.ComponentModel.Category("FeedBack")> _
    Public Property PanelCadastro() As fbPanel
        Get
            Return _panel
        End Get
        Set(ByVal value As fbPanel)
            _panel = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
   Public Property CampoFoco() As Control
        Get
            Return _control
        End Get
        Set(ByVal value As Control)
            _control = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property frmCadastro() As frmPadraoCadastro
        Get
            Return frm
        End Get
        Set(ByVal value As frmPadraoCadastro)
            frm = value
            If frm IsNot Nothing Then
                frm.Carrega()
            End If
        End Set
    End Property

    Public Sub inicia()
        If PanelCadastro IsNot Nothing Then
            PanelCadastro.Enabled = False
        End If
        If frm IsNot Nothing Then
            Me.btnNovo.Enabled = frm.Permissao.Insere
            Me.btnEdita.Enabled = frm.Permissao.Edita
            Me.btnInicio.Enabled = frm.Permissao.Navega
            Me.btnFim.Enabled = frm.Permissao.Navega
            Me.btnVolta.Enabled = frm.Permissao.Navega
            Me.btnAvanca.Enabled = frm.Permissao.Navega
            Me.btnExclui.Enabled = frm.Permissao.Exclui
        Else
            Me.btnNovo.Enabled = True
            Me.btnExclui.Enabled = True
            Me.btnInicio.Enabled = True
            Me.btnFim.Enabled = True
            Me.btnVolta.Enabled = True
            Me.btnAvanca.Enabled = True
            Me.btnEdita.Enabled = True
        End If
        Me.btnCancela.Enabled = False
        Me.btnSalva.Enabled = False
    End Sub

    Public Sub editar()
        Me.btnSalva.Enabled = True
        Me.btnCancela.Enabled = True
        Me.btnExclui.Enabled = False
        Me.btnNovo.Enabled = False
        Me.btnInicio.Enabled = False
        Me.btnFim.Enabled = False
        Me.btnVolta.Enabled = False
        Me.btnAvanca.Enabled = False
        Me.btnEdita.Enabled = False
        If PanelCadastro IsNot Nothing Then
            PanelCadastro.Enabled = True
        End If
        If Me.CampoFoco IsNot Nothing Then Me.CampoFoco.Focus()
    End Sub

    Private Sub carregaRow()
        If frm.Dados IsNot Nothing AndAlso frm.Dados.Rows.Count > 0 Then
            frm.Editar(frm.Dados.Rows(contador).Item("ID"))
        End If
    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        ePrimeiro()
    End Sub

    Private Sub btnVolta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolta.Click
        eVolta()
    End Sub

    Private Sub btnAvanca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvanca.Click
        eAvanca()
    End Sub

    Private Sub btnFim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFim.Click
        eUltimo()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        eNovo()
    End Sub

    Private Sub btnEdita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdita.Click
        eEditar()
    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        eSalva()
    End Sub

    Public Sub ePrimeiro()
        contador = 0
        carregaRow()
    End Sub

    Public Sub eUltimo()
        If frm.Dados IsNot Nothing AndAlso frm.Dados.Rows.Count > 0 Then
            contador = frm.Dados.Rows.Count - 1
            carregaRow()
        End If
    End Sub

    Public Sub eNovo()
        If btnNovo.Enabled = True Then
            editar()
            frm.Limpar()
        End If
    End Sub

    Public Sub eEditar()
        If frm.ID <> -1 AndAlso btnEdita.Enabled = True Then
            'frm.Editar(frm.ID)
            'frm.Carrega()
            editar()
        Else
            MsgBox("Selecione um Item Para Editar!", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Public Sub eSalva()
        If btnSalva.Enabled = True Then
            If frm.Salvar(frm.ID) = True Then
                inicia()
                frm.Carrega()
                If frm.ID = -1 Then
                    If frm.Dados IsNot Nothing AndAlso frm.Dados.Rows.Count > 0 Then
                        contador = frm.Dados.Rows.Count - 1
                        carregaRow()
                    End If
                Else
                    frm.Editar(frm.ID)
                End If
            End If
        End If
    End Sub

    Public Sub eExclui()
        If MessageBox.Show("Deseja Excluir Este Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            If btnExclui.Enabled = True Then
                If frm.Excluir(frm.ID) = True Then
                    inicia()
                    frm.Carrega()
                    If frm.Dados IsNot Nothing AndAlso frm.Dados.Rows.Count > 0 Then
                        contador = frm.Dados.Rows.Count - 1
                        carregaRow()
                    Else
                        frm.Limpar()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub eCancela()
        If btnCancela.Enabled = True Then
            inicia()
            frm.Limpar()
        End If
    End Sub

    Public Sub eVolta()
        If btnVolta.Enabled = True Then
            If contador > 0 Then
                contador -= 1
            Else
                contador = 0
            End If
            carregaRow()
        End If
    End Sub

    Public Sub eAvanca()
        If btnAvanca.Enabled = True Then
            If frm.Dados IsNot Nothing AndAlso frm.Dados.Rows.Count > 0 Then
                If contador < frm.Dados.Rows.Count - 1 Then
                    contador += 1
                Else
                    contador = frm.Dados.Rows.Count - 1
                End If
                carregaRow()
            End If
        End If
    End Sub

    Private Sub btnExclui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExclui.Click
        eExclui()
    End Sub

    Private Sub btnCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.Click
        eCancela()
    End Sub

    Private Sub fbBarra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        inicia()
    End Sub
End Class
