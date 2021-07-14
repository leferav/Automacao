Public Class fbGridviewCad
    Inherits DataGridView

    Public Sub New()
        'Me.AllowUserToAddRows = False
        Me.AllowUserToDeleteRows = False
        'Me.AllowUserToOrderColumns = False
        'Me.AllowUserToResizeRows = False
        Me.MultiSelect = False
        Me.RowHeadersVisible = False
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.BackgroundColor = Color.WhiteSmoke
        Me.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        Me.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        Me.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
        Me.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold, GraphicsUnit.Point)
    End Sub

    Private Sub fbGridviewCad_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataSourceChanged
        If colselect = True AndAlso Me.DataSource IsNot Nothing Then
            If Me.Columns("ck") Is Nothing Then
                Dim ck As New DataGridViewCheckBoxColumn
                ck.HeaderText = "Selecionar"
                ck.Name = "ck"
                ck.DisplayIndex = 0
                ck.ReadOnly = False
                ck.Width = 75
                Me.Columns.Add(ck)
            End If
        End If
        If Me.ColumnCount > 0 Then
            If Me.Columns("ID") IsNot Nothing Then
                Me.Columns("ID").Visible = False
            End If
        End If
    End Sub

    Dim colselect As Boolean = False

    <System.ComponentModel.Category("FeedBack")>
    Public Property ColunaSeleciona() As Boolean
        Get
            Return colselect
        End Get
        Set(ByVal value As Boolean)
            colselect = value
        End Set
    End Property

    Private Sub fbGridview_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CellClick
        If colselect = True Then
            If Me.Columns("ck") IsNot Nothing Then
                If e.ColumnIndex = Me.Columns("ck").Index AndAlso e.RowIndex >= 0 Then
                    If Me.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True Then
                        Me.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False
                    Else
                        Me.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
                    End If
                    Me.EndEdit()
                    RaiseEvent selecionaCol(Me.Rows(e.RowIndex))
                End If
            End If
        End If
    End Sub

    <System.ComponentModel.Category("FeedBack")>
    Public Event selecionaCol(ByVal row As DataGridViewRow)

End Class
