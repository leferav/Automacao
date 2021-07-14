Imports System.ComponentModel
Public Class fbTextBoxSearch
    Inherits System.Windows.Forms.TextBox

    Private WithEvents myParentForm As Form
    Private WithEvents frmDropDown As Form
    Private MySuggestCollection As String()
    Private myDropDownFormCreated As Boolean = False
    Private strInputChars As String = String.Empty
    Private myCurrentSuggest As List(Of String) = Nothing
    Private MyAutoCompleteListShowKey As Keys = Keys.F3
    Private MyAutoCompleteControlMaxHeigh As Integer = 100
    Private mHandleKeyChar As Boolean = True

    Private _BuscaContains As Boolean = True
    Private _CaracterInicio As String = ""
    Private _CaracterFim As String = ""

    ''' <summary>
    ''' Event is fired after the List of current Suggest changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    <Description("Event is fired after the List of current Suggest changed"), Category("AutoComplete")>
    Public Event CurrentSuggestChanged(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Maximal heigh of the Autocomplete Control befor Scrollbar is shown
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Description("Maximal heigh for the Control befor Scrolling is activ"), Category("AutoComplete")>
    Public Property AutoCompleteControlMaxHeighBeforScrolling() As Integer
        Get
            Return MyAutoCompleteControlMaxHeigh
        End Get
        Set(ByVal value As Integer)
            MyAutoCompleteControlMaxHeigh = value
        End Set
    End Property

    ''' <summary>
    ''' Shortcut for displaying the Autocomplete Control
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Description("Shortcut for Displaying the Suggestcontrol with all Values"), Category("AutoComplete")>
    Public Property AutoCompleteListHotKey() As Keys
        Get
            Return MyAutoCompleteListShowKey
        End Get
        Set(ByVal value As Keys)
            MyAutoCompleteListShowKey = value
        End Set
    End Property

    ''' <summary>
    ''' Parent Windows Form from the UserControl
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This Property is Set in the HandleCreate Event of the Control</remarks>
    Public ReadOnly Property ParentForm As Form
        Get
            Return myParentForm
        End Get
    End Property

    ''' <summary>
    ''' Current Suggestion for the Input Value
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Description("Readonly List of String for the Current Suggests"), Category("AutoComplete")>
    Public ReadOnly Property CurrentSuggestCollection As String()
        Get
            If myCurrentSuggest Is Nothing Then
                Return Nothing
            Else
                Return myCurrentSuggest.ToArray
            End If
        End Get
    End Property

    ''' <summary>
    ''' Collection for the Autocomplette
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Description("String Collection that is used for the AutoComplete"), Category("AutoComplete")>
    Public Property AutoCompleteCollection() As String()
        Get
            Return MySuggestCollection
        End Get
        Set(ByVal value As String())
            MySuggestCollection = value
        End Set
    End Property


    ''' <summary>
    ''' Busca por Contains
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Description("Define se a busca vai ser por Contains ou Inicio da frase"), Category("AutoComplete")>
    Public Property BuscaContains As Boolean
        Get
            Return _BuscaContains
        End Get
        Set(ByVal value As Boolean)
            _BuscaContains = value
        End Set
    End Property


    ''' <summary>
    ''' Caracter Inicio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Description("Define o Inicio do Caractere (Para o Conteudo) que vai realmente para o TextBox, Ex (Email).: <"), Category("AutoComplete")>
    Public Property CaracterInicio As String
        Get
            Return _CaracterInicio
        End Get
        Set(ByVal value As String)
            _CaracterInicio = value
        End Set
    End Property

    ''' <summary>
    ''' Caracter Fim
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Description("Define o Fim do Caractere (Para o Conteudo) que vai realmente para o TextBox, Ex (Email).: >"), Category("AutoComplete")>
    Public Property CaracterFim As String
        Get
            Return _CaracterFim
        End Get
        Set(ByVal value As String)
            _CaracterFim = value
        End Set
    End Property


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If frmDropDown IsNot Nothing Then
                frmDropDown.Close()
                frmDropDown.Dispose()
                frmDropDown = Nothing
            End If
            If myParentForm IsNot Nothing Then
                myParentForm = Nothing
            End If
            MySuggestCollection = Nothing
            strInputChars = ""
            If myCurrentSuggest IsNot Nothing Then
                myCurrentSuggest.Clear()
                myCurrentSuggest = Nothing
            End If
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

#Region "AutoComplete"
    Private Sub CreateShowDropDownFrom()
        frmDropDown = New Form
        frmDropDown.Controls.Add(lbSuggest)
        frmDropDown.Controls(lbSuggest.Name).Dock = DockStyle.Fill
        frmDropDown.FormBorderStyle = FormBorderStyle.None
        frmDropDown.StartPosition = FormStartPosition.Manual
        Dim pScreen As Drawing.Point = Me.PointToScreen(Drawing.Point.Empty)
        pScreen.Y = (pScreen.Y + Me.Height) - 1
        pScreen.X = pScreen.X - 2
        frmDropDown.Location = pScreen
        frmDropDown.Width = Me.Width
        frmDropDown.Height = MyAutoCompleteControlMaxHeigh
        frmDropDown.TopMost = True
        frmDropDown.Show()
        myDropDownFormCreated = True
    End Sub

    Private Function CheckAutoCompleteActiv() As Boolean
        If MySuggestCollection IsNot Nothing AndAlso MySuggestCollection.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub UpdateSuggestListBox(Optional bShowFullList As Boolean = False)
        lbSuggest.Items.Clear()
        If bShowFullList Then
            If myCurrentSuggest Is Nothing Then
                myCurrentSuggest = New List(Of String)
            Else
                myCurrentSuggest.Clear()
            End If
            myCurrentSuggest.AddRange(MySuggestCollection)
        End If
        If myCurrentSuggest IsNot Nothing Then
            lbSuggest.Items.AddRange(myCurrentSuggest.ToArray)
            RaiseEvent CurrentSuggestChanged(Me, New EventArgs())
        End If
    End Sub

    Private Function CapturaValor(ByVal sVal As String) As String
        If _CaracterInicio <> "" AndAlso _CaracterFim <> "" AndAlso sVal.Contains(_CaracterInicio) AndAlso sVal.Contains(_CaracterFim) Then
            Return sVal.Substring(sVal.IndexOf(_CaracterInicio) + 1, (sVal.LastIndexOf(_CaracterFim) - sVal.IndexOf(_CaracterInicio)) - 1)
        Else
            Return sVal
        End If
    End Function

    Private Function CheckCharInSuggest(strChar As String) As Boolean
        If MySuggestCollection IsNot Nothing AndAlso Not (String.IsNullOrEmpty(strChar) OrElse strChar.Trim.Length = 0) Then
            strInputChars += strChar

            Return CheckInAutoCompleteCollection()
        Else
            Return False
        End If
    End Function

    Private Function HandleSpezialKeySuggest(kKey As Keys) As Boolean
        If MySuggestCollection IsNot Nothing Then
            If kKey = Keys.Back AndAlso strInputChars.Length > 0 Then
                strInputChars = strInputChars.Remove(strInputChars.Length - 1)
            Else
                Return False
            End If

            Return CheckInAutoCompleteCollection()
        Else
            Return False
        End If
    End Function

    Private Function CheckInAutoCompleteCollection() As Boolean
        If myCurrentSuggest Is Nothing Then
            myCurrentSuggest = New List(Of String)
        Else
            myCurrentSuggest.Clear()
        End If

        ''Without Linq
        'For Each dat As String In MySuggestCollection
        '    If dat.ToUpper.StartsWith(strInputChars.ToUpper) Then
        '        myCurrentSuggest.Add(dat)
        '    End If
        'Next

        'With Linq
        If _BuscaContains = False Then
            myCurrentSuggest = MySuggestCollection.Where(Function(s) s.ToUpper.StartsWith(strInputChars.ToUpper)).ToList()
        Else
            myCurrentSuggest = MySuggestCollection.Where(Function(s) s.ToUpper.Contains(strInputChars.ToUpper)).ToList()
        End If


        If myCurrentSuggest.Count > 0 Then
            Return True
        Else
            strInputChars = ""
            Return False
        End If
    End Function

    ''' <summary>
    ''' Shows the Autocomplete Control with all Values
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ShowAutoCompleteControl()
        If CheckAutoCompleteActiv() Then
            UpdateSuggestListBox(True)
            mShowAutoCompleteControl()
        End If
    End Sub

    Private Sub mShowAutoCompleteControl()
        If myDropDownFormCreated Then
            frmDropDown.Visible = True
        Else
            CreateShowDropDownFrom()
        End If
        Me.Focus()
    End Sub

    Private Sub ReplaceTextValueWithSuggest()
        If strInputChars.Length > 0 Then
            Me.Text = Me.Text.Remove(((Me.Text.Length) - strInputChars.Length))
        End If
        Me.Text += CapturaValor(lbSuggest.SelectedItem.ToString())
        Me.SelectionStart = Me.Text.Length
        strInputChars = ""
    End Sub

    Private Sub HandleInputChanged()
        UpdateSuggestListBox()

        If frmDropDown IsNot Nothing AndAlso frmDropDown.Visible Then
            lbSuggest.Refresh()
            AutoCompleteControlAfterDataChanged()
        Else
            mShowAutoCompleteControl()
            AutoCompleteControlAfterDataChanged()
        End If
    End Sub

#Region "lbSuggest"

    Protected Overridable Sub AutoCompleteControlAfterDataChanged()
        If frmDropDown IsNot Nothing AndAlso lbSuggest IsNot Nothing AndAlso myCurrentSuggest.Count > 0 Then
            Dim inrCalcCrtlSize As Integer = (lbSuggest.ItemHeight * myCurrentSuggest.Count) + 5
            If inrCalcCrtlSize > MyAutoCompleteControlMaxHeigh Then
                frmDropDown.Height = MyAutoCompleteControlMaxHeigh
            Else
                frmDropDown.Height = inrCalcCrtlSize
            End If
        End If
    End Sub

    Private Sub lbSuggest_KeyDown(sender As Object, e As KeyEventArgs) Handles lbSuggest.KeyDown
        If lbSuggest.SelectedItem IsNot Nothing AndAlso Not (String.IsNullOrEmpty(lbSuggest.SelectedItem) OrElse lbSuggest.SelectedItem.Trim.Length = 0) Then
            If e.KeyData = Keys.Enter OrElse e.KeyData = Keys.Tab Then
                Try
                    ReplaceTextValueWithSuggest()
                    e.SuppressKeyPress = True
                    frmDropDown.Visible = False
                Finally
                    frmDropDown.Visible = False
                End Try
            ElseIf e.KeyData = Keys.Up Then
                If lbSuggest.SelectedIndex = 0 Then
                    frmDropDown.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub lbSuggest_MouseClick(sender As Object, e As MouseEventArgs) Handles lbSuggest.MouseClick
        If lbSuggest IsNot Nothing AndAlso lbSuggest.Items IsNot Nothing AndAlso lbSuggest.Items.Count > 0 Then
            If lbSuggest.SelectedItem IsNot Nothing AndAlso Not (String.IsNullOrEmpty(lbSuggest.SelectedItem) OrElse lbSuggest.SelectedItem.Trim.Length = 0) Then
                Try
                    ReplaceTextValueWithSuggest()
                    frmDropDown.Visible = False
                Finally
                    frmDropDown.Visible = False
                End Try
            End If
        End If
    End Sub

    Private Sub lbSuggest_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles lbSuggest.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub
#End Region
#End Region

    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        If CheckAutoCompleteActiv() Then
            If mHandleKeyChar Then
                If CheckCharInSuggest(e.KeyChar) Then
                    HandleInputChanged()
                Else
                    If frmDropDown IsNot Nothing AndAlso frmDropDown.Visible Then
                        frmDropDown.Visible = False
                    End If
                End If
            Else
                mHandleKeyChar = True
            End If
        End If
        MyBase.OnKeyPress(e)
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        If CheckAutoCompleteActiv() Then
            If e.KeyData = Keys.Down Then
                frmDropDown.Focus()
                If lbSuggest.Items.Count > 0 Then
                    lbSuggest.SelectedIndex = 0
                End If
            ElseIf e.KeyData = MyAutoCompleteListShowKey Then
                ShowAutoCompleteControl()
                AutoCompleteControlAfterDataChanged()
            ElseIf e.KeyData = Keys.Back Then
                If HandleSpezialKeySuggest(e.KeyData) Then
                    HandleInputChanged()
                    mHandleKeyChar = False
                End If
            End If
        End If
        MyBase.OnKeyDown(e)
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        If CheckAutoCompleteActiv() Then
            If frmDropDown IsNot Nothing AndAlso frmDropDown.Visible AndAlso Not frmDropDown.Focused AndAlso Not Me.Focused AndAlso Not lbSuggest.Focused Then
                frmDropDown.Visible = False
            End If
        End If
        MyBase.OnLostFocus(e)
    End Sub

    Private Sub myParentForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles myParentForm.FormClosing
        If frmDropDown IsNot Nothing Then
            frmDropDown.Close()
            frmDropDown.Dispose()
            frmDropDown = Nothing
        End If
    End Sub

    Private Sub myParentForm_LocationChanged(sender As Object, e As EventArgs) Handles myParentForm.LocationChanged
        If frmDropDown IsNot Nothing AndAlso frmDropDown.Visible Then
            Dim pScreen As Drawing.Point = Me.PointToScreen(Drawing.Point.Empty)
            pScreen.Y = (pScreen.Y + Me.Height) - 1
            pScreen.X = pScreen.X - 2
            frmDropDown.Location = pScreen
        End If
    End Sub

    Private Sub cTA_TextBox_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        If myParentForm Is Nothing Then
            myParentForm = Me.FindForm
        End If
    End Sub

#Region "Designer"
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbSuggest = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbSuggest
        '
        Me.lbSuggest.FormattingEnabled = True
        Me.lbSuggest.Location = New System.Drawing.Point(0, 0)
        Me.lbSuggest.Name = "lbSuggest"
        Me.lbSuggest.Size = New System.Drawing.Size(120, 96)
        Me.lbSuggest.TabIndex = 0
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbSuggest As System.Windows.Forms.ListBox
#End Region

End Class
