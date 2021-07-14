Public Class fbGridview
    Inherits DataGridView

    Public Sub New()
        Me.AllowUserToAddRows = False
        Me.AllowUserToDeleteRows = False
        Me.AllowUserToOrderColumns = False
        Me.AllowUserToResizeRows = False
        Me.MultiSelect = False
        'Me.ReadOnly = True
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

    <System.ComponentModel.Category("FeedBack")> _
    Public Event selecionaCol(ByVal row As DataGridViewRow)

    Dim colselect As Boolean = False


    Dim _id As Integer = -1
    Public Property idSel() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Dim colID As String = "ID"
    Public Property colunaID() As String
        Get
            Return colID
        End Get
        Set(ByVal value As String)
            colID = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
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
        ElseIf Me.Columns("Selecionar") IsNot Nothing Then
            If e.ColumnIndex = Me.Columns("Selecionar").Index AndAlso e.RowIndex >= 0 Then
                If Me.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True Then
                    Me.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False
                Else
                    Me.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
                End If
                Me.EndEdit()
                RaiseEvent selecionaCol(Me.Rows(e.RowIndex))
            End If
        End If
    End Sub

    Private Sub fbGridview_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CellEnter
        _id = Me.CurrentRow.Cells(colID).Value
    End Sub

    Private Sub fbGridview_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataSourceChanged
        idSel = -1
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
        If Me.Rows.Count > 0 AndAlso Me.CurrentRow IsNot Nothing Then
            _id = Me.CurrentRow.Cells(colID).Value
        End If
    End Sub
End Class
