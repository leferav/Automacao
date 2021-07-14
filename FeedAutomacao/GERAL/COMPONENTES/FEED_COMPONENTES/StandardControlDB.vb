'DEVELOPMENT BY GUIGUI NARIZ, SERA Q ALGUEM VAI VER!!? (QUEM PENSA MAIS, DIGITA MENOS, FICA A DICA!! ;) )
Public Class StandardControlDB
    Public Property ValorVazio As Object
    Public Property ValorPadrao As Object
    Public Property Row As DataRow
    Public Property NomeCampo As String
    Private Property Controle As Object

    Public Function ValidaVazio(msg As String) As Boolean
        Dim val As Boolean = True

        If TypeOf Controle Is fbTextBox OrElse TypeOf Controle Is fbMaskBox OrElse TypeOf Controle Is fbNumericBox Then
            If TypeOf Controle Is fbMaskBox AndAlso Controle.ValorSemMascara = ValorVazio Then
                val = False
            Else
                If Controle.Text = ValorVazio Then val = False
            End If
        ElseIf TypeOf Controle Is fbComboBox Then
            If Controle.ValorSelecionado = ValorVazio Then val = False

        ElseIf TypeOf Controle Is fbData OrElse TypeOf Controle Is fbDate Then
            If Controle.ShowCheckBox Then
                If Controle.Checked = False Then val = False
            Else
                If Controle.Value = ValorVazio Then val = False
            End If
        ElseIf TypeOf Controle Is fbNumericUP Then
            If Controle.Value = ValorVazio Then val = False

        ElseIf TypeOf Controle Is fbCheckBox Then
            If Controle.checked = ValorVazio Then val = False

        ElseIf TypeOf Controle Is fbPicturebox Then
            If Controle.Image = ValorVazio Then val = False

        ElseIf TypeOf Controle Is fbNumericBox_v2 Then
            If Controle.valorNumerico = ValorVazio Then val = False

        ElseIf TypeOf Controle Is fbRadioGroupBox Then
            If Controle.ValorSelecionado = ValorVazio.ToString Then val = False

        ElseIf TypeOf Controle Is fbRadioGroupBox Then
            If Controle.ValorSelecionado = ValorVazio.ToString Then val = False

        ElseIf TypeOf Controle Is fbLookUp Then
            If Controle.SelectID = ValorVazio Then val = False

        ElseIf TypeOf Controle Is fbLookUpTreeView Then
            If Controle.SelectID = ValorVazio Then val = False

        End If
        If val = False Then msgValida(msg, Controle)
        Return val
    End Function


    Public Sub New(_Controle As Object, Optional _ValorVazio As Object = Nothing, Optional _ValorPadrao As Object = Nothing)
        Controle = _Controle
        ValorVazio = _ValorVazio
        ValorPadrao = _ValorPadrao
    End Sub

    Public Sub SetaCampo(_Row As DataRow, _NomeCampo As String, Optional _ValorVazio As Object = Nothing, Optional _ValorPadrao As Object = Nothing)
        Row = _Row
        NomeCampo = _NomeCampo
        If _ValorVazio IsNot Nothing Then ValorVazio = _ValorVazio
        If _ValorPadrao IsNot Nothing Then ValorPadrao = _ValorPadrao
    End Sub

    Public Sub AtualizaControle()
        If Row IsNot Nothing AndAlso NomeCampo <> "" Then
            If Row.IsNull(NomeCampo) Then
                Limpar()
            Else
                If TypeOf Controle Is fbTextBox OrElse TypeOf Controle Is fbMaskBox Then
                    Controle.Text = Row.Item(NomeCampo).ToString.TrimEnd()

                ElseIf TypeOf Controle Is fbNumericBox Then
                    Controle.Text = Row.Item(NomeCampo)

                ElseIf TypeOf Controle Is fbComboBox Then
                    Controle.ValorSelecionado = Row.Item(NomeCampo)

                ElseIf TypeOf Controle Is fbData Or TypeOf Controle Is fbDate Then
                    Controle.Value = Row.Item(NomeCampo)
                    If Controle.ShowCheckBox Then
                        Controle.Checked = True
                    End If
                ElseIf TypeOf Controle Is fbNumericUP Then
                    Controle.Value = Row.Item(NomeCampo)

                ElseIf TypeOf Controle Is fbCheckBox Then
                    Controle.checked = Row.Item(NomeCampo)

                    'ElseIf TypeOf Controle Is fbPicturebox Then
                    '    Controle.Image = clConversoes.ByteArray2Img(Row.Item(NomeCampo))

                ElseIf TypeOf Controle Is fbNumericBox_v2 Then
                    Controle.text = Row.Item(NomeCampo)

                ElseIf TypeOf Controle Is fbRadioGroupBox Then
                    Controle.ValorSelecionado = Row.Item(NomeCampo).ToString

                ElseIf TypeOf Controle Is fbLookUp Then
                    Controle.SelectID = Row.Item(NomeCampo)

                ElseIf TypeOf Controle Is fbLookUpTreeView Then
                    Controle.SelectID = Row.Item(NomeCampo)

                End If
            End If
        End If
    End Sub

    Public Sub Limpar()
        If TypeOf Controle Is fbTextBox Or TypeOf Controle Is fbMaskBox Or TypeOf Controle Is fbNumericBox Then
            If ValorPadrao Is Nothing Then
                Controle.Text = ValorVazio
            Else
                Controle.Text = ValorPadrao
            End If

        ElseIf TypeOf Controle Is fbComboBox Then
            If ValorPadrao Is Nothing Then
                Controle.ValorSelecionado = ValorVazio
            Else
                Controle.ValorSelecionado = ValorPadrao
            End If

        ElseIf TypeOf Controle Is fbData Or TypeOf Controle Is fbDate Then
            If ValorPadrao Is Nothing Then
                Controle.Value = Date.Now
                If Controle.ShowCheckBox Then
                    Controle.Checked = True
                End If
            Else
                Controle.Value = ValorPadrao
                If Controle.ShowCheckBox Then
                    Controle.Checked = False
                End If
            End If

            Controle.Update
        ElseIf TypeOf Controle Is fbNumericUP Then
            If ValorPadrao Is Nothing Then
                Controle.Text = ValorVazio
            Else
                Controle.Text = ValorPadrao
            End If
        ElseIf TypeOf Controle Is fbCheckBox Then
            If ValorPadrao Is Nothing Then
                Controle.checked = ValorVazio
            Else
                Controle.checked = ValorPadrao
            End If

        ElseIf TypeOf Controle Is fbPicturebox Then
            If ValorPadrao Is Nothing Then
                Controle.Image = ValorVazio
            Else
                Controle.Image = ValorPadrao
            End If

        ElseIf TypeOf Controle Is fbNumericBox_v2 Then
            If ValorPadrao Is Nothing Then
                Controle.Text = ValorVazio
            Else
                Controle.Text = ValorPadrao
            End If

        ElseIf TypeOf Controle Is fbRadioGroupBox Then
            If ValorPadrao Is Nothing Then
                Controle.ValorSelecionado = ValorVazio.ToString
            Else
                Controle.ValorSelecionado = ValorPadrao.ToString
            End If

        ElseIf TypeOf Controle Is fbRadioGroupBox Then
            If ValorPadrao Is Nothing Then
                Controle.ValorSelecionado = ValorVazio.ToString
            Else
                Controle.ValorSelecionado = ValorVazio.ToString
            End If

        ElseIf TypeOf Controle Is fbLookUp Then
            If ValorPadrao Is Nothing Then
                Controle.SelectID = ValorVazio
            Else
                Controle.SelectID = ValorVazio
            End If

        End If
    End Sub

    Public Sub AtualizaRegistro()
        If Row IsNot Nothing AndAlso NomeCampo <> "" Then
            If TypeOf Controle Is fbTextBox Or TypeOf Controle Is fbNumericBox Then
                Row.Item(NomeCampo) = Controle.Text.ToString.TrimEnd()
            ElseIf TypeOf Controle Is fbMaskBox Then
                Row.Item(NomeCampo) = Controle.ValorSemMascara
            ElseIf TypeOf Controle Is fbComboBox Then
                If IsNumeric(Controle.ValorSelecionado) AndAlso Controle.ValorSelecionado <> -1 Then
                    Row.Item(NomeCampo) = Controle.ValorSelecionado
                ElseIf Controle.ValorSelecionado <> "-1" Then
                    Row.Item(NomeCampo) = Controle.ValorSelecionado
                Else
                    Row.Item(NomeCampo) = DBNull.Value
                End If
            ElseIf TypeOf Controle Is fbData OrElse TypeOf Controle Is fbDate Then
                If Controle.ShowCheckBox AndAlso Controle.Checked = True Then
                    Row.Item(NomeCampo) = Controle.Value
                ElseIf Controle.ShowCheckBox = False Then
                    Row.Item(NomeCampo) = Controle.Value
                End If
            ElseIf TypeOf Controle Is fbNumericUP Then
                Row.Item(NomeCampo) = Controle.Value
            ElseIf TypeOf Controle Is fbCheckBox Then
                Row.Item(NomeCampo) = Controle.checked
            ElseIf TypeOf Controle Is NumericUpDown Then
                Row.Item(NomeCampo) = Controle.Value
                'ElseIf TypeOf Controle Is fbPicturebox Then
                '    If Not IsNothing(Controle.Image) Then Row.Item(NomeCampo) = clConversoes.Img2ByteArray(Controle.Image)
            ElseIf TypeOf Controle Is fbNumericBox_v2 Then
                Row.Item(NomeCampo) = Controle.ValorNumerico
            ElseIf TypeOf Controle Is fbRadioGroupBox Then
                Try
                    Row.Item(NomeCampo) = Controle.ValorSelecionado
                Catch
                    Row.Item(NomeCampo) = DBNull.Value
                End Try
            ElseIf TypeOf Controle Is fbLookUp Then
                If Controle.SelectID <> -1 Then
                    Row.Item(NomeCampo) = Controle.SelectID
                Else
                    Row.Item(NomeCampo) = DBNull.Value
                End If
            ElseIf TypeOf Controle Is fbLookUpTreeView Then
                If Controle.SelectID <> -1 Then
                    Row.Item(NomeCampo) = Controle.SelectID
                Else
                    Row.Item(NomeCampo) = DBNull.Value
                End If
            End If
        End If
    End Sub

End Class
