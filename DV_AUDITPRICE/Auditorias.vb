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
Imports System.DBNull

Public Class frmAuditorias

    Sub buscaArquivosDiretorio()
        '### Necessário para utilizar algumas classes envolvidas

        '### Preenche o FileCollection com um Array de objetos FileInfo

        oFileInfoCollection = DirDiretorio.GetFiles("C*")

        '### Podemos utilizar os objetos da coleção oFileCollection para preencher um ListBox por exemplo

        For i = 0 To oFileInfoCollection.Length() - 1

            oFileInfo = oFileInfoCollection.GetValue(i)

            fn = New FileStream(oFileInfo.FullName, FileMode.Open, FileAccess.Read)
            br = New BinaryReader(fn)
            fn.Seek(0, 0)
            'Despreza *I* de Inicio do arquivo
            br.ReadChars(1)

            'Captura Loja
            loja = br.ReadChars(4)
            br.ReadChars(1)

            'Captura Departamento
            br.ReadChars(33)
            br.ReadChars(1)

            'Captura Secao
            br.ReadChars(33)
            br.ReadChars(1)

            'Captura Secao
            br.ReadChars(33)
            br.ReadChars(1)

            'Captura Secao
            br.ReadChars(33)
            br.ReadChars(1)

            'Captura Data
            data = br.ReadChars(6)
            hora = br.ReadChars(6)
            br.ReadChars(1)

            'Captura Codigo Arquivo
            codArq = br.ReadChars(8)

            loja = CInt(loja)
            'codArq = CInt(codArq)
            lstArquivos.Items.Add("L" & loja.PadLeft(2, "0") & " D" & data & " A" & codArq)

        Next

    End Sub

    Sub retornaClassificacao()

        Dim fileName = "\BACKUP\DAVO\AUDITPRICE\IN\" + "C" + Arquivo

        fn = New FileStream(fileName, FileMode.Open, FileAccess.Read)
        br = New BinaryReader(fn)
        fn.Seek(0, 0)
        'Despreza *I* de Inicio do arquivo
        br.ReadChars(1)

        'Captura Loja
        br.ReadChars(4)
        br.ReadChars(1)

        'Captura Departamento
        deptoF = br.ReadChars(33)
        depto = Replace(deptoF, "|", "-")
        br.ReadChars(1)

        'Captura Secao
        secaoF = br.ReadChars(33)
        secao = Replace(secaoF, "|", "-")
        br.ReadChars(1)

        'Captura Secao
        grupoF = br.ReadChars(33)
        grupo = Replace(grupoF, "|", "-")
        br.ReadChars(1)

        'Captura Secao
        subgrupoF = br.ReadChars(33)
        subgrupo = Replace(subgrupoF, "|", "-")
        br.ReadChars(1)

        'Captura Data
        br.ReadChars(6)
        br.ReadChars(6)
        br.ReadChars(1)

        'Captura Codigo Arquivo
        codArq = br.ReadChars(8)
    End Sub

    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click

        If MsgBox("Deseja mesmo sair?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        buscaArquivosDiretorio()

    End Sub

    Private Sub lstArquivos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstArquivos.SelectedIndexChanged

        cmdOk.Enabled = True

        Arquivo = lstArquivos.SelectedItem

        If Arquivo <> "" Then
            Arquivo = loja.PadLeft(4, "0") & "_" & codArq
            retornaClassificacao()
            txtDpto.Text = depto
            txtSecao.Text = secao
            txtGrupo.Text = grupo
            txtSubgrupo.Text = subgrupo
            txtArquivo.Text = codArq

            lstItem = lstArquivos.SelectedIndex

        End If

    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click

        fileName = "\BACKUP\DAVO\AUDITPRICE\IN\" + "C" + Arquivo
        Coleta.Show()

    End Sub

End Class