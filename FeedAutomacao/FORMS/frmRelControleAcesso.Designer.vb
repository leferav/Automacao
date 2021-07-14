<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelControleAcesso
    Inherits FeedAutomacao.frmPadraoRelatorio

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelControleAcesso))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIni = New FeedAutomacao.fbDate()
        Me.txtFim = New FeedAutomacao.fbDate()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbbPessoa = New FeedAutomacao.fbComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Pessoa:"
        '
        'txtIni
        '
        Me.txtIni.BackColor = System.Drawing.Color.White
        Me.txtIni.ControlDB = Nothing
        Me.txtIni.CustomFormat = "dd/MM/yyyy"
        Me.txtIni.DataAtual = False
        Me.txtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtIni.Location = New System.Drawing.Point(52, 10)
        Me.txtIni.Name = "txtIni"
        Me.txtIni.NomeCampoMsg = "FbDate1"
        Me.txtIni.Requerido = False
        Me.txtIni.ShowCheckBox = True
        Me.txtIni.Size = New System.Drawing.Size(105, 20)
        Me.txtIni.TabIndex = 13
        Me.txtIni.Value = New Date(2018, 3, 29, 16, 48, 34, 189)
        '
        'txtFim
        '
        Me.txtFim.BackColor = System.Drawing.Color.White
        Me.txtFim.ControlDB = Nothing
        Me.txtFim.CustomFormat = "dd/MM/yyyy"
        Me.txtFim.DataAtual = False
        Me.txtFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFim.Location = New System.Drawing.Point(192, 10)
        Me.txtFim.Name = "txtFim"
        Me.txtFim.NomeCampoMsg = "FbDate1"
        Me.txtFim.Requerido = False
        Me.txtFim.ShowCheckBox = True
        Me.txtFim.Size = New System.Drawing.Size(105, 20)
        Me.txtFim.TabIndex = 14
        Me.txtFim.Value = New Date(2018, 3, 29, 16, 48, 34, 189)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "De:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Até:"
        '
        'cbbPessoa
        '
        Me.cbbPessoa.AgrupadoPor = Nothing
        Me.cbbPessoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbPessoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbPessoa.Campo = ""
        Me.cbbPessoa.campoID = "ID"
        Me.cbbPessoa.campoOrdem = Nothing
        Me.cbbPessoa.campoRelacionamento = Nothing
        Me.cbbPessoa.campoSelecionavel = "Nome"
        Me.cbbPessoa.campoSql = Nothing
        Me.cbbPessoa.campoSqlID = Nothing
        Me.cbbPessoa.carrega2Parametro = False
        Me.cbbPessoa.carregaClick = True
        Me.cbbPessoa.comDistinct = False
        Me.cbbPessoa.ControlDB = Nothing
        Me.cbbPessoa.DisplayMember = "Texto"
        Me.cbbPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbPessoa.Filtro = Nothing
        Me.cbbPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbPessoa.FormattingEnabled = True
        Me.cbbPessoa.Location = New System.Drawing.Point(52, 35)
        Me.cbbPessoa.Name = "cbbPessoa"
        Me.cbbPessoa.NomeCampoMsg = "FbComboBox1"
        Me.cbbPessoa.Ordena = Nothing
        Me.cbbPessoa.Requerido = False
        Me.cbbPessoa.Size = New System.Drawing.Size(245, 21)
        Me.cbbPessoa.TabelaRelacionamento = "TB_PESSOA"
        Me.cbbPessoa.TabIndex = 17
        Me.cbbPessoa.TextoSelecionar = "Selecione a Pessoa"
        Me.cbbPessoa.Valor = Nothing
        Me.cbbPessoa.ValorRelacionamento = Nothing
        Me.cbbPessoa.ValorSelecionado = "-1"
        Me.cbbPessoa.valorVazio = -1
        Me.cbbPessoa.ValueMember = "Valor"
        '
        'frmRelControleAcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(315, 104)
        Me.Controls.Add(Me.cbbPessoa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFim)
        Me.Controls.Add(Me.txtIni)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRelControleAcesso"
        Me.Text = "Relatório de Controle Acessos"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtIni, 0)
        Me.Controls.SetChildIndex(Me.txtFim, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.cbbPessoa, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIni As fbDate
    Friend WithEvents txtFim As fbDate
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbbPessoa As fbComboBox
End Class
