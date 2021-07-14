Public Class fbGridDadosDesc

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        btnAdd.FlatStyle = FlatStyle.Standard
        btndel.FlatStyle = FlatStyle.Standard
        btnEdit.FlatStyle = FlatStyle.Standard
        btnPrint.FlatStyle = FlatStyle.Standard
        ' Add any initialization after the InitializeComponent() call.
        Me.dgvDados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        Me.dgvDados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        Me.dgvDados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvDados.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
        Me.dgvDados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvDados.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold, GraphicsUnit.Point)
    End Sub

    Public cancelaOperacao As Boolean = False

    <System.ComponentModel.Category("FeedBack")> _
    Public Event change()

    <System.ComponentModel.Category("FeedBack")> _
    Public Event aoEntrarLinha(ByVal IDSelecionado As Integer)

    <System.ComponentModel.Category("FeedBack")> _
    Public Event Imprimir(ByVal IDSelecionado As Integer)

    <System.ComponentModel.Category("FeedBack")> _
    Public Event antesDeExcluir(ByVal IDSelecionado As Integer)

    <System.ComponentModel.Category("FeedBack")> _
    Public Event antesDeInserir(ByVal IDSelecionado As Integer)

    <System.ComponentModel.Category("FeedBack")> _
    Public Event antesDeEditar(ByVal IDSelecionado As Integer)

    <System.ComponentModel.Category("FeedBack")> _
    Public Event executaAcao()

    <System.ComponentModel.Category("FeedBack")> _
    Public Event atualizaDts(ByVal grid As DataGridView)

    <System.ComponentModel.Category("FeedBack")> _
    Public Event depoisdeSetarID()


    Dim _eleID As String = "ID"
    <System.ComponentModel.Category("FeedBack")> _
    Public Property campoID() As String
        Get
            Return _eleID
        End Get
        Set(ByVal value As String)
            _eleID = value
        End Set
    End Property

    Dim _par As String = ""
    <System.ComponentModel.Category("FeedBack")> _
    Public Property Parametro() As String
        Get
            Return _par
        End Get
        Set(ByVal value As String)
            _par = value
        End Set
    End Property

    Dim _ssql As String = ""
    <System.ComponentModel.Category("FeedBack")> _
    Public Property SqlDados() As String
        Get
            Return _ssql
        End Get
        Set(ByVal value As String)
            _ssql = value
        End Set
    End Property

    Dim _sCampos As String()
    <System.ComponentModel.Category("FeedBack")> _
    Public Property camposVisiveis() As String()
        Get
            Return _sCampos
        End Get
        Set(ByVal value As String())
            _sCampos = value
        End Set
    End Property

    Dim _id As Integer = -1
    <System.ComponentModel.Category("FeedBack")> _
    Public Property IDItem() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property showPrint() As Boolean
        Get
            Return btnPrint.Visible
        End Get
        Set(ByVal value As Boolean)
            btnPrint.Visible = value
        End Set
    End Property

    Dim _usarSalva As Boolean = True
    <System.ComponentModel.Category("FeedBack")> _
    Public Property usarSalvar() As Boolean
        Get
            Return _usarSalva
        End Get
        Set(ByVal value As Boolean)
            _usarSalva = value
        End Set
    End Property

    'Dim _idPai As Integer = -1
    '<System.ComponentModel.Category("FeedBack")> _
    'Public Property IDRelacionamento() As Integer
    '    Get
    '        Return _idPai
    '    End Get
    '    Set(ByVal value As Integer)
    '        _idPai = value
    '        If _idPai = -1 Then
    '            btnAdd.Enabled = SalvarDadosForm
    '            btndel.Enabled = False
    '            btnEdit.Enabled = False
    '        Else
    '            btnAdd.Enabled = True
    '            btndel.Enabled = True
    '            btnEdit.Enabled = True
    '            RaiseEvent depoisdeSetarID()
    '            End If
    '    End Set
    'End Property

    'Dim dt As DataTable
    '<System.ComponentModel.Category("FeedBack")> _
    'Public Property DataTable() As DataTable
    '    Get
    '        Return dt
    '    End Get
    '    Set(ByVal value As DataTable)
    '        dt = value
    '        dgvDados.DataSource = dt
    '    End Set
    'End Property

    Dim _frm As frmPadraoCadastroDados = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property Formulario() As frmPadraoCadastroDados
        Get
            Return _frm
        End Get
        Set(ByVal value As frmPadraoCadastroDados)
            _frm = value
        End Set
    End Property

    'Dim _frmPai As frmPadraoCadastroDados = Nothing
    '<System.ComponentModel.Category("FeedBack")> _
    'Public Property FormularioPai() As frmPadraoCadastroDados
    '    Get
    '        Return _frmPai
    '    End Get
    '    Set(ByVal value As frmPadraoCadastroDados)
    '        _frmPai = value
    '    End Set
    'End Property

    'Dim _frmPaiCad As frmPadraoCadastro = Nothing
    '<System.ComponentModel.Category("FeedBack")> _
    'Public Property FormularioPaiCad() As frmPadraoCadastro
    '    Get
    '        Return _frmPaiCad
    '    End Get
    '    Set(ByVal value As frmPadraoCadastro)
    '        _frmPaiCad = value
    '    End Set
    'End Property

    Dim _editar As Boolean = True
    <System.ComponentModel.Category("FeedBack")> _
    Public Property liberaEditar() As Boolean
        Get
            Return _editar
        End Get
        Set(ByVal value As Boolean)
            _editar = value
            btnEdit.Enabled = value
        End Set
    End Property

    Dim _inserir As Boolean = True
    <System.ComponentModel.Category("FeedBack")> _
    Public Property liberaInserir() As Boolean
        Get
            Return _inserir
        End Get
        Set(ByVal value As Boolean)
            _inserir = value
            btnAdd.Enabled = value
        End Set
    End Property

    Dim _veBarra As Boolean = True
    <System.ComponentModel.Category("FeedBack")> _
    Public Property visualizarBarra() As Boolean
        Get
            Return _veBarra
        End Get
        Set(ByVal value As Boolean)
            _veBarra = value
            pnlBarra.Visible = _veBarra
        End Set
    End Property

    Dim _txtPrint As String = ""
    <System.ComponentModel.Category("FeedBack")> _
    Public Property textPrint() As String
        Get
            Return _txtPrint
        End Get
        Set(ByVal value As String)
            _txtPrint = value
            If value = "" Then
                ToolTip1.SetToolTip(btnPrint, "Imprimir")
            Else
                ToolTip1.SetToolTip(btnPrint, _txtPrint)
            End If
        End Set
    End Property

    Dim _excluir As Boolean = True
    <System.ComponentModel.Category("FeedBack")> _
    Public Property liberaExcluir() As Boolean
        Get
            Return _excluir
        End Get
        Set(ByVal value As Boolean)
            _excluir = value
            btndel.Enabled = value
        End Set
    End Property

    Dim _objRow(_tam) As Object
    <System.ComponentModel.Category("FeedBack")> _
    Public Property Linha() As Object
        Get
            Return _objRow
        End Get
        Set(ByVal value As Object)
            _objRow = value
        End Set
    End Property

    Dim _objCol(_tam) As Object
    <System.ComponentModel.Category("FeedBack")> _
    Public Property Coluna() As Object
        Get
            Return _objCol
        End Get
        Set(ByVal value As Object)
            _objCol = value
        End Set
    End Property

    Dim _tam As Integer = 1
    <System.ComponentModel.Category("FeedBack")> _
    Public Property Tamanho() As Integer
        Get
            Return _tam
        End Get
        Set(ByVal value As Integer)
            _tam = value
        End Set
    End Property

    Dim _salvar As Boolean = False
    <System.ComponentModel.Category("FeedBack")> _
    Public Property Salvar() As Boolean
        Get
            Return _salvar
        End Get
        Set(ByVal value As Boolean)
            _salvar = value
        End Set
    End Property

    Dim _salvaInsere As Boolean = True
    <System.ComponentModel.Category("FeedBack")> _
    Public Property SalvarDadosForm() As Boolean
        Get
            Return _salvaInsere
        End Get
        Set(ByVal value As Boolean)
            _salvaInsere = value
        End Set
    End Property

    Private Sub dgvDados_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDados.CellEnter
        If campoID <> "" Then
            _id = dgvDados.CurrentRow.Cells(campoID).Value
        Else
            MsgBox("Informe a Propriedade do ID!", MsgBoxStyle.Critical)
        End If
        RaiseEvent aoEntrarLinha(_id)
    End Sub

    Private Sub insere()
        If _inserir Then
            cancelaOperacao = False
            RaiseEvent change()
            If cancelaOperacao = False Then
                RaiseEvent antesDeInserir(_id)
                If cancelaOperacao = False Then
                    _frm.ID = -1
                    _frm.ShowDialog()
                    CarregaGrid()
                    RaiseEvent executaAcao()
                End If
            End If
        End If
    End Sub

    Private Sub CarregaGrid()
        If Me.dgvDados.RowCount > 0 AndAlso _salvar Then
            Me.dgvDados.Rows.Add(_objRow)
        ElseIf _objCol.Length > 1 AndAlso _salvar Then
            Me.dgvDados.Columns.Clear()
            For i As Integer = 0 To _tam - 1
                Me.dgvDados.Columns.Add(_objCol(i), _objCol(i))
            Next
            Me.dgvDados.Rows.Clear()
            Me.dgvDados.Rows.Add(_objRow)
        ElseIf Me.dgvDados.RowCount = 0 Then
            Me.dgvDados.Rows.Clear()
            Me.dgvDados.Columns.Clear()
        End If
        _salvar = False
    End Sub

    Private Sub edita()
        If _editar Then
            cancelaOperacao = False
            RaiseEvent change()
            If cancelaOperacao = False Then
                RaiseEvent antesDeEditar(_id)
                If cancelaOperacao = False Then
                    For i As Integer = 0 To _tam - 1
                        _objRow(i) = Me.dgvDados.CurrentRow.Cells(i).Value
                    Next
                    _frm.Editar(1)
                    _frm.ShowDialog()
                    CarregaGrid()
                    RaiseEvent executaAcao()
                End If
            End If
        End If
    End Sub

    Private Sub exclui()
        If _excluir Then
            cancelaOperacao = False
            RaiseEvent change()
            If cancelaOperacao = False Then
                If MessageBox.Show("Deseja Realmente Excluir esse Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    RaiseEvent antesDeExcluir(_id)
                    If cancelaOperacao = False Then
                        _frm.Parametro = _par
                        _frm.ID = IDItem
                        Me.dgvDados.Rows.RemoveAt(Me.dgvDados.CurrentRow.Index)
                        RaiseEvent executaAcao()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        insere()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        edita()
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        exclui()
    End Sub

    Private Sub dgvDados_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDados.CellMouseDoubleClick
        edita()
    End Sub

    Public Sub SETKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Insert Then
            insere()
        ElseIf e.KeyCode = Keys.Home Then
            edita()
        ElseIf e.KeyCode = Keys.Delete Then
            exclui()
        ElseIf e.KeyCode = Keys.Pause Then
            imprimi()
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        imprimi()
    End Sub

    Private Sub imprimi()
        If btnPrint.Visible = True AndAlso _id <> -1 Then
            'RaiseEvent change()
            RaiseEvent Imprimir(_id)
            ' RaiseEvent executaAcao()
        End If
    End Sub
End Class
