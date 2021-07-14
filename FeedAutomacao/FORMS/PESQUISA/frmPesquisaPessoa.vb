Public Class frmPesquisaPessoa

    '0 = Todos, 1 = Representante
    Public TipoPesquisa As Integer = 0

    Private Sub txtNome_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNome.KeyUp,
        txtCGC.KeyUp, txtCodigo.KeyUp, txtFant.KeyUp
        If e.KeyCode <> Keys.Escape AndAlso e.KeyCode <> Keys.Enter AndAlso e.KeyCode <> Keys.Down Then
            carrega(Filtro_Pesquisa())
        End If
    End Sub

    Private Function Filtro_Pesquisa() As String
        Dim ssql As String = ""
        Dim _cnpj As String = Trim(txtCGC.Text.Replace(".", "").Replace("-", "").Replace("/", ""))

        If txtNome.Text <> "" Then
            ssql += " AND Nome like '%" + txtNome.Text + "%'"
        End If
        If _cnpj <> "" Then
            ssql += " AND CGC like '%" + _cnpj + "%'"
        End If
        If cbbTipoPessoa.ValorSelecionado <> -1 Then
            ssql += " AND IDTIPOPESSOA = " + cbbTipoPessoa.ValorSelecionado.ToString()
        End If
        If txtCodigo.Text <> "" Then
            ssql += " AND Codigo LIKE '%" + txtCodigo.Text + "%'"
        End If

        If txtCodigo.Text <> "" Then
            ssql += " AND p.Apelido LIKE '%" + txtFant.Text + "%'"
        End If

        If TipoPesquisa = 1 Then
            ssql += " AND IDTipoPessoa in (select id from TB_TIPO_PESSOA where nome in ('Funcionário', 'Geral') )"
        End If

        Return ssql
    End Function

    Public Function setaWhere(ByVal _filtro As String, Optional ByVal semWhere As Boolean = True) As String
        Dim ret As String = ""
        If Not _filtro.Contains("WHERE") Then
            ret = " WHERE "
        Else
            ret = " AND "
        End If
        Return ret
    End Function

    Public Overrides Sub carrega(Optional ByVal filtro As String = "")
        MyBase.carrega()
        Dim dt As DataTable
        Dim ssql As String

        ssql = "SELECT top 200 p." + ValID

        ssql += " , p.Nome, p.Codigo AS 'Código', p.cgc as 'CNPJ/CPF', (select Nome from tb_tipo_pessoa where id = p.IdTipoPessoa) as Grupo"
        ssql += ",p.Apelido as Fantasia FROM TB_PESSOA p WITH (NOLOCK) WHERE ID = ID "

        If cbInativo.Visible AndAlso cbInativo.Checked Then
            ssql += " AND ATIVO = 0"
        Else
            ssql += " AND ATIVO = 1"
        End If

        'ssql += filtro + Filtro_Pesquisa() + Condicao + Filtro_Pesquisa()
        ssql += Filtro_Pesquisa() + Condicao

        If txtNome.Focused Then
            ssql += " ORDER BY Nome"
        ElseIf txtCGC.Focused Then
            ssql += " ORDER BY 'CNPJ/CPF'"
        Else
            ssql += " ORDER BY 'Fantasia',Nome"
        End If

        dt = fbConnection.executaSelect(ssql)
        dgvDados.DataSource = dt

    End Sub

    Public Overrides Sub arrumaGrid()
        MyBase.arrumaGrid()
        dgvDados.Columns("Nome").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvDados.Columns("Grupo").Width = 130
        dgvDados.Columns("Código").Width = 70
        dgvDados.Columns("CNPJ/CPF").Width = 105
        dgvDados.Columns("Fantasia").Width = 110
    End Sub

    Public Overrides Sub seleciona()
        MyBase.seleciona()
        If ID <> -1 Then
            daTaSelect = fbConnection.executaSelect("SELECT * from TB_PESSOA where ID = " + ID.ToString())
            If daTaSelect IsNot Nothing AndAlso daTaSelect.Rows.Count > 0 Then
                ValVisivel = daTaSelect.Rows(0).Item("Nome")
            End If
            Me.Close()
        End If
    End Sub

    Public Overrides Sub setaValor()
        MyBase.setaValor()
        ValVisivel = dgvDados.CurrentRow.Cells("Nome").Value
    End Sub

    Private Sub frmPesquisaPessoa_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            cbInativo.Hide()
            cbInativo.Visible = False
        End If
    End Sub

    Private Sub frmPesquisaPessoa_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtCGC.Clear()
        txtCodigo.Clear()
        txtNome.Clear()
        cbbTipoPessoa.ValorSelecionado = -1
        cbInativo.Checked = False
        txtFant.Clear()
        If Me.Condicao = "" Then
            cbbTipoPessoa.Enabled = True
        Else
            cbbTipoPessoa.Enabled = False
        End If
    End Sub

    'Private Sub frmPesquisaPessoa_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
    '    cbbTipoPessoa.ValorSelecionado = -1
    'End Sub

    Private Sub cbInativo_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbInativo.CheckedChanged
        If cbInativo.Visible Then
            carrega()
        End If
    End Sub

    'Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
    '    cbInativo.Hide()
    '    cbInativo.Visible = False
    'End Sub

    Private Sub cbbTipoPessoa_Selecionando() Handles cbbTipoPessoa.Selecionando
        carrega()
    End Sub

    Private Sub frmPesquisaPessoa_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            cbInativo.Hide()
            cbInativo.Visible = False
            Me.Condicao = ""
        End If
    End Sub

End Class
