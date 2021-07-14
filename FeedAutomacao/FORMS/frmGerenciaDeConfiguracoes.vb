Public Class frmGerenciaDeConfiguracoes

    Dim IDsel As Integer = -1

    Public Overrides Sub Filtrar(Optional ByVal filtra As Boolean = True)
        Me.Cursor = Cursors.WaitCursor
        Dim filtro As String = ""

        If txtNome.Text <> "" Then
            filtro += " AND MC.NOME LIKE '%" & txtNome.Text & "%'"
        End If

        If txtDescricao.Text <> "" Then
            filtro += " AND MC.DESCRICAO LIKE '%" & txtDescricao.Text & "%'"
        End If

        Dim ssql As String = ""


        ssql += " Select MC.ID, MC.TABELA, MC.NOME, MC.TIPODADOS AS 'TIPO', MC.TAMANHO AS 'TAM', MC.DECIMAL AS 'DEC', MC.DESCRICAO AS 'DESCRIÇÃO' "
        ssql += " FROM TB_MAP_CONF MC"
        ssql += " WHERE MC.TABELA <> '' "
        ssql += filtro
        ssql += " ORDER BY MC.NOME"


        Dim dt = fbConnection.executaSelect(ssql)
        dgvDados.DataSource = dt
        Me.Cursor = Cursors.Arrow
    End Sub

    Public Overrides Sub setaDts()
        MyBase.setaDts()

        If dgvDados.ColumnCount > 1 Then
            dgvDados.Columns("ID").Width = 50
            dgvDados.Columns("ID").Visible = False
            dgvDados.Columns("TABELA").Width = 50
            dgvDados.Columns("TABELA").Visible = False
            dgvDados.Columns("NOME").Width = 200
            dgvDados.Columns("TIPO").Width = 80
            dgvDados.Columns("TAM").Width = 50
            dgvDados.Columns("DEC").Width = 50
            dgvDados.Columns("DESCRIÇÃO").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If

        For Each R As DataGridViewRow In dgvDados.Rows
            Select Case R.Cells("DESCRIÇÃO").Value
                Case Is = ""
                    R.DefaultCellStyle.BackColor = Color.Red
                    R.DefaultCellStyle.ForeColor = Color.Gold
            End Select
        Next

    End Sub

    Public Overrides Function EditarF6(ByVal IDSel As Integer) As Boolean
        If IDSel <> -1 Then
            My.Forms.frmCadastroConfiguracao.ID = IDSel
            FeedAutomacao.frmMain2.abreForm(My.Forms.frmCadastroConfiguracao, "S", 1)
        Else
            MsgBox("Selecione Um Registro Para Edição!", MsgBoxStyle.Information, "Aviso")
        End If
        Return MyBase.EditarF6(IDSel)
    End Function

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarF6(Me.dgvDados.idSel)
    End Sub

    Private Sub frmGerenciaDeConfiguracoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Filtrar()
    End Sub

End Class
