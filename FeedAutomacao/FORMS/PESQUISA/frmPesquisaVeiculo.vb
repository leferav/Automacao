Public Class frmPesquisaVeiculo

    Private Sub txtNome_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNome.KeyUp, txtPLaca.KeyUp
        If e.KeyCode <> Keys.Escape AndAlso e.KeyCode <> Keys.Enter AndAlso e.KeyCode <> Keys.Down Then
            Dim ssql As String = ""
            Dim _placa As String = Trim(txtPLaca.Text.Replace("-", "").Replace("/", "").Replace(" ", ""))
           If txtNome.Text <> "" Then
                ssql += " AND Nome like '%" + txtNome.Text + "%'"
            End If
            If _placa <> "" Then
                ssql += " AND placa like '%" + _placa + "%'"
            End If
            carrega(ssql)
        End If
    End Sub

    Private Function setaWHERE2(ByVal sql As String) As String
        Dim srt As String = " WHERE "
        If sql.Contains("WHERE") Then
            srt = " AND "
        End If
        Return srt
    End Function

    Public Overrides Sub carrega(Optional ByVal filtro As String = "")
        MyBase.carrega()
        Dim dt As DataTable
        Dim ssql As String = "SELECT " + ValID
        ssql += " , Placa, Nome"
        ssql += " FROM TB_VEICULO v WITH (NOLOCK) WHERE ID > 0 "
        ssql += filtro
        ssql += Condicao
        If txtNome.Focused Then
            ssql += " ORDER BY Nome"
        Else
            ssql += " ORDER BY Placa"
        End If
        dt = fbConnection.executaSelect(ssql)
        dgvDados.DataSource = dt
    End Sub

    Public Overrides Sub arrumaGrid()
        MyBase.arrumaGrid()
        dgvDados.Columns("Nome").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvDados.Columns("Placa").Width = 150
    End Sub

    Public Overrides Sub seleciona()
        MyBase.seleciona()
        If ID <> -1 Then
            daTaSelect = fbConnection.executaSelect("SELECT * from TB_VEICULO WITH (NOLOCK) where ID = " + ID.ToString())
            If daTaSelect IsNot Nothing AndAlso daTaSelect.Rows.Count > 0 Then
                ValVisivel = daTaSelect.Rows(0).Item("Placa")
            End If
            Me.Close()
        End If
    End Sub

    Public Overrides Sub setaValor()
        MyBase.setaValor()
        ValVisivel = dgvDados.CurrentRow.Cells("Placa").Value
    End Sub

End Class
