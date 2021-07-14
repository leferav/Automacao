Public Class fbLookUpMultiSelect

    Dim _listID As New List(Of Integer)
    Friend WithEvents _ID As New TextBox
    Dim _tabela As String
    Dim _filtro As String
    Dim _campoValor As String
    Dim _campoTexto As String
    Dim _campoPesquisa As String
    Dim _campoRel As String
    Dim _recebIDEdit As String = ""
    Dim _dataTable As DataTable
    Dim _paiRel As String
    Dim _campoOrdem As String
    Dim _filtroPesquisa As String

    <System.ComponentModel.Category("FeedBack")> _
    Public Event atualizarDTS()

    <System.ComponentModel.Category("FeedBack")> _
   Public Event Selecionando()

    <System.ComponentModel.Category("FeedBack")> _
     Public Event antesDeAbrir()

    Public Sub New()
        InitializeComponent()
        _ID.Text = "-1"
        txt.Text = ""
        AddHandler Me.txt.TextChanged, AddressOf Me.alteraValor
    End Sub

    Protected Sub alteraValor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent Selecionando()
    End Sub

    Private Sub fbLookUp_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled = True Then
            Me.txt.BackColor = Color.WhiteSmoke
        Else
            Me.txt.BackColor = Color.FromArgb(255, 212, 208, 200)
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        RaiseEvent antesDeAbrir()
        If Me.Height = 320 Then
            Me.Height = 20
        Else
            Me.BringToFront()
            Me.Height = 320
            carregaTabela()
        End If
    End Sub

    Private Sub FbButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FbButton2.Click
        ckeckGrid(False)
        _ID.Text = "-1"
        _listID.Clear()
        setaID()
    End Sub

    Private Sub ckeckGrid(ByVal valor As Boolean)
        For Each r As DataGridViewRow In dgvDados.Rows
            r.Cells("ck").Value = valor
            If valor = True Then
                _listID.Add(r.Cells(_campoValor).Value)
                setaID()
            End If
        Next
    End Sub

    Private Sub setaID()
        If _listID.Count = 0 Then
            _ID.Text = "-1"
        Else
            _ID.Text = ""
            For Each i As Integer In _listID
                If _ID.Text = "" Then
                    _ID.Text += i.ToString()
                Else
                    _ID.Text += "," + i.ToString()
                End If
            Next
        End If
        If _ID.Text = "-1" Then
            txt.Text = ""
        Else
            txt.Text = _ID.Text
        End If
    End Sub

    Private Sub FbButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FbButton3.Click
        _listID.Clear()
        ckeckGrid(True)
    End Sub

    Private Sub FbButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FbButton1.Click
        Me.Height = 20
    End Sub

    Private Sub fbLookUpMultiSelect_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.Height = 20
    End Sub

    Private Sub fbLookUpMultiSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        If _ID.Text = "" Then
            _ID.Text = "-1"
            txt.Text = ""
        End If
        Me.Height = 20
    End Sub

    Dim habilitaProcura As Boolean = True
    Public Sub carregaTabela(Optional ByVal _IDRecebSel As String = "")
        habilitaProcura = False
        Dim ssql As String = "SELECT "
        If _campoTexto = _campoValor Then _campoValor = "ID"
        ssql += _campoValor + ","
        ssql += _campoTexto
        ssql += " FROM " + _tabela
        If _IDRecebSel = "" Then
            If campoRelacionamento <> "" AndAlso _paiRel <> "" Then ssql += " WHERE " + campoRelacionamento + " = " + _paiRel + " "
            If _filtro <> "" Then
                ssql += IIf(ssql.Contains("WHERE"), " AND ", " WHERE ") + _filtro
            End If
            If _campoPesquisa <> "" AndAlso _filtroPesquisa <> "" Then
                ssql += IIf(ssql.Contains("WHERE"), " AND ", " WHERE ") + _campoPesquisa + " LIKE '%" + _filtroPesquisa + "%' "
            End If
        Else
            ssql += " WHERE " + _campoValor + " = " + _IDRecebSel
        End If
        If _campoOrdem <> "" Then
            ssql += " ORDER BY " + _campoTexto
        Else
            ssql += " ORDER BY " + _campoValor
        End If

        _dataTable = fbConnection.executaSelect(ssql)
        dgvDados.DataSource = _dataTable
        setaCheck()
        habilitaProcura = True
        _recebIDEdit = ""
    End Sub

    Private Sub setaCheck()
        If _listID.Count > 0 Then
            For Each r As DataGridViewRow In dgvDados.Rows
                If _listID.Contains(r.Cells(_campoValor).Value) Then
                    r.Cells("ck").Value = True
                End If
            Next
        End If
    End Sub

    <System.ComponentModel.Category("FeedBack")> _
   Public Property TabelaRelacionamento() As String
        Get
            Return _tabela
        End Get
        Set(ByVal value As String)
            _tabela = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property campoSelecionavel() As String
        Get
            Return _campoTexto
        End Get
        Set(ByVal value As String)
            _campoTexto = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
   Public Property campoPesquisa() As String
        Get
            Return _campoPesquisa
        End Get
        Set(ByVal value As String)
            _campoPesquisa = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property campoID() As String
        Get
            Return _campoValor
        End Get
        Set(ByVal value As String)
            _campoValor = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
   Public Property campoOrdem() As String
        Get
            Return _campoOrdem
        End Get
        Set(ByVal value As String)
            _campoOrdem = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property campoRelacionamento() As String
        Get
            Return _campoRel
        End Get
        Set(ByVal value As String)
            _campoRel = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property ValorRelacionamento() As String
        Get
            Return _paiRel
        End Get
        Set(ByVal value As String)
            _paiRel = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property ValorSelecionado() As String
        Get
            Return _ID.Text
        End Get
        Set(ByVal value As String)
            _ID.Text = value
            If value <> "-1" Then
                _recebIDEdit = value
                carregaTabela(_ID.Text)
            End If
        End Set
    End Property

    Private Sub dgvDados_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDados.DataSourceChanged
        RaiseEvent atualizarDTS()
    End Sub
   
    Private Sub dgvDados_selecionaCol(ByVal row As System.Windows.Forms.DataGridViewRow) Handles dgvDados.selecionaCol
        If row.Cells("ck").Value = True Then
            If Not _listID.Contains(row.Cells(_campoValor).Value) Then
                _listID.Add(row.Cells(_campoValor).Value)
            End If
        Else
            If _listID.Contains(row.Cells(_campoValor).Value) Then
                _listID.Remove(row.Cells(_campoValor).Value)
            End If
        End If
        setaID()
    End Sub

    Private Sub FbButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FbButton4.Click
        If _campoPesquisa <> "" Then
            carregaTabela()
        Else
            MsgBox("Campo Pesquisa Não Definido")
        End If
    End Sub

    Private Sub FbTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FbTextBox1.TextChanged
        _filtroPesquisa = FbTextBox1.Text
    End Sub

    Private Sub _ID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _ID.TextChanged
        txt.Text = _ID.Text
    End Sub
End Class
