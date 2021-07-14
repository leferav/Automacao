﻿Public Class fbGridDados

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        btnAdd.FlatStyle = FlatStyle.Standard
        btndel.FlatStyle = FlatStyle.Standard
        btnEdit.FlatStyle = FlatStyle.Standard
        btnPrint.FlatStyle = FlatStyle.Standard
        lblTo.Visible = _totRegVis
        lblTotReg.Visible = _totRegVis
        ' Add any initialization after the InitializeComponent() call.
        Me.dgvDados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        Me.dgvDados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        Me.dgvDados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvDados.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
        Me.dgvDados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvDados.ColumnHeadersDefaultCellStyle.Font = New Font("verdana", 8.25, FontStyle.Bold, GraphicsUnit.Point)
    End Sub

    Public cancelaOperacao As Boolean = False

    <System.ComponentModel.Category("FeedBack")> _
    Public Event ClicarCelula(ByVal e As DataGridViewCellEventArgs)

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

    <System.ComponentModel.Category("FeedBack")>
    Public Event depoisdeSetarID()

    <System.ComponentModel.Category("FeedBack")>
    Public Event CellEndEdit()


    Dim _totRegVis As Boolean = True
    <System.ComponentModel.Category("FeedBack")>
    Public Property TotalRegistrosVisivel() As Boolean
        Get
            Return _totRegVis
        End Get
        Set(ByVal value As Boolean)
            _totRegVis = value
            lblTo.Visible = value
            lblTotReg.Visible = value
        End Set
    End Property

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

    Dim _idPai As Integer = -1
    <System.ComponentModel.Category("FeedBack")> _
    Public Property IDRelacionamento() As Integer
        Get
            Return _idPai
        End Get
        Set(ByVal value As Integer)
            _idPai = value
            If _idPai = -1 Then
                btnAdd.Enabled = SalvarDadosForm
                btndel.Enabled = False
                btnEdit.Enabled = False
            Else
                btnAdd.Enabled = True
                btndel.Enabled = True
                btnEdit.Enabled = True
                If Not IsNothing(_frm) Then
                    _frm.Parametro = _par
                    _frm.ID = -1
                    _frm.IDRelacionamento = _idPai
                    _frm.Carrega()
                    Me.DataTable = _frm.Dados
                End If
                If Me.DataTable Is Nothing OrElse Me.DataTable.Rows.Count < 1 Then
                    Me._id = -1
                End If
                RaiseEvent depoisdeSetarID()
            End If
        End Set
    End Property

    Dim dt As DataTable
    <System.ComponentModel.Category("FeedBack")> _
    Public Property DataTable() As DataTable
        Get
            Return dt
        End Get
        Set(ByVal value As DataTable)
            dt = value
            dgvDados.DataSource = dt
        End Set
    End Property

    Dim _frm As frmPadraoCadastroDados = Nothing
    <System.ComponentModel.Category("FeedBack")>
    Public Property Formulario() As frmPadraoCadastroDados
        Get
            Return _frm
        End Get
        Set(ByVal value As frmPadraoCadastroDados)
            _frm = value
        End Set
    End Property

    Dim _frmPai As frmPadraoCadastroDados = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property FormularioPai() As frmPadraoCadastroDados
        Get
            Return _frmPai
        End Get
        Set(ByVal value As frmPadraoCadastroDados)
            _frmPai = value
        End Set
    End Property

    Dim _frmPaiCad As frmPadraoCadastro = Nothing
    <System.ComponentModel.Category("FeedBack")> _
    Public Property FormularioPaiCad() As frmPadraoCadastro
        Get
            Return _frmPaiCad
        End Get
        Set(ByVal value As frmPadraoCadastro)
            _frmPaiCad = value
        End Set
    End Property

    Dim _editar As Boolean = True
    <System.ComponentModel.Category("FeedBack")> _
    Public Property liberaEditar() As Boolean
        Get
            Return _editar
        End Get
        Set(ByVal value As Boolean)
            _editar = value
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

    Dim _salvaInsere As Boolean = False
    <System.ComponentModel.Category("FeedBack")> _
    Public Property SalvarDadosForm() As Boolean
        Get
            Return _salvaInsere
        End Get
        Set(ByVal value As Boolean)
            _salvaInsere = value
            btnAdd.Enabled = value
        End Set
    End Property

    Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellClick
        RaiseEvent ClicarCelula(e)
    End Sub

    Private Sub dgvDados_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDados.CellEnter
        If campoID <> "" Then
            _id = dgvDados.CurrentRow.Cells(campoID).Value
        Else
            MessageBox.Show("Informe a Propriedade do ID!", "Aviso, ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        RaiseEvent aoEntrarLinha(_id)
    End Sub

    Private Sub insere()
        Try
            If _salvaInsere = True And _idPai = -1 Then
                If _frmPai IsNot Nothing Then
                    If _usarSalva = True Then
                        _frmPai.Salvar(_idPai)
                    Else
                        _frmPai.ID = _idPai
                        _frmPai.salvandoDados()
                    End If
                ElseIf _frmPaiCad IsNot Nothing Then
                    _frmPaiCad.Salvar(_idPai)
                End If
            End If
            If _idPai <> -1 AndAlso _inserir = True Then
                cancelaOperacao = False
                RaiseEvent change()
                If cancelaOperacao = False Then
                    RaiseEvent antesDeInserir(_id)
                    If cancelaOperacao = False Then
                        If Not IsNothing(_frm) Then
                            Try
                                _frm.Parametro = _par
                                _frm.ID = -1
                                _frm.IDRelacionamento = _idPai
                                _frm.aoIniciarTela()
                                _frm.ShowDialog()
                                Me.DataTable = _frm.Dados
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                        End If
                        RaiseEvent executaAcao()
                    End If
                End If
            End If
        Catch : End Try
        'MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try
    End Sub

    Private Sub edita()
        If _idPai <> -1 AndAlso _editar = True AndAlso _id <> -1 Then
            cancelaOperacao = False
            RaiseEvent change()
            If cancelaOperacao = False Then
                RaiseEvent antesDeEditar(_id)
                If cancelaOperacao = False Then
                    If Not IsNothing(_frm) Then
                        _frm.Parametro = _par
                        _frm.ID = IDItem
                        _frm.IDRelacionamento = _idPai
                        _frm.aoIniciarTela()
                        _frm.ShowDialog()
                        Me.DataTable = _frm.Dados
                    End If
                    RaiseEvent executaAcao()
                End If
            End If
        End If
    End Sub

    Private Sub exclui()
        If _idPai <> -1 AndAlso _excluir = True AndAlso _id <> -1 Then
            cancelaOperacao = False
            RaiseEvent change()
            If cancelaOperacao = False Then
                If MessageBox.Show("Deseja Realmente Excluir esse Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    RaiseEvent antesDeExcluir(_id)
                    If cancelaOperacao = False Then
                        If Not IsNothing(_frm) Then
                            _frm.Parametro = _par
                            _frm.ID = IDItem
                            _frm.IDRelacionamento = _idPai
                            _frm.Excluir(IDItem)
                            _frm.Carrega()
                            Me.DataTable = _frm.Dados
                        End If
                        If Me.DataTable Is Nothing OrElse Me.DataTable.Rows.Count < 1 Then
                            Me._id = -1
                        End If
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

    Public Sub Carrega()
        If _idPai <> -1 Then
            If Not IsNothing(_frm) Then
                _frm.Parametro = _par
                _frm.ID = IDItem
                _frm.IDRelacionamento = _idPai
                _frm.Carrega()
                Me.DataTable = _frm.Dados
            End If
            If Me.DataTable Is Nothing OrElse Me.DataTable.Rows.Count < 1 Then
                    Me._id = -1
                End If
            Else
                Me.DataTable = Nothing
        End If
    End Sub

    Private Sub dgvDados_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDados.DataSourceChanged
        If Me.dgvDados.Columns.Count > 0 Then
            If Me.dgvDados.Columns("ID") IsNot Nothing Then
                Me.dgvDados.Columns("ID").Visible = False
            End If
            RaiseEvent atualizaDts(Me.dgvDados)
        End If
        lblTo.Text = FormatNumber(dgvDados.RowCount, 0)
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
        If _idPai <> -1 AndAlso btnPrint.Visible = True AndAlso _id <> -1 Then
            'RaiseEvent change()
            RaiseEvent Imprimir(_id)
            ' RaiseEvent executaAcao()
        End If
    End Sub

    Private Sub dgvDados_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellEndEdit
        RaiseEvent CellEndEdit()
    End Sub

End Class

