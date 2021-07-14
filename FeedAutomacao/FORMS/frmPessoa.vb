Imports System.IO
Imports System.Drawing.Imaging

Public Class frmPessoa

    Dim dt As dtsTabelas.TB_PESSOADataTable
    Dim dr As New dtsTabelasTableAdapters.TB_PESSOATableAdapter
    Dim row As dtsTabelas.TB_PESSOARow
    Dim cpfVal As String = ""
    Dim tipoProdutor As Integer = -1
    Dim tipoGeral As Integer = -1

    Private Sub dgvServico1_atualizaDts(ByVal grid As System.Windows.Forms.DataGridView) Handles dgvLote.atualizaDts
        If dgvLote.dgvDados.ColumnCount > 0 Then
            dgvLote.dgvDados.Columns("IDPessoa").Visible = False
            dgvLote.dgvDados.Columns("codEstado").Visible = False
            dgvLote.dgvDados.Columns("codCidade").Visible = False
            dgvLote.dgvDados.Columns("Conta").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    Private Sub FbComboBox1_Selecionando() Handles cbbTipoCad.Selecionando
        txtIE.Clear()
        If cbbTipoCad.ValorSelecionado = "J" Then
            txtCGC.Mask = "99,999,999/9999-99"
        Else
            txtCGC.Mask = "999,999,999-99"
        End If
    End Sub

    Public Sub setaForm()
        frmPesquisaPessoa.cbInativo.Visible = True
        pesDados.FormularioPesquisa = frmPesquisaPessoa
        'dgvRedeSocial.Formulario = frmPessoaRedeSocial
        'dgvAgente.Formulario = frmPessoaReferente
        'lkpDomicilio.FormularioPesquisa = frmPesquisaDomicilio
        'pesContaCont.FormularioPesquisa = My.Forms.frmSelecionaContaContabil
        'cbbTabela.Filtro = "IDEMPRESA = " + My.Forms.frmPadrao.IDEmpresa.ToString()
        dgvDom.DataSource = Nothing
    End Sub

    Public Overrides Function Limpar() As Boolean
        MyBase.Limpar()
        ' Tela Inicial
        tpeEmpresa.SelectedTab = tpeEndereco
        txtNome.Clear()
        txtFantasia.Clear()
        cbbTipoCad.ValorSelecionado = "-1"
        txtCGC.Clear()
        txtCodigo.Clear()
        cbbTipoPessoa.ValorSelecionado = -1
        cbbTAG.ValorSelecionado = -1
        txtIE.Clear()
        cpfVal = ""

        '1º Aba Endereco
        txtCEP.Clear()
        txtEstado.ValorSelecionado = -1
        txtCidade.ValorSelecionado = -1
        txtLogradouro.Clear()
        txtNumero.Text = ""
        txtBairro.Clear()
        txtComplemento.Clear()
        '2º Aba inf.comple
        txtEmail.Clear()
        txtTelefone.Clear()
        txtCel.Clear()
        rbAtivo.Checked = True
        txtObs.Clear()
        ptbImagem.Image = Nothing
        '3º Aba Configuraçao
        cbbTipoFiscal.ValorSelecionado = -1
        pesContaCont.SelectID = -1
        lkpDomicilio.SelectID = -1

        txtCepInterv.Text = ""
        cbbEstadoInterv.ValorSelecionado = -1
        cbbCidadeInterv.ValorSelecionado = -1
        txtEnderecoInterv.Text = ""
        txtBairroInterv.Text = ""
        txtCPFInteerv.Text = ""
        cbbEstadoCivilInterv.ValorSelecionado = -1

        'inf pessoais
        txtPai.Clear()
        txtMae.Clear()
        txtDataNasc.Value = Date.Now
        txtProfissao.Text = ""

        'dados Emp
        cbbCargo.ValorSelecionado = -1
        cbbSetor.ValorSelecionado = -1
        txtAdmissao.Value = Date.Now

        'outras Inf
        txtRg.Clear()
        txtRGexp.Clear()
        txtDataExpRG.Value = Date.Now

        txtCNH.Clear()
        txtCNHTipoCarteira.Clear()
        txtDataHabilitacao.Text = Date.Now
        txtDataVencimentoHab.Text = Date.Now

        txtCTPS.Clear()
        txtCTPSPis.Clear()
        txtCTPSSerie.Clear()

        ckbFiscal.Checked = False
        ckbFunRural.Checked = False
        ckbICMS.Checked = False
        ckbSenar.Checked = False
        txtSenha.Clear()

        txtTelCom.Text = ""
        txtCel2.Text = ""
        txtComissao.Value = 0

        txtVlrHora.Text = 0
        txtHrExtra.Value = 0
        txtAdicNoturno.Value = 0


        'dgvLote.Formulario = My.Forms.frmPessoaContaBanco
        dgvLote.IDRelacionamento = -1
        dgvLote.dgvDados.DataSource = Nothing
        dgvRedeSocial.IDRelacionamento = -1
        dgvRedeSocial.dgvDados.DataSource = Nothing
        dgvAgente.IDRelacionamento = -1
        dgvAgente.dgvDados.DataSource = Nothing

    End Function

    Public Overrides Function Editar(ByVal IDSel As Integer) As Boolean

        If PermissaoEditar("Pessoa") = False Then
            FbBarra1.btnEdita.Enabled = False
        Else
            FbBarra1.btnEdita.Enabled = True
        End If
        If PermissaoInserir("Pessoa") = False Then
            FbBarra1.btnNovo.Enabled = False
        Else
            FbBarra1.btnNovo.Enabled = True
        End If
        If PermissaoExcluir("Pessoa") = False Then
            FbBarra1.btnExclui.Enabled = False
        Else
            FbBarra1.btnExclui.Enabled = True
        End If

        ID = IDSel


        If IDSel <> -1 Then
            dt = dr.GetDataByID(IDSel)
            row = dt.FindByID(IDSel)
            If row IsNot Nothing Then
                tpeEmpresa.SelectedTab = tpeEndereco
                If row.IsNomeNull = False Then
                    txtNome.Text = Trim(row.Nome)
                Else
                    txtNome.Text = ""
                End If
                If row.IsApelidoNull = False Then
                    txtFantasia.Text = Trim(row.Apelido)
                Else
                    txtFantasia.Text = ""
                End If
                If row.IsTipoCadastroNull = False Then
                    cbbTipoCad.ValorSelecionado = row.TipoCadastro
                Else
                    cbbTipoCad.ValorSelecionado = -1
                End If
                If row.IsCGCNull = False Then
                    txtCGC.Text = row.CGC
                    cpfVal = row.CGC
                Else
                    txtCGC.Text = ""
                    cpfVal = ""
                End If
                If row.IsCodigoNull = False Then
                    txtCodigo.Text = row.Codigo
                Else
                    txtCodigo.Text = 0
                End If
                If row.IsIDTipoPessoaNull = False Then
                    cbbTipoPessoa.ValorSelecionado = row.IDTipoPessoa
                Else
                    cbbTipoPessoa.ValorSelecionado = -1
                End If
                If row.IsIDTagNull = False Then
                    cbbTAG.ValorSelecionado = row.IDTag
                Else
                    cbbTAG.ValorSelecionado = -1
                End If
                If row.IsIENull = False Then
                    txtIE.Text = row.IE
                Else
                    txtIE.Text = ""
                End If
                If row.IsCEPNull = False Then
                    txtCEP.Text = row.CEP
                Else
                    txtCEP.Text = ""
                End If
                If row.IscodEstadoNull = False Then
                    txtEstado.ValorSelecionado = row.codEstado
                Else
                    txtEstado.ValorSelecionado = -1
                End If
                If row.IscodCidadeNull = False Then
                    txtCidade.ValorSelecionado = row.codCidade
                Else
                    txtCidade.ValorSelecionado = -1
                End If
                If row.IsEnderecoNull = False Then
                    txtLogradouro.Text = Trim(row.Endereco)
                Else
                    txtLogradouro.Text = ""
                End If
                If row.IsNumeroNull = False Then
                    txtNumero.Text = row.Numero
                Else
                    txtNumero.Text = 0
                End If
                If row.IsBairroNull = False Then
                    txtBairro.Text = Trim(row.Bairro)
                Else
                    txtBairro.Text = ""
                End If
                txtComplemento.Text = row.Complemento
                If row.IsEmailNull = False Then
                    txtEmail.Text = row.Email
                Else
                    txtEmail.Text = ""
                End If
                If row.IsTelefoneNull = False Then
                    txtTelefone.Text = row.Telefone
                Else
                    txtTelefone.Text = ""
                End If
                If row.IsCelularNull = False Then
                    txtCel.Text = row.Celular
                Else
                    txtCel.Text = ""
                End If
                If row.IstelefoneComNull = False Then
                    txtTelCom.Text = row.telefoneCom
                Else
                    txtTelCom.Text = ""
                End If
                If row.IstelefoneCelular2Null = False Then
                    txtCel2.Text = row.telefoneCelular2
                Else
                    txtCel2.Text = ""
                End If
                If row.IscomissaoNull = False Then
                    txtComissao.Value = row.comissao
                Else
                    txtComissao.Value = 0
                End If

                If row.IsIntervenienteAnuenteNull = False Then
                    txtInterveniente.Text = row.IntervenienteAnuente
                Else
                    txtInterveniente.Text = ""
                End If

                If row.IsCepIntervNull = False Then
                    txtCepInterv.Text = row.CepInterv
                Else
                    txtCepInterv.Text = ""
                End If
                If row.IscodEstadoIntervNull = False Then
                    cbbEstadoInterv.ValorSelecionado = row.codEstadoInterv
                Else
                    cbbEstadoInterv.ValorSelecionado = -1
                End If
                If row.IscodCidadeIntervNull = False Then
                    cbbCidadeInterv.ValorSelecionado = row.codCidadeInterv
                Else
                    cbbCidadeInterv.ValorSelecionado = -1
                End If
                If row.IsEnderecoIntervNull = False Then
                    txtEnderecoInterv.Text = row.EnderecoInterv
                Else
                    txtEnderecoInterv.Text = ""
                End If
                If row.IsBairroIntervNull = False Then
                    txtBairroInterv.Text = row.BairroInterv
                Else
                    txtBairroInterv.Text = ""
                End If
                If row.IsCPFIntervNull = False Then
                    txtCPFInteerv.Text = row.CPFInterv
                Else
                    txtCPFInteerv.Text = ""
                End If
                If row.IsEstadoCivilIntervNull = False Then
                    cbbEstadoCivilInterv.ValorSelecionado = row.EstadoCivilInterv
                Else
                    cbbEstadoCivilInterv.ValorSelecionado = -1
                End If

                If row.ativo Then
                    rbAtivo.Checked = True
                Else
                    rbInativo.Checked = True
                End If

                If row.IsObservacaoNull = False Then
                    txtObs.Text = row.Observacao
                Else
                    txtObs.Text = ""
                End If

                'TAG
                'Dim sSqlTAG As String = fbConnection.retornaValorUnico($"SELECT TAG from TB_AUTOMACAO_TAG where IDPessoa = " + IDSel.ToString)
                'CbxTAG.Text = sSqlTAG

                'Dim sSqlTagUpdate As String = $"update TB_AUTOMACAO_TAG set IDPessoa = {IDSel} where IDTag = {sSqlTAG.ToString}"
                'Dim exc = fbConnection.executaCommand(sSqlTagUpdate)


                If row.IsIDTipoFiscalNull = False Then
                    cbbTipoFiscal.ValorSelecionado = row.IDTipoFiscal
                Else
                    cbbTipoFiscal.ValorSelecionado = -1
                End If
                If row.IsIDContaContNull = False Then
                    pesContaCont.SelectID = row.IDContaCont
                Else
                    pesContaCont.SelectID = -1
                End If

                If row.IsIDDomCobrarNull = False Then
                    lkpDomicilio.SelectID = row.IDDomCobrar
                Else
                    lkpDomicilio.SelectID = -1
                End If

                If row.IsImagemNull = False AndAlso row.Imagem IsNot Nothing Then
                    Dim stmBLOBData As New MemoryStream(row.Imagem)

                    If stmBLOBData IsNot Nothing Then
                        ptbImagem.Image = Image.FromStream(stmBLOBData)
                    Else
                        ptbImagem.Image = Nothing
                    End If
                Else
                    ptbImagem.Image = Nothing
                End If

                'inf pessoais
                If row.IsNomePaiNull = False Then
                    txtPai.Text = row.NomePai
                Else
                    txtPai.Text = ""
                End If

                If row.IsNomeMaeNull = False Then
                    txtMae.Text = row.NomeMae
                Else
                    txtMae.Text = ""
                End If

                If row.IsDataNascimentoNull = False Then
                    txtDataNasc.Value = row.DataNascimento
                Else
                    txtDataNasc.Value = "01/01/1900"
                End If


                'dados Emp
                If row.IsIDCargoNull = False Then
                    cbbCargo.ValorSelecionado = row.IDCargo
                Else
                    cbbCargo.ValorSelecionado = -1
                End If
                If row.IsIDSetorNull = False Then
                    cbbSetor.ValorSelecionado = row.IDSetor
                Else
                    cbbSetor.ValorSelecionado = -1
                End If

                If row.IsdataAdmissaoNull = False Then
                    txtAdmissao.Value = row.dataAdmissao
                Else
                    txtAdmissao.Value = "01/01/1900"
                End If


                'outras Inf
                If row.IsRGNull = False Then
                    txtRg.Text = row.RG
                Else
                    txtRg.Text = ""
                End If

                If row.IsRGorgaoEXPNull = False Then
                    txtRGexp.Text = row.RGorgaoEXP
                Else
                    txtRGexp.Text = ""
                End If

                If row.IsRGdataEXPNull = False Then
                    txtDataExpRG.Value = row.RGdataEXP
                Else
                    txtDataExpRG.Value = ""
                End If

                If row.IsCNHNull = False Then
                    txtCNH.Text = row.CNH
                Else
                    txtCNH.Text = ""
                End If

                If row.IsCategoriaCNHNull = False Then
                    txtCNHTipoCarteira.Text = row.CategoriaCNH
                Else
                    txtCNHTipoCarteira.Text = ""
                End If

                If row.IsDataHabilitacaoNull = False Then
                    txtDataHabilitacao.Text = row.DataHabilitacao
                Else
                    txtDataHabilitacao.Text = ""
                End If

                If row.IsDataVencHabilitacaoNull = False Then
                    txtDataVencimentoHab.Text = row.DataVencHabilitacao
                Else
                    txtDataVencimentoHab.Text = ""
                End If

                If row.IsCTPSNull = False Then
                    txtCTPS.Text = row.CTPS
                Else
                    txtCTPS.Text = ""
                End If

                If row.IsCTPSpisNull = False Then
                    txtCTPSPis.Text = row.CTPSpis
                Else
                    txtCTPSPis.Text = ""
                End If


                If row.IsCTPSserieNull = False Then
                    txtCTPSSerie.Text = row.CTPSserie
                Else
                    txtCTPSSerie.Text = ""
                End If


                ' ckbFiscal.Checked = row.codfiscal
                If row.IssenhaNull = False Then
                    txtSenha.Text = row.senha
                Else
                    txtSenha.Text = ""
                End If

                If row.IsincideFUNRURALNull = False Then
                    ckbFunRural.Checked = row.incideFUNRURAL
                Else
                    ckbFunRural.Checked = False
                End If

                If row.IsincideICMSNull = False Then
                    ckbICMS.Checked = row.incideICMS
                Else
                    ckbICMS.Checked = False
                End If

                If row.IsincideSENARNull = False Then
                    ckbSenar.Checked = row.incideSENAR
                Else
                    ckbSenar.Checked = False
                End If

                If row.IsVLRHORANull = False Then
                    txtVlrHora.Text = row.VLRHORA
                Else
                    txtVlrHora.Text = ""
                End If

                If row.IsPER_EXTRANull = False Then
                    txtHrExtra.Value = row.PER_EXTRA
                Else
                    'txtHrExtra.Value = ""
                    txtHrExtra.Value = 0
                End If

                If row.IsPER_ADINOTURNONull = False Then
                    txtAdicNoturno.Value = row.PER_ADINOTURNO
                Else
                    'txtAdicNoturno.Value = ""
                    txtAdicNoturno.Value = 0
                End If

                If row.IsProfissaoNull = False Then txtProfissao.Text = row.Profissao Else txtProfissao.Text.Equals(String.Empty)

                Dim sql = "Select d.ID, d.Nome, d.cgc As CNPJ,d.IE, d.codFazCli, d.matricula, p.senha FROM TB_DOMICILIO d inner join TB_PESSOA p on d.IDPessoa = p.id WHERE d.IDPessoa = " + row.ID.ToString()
                Dim dtx = fbConnection.executaSelect(sql)
                If dtx IsNot Nothing Then
                    dgvDom.DataSource = dtx
                Else
                    dgvDom.DataSource = Nothing
                End If

                'dgvLote.Formulario = My.Forms.frmPessoaContaBanco
                dgvLote.IDRelacionamento = row.ID
                dgvRedeSocial.IDRelacionamento = ID
                dgvAgente.IDRelacionamento = ID

            Else
                MsgBox("Erro ao Carregar o Registro!", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Selecione um Registro para Carregar!", MsgBoxStyle.Critical)
        End If
        Return MyBase.Editar(IDSel)
    End Function

    Public Overrides Function Salvar(ByVal IDSel As Integer) As Boolean
        If MyBase.Salvar(IDSel) = True Then
            If IDSel = -1 Then
                row = dt.NewTB_PESSOARow
                row.COTA = 0
            Else
                row = dt.FindByID(IDSel)
                AutualizarAtivoDom()
            End If

            carregaTAG()

            row.Nome = txtNome.Text.TrimEnd()
            row.Apelido = txtFantasia.Text.TrimEnd()
            If cbbTipoCad.ValorSelecionado <> "-1" Then row.TipoCadastro = cbbTipoCad.ValorSelecionado
            row.CGC = txtCGC.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim()
            row.Codigo = txtCodigo.Text
            If cbbTipoPessoa.ValorSelecionado <> -1 Then row.IDTipoPessoa = cbbTipoPessoa.ValorSelecionado
            If cbbTAG.ValorSelecionado <> -1 Then row.IDTag = cbbTAG.ValorSelecionado
            If txtIE.Text.Replace(".", "").Replace("/", "").Trim() = "" Then
                row.IE = "ISENTO"
            Else
                row.IE = txtIE.Text.Replace(".", "").Replace("/", "").Trim()
            End If
            row.CEP = txtCEP.Text.Replace(".", "").Replace("-", "").Trim()
            If txtEstado.ValorSelecionado <> -1 Then
                row.codEstado = txtEstado.ValorSelecionado
                row.Estado = txtEstado.Text
            End If
            If txtCidade.ValorSelecionado <> -1 Then
                row.codCidade = txtCidade.ValorSelecionado
                row.Cidade = txtCidade.Text
            End If
            row.Endereco = Trim(txtLogradouro.Text)
            row.Numero = txtNumero.Text
            row.Bairro = Trim(txtBairro.Text)
            row.Complemento = Trim(txtComplemento.Text)
            row.Email = Trim(txtEmail.Text)
            row.Telefone = Trim(txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""))
            row.Celular = Trim(txtCel.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""))
            row.telefoneCom = Trim(txtTelCom.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""))
            row.telefoneCelular2 = Trim(txtCel2.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""))

            'Interv
            row.IntervenienteAnuente = txtInterveniente.Text
            row.CepInterv = txtCepInterv.Text.Replace(".", "").Replace("-", "")
            row.codEstadoInterv = cbbEstadoInterv.ValorSelecionado
            row.codCidadeInterv = cbbCidadeInterv.ValorSelecionado
            row.EstadoInterv = cbbEstadoInterv.Text
            row.CidadeInterv = cbbCidadeInterv.Text
            row.EnderecoInterv = txtEnderecoInterv.Text
            row.BairroInterv = txtBairroInterv.Text
            row.CPFInterv = txtCPFInteerv.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim()
            row.EstadoCivilInterv = cbbEstadoCivilInterv.ValorSelecionado

            row.Observacao = Trim(txtObs.Text)
            row.ativo = rbAtivo.Checked
            If cbbTipoFiscal.ValorSelecionado <> -1 Then row.IDTipoFiscal = cbbTipoFiscal.ValorSelecionado
            If pesContaCont.SelectID <> -1 Then row.IDContaCont = pesContaCont.SelectID
            If lkpDomicilio.SelectID <> -1 Then row.IDDomCobrar = lkpDomicilio.SelectID
            If cbbTipoPessoa.ValorSelecionado = tipoProdutor OrElse cbbTipoPessoa.ValorSelecionado = tipoGeral Then 'Tabela


            End If

            If ptbImagem.Image IsNot Nothing Then
                Dim ms As MemoryStream = New MemoryStream()
                ptbImagem.Image.Save(ms, ImageFormat.Jpeg)
                Dim bytBLOBData(ms.Length - 1) As Byte
                ms.Position = 0
                ms.Read(bytBLOBData, 0, ms.Length)

                row.Imagem = bytBLOBData
            End If

            'inf pessoais
            row.NomePai = txtPai.Text
            row.NomeMae = txtMae.Text
            row.DataNascimento = txtDataNasc.Value
            row.Profissao = txtProfissao.Text

            'dados Emp
            If cbbCargo.ValorSelecionado <> -1 Then
                row.IDCargo = cbbCargo.ValorSelecionado
            End If
            If cbbSetor.ValorSelecionado <> -1 Then
                row.IDSetor = cbbSetor.ValorSelecionado
            End If
            row.dataAdmissao = txtAdmissao.Value

            'outras Inf
            row.RG = txtRg.Text
            row.RGorgaoEXP = txtRGexp.Text
            row.RGdataEXP = txtDataExpRG.Value


            row.CNH = txtCNH.Text
            row.CategoriaCNH = txtCNHTipoCarteira.Text
            row.DataHabilitacao = txtDataHabilitacao.Value
            row.DataVencHabilitacao = txtDataVencimentoHab.Value

            row.CTPS = txtCTPS.Text
            row.CTPSpis = txtCTPSPis.Text
            row.CTPSserie = txtCTPSSerie.Text

            row.crm = False
            row.TipoFat = "M"
            row.ObsBeneficio = ""
            row.Beneficio = 0
            row.CRC = ""
            row.ANTT = ""
            row.RNTRC = ""
            row.IDGrupoEmpresa = My.Forms.frmPadrao.IDGrupoEmpresa

            ' row.codfiscal = ckbFiscal.Checked
            row.senha = txtSenha.Text

            row.incideFUNRURAL = ckbFunRural.Checked
            row.incideICMS = ckbICMS.Checked
            row.incideSENAR = ckbSenar.Checked
            row.comissao = txtComissao.Value


            row.VLRHORA = txtVlrHora.Text
            row.PER_EXTRA = txtHrExtra.Value
            row.PER_ADINOTURNO = txtAdicNoturno.Value

            dgvRedeSocial.IDRelacionamento = ID
            dgvAgente.IDRelacionamento = ID

            If IDSel = -1 Then
                dt.AddTB_PESSOARow(row)
            End If
            dr.Update(dt)

            'Dim sSqlTAG As Integer = fbConnection.retornaValorUnico($"SELECT IDTag FROM dbo.TB_AUTOMACAO_TAG with (nolock) WHERE TAG = '{CbxTAG.Text}'")
            'Dim IDPessoa = fbConnection.retornaValorUnico("SELECT MAX(ID) FROM TB_PESSOA")
            'Dim sSqlTagUpdate As String = $"update TB_AUTOMACAO_TAG set IDPessoa = {IDPessoa} where IDTag ={sSqlTAG}"
            'Dim exc = fbConnection.executaCommand(sSqlTagUpdate)

            msgSalvar()
            If IDSel = -1 Then
                IDSel = dr.MAXID()
                ID = IDSel
                'If MsgBox("Deseja Gerar Domicilio para esta Pessoa?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '    Dim qtdD As New dtsGeral3TableAdapters.QueriesTableAdapter
                '    qtdD.plenaDomicilio(IDSel)
                'End If
            End If
            Return True
        End If
        Return False
    End Function


    Private Sub AutualizarAtivoDom()
        If row.ativo AndAlso rbAtivo.Checked = False OrElse row.ativo = False AndAlso rbAtivo.Checked Then
            If cbbTipoPessoa.ValorSelecionado = tipoProdutor OrElse cbbTipoPessoa.ValorSelecionado = tipoGeral Then
                If MessageBox.Show("Deseja Atualizar o(s) Domicílio(s) Deste Produtor como Ativo/Inativo Conforme o Cadastro Do Produtor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    Dim sql As String = "UPDATE TB_DOMICILIO Set ativo = " + CInt(rbAtivo.Checked).ToString().Replace("-", "") _
                                        + " WHERE IDPESSOA = " + ID.ToString()
                    fbConnection.executaCommand(sql)
                End If
            End If
        End If
    End Sub



    Public Overrides Function Excluir(ByVal IDSel As Integer) As Boolean
        If IDSel <> -1 Then
            Try
                row = dt.FindByID(IDSel)
                row.ativo = 0
                'row.Delete()
                dr.Update(dt)
                msgExcluir()
                Return True
            Catch ex As SqlClient.SqlException
                If ex.ErrorCode = -2146232060 Then
                    MsgBox("Erro ao Excluir o Registro Pois Está Relacionado a Outro Registro! ", MsgBoxStyle.Critical)
                Else
                    MsgBox("Erro ao Excluir o Registro! " + ex.Message, MsgBoxStyle.Critical)
                End If
                Return False
            End Try
        End If
    End Function

    Public Overrides Function Validar() As Boolean
        If txtNome.Text = "" Then
            msgValida("Nome", txtNome)
            Return False
        ElseIf cbbTipoCad.ValorSelecionado = "-1" Then
            msgValida("Tipo Cadastro", cbbTipoCad)
            Return False
        ElseIf cbbTipoPessoa.ValorSelecionado = -1 Then
            msgValida("Tipo Pessoa", cbbTipoPessoa)
            Return False
        ElseIf cbbTAG.ValorSelecionado = -1 Then
            msgValida("TAG", cbbTAG)
            Return False
        ElseIf cbbTipoCad.ValorSelecionado = "J" AndAlso txtIE.Text.Replace(".", "").Replace("-", "").Trim() <> "" AndAlso
            IsNumeric(txtIE.Text) AndAlso Not clValidacao.existCampo("IE", "TB_PESSOA", txtIE.Text.Replace(".", "").Replace("-", "").Trim(), ID) Then
            MsgBox("Já Existe uma Pessoa Com Esta Insc. Estadual no Banco de Dados!", MsgBoxStyle.Information, "Aviso")
            txtIE.Focus()
            Return False
        ElseIf txtCEP.Requerido AndAlso Trim(txtCEP.Text.Replace("-", "").Replace(".", "")) = "" Then
            'ElseIf Trim(txtCEP.Text.Replace("-", "").Replace(".", "")) = "" Then Antigo alterado 10/05/2019 Coopadap
            msgValida("Cep", txtCEP)
            Return False
        ElseIf txtEstado.Requerido AndAlso txtEstado.ValorSelecionado = -1 Then
            msgValida("Estado", txtEstado)
            Return False
        ElseIf txtCidade.Requerido AndAlso txtCidade.ValorSelecionado = -1 Then
            msgValida("Cidade", txtCidade)
            Return False
        ElseIf txtLogradouro.Requerido AndAlso txtLogradouro.Text = "" Then
            msgValida("Logradouro", txtLogradouro)
            Return False
        ElseIf txtBairro.Requerido AndAlso txtBairro.Text = "" Then
            msgValida("Bairro", txtBairro)
            Return False
        ElseIf txtEmail.Text <> "" AndAlso Not txtEmail.Text.Contains("@") Then
            MsgBox("Email Inválido! Por Favor, Corrija e Tente Novamente.", MsgBoxStyle.Information, "Aviso")
            tpeEmpresa.SelectedIndex = 1
            txtEmail.Focus()
            Return False
        ElseIf Trim(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", "")) = "" Then
            msgValida("CPF/CNPJ", txtCGC)
            Return False
        ElseIf Trim(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", "")).Length = 11 AndAlso clValidacao.ValidaCPF(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", "")) = False Then
            MsgBox("CPF Inválido", MsgBoxStyle.Information)
            txtCGC.Focus()
            Return False
        ElseIf Trim(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", "")).Length <> 14 AndAlso Trim(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", "")).Length <> 11 Then
            MsgBox("CPF/CNPJ Inválido", MsgBoxStyle.Information)
            txtCGC.Focus()
            Return False
        ElseIf Trim(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", "")).Length = 14 AndAlso clValidacao.ValidaCNPJ(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", "")) = False Then
            MsgBox("CNPJ Inválido", MsgBoxStyle.Information)
            txtCGC.Focus()
            Return False
        ElseIf cpfVal <> Trim(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", "")) AndAlso
        clValidacao.existCNPJ_CPF(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", ""), "TB_PESSOA", ID) = False Then
            MsgBox("CPF/CNPJ Já Esta Cadastrado no Banco de Dados", MsgBoxStyle.Information)
            txtCGC.Focus()
            Return False
        ElseIf row IsNot Nothing AndAlso cpfVal <> Trim(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", "")) AndAlso
        row.CGC <> txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", "") AndAlso
        clValidacao.existCNPJ_CPF(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", ""), "TB_PESSOA", ID) = False Then
            MsgBox("CPF/CNPJ Já Esta Cadastrado no Banco de Dados", MsgBoxStyle.Information)
            txtCGC.Focus()
            Return False
        ElseIf row Is Nothing AndAlso cpfVal <> Trim(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", "")) AndAlso
        clValidacao.existCNPJ_CPF(txtCGC.Text.Replace("/", "").Replace("-", "").Replace(".", ""), "TB_PESSOA", ID) = False Then
            MsgBox("CPF/CNPJ Já Esta Cadastrado no Banco de Dados", MsgBoxStyle.Information)
            txtCGC.Focus()
            Return False
            'ElseIf cbbTipoCad.ValorSelecionado = "J" AndAlso clValidaIE.valida(txtEstado.ValorSelecionado, txtIE.Text.Replace(".", "").Replace("/", "")) = False Then
            '    MsgBox("Inscrição Estadual Invalida!", MsgBoxStyle.Information)
            '    txtIE.Focus()
            '    Return False
        End If
        Return True
    End Function

    Public Overrides Sub Carrega(Optional ByVal IDParent As Integer = -1)
        'PopulacomboboxTAG()
        MyBase.Carrega(IDParent)
        dt = dr.GetData()
        Dados = dt
    End Sub

    Private Sub txtEstado_Selecionando() Handles txtEstado.Selecionando
        txtCidade.ValorSelecionado = -1
        If txtEstado.ValorSelecionado = -1 Then
            txtCidade.Enabled = False
        Else
            txtCidade.Enabled = True
            txtCidade.campoRelacionamento = "CODESTADO"
            txtCidade.ValorRelacionamento = txtEstado.ValorSelecionado
        End If
    End Sub

    Private Sub btnBuscaCep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCep.Click
        Dim cep = txtCEP.Text.Replace(".", "").Replace("-", "").Trim()
        If cep <> "" AndAlso cep.Length = 8 Then
            Dim dtCep As dtsFuncao.BuscaCEPDataTable
            Dim taCep As New dtsFuncaoTableAdapters.BuscaCEPTableAdapter
            dtCep = taCep.GetData(cep.ToString())
            Dim dt As DataTable = fbConnection.executaSelect("Select * from TB_IBGE_CEP where cep = '" + cep.ToString() + "'")
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                txtLogradouro.Text = IIf(IsDBNull(dt.Rows(0).Item("logradouro")), "", dt.Rows(0).Item("logradouro"))
                txtEstado.ValorSelecionado = dt.Rows(0).Item("codigoUF")
                txtCidade.ValorSelecionado = dt.Rows(0).Item("codigoMUNI")
                txtBairro.Text = IIf(IsDBNull(dt.Rows(0).Item("bairro")), "", dt.Rows(0).Item("bairro"))

            ElseIf dtCep IsNot Nothing AndAlso dtCep.Rows.Count > 0 Then
                If fbConnection.retornaValorUnico("SELECT COUNT(ID) FROM TB_CIDADE WHERE CODIGO = " + dtCep.Rows(0).Item("ibge")) = 0 Then

                    Dim InsereCidade = fbConnection.executaCommand("INSERT INTO TB_CIDADE(codigo,Nome,codEstado) SELECT " + dtCep.Rows(0).Item("ibge") +
                                                               ", '" + dtCep.Rows(0).Item("localidade") +
                                                               "', (SELECT codigo FROM TB_ESTADO WITH(NOLOCK) WHERE SIGLA = '" + dtCep.Rows(0).Item("uf") + "')")
                End If

                Dim InsereCEP = fbConnection.executaCommand("INSERT INTO TB_IBGE_CEP(ID,CODIGOUF,NOMEUF,CODIGOMESO,NOMEMESO,CODIGOMICRO,NOMEMICRO,CODIGOMUNI,NOMEMUNI,SIGLA,CEP,LOGRADOURO,BAIRRO,CODPAIS,NOMEPAIS)
                                                            SELECT (select MAX(ID) + 1 from TB_IBGE_CEP WITH(NOLOCK) WHERE ID LIKE '1%') , (SELECT codigo FROM TB_ESTADO WITH(NOLOCK) WHERE SIGLA = '" + dtCep.Rows(0).Item("uf") + "'), 
                                                            (SELECT Nome FROM TB_ESTADO WITH(NOLOCK) WHERE SIGLA = '" + dtCep.Rows(0).Item("uf") + "'), '','','','', '" + dtCep.Rows(0).Item("ibge") + "', '" +
                                                            dtCep.Rows(0).Item("localidade") + "', '" + dtCep.Rows(0).Item("uf") + "', '" + dtCep.Rows(0).Item("cep").Replace(".", "").Replace("-", "") + "', '" +
                                                            dtCep.Rows(0).Item("logradouro") + "', '" + dtCep.Rows(0).Item("Bairro") +
                                                            "', (SELECT codPais FROM TB_ESTADO WITH(NOLOCK) WHERE SIGLA = '" + dtCep.Rows(0).Item("uf") + "'),
                                                            (SELECT Nome FROM TB_PAIS where codigo = (SELECT codPais FROM TB_ESTADO WHERE SIGLA = '" + dtCep.Rows(0).Item("uf") + "'))")


                Dim dt2 As DataTable = fbConnection.executaSelect("select * from TB_IBGE_CEP with (nolock) where cep = '" + txtCEP.Text.Replace(".", "").Replace("-", "") + "'")
                If dt2 IsNot Nothing AndAlso dt2.Rows.Count > 0 Then
                    txtLogradouro.Text = IIf(IsDBNull(dt2.Rows(0).Item("logradouro")), "", dt2.Rows(0).Item("logradouro"))
                    txtEstado.ValorSelecionado = dt2.Rows(0).Item("codigoUF")
                    txtCidade.ValorSelecionado = dt2.Rows(0).Item("codigoMUNI")
                    txtBairro.Text = IIf(IsDBNull(dt2.Rows(0).Item("bairro")), "", dt2.Rows(0).Item("bairro"))
                Else
                    MsgBox("CEP Não Encontrado", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("O CEP Informado Não é Válido! Favor Informe um CEP Válido!", MsgBoxStyle.Information, "Aviso")
            End If
        Else
            MsgBox("Informe um CEP Válido!", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub ptbImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptbImagem.MouseDoubleClick
        Dim c = clGeral.buscaImg
        If c <> "" Then
            ptbImagem.ImageLocation = c
        End If
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        ptbImagem.Image = Nothing
    End Sub

    Private Sub cbbTipoPessoa_Selecionando() Handles cbbTipoPessoa.Selecionando
        Dim TipoMotorista As String = "SELECT isnull(IDTipoMotorista,-1) from tb_conf_armazem WHERE IDEMPRESA = " & My.Forms.frmPadrao.IDEmpresa
        Dim IDTipoMotorista = fbConnection.retornaValorUnico(TipoMotorista)
        If cbbTipoPessoa.ValorSelecionado = IDTipoMotorista Then
            txtCEP.Requerido = False
            txtEstado.Requerido = False
            txtCidade.Requerido = False
            txtLogradouro.Requerido = False
            txtBairro.Requerido = False
        End If
    End Sub


    Private Sub frmPessoa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sql = "SELECT IDTIPOPRODUTOR, IDTIPOGERAL FROM TB_CONF_ARMAZEM WHERE IDEMPRESA = " + My.Forms.frmPadrao.IDEmpresa.ToString()
        Dim dtLoc As DataTable = fbConnection.executaSelect(sql)
        If dtLoc IsNot Nothing AndAlso dtLoc.Rows.Count > 0 Then
            tipoProdutor = dtLoc.Rows(0).Item(0)
            tipoGeral = dtLoc.Rows(0).Item(1)
        End If
        setaForm()
        carregaTAG()
        If PermissaoEditar("Pessoa") = False Then
            FbBarra1.btnEdita.Enabled = True  'FAlse
        Else
            FbBarra1.btnEdita.Enabled = True
        End If
        If PermissaoInserir("Pessoa") = False Then
            FbBarra1.btnNovo.Enabled = True 'FAlse
        Else
            FbBarra1.btnNovo.Enabled = True
        End If
        If PermissaoExcluir("Pessoa") = False Then
            FbBarra1.btnExclui.Enabled = False
        Else
            FbBarra1.btnExclui.Enabled = True
        End If

    End Sub

    Private Sub BuscarCep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCep.Click
        If txtCEP.Text.Replace("-", "").Replace(".", "") = "" AndAlso txtCidade.ValorSelecionado <> -1 Then
            Dim sql = "SELECT TOP 1 CEP FROM TB_IBGE_CEP WHERE CODIGOMUNI = " + txtCidade.ValorSelecionado.ToString()
            Dim cep = fbConnection.retornaValorUnico(sql)
            If cep IsNot Nothing Then
                txtCEP.Text = cep
            End If
        End If
    End Sub

    Private Sub pesDados_antesDeAbrir() Handles pesDados.antesDeAbrir, pesContaCont.antesDeAbrir
        frmPesquisaPessoa.Condicao = ""
        frmPesquisaPessoa.cbInativo.Show()
        frmPesquisaPessoa.cbInativo.Visible = True
        setaForm()
    End Sub

    'Private Sub FbButtonVisual1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FbButtonVisual1.Click
    '    If ID <> -1 AndAlso row IsNot Nothing AndAlso row.Codigo <> "" Then
    '        Dim dts As New DataSet

    '        Dim cod As String = row.Codigo

    '        Dim img As Image = clBarCode.geraCodeToImagem2(cod, 200, 100, False)
    '        Dim ms As MemoryStream = New MemoryStream()
    '        img.Save(ms, ImageFormat.Jpeg)
    '        Dim bytBLOBData(ms.Length - 1) As Byte
    '        ms.Position = 0
    '        ms.Read(bytBLOBData, 0, ms.Length)

    '        Dim tb As dtsProdBar.imprimeEtiquetaProdDataTable
    '        Dim tr As New dtsProdBarTableAdapters.imprimeEtiquetaProdTableAdapter
    '        tb = tr.GetData(row.Nome, bytBLOBData)

    '        dts.Tables.Add(tb)

    '        My.Forms.frmGeraRelatorio.TipoRel = TipoRel.Rel.EtiquetaProd
    '        My.Forms.frmGeraRelatorio.DataSetRel = dts
    '        My.Forms.frmGeraRelatorio.ShowDialog()

    '    End If
    'End Sub

    Private Sub dgvDom_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvDom.DataSourceChanged
        If dgvDom.ColumnCount > 0 Then
            dgvDom.Columns("Nome").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    'Private Sub FbButtonVisual2_Click(sender As Object, e As EventArgs) Handles FbButtonVisual2.Click
    '    If ID <> -1 AndAlso row IsNot Nothing Then
    '        Dim TipoCliente As String = fbConnection.retornaValorUnico("select nome from tb_tipo_pessoa where id =" + row.IDTipoPessoa.ToString())
    '        If TipoCliente.ToUpper = "MOTORISTA" OrElse TipoCliente.ToUpper = "COMPRADOR" OrElse TipoCliente.ToUpper = "VENDEDOR" Then
    '            If TipoCliente.ToUpper = "MOTORISTA" Then
    '                Dim dts As New DataSet

    '                Dim tb As dtsRelCli.retornaDadosEmpresaDataTable
    '                Dim tr As New dtsRelCliTableAdapters.retornaDadosEmpresaTableAdapter
    '                tb = tr.GetData(My.Forms.frmPadrao.IDEmpresa, 0, Date.Now, Date.Now)

    '                dts.Tables.Add(tb)

    '                Dim tb1 As dtsRelCli.imprimeFichaClienteIbiaDataTable
    '                Dim tr1 As New dtsRelCliTableAdapters.imprimeFichaClienteIbiaTableAdapter
    '                tb1 = tr1.GetData(row.ID, row.IDTipoPessoa)

    '                dts.Tables.Add(tb1)

    '                My.Forms.frmGeraRelatorio.TipoRel = TipoRel.Rel.FichaClienteIbiaMotorista
    '                My.Forms.frmGeraRelatorio.DataSetRel = dts
    '                My.Forms.frmGeraRelatorio.ShowDialog()
    '            Else
    '                Dim dts As New DataSet

    '                Dim tb As dtsRelCli.retornaDadosEmpresaDataTable
    '                Dim tr As New dtsRelCliTableAdapters.retornaDadosEmpresaTableAdapter
    '                tb = tr.GetData(My.Forms.frmPadrao.IDEmpresa, 0, Date.Now, Date.Now)

    '                dts.Tables.Add(tb)

    '                Dim tb1 As dtsRelCli.imprimeFichaClienteIbiaDataTable
    '                Dim tr1 As New dtsRelCliTableAdapters.imprimeFichaClienteIbiaTableAdapter
    '                tb1 = tr1.GetData(row.ID, row.IDTipoPessoa)

    '                dts.Tables.Add(tb1)

    '                My.Forms.frmGeraRelatorio.TipoRel = TipoRel.Rel.FichaClienteIbia
    '                My.Forms.frmGeraRelatorio.DataSetRel = dts
    '                My.Forms.frmGeraRelatorio.ShowDialog()
    '            End If
    '        Else

    '            Dim dts As New DataSet

    '            Dim tb As dtsRelCli.retornaDadosEmpresaDataTable
    '            Dim tr As New dtsRelCliTableAdapters.retornaDadosEmpresaTableAdapter
    '            tb = tr.GetData(My.Forms.frmPadrao.IDEmpresa, 0, Date.Now, Date.Now)

    '            dts.Tables.Add(tb)

    '            Dim tb1 As dtsRelCli.imprimeFichaClienteDataTable
    '            Dim tr1 As New dtsRelCliTableAdapters.imprimeFichaClienteTableAdapter
    '            tb1 = tr1.GetData(row.ID)

    '            If tb1.Rows.Count = 0 Then
    '                MsgBox("A Ficha só Pode Ser Impressa aos Produtores que Possuem Domicílio!", MsgBoxStyle.Information)
    '                Exit Sub
    '            End If

    '            dts.Tables.Add(tb1)

    '            My.Forms.frmGeraRelatorio.TipoRel = TipoRel.Rel.FichaCliente
    '            My.Forms.frmGeraRelatorio.DataSetRel = dts
    '            My.Forms.frmGeraRelatorio.ShowDialog()
    '        End If
    '    End If
    'End Sub

    Private Sub FbButtonVisual4_Click(sender As Object, e As EventArgs) Handles FbButtonVisual4.Click
        Dim cep = txtCepInterv.Text.Replace(".", "").Replace("-", "").Trim()
        If cep <> "" AndAlso cep.Length = 8 Then
            Dim dt As DataTable = fbConnection.executaSelect("select * from TB_IBGE_CEP where cep = '" + cep.ToString() + "'")
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                txtEnderecoInterv.Text = IIf(IsDBNull(dt.Rows(0).Item("logradouro")), "", dt.Rows(0).Item("logradouro"))
                cbbEstadoInterv.ValorSelecionado = dt.Rows(0).Item("codigoUF")
                cbbCidadeInterv.ValorSelecionado = dt.Rows(0).Item("codigoMUNI")
                txtBairroInterv.Text = IIf(IsDBNull(dt.Rows(0).Item("bairro")), "", dt.Rows(0).Item("bairro"))
            Else
                MsgBox("O CEP Informado Não é Válido! Favor Informe um CEP Válido!", MsgBoxStyle.Information, "Aviso")
            End If
        Else
            MsgBox("Informe um CEP Válido!", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub FbButtonVisual3_Click(sender As Object, e As EventArgs) Handles FbButtonVisual3.Click
        If txtCepInterv.Text.Replace("-", "").Replace(".", "") = "" AndAlso cbbCidadeInterv.ValorSelecionado <> -1 Then
            Dim sql = "SELECT TOP 1 CEP FROM TB_IBGE_CEP WHERE CODIGOMUNI = " + cbbCidadeInterv.ValorSelecionado.ToString()
            Dim cep = fbConnection.retornaValorUnico(sql)
            If cep IsNot Nothing Then
                txtCepInterv.Text = cep
            End If
        End If
    End Sub

    'Private Sub dgvLote_antesDeInserir(IDSelecionado As Integer) Handles dgvLote.antesDeInserir
    '    If dgvLote.dgvDados.RowCount = 0 Then
    '        insereDom()
    '    End If
    'End Sub

    Private Function PermissaoEditar(ByVal Tipo As String)
        Dim checaPermissao As String = "SELECT TOP 1 isnull(Editar,1) from TB_PERMISSAO_TIPO_USUARIO PTU WITH(NOLOCK) "
        'checaPermissao += "WHERE PTU.IDTIPOUSUARIO = " & My.Forms.frmPadrao.IDUsuarioTipo
        checaPermissao += " WHERE PTU.IDTELA = (SELECT ID FROM TB_TELA WHERE NOME = '" & Tipo & "')"
        If fbConnection.retornaValorUnico(checaPermissao) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function PermissaoInserir(ByVal Tipo As String)
        Dim checaPermissao As String = "SELECT  isnull(Inserir,1) from TB_PERMISSAO_TIPO_USUARIO PTU WITH(NOLOCK) "
        checaPermissao += "WHERE PTU.IDTIPOUSUARIO = " & My.Forms.frmPadrao.IDUsuarioTipo
        checaPermissao += " AND PTU.IDTELA = (SELECT ID FROM TB_TELA WHERE NOME = '" & Tipo & "')"
        If fbConnection.retornaValorUnico(checaPermissao) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function PermissaoExcluir(ByVal Tipo As String)
        Dim checaPermissao As String = "SELECT isnull(Excluir,1) from TB_PERMISSAO_TIPO_USUARIO PTU WITH(NOLOCK) "
        checaPermissao += "WHERE PTU.IDTIPOUSUARIO = " & My.Forms.frmPadrao.IDUsuarioTipo
        checaPermissao += " AND PTU.IDTELA = (SELECT ID FROM TB_TELA WHERE NOME = '" & Tipo & "')"
        If fbConnection.retornaValorUnico(checaPermissao) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Private Sub lkpDomicilio_antesDeAbrir() Handles lkpDomicilio.antesDeAbrir
    '    setaForm()
    '    frmPesquisaDomicilio.Condicao = " AND IDPESSOA = " & ID.ToString()
    'End Sub

    Private Sub dgvRedeSocial_atualizaDts(grid As DataGridView) Handles dgvRedeSocial.atualizaDts
        grid.Columns("Link").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grid.Columns("Rede Social").Width = 100
    End Sub

    Private Sub dgvAgente_atualizaDts(grid As DataGridView) Handles dgvAgente.atualizaDts
        grid.Columns("Nome").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grid.Columns("Rateio(%)").Width = 100
    End Sub

    Private Sub cbbTAG_Selecionando() Handles cbbTAG.Selecionando
        carregaTAG()
    End Sub

    Private Sub cbbTAG_DropDown(sender As Object, e As EventArgs) Handles cbbTAG.DropDown
        carregaTAG()
    End Sub

    Public Sub carregaTAG()
        Dim sql As String
        sql = $"IDTAG =         (SELECT P.IDTAG FROM TB_PESSOA P WITH(NOLOCK) WHERE P.ID = {ID}) OR "
        sql += "IDTag NOT IN    (SELECT ISNULL(P.IDTAG, -1) FROM TB_PESSOA P WITH(NOLOCK)) AND "
        sql += "IDTag NOT IN    (SELECT ISNULL(P.IDTAG, -1) FROM TB_PORTARIA P WITH(NOLOCK))"
        Dim sql1 As String
        sql1 = $"(IDTAG NOT IN (SELECT ISNULL(P.IDTAG,-1) FROM TB_PESSOA P WITH(NOLOCK))) AND "
        sql1 += "(IDTAG NOT IN (SELECT ISNULL(P.IDTAG,-1) FROM TB_PORTARIA P WITH(NOLOCK)))"

        If ID <> -1 Then
            cbbTAG.Filtro = sql
        Else
            cbbTAG.Filtro = sql1
        End If
    End Sub

End Class

