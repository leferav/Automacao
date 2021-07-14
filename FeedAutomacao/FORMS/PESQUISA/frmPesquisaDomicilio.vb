Public Class frmPesquisaDomicilio

    Public idProdutor As Integer = -1
    'Public MostrarIE As Boolean = False

    Private Sub txtDomicilio_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDomicilio.KeyUp, txtProdutor.KeyUp, txtIE.KeyUp, txtCNPJ.KeyUp, txtFantasia.KeyUp
        If e.KeyCode <> Keys.Escape AndAlso e.KeyCode <> Keys.Enter AndAlso e.KeyCode <> Keys.Down Then
            Dim ssql As String = ""
            If txtProdutor.Text <> "" Then ' txtDomicilio.Text <> "" AndAlso txtIE.Text.Replace(".", "").Replace("-", "").Trim() <> "" Then
                ssql += " AND (SELECT NOME FROM TB_PESSOA with (nolock) WHERE ID = N.IDPESSOA) like '%" + txtProdutor.Text + "%'"
            End If
            If txtDomicilio.Text <> "" Then
                ssql += " AND N.Nome like '%" + txtDomicilio.Text + "%'"
            End If
            If txtIE.Text.Replace(".", "").Replace("-", "").Replace("_", "").TrimEnd() <> "" Then
                ssql += " AND N.IE like '%" + txtIE.Text.Replace(".", "").Replace("-", "").Replace("_", "").TrimEnd() + "%'"
            End If
            If txtCNPJ.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "").TrimEnd() <> "" Then
                ssql += " AND N.CGC like '%" + txtCNPJ.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "").TrimEnd() + "%'"
            End If
            If txtFantasia.Text <> "" Then
                ssql += " AND N.Fantasia like '%" + txtFantasia.Text + "%'"
            End If
            carrega(ssql)
        End If
    End Sub

    Public Overrides Sub carrega(Optional ByVal filtro As String = "")
        MyBase.carrega()
        Dim dt As DataTable
        Dim ssql As String = "SELECT top 200 " + ValID
        ssql += " ,CodFazCli As 'CÓD.', Nome AS 'DOMICÍLIO', FANTASIA, "
        ssql += "(SELECT NOME FROM TB_PESSOA with (nolock) WHERE ID = N.IDPESSOA) AS 'PRODUTOR', IE, CGC AS CNPJ,CodClienteExterno as 'CodClienteEx',CodFornecedorExterno as 'CodFornecedorEx' "
        ssql += " from TB_DOMICILIO N with (nolock) WHERE IDEmpresa <> -2 " 'WHERE IDGrupoEmpresa = " + My.Forms.frmPadrao.IDGrupoEmpresa.ToString() '"IDEMPRESA = " + My.Forms.frmPadrao.IDEmpresa.ToString()
        ssql += filtro

        If My.Forms.frmPadrao.eFiscal = True Then
            ssql += " AND controle = 0"
        End If


        If idProdutor <> -1 Then
            ssql += " AND IDPessoa = " + idProdutor.ToString()
        End If

        If cbInativo.Visible AndAlso cbInativo.Checked Then
            ssql += " AND ATIVO = 0"
        Else
            ssql += " AND ATIVO = 1"
        End If

        If Condicao <> "" Then
            ssql += Condicao
        End If

        If txtDomicilio.Focused Then
            ssql += " order by Nome"
        ElseIf txtProdutor.Focused Then
            ssql += " order by PRODUTOR"
        ElseIf txtIE.Focused Then
            ssql += " order by IE"
        Else
            ssql += " order by CNPJ"
        End If

        dt = fbConnection.executaSelect(ssql)
        dgvDados.DataSource = dt
    End Sub

    Public Overrides Sub arrumaGrid()
        MyBase.arrumaGrid()
        dgvDados.Columns("PRODUTOR").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvDados.Columns("PRODUTOR").MinimumWidth = 200
        dgvDados.Columns("DOMICÍLIO").Width = 200
        dgvDados.Columns("Fantasia").Width = 200
        dgvDados.Columns("IE").Width = 90
        dgvDados.Columns("Cód.").Width = 50
    End Sub

    Public Overrides Sub seleciona()
        MyBase.seleciona()
        If ID <> -1 Then
            daTaSelect = fbConnection.executaSelect("SELECT * from TB_DOMICILIO WITH (NOLOCK) where ID = " + ID.ToString())
            If daTaSelect IsNot Nothing AndAlso daTaSelect.Rows.Count > 0 Then
                'If MostrarIE Then
                ValVisivel = daTaSelect.Rows(0).Item("NOME") & " - " & daTaSelect.Rows(0).Item("IE")
                'Else
                '    ValVisivel = daTaSelect.Rows(0).Item("NOME")
                'End If
            End If
            Me.Close()
        End If
    End Sub

    Public Overrides Sub setaValor()
        MyBase.setaValor()
        ValVisivel = dgvDados.CurrentRow.Cells("DOMICÍLIO").Value
    End Sub

    Private Sub frmPesquisaPessoa_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            idProdutor = -1
            cbInativo.Hide()
            cbInativo.Visible = False
        End If
    End Sub

    Private Sub cbInativo_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbInativo.CheckedChanged
        If cbInativo.Visible Then
            carrega()
        End If
    End Sub

    Private Sub frmPesquisaDomicilio_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            idProdutor = -1
            cbInativo.Hide()
            cbInativo.Visible = False
            Me.txtDomicilio.Visible = True
            Me.txtProdutor.Visible = True
            Me.lblDom.Visible = True
            Me.lblProdutor.Visible = True
            Me.menuFiltro.Height = 123
        End If
    End Sub

    Private Sub frmPesquisaDomicilio_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Me.FormularioCadastroBARRA = New frmCadastroDomicilio
    End Sub

    Private Sub txtCodCliExterno_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCodCliInt.KeyUp, txtCodCliExterno.KeyUp
        If e.KeyCode <> Keys.Escape AndAlso e.KeyCode <> Keys.Enter AndAlso e.KeyCode <> Keys.Down Then
            Dim ssql As String = ""
            If txtCodCliExterno.Text <> "" Then
                ssql += "AND CodClienteExterno like '%" + txtCodCliExterno.Text + "%'"
            End If

            If txtCodCliInt.Text <> "" Then
                ssql += "AND CodFornecedorExterno like '%" + txtCodCliInt.Text + "%'"
            End If
            carrega(ssql)
        End If
    End Sub
End Class

