<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPadraoCadastroDados2
    Inherits frmPadrao

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPadraoCadastroDados2))
        Me.pnlBarra = New fbPanel()
        Me.pnlCampos = New fbPanel()
        Me.fbControlDados = New fbControler()
        Me.SuspendLayout()
        '
        'pnlBarra
        '
        Me.pnlBarra.BackColor = System.Drawing.Color.LightSlateGray
        Me.pnlBarra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBarra.Location = New System.Drawing.Point(0, 363)
        Me.pnlBarra.Name = "pnlBarra"
        Me.pnlBarra.Size = New System.Drawing.Size(558, 53)
        Me.pnlBarra.TabIndex = 1
        '
        'pnlCampos
        '
        Me.pnlCampos.AutoScroll = True
        Me.pnlCampos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCampos.Location = New System.Drawing.Point(0, 0)
        Me.pnlCampos.Name = "pnlCampos"
        Me.pnlCampos.Size = New System.Drawing.Size(558, 363)
        Me.pnlCampos.TabIndex = 2
        '
        'fbControlDados
        '
        Me.fbControlDados.CampoFoco = Nothing
        Me.fbControlDados.cancelaOperacao = False
        Me.fbControlDados.conDB = Nothing
        Me.fbControlDados.dadosDB = Nothing
        Me.fbControlDados.dadosTabela = Nothing
        Me.fbControlDados.frmCadastro = Nothing
        Me.fbControlDados.ID = -1
        Me.fbControlDados.listControles = CType(resources.GetObject("fbControlDados.listControles"), System.Collections.Generic.List(Of Object))
        Me.fbControlDados.Tabela = Nothing
        '
        'frmPadraoCadastroDados2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(558, 416)
        Me.Controls.Add(Me.pnlCampos)
        Me.Controls.Add(Me.pnlBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmPadraoCadastroDados2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents pnlCampos As fbPanel
    Protected Friend WithEvents pnlBarra As fbPanel
    Public WithEvents fbControlDados As fbControler

End Class
