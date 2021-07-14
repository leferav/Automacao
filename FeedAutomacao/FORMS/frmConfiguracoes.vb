Imports System.Runtime.InteropServices

Public Class frmConfiguracoes

    'importando Dll's
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr,
                                   ByVal wMsg As Integer,
                                   ByVal wParam As Integer,
                                   ByVal lParam As Integer)

    End Sub

    Private _ID As Integer = -1
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property



    Public Shared Con As New SqlClient.SqlConnection(My.Settings.FeedAutomacaoConnectionString)

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()
    End Sub

    Private Sub BtnSalvar_Load(sender As Object, e As EventArgs) Handles BtnSalvar.Load
        CarregaDados()
    End Sub

    Public sql As String = "Select * from TB_AUTOMACAO_EQUIPAMENTOS "
    Public equipamentos As DataTable = fbConnection.executaSelect(sql)

    Private Sub CarregaDados()

        Try
            If equipamentos IsNot Nothing AndAlso equipamentos.Rows.Count > 0 Then

                Dim Status1 As Integer = equipamentos.Rows(0).Item("Status")
                Dim Status2 As Integer = equipamentos.Rows(1).Item("Status")
                Dim Status3 As Integer = equipamentos.Rows(2).Item("Status")
                Dim Status4 As Integer = equipamentos.Rows(3).Item("Status")

                If (Status1 = True) Then

                    If txtNomeCancela1.Text <> "" Then
                        txtNomeCancela1.Text = equipamentos.Rows(0).Item("NomeCancela")
                    Else
                        txtNomeCancela1.Text = "Nome Padrao Cancela"
                    End If
                    If txtIPCancela1.Text <> "" Then
                        txtIPCancela1.Text = equipamentos.Rows(0).Item("IPCancela")
                    Else
                        txtIPCancela1.Text = "1.1.1.1"
                    End If

                    If txtNomeRFID1.Text <> "" Then
                        txtNomeRFID1.Text = equipamentos.Rows(0).Item("NomeRFID_1")
                    Else
                        txtNomeRFID1.Text = "Nome Padrão RFID"
                    End If
                    If txtIPRFID1.Text <> "" Then
                        txtIPRFID1.Text = equipamentos.Rows(0).Item("IPRFID_1")
                    Else
                        txtIPRFID1.Text = "1.1.1.1"
                    End If

                    If txtNomeRFID1_1.Text <> "" Then
                        txtNomeRFID1_1.Text = equipamentos.Rows(0).Item("NomeRFID_2")
                    Else
                        txtNomeRFID1_1.Text = "Nome Padrão RFID"
                    End If
                    If txtIPRFID1_1.Text <> "" Then
                        txtIPRFID1_1.Text = equipamentos.Rows(0).Item("IPRFID_2")
                    Else
                        txtIPRFID1_1.Text = "1.1.1.1"
                    End If

                End If

                If (Status2 = True) Then

                    txtNomeCancela2.Enabled = True
                    txtIPCancela2.Enabled = True
                    txtNomeRFID2.Enabled = True
                    txtIPRFID2.Enabled = True
                    txtNomeRFID1_2.Enabled = True
                    txtIPRFID1_2.Enabled = True

                    If txtNomeCancela2.Text <> "" Then
                        txtNomeCancela2.Text = equipamentos.Rows(1).Item("NomeCancela")
                    Else
                        txtNomeCancela2.Text = "Nome Padrao Cancela"
                    End If
                    If txtIPCancela2.Text <> "" Then
                        txtIPCancela2.Text = equipamentos.Rows(1).Item("IPCancela")
                    Else
                        txtIPCancela2.Text = "1.1.1.1"
                    End If

                    If txtNomeRFID2.Text <> "" Then
                        txtNomeRFID2.Text = equipamentos.Rows(1).Item("NomeRFID_1")
                    Else
                        txtNomeRFID2.Text = "Nome Padrão RFID"
                    End If
                    If txtIPRFID2.Text <> "" Then
                        txtIPRFID2.Text = equipamentos.Rows(1).Item("IPRFID_1")
                    Else
                        txtIPRFID2.Text = "1.1.1.1"
                    End If

                    If txtNomeRFID1_2.Text <> "" Then
                        txtNomeRFID1_2.Text = equipamentos.Rows(1).Item("NomeRFID_2")
                    Else
                        txtNomeRFID1_2.Text = "Nome Padrão RFID"
                    End If
                    If txtIPRFID1_2.Text <> "" Then
                        txtIPRFID1_2.Text = equipamentos.Rows(1).Item("IPRFID_2")
                    Else
                        txtIPRFID1_2.Text = "1.1.1.1"
                    End If
                End If

                If (Status3 = True) Then
                    txtNomeCancela3.Enabled = True
                    txtIPCancela3.Enabled = True
                    txtNomeRFID3.Enabled = True
                    txtIPRFID3.Enabled = True
                    txtNomeRFID1_3.Enabled = True
                    txtIPRFID1_3.Enabled = True

                    If txtNomeCancela3.Text <> "" Then
                        txtNomeCancela3.Text = equipamentos.Rows(3).Item("NomeCancela")
                    Else
                        txtNomeCancela3.Text = "Nome Padrao Cancela"
                    End If
                    If txtIPCancela3.Text <> "" Then
                        txtIPCancela3.Text = equipamentos.Rows(3).Item("IPCancela")
                    Else
                        txtIPCancela3.Text = "1.1.1.1"
                    End If

                    If txtNomeRFID3.Text <> "" Then
                        txtNomeRFID3.Text = equipamentos.Rows(3).Item("NomeRFID_1")
                    Else
                        txtNomeRFID3.Text = "Nome Padrão RFID"
                    End If
                    If txtIPRFID3.Text <> "" Then
                        txtIPRFID3.Text = equipamentos.Rows(3).Item("IPRFID_1")
                    Else
                        txtIPRFID3.Text = "1.1.1.1"
                    End If

                    If txtNomeRFID1_3.Text <> "" Then
                        txtNomeRFID1_3.Text = equipamentos.Rows(3).Item("NomeRFID_2")
                    Else
                        txtNomeRFID1_3.Text = "Nome Padrão RFID"
                    End If
                    If txtIPRFID1_3.Text <> "" Then
                        txtIPRFID1_3.Text = equipamentos.Rows(3).Item("IPRFID_2")
                    Else
                        txtIPRFID1_3.Text = "1.1.1.1"
                    End If
                End If

                If (Status4 = True) Then
                    txtNomeCancela4.Enabled = True
                    txtIPCancela4.Enabled = True
                    txtNomeRFID4.Enabled = True
                    txtIPRFID4.Enabled = True
                    txtNomeRFID1_4.Enabled = True
                    txtIPRFID1_4.Enabled = True

                    If txtNomeCancela4.Text <> "" Then
                        txtNomeCancela4.Text = equipamentos.Rows(4).Item("NomeCancela")
                    Else
                        txtNomeCancela4.Text = "Nome Padrao Cancela"
                    End If
                    If txtIPCancela4.Text <> "" Then
                        txtIPCancela4.Text = equipamentos.Rows(4).Item("IPCancela")
                    Else
                        txtIPCancela4.Text = "1.1.1.1"
                    End If

                    If txtNomeRFID4.Text <> "" Then
                        txtNomeRFID4.Text = equipamentos.Rows(4).Item("NomeRFID_1")
                    Else
                        txtNomeRFID4.Text = "Nome Padrão RFID"
                    End If
                    If txtIPRFID4.Text <> "" Then
                        txtIPRFID4.Text = equipamentos.Rows(4).Item("IPRFID_1")
                    Else
                        txtIPRFID4.Text = "1.1.1.1"
                    End If

                    If txtNomeRFID1_4.Text <> "" Then
                        txtNomeRFID1_4.Text = equipamentos.Rows(4).Item("NomeRFID_2")
                    Else
                        txtNomeRFID1_4.Text = "Nome Padrão RFID"
                    End If
                    If txtIPRFID1_4.Text <> "" Then
                        txtIPRFID1_4.Text = equipamentos.Rows(3).Item("IPRFID_2")
                    Else
                        txtIPRFID1_4.Text = "1.1.1.1"
                    End If
                End If



                'txtNomeRFID1.Text = equipamentos.Rows(0).Item("NomeRFID_1")
                'txtNomeRFID2.Text = equipamentos.Rows(1).Item("NomeRFID_1")
                'txtNomeRFID3.Text = equipamentos.Rows(2).Item("NomeRFID_1")
                'txtNomeRFID4.Text = equipamentos.Rows(3).Item("NomeRFID_1")

                'txtIPRFID1.Text = equipamentos.Rows(0).Item("IPRFID_1")
                'txtIPRFID2.Text = equipamentos.Rows(1).Item("IPRFID_1")
                'txtIPRFID3.Text = equipamentos.Rows(2).Item("IPRFID_1")
                'txtIPRFID4.Text = equipamentos.Rows(3).Item("IPRFID_1")
            Else
                'txtNomeCancela1.Text = "Cancela Padrao"
                'txtNomeCancela2.Text = "Cancela Padrao"
                'txtNomeCancela3.Text = "Cancela Padrao"
                'txtNomeCancela4.Text = "Cancela Padrao"
                'txtIPCancela1.Text = "192.168.254.254"
                'txtNomeRFID1.Text = "RFID Padrao"
                'txtIPRFID1.Text = "192.168.254.254"

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Salvar()

        Dim sql As String = ""
            Dim cont As Integer = 0
        Try
            If equipamentos.Rows(0).Item("Status") = True Then
                sql += $"UPDATE TB_AUTOMACAO_EQUIPAMENTOS SET "
                sql += $"NomeCancela = '{txtNomeCancela1.Text}' , "
                sql += $"IPCancela = '{txtIPCancela1.Text}' , "
                sql += $"NomeRFID_1 = '{txtNomeRFID1.Text}' , "
                sql += $"IPRFID_1 = '{txtIPRFID1.Text}' , "
                sql += $"NomeRFID_2 = '{txtNomeRFID1_1.Text}' , "
                sql += $"IPRFID_2 = '{txtIPRFID1_1.Text}'  "
                sql += $" where id = 1"
                Dim exc = fbConnection.executaCommand(sql.ToString)
                cont += 1
            End If
            If equipamentos.Rows(1).Item("Status") = True Then
                sql += $"UPDATE TB_AUTOMACAO_EQUIPAMENTOS SET "
                sql += $"NomeCancela = '{txtNomeCancela2.Text}' , "
                sql += $"IPCancela = '{txtIPCancela2.Text}' , "
                sql += $"NomeRFID_1 = '{txtNomeRFID2.Text}' , "
                sql += $"IPRFID_1 = '{txtIPRFID2.Text}' , "
                sql += $"NomeRFID_2 = '{txtNomeRFID1_2.Text}' , "
                sql += $"IPRFID_2 = '{txtIPRFID1_2.Text}'  "
                sql += $" where id = 2"
                Dim exc = fbConnection.executaCommand(sql.ToString)
                cont += 1
            End If
            If cont > 0 Then
                MsgBox("Dados Salvo com sucesso!")
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao Alterar\Salvar os dados" + ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Close()
    End Sub

End Class
