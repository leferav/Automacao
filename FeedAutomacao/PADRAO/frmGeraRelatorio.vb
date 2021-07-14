Imports System.IO
Public Class frmGeraRelatorio

    Dim tp As TipoRel.Rel
    Dim dts As DataSet
    Dim _papelNormal As Boolean = True
    Dim NumeroRel As String = ""


    <System.ComponentModel.Category("FeedBack")> _
    Public Property TipoRel() As TipoRel.Rel
        Get
            Return tp
        End Get
        Set(ByVal value As TipoRel.Rel)
            tp = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property DataSetRel() As DataSet
        Get
            Return dts
        End Get
        Set(ByVal value As DataSet)
            dts = value
        End Set
    End Property

    <System.ComponentModel.Category("FeedBack")> _
    Public Property PapelNormal() As Boolean
        Get
            Return _papelNormal
        End Get
        Set(ByVal value As Boolean)
            _papelNormal = value
        End Set
    End Property

    Dim _war As Boolean
    Public Property FatWar() As Boolean
        Get
            Return _war
        End Get
        Set(value As Boolean)
            _war = value
        End Set
    End Property

    Public Property LucroContrato As Boolean = False

    'Dim _loteWar As Integer
    'Public Property LoteWar() As Integer
    '    Get
    '        Return _loteWar
    '    End Get
    '    Set(ByVal value As Integer)
    '        _loteWar = value
    '    End Set
    'End Property

    Dim _sai As Boolean
    Public Property FatSai() As Boolean
        Get
            Return _sai
        End Get
        Set(value As Boolean)
            _sai = value
        End Set
    End Property

    Dim _trans As Boolean
    Public Property FatTrans() As Boolean
        Get
            Return _trans
        End Get
        Set(value As Boolean)
            _trans = value
        End Set
    End Property

    Dim _serv As Boolean
    Public Property FatServ() As Boolean
        Get
            Return _serv
        End Get
        Set(value As Boolean)
            _serv = value
        End Set
    End Property

    Dim _tpProd As Boolean
    Public Property FatTpProd() As Boolean
        Get
            Return _tpProd
        End Get
        Set(value As Boolean)
            _tpProd = value
        End Set
    End Property

    Dim _semMov As Boolean
    Public Property LoteSemMov() As Boolean
        Get
            Return _semMov
        End Get
        Set(ByVal value As Boolean)
            _semMov = value
        End Set
    End Property

    Dim _semCert As Boolean
    Public Property LoteSemCert() As Boolean
        Get
            Return _semCert
        End Get
        Set(ByVal value As Boolean)
            _semCert = value
        End Set
    End Property

    Dim _pgtAdiantado As Boolean
    Public Property PgtAdiantado() As Boolean
        Get
            Return _pgtAdiantado
        End Get
        Set(value As Boolean)
            _pgtAdiantado = value
        End Set
    End Property

    Dim _gsSai As Boolean = True
    Public Property GSSai() As Boolean
        Get
            Return _gsSai
        End Get
        Set(ByVal value As Boolean)
            _gsSai = value
        End Set
    End Property

    Public Property GSMarcacoes() As Boolean = True

    Dim _gsPrevia As Integer = True
    Public Property GSPrevia() As Integer
        Get
            Return _gsPrevia
        End Get
        Set(ByVal value As Integer)
            _gsPrevia = value
        End Set
    End Property

    Dim _gsParc As Boolean = True
    Public Property GSParc() As Boolean
        Get
            Return _gsParc
        End Get
        Set(ByVal value As Boolean)
            _gsParc = value
        End Set
    End Property

    Dim _gsEntBag As Boolean = True
    Public Property GSEntBag() As Boolean
        Get
            Return _gsEntBag
        End Get
        Set(ByVal value As Boolean)
            _gsEntBag = value
        End Set
    End Property

    Dim _vol As Boolean = True
    Public Property Vol() As Boolean
        Get
            Return _vol
        End Get
        Set(ByVal value As Boolean)
            _vol = value
        End Set
    End Property


    Public Property MostraPainelEsquerdo = True

    Private Sub frmGeraRelatorio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'REMOVENDO BOTOES ADICIONAIS NA BARRA DE COMANDO DO CRYSTAL REPORTS**********
        For Each ctr In crvReport.Controls
            Dim tipo As Type = ctr.GetType
            If tipo.FullName = "System.Windows.Forms.ToolStrip" Then
                For i As Integer = 0 To ctr.items.count - 1
                    If ctr.items(i).name = "btnEmail" Then ctr.items.RemoveAt(i)
                Next
            End If
        Next
        '*******************************************************************
        MostraPainelEsquerdo = True
    End Sub

    Public Sub CarregaLoad_Sem_Abrir()
        EventoCarregaLoad()
    End Sub

    Private Sub frmGeraRelatorio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        EventoCarregaLoad()
    End Sub

    Private Sub EventoCarregaLoad()
        Me.TopMost = False
        geraRelatorio()
        Try
            Seta_Param(rpt)
            crvReport.ReportSource.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            crvReport.ReuseParameterValuesOnRefresh = True
            crvReport.Refresh()
            'Dim crPM As CrystalDecisions.Shared.PageMargins
            'crPM.topMargin = 0.38
            'crPM.leftMargin = 0.36
            'crPM.bottomMargin = 0.37
            'crPM.rightMargin = 0.35
            'crvReport.ReportSource.PrintOptions.ApplyPageMargins(crPM)

            'crvReport.ReportSource.SetParameterValue(0, My.Forms.frmPadrao.Usuario)
            'crvReport.ReportSource.SetParameterValue(1, NumeroRel)
        Catch : End Try
        Try
            'For Each par As CrystalDecisions.Shared.ParameterField In crvReport.ReportSource.ParameterFields
            '    If par.Name = "usuario" Or par.Name = "Usuario" Then crvReport.ReportSource.SetParameterValue(par.Name, My.Forms.frmPadrao.Usuario)
            '    'If par.Name = "usuario" Or par.Name = "Usuario" Or par.Name = "Funcionario" Then
            '    'crvReport.ReportSource.SetParameterValue(par.Name, My.Forms.frmPadrao.Usuario)
            '    'Else
            '    '    crvReport.ReportSource.SetParameterValue(par.Name, "")
            '    'End If
            'Next
        Catch : End Try


        'ADCIONANDO BOTOES NA BARRA DE COMANDO DO CRYSTAL REPORTS**********
        For Each ctr In crvReport.Controls
            Dim tipo As Type = ctr.GetType
            If tipo.FullName = "System.Windows.Forms.ToolStrip" Then
                Dim ts As ToolStrip = DirectCast(ctr, ToolStrip)

                'ADICIONANDO BOTAO DE EMAIL
                Dim BtnEmail As New ToolStripButton
                BtnEmail.Name = "btnEmail"
                'BtnEmail.Image = My.Resources.emailsend
                BtnEmail.ToolTipText = "Enviar Relatório por Email..."
                AddHandler BtnEmail.Click, AddressOf BtnEmail_Click
                ctr.Items.Add(BtnEmail)
                '*****************************
            End If
        Next
        '*******************************************************************
        If MostraPainelEsquerdo Then
            Me.crvReport.ShowGroupTreeButton = True
            Me.crvReport.ShowParameterPanelButton = True
            Me.crvReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.GroupTree
        Else
            Me.crvReport.ShowGroupTreeButton = False
            Me.crvReport.ShowParameterPanelButton = False
            Me.crvReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        End If

    End Sub

    Dim lt As List(Of Object)

    Public Property ListaParametros() As List(Of Object)
        Get
            Return lt
        End Get
        Set(ByVal value As List(Of Object))
            lt = value
        End Set
    End Property

    Public Class ParametrosCrystal
        Public Sub New(nomeParam As String, valorParam As Object)
            nome = nomeParam
            valor = valorParam
        End Sub
        Public Property nome As String
        Public Property valor As Object
    End Class

    Private Sub Seta_Param(r As Object)
        Try

            For Each par As CrystalDecisions.Shared.ParameterField In r.ParameterFields
                If par.Name = "usuario" Then r.SetParameterValue("usuario", My.Forms.frmPadrao.Usuario)
                If par.Name = "Usuario" Then r.SetParameterValue("Usuario", My.Forms.frmPadrao.Usuario)
                If par.Name = "numeroRel" Then r.SetParameterValue("numeroRel", NumeroRel)
                If par.Name = "Funcionario" Then r.SetParameterValue("Funcionario", My.Forms.frmPadrao.Usuario)
                'If par.Name = "arquivoRpt" Then r.SetParameterValue("arquivoRpt", ArquivoRpt)
                'If par.Name = "Empresa_logoURL" Then r.SetParameterValue("Empresa_logoURL", imagemEmpresa)
                'If par.Name = "Logo_Feed" Then r.SetParameterValue("Logo_Feed", imagemFeed)
                'If par.Name = "Empresa_Nome" Then r.SetParameterValue("Empresa_Nome", My.Forms.frmPadrao.DadosEmpresa.Item("Nome"))
                'If par.Name = "Empresa_CGC" Then r.SetParameterValue("Empresa_CGC", clGeral.MaskCNPJ(My.Forms.frmPadrao.DadosEmpresa.Item("CNPJ")))
                'If par.Name = "Empresa_Cidade" Then r.SetParameterValue("Empresa_Cidade", My.Forms.frmPadrao.DadosEmpresa.Item("Cidade"))
                'If par.Name = "Empresa_Estado" Then r.SetParameterValue("Empresa_Estado", My.Forms.frmPadrao.DadosEmpresa.Item("Estado"))
                'If par.Name = "Empresa_Endereco" Then r.SetParameterValue("Empresa_Endereco", EnderecoEmpresa())
                'If par.Name = "filtro" Then r.SetParameterValue("filtro", Me.Filtro)
            Next

            For Each l As ParametrosCrystal In ListaParametros
                r.SetParameterValue(l.nome, l.valor)
            Next

            ListaParametros.Clear()

            'r.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            'Dim crPM As CrystalDecisions.Shared.PageMargins
            'crPM.topMargin = 0.38
            'crPM.leftMargin = 0.36
            'crPM.bottomMargin = 0.37
            'crPM.rightMargin = 0.35
            ''r.PrintOptions.ApplyPageMargins(crPM)
        Catch : End Try
    End Sub

    Public Function GeraPDF() As System.IO.Stream
        Return crvReport.ReportSource.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
    End Function

    Private Sub BtnEmail_Click(ByVal sender As Object, ByVal e As EventArgs)
        EnviaEmail()
    End Sub

    Private Sub EnviaEmail()
        Try
            'Dim frm As New Fr frmEnviaEmail

            'GC.Collect()

            'If Not System.IO.Directory.Exists(My.Computer.FileSystem.CurrentDirectory & "\REL\") Then
            '    System.IO.Directory.CreateDirectory(My.Computer.FileSystem.CurrentDirectory & "\REL\")
            'End If

            'Dim arq As String = My.Computer.FileSystem.CurrentDirectory & "\REL\" & _
            '    System.Enum.GetName(GetType(TipoRel.Rel), tp) + ".PDF"

            'If System.IO.File.Exists(arq) Then
            '    Try
            '        IO.File.Delete(arq)
            '    Catch ex As Exception

            '    End Try
            'End If

            'crvReport.ReportSource.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, arq)

            'frm.sArquivo = arq
            'frm.txtAssunto.Text = Me.Text

            'Me.TopMost = False
            'frm.ShowDialog()
            'Me.TopMost = True
            'frm.Dispose()

            'File.Delete(arq)

        Catch ex As Exception

        End Try
    End Sub

    Dim rpt As Object

    Private Sub geraRelatorio()
        Select Case tp

            Case FeedAutomacao.TipoRel.Rel.UpdateImprimeSolicitações
                Me.Text = "Impressão de Solicitação"
                rpt = New rptImprimeSolicitacao
                rpt.SetDataSource(dts)
                crvReport.ReportSource = rpt

            Case FeedAutomacao.TipoRel.Rel.updateRelSolicitações
                Me.Text = "Relatório de Solicitação"
                rpt = New rptImprimeSolicitacao2
                rpt.SetDataSource(dts)
                crvReport.ReportSource = rpt


            Case FeedAutomacao.TipoRel.Rel.updateRelSolicitaçõesComObs
                Me.Text = "Relatório de Solicitação com Observações"
                rpt = New rptImprimeSolicitacao3
                rpt.SetDataSource(dts)
                crvReport.ReportSource = rpt

            Case FeedAutomacao.TipoRel.Rel.updateClientes
                Me.Text = "Relatório de Clientes"
                rpt = New rptImprimeClientes
                rpt.SetDataSource(dts)
                crvReport.ReportSource = rpt

            Case FeedAutomacao.TipoRel.Rel.UpdateAtendentes
                Me.Text = "Relatório de Atendentes"
                rpt = New rptImprimeAtendentes
                rpt.SetDataSource(dts)
                crvReport.ReportSource = rpt

            Case FeedAutomacao.TipoRel.Rel.updateResponsaveis
                Me.Text = "Relatório de Usuários Responsáveis pelo Sistema "
                rpt = New rptImprimeClientesResponsaveis
                rpt.SetDataSource(dts)
                crvReport.ReportSource = rpt

            Case FeedAutomacao.TipoRel.Rel.updateAcesso
                Me.Text = "Relatório de Acesso"
                rpt = New rptImprimeClientesAcesso
                rpt.SetDataSource(dts)
                crvReport.ReportSource = rpt


            Case FeedAutomacao.TipoRel.Rel.RelControleAcesso
                Me.Text = "Relatório Controle de Acessos"
                rpt = New rptImprimeControleAcesso
                rpt.SetDataSource(dts)
                crvReport.ReportSource = rpt

            Case FeedAutomacao.TipoRel.Rel.RelControlePortariaTicket
                Me.Text = "Relatório Controle de Acessos Portaria com Ticket"
                rpt = New rptImprimeTicket
                rpt.SetDataSource(dts)
                crvReport.ReportSource = rpt


        End Select
    End Sub

    Private Sub crvReport_ReportRefresh(source As Object, e As CrystalDecisions.Windows.Forms.ViewerEventArgs) Handles crvReport.ReportRefresh
        Try
            For Each par As CrystalDecisions.Shared.ParameterField In crvReport.ReportSource.ParameterFields
                If par.Name = "usuario" Or par.Name = "Usuario" Or par.Name = "Funcionario" Then
                    crvReport.ReportSource.SetParameterValue(par.Name, My.Forms.frmPadrao.Usuario)
                    'Else
                    '    crvReport.ReportSource.SetParameterValue(par.Name, "")
                End If
            Next
        Catch : End Try
    End Sub

End Class

Public Class TipoRel
    Public Enum Rel
        UpdateImprimeSolicitações
        SEMREL
        updateRelSolicitações
        updateRelSolicitaçõesComObs
        updateClientes
        UpdateAtendentes
        updateResponsaveis
        updateAcesso

        RelControleAcesso
        RelControlePortariaTicket
    End Enum



End Class
