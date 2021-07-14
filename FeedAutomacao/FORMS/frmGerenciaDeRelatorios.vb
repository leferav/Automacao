

Public Class frmGerenciaDeRelatorios

    Dim IDsel As Integer = -1





    Public Overrides Sub Filtrar(Optional ByVal filtra As Boolean = True)
        Me.Cursor = Cursors.WaitCursor
        Dim filtro As String = ""

        If txtNomeRel.Text <> "" Then
            filtro += " AND R.NOME LIKE '%" & txtNomeRel.Text.Trim & "%'"
        End If

        If rbwms.Checked = True Then
            filtro += " AND R.TIPOSISTEMA = (SELECT ID FROM TB_TIPO_SISTEMA WITH (NOLOCK) WHERE NOME = 'WMS')"
        ElseIf rbERP.Checked = True Then
            filtro += " AND R.TIPOSISTEMA = (SELECT ID FROM TB_TIPO_SISTEMA WITH (NOLOCK) WHERE NOME = 'ERP')"
        ElseIf rbTms.Checked = True Then
            filtro += " AND R.TIPOSISTEMA = (SELECT ID FROM TB_TIPO_SISTEMA WITH (NOLOCK) WHERE NOME = 'TRANSPORTE')"
        Else
            filtro += " AND R.TIPOSISTEMA = R.TIPOSISTEMA "
        End If




        Dim ssql As String = ""

        ssql += " SELECT TOP 200 R.ID,"
        ssql += " R.Nome as 'RELATÓRIO',"
        ssql += " R.COD AS 'CÓDIGO',"
        ssql += " R.PROCEDIMENTO AS 'PROCEDURE',"
        ssql += " S.NOME AS 'SISTEMA',"
        ssql += " R.DESCRICAO AS 'INFORMAÇÕES ADC.',"
        ssql += " R.IMAGEM AS 'REFERÊNCIA'"
        ssql += " FROM TB_TIPO_RELATORIO R with (nolock) INNER JOIN TB_TIPO_SISTEMA S ON S.ID = R.TIPOSISTEMA"
        ssql += " WHERE R.ID = R.ID "
        ssql += filtro
        Dim dt = fbConnection.executaSelect(ssql)
        dgvDados.DataSource = dt
        Me.Cursor = Cursors.Arrow
    End Sub


    Public Overrides Sub setaDts()
        MyBase.setaDts()

        If dgvDados.ColumnCount > 1 Then
            dgvDados.Columns("RELATÓRIO").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvDados.Columns("CÓDIGO").MinimumWidth = 180
            dgvDados.Columns("PROCEDURE").MinimumWidth = 150
            dgvDados.Columns("SISTEMA").MinimumWidth = 100
            dgvDados.Columns("INFORMAÇÕES ADC.").MinimumWidth = 300
            dgvDados.Columns("REFERÊNCIA").Width = 140


            'For Each R As DataGridViewRow In dgvDados.Rows
            '    Select Case R.Cells(".NET").Value
            '        Case Is = "SIM"
            '            R.DefaultCellStyle.BackColor = Color.SteelBlue
            '            R.DefaultCellStyle.ForeColor = Color.White
            '        Case Is = "NÃO"
            '            R.DefaultCellStyle.BackColor = Color.CadetBlue
            '            R.DefaultCellStyle.ForeColor = Color.White
            '    End Select
            'Next

        End If
    End Sub


    Public Overrides Sub inserirF5()
        MyBase.inserirF5()
        My.Forms.frmCadastroDeTipoDeRelatorio.ID = -1
        FeedAutomacao.frmMain2.abreForm(My.Forms.frmCadastroDeTipoDeRelatorio, "S", 0)
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        inserirF5()
    End Sub


    Public Overrides Function EditarF6(ByVal IDSel As Integer) As Boolean
        If IDSel <> -1 Then
            My.Forms.frmCadastroDeTipoDeRelatorio.ID = IDSel
            FeedAutomacao.frmMain2.abreForm(My.Forms.frmCadastroDeTipoDeRelatorio, "S", 1)
        Else
            MsgBox("Selecione Um Registro Para Edição!", MsgBoxStyle.Information, "Aviso")
        End If
        Return MyBase.EditarF6(IDSel)
    End Function

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarF6(Me.dgvDados.idSel)
    End Sub

    Private Sub txtNomeRel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNomeRel.KeyDown
        If e.KeyCode <> Keys.Escape AndAlso e.KeyCode <> Keys.Enter AndAlso e.KeyCode <> Keys.Down Then
            Filtrar(True)
        End If
    End Sub

    Private Sub AnexarImagemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnexarImagemToolStripMenuItem.Click
        If dgvDados.CurrentRow IsNot Nothing Then
            Dim idRel As Integer = dgvDados.CurrentRow.Cells("ID").Value

            Dim caminhoFoto = clGeral.buscaImg
            If caminhoFoto <> "" Then
                Anexa_Desanexa_Foto(idRel, caminhoFoto)
            End If
            If dgvDados.CurrentRow IsNot Nothing Then
                Filtrar(True)
            End If
        End If
    End Sub

    Private Sub DesanexarImagemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesanexarImagemToolStripMenuItem.Click
        If dgvDados.CurrentRow IsNot Nothing Then
            Dim idrel As Integer = dgvDados.CurrentRow.Cells("ID").Value
            Anexa_Desanexa_Foto(idrel, "")
            If dgvDados.CurrentRow IsNot Nothing Then
                Filtrar(True)
            End If
        End If
    End Sub

    Private Sub Anexa_Desanexa_Foto(IDRE As Integer, caminhoFoto As String)
        Dim dt As New dtsDev.TB_TIPO_RELATORIODataTable
        Dim dr As New dtsDevTableAdapters.TB_TIPO_RELATORIOTableAdapter
        Dim row As dtsDev.TB_TIPO_RELATORIORow

        If IDRE <> -1 Then
            dt = dr.GetDataByID(IDRE)
            row = dt.Rows(0)
            If caminhoFoto <> "" Then
                row.imagem = clGeral.FileImage2ByteArray(caminhoFoto)
            Else
                row.SetImagemNull()
            End If
            dr.Update(dt)
        End If
    End Sub

    Private Sub frmGerenciaDeRelatorios_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvDados.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub RtbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles RtbTodos.CheckedChanged, rbwms.CheckedChanged, rbTms.CheckedChanged, rbERP.CheckedChanged
        Filtrar(True)
    End Sub
End Class
