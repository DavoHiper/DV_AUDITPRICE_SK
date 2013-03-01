Imports System.Math
Imports System.Resources
Imports System.Collections
Imports System.IO
Imports System.IO.Directory
Imports System.IO.File
Imports System.Windows.Forms

Module Modulo
    'para pesquisa binária produtos
    Structure Produto
        Dim EAN As String
        Dim Descr As String
        Dim SMedia As String
        Dim PrcVigente As String
        Dim DataVigente As String
        Dim FlagOferta As String
        Dim FlagEmLinha As String
    End Structure

    Structure Classificacao
        Dim CodDepto As String
        Dim Depto As String
        Dim CodSecao As String
        Dim Secao As String
        Dim CodGrupo As String
        Dim Grupo As String
        Dim CodSubgrupo As String
        Dim Subgrupo As String
    End Structure

    Structure arqOUT
        Dim EAN As String
        Dim Descr As String
        Dim PrcVigente As String
        Dim PrcAuditado As String
        Dim FlagOferta As String
        Dim NroEndereco As String
        Dim TpEndereco As String
        Dim QtdEtiqueta As String
        Dim Status As String
        Dim FlagEmLinha As String
    End Structure

    Public fn As FileStream
    Public br As BinaryReader
    Public found As Boolean
    Public szProduto As String
    Public flOutput As System.IO.StreamWriter

    'Declaracao de Variaveis
    Public Temp As Produto
    Public stOUT As arqOUT
    Public Arquivo As String
    Public currentRecord As Integer = 0
    Public fileName As String
    Public fileSize As Long
    Public recordCount, r, last, first As Integer
    Public codItem, codItemCursor As Long
    Public recSize As Integer
    Public itm As Integer
    Public DirDiretorio As DirectoryInfo = New DirectoryInfo("\BACKUP\DAVO\AUDITPRICE\IN")
    Public oFileInfoCollection() As FileInfo
    Public oFileInfo As FileInfo
    Public i As Integer
    Public loja, codArq, hora, depto, secao, grupo, subgrupo, deptoF, secaoF, grupoF, subgrupoF As String
    Public data = New DateTime()
    Public lstItem As Integer = -1
    Public verifica As Boolean = False

    Public Class Utils

        ''' <summary>
        ''' Método que formata para moeda o conteúdo de um TextBox
        ''' </summary>
        ''' <param name="txt">Controle a ser formatado</param>
        ''' <remarks></remarks>
        ''' 

        Public Shared Sub TextBoxMoeda(ByRef txt As TextBox)
            Dim n As String = String.Empty
            Dim v As Double = 0
            Try
                n = txt.Text.Replace(",", "").Replace(".", "")
                If n.Equals("") Then n = "000"
                n = n.PadLeft(3, "0")
                If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
                v = Convert.ToDouble(n) / 100
                txt.Text = String.Format("{0:N}", v)
                txt.SelectionStart = txt.Text.Length
            Catch ex As Exception
                MessageBox.Show(ex.Message, "TextBoxMoeda")
            End Try
        End Sub

    End Class

End Module
