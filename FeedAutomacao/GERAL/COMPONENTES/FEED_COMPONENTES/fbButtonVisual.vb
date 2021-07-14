Imports System.ComponentModel
Imports System.Security.Permissions
Imports System.Drawing.Design
Imports System.Windows.Forms.Design

<Flags()> _
Public Enum Corners
    None = 0
    TopLeft = 1
    TopRight = 2
    BottomLeft = 4
    BottomRight = 8
    All = TopLeft Or TopRight Or BottomLeft Or BottomRight
End Enum

Public Enum CustomButtonState
    [Normal] = 1
    [Hot]
    [Pressed]
    [Disabled]
    [Focused]
End Enum

Public Class fbButtonVisual
    Inherits Control
    Implements IButtonControl

    Public Sub New()
        MyBase.New()
        Me.ForeColor = Color.Lavender
        Me.SetStyle(ControlStyles.Selectable Or ControlStyles.StandardClick Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
    End Sub

#Region " Private Instance Variables "

    Private m_DialogResult As DialogResult
    Private m_IsDefault As Boolean

    Private m_CornerRadius As Int32 = 8
    Private m_RoundCorners As Corners
    Private m_ButtonState As CustomButtonState = CustomButtonState.Normal

    Private m_ImageAlign As ContentAlignment = ContentAlignment.MiddleCenter
    Private m_TextAlign As ContentAlignment = ContentAlignment.MiddleCenter
    Private m_ImageList As ImageList
    Private m_ImageIndex As Int32 = -1

    Private keyPressed As Boolean
    Private contentRect As Rectangle

#End Region

#Region " IButtonControl Implementation "

    <Category("Behavior"), DefaultValue(GetType(DialogResult), "None"), _
    Description("The dialog result produced in a modal form by clicking the button.")> _
    Public Property DialogResult() As System.Windows.Forms.DialogResult Implements System.Windows.Forms.IButtonControl.DialogResult
        Get
            Return m_DialogResult
        End Get
        Set(ByVal Value As System.Windows.Forms.DialogResult)
            If [Enum].IsDefined(GetType(DialogResult), Value) Then
                m_DialogResult = Value
            End If
        End Set
    End Property

    Public Sub NotifyDefault(ByVal value As Boolean) Implements System.Windows.Forms.IButtonControl.NotifyDefault
        If m_IsDefault <> value Then
            m_IsDefault = value
        End If
        Me.Invalidate()
    End Sub

    Public Sub PerformClick() Implements System.Windows.Forms.IButtonControl.PerformClick
        If Me.CanSelect Then
            MyBase.OnClick(EventArgs.Empty)
        End If
    End Sub

#End Region

#Region " Properties "

    'ButtonState
    <Browsable(False)> _
    Public ReadOnly Property ButtonState() As CustomButtonState
        Get
            Return m_ButtonState
        End Get
    End Property

    'CornerRadius
    <Category("Appearance"), _
    DefaultValue(8), _
    Description("Defines the radius of the controls RoundedCorners.")> _
    Public Property CornerRadius() As Int32
        Get
            Return m_CornerRadius
        End Get
        Set(ByVal Value As Int32)
            If m_CornerRadius = Value Then Return
            m_CornerRadius = Value
            Me.Invalidate()
        End Set
    End Property

    'DefaultSize
    Protected Overrides ReadOnly Property DefaultSize() As System.Drawing.Size
        Get
            Return New Size(75, 23)
        End Get
    End Property

    'IsDefault
    <Browsable(False)> _
    Public ReadOnly Property IsDefault() As Boolean
        Get
            Return m_IsDefault
        End Get
    End Property

    'ImageList
    <Category("Appearance"), DefaultValue(GetType(ImageList), Nothing), _
    Description("The image list to get the image to display in the face of the control.")> _
    Public Property ImageList() As ImageList
        Get
            Return m_ImageList
        End Get
        Set(ByVal Value As ImageList)
            m_ImageList = Value
            Me.Invalidate()
        End Set
    End Property

    'ImageIndex
    <Category("Appearance"), DefaultValue(-1), _
    Description("The index of the image in the image list to display in the face of the control."), _
    TypeConverter(GetType(ImageIndexConverter)), _
    Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design", GetType(System.Drawing.Design.UITypeEditor))> _
    Public Property ImageIndex() As Int32
        Get
            Return m_ImageIndex
        End Get
        Set(ByVal Value As Int32)
            m_ImageIndex = Value
            Me.Invalidate()
        End Set
    End Property

    'ImageAlign
    <Category("Appearance"), DefaultValue(GetType(ContentAlignment), "MiddleCenter"), _
    Description("The alignment of the image that will be displayed in the face of the control.")> _
    Public Property ImageAlign() As ContentAlignment
        Get
            Return m_ImageAlign
        End Get
        Set(ByVal Value As ContentAlignment)
            If Not [Enum].IsDefined(GetType(ContentAlignment), Value) Then
                Throw New InvalidEnumArgumentException("value", CInt(Value), GetType(ContentAlignment))
            End If
            If m_ImageAlign = Value Then Return
            m_ImageAlign = Value
            Invalidate()
        End Set
    End Property

    'RoundCorners
    <Category("Appearance"), _
    DefaultValue(GetType(Corners), "None"), _
    Description("Gets/sets the corners of the control to round."), _
    Editor(GetType(RoundCornersEditor), GetType(UITypeEditor)), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
    Public Property RoundCorners() As Corners
        Get
            Return m_RoundCorners
        End Get
        Set(ByVal Value As Corners)
            If m_RoundCorners = Value Then Return
            m_RoundCorners = Value
            Me.Invalidate()
        End Set
    End Property

    'TextAlign
    <Category("Appearance"), DefaultValue(GetType(ContentAlignment), "MiddleCenter"), _
    Description("The alignment of the text that will be displayed in the face of the control.")> _
    Public Property TextAlign() As ContentAlignment
        Get
            Return m_TextAlign
        End Get
        Set(ByVal Value As ContentAlignment)
            If Not [Enum].IsDefined(GetType(ContentAlignment), Value) Then
                Throw New InvalidEnumArgumentException("value", CInt(Value), GetType(ContentAlignment))
            End If
            If m_TextAlign = Value Then Return
            m_TextAlign = Value
            Invalidate()
        End Set
    End Property

#End Region

#Region " Overriden Methods "

    Protected Overrides Sub OnKeyDown(ByVal kevent As System.Windows.Forms.KeyEventArgs)
        MyBase.OnKeyDown(kevent)
        If kevent.KeyValue = Keys.Space Then
            keyPressed = True
            m_ButtonState = CustomButtonState.Pressed
        End If
        OnStateChange(EventArgs.Empty)
    End Sub

    Protected Overrides Sub OnKeyUp(ByVal kevent As System.Windows.Forms.KeyEventArgs)
        MyBase.OnKeyUp(kevent)
        If kevent.KeyValue = Keys.Space Then
            If Me.ButtonState = CustomButtonState.Pressed Then
                Me.PerformClick()
            End If
            keyPressed = False
            m_ButtonState = CustomButtonState.Focused
        End If
        OnStateChange(EventArgs.Empty)
    End Sub

    Protected Overrides Sub OnMouseEnter(ByVal eventargs As System.EventArgs)
        MyBase.OnMouseEnter(eventargs)
        If Not keyPressed Then
            m_ButtonState = CustomButtonState.Hot
        End If
        OnStateChange(eventargs.Empty)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal eventargs As System.EventArgs)
        MyBase.OnMouseLeave(eventargs)
        If Not keyPressed Then
            If Me.IsDefault Then
                m_ButtonState = CustomButtonState.Focused
            Else
                m_ButtonState = CustomButtonState.Normal
            End If
        End If
        OnStateChange(eventargs.Empty)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal mevent As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(mevent)
        If mevent.Button = MouseButtons.Left Then
            Me.Focus()
            m_ButtonState = CustomButtonState.Pressed
        End If
        OnStateChange(EventArgs.Empty)
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal mevent As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(mevent)
        m_ButtonState = CustomButtonState.Focused
        OnStateChange(EventArgs.Empty)
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal mevent As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(mevent)
        If New Rectangle(Point.Empty, Me.Size).Contains(mevent.X, mevent.Y) AndAlso mevent.Button = MouseButtons.Left Then
            m_ButtonState = CustomButtonState.Pressed
        Else
            If keyPressed Then Return
            m_ButtonState = CustomButtonState.Hot
        End If
        OnStateChange(EventArgs.Empty)
    End Sub

    Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
        MyBase.OnGotFocus(e)
        m_ButtonState = CustomButtonState.Focused
        Me.NotifyDefault(True)
    End Sub

    Protected Overrides Sub OnLostFocus(ByVal e As System.EventArgs)
        MyBase.OnLostFocus(e)
        If Me.FindForm.Focused Then
            Me.NotifyDefault(False)
        End If
        m_ButtonState = CustomButtonState.Normal
    End Sub

    Protected Overrides Sub OnEnabledChanged(ByVal e As System.EventArgs)
        MyBase.OnEnabledChanged(e)
        If Me.Enabled Then
            m_ButtonState = CustomButtonState.Normal
        Else
            m_ButtonState = CustomButtonState.Disabled
        End If
        OnStateChange(EventArgs.Empty)
    End Sub

    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        'Click gets fired before MouseUp which is handy
        If Me.ButtonState = CustomButtonState.Pressed Then
            Me.Focus()
            Me.PerformClick()
        End If
    End Sub

    Protected Overrides Sub OnDoubleClick(ByVal e As System.EventArgs)
        If Me.ButtonState = CustomButtonState.Pressed Then
            Me.Focus()
            Me.PerformClick()
        End If
    End Sub

    Protected Overrides Function ProcessMnemonic(ByVal charCode As Char) As Boolean
        If IsMnemonic(charCode, Me.Text) Then
            MyBase.OnClick(EventArgs.Empty)
            Return True
        End If
        Return MyBase.ProcessMnemonic(charCode)
    End Function

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Simulate Transparency
        Dim g As System.Drawing.Drawing2D.GraphicsContainer = pevent.Graphics.BeginContainer()
        Dim translateRect As Rectangle = Me.Bounds
        pevent.Graphics.TranslateTransform(-Me.Left, -Me.Top)
        Dim pe As PaintEventArgs = New PaintEventArgs(pevent.Graphics, translateRect)
        Me.InvokePaintBackground(Me.Parent, pe)
        Me.InvokePaint(Me.Parent, pe)
        pevent.Graphics.ResetTransform()
        pevent.Graphics.EndContainer(g)

        pevent.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim shadeColor, fillColor As Color
        Dim darkColor As Color = DarkenColor(Me.BackColor, 10)
        Dim darkDarkColor As Color = DarkenColor(Me.BackColor, 25)
        Dim lightColor As Color = LightenColor(Me.BackColor, 25)
        Dim lightLightColor As Color = LightenColor(Me.BackColor, 60)

        If Me.ButtonState = CustomButtonState.Hot Then
            fillColor = lightColor
            shadeColor = darkDarkColor
        ElseIf Me.ButtonState = CustomButtonState.Pressed Then
            fillColor = Me.BackColor
            shadeColor = Me.BackColor
        Else
            fillColor = Me.BackColor
            shadeColor = darkDarkColor
        End If

        Dim r As Rectangle = Me.ClientRectangle
        Dim path As Drawing2D.GraphicsPath = RoundRectangle(r, Me.CornerRadius, Me.RoundCorners)

        Dim paintBrush As New Drawing2D.LinearGradientBrush(r, fillColor, shadeColor, Drawing2D.LinearGradientMode.Vertical)

        'We want a sharp change in the colors so define a Blend for the brush
        Dim b As New Drawing2D.Blend
        b.Positions = New Single() {0, 0.45, 0.55, 1}
        b.Factors = New Single() {0, 0, 1, 1}
        paintBrush.Blend = b

        'Draw the Button Background
        pevent.Graphics.FillPath(paintBrush, path)
        paintBrush.Dispose()

        '...and border
        Dim drawingPen As New Pen(darkDarkColor)
        pevent.Graphics.DrawPath(drawingPen, path)
        drawingPen.Dispose()

        'Get the Rectangle to be used for Content
        Dim inBounds As Boolean
        'We could use some Math to get this from the radius but I'm 
        'not great at Math so for the example this hack will suffice.
        While Not (inBounds) AndAlso r.Width >= 1 AndAlso r.Height >= 1
            inBounds = path.IsVisible(r.Left, r.Top) AndAlso _
                        path.IsVisible(r.Right, r.Top) AndAlso _
                        path.IsVisible(r.Left, r.Bottom) AndAlso _
                        path.IsVisible(r.Right, r.Bottom)
            r.Inflate(-1, -1)

        End While

        contentRect = r

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        DrawImage(e.Graphics)
        DrawText(e.Graphics)
        DrawFocus(e.Graphics)
        MyBase.OnPaint(e)
    End Sub

    Protected Overrides Sub OnParentBackColorChanged(ByVal e As System.EventArgs)
        MyBase.OnParentBackColorChanged(e)
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnParentBackgroundImageChanged(ByVal e As System.EventArgs)
        MyBase.OnParentBackgroundImageChanged(e)
        Me.Invalidate()
    End Sub

#End Region

#Region " Internal Draw Methods "

    Private Sub DrawImage(ByVal g As Graphics)

        If Me.ImageList Is Nothing OrElse Me.ImageIndex = -1 Then Return
        If Me.ImageIndex < 0 OrElse Me.ImageIndex >= Me.ImageList.Images.Count Then Return

        Dim _Image As Image = Me.ImageList.Images(Me.ImageIndex)

        Dim pt As Point

        Select Case Me.ImageAlign

            Case ContentAlignment.TopLeft
                pt.X = contentRect.Left
                pt.Y = contentRect.Top

            Case ContentAlignment.TopCenter
                pt.X = (Width - _Image.Width) \ 2
                pt.Y = contentRect.Top

            Case ContentAlignment.TopRight
                pt.X = contentRect.Right - _Image.Width
                pt.Y = contentRect.Top

            Case ContentAlignment.MiddleLeft
                pt.X = contentRect.Left
                pt.Y = (Height - _Image.Height) \ 2

            Case ContentAlignment.MiddleCenter
                pt.X = (Width - _Image.Width) \ 2
                pt.Y = (Height - _Image.Height) \ 2

            Case ContentAlignment.MiddleRight
                pt.X = contentRect.Right - _Image.Width
                pt.Y = (Height - _Image.Height) \ 2

            Case ContentAlignment.BottomLeft
                pt.X = contentRect.Left
                pt.Y = contentRect.Bottom - _Image.Height

            Case ContentAlignment.BottomCenter
                pt.X = (Width - _Image.Width) \ 2
                pt.Y = contentRect.Bottom - _Image.Height

            Case ContentAlignment.BottomRight
                pt.X = contentRect.Right - _Image.Width
                pt.Y = contentRect.Bottom - _Image.Height

        End Select

        If Me.ButtonState = CustomButtonState.Pressed Then
            pt.Offset(1, 1)
        End If

        If Me.Enabled Then
            Me.ImageList.Draw(g, pt, Me.ImageIndex)
        Else
            ControlPaint.DrawImageDisabled(g, _Image, pt.X, pt.Y, Me.BackColor)
        End If

    End Sub

    Private Sub DrawText(ByVal g As Graphics)

        Dim TextBrush As New SolidBrush(Me.ForeColor)

        Dim R As RectangleF = RectangleF.op_Implicit(contentRect)

        If Not Me.Enabled Then TextBrush.Color = SystemColors.GrayText

        Dim sf As New StringFormat(StringFormatFlags.NoWrap Or StringFormatFlags.NoClip)

        If ShowKeyboardCues Then
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
        Else
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Hide
        End If

        Select Case Me.TextAlign
            Case ContentAlignment.TopLeft
                sf.Alignment = StringAlignment.Near
                sf.LineAlignment = StringAlignment.Near

            Case ContentAlignment.TopCenter
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Near

            Case ContentAlignment.TopRight
                sf.Alignment = StringAlignment.Far
                sf.LineAlignment = StringAlignment.Near

            Case ContentAlignment.MiddleLeft
                sf.Alignment = StringAlignment.Near
                sf.LineAlignment = StringAlignment.Center

            Case ContentAlignment.MiddleCenter
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Center

            Case ContentAlignment.MiddleRight
                sf.Alignment = StringAlignment.Far
                sf.LineAlignment = StringAlignment.Center

            Case ContentAlignment.BottomLeft
                sf.Alignment = StringAlignment.Near
                sf.LineAlignment = StringAlignment.Far

            Case ContentAlignment.BottomCenter
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Far

            Case ContentAlignment.BottomRight
                sf.Alignment = StringAlignment.Far
                sf.LineAlignment = StringAlignment.Far

        End Select

        If Me.ButtonState = CustomButtonState.Pressed Then
            R.Offset(1, 1)
        End If

        If Me.Enabled Then
            g.DrawString(Me.Text, Me.Font, TextBrush, R, sf)
        Else
            ControlPaint.DrawStringDisabled(g, Me.Text, Me.Font, Me.BackColor, R, sf)
        End If

    End Sub

    Private Sub DrawFocus(ByVal g As Graphics)
        Dim r As Rectangle = contentRect
        r.Inflate(1, 1)
        If Me.Focused AndAlso Me.ShowFocusCues AndAlso Me.TabStop Then
            Dim pen As Pen = Pens.Gainsboro
            Dim ret As New Rectangle(0, 0, Me.Size.Width - 1, Me.Size.Height - 1)
            g.DrawRectangle(pen, ret)
            ControlPaint.DrawFocusRectangle(g, r, Me.ForeColor, Me.BackColor)
        End If

    End Sub

#End Region

#Region " Helper Methods "

    Private Function RoundRectangle(ByVal r As Rectangle, ByVal radius As Int32, ByVal corners As Corners) As System.Drawing.Drawing2D.GraphicsPath

        'Make sure the Path fits inside the rectangle
        r.Width -= 1
        r.Height -= 1

        'Scale the radius if it's too large to fit.
        If (radius > (r.Width)) Then radius = r.Width
        If (radius > (r.Height)) Then radius = r.Height

        Dim path As New System.Drawing.Drawing2D.GraphicsPath

        If radius <= 0 Then
            path.AddRectangle(r)
        Else
            If (corners And corners.TopLeft) = corners.TopLeft Then
                path.AddArc(r.Left, r.Top, radius, radius, 180, 90)
            Else
                path.AddLine(r.Left, r.Top, r.Left, r.Top)
            End If

            If (corners And corners.TopRight) = corners.TopRight Then
                path.AddArc(r.Right - radius, r.Top, radius, radius, 270, 90)
            Else
                path.AddLine(r.Right, r.Top, r.Right, r.Top)
            End If


            If (corners And corners.BottomRight) = corners.BottomRight Then
                path.AddArc(r.Right - radius, r.Bottom - radius, radius, radius, 0, 90)
            Else
                path.AddLine(r.Right, r.Bottom, r.Right, r.Bottom)
            End If

            If (corners And corners.BottomLeft) = corners.BottomLeft Then
                path.AddArc(r.Left, r.Bottom - radius, radius, radius, 90, 90)
            Else
                path.AddLine(r.Left, r.Bottom, r.Left, r.Bottom)
            End If

            path.CloseFigure()

        End If

        Return path

    End Function

    'The ControlPaint Class has methods to Lighten and Darken Colors, but they return a Solid Color.
    'The Following 2 methods return a modified color with original Alpha.
    Private Function DarkenColor(ByVal colorIn As Color, ByVal percent As Int32) As Color
        'This method returns Black if you Darken by 100%

        If percent < 0 OrElse percent > 100 Then
            Throw New ArgumentOutOfRangeException("percent")
        End If

        Dim a, r, g, b As Int32

        a = colorIn.A
        r = colorIn.R - CInt((colorIn.R / 100) * percent)
        g = colorIn.G - CInt((colorIn.G / 100) * percent)
        b = colorIn.B - CInt((colorIn.B / 100) * percent)

        Return Color.FromArgb(a, r, g, b)

    End Function

    Private Function LightenColor(ByVal colorIn As Color, ByVal percent As Int32) As Color

        'This method returns White if you lighten by 100%
        If percent < 0 OrElse percent > 100 Then
            Throw New ArgumentOutOfRangeException("percent")
        End If

        Dim a, r, g, b As Int32

        a = colorIn.A
        r = colorIn.R + CInt(((255 - colorIn.R) / 100) * percent)
        g = colorIn.G + CInt(((255 - colorIn.G) / 100) * percent)
        b = colorIn.B + CInt(((255 - colorIn.B) / 100) * percent)

        Return Color.FromArgb(a, r, g, b)
    End Function

#End Region

    Private Sub OnStateChange(ByVal e As EventArgs)
        Static currentState As CustomButtonState
        'Repaint the button only if the state has actually changed
        If Me.ButtonState = currentState Then Return
        currentState = Me.ButtonState
        Me.Invalidate()
    End Sub

End Class

#Region " Custom TypeEditor for RoundCorners property "

<PermissionSetAttribute(SecurityAction.LinkDemand, Unrestricted:=True), PermissionSetAttribute(SecurityAction.InheritanceDemand, Unrestricted:=True)> _
Public Class RoundCornersEditor
    Inherits UITypeEditor

    Public Overloads Overrides Function GetEditStyle(ByVal context As System.ComponentModel.ITypeDescriptorContext) As System.Drawing.Design.UITypeEditorEditStyle
        Return UITypeEditorEditStyle.DropDown
    End Function

    Public Overloads Overrides Function EditValue(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal provider As System.IServiceProvider, ByVal value As Object) As Object

        If Not TypeOf value Is Corners OrElse _
                    provider Is Nothing Then
            Return value
        End If

        Dim edSvc As IWindowsFormsEditorService = CType(provider.GetService(GetType(IWindowsFormsEditorService)), IWindowsFormsEditorService)
        If Not (edSvc Is Nothing) Then
            Dim lb As New CheckedListBox
            lb.BorderStyle = System.Windows.Forms.BorderStyle.None
            lb.CheckOnClick = True

            lb.Items.Add("TopLeft", (DirectCast(context.Instance, fbButtonVisual).RoundCorners And Corners.TopLeft) = Corners.TopLeft)
            lb.Items.Add("TopRight", (DirectCast(context.Instance, fbButtonVisual).RoundCorners And Corners.TopRight) = Corners.TopRight)
            lb.Items.Add("BottomLeft", (DirectCast(context.Instance, fbButtonVisual).RoundCorners And Corners.BottomLeft) = Corners.BottomLeft)
            lb.Items.Add("BottomRight", (DirectCast(context.Instance, fbButtonVisual).RoundCorners And Corners.BottomRight) = Corners.BottomRight)

            edSvc.DropDownControl(lb)
            Dim cornerFlags As Corners
            For Each o As Object In lb.CheckedItems
                cornerFlags = cornerFlags Or DirectCast([Enum].Parse(GetType(Corners), o.ToString), Corners)
            Next
            lb.Dispose()
            edSvc.CloseDropDown()
            Return cornerFlags
        End If

        Return value

    End Function

End Class

#End Region


