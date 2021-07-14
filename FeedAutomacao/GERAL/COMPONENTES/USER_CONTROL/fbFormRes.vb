Imports System.Drawing.Drawing2D

Public Class fbFormRes
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    <System.STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New fbFormRes)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenu2 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuExit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuAbout As System.Windows.Forms.MenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LabelFile As System.Windows.Forms.Label
    Friend WithEvents LabelResize As System.Windows.Forms.Label
    Friend WithEvents LabelHelp As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuExit = New System.Windows.Forms.MenuItem
        Me.ContextMenu2 = New System.Windows.Forms.ContextMenu
        Me.MenuAbout = New System.Windows.Forms.MenuItem
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelFile = New System.Windows.Forms.Label
        Me.LabelHelp = New System.Windows.Forms.Label
        Me.LabelResize = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuExit})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "MenuItem1"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'MenuExit
        '
        Me.MenuExit.Index = 2
        Me.MenuExit.Text = "Exit"
        '
        'ContextMenu2
        '
        Me.ContextMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuAbout})
        '
        'MenuAbout
        '
        Me.MenuAbout.Index = 0
        Me.MenuAbout.Text = "About"
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'LabelFile
        '
        Me.LabelFile.BackColor = System.Drawing.Color.Transparent
        Me.LabelFile.ForeColor = System.Drawing.SystemColors.MenuText
        Me.LabelFile.Location = New System.Drawing.Point(8, 24)
        Me.LabelFile.Name = "LabelFile"
        Me.LabelFile.Size = New System.Drawing.Size(32, 19)
        Me.LabelFile.TabIndex = 0
        Me.LabelFile.Text = "File"
        Me.LabelFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelHelp
        '
        Me.LabelHelp.BackColor = System.Drawing.Color.Transparent
        Me.LabelHelp.ForeColor = System.Drawing.SystemColors.MenuText
        Me.LabelHelp.Location = New System.Drawing.Point(64, 24)
        Me.LabelHelp.Name = "LabelHelp"
        Me.LabelHelp.Size = New System.Drawing.Size(32, 19)
        Me.LabelHelp.TabIndex = 1
        Me.LabelHelp.Text = "Help"
        Me.LabelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelResize
        '
        Me.LabelResize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelResize.AutoSize = True
        Me.LabelResize.BackColor = System.Drawing.Color.Transparent
        Me.LabelResize.Font = New System.Drawing.Font("Marlett", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.LabelResize.Location = New System.Drawing.Point(272, 138)
        Me.LabelResize.Name = "LabelResize"
        Me.LabelResize.Size = New System.Drawing.Size(16, 14)
        Me.LabelResize.TabIndex = 2
        Me.LabelResize.Text = "o"
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(288, 152)
        Me.Controls.Add(Me.LabelResize)
        Me.Controls.Add(Me.LabelHelp)
        Me.Controls.Add(Me.LabelFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "Shaped Form Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ReadOnly Property TitleBar() As Region
        Get
            Return New Region(New Rectangle(0, 0, Width, 26))
        End Get
    End Property

    Private ReadOnly Property CloseButton() As GraphicsPath
        Get
            Dim gp As New GraphicsPath
            gp.AddEllipse(New Rectangle(Width - 26, 3, 18, 18))
            Return gp
        End Get
    End Property

    Private ReadOnly Property MinButton() As GraphicsPath
        Get
            Dim gp As New GraphicsPath
            gp.AddEllipse(New Rectangle(Width - 49, 3, 18, 18))
            Return gp
        End Get
    End Property

    Private ReadOnly Property FormShape() As GraphicsPath
        Get
            Dim gp As GraphicsPath = New GraphicsPath
            Dim r As Rectangle = ClientRectangle
            Dim radius As Int32 = 12

            gp.AddArc(r.Left, r.Top + 24, radius, radius, 180, 90)
            gp.AddArc(r.Left + 80 - radius, r.Top + 24 - radius, radius, radius, -270, -90)
            gp.AddArc(r.Left + 80, r.Top, radius, radius, 180, 90)
            gp.AddArc(r.Right - radius, r.Top, radius, radius, 270, 90)
            gp.AddArc(r.Right - radius, r.Bottom - radius, radius, radius, 0, 90)
            gp.AddArc(r.Left, r.Bottom - radius, radius, radius, 90, 90)
            gp.CloseFigure()

            Return gp

        End Get
    End Property

    Private ClosePress As Boolean = False
    Private MinPress As Boolean = False
    Private FormDrag As Boolean = False
    Private FileActive As Boolean = False
    Private HelpActive As Boolean = False
    Private FileHot As Boolean = False
    Private HelpHot As Boolean = False

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const WS_CLIPCHILDREN As Integer = &H2000000
            Const WS_MINIMIZEBOX As Integer = &H20000
            'Const WS_MAXIMIZEBOX As Integer = &H10000
            Const WS_SYSMENU As Integer = &H80000

            Const CS_DBLCLKS As Integer = &H8
            Const CS_DROPSHADOW As Integer = &H20000

            Dim ClassFlags As Integer = CS_DBLCLKS
            Dim OSVER As Integer = Environment.OSVersion.Version.Major * 10
            OSVER += Environment.OSVersion.Version.Minor
            If OSVER >= 51 Then ClassFlags = CS_DBLCLKS Or CS_DROPSHADOW

            cp.Style = WS_CLIPCHILDREN Or WS_MINIMIZEBOX Or WS_SYSMENU 'Or WS_MAXIMIZEBOX
            cp.ClassStyle = ClassFlags
            Return cp
        End Get
    End Property

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LabelFile.Location = New Point(2, 26)
        Me.LabelHelp.Location = New Point(LabelFile.Right, 26)
        Me.LabelFile.Font = SystemInformation.MenuFont
        Me.LabelHelp.Font = SystemInformation.MenuFont
        Me.Region = New Region(FormShape)
    End Sub

    Private Sub MainForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        e.Graphics.FillRegion(Brushes.Green, TitleBar)
        e.Graphics.FillRectangle(SystemBrushes.Menu, New Rectangle(0, 26, Width, 19))

        If FileHot Then e.Graphics.FillRectangle(SystemBrushes.Highlight, LabelFile.Bounds)
        If HelpHot Then e.Graphics.FillRectangle(SystemBrushes.Highlight, LabelHelp.Bounds)

        Dim BorderPen As New Pen(Color.Green, 2)
        BorderPen.Alignment = PenAlignment.Inset
        e.Graphics.DrawPath(BorderPen, FormShape)
        BorderPen.Dispose()

        e.Graphics.SmoothingMode = SmoothingMode.HighQuality

        Dim sf As New StringFormat(StringFormatFlags.NoWrap)
        sf.Trimming = StringTrimming.EllipsisCharacter
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString(Me.Text, Control.DefaultFont, Brushes.White, RectangleF.FromLTRB(84, 0, MinButton.GetBounds.X, 24), sf)

        If ClosePress Then
            e.Graphics.FillPath(Brushes.Blue, CloseButton)
        Else
            e.Graphics.FillPath(Brushes.Red, CloseButton)
        End If

        If MinPress Then
            e.Graphics.FillPath(Brushes.Red, MinButton)
        Else
            e.Graphics.FillPath(Brushes.Yellow, MinButton)
        End If

        Dim GlyphFont As New Font("marlett", Font.SizeInPoints, FontStyle.Bold, GraphicsUnit.Point)
        e.Graphics.DrawString("0", GlyphFont, Brushes.Black, MinButton.GetBounds, sf)
        e.Graphics.DrawString("r", GlyphFont, Brushes.Black, CloseButton.GetBounds, sf)
        GlyphFont.Dispose()

    End Sub

    Private Sub MainForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        ClosePress = CloseButton.IsVisible(e.X, e.Y) AndAlso e.Button = MouseButtons.Left
        MinPress = MinButton.IsVisible(e.X, e.Y) AndAlso e.Button = MouseButtons.Left
        FormDrag = TitleBar.IsVisible(e.X, e.Y) AndAlso _
                    e.Button = MouseButtons.Left AndAlso _
                    ClosePress = False AndAlso MinPress = False

        If FormDrag Then
            Me.Capture = False
            WndProc(Message.Create(Handle, WM_NCLBUTTONDOWN, IntPtr.op_Explicit(HT_CAPTION), IntPtr.Zero))
        End If

        Invalidate()

    End Sub

    Private Sub MainForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Dim OverClose, OverMin As Boolean
        OverClose = CloseButton.IsVisible(e.X, e.Y)
        OverMin = MinButton.IsVisible(e.X, e.Y)
        ClosePress = OverClose AndAlso e.Button = MouseButtons.Left
        MinPress = OverMin AndAlso e.Button = MouseButtons.Left

        If OverClose AndAlso ClosePress = False Then
            ToolTip1.SetToolTip(Me, "Close")
        ElseIf OverMin AndAlso MinPress = False Then
            ToolTip1.SetToolTip(Me, "Minimize")
        Else
            ToolTip1.SetToolTip(Me, "")
        End If
        Invalidate()
    End Sub

    Private Sub MainForm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Dim OverClose, OverMin As Boolean
        OverClose = CloseButton.IsVisible(e.X, e.Y)
        OverMin = MinButton.IsVisible(e.X, e.Y)

        If OverClose AndAlso ClosePress AndAlso e.Button = MouseButtons.Left Then
            Me.Close()
        End If
        If OverMin AndAlso MinPress AndAlso e.Button = MouseButtons.Left Then
            Me.WindowState = FormWindowState.Minimized
        End If

        If e.Button = MouseButtons.Right AndAlso TitleBar.IsVisible(e.X, e.Y) Then
            If OverClose = False AndAlso OverMin = False Then
                Const WM_GETSYSMENU As Integer = &H313
                If e.Button = MouseButtons.Right Then
                    Dim pos As Point = Me.PointToScreen(New Point(e.X, e.Y))
                    Dim hPos As IntPtr = IntPtr.op_Explicit(CInt((pos.Y * &H10000) Or (pos.X And &HFFFF&)))
                    WndProc(Message.Create(Handle, WM_GETSYSMENU, IntPtr.Zero, hPos))
                End If
            End If
        End If

        ClosePress = False
        MinPress = False
        FormDrag = False

        Invalidate()
    End Sub

    Private Sub MenuAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuAbout.Click
        MessageBox.Show("Shaped Form Example!" & vbCrLf & "By Mick Doherty (http://dotnetrix.co.uk)", "About...", MessageBoxButtons.OK)
    End Sub

    Private Sub MenuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExit.Click
        Application.Exit()
    End Sub

    Private Sub LabelHelp_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelHelp.MouseEnter
        HelpHot = True
        LabelHelp.ForeColor = SystemColors.HighlightText
        Invalidate()
    End Sub

    Private Sub LabelHelp_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelHelp.MouseUp
        HelpActive = True
        ContextMenu2.Show(LabelHelp, New Point(0, LabelHelp.Height))
        HelpActive = False
        LabelHelp.ForeColor = SystemColors.MenuText
        Invalidate()
    End Sub

    Private Sub LabelHelp_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelHelp.MouseLeave
        If HelpActive = False Then
            HelpHot = False
            LabelHelp.ForeColor = SystemColors.MenuText
        End If
        Invalidate()
    End Sub

    Private Sub LabelFile_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelFile.MouseEnter
        FileHot = True
        LabelFile.ForeColor = SystemColors.HighlightText
        Invalidate()
    End Sub

    Private Sub LabelFile_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelFile.MouseUp
        FileActive = True
        ContextMenu1.Show(LabelFile, New Point(0, LabelFile.Height))
        FileActive = False
        LabelFile.ForeColor = SystemColors.MenuText
        Invalidate()
    End Sub

    Private Sub LabelFile_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelFile.MouseLeave
        If FileActive = False Then
            FileHot = False
            LabelFile.ForeColor = SystemColors.MenuText
        End If
        Invalidate()
    End Sub

    Private Sizing As Boolean = False
    Private SizeOffset As Point = Point.Empty

    Private Sub LabelResize_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelResize.MouseDown
        Sizing = True
        SizeOffset = New Point(Me.Right - Cursor.Position.X, Me.Bottom - Cursor.Position.Y)
    End Sub

    Private Sub LabelResize_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelResize.MouseMove
        If Sizing = True Then
            'Clip cursor to dissallow sizing of form below 250x100
            Dim ClipRectangle As Rectangle = RectangleToScreen(New Rectangle(250, 100, Width, Height))
            ClipRectangle.Offset(SizeOffset)
            Cursor.Clip = ClipRectangle
            Me.Size = New Size(Cursor.Position.X + SizeOffset.X - Location.X, Cursor.Position.Y + SizeOffset.Y - Location.Y)
        End If
    End Sub

    Private Sub LabelResize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelResize.MouseUp
        Sizing = False
        Cursor.Clip = Nothing
    End Sub

    Private Sub MainForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Region = New Region(FormShape)
    End Sub

End Class


