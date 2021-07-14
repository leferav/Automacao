
Public Class frmMain2
    Public Property CorSistema As Color

    Dim VERSAO As Integer = 1121

    'TESTE MAYCON VSO
    'TESTE MATHEUS
    'teste danilo
    'TESTE THIAGO
    'DAN

#Region "FUNÇÕES"

    Private Function verificaAtualizacao() As Boolean
        If VERSAO < retornaVersaoServer() Then
            Return True
        End If
        Return False
    End Function
    Private Function retornaVersaoServer() As Integer
        Dim ret As Integer = 1
        Dim ssql As String = "SELECT TOP 1 versao FROM TB_ATUALIZACAO"
        Dim dt As DataTable = fbConnection.executaSelect(ssql)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            ret = dt.Rows(0).Item(0)
        End If
        Return ret
    End Function


    Private Sub setaImg()
        Me.BackgroundImage = My.Resources.management_system
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.Update()
    End Sub


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BackColor = My.Settings.Cor
        Me.Hide()
        My.Forms.FrmSplash.ShowDialog()
        My.Forms.frmLoguin.ShowDialog()

        If My.Forms.frmLoguin.logado = True Then
            Me.Show()
            tmsMsg.Start()
            'menuGeral.trataTamanho(True)
            setaImg()
        Else
            Me.Close()
        End If

        BtnDesativado1.Visible = False
        BtnDesativado2.Visible = False
        BtnDesativado3.Visible = False
        BtnRelPortaria.Visible = False
        BtnCadPessoas.Visible = False
        BtnCadPortaria.Visible = False
        BtnCadTAGs.Visible = False
        BtnCadPortaria.Visible = False
        BtnGerPortaria.Visible = False
    End Sub



    Public Sub abreForm(ByVal frm As frmPadrao, Optional ByVal nRestricao As String = "S",
                        Optional ByVal stForm As Integer = 1)
        If frm.IsMdiChild = True Then
            frm.BringToFront()
            Me.ActivateMdiChild(frm)
            If frm.GetType.BaseType.Name = "frmPadraoCadastroDados" Then
                frm.aoIniciarTela()
            ElseIf frm.GetType.BaseType.Name = "frmPadraoSeleciona" Then
                If frm.Visible = False Then frm.Visible = True
            End If
        Else
            If frm.GetType.BaseType.Name = "frmPadraoCadastroDados" Or frm.GetType.BaseType.Name = "frmPadraoCadastroDados2" Then
                frm.aoIniciarTela()
            End If
            frm.MdiParent = Me
            'frm.aoIniciarTela()
            If stForm = 1 AndAlso frm.GetType.BaseType.Name = "frmPadraoCadastro" Then
                frm.LayoutMdi(MdiLayout.TileVertical)
                Me.Cursor = Cursors.Arrow
                frm.StartPosition = FormStartPosition.Manual
                Dim MAXpOS As Integer = 0
                For Each F As Form In Me.MdiChildren
                    If MAXpOS < F.Location.Y Then MAXpOS = F.Location.Y
                Next
                If Me.MdiChildren.Length > 1 Then MAXpOS += 20
                frm.Location = New Point(0, MAXpOS)
                'frm.Show()
            End If
        End If
        frm.Show()
        'frm.StartPosition = FormStartPosition.CenterScreen
        If stForm = 0 Then
            'frm.Show()
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.WindowState = FormWindowState.Normal
        ElseIf stForm = 1 Then
            'frm.Show()
            frm.WindowState = FormWindowState.Normal
            'frm.StartPosition = FormStartPosition.CenterScreen
        ElseIf stForm = 2 Then
            frm.WindowState = FormWindowState.Maximized
            ' frm.Show()
        End If
        GC.Collect()
        Me.Update()
    End Sub
    Private Sub setaControle(controle As Control)
        Dim pp As clPermissao
        Dim obj As fbMenuStrip
        For Each c As Control In controle.Controls
            If c.GetType.Name = "fbMenuStrip" Then
                obj = DirectCast(c, fbMenuStrip)
                For Each c1 In obj.Items
                    If c1.GetType.Name = "ToolStripMenuItem" Then
                        '   If c1.Name = "ToolStripMenuItem186" Then MsgBox("aa")
                        pp = My.Forms.frmPadrao.listPermissao.Find(Function(p As clPermissao) p.Objeto = c1.Name)
                        If pp IsNot Nothing Then
                            c1.Enabled = pp.Menu
                        Else
                            percorreItens(c1)
                        End If
                    End If
                Next
            Else
                setaControle(c)
            End If
        Next
    End Sub

    Private Sub percorreItens(it As ToolStripMenuItem)
        Dim pp As clPermissao
        For Each c1 In it.DropDownItems
            If c1.GetType.Name = "ToolStripMenuItem" Then
                ' If c1.Name = "ToolStripMenuItem186" Then MsgBox("aa")
                pp = My.Forms.frmPadrao.listPermissao.Find(Function(p As clPermissao) p.Objeto = c1.Name)
                If pp IsNot Nothing Then
                    c1.Enabled = pp.Menu
                Else
                    percorreItens(c1)
                End If
            End If
        Next
    End Sub

    Private Sub AcessoToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        abreForm(My.Forms.frmCadastroTipoAcesso, "S", 1)
    End Sub

    Private Sub SolicitaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        abreForm(My.Forms.frmRelControleAcesso, "s", 2)
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        abreForm(My.Forms.frmRelClientes, "s", 2)
    End Sub

    Private Sub AtendentesToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        clGeral.imprimeAtendentes()
    End Sub


#End Region

    Dim IDPedido As Integer = -1
    'Private Sub ntfLeitor_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
    '    If IDPedido <> -1 Then
    '        Dim pd As New frmCadastroDepedidos
    '        pd.Editar(IDPedido)
    '        pd.Show()
    '        pd.WindowState = FormWindowState.Normal
    '        pd.BringToFront()
    '    End If
    'End Sub

    Dim counter As Int16 = 0

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        abreForm(My.Forms.frmUsuario, "s", 1)
    End Sub

    Private Sub TelaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        abreForm(My.Forms.frmCadastroTelaReferencia, "s", 1)
    End Sub

    Private Sub ConfigDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        abreForm(My.Forms.frmGerenciaDeConfiguracoes, "s", 1)
    End Sub

    Private Sub RelatórioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        abreForm(My.Forms.frmGerenciaDeRelatorios, "s", 2)
    End Sub

    Private Sub CorDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ColorDialog1.ShowDialog()
        CorSistema = ColorDialog1.Color
        Me.BackColor = CorSistema
        My.Settings.Cor = CorSistema
    End Sub

    Private Sub BtnCadastros_Click(sender As Object, e As EventArgs) Handles BtnCadastros.Click
        If BtnCadPessoas.Visible = True Then
            BtnCadPessoas.Visible = False
        Else
            BtnCadPessoas.Visible = True
        End If

        If BtnCadTAGs.Visible = True Then
            BtnCadTAGs.Visible = False
        Else
            BtnCadTAGs.Visible = True
        End If
    End Sub

    Private Sub BtnPortaria_Click(sender As Object, e As EventArgs) Handles BtnPortaria.Click
        If BtnCadPortaria.Visible = True Then
            BtnCadPortaria.Visible = False
        Else
            BtnCadPortaria.Visible = True
        End If

        If BtnGerPortaria.Visible = True Then
            BtnGerPortaria.Visible = False
        Else
            BtnGerPortaria.Visible = True
        End If

        If BtnRelPortaria.Visible = True Then
            BtnRelPortaria.Visible = False
        Else
            BtnRelPortaria.Visible = True
        End If
    End Sub

    Private Sub BtnAutomacao_Click(sender As Object, e As EventArgs) Handles BtnAutomacao.Click
        abreForm(My.Forms.frmAutomacao, "s", 2)
    End Sub

    Private Sub BtnCadPessoas_Click(sender As Object, e As EventArgs) Handles BtnCadPessoas.Click
        abreForm(My.Forms.frmPessoa, "s", 1)
    End Sub

    Private Sub BtnCadTAGs_Click(sender As Object, e As EventArgs) Handles BtnCadTAGs.Click
        abreForm(My.Forms.frmCadastroTAGs, "s", 2)
    End Sub

    Private Sub BtnConfigurações_Click(sender As Object, e As EventArgs) Handles BtnConfigurações.Click
        abreForm(My.Forms.frmConfiguracoes, "s", 1)
    End Sub

    Private Sub BtnCadPortaria_Click(sender As Object, e As EventArgs) Handles BtnCadPortaria.Click
        abreForm(My.Forms.frmCadastroPortaria, "s", 1)
    End Sub

    Private Sub BtnGerPortaria_Click(sender As Object, e As EventArgs) Handles BtnGerPortaria.Click
        abreForm(My.Forms.frmGerenciaPortaria, "s", 1)
    End Sub

    Private Sub BtnRelPortaria_Click(sender As Object, e As EventArgs) Handles BtnRelPortaria.Click

    End Sub
End Class
