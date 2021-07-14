Imports System.Text

Public Class frmPesquisaTulha

    Private Sub txtNome_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNome.KeyUp
        If e.KeyCode <> Keys.Escape AndAlso e.KeyCode <> Keys.Enter AndAlso e.KeyCode <> Keys.Down Then
            Dim ssql As String = ""
            If txtNome.Text <> "" Then
                ssql += " AND Nome like '%" + txtNome.Text + "%'"
            End If
            carrega(ssql)
        End If
    End Sub

    Public Overrides Sub carrega(Optional ByVal filtro As String = "")
        MyBase.carrega()
        Dim dt As DataTable
        Dim ssql As New StringBuilder

        ssql.Append("SELECT ")
        ssql.Append(ValID)
        ssql.Append(" ,Nome")
        ssql.Append(" from TB_LOC_QUADRA ")
        ssql.Append(" WHERE IDEMPRESA = ")
        ssql.Append(My.Forms.frmPadrao.IDEmpresa.ToString())
        ssql.Append(" and tipo = 1")
        ssql.Append(filtro)
        ssql.Append(" order by Nome")
        dt = fbConnection.executaSelect(ssql.ToString())
        dgvDados.DataSource = dt
    End Sub

    Public Overrides Sub arrumaGrid()
        MyBase.arrumaGrid()
        dgvDados.Columns("Nome").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Public Overrides Sub seleciona()
        MyBase.seleciona()
        If ID <> -1 Then
            daTaSelect = fbConnection.executaSelect("SELECT * from TB_LOC_QUADRA where ID = " + ID.ToString())
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

    Public Overrides Sub FormatarCelula(sender As Object, e As DataGridViewCellFormattingEventArgs)
        MyBase.FormatarCelula(sender, e)
        If dgvDados IsNot Nothing Then
            If e IsNot Nothing AndAlso (Me.dgvDados.Columns.Item("Nome").Index) = e.ColumnIndex Then
                e.CellStyle.BackColor = Color.SeaGreen
                e.CellStyle.ForeColor = Color.White
            End If
        End If
    End Sub

End Class
