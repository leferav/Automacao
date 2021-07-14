<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesquisaDomicilio
    Inherits FeedAutomacao.frmPadraoPesquisa

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDomicilio = New FeedAutomacao.fbTextBox()
        Me.lblDom = New FeedAutomacao.fbLabel()
        Me.txtProdutor = New FeedAutomacao.fbTextBox()
        Me.lblProdutor = New FeedAutomacao.fbLabel()
        Me.cbInativo = New FeedAutomacao.fbCheckBox()
        Me.txtIE = New FeedAutomacao.fbMaskBox()
        Me.FbLabel13 = New FeedAutomacao.fbLabel()
        Me.txtCNPJ = New FeedAutomacao.fbMaskBox()
        Me.FbLabel3 = New FeedAutomacao.fbLabel()
        Me.txtFantasia = New FeedAutomacao.fbTextBox()
        Me.FbLabel1 = New FeedAutomacao.fbLabel()
        Me.txtCodCliExterno = New FeedAutomacao.fbTextBox()
        Me.txtCodCliInt = New FeedAutomacao.fbTextBox()
        Me.FbLabel2 = New FeedAutomacao.fbLabel()
        Me.FbLabel4 = New FeedAutomacao.fbLabel()
        Me.menuFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuFiltro
        '
        Me.menuFiltro.Controls.Add(Me.FbLabel4)
        Me.menuFiltro.Controls.Add(Me.FbLabel2)
        Me.menuFiltro.Controls.Add(Me.txtCodCliInt)
        Me.menuFiltro.Controls.Add(Me.txtCodCliExterno)
        Me.menuFiltro.Controls.Add(Me.txtFantasia)
        Me.menuFiltro.Controls.Add(Me.FbLabel1)
        Me.menuFiltro.Controls.Add(Me.FbLabel3)
        Me.menuFiltro.Controls.Add(Me.txtCNPJ)
        Me.menuFiltro.Controls.Add(Me.txtIE)
        Me.menuFiltro.Controls.Add(Me.FbLabel13)
        Me.menuFiltro.Controls.Add(Me.cbInativo)
        Me.menuFiltro.Controls.Add(Me.txtProdutor)
        Me.menuFiltro.Controls.Add(Me.lblProdutor)
        Me.menuFiltro.Controls.Add(Me.lblDom)
        Me.menuFiltro.Controls.Add(Me.txtDomicilio)
        Me.menuFiltro.Fechar = True
        Me.menuFiltro.Size = New System.Drawing.Size(770, 179)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtDomicilio, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.lblDom, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.lblProdutor, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtProdutor, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.cbInativo, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel13, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtIE, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtCNPJ, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel3, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel1, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtFantasia, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtCodCliExterno, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.txtCodCliInt, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel2, 0)
        Me.menuFiltro.Controls.SetChildIndex(Me.FbLabel4, 0)
        '
        'txtDomicilio
        '
        Me.txtDomicilio.BackColor = System.Drawing.Color.White
        Me.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomicilio.botaoClear = False
        Me.txtDomicilio.Campo = ""
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.ControlDB = Nothing
        Me.txtDomicilio.Location = New System.Drawing.Point(79, 53)
        Me.txtDomicilio.MaxLength = 100
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.NomeCampoMsg = "Domicilio"
        Me.txtDomicilio.Requerido = False
        Me.txtDomicilio.Size = New System.Drawing.Size(679, 20)
        Me.txtDomicilio.TabIndex = 3
        Me.txtDomicilio.Valor = Nothing
        Me.txtDomicilio.valorVazio = ""
        '
        'lblDom
        '
        Me.lblDom.AutoSize = True
        Me.lblDom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblDom.Location = New System.Drawing.Point(23, 56)
        Me.lblDom.Name = "lblDom"
        Me.lblDom.Size = New System.Drawing.Size(54, 13)
        Me.lblDom.TabIndex = 8
        Me.lblDom.Text = "Domicílio:"
        '
        'txtProdutor
        '
        Me.txtProdutor.BackColor = System.Drawing.Color.White
        Me.txtProdutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdutor.botaoClear = False
        Me.txtProdutor.Campo = ""
        Me.txtProdutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutor.ControlDB = Nothing
        Me.txtProdutor.Location = New System.Drawing.Point(79, 77)
        Me.txtProdutor.MaxLength = 100
        Me.txtProdutor.Name = "txtProdutor"
        Me.txtProdutor.NomeCampoMsg = "Produtor"
        Me.txtProdutor.Requerido = False
        Me.txtProdutor.Size = New System.Drawing.Size(679, 20)
        Me.txtProdutor.TabIndex = 4
        Me.txtProdutor.Valor = Nothing
        Me.txtProdutor.valorVazio = ""
        '
        'lblProdutor
        '
        Me.lblProdutor.AutoSize = True
        Me.lblProdutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblProdutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblProdutor.Location = New System.Drawing.Point(27, 80)
        Me.lblProdutor.Name = "lblProdutor"
        Me.lblProdutor.Size = New System.Drawing.Size(50, 13)
        Me.lblProdutor.TabIndex = 10
        Me.lblProdutor.Text = "Produtor:"
        '
        'cbInativo
        '
        Me.cbInativo.AutoSize = True
        Me.cbInativo.Campo = ""
        Me.cbInativo.ControlDB = Nothing
        Me.cbInativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbInativo.Location = New System.Drawing.Point(679, 31)
        Me.cbInativo.Name = "cbInativo"
        Me.cbInativo.Size = New System.Drawing.Size(55, 17)
        Me.cbInativo.TabIndex = 2
        Me.cbInativo.Text = "Inativo"
        Me.cbInativo.UseVisualStyleBackColor = True
        Me.cbInativo.Valor = Nothing
        Me.cbInativo.valorVazio = False
        Me.cbInativo.Visible = False
        '
        'txtIE
        '
        Me.txtIE.BackColor = System.Drawing.Color.White
        Me.txtIE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIE.ControlDB = Nothing
        Me.txtIE.DB = Nothing
        Me.txtIE.Location = New System.Drawing.Point(79, 29)
        Me.txtIE.Mask = "000,000,000,00-00"
        Me.txtIE.Name = "txtIE"
        Me.txtIE.NomeCampoMsg = "IE"
        Me.txtIE.Requerido = False
        Me.txtIE.Size = New System.Drawing.Size(106, 20)
        Me.txtIE.TabIndex = 0
        Me.txtIE.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'FbLabel13
        '
        Me.FbLabel13.AutoSize = True
        Me.FbLabel13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel13.Location = New System.Drawing.Point(23, 32)
        Me.FbLabel13.Name = "FbLabel13"
        Me.FbLabel13.Size = New System.Drawing.Size(54, 13)
        Me.FbLabel13.TabIndex = 320
        Me.FbLabel13.Text = "Insc. Est.:"
        '
        'txtCNPJ
        '
        Me.txtCNPJ.BackColor = System.Drawing.Color.White
        Me.txtCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCNPJ.ControlDB = Nothing
        Me.txtCNPJ.DB = Nothing
        Me.txtCNPJ.Location = New System.Drawing.Point(245, 29)
        Me.txtCNPJ.Mask = "00,000,000/0000-00"
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.NomeCampoMsg = "CNPJ"
        Me.txtCNPJ.Requerido = False
        Me.txtCNPJ.Size = New System.Drawing.Size(124, 20)
        Me.txtCNPJ.TabIndex = 1
        Me.txtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'FbLabel3
        '
        Me.FbLabel3.AutoSize = True
        Me.FbLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel3.Location = New System.Drawing.Point(206, 32)
        Me.FbLabel3.Name = "FbLabel3"
        Me.FbLabel3.Size = New System.Drawing.Size(37, 13)
        Me.FbLabel3.TabIndex = 322
        Me.FbLabel3.Text = "CNPJ:"
        '
        'txtFantasia
        '
        Me.txtFantasia.BackColor = System.Drawing.Color.White
        Me.txtFantasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFantasia.botaoClear = False
        Me.txtFantasia.Campo = ""
        Me.txtFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFantasia.ControlDB = Nothing
        Me.txtFantasia.Location = New System.Drawing.Point(79, 101)
        Me.txtFantasia.MaxLength = 100
        Me.txtFantasia.Name = "txtFantasia"
        Me.txtFantasia.NomeCampoMsg = "Produtor"
        Me.txtFantasia.Requerido = False
        Me.txtFantasia.Size = New System.Drawing.Size(679, 20)
        Me.txtFantasia.TabIndex = 5
        Me.txtFantasia.Valor = Nothing
        Me.txtFantasia.valorVazio = ""
        '
        'FbLabel1
        '
        Me.FbLabel1.AutoSize = True
        Me.FbLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel1.Location = New System.Drawing.Point(27, 104)
        Me.FbLabel1.Name = "FbLabel1"
        Me.FbLabel1.Size = New System.Drawing.Size(50, 13)
        Me.FbLabel1.TabIndex = 324
        Me.FbLabel1.Text = "Fantasia:"
        '
        'txtCodCliExterno
        '
        Me.txtCodCliExterno.BackColor = System.Drawing.Color.White
        Me.txtCodCliExterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliExterno.botaoClear = False
        Me.txtCodCliExterno.Campo = ""
        Me.txtCodCliExterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodCliExterno.ControlDB = Nothing
        Me.txtCodCliExterno.Location = New System.Drawing.Point(78, 127)
        Me.txtCodCliExterno.MaxLength = 100
        Me.txtCodCliExterno.Name = "txtCodCliExterno"
        Me.txtCodCliExterno.NomeCampoMsg = "Domicilio"
        Me.txtCodCliExterno.Requerido = False
        Me.txtCodCliExterno.Size = New System.Drawing.Size(217, 20)
        Me.txtCodCliExterno.TabIndex = 325
        Me.txtCodCliExterno.Valor = Nothing
        Me.txtCodCliExterno.valorVazio = ""
        '
        'txtCodCliInt
        '
        Me.txtCodCliInt.BackColor = System.Drawing.Color.White
        Me.txtCodCliInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliInt.botaoClear = False
        Me.txtCodCliInt.Campo = ""
        Me.txtCodCliInt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodCliInt.ControlDB = Nothing
        Me.txtCodCliInt.Location = New System.Drawing.Point(541, 127)
        Me.txtCodCliInt.MaxLength = 100
        Me.txtCodCliInt.Name = "txtCodCliInt"
        Me.txtCodCliInt.NomeCampoMsg = "Domicilio"
        Me.txtCodCliInt.Requerido = False
        Me.txtCodCliInt.Size = New System.Drawing.Size(217, 20)
        Me.txtCodCliInt.TabIndex = 326
        Me.txtCodCliInt.Valor = Nothing
        Me.txtCodCliInt.valorVazio = ""
        '
        'FbLabel2
        '
        Me.FbLabel2.AutoSize = True
        Me.FbLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel2.Location = New System.Drawing.Point(17, 129)
        Me.FbLabel2.Name = "FbLabel2"
        Me.FbLabel2.Size = New System.Drawing.Size(58, 13)
        Me.FbLabel2.TabIndex = 327
        Me.FbLabel2.Text = "Cod.Cli.Ex:"
        '
        'FbLabel4
        '
        Me.FbLabel4.AutoSize = True
        Me.FbLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FbLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FbLabel4.Location = New System.Drawing.Point(477, 129)
        Me.FbLabel4.Name = "FbLabel4"
        Me.FbLabel4.Size = New System.Drawing.Size(58, 13)
        Me.FbLabel4.TabIndex = 328
        Me.FbLabel4.Text = "Cod.Cli.Int."
        '
        'frmPesquisaDomicilio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.campoFoco = Me.txtIE
        Me.ClientSize = New System.Drawing.Size(770, 468)
        Me.Filtro = True
        Me.GridVisivel = True
        Me.Name = "frmPesquisaDomicilio"
        Me.Text = "Pesquisar Domicílio"
        Me.menuFiltro.ResumeLayout(False)
        Me.menuFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDomicilio As FeedAutomacao.fbTextBox
    Friend WithEvents lblDom As FeedAutomacao.fbLabel
    Friend WithEvents txtProdutor As FeedAutomacao.fbTextBox
    Friend WithEvents lblProdutor As FeedAutomacao.fbLabel
    Friend WithEvents cbInativo As FeedAutomacao.fbCheckBox
    Friend WithEvents FbLabel3 As FeedAutomacao.fbLabel
    Friend WithEvents txtCNPJ As FeedAutomacao.fbMaskBox
    Friend WithEvents txtIE As FeedAutomacao.fbMaskBox
    Friend WithEvents FbLabel13 As FeedAutomacao.fbLabel
    Friend WithEvents txtFantasia As fbTextBox
    Friend WithEvents FbLabel1 As fbLabel
    Friend WithEvents FbLabel4 As fbLabel
    Friend WithEvents FbLabel2 As fbLabel
    Friend WithEvents txtCodCliInt As fbTextBox
    Friend WithEvents txtCodCliExterno As fbTextBox
End Class
