Imports System.Windows.Forms
Public Class frmCadastroClientesResponsaveis
    Dim dt As dtsCadastroCliente.TB_CLIENTES_RESPONSAVEISDataTable
    Dim dr As New dtsCadastroClienteTableAdapters.TB_CLIENTES_RESPONSAVEISTableAdapter
    Friend row As dtsCadastroCliente.TB_CLIENTES_RESPONSAVEISRow
    Dim msg As Boolean = True

    Private Sub setaForm()



    End Sub



    Public Overrides Function Limpar() As Boolean
        MyBase.Limpar()

        txtNomeResponsavel.Text = ""
        txtCargoResposavel.Text = ""
        txtTel.Clear()
        txtWhats.Clear()
        txtSkype.Text = ""
        txtEmail.Text = ""
        Return MyBase.Limpar()
    End Function

    Public Overrides Function Editar(ByVal IDSel As Integer) As Boolean

        ID = IDSel
        If IDSel <> -1 Then
            dt = dr.GetDataByID(IDSel)
            row = dt.FindByID(IDSel)


            If row.IsNomeNull = False Then
                txtNomeResponsavel.Text = row.Nome
            Else
                txtNomeResponsavel.Text = ""
            End If

            If row.IsCargoNull = False Then
                txtCargoResposavel.Text = row.Cargo
            Else
                txtCargoResposavel.Text = ""
            End If

            If row.IsTelefoneNull = False Then
                txtTel.Text = row.Telefone
            Else
                txtTel.Clear()
            End If

            If row.IsWhatssapNull = False Then
                txtWhats.Text = row.Whatssap
            Else
                txtWhats.Clear()
            End If


            If row.IsSkypeNull = False Then
                txtSkype.Text = row.Skype
            Else
                txtSkype.Clear()
            End If

            Carrega()
        Else
            MsgBox("Erro ao Carregar o Registro!", MsgBoxStyle.Critical)
        End If
        Return MyBase.Editar(IDSel)
    End Function



    Public Overrides Function Salvar(ByVal IDSel As Integer) As Boolean
        If MyBase.Salvar(IDSel) = True Then
            Carrega()
            If IDSel = -1 Then
                Carrega()
                row = dt.NewTB_CLIENTES_RESPONSAVEISRow
            Else
                Carrega()
                row = dt.FindByID(IDSel)
            End If

            row.Nome = txtNomeResponsavel.Text
            row.Cargo = txtCargoResposavel.Text
            row.Telefone = txtTel.Text
            row.Whatssap = txtWhats.Text
            row.Skype = txtSkype.Text
            row.Email = txtEmail.Text
            row.IDCliente = IDRelacionamento

            If IDSel = -1 Then
                dt.AddTB_CLIENTES_RESPONSAVEISRow(row)
            End If

            dr.Update(dt)
            If msg Then
                msgSalvar()
                Esc()
            End If
            If IDSel = -1 Then
                IDSel = dr.MAXID
                ID = IDSel
            End If
            Return True
        End If
        Return False
    End Function





    Public Overrides Sub Carrega(Optional ByVal IDParent As Integer = -1)
        MyBase.Carrega(IDParent)
        dt = dr.GetDataByID(ID)

        Dim sql As String = "Select r.ID,"
        sql += "r.NOME,"
        sql += "r.CARGO,"
        sql += "r.TELEFONE,"
        sql += "r.WHATSSAP,"
        sql += "r.EMAIL,"
        sql += "r.SKYPE"
        sql += "  From TB_CLIENTES_RESPONSAVEIS r "
        sql += " INNER JOIN TB_CLIENTES c ON r.idCliente = c.id  "
        sql += "  WHERE r.idCliente =" + IDRelacionamento.ToString()
        Dados = fbConnection.executaSelect(sql)

    End Sub


    Public Overridable Sub F12()
        MyBase.funcF12()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        salvandoDados()
    End Sub





    Public Overridable Sub Esc()
        ShowDialogs = False
        Me.Close()
    End Sub

    Private Sub btnFecharTela_Click(sender As Object, e As EventArgs) Handles btnFecharTela.Click
        Esc()
    End Sub

    Public Overrides Function Excluir(ByVal IDSel As Integer) As Boolean

        If IDSel <> -1 Then
            Try
                Carrega()
                row = dt.FindByID(IDSel)
                row.Delete()
                dr.Update(dt)
                msgExcluir()
                Return True
            Catch ex As SqlClient.SqlException
                If ex.ErrorCode = -2146232060 Then
                    MsgBox("Erro ao Excluir o Registro Pois Está Relacionado a Outro Registro! ", MsgBoxStyle.Critical)
                Else
                    MsgBox("Erro ao Excluir o Registro! " + ex.Message, MsgBoxStyle.Critical)
                End If
                Return False
            End Try
        End If

        Return MyBase.Excluir(IDSel)
    End Function

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Excluir(ID)
    End Sub
End Class
