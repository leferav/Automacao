Public Class frmPesquisaCliente
    Private Sub txtCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyUp, txtCodigo.KeyUp
        If e.KeyCode <> Keys.Escape AndAlso e.KeyCode <> Keys.Enter AndAlso e.KeyCode <> Keys.Down Then
            Dim ssql As String = ""

            If txtCodigo.Text <> "" Then
                ssql += " AND C.id = " & txtCodigo.Text
            End If

            If txtCliente.Text <> "" Then
                ssql += " AND C.Nome like '%" + txtCliente.Text + "%'"
            End If
            carrega(ssql)
        End If
    End Sub


    Public Overrides Sub carrega(Optional ByVal filtro As String = "")
        MyBase.carrega()
        Dim dt As DataTable
        Dim ssql As String = "SELECT top (200) C.ID, c.ID AS 'CÓDIGO', C.NOME as 'CLIENTE' "
        ssql += " from TB_CLIENTES C with (nolock)"
        ssql += " WHERE C.ID = C.ID"
        ssql += filtro

        dt = fbConnection.executaSelect(ssql)
        dgvDados.DataSource = dt
    End Sub


    Public Overrides Sub arrumaGrid()
        MyBase.arrumaGrid()
        dgvDados.Columns("ID").Visible = False
        dgvDados.Columns("CÓDIGO").MinimumWidth = 40
        dgvDados.Columns("CLIENTE").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill




    End Sub

    Public Overrides Sub seleciona()
        MyBase.seleciona()
        If ID <> -1 Then
            daTaSelect = fbConnection.executaSelect("SELECT * from TB_CLIENTES WITH (NOLOCK) where ID = " + ID.ToString())
            If daTaSelect IsNot Nothing AndAlso daTaSelect.Rows.Count > 0 Then
                ValVisivel = daTaSelect.Rows(0).Item("NOME")
            End If
            Me.Close()
        End If
    End Sub

    Public Overrides Sub setaValor()
        MyBase.setaValor()
        ValVisivel = dgvDados.CurrentRow.Cells("CLIENTE").Value
    End Sub

    Private Sub frmPesquisaCliente_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
