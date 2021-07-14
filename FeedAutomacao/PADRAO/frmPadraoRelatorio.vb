Public Class frmPadraoRelatorio

    Public Overridable Sub Relatorio()

    End Sub

    Public Overridable Function Validar() As Boolean
        Return True
    End Function

    Dim tp As TipoRel.Rel
    Dim dts As New DataSet
    Dim _papelNormal As Boolean = True


    Public Property PDF As System.IO.Stream

    <System.ComponentModel.Category("FeedBack")> _
    Public Property AbreImpressao As Boolean = True

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

    <System.ComponentModel.Category("FeedBack")>
    Public Property PapelNormal() As Boolean
        Get
            Return _papelNormal
        End Get
        Set(ByVal value As Boolean)
            _papelNormal = value
        End Set
    End Property

    Public Property MostraPainelEsquerdo = True

    Private Sub btnRelatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorio.Click
        clica()
    End Sub

    Private Sub Clica()
        If Validar() Then
            geraRel()
        End If
    End Sub

    Public Sub ClicaPorFora()
        clica()
    End Sub

    Private Sub geraRel()
        dts = New DataSet
        Relatorio()
        If Me.TipoRel <> FeedAutomacao.TipoRel.Rel.SEMREL Then
            My.Forms.frmGeraRelatorio.TipoRel = Me.TipoRel
            My.Forms.frmGeraRelatorio.DataSetRel = Me.DataSetRel
            My.Forms.frmGeraRelatorio.PapelNormal = Me.PapelNormal
            My.Forms.frmGeraRelatorio.MostraPainelEsquerdo = Me.MostraPainelEsquerdo
            If AbreImpressao = True Then
                My.Forms.frmGeraRelatorio.ShowDialog()
            Else
                My.Forms.frmGeraRelatorio.CarregaLoad_Sem_Abrir()
            End If
            'PDF = My.Forms.frmGeraRelatorio.GeraPDF

            GC.Collect()
            GC.WaitForPendingFinalizers()
        End If
    End Sub

    Private Sub frmPadraoRelatorio_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If Not e.Modifiers = Keys.Shift AndAlso e.KeyCode = Keys.F4 Then
            If sender.activecontrol.GetType().Name = "fbLookUp" Then
                sender.activecontrol.abreFormLookUP()
            End If
        ElseIf e.Modifiers = Keys.Shift AndAlso e.KeyCode = Keys.F4 Then
            If sender.activecontrol.GetType().Name = "fbLookUp" Then
                sender.activecontrol.selectID = -1
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            If Validar() Then
                geraRel()
            End If
        End If
    End Sub

    Private Sub frmPadraoRelatorio_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.WindowState = FormWindowState.Normal
    End Sub

End Class
