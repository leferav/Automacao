Imports System.Globalization
Public Class fbNumericBox_v2

    ' Compile this then go to the bin directories. Copy the release dll and paste it in your project folder. 
    ' Reference it from there. Then go to the toolbox for the gui components then click add more. There find
    ' reference the dll in your project folder. This has been tested to work on Microsoft Visual Studio 2010
    ' Ultimate. I assume this will work on all versions of Visual Studio 2010. For flexibility here are the 
    ' parts that you should change depending on your location/currency:
    '   1. Using replace text (ctrl+h), replace all occurences of "en-PH" with your desired location code.
    '   2. There are parts of the world that use the format "9.876.543,21" if you use this format, using 
    '      replace text (ctrl+h), replace all occurences of 46 to 44. You have nothing to change if you use
    '      PhP as your currency and if you use "9,876,543.21" format.
    ' Using as a control:
    '   1. When you want to change the value of the text programmatically follow this statement:
    '           CurrencyTextBox1.Text = "9876543.21" or CurrencyTextBox1.Text = MyDecimal
    '      In that case "9876543.21" can be string, or MyDecimal can be both string and any numeric
    '      variable. 
    '   2. If you want to get the value of the currency not in the formatted mode, you can use
    '           MyDecimal = CurrencyTextBox1.Value ' Dont use .Text since it will output the formatted code.
    ' Programmed by: Bangon Kali 
    ' Email: bangonkali@gmail.com
    ' You may erase this after reading. 

    Inherits TextBox

    'Const LOCATIONCODE As String = "pt-BR"
    Private DECIMALPOINT As Integer '= 44
    Private NEGATIVESIMBOL As Integer '= 44
    Private CURRFORM As String '= "D"

    Private mDecimalPeriod As Boolean = False
    Private mNegativePeriod As Boolean = False

    Private mNumberFormat As System.Globalization.NumberFormatInfo '= New System.Globalization.CultureInfo(LOCATIONCODE, False).NumberFormat
    Private mBuffer As String = ""

    Private StiloNumero As NumberStyles
    Private CorTexto As Color

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        CorTexto = Me.ForeColor
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()


        Me.BorderStyle = BorderStyle.FixedSingle
        Me.Name = "fbNumericBox_v2"
        Me.CulturaSistema = True
        Me.SimboloMoeda = "R$"
        Me.SimboloPercentual = "%"
        Me.EstiloNumerico = EstiloNumero.Numerico
        Me.CasasDecimais = 2
        Me.SeparadorDecimal = ","
        Me.SeparadorMilhar = "."
        Me.ComportamentoDecimais = ComportaDecimais.Arredondamento
        Me.TextAlign = HorizontalAlignment.Right
        Me.AceitaNegativo = True


        Me.DB = New StandardControlDB(Me, 0)
    End Sub

    <System.ComponentModel.Category("FeedBack")>
    Public Property DB As StandardControlDB


    Private _CulturaSistema As Boolean
    <System.ComponentModel.Category("FeedBack")>
    <System.ComponentModel.Description("Coloque se deseja usar a cultura padrão do windows")>
    Public Property CulturaSistema() As Boolean
        Get
            Return _CulturaSistema
        End Get
        Set(ByVal value As Boolean)
            _CulturaSistema = value
            AjustaFormato()
        End Set
    End Property

    Private _AceitaNegativo As Boolean
    <System.ComponentModel.Category("FeedBack")>
    <System.ComponentModel.Description("Símbolo Negativo")>
    Public Property AceitaNegativo() As Boolean
        Get
            Return _AceitaNegativo
        End Get
        Set(ByVal value As Boolean)
            _AceitaNegativo = value
            AjustaFormato()
        End Set
    End Property


    Private _SimboloMoeda As String
    <System.ComponentModel.Category("FeedBack")>
    <System.ComponentModel.Description("Símbolo da Moeda Corrente")>
    Public Property SimboloMoeda() As String
        Get
            Return _SimboloMoeda
        End Get
        Set(ByVal value As String)
            _SimboloMoeda = value
            AjustaFormato()
        End Set
    End Property




    Public Enum EstiloNumero
        Dinheiro
        Numerico
        Percentual
    End Enum
    Private _EstiloNumerico As EstiloNumero
    <System.ComponentModel.Category("FeedBack")>
    <System.ComponentModel.Description("Estilo do Número")>
    Public Property EstiloNumerico() As EstiloNumero
        Get
            Return _EstiloNumerico
        End Get
        Set(ByVal value As EstiloNumero)
            _EstiloNumerico = value
            AjustaFormato()
        End Set
    End Property

    Private _CasasDecimais As Integer
    <System.ComponentModel.Category("FeedBack")>
    <System.ComponentModel.Description("Casas Decimais")>
    Public Property CasasDecimais() As Integer
        Get
            Return _CasasDecimais
        End Get
        Set(ByVal value As Integer)
            _CasasDecimais = value
            AjustaFormato()
        End Set
    End Property

    Private _SeparadorDecimal As String
    <System.ComponentModel.Category("FeedBack")>
    <System.ComponentModel.Description("Símbolo Separador Decimal")>
    Public Property SeparadorDecimal() As String
        Get
            Return _SeparadorDecimal
        End Get
        Set(ByVal value As String)
            _SeparadorDecimal = value
        End Set
    End Property

    Private _SeparadorMilhar As String
    <System.ComponentModel.Category("FeedBack")>
    <System.ComponentModel.Description("Símbolo Separador Milhar")>
    Public Property SeparadorMilhar() As String
        Get
            Return _SeparadorMilhar
        End Get
        Set(ByVal value As String)
            _SeparadorMilhar = value
            AjustaFormato()
        End Set
    End Property

    Public Enum ComportaDecimais
        Arredondamento
        Truncamento
    End Enum
    Private _ComportamentoDecimais As ComportaDecimais
    <System.ComponentModel.Category("FeedBack")>
    <System.ComponentModel.Description("Indica se o valor irá arrendoar ou truncar")>
    Public Property ComportamentoDecimais() As ComportaDecimais
        Get
            Return _ComportamentoDecimais
        End Get
        Set(ByVal value As ComportaDecimais)
            _ComportamentoDecimais = value
        End Set
    End Property


    Private _SimboloPercentual As String
    <System.ComponentModel.Category("FeedBack")>
    <System.ComponentModel.Description("Símbolo Percentual")>
    Public Property SimboloPercentual() As String
        Get
            Return _SimboloPercentual
        End Get
        Set(ByVal value As String)
            _SimboloPercentual = value
            AjustaFormato()
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            Return MyBase.Text.Replace(".", "")
        End Get
        Set(ByVal value As String)
            Try
                Dim num As Decimal = Decimal.Parse(value, StiloNumero, mNumberFormat)
                If Not AceitaNegativo AndAlso num < 0 Then
                    num = num * -1
                End If

                If ComportamentoDecimais = ComportaDecimais.Truncamento Then
                    num = Trunca(num, Me.CasasDecimais)
                End If
                If EstiloNumerico = EstiloNumero.Percentual Then
                    num = CDec(num) / 100
                    MyBase.Text = num.ToString(CURRFORM, mNumberFormat)
                Else
                    MyBase.Text = num.ToString(CURRFORM, mNumberFormat)
                End If
            Catch ex As Exception
                MyBase.Text = Decimal.Parse("0", StiloNumero, mNumberFormat).ToString(CURRFORM, mNumberFormat)
            End Try
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public ReadOnly Property ValorNumerico As Decimal
        Get
            Dim sText As String = MyBase.Text
            If sText.Length = 0 Then
                sText = "0"
            End If
            If EstiloNumerico = EstiloNumero.Percentual Then
                sText = sText.Replace(mNumberFormat.PercentSymbol, "")
            End If
            Return Decimal.Parse(sText, StiloNumero, mNumberFormat)
        End Get
    End Property

    Private Sub fbNumericBox_v2_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled = True Then
            If _req = True Then
                Me.BackColor = Color.LightBlue 'System.Drawing.SystemColors.GradientActiveCaption
            Else
                Me.BackColor = Color.White
            End If
        Else
            Me.BackColor = Color.LightGray
        End If
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

    Public Sub txt_BackColorChanged() Handles Me.EnabledChanged
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


    Private Sub AjustaFormato()
        If Me.CulturaSistema Then
            mNumberFormat = New CultureInfo(CultureInfo.CurrentCulture.Name, False).NumberFormat
            Select Case EstiloNumerico
                Case EstiloNumero.Dinheiro
                    StiloNumero = NumberStyles.Currency
                    mNumberFormat.CurrencyDecimalDigits = Me.CasasDecimais
                    CURRFORM = "C"
                Case EstiloNumero.Numerico
                    StiloNumero = NumberStyles.Number
                    mNumberFormat.NumberDecimalDigits = Me.CasasDecimais
                    CURRFORM = "N"
                Case EstiloNumero.Percentual
                    StiloNumero = NumberStyles.Number
                    mNumberFormat.PercentDecimalDigits = Me.CasasDecimais
                    CURRFORM = "P"
            End Select
            If Me.CasasDecimais > 0 Then
                CURRFORM += Me.CasasDecimais.ToString
            End If
        Else
            mNumberFormat = New CultureInfo(CultureInfo.CurrentCulture.Name, False).NumberFormat
            Select Case EstiloNumerico
                Case EstiloNumero.Dinheiro
                    StiloNumero = NumberStyles.Currency
                    mNumberFormat.CurrencySymbol = Me.SimboloMoeda
                    mNumberFormat.CurrencyDecimalDigits = Me.CasasDecimais
                    mNumberFormat.CurrencyDecimalSeparator = Me.SeparadorDecimal
                    mNumberFormat.CurrencyGroupSeparator = Me.SeparadorMilhar
                    CURRFORM = "C"
                Case EstiloNumero.Numerico
                    StiloNumero = NumberStyles.Number
                    mNumberFormat.NumberDecimalDigits = Me.CasasDecimais
                    mNumberFormat.NumberDecimalSeparator = Me.SeparadorDecimal
                    mNumberFormat.NumberGroupSeparator = Me.SeparadorMilhar
                    CURRFORM = "N"
                Case EstiloNumero.Percentual
                    StiloNumero = NumberStyles.Number
                    mNumberFormat.PercentSymbol = Me.SimboloPercentual
                    mNumberFormat.PercentDecimalDigits = Me.CasasDecimais
                    mNumberFormat.PercentDecimalSeparator = Me.SeparadorDecimal
                    mNumberFormat.PercentGroupSeparator = Me.SeparadorMilhar
                    CURRFORM = "P"
            End Select
            If Me.CasasDecimais > 0 Then
                CURRFORM += Me.CasasDecimais.ToString
            End If
        End If
        DECIMALPOINT = Asc(Convert.ToChar(mNumberFormat.NumberDecimalSeparator))
        NEGATIVESIMBOL = Asc(Convert.ToChar(mNumberFormat.NegativeSign))
    End Sub


    Private Sub DecimalTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        AjustaFormato()
        If MyBase.Text.Length = 0 Then
            MyBase.Text = "0"
        End If
        _txtChange = False
        If EstiloNumerico = EstiloNumero.Percentual Then
            MyBase.Text = MyBase.Text.Replace(mNumberFormat.PercentSymbol, "")
        End If
        If IsNumeric(MyBase.Text) Then
            MyBase.Text = Decimal.Parse(MyBase.Text, StiloNumero, mNumberFormat).ToString
            _txtChange = True
        End If
    End Sub

    Private Sub DecimalTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        If MyBase.Text.Length = 0 Then
            MyBase.Text = "0"
        End If
        If EstiloNumerico = EstiloNumero.Percentual Then
            MyBase.Text = MyBase.Text.Replace(mNumberFormat.PercentSymbol, "")
            MyBase.Text = CDec(MyBase.Text) / 100.0
        End If
        Dim num As Decimal = 0
        If IsNumeric(MyBase.Text) Then
            num = Decimal.Parse(MyBase.Text, StiloNumero, mNumberFormat)
        End If
        If ComportamentoDecimais = ComportaDecimais.Truncamento Then
            If EstiloNumerico = EstiloNumero.Percentual Then
                num = num * 100
                num = Trunca(num, Me.CasasDecimais)
                num = num / 100
            Else
                num = Trunca(num, Me.CasasDecimais)
            End If
        End If
        MyBase.Text = num.ToString(CURRFORM, mNumberFormat)
        mDecimalPeriod = False
        mNegativePeriod = False
    End Sub

    Private Sub DecimalTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        mBuffer = MyBase.Text
        If e.KeyChar = Chr(8) Then
            If MyBase.Text.Length = 0 Then Exit Sub
            If MyBase.Text.Chars(MyBase.Text.Length - 1) = Chr(DECIMALPOINT) Then
                mDecimalPeriod = False
            End If
            If _AceitaNegativo Then
                If MyBase.Text.Chars(MyBase.Text.Length - 1) = Chr(NEGATIVESIMBOL) Then
                    mNegativePeriod = False
                End If
            End If
            Exit Sub
        ElseIf Char.IsNumber(e.KeyChar) = False Then
            If e.KeyChar = Chr(DECIMALPOINT) Then
                If MyBase.Text.Length = 0 And MyBase.SelectionLength = 0 Then
                    e.Handled = True
                    Exit Sub
                End If
                If mDecimalPeriod = False And MyBase.SelectionLength = 0 Then
                    mDecimalPeriod = True
                    Exit Sub
                Else
                    e.Handled = True
                End If
            End If
            If _AceitaNegativo Then
                If e.KeyChar = Chr(NEGATIVESIMBOL) Then
                    If MyBase.Text.Length = 0 And MyBase.SelectionLength = 0 Or MyBase.Text.Length = MyBase.SelectionLength Then
                        mNegativePeriod = True
                        Exit Sub
                        'e.Handled = True
                        'Exit Sub
                    End If
                    If mNegativePeriod = False And MyBase.SelectionLength = 0 Then
                        mNegativePeriod = True
                        Exit Sub
                    Else
                        e.Handled = True
                    End If
                End If
            End If
            e.Handled = True
            Exit Sub
        End If
        If IsNumber(Text) = False Then
            MyBase.Text = mBuffer
        End If
    End Sub
    Private Sub DecimalTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        MyBase.SelectAll()
    End Sub

    'Private Sub DecimalTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged
    '    If MyBase.Enabled = False Or MyBase.ReadOnly = True Then

    '        'MyBase.Text = Decimal.Parse(Me.ValorNumerico, StiloNumero, mNumberFormat).ToString(CURRFORM, mNumberFormat)
    '        'Try
    '        '    MyBase.Text = Decimal.Parse(MyBase.Text, StiloNumero, mNumberFormat).ToString(CURRFORM, mNumberFormat)
    '        'Catch ex As Exception
    '        '    MyBase.Text = Decimal.Parse("0", StiloNumero, mNumberFormat).ToString(CURRFORM, mNumberFormat)
    '        'End Try
    '    End If

    '    'Try
    '    '    If MyBase.ReadOnly = True Then
    '    '        MyBase.Text = Decimal.Parse(MyBase.Text, StiloNumero, mNumberFormat).ToString(CURRFORM, mNumberFormat)
    '    '    End If
    '    'Catch ex As Exception
    '    '    MyBase.Text = Decimal.Parse("0", StiloNumero, mNumberFormat).ToString(CURRFORM, mNumberFormat)
    '    'End Try

    'End Sub


    Private Function IsNumber(ByVal str As String) As Boolean
        Dim iCounter As Integer
        Dim bValidator As Boolean
        For iCounter = 0 To str.Length - 1
            If Char.IsDigit(str.Chars(iCounter)) = False Then
                If str.Chars(iCounter) = Chr(DECIMALPOINT) And bValidator = False Then
                    bValidator = True
                Else
                    Return False
                    Exit Function
                End If
            End If
        Next
        Return True
    End Function

    Private Function Trunca(valor As Decimal, casas As Integer) As Decimal
        Dim parInt As Int64 = Math.Truncate(valor * CInt(10 ^ casas))
        Return (parInt / CDec(10 ^ casas))
    End Function

    Dim _NomeCampoMsg As String = ""
    <System.ComponentModel.Category("FeedBack")>
    Public Property NomeCampoMsg() As String
        Get
            If _NomeCampoMsg = "" Then _NomeCampoMsg = Me.Name.Replace("txt", "")
            Return _NomeCampoMsg
        End Get
        Set(ByVal value As String)
            _NomeCampoMsg = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")>
    Public Property ValorMaximo() As Integer = 100000000

    <System.ComponentModel.Category("FeedBack")>
    Public Property ValorMinimo() As Integer = -100000000

    Dim _txtChange As Boolean = True
    Private Sub fbNumericBox_TextChanged(sender As Object, e As System.EventArgs) Handles Me.TextChanged
        If _txtChange AndAlso Me.Focused Then
            If Me.Text = "" Then
                Me.Text = 0
            ElseIf IsNumeric(Me.Text) AndAlso Me.Text > ValorMaximo Then
                Me.Text = FormatNumber(ValorMaximo, Me.CasasDecimais)
            ElseIf IsNumeric(Me.Text) AndAlso Me.Text < 0 AndAlso Me.Text < ValorMinimo Then
                Me.Text = FormatNumber(ValorMinimo, Me.CasasDecimais)
            End If
        End If
        'If IsNumeric(Me.Text) Then
        '    If AceitaNegativo AndAlso Me.Text < 0 Then
        '        Me.ForeColor = Color.Red
        '    Else
        '        Me.ForeColor = CorTexto
        '    End If
        'End If
    End Sub

    Private Sub fbNumericBox_v2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Delete Then
            Me.Text = 0
        End If

    End Sub

End Class
