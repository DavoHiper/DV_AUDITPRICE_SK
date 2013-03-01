Imports System
Imports System.IO
Imports System.Text
Imports System.InvalidCastException
Imports System.InvalidOperationException
Imports System.InvalidProgramException
Imports System.NotSupportedException
Imports System.Diagnostics
Imports System.Reflection
Imports System.Windows.Forms.ListBox
Imports System.Math 'para função round

Public Class Coleta

    Public Function ler(ByVal r As Integer, ByVal recSize As Integer)

        'Posiciona cursor no arquivo
        On Error Resume Next

        fn.Seek((r - 1) * recSize, 0)
        If Err.Number <> 0 Then
            itm = 1
            found = True
            Return r
        Else
            Return r
        End If

    End Function

    Function IsDouble(ByVal varValue As Object) As Boolean

        Dim dblTest As Double

        On Error Resume Next

        dblTest = CDbl(varValue)

        IsDouble = Err.Number = 0
    End Function

    Function IsLong(ByVal varValue As Object) As Boolean

        Dim lngTest As Double

        On Error Resume Next

        lngTest = CLng(varValue)

        IsLong = Err.Number = 0
    End Function

    Sub pesquisaProduto(ByVal szProduto)

        recSize = 163 + 1 '164 CARACTERES + 1 FILLER

        fn = New FileStream(fileName, FileMode.Open, FileAccess.Read)
        br = New BinaryReader(fn)

        'tamanho do arquivo
        fileSize = fn.Length
        'total de linhas arquivo
        recordCount = (fileSize / recSize)
        'inicializa ultima linha com total de linhas
        last = recordCount
        'inicializa primeira linha com 0
        first = 0
        'r = linha atual, posiciona no meio
        r = Round(last / 2)
        'inicializa found
        found = False
        'posiciona cursor no arquivo 
        ler(r, recSize)

        itm = 0

        codItem = szProduto

        While (Not found)

            'EAN do produto
            Temp.EAN = br.ReadChars(14)

            br.ReadChars(1) 'pula | da linha do arquivo

            'Descrição do Produto
            Temp.Descr = br.ReadChars(30)

            br.ReadChars(1) 'pula | da linha do arquivo

            'Preço Vigente
            Temp.PrcVigente = br.ReadChars(8)

            'Verifica se o campo é decimal/double
            If (IsDouble(Temp.PrcVigente)) = True Then

                Temp.PrcVigente = Temp.PrcVigente.Replace(",", ".")
                Temp.PrcVigente = FormatCurrency(Temp.PrcVigente, 2, TriState.True, TriState.True, _
                                            TriState.True).Replace("$", "").Trim

            End If

            br.ReadChars(1) 'pula | da linha do arquivo

            'Flag Oferta
            Temp.FlagOferta = br.ReadChars(1)
            br.ReadChars(1) 'pula | da linha do arquivo

            'Flag EmLinha
            Temp.FlagEmLinha = br.ReadChars(1)
            br.ReadChars(1) 'pula | da linha do arquivo

            'Saida Média
            Temp.SMedia = br.ReadChars(6)

            If IsLong(Trim(Temp.EAN)) = True Then
                codItemCursor = CType(Trim(Temp.EAN), Long)
            Else
                codItemCursor = 0
            End If

            If codItem = codItemCursor Then
                found = True
                lblProduto.Text = Temp.Descr
                lblPreco.Text = "R$ " + Temp.PrcVigente
                Exit While
            ElseIf codItem > codItemCursor Then
                first = r
                r = Round((first + last) / 2)
                If (first = r) Then
                    itm = 1
                    Exit While
                End If
                ler(r, recSize)
            Else
                last = r
                r = Round((first + last) / 2)
                If (last = r) Then
                    itm = 1
                    Exit While
                End If
                ler(r, recSize)
            End If
        End While

    End Sub

    Public Sub gravaArquivo(ByVal evento)

        Dim linha

        flOutput = IO.File.AppendText("\BACKUP\DAVO\AUDITPRICE\OUT\" & "I" & Arquivo & ".txt")

        stOUT.EAN = txtCodigo.Text
        stOUT.QtdEtiqueta = txtQtdEtq.Text
        stOUT.FlagEmLinha = Temp.FlagEmLinha
        stOUT.FlagOferta = Temp.FlagOferta

        If (lblPreco.Text <> "") Then
            stOUT.PrcVigente = Temp.PrcVigente
        Else
            stOUT.PrcVigente = 0
        End If

        If txtPreco.Text <> "" Then
            stOUT.PrcAuditado = txtPreco.Text
        Else
            stOUT.PrcAuditado = 0
        End If

        Dim Separador = "|"

        Select Case evento
            Case 1 'Grava Header
                linha = "I" & loja.PadLeft(4, "0") & Separador & deptoF & Separador & secaoF & Separador & grupoF & Separador & subgrupoF & Separador & Format(DateTime.Now, "ddMMyyHHmmss") & Separador & codArq
            Case 2 'Grava Corpo
                linha = stOUT.EAN & Separador & _
                        stOUT.PrcAuditado & Separador & _
                        stOUT.PrcVigente & Separador & _
                        stOUT.FlagOferta & Separador & _
                        stOUT.FlagEmLinha & Separador & _
                        stOUT.TpEndereco & Separador & _
                        stOUT.NroEndereco & Separador & _
                        stOUT.QtdEtiqueta & Separador & _
                        stOUT.Status

                stOUT.Status = 1 'Volta Status para Sem Divergencia
                txtPreco.Text = "" 'Limpa Campo de Preço

            Case 3 'Grava Footer
                linha = "F" & loja.PadLeft(4, "0") & Separador & Format(DateTime.Now, "ddMMyyHHmmss") & Separador & codArq
        End Select

        flOutput.WriteLine(linha)

        flOutput.Close()

    End Sub

    Sub moveArquivo()

        'Move arquivo de entrada para pasta PROC de arquivos processados
        IO.File.Move("\BACKUP\DAVO\AUDITPRICE\IN\" + "C" + Arquivo, "\BACKUP\DAVO\AUDITPRICE\IN\PROC\" + "C" + Arquivo)

        frmAuditorias.lstArquivos.Items.RemoveAt(lstItem)

    End Sub

    Sub mostraMsg()

        chkEtq.Enabled = False
        chkPrc.Enabled = False

        frmMsg.Visible = True

    End Sub

    Sub limpaCampos()

        lblOferta.Visible = False
        txtCodigo.Enabled = True
        txtCodigo.Text = ""
        lblPreco.Text = ""
        lblProduto.Text = ""
        txtQtdEtq.Text = ""

        chkEtq.Enabled = False
        chkPrc.Enabled = False
        chkEtq.Checked = False
        chkPrc.Checked = False

        lblQtdEtq.Visible = False
        txtQtdEtq.Visible = False

        cmdConfirma.Enabled = False

        txtCodigo.Enabled = True
        txtCodigo.Focus()

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress

        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
               Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If

    End Sub

    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        If txtCodigo.TextLength > 13 Then
            MsgBox("Código incorreto, reescaneie o produto!")
            txtCodigo.Text = ""
            txtCodigo.Focus()
        Else
            If txtCodigo.Text <> "" Then

                txtCodigo.Enabled = False
                pesquisaProduto(txtCodigo.Text)

                If itm = 0 Then

                    chkPrc.Enabled = True
                    chkEtq.Enabled = True
                    cmdConfirma.Enabled = True
                    txtCodigo.Enabled = False

                    If Temp.FlagOferta = "S" Then
                        lblOferta.Visible = True
                    End If

                Else

                    cmdConfirma.Enabled = True
                    mostraMsg()

                End If

            End If
        End If

    End Sub

    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click
        If MsgBox("Deseja mesmo sair?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            gravaArquivo(3)
            moveArquivo()

            frmAuditorias.txtDpto.Text = ""
            frmAuditorias.txtSecao.Text = ""
            frmAuditorias.txtGrupo.Text = ""
            frmAuditorias.txtSubgrupo.Text = ""
            frmAuditorias.txtArquivo.Text = ""

            Me.Close()

        Else
            txtCodigo.Focus()
        End If

    End Sub

    Private Sub cmdConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirma.Click

        If txtQtdEtq.Visible = True Then

            If txtQtdEtq.Text = "0" Or txtQtdEtq.Text = "" Then

                MsgBox("Campo deve ser preenchido com algum valor ou maior que 0!", MsgBoxStyle.Critical)
                txtQtdEtq.Text = ""
                txtQtdEtq.Focus()

            Else

                If chkEtq.Checked = True Or chkPrc.Checked = True Then

                    stOUT.Status = 2  'Status Divergente

                End If

                gravaArquivo(2)
                limpaCampos()

            End If

        Else

            If txtPreco.Visible = True Then

                stOUT.PrcAuditado = txtPreco.Text

                txtPreco.Visible = False

                lblQtdEtq.Visible = True
                txtQtdEtq.Visible = True
                txtQtdEtq.Focus()

            Else

                gravaArquivo(2)
                limpaCampos()

            End If

        End If

    End Sub

    Private Sub Coleta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'grava header do arquivo
        gravaArquivo(1)

        'Inicia Status com 1 (item sem divergencia)
        stOUT.Status = 1

    End Sub

    Private Sub chkPrc_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrc.CheckStateChanged

        If chkPrc.Checked = True Then

            chkEtq.Visible = False
            txtPreco.Visible = True
            txtPreco.Focus()
        Else

            chkEtq.Visible = True
            txtPreco.Visible = False
            cmdConfirma.Focus()

        End If

        If chkPrc.Checked = False And chkEtq.Checked = False Then

            lblQtdEtq.Visible = False
            txtQtdEtq.Visible = False

        End If

    End Sub

    Private Sub chkEtq_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEtq.CheckStateChanged

        If chkEtq.Checked = True Then

            chkPrc.Visible = False

            If txtPreco.Visible = True Then

                txtPreco.Focus()

            Else

                lblQtdEtq.Visible = True
                txtQtdEtq.Visible = True

                txtQtdEtq.Focus()

            End If

        Else

            chkPrc.Visible = True

        End If

        If chkPrc.Checked = False And chkEtq.Checked = False Then

            lblQtdEtq.Visible = False
            txtQtdEtq.Visible = False

        End If

    End Sub

    Private Sub btnSim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSim.Click
        frmMsg.Visible = False
        stOUT.Status = 3    'Status de Item Sem Cadastro
        chkPrc.Enabled = False
        chkEtq.Enabled = True
        cmdConfirma.Enabled = True
        txtCodigo.Enabled = False
        chkPrc.Checked = True
    End Sub

    Private Sub btnNao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNao.Click
        frmMsg.Visible = False
        cmdConfirma.Enabled = False
        limpaCampos()
    End Sub

    Private Sub txtPreco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)Handles txtPreco.TextChanged

        Utils.TextBoxMoeda(txtPreco)

    End Sub

    Private Sub txtQtdEtq_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtdEtq.LostFocus
        If txtQtdEtq.Text <> "" Then
            If txtQtdEtq.Text > 10 Then
                MsgBox("Quantidade de Etiquetas não pode ser maior que 10", MsgBoxStyle.Exclamation)
                txtQtdEtq.Text = ""
                txtQtdEtq.Focus()
            End If
        End If
    End Sub

End Class
