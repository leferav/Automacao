Public Class fbComboBox
    Inherits ComboBox

    Dim _tabela As String
    Dim _filtro As String
    Dim _campoValor As String
    Dim _campoTexto As String
    Dim _campoOrdem As String
    Dim _campoSql As String
    Dim _campoRel As String
    Dim _paiRel As String
    Dim _vSelect As String
    Dim _carregaParametro As Boolean = False

    Public carregou As Boolean = False

    Friend WithEvents _ID As New TextBox
    Dim _recebIDEdit As String = ""

    <System.ComponentModel.Category("FeedBack")>
    Public Event Selecionando()

    Public Sub New()
        Me.FlatStyle = FlatStyle.Flat
        'Me.AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
        'Me.AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
        'Me.DropDownStyle = ComboBoxStyle.DropDownList

        Me.DropDownStyle = ComboBoxStyle.DropDownList
        Me.AutoCompleteSource = AutoCompleteSource.ListItems
        Me.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Me.DB = New StandardControlDB(Me, "-1")
        _ID.Text = "-1"
        carregou = False
        AddHandler Me._ID.TextChanged, AddressOf Me.alteraValor
    End Sub

    Private Sub fbComboBox_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        carregou = False
    End Sub

    <System.ComponentModel.Category("FeedBack")>
    Public Property carregaClick As Boolean = True



    Protected Sub alteraValor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent Selecionando()
    End Sub

    Private Sub COMBO_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DropDown
        carregaDados()
    End Sub

    Private Sub carregaDados(Optional ByVal _IDRecebido As String = "")
        If _tabela <> "" AndAlso carregou = False Then
            Try
                If _tabela = "TB_PARAMETRO" Then
                    carregaParametro()
                Else
                    carregaTabela(_IDRecebido)
                End If
                carregou = True
            Catch ex As Exception
                MsgBox("Erro ao Carregar os Dados!" + ex.Message)
                carregou = False
            End Try

        Else
            Try
                If Me.SelectedValue <> ValorSelecionado Then Me.SelectedValue = ValorSelecionado
            Catch : End Try
        End If
    End Sub

    Dim habilitaProcura As Boolean = True

    <System.ComponentModel.Category("FeedBack")>
    Public Property comDistinct As Boolean = False
    Public Sub carregaTabela(Optional ByVal _IDRecebSel As String = "")
        habilitaProcura = False
        Dim ssql As String = "SELECT "
        If comDistinct = True Then ssql += " DISTINCT "
        If _campoTexto = _campoValor Then _campoValor = "ID"
        ssql += _campoValor + ","
        If _campoSql = "" Then
            ssql += "convert(nvarchar(MAX)," + _campoTexto + ") as " + _campoTexto
        Else
            ssql += "(" + _campoSql + ") as " + _campoTexto
        End If
        ssql += " FROM " + _tabela
        If (_tabela.ToUpper.Contains("JOIN") = False) Then ssql += " WITH (NOLOCK)"
        ssql += IIf(campoRelacionamento <> "", " WHERE " + campoRelacionamento + " = " + _paiRel + " ", "")
        If _filtro <> "" Then
            If _campoSql <> "" Then
                ssql += IIf(ssql.Replace(_campoSql, "").Contains("WHERE"), " AND ", " WHERE ") + _filtro
            Else
                ssql += IIf(ssql.Contains("WHERE"), " AND ", " WHERE ") + _filtro
            End If
        End If
        If _campoTexto <> "" Then
            If _campoOrdem <> "" Then
                ssql += " ORDER BY " + _campoOrdem
            Else
                ssql += " ORDER BY " + _campoTexto
            End If
        Else
            ssql += " ORDER BY " + _campoValor
        End If

        Dim dt As DataTable = fbConnection.executaSelect(ssql)
        Dim r As DataRow = dt.NewRow
        r.Item(0) = "-1"
        r.Item(1) = _vSelect
        dt.Rows.InsertAt(r, 0)
        Dim oldValue = ValorSelecionado
        Me.DataSource = dt
        Me.ValueMember = _campoValor.Replace("x.", "")
        Me.DisplayMember = _campoTexto
        If Me.SelectedValue <> oldValue Then Me.SelectedValue = oldValue
        habilitaProcura = True
        _recebIDEdit = ""
    End Sub

    Private Sub carregaParametro()
        habilitaProcura = False
        Dim TB As New DataTable
        TB.Columns.Add("Item")
        TB.Columns.Add("Valor")
        TB.Rows.Clear()

        Dim ssql As String = "SELECT "
        If _campoTexto = _campoValor Then _campoValor = "ID"
        If _campoValor = "" Then _campoValor = "ID"
        ssql += _campoValor + "," + _campoTexto + " FROM " + _tabela
        ssql += IIf(campoRelacionamento <> "", " WHERE " + campoRelacionamento + " = '" + _paiRel + "' ", "")
        Dim dt As DataTable = fbConnection.executaSelect(ssql)

        Dim obj1(1) As Object
        obj1(0) = "-1"
        obj1(1) = _vSelect
        TB.Rows.Add(obj1)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Dim obj() = dt.Rows(0).Item("VALOR").ToString().Split(";")

            For i As Integer = 0 To obj.Length - 1
                If obj(i).Contains("-") Then
                    obj1(0) = Trim(obj(i).Split("-")(0))
                    obj1(1) = Trim(obj(i).Split("-")(1))
                    If carrega2Parametro = True Then
                        obj1(1) = obj1(0).ToString + " - " + obj1(1).ToString
                    End If
                    TB.Rows.Add(obj1)
                End If
            Next
        End If
        Dim oldValue = ValorSelecionado
        Me.DataSource = TB
        Me.ValueMember = "Item"
        Me.DisplayMember = "Valor"
        If Me.SelectedValue <> oldValue Then Me.SelectedValue = oldValue
        habilitaProcura = True
    End Sub

    Private Sub fbComboBox_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled Then
            If Me._req Then
                Me.BackColor = Color.LightBlue
            Else
                Me.BackColor = Color.White
            End If
        Else
            Me.BackColor = Color.FromArgb(255, 212, 208, 200)
        End If
    End Sub

    Private Sub COMBO_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedValueChanged
        If habilitaProcura = True Then
            If Me.SelectedValue IsNot Nothing AndAlso Me.SelectedValue.ToString() <>
            "System.Data.DataRowView" Then
                If _ID.Text <> Me.SelectedValue Then _ID.Text = Me.SelectedValue
            Else
                If _ID.Text <> "-1" Then _ID.Text = "-1"
            End If
        End If
    End Sub

    <System.ComponentModel.Category("FeedBack")>
    Public Property DB As StandardControlDB

    <System.ComponentModel.Category("FeedBack")>
    Public Property carrega2Parametro() As Boolean
        Get
            Return _carregaParametro
        End Get
        Set(ByVal value As Boolean)
            _carregaParametro = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property TabelaRelacionamento() As String
        Get
            Return _tabela
        End Get
        Set(ByVal value As String)
            _tabela = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property campoSelecionavel() As String
        Get
            Return _campoTexto
        End Get
        Set(ByVal value As String)
            _campoTexto = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property campoOrdem() As String
        Get
            Return _campoOrdem
        End Get
        Set(ByVal value As String)
            _campoOrdem = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property campoSql() As String
        Get
            Return _campoSql
        End Get
        Set(ByVal value As String)
            _campoSql = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property campoID() As String
        Get
            Return _campoValor
        End Get
        Set(ByVal value As String)
            _campoValor = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property campoRelacionamento() As String
        Get
            Return _campoRel
        End Get
        Set(ByVal value As String)
            If value <> _campoRel Then
                carregou = False
                _campoRel = value
            End If
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property ValorRelacionamento() As String
        Get
            Return _paiRel
        End Get
        Set(ByVal value As String)
            If value <> _paiRel Then
                carregou = False
                _paiRel = value
            End If
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property ValorSelecionado() As String
        Get
            Return _ID.Text
        End Get
        Set(ByVal value As String)
            _ID.Text = value
            If value <> "-1" Then
                _recebIDEdit = value
                carregaDados(_ID.Text)
            Else
                If Me.DataSource Is Nothing Then
                    setaText()
                Else
                    Me.SelectedValue = "-1"
                End If
            End If
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property TextoSelecionar() As String
        Get
            Return _vSelect
        End Get
        Set(ByVal value As String)
            _vSelect = value
            If Me.DataSource Is Nothing Then
                setaText()
            Else
                Me.SelectedValue = "-1"
            End If
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property Filtro() As String
        Get
            Return _filtro
        End Get
        Set(ByVal value As String)
            If value <> _filtro Then
                carregou = False
                _filtro = value
            End If
        End Set
    End Property


    Private Sub setaText()
        Dim dt = New DataTable
        dt.Columns.Add("Valor")
        dt.Columns.Add("Texto")
        dt.Rows.Clear()
        Dim Tobj(1) As Object
        Tobj(0) = "-1"
        Tobj(1) = _vSelect
        dt.Rows.Add(Tobj)
        Me.DataSource = dt
        Me.ValueMember = "Valor"
        Me.DisplayMember = "Texto"
        Me.SelectedValue = "-1"
        carregou = False
    End Sub

    Dim _req As Boolean = False
    <System.ComponentModel.Category("FeedBack")>
    Public Property Requerido() As Boolean
        Get
            Return _req
        End Get
        Set(ByVal value As Boolean)
            _req = value
            If _req = True AndAlso Me.Enabled Then
                Me.BackColor = Color.LightBlue
            ElseIf Me.Enabled Then
                If Me.BackColor = Color.LightBlue Then
                    Me.BackColor = Color.White
                End If
            End If
        End Set
    End Property

    Dim _valor As Object
    <System.ComponentModel.Category("FeedBack")>
    Public Property Valor() As Object
        Get
            Return _valor
        End Get
        Set(ByVal value As Object)
            _valor = value
        End Set
    End Property

    Dim _campo As String = ""
    <System.ComponentModel.Category("FeedBack")>
    Public Property Campo() As String
        Get
            Return _campo
        End Get
        Set(ByVal value As String)
            _campo = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property valorVazio() As Object = -1

    Dim _NomeCampoMsg As String = ""
    <System.ComponentModel.Category("FeedBack")>
    Public Property NomeCampoMsg() As String
        Get
            If _NomeCampoMsg = "" Then _NomeCampoMsg = Me.Name.Replace("cbb", "")
            Return _NomeCampoMsg
        End Get
        Set(ByVal value As String)
            _NomeCampoMsg = value
        End Set
    End Property

    Dim _controlDB As fbControler
    <System.ComponentModel.Category("FeedBack")>
    Public Property ControlDB() As fbControler
        Get
            Return _controlDB
        End Get
        Set(ByVal value As fbControler)
            _controlDB = value
            If _controlDB IsNot Nothing Then
                _controlDB.listControles.Add(Me)
            End If
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property Ordena() As String

    <System.ComponentModel.Category("FeedBack")>
    Public Property campoSqlID() As String

    <System.ComponentModel.Category("FeedBack")>
    Public Property AgrupadoPor() As String

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'fbComboBox
        '
        Me.ResumeLayout(False)

    End Sub
End Class
