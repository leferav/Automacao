Public Class fbGridViewST

    Dim colselect As Boolean = False

    <System.ComponentModel.Category("FeedBack")> _
    Public Property ColunaSeleciona() As Boolean
        Get
            Return colselect
        End Get
        Set(ByVal value As Boolean)
            colselect = value
        End Set
    End Property

    Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellClick
        If colselect = True Then
            If Me.dgvDados.Columns("ck") IsNot Nothing Then
                If e.ColumnIndex = Me.dgvDados.Columns("ck").Index AndAlso e.RowIndex >= 0 Then
                    'If Me.dgvDados.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True Then
                    '    Me.dgvDados.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False
                    'Else
                    '    Me.dgvDados.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
                    'End If
                    Me.dgvDados.EndEdit()
                    RaiseEvent selecionaCol(Me.dgvDados.Rows(e.RowIndex))
                End If
            End If
        End If
    End Sub

    Private Sub dgvDados_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellEndEdit
        RaiseEvent fimEdicaoCelula(sender, e)
    End Sub

    Private Sub dgvDados_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDados.CellFormatting
        RaiseEvent formatarCelula(sender, e)
    End Sub

    Private Sub FbGridviewCad1_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvDados.DataSourceChanged
        lbLinhas.Text = FormatNumber(dgvDados.RowCount, 0)
        RaiseEvent atualizarGrid()
    End Sub

    <System.ComponentModel.Category("FeedBack")> _
    Public Event selecionaCol(ByVal row As DataGridViewRow)

    <System.ComponentModel.Category("FeedBack")> _
    Public Event atualizarGrid()

    <System.ComponentModel.Category("FeedBack")> _
    Public Event formatarCelula(sender As Object, e As DataGridViewCellFormattingEventArgs)

    <System.ComponentModel.Category("FeedBack")> _
    Public Event fimEdicaoCelula(sender As Object, e As DataGridViewCellEventArgs)

End Class
