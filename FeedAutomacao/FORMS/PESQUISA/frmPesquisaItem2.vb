Public Class frmPesquisaItem2

    Private Sub txtNome_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNome.KeyUp, txtCodServ.KeyUp
        If e.KeyCode <> Keys.Escape AndAlso e.KeyCode <> Keys.Enter AndAlso e.KeyCode <> Keys.Down Then
            Dim ssql As String = ""
            If txtCodServ.Text <> "" Then
                ssql += " AND Codigo like '%" + txtCodServ.Text + "%'"
            End If
            If txtNome.Text <> "" Then
                ssql += " AND Nome like '%" + txtNome.Text + "%'"
            End If
            carrega(ssql)
        End If
    End Sub
   
    Public Overrides Sub carrega(Optional ByVal filtro As String = "")
        MyBase.carrega()
        Dim dt As DataTable
        Dim ssql As String = "SELECT top 200 " + ValID
        ssql += ", Codigo as 'Cód. Serv.',NOME, Case Tipo When 'P' THEN 'PRODUTO' When 'S' THEN 'SERVIÇO' END As TIPO"
        ssql += " from TB_ITEM i with (nolock) WHERE i.Ativo = 1"
        'ssql += " WHERE IDEmpresa  = " + My.Forms.frmPadrao.IDEmpresa.ToString()
        ssql += filtro + Condicao
        If gbTipo.Visible Then
            If rbProduto.Checked Then
                ssql += " AND i.TIPO = 'P'"
            Else
                ssql += " AND i.TIPO = 'S'"
            End If
        End If
        ssql += " order by i.Nome"
        dt = fbConnection.executaSelect(ssql)
        dgvDados.DataSource = dt
    End Sub

    Public Overrides Sub arrumaGrid()
        MyBase.arrumaGrid()
        dgvDados.Columns("Nome").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Public Overrides Sub seleciona()
        MyBase.seleciona()
        If ID <> -1 Then
            daTaSelect = fbConnection.executaSelect("SELECT * from TB_ITEM with (nolock) where ID = " + ID.ToString())
            If daTaSelect IsNot Nothing AndAlso daTaSelect.Rows.Count > 0 Then
                ValVisivel = daTaSelect.Rows(0).Item("Nome")
            End If
            Me.Hide()
        End If
    End Sub

    Public Overrides Sub setaValor()
        MyBase.setaValor()
        ValVisivel = dgvDados.CurrentRow.Cells("Nome").Value
    End Sub

    Private Sub frmPesquisaItem2_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Condicao <> "" Then
            gbTipo.Visible = False
        Else '
            gbTipo.Visible = True
        End If
    End Sub

End Class
