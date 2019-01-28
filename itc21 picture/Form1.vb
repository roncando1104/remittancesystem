Imports System.IO
Imports System.Data
Imports System.Reflection
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Form1

    Public Sub New()
        InitializeComponent()
        Me.BindDataGridView()
    End Sub

    Private Sub BindDataGridView()
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn() {New DataColumn("Id", GetType(Integer)), _
                                               New DataColumn("Name", GetType(String)), _
                                               New DataColumn("Country", GetType(String))})
        dt.Rows.Add(1, "John Hammond", "United States")
        dt.Rows.Add(2, "Mudassar Khan", "India")
        dt.Rows.Add(3, "Suzanne Mathews", "France")
        dt.Rows.Add(4, "Robert Schidner", "Russia")
        Me.dataGridView1.DataSource = dt
    End Sub

    Private Sub btnExportPDF_Click(sender As System.Object, e As System.EventArgs) Handles btnExportPDF.Click
        'Creating iTextSharp Table from the DataTable data
        Dim pdfTable As New PdfPTable(dataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 30
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1

        'Adding Header row
        For Each column As DataGridViewColumn In dataGridView1.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.Color(240, 240, 240)
            pdfTable.AddCell(cell)
        Next

        'Adding DataRow
        For Each row As DataGridViewRow In dataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                pdfTable.AddCell(cell.Value.ToString())
            Next
        Next

        'Exporting to PDF
        Dim folderPath As String = "C:\PDFs\"
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Using stream As New FileStream(folderPath & "DataGridViewExport.pdf", FileMode.Create)
            Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            PdfWriter.GetInstance(pdfDoc, stream)
            pdfDoc.Open()
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()
            stream.Close()
        End Using
    End Sub
End Class
