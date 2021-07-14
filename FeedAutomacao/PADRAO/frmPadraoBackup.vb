Imports System.IO
Imports System.Reflection

Public Class frmPadraoBackup
    Dim _usuario As String = ""
    Dim _emp As String = ""
    Dim _IDUsuario As Integer = -1
    Dim _fun As String = ""
    Dim _IDUsuarioPessoa As Integer = -1
    Dim _IDEmp As Integer = -1
    Dim _perm As New clPermissao
    Dim _Lperm As New List(Of clPermissao)
    Dim _dtZim As Date


    Public Property CodFilial As String = ""

    Public Property RemocaoMultipla As Boolean = False

    <System.ComponentModel.Category("FeedBack")>
    Public Property DATA_SERVER() As Date
        Get
            Return _dtZim
        End Get
        Set(ByVal value As Date)
            _dtZim = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property dataFat As Date

    <System.ComponentModel.Category("FeedBack")>
    Public Property IDUsuario() As Integer
        Get
            Return _IDUsuario
        End Get
        Set(ByVal value As Integer)
            _IDUsuario = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property IDUsuarioPessoa() As Integer
        Get
            Return _IDUsuarioPessoa
        End Get
        Set(ByVal value As Integer)
            _IDUsuarioPessoa = value
            If _IDUsuarioPessoa <> -1 Then
                Dim dt = fbConnection.executaSelect("SELECT Nome FROM TB_PESSOA WHERE ID = " + _IDUsuarioPessoa.ToString())
                If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                    _fun = dt.Rows(0).Item(0)
                End If
            End If
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property travaFeedBack As Boolean = False

    Public Property LogoEmpresaByte As Byte() = Nothing

    <System.ComponentModel.Category("FeedBack")>
    Public Property IDEmpresa() As Integer
        Get
            Return _IDEmp
        End Get
        Set(ByVal value As Integer)
            _IDEmp = value
            If _IDEmp <> -1 Then
                Dim dt = fbConnection.executaSelect("SELECT Nome, Imagem, IDGrupo,ISNULL(FeedFisOK,0)," +
                                                                    " ISNULL(codExterno,'') as CodigoFilial,  " +
                                                                    " ISNULL(travaFeedBack,0) as travaFeedBack  " +
                                                                    " FROM TB_EMPRESA WHERE ID = " + _IDEmp.ToString())
                If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                    _emp = dt.Rows(0).Item(0)
                    _retIDGrupo = dt.Rows(0).Item(2)
                    _efiscal = dt.Rows(0).Item(3)
                    If Not IsDBNull(dt.Rows(0).Item(1)) Then
                        LogoEmpresaByte = dt.Rows(0).Item(1)
                        Dim stmBLOBData As New MemoryStream(LogoEmpresaByte, True)
                        If stmBLOBData IsNot Nothing Then
                            _retImg = Image.FromStream(stmBLOBData)
                        Else
                            _retImg = Nothing
                        End If
                    End If
                    CodFilial = dt.Rows(0).Item("CodigoFilial")
                    travaFeedBack = dt.Rows(0).Item("travaFeedBack")
                End If
            End If
        End Set
    End Property

    Dim _retIDGrupo As Integer = -1
    Public ReadOnly Property IDGrupoEmpresa() As Integer
        Get
            Return _retIDGrupo
        End Get
    End Property

    Dim _efiscal As Boolean = False
    Public ReadOnly Property eFiscal() As Boolean
        Get
            Return _efiscal
        End Get
    End Property

    Dim _retImg As Image = Nothing
    Public ReadOnly Property ImageEmp() As Image
        Get
            Return _retImg
        End Get
    End Property

    Public ReadOnly Property NomeEmpresa() As String
        Get
            Return _emp
        End Get
    End Property

    Public ReadOnly Property NomeFuncionario() As String
        Get
            Return _fun
        End Get
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property Permissao() As clPermissao
        Get
            Return _perm
        End Get
        Set(ByVal value As clPermissao)
            _perm = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property listPermissao() As List(Of clPermissao)
        Get
            Return _Lperm
        End Get
        Set(ByVal value As List(Of clPermissao))
            _Lperm = value
        End Set
    End Property

    Dim _truncar As Boolean
    Public Property TruncarVol() As Boolean
        Get
            Return _truncar
        End Get
        Set(ByVal value As Boolean)
            _truncar = value
        End Set
    End Property

    Dim _arredondaPeso As Boolean
    Public Property arredonadaPeso() As Boolean
        Get
            Return _arredondaPeso
        End Get
        Set(ByVal value As Boolean)
            _arredondaPeso = value
        End Set
    End Property

    Dim _contratoAutomatico As Boolean
    Public Property contratoAutomatico() As Boolean
        Get
            Return _contratoAutomatico
        End Get
        Set(ByVal value As Boolean)
            _contratoAutomatico = value
        End Set
    End Property

    Dim _pesoTiket As Double = 0
    Public Property pesoTiketDivide() As Double
        Get
            Return _pesoTiket
        End Get
        Set(ByVal value As Double)
            _pesoTiket = value
        End Set
    End Property

    Dim _IDUsuarioTipo As Integer = -1
    <System.ComponentModel.Category("FeedBack")>
    Public Property IDUsuarioTipo() As Integer
        Get
            Return _IDUsuarioTipo
        End Get
        Set(ByVal value As Integer)
            _IDUsuarioTipo = value
        End Set
    End Property

    Public Function retornaLogoFeed() As Byte()
        Dim ms As MemoryStream = New MemoryStream()
        My.Resources.feed.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
        Dim bytBLOBData(ms.Length - 1) As Byte
        ms.Position = 0
        ms.Read(bytBLOBData, 0, ms.Length)

        Return bytBLOBData
    End Function

    Private Function setaItem(ByVal item As String) As Boolean
        If item = "S" Then
            Return True
        ElseIf item = "N" Then
            Return False
        End If
    End Function

    Public Sub setaVisForm(ByVal frm As frmPadrao, Optional ByVal hide As Boolean = False)
        'If hide = True Then
        '    frm.Close()
        '    'frm.Visible = False
        'Else
        '    'frm.Visible = True
        '    If frm.IsMdiChild = True Then
        '        frm.BringToFront()
        '        My.Forms.frmMain2.ActivateMdiChild(frm)
        '    Else
        '        frm.MdiParent = My.Forms.frmMain2
        '        Me.Cursor = Cursors.Arrow
        '        frm.Show()
        '    End If
        'End If
    End Sub

    Private Sub frmPadrao_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub


    Public Overridable Sub aoIniciarTela()

    End Sub

    Public Function salvaComTransaction(tableAdapter As Object, tabela As Object,
                                        Optional ByVal timeOut As Integer = 9000000) As Boolean
        Dim tableAdapterType As Type = tableAdapter.[GetType]()
        Dim adapter As SqlClient.SqlDataAdapter = DirectCast(tableAdapterType.GetProperty("Adapter",
                                       BindingFlags.Instance Or BindingFlags.NonPublic).GetValue(tableAdapter, Nothing),
                                        SqlClient.SqlDataAdapter)

        Dim conn As New SqlClient.SqlConnection(fbConnection.sCon.ConnectionString)

        Dim trans As SqlClient.SqlTransaction = Nothing
        Try
            conn.Open()
            trans = conn.BeginTransaction

            adapter.InsertCommand.Connection = trans.Connection
            adapter.UpdateCommand.Connection = trans.Connection
            adapter.DeleteCommand.Connection = trans.Connection

            adapter.InsertCommand.Transaction = trans
            adapter.UpdateCommand.Transaction = trans
            adapter.DeleteCommand.Transaction = trans

            adapter.InsertCommand.CommandTimeout = timeOut
            adapter.UpdateCommand.CommandTimeout = timeOut
            adapter.DeleteCommand.CommandTimeout = timeOut

            adapter.Update(tabela)

            trans.Commit()
        Catch
            trans.Rollback()
        Finally
            conn.Close()
        End Try
        Return True
    End Function

    Public Function salvaComTransactionMAXIDUsuario(tableAdapter As Object,
                                                    tabela As Object,
                                                    _IDUsuario As Integer,
                                                    Optional ByVal timeOut As Integer = 9000000) As Integer
        Dim iID As Integer = -1
        Dim tableAdapterType As Type = tableAdapter.[GetType]()
        Dim adapter As SqlClient.SqlDataAdapter = DirectCast(tableAdapterType.GetProperty("Adapter",
                                       BindingFlags.Instance Or BindingFlags.NonPublic).GetValue(tableAdapter, Nothing),
                                        SqlClient.SqlDataAdapter)

        Dim conn As New SqlClient.SqlConnection(fbConnection.sCon.ConnectionString)
        Dim trans As SqlClient.SqlTransaction = Nothing
        Try
            conn.Open()
            trans = conn.BeginTransaction

            adapter.InsertCommand.Connection = trans.Connection
            adapter.UpdateCommand.Connection = trans.Connection
            adapter.DeleteCommand.Connection = trans.Connection

            adapter.InsertCommand.Transaction = trans
            adapter.UpdateCommand.Transaction = trans
            adapter.DeleteCommand.Transaction = trans

            adapter.InsertCommand.CommandTimeout = timeOut
            adapter.UpdateCommand.CommandTimeout = timeOut
            adapter.DeleteCommand.CommandTimeout = timeOut

            adapter.Update(tabela)

            trans.Commit()

            iID = tableAdapter.MAXID(_IDUsuario)

        Catch
            trans.Rollback()
        Finally
            conn.Close()
        End Try
        Return iID
    End Function

End Class