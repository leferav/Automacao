Public Class frmLoguin

    Public logado As Boolean = False
    Dim dr As New dtsLoguinTableAdapters.verificaLoginTableAdapter
    Dim dt As New dtsLoguin.verificaLoginDataTable

    Private Sub txtSenha_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSenha.KeyUp
        If e.KeyCode = Keys.Enter Then
            logar()
        End If

    End Sub


    Private Function setaContexto() As Boolean
        Me.Hide()
        My.Forms.frmSelecionaContexto2.StartPosition = FormStartPosition.CenterScreen
        My.Forms.frmSelecionaContexto2.ShowDialog()
        If My.Forms.frmSelecionaContexto2.empresaSel <> -1 Then
            My.Forms.frmPadrao.IDEmpresa = My.Forms.frmSelecionaContexto2.empresaSel
            Return True
        Else
            MsgBox("Empresa não Selecionada")
        End If
        Return False
    End Function


    Private Sub logar()
        If txtUsuario.Text <> "" Then
            If txtSenha.Text <> "" Then
                dt = dr.GetData(txtUsuario.Text, txtSenha.Text)
                If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                    Dim row = dt.Rows(0)
                    If veLogado(row.Item("ID")) = True Then
                        My.Forms.frmPadrao.Usuario = row.Item("Usuario")
                        My.Forms.frmPadrao.IDUsuario = row.Item("ID")
                        If setaContexto() = True Then
                            If setaConfiguracao() = True Then
                                logado = True
                                Me.Close()
                            End If
                        End If
                        'logado = True
                        'Me.Close()
                    End If
                Else
                    MsgBox("Usuário não Encontrado na Base de Dados!", MsgBoxStyle.Critical)
                    txtUsuario.Focus()
                End If
            Else
                msgValida("Senha", txtSenha)
            End If
        Else
            msgValida("Usuário", txtUsuario)
        End If
    End Sub

    Public Function setaConfiguracao() As Boolean
        Dim str As String = "SELECT TOP 1 volumeComQuebra,TruncarVol,arredondaPeso,"
        str += " numeroContratoAutomatico,pesoTiketDivide,setaVolInteiro, "
        str += " editaTiket,modeloTiketClassificacao, contratoCompraPreContrato, IDUsuarioSupremo, "
        str += " veTodasQuadras,IDDomicilioEmpresa,Tiket2Via,arrendondarPeso, controleSacariaAuto, "
        str += " tipoClassicaoGrid,Class_Safra,Class_LotePadrao,Class_Padrao,Class_Arm_Amostra,"
        str += " Class_Umidade,Class_Loc_Amostra,TradingOfertaZerado,TradingLoteMaiorZero, liberaLoteCompleto, "
        str += " naotravaTrading,ObrigatorioNFBal, IDUsuarioMaster, VersaoSistema, ISNULL(fat2Tabela,0) as fat2Tabela,imprimeTiketSimples "
        str += " , ISNULL(DadosEmp,'') as DadosEmp, isnull(pclink,0) as pclink, "
        str += " isnull(caminho_pclink,'') as caminho_pclink, isnull(comando_pclink,'') as comando_pclink, "
        str += " TravaNumeroGuia, ImpressaoTiketClassificacao, ImprimeTiket2, NFObrigatoriaTiket, "
        str += " ISNULL(IDTRANSPORTADORA,-1) as IDTRANSPORTADORA, isnull(VOLUME_HABILITADO,1) as VOLUME_HABILITADO, "
        str += " isnull(GS_QtdZerada,0) as GS_QtdZerada, PESO_SACA, ISNULL(desdobraSEMQTD,0) as desdobraSEMQTD, isnull(ContratoSemPre,0) as ContratoSemPre "
        str += ",ImpressaoTiket2, ImprimeGSIniTexto, ImprimeGSIniTexto2, ImprimeGSFimTexto, imprimeGSBXMatricial2, imprimeGRMatricial2, "
        str += " ImprimeGRTexto, imprimeGSBXTexto2, imprimeGTTexto, travaEntradaFsical, CobraAdcNoturno, "
        str += " IDTIPOPRODUTOR, IDTIPOGERAL, GeraArquivoExportLote, NFMultiplasTransf, ImpressaContratoGrano,"
        str += " IMPRIMEGSBASE2VELOSO,IMPRIMEGSBXBASE2VELOSO,imprimeDocGuiaTextoBase2Veloso,IMPRIMEGSINICIALVERTICALBASE2F7,imprimeGuiaEntradaVelosoBase2F3,"
        str += " MostraVolumeRelFat,ImprimeGuiaDePreenchimentoSaida, isnull(ImprimeGRTextoBal,0) as ImprimeGRTextoBal, isnull(InsereEntradasNaAmostra,0) as InsereEntradasNaAmostra, "
        str += " RemocaoMultipla, IDTipoFuncConf, isnull(CertificadoDomicilioAutomatico,0) CertificadoDomicilioAutomatico,
                 TipoReserva,isnull(TiketModeloAuma,0) as TiketModeloAuma, 
                 ISNULL(senhaControladoria,'') as senhaControladoria,
                 ISNULL(validaPesoSaida,0) as validaPesoSaida "
        str += " FROM tb_conf_armazem with (nolock) WHERE IDEMPRESA = "
        str += My.Forms.frmPadrao.IDEmpresa.ToString()
        Dim dtLoc As DataTable = fbConnection.executaSelect(str)
        If dtLoc IsNot Nothing AndAlso dtLoc.Rows.Count > 0 Then
            My.Forms.frmPadrao.volumeComQuebra = dtLoc.Rows(0).Item("volumeComQuebra")
            My.Forms.frmPadrao.TruncarVol = dtLoc.Rows(0).Item("TruncarVol")
            My.Forms.frmPadrao.arredonadaPeso = dtLoc.Rows(0).Item("arredondaPeso")
            My.Forms.frmPadrao.contratoAutomatico = dtLoc.Rows(0).Item("numeroContratoAutomatico")
            My.Forms.frmPadrao.pesoTiketDivide = dtLoc.Rows(0).Item("pesoTiketDivide")
            My.Forms.frmPadrao.volumeSomenteInt = dtLoc.Rows(0).Item("setaVolInteiro")
            My.Forms.frmPadrao.EditarTiket = dtLoc.Rows(0).Item("editaTiket")
            My.Forms.frmPadrao.ModeloImpTiketClassificacao = dtLoc.Rows(0).Item("modeloTiketClassificacao")
            My.Forms.frmPadrao.preContratoCompra = dtLoc.Rows(0).Item("contratoCompraPreContrato")
            My.Forms.frmPadrao.IDUsuarioSupremo = dtLoc.Rows(0).Item("IDUsuarioSupremo")
            My.Forms.frmPadrao.veTodasQuadras = dtLoc.Rows(0).Item("veTodasQuadras")
            My.Forms.frmPadrao.IDDomicilioEmpresa = dtLoc.Rows(0).Item("IDDomicilioEmpresa")
            My.Forms.frmPadrao.Tiket2Via = dtLoc.Rows(0).Item("Tiket2Via")
            My.Forms.frmPadrao.arrendondarPeso = dtLoc.Rows(0).Item("arrendondarPeso")
            My.Forms.frmPadrao.controleSacariaAuto = dtLoc.Rows(0).Item("controleSacariaAuto")
            My.Forms.frmPadrao.tipoClassicaoGrid = dtLoc.Rows(0).Item("tipoClassicaoGrid")
            My.Forms.frmPadrao.Class_Safra = dtLoc.Rows(0).Item("Class_Safra")
            My.Forms.frmPadrao.Class_LotePadrao = dtLoc.Rows(0).Item("Class_LotePadrao")
            My.Forms.frmPadrao.Class_Padrao = dtLoc.Rows(0).Item("Class_Padrao")
            My.Forms.frmPadrao.Class_Arm_Amostra = dtLoc.Rows(0).Item("Class_Arm_Amostra")
            My.Forms.frmPadrao.Class_Umidade = dtLoc.Rows(0).Item("Class_Umidade")
            My.Forms.frmPadrao.Class_Loc_Amostra = dtLoc.Rows(0).Item("Class_Loc_Amostra")
            My.Forms.frmPadrao.TradingOfertaZerado = dtLoc.Rows(0).Item("TradingOfertaZerado")
            My.Forms.frmPadrao.TradingLoteMaiorZero = dtLoc.Rows(0).Item("TradingLoteMaiorZero")
            My.Forms.frmPadrao.liberaLoteCompleto = dtLoc.Rows(0).Item("liberaLoteCompleto")
            My.Forms.frmPadrao.LIBERA_TRADING = dtLoc.Rows(0).Item("naotravaTrading")
            My.Forms.frmPadrao.ObrigatorioNFBal = dtLoc.Rows(0).Item("ObrigatorioNFBal")
            My.Forms.frmPadrao.fat2Tabela = dtLoc.Rows(0).Item("fat2Tabela")
            My.Forms.frmPadrao.imprimeTiketSimples = dtLoc.Rows(0).Item("imprimeTiketSimples")
            My.Forms.frmPadrao.TravaNumeroGuia = dtLoc.Rows(0).Item("TravaNumeroGuia")
            My.Forms.frmPadrao.travaEntradaFsical = dtLoc.Rows(0).Item("travaEntradaFsical")
            My.Forms.frmPadrao.GeraArquivoExportLote = dtLoc.Rows(0).Item("GeraArquivoExportLote")
            My.Forms.frmPadrao.NFMultiplasTransf = dtLoc.Rows(0).Item("NFMultiplasTransf")
            My.Forms.frmPadrao.ImpressaContratoGrano = dtLoc.Rows(0).Item("ImpressaContratoGrano")
            My.Forms.frmPadrao.IMPRIMEGSBASE2VELOSO = dtLoc.Rows(0).Item("IMPRIMEGSBASE2VELOSO")
            My.Forms.frmPadrao.IMPRIMEGSBXBASE2VELOSO = dtLoc.Rows(0).Item("IMPRIMEGSBXBASE2VELOSO")
            My.Forms.frmPadrao.imprimeDocGuiaTextoBase2Veloso = dtLoc.Rows(0).Item("imprimeDocGuiaTextoBase2Veloso")
            My.Forms.frmPadrao.IMPRIMEGSINICIALVERTICALBASE2F7 = dtLoc.Rows(0).Item("IMPRIMEGSINICIALVERTICALBASE2F7")
            My.Forms.frmPadrao.imprimeGuiaEntradaVelosoBase2F3 = dtLoc.Rows(0).Item("imprimeGuiaEntradaVelosoBase2F3")
            My.Forms.frmPadrao.MostraVolumeRelFat = dtLoc.Rows(0).Item("MostraVolumeRelFat")
            My.Forms.frmPadrao.ImprimeGuiaDePreenchimentoSaida = dtLoc.Rows(0).Item("ImprimeGuiaDePreenchimentoSaida")
            My.Forms.frmPadrao.ImprimeGRTextoBal = dtLoc.Rows(0).Item("ImprimeGRTextoBal")
            My.Forms.frmPadrao.InsereEntradasNaAmostra = dtLoc.Rows(0).Item("InsereEntradasNaAmostra")
            My.Forms.frmPadrao.RemocaoMultipla = dtLoc.Rows(0).Item("RemocaoMultipla")
            My.Forms.frmPadrao.IDTipoConf = dtLoc.Rows(0).Item("IDTipoFuncConf")
            My.Forms.frmPadrao.CertificadoDomicilioAutomatico = dtLoc.Rows(0).Item("CertificadoDomicilioAutomatico")
            My.Forms.frmPadrao.TipoReserva = dtLoc.Rows(0).Item("TipoReserva")
            My.Forms.frmPadrao.TiketModeloAuma = dtLoc.Rows(0).Item("TiketModeloAuma")
            My.Forms.frmPadrao.senhaControladoria = dtLoc.Rows(0).Item("senhaControladoria")
            My.Forms.frmPadrao.validaPesoSaida = dtLoc.Rows(0).Item("validaPesoSaida")

            If Not IsDBNull(dtLoc.Rows(0).Item("IDUsuarioMaster")) AndAlso My.Forms.frmPadrao.IDUsuario = dtLoc.Rows(0).Item("IDUsuarioMaster") Then
                ExcluirEstoqueEmpresa(dtLoc.Rows(0).Item("VersaoSistema"))
            End If


            My.Forms.frmPadrao.DadosEMP = dtLoc.Rows(0).Item("DadosEmp")
            'My.Forms.frmPadrao.DATA_SERVER = dtLoc.Rows(0).Item("DATA_SERVER")
            My.Forms.frmPadrao.pclink = dtLoc.Rows(0).Item("pclink")
            My.Forms.frmPadrao.caminho_pclink = dtLoc.Rows(0).Item("caminho_pclink")
            My.Forms.frmPadrao.comando_pclink = dtLoc.Rows(0).Item("comando_pclink")
            My.Forms.frmPadrao.ImpressaoTiketClassificacao = dtLoc.Rows(0).Item("ImpressaoTiketClassificacao")
            My.Forms.frmPadrao.ImprimeTiket2 = dtLoc.Rows(0).Item("ImprimeTiket2")
            My.Forms.frmPadrao.IDTransportadora = dtLoc.Rows(0).Item("IDTRANSPORTADORA")
            My.Forms.frmPadrao.VOLUME_HABILITADO = dtLoc.Rows(0).Item("VOLUME_HABILITADO")
            My.Forms.frmPadrao.GS_QtdZerada = dtLoc.Rows(0).Item("GS_QtdZerada")
            My.Forms.frmPadrao.PESO_SACA = dtLoc.Rows(0).Item("PESO_SACA")
            My.Forms.frmPadrao.desdobraSEMQTD = dtLoc.Rows(0).Item("desdobraSEMQTD")
            My.Forms.frmPadrao.ContratoSemPre = dtLoc.Rows(0).Item("ContratoSemPre")
            My.Forms.frmPadrao.ImpressaoTiket2 = dtLoc.Rows(0).Item("ImpressaoTiket2")
            My.Forms.frmPadrao.ImprimeGSIniTexto = dtLoc.Rows(0).Item("ImprimeGSIniTexto")
            My.Forms.frmPadrao.ImprimeGSIniTexto2 = dtLoc.Rows(0).Item("ImprimeGSIniTexto2")
            My.Forms.frmPadrao.ImprimeGSFimTexto = dtLoc.Rows(0).Item("ImprimeGSFimTexto")
            My.Forms.frmPadrao.imprimeGSBXMatricial2 = dtLoc.Rows(0).Item("imprimeGSBXMatricial2")
            My.Forms.frmPadrao.imprimeGRMatricial2 = dtLoc.Rows(0).Item("imprimeGRMatricial2")
            My.Forms.frmPadrao.ImprimeGRTexto = dtLoc.Rows(0).Item("ImprimeGRTexto")
            My.Forms.frmPadrao.imprimeGSBXTexto2 = dtLoc.Rows(0).Item("imprimeGSBXTexto2")
            My.Forms.frmPadrao.imprimeGTTexto = dtLoc.Rows(0).Item("imprimeGTTexto")
            My.Forms.frmPadrao.CobraAdcNoturno = dtLoc.Rows(0).Item("CobraAdcNoturno")
            My.Forms.frmPadrao.IDTIPOPRODUTOR = dtLoc.Rows(0).Item("IDTIPOPRODUTOR")
            My.Forms.frmPadrao.IDTIPOGERAL = dtLoc.Rows(0).Item("IDTIPOGERAL")

            str = "SELECT isnull(TamanhoRelatorio,100) as TamanhoRelatorio ,isnull(TipoRelatorioJuridicoContrato,0) as TipoRelatorioJuridicoContrato  FROM TB_GERAL_CONFIGURACAO WITH (NOLOCK) WHERE IDEmpresa = " & My.Forms.frmPadrao.IDEmpresa

            dtLoc = fbConnection.executaSelect(str)

            My.Forms.frmPadrao.TamanhoRelatorio = dtLoc.Rows(0).Item("TamanhoRelatorio")
            My.Forms.frmPadrao.TipoContratoJuridico = dtLoc.Rows(0).Item("TipoRelatorioJuridicoContrato")

            Return True
        Else
            MsgBox("Erro Ao Carregar Configurações!")
            Return False
        End If
        Return False
    End Function

    Private Function veLogado(_IDUsuario As Integer) As Boolean
        Dim qry As New dtsLoguinTableAdapters.QueriesTableAdapter
        Dim ret As Boolean = qry.verificaUsuarioLogado(_IDUsuario)
        If ret = True Then
            MsgBox("Usuário já Está Logado em Outra Estação!", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub FbButton1_Click(sender As Object, e As EventArgs) Handles FbButton1.Click
        logar()
    End Sub

    Private Sub frmLoguin_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            logado = False
            Me.Close()
        End If

    End Sub

    Private Sub ExcluirEstoqueEmpresa(ByVal IDEmpresa As Integer)
        'If MessageBox.Show("Deseja Atualizar o Sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
        '    frmAtualizarSistema.IDEmpresa = IDEmpresa
        '    frmAtualizarSistema.ShowDialog()
        'End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

End Class
