Public Class frmPesquisaAtendentes
    Private Sub txtCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNome.KeyUp, txtCodigo.KeyUp
        If e.KeyCode <> Keys.Escape AndAlso e.KeyCode <> Keys.Enter AndAlso e.KeyCode <> Keys.Down Then
            Dim ssql As String = ""

            If txtCodigo.Text <> "" Then
                ssql += " AND A.id = " & txtCodigo.Text
            End If

            If txtNome.Text <> "" Then
                ssql += " AND A.Nome like '%" + txtNome.Text + "%'"
            End If
            carrega(ssql)
        End If
    End Sub


    Public Overrides Sub carrega(Optional ByVal filtro As String = "")
        MyBase.carrega()
        Dim dt As DataTable
        Dim ssql As String = "SELECT top (200) A.ID, A.ID AS 'CÓDIGO', A.NOME as 'ATENDENTE' "
        ssql += " from TB_ATENDENTES A with (nolock)"
        ssql += " WHERE A.ID = A.ID"
        ssql += filtro

        dt = fbConnection.executaSelect(ssql)
        dgvDados.DataSource = dt
    End Sub


    Public Overrides Sub arrumaGrid()
        MyBase.arrumaGrid()
        dgvDados.Columns("ID").Visible = False
        dgvDados.Columns("CÓDIGO").MinimumWidth = 40
        dgvDados.Columns("ATENDENTE").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill



    End Sub

    Public Overrides Sub seleciona()
        MyBase.seleciona()
        If ID <> -1 Then
            daTaSelect = fbConnection.executaSelect("SELECT * from TB_TIPO_ACESSO WITH (NOLOCK) where ID = " + ID.ToString())
            If daTaSelect IsNot Nothing AndAlso daTaSelect.Rows.Count > 0 Then
                ValVisivel = daTaSelect.Rows(0).Item("NOME")
            End If
            Me.Close()
        End If
    End Sub

    Public Overrides Sub setaValor()
        MyBase.setaValor()
        ValVisivel = dgvDados.CurrentRow.Cells("ATENDENTE").Value
    End Sub




End Class
