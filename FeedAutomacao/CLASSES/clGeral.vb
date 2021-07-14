Imports System.Text
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
'Imports System.Text.RegularExpressions

Public Class clGeral

    'teste gustavo arm
    Public Shared Function buscaImg() As String
        Dim cmh As String = ""
        Dim ofd As New OpenFileDialog
        ofd.Multiselect = False
        ofd.Filter = "Imagem no Formato JPG (*.JPG)|*.JPG|Imagem no Formato BMP (*.BMP)|*.BMP|Imagem no Formato GIF (*.GIF)|*.GIF|Imagem no Formato PNG (*.PNG)|*.PNG"
        ofd.ShowDialog()
        If ofd.FileName <> "" AndAlso System.IO.File.Exists(ofd.FileName) Then
            cmh = ofd.FileName
        End If
        Return cmh
    End Function

    Public Shared Sub TrataRow(row As DataRow)
        Dim index As Integer = 0
        If row IsNot Nothing Then
            For Each col As DataColumn In row.Table.Columns
                If row.IsNull(col.ColumnName) Then
                    If col.DataType Is GetType(System.String) Then row.Item(col.ColumnName) = ""
                    If col.DataType Is GetType(System.Int32) Then row.Item(col.ColumnName) = 0
                    If col.DataType Is GetType(System.Int64) Then row.Item(col.ColumnName) = 0
                    If col.DataType Is GetType(System.Decimal) Then row.Item(col.ColumnName) = 0
                    If col.DataType Is GetType(System.Double) Then row.Item(col.ColumnName) = 0
                    If col.DataType Is GetType(System.SByte) Then row.Item(col.ColumnName) = 0
                    If col.DataType Is GetType(System.Byte) Then row.Item(col.ColumnName) = 0
                    If col.DataType Is GetType(System.Boolean) Then row.Item(col.ColumnName) = False
                End If
            Next
        End If
    End Sub

    Public Shared Function MaskCNPJ(val As String) As String
        If val.Length = 14 Then
            Return val.Format("{0}.{1}.{2}/{3}-{4}", val.Substring(0, 2), val.Substring(2, 3), val.Substring(5, 3), val.Substring(8, 4), val.Substring(12, 2))
        Else
            Return "00.000.000/0000-00"
        End If
    End Function

    'Public Shared Function MaskCPF(val As String) As String
    '    If val.Length = 11 Then
    '        Return val.Format("{0}.{1}.{2}-{3}", val.Substring(0, 3), val.Substring(3, 3), val.Substring(6, 3), val.Substring(9, 2))
    '    Else
    '        Return "000.000.000-00"
    '    End If
    'End Function

    'Public Shared Sub ImprimePedidoVenda(ByVal ID As Integer)
    '    Dim dts As New DataSet

    '    Dim tb As dtsPedidos.ImprimeSolicitaçãoDataTable
    '    Dim tr As New dtsPedidosTableAdapters.ImprimeSolicitaçãoTableAdapter
    '    tb = tr.GetData(ID)

    '    Dim tb1 As dtsPedidos.ImprimePedido_PedidosDataTable
    '    Dim tr1 As New dtsPedidosTableAdapters.ImprimePedido_PedidosTableAdapter
    '    tb1 = tr1.GetData(ID)

    '    Dim tb2 As dtsPedidos.ImprimePedido_Pedidos_OBS_DVDataTable
    '    Dim tr2 As New dtsPedidosTableAdapters.ImprimePedido_Pedidos_OBS_DVTableAdapter
    '    tb2 = tr2.GetData(ID)

    '    dts.Tables.Add(tb)
    '    dts.Tables.Add(tb1)
    '    dts.Tables.Add(tb2)

    '    My.Forms.frmGeraRelatorio.TipoRel = TipoRel.Rel.UpdateImprimeSolicitações
    '    My.Forms.frmGeraRelatorio.DataSetRel = dts
    '    My.Forms.frmGeraRelatorio.ShowDialog()

    'End Sub



    Public Shared Sub imprimeAtendentes()

        Dim dts As New DataSet

        Dim tb As dtsCadAtendentes.ImpAtendentesDataTable
        Dim tr As New dtsCadAtendentesTableAdapters.ImpAtendentesTableAdapter
        tb = tr.GetData()

        dts.Tables.Add(tb)

        My.Forms.frmGeraRelatorio.TipoRel = TipoRel.Rel.UpdateAtendentes
        My.Forms.frmGeraRelatorio.DataSetRel = dts
        My.Forms.frmGeraRelatorio.ShowDialog()


    End Sub




    Public Shared Function Byte2Img(bytes As Byte) As Image
        If bytes > 0 Then
            Dim stream As New MemoryStream(BitConverter.GetBytes(bytes))
            Return Image.FromStream(stream)
        Else
            Return Nothing
        End If
    End Function


    Public Shared Function FileImage2ByteArray(filename As String) As Byte()
        If filename <> "" AndAlso File.Exists(filename) Then
            Dim img As Image = Image.FromFile(filename)
            Return Img2ByteArray(img)
        End If
        Return Nothing
    End Function

    Public Shared Function Img2ByteArray(img As Image) As Byte()
        Dim bytes() As Byte
        If img IsNot Nothing Then
            Dim ms = New MemoryStream()
            img.Save(ms, Imaging.ImageFormat.Jpeg)
            bytes = ms.ToArray()
        End If
        Return bytes
    End Function




End Class
