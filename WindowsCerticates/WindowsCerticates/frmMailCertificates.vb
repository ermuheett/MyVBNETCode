
Imports iTextSharp.text
Imports System.Drawing.Drawing2D
Imports iTextSharp.text.pdf
Imports System.Drawing
Imports System.Text
Imports iTextSharp.text.html.simpleparser
Imports System.Collections.Generic






Imports System.IO

Public Class frmMailCertificates

    Private Sub ButnEmailCertificates_Click(sender As Object, e As EventArgs) Handles ButnEmailCertificates.Click

        Dim pdfDoc As New Document
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("c:\FMS\Sample.pdf", FileMode.Create))

        pdfDoc.Open()

        '  pdfDoc.Add(New Paragraph("paragraph one in PDF"))



        '  pdfDoc.Add(New Paragraph("paragraph two in PDF"))

        'Adding Image..

        Dim imagefilePath As String = "C:\fms\Certificate_format.jpg"

        Dim ImgCert As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imagefilePath)


        pdfDoc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate()) ' For horizontal layout

        pdfDoc.Add(ImgCert)



        pdfDoc.Close()


        MsgBox("Done")



    End Sub

    Private Sub butnPDF_Click(sender As Object, e As EventArgs) Handles butnPDF.Click


        Dim Path As String = "C:\fms\Certificate_format.jpg"

        Dim rect As iTextSharp.text.Rectangle = New iTextSharp.text.Rectangle(400, 300)

        Dim pdfDoc As New Document(rect)

        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("c:\FMS\Sample.pdf", FileMode.Create))

        pdfDoc.Open()
        Dim C1 As Chunk = New Chunk("A chunk represents an isolated string. ")

        For i As Integer = 1 To 4

            pdfDoc.Add(C1)
        Next



        pdfDoc.Close()

        MsgBox("DONE")





    End Sub

    Private Sub butnPDFText_Click(sender As Object, e As EventArgs) Handles butnPDFText.Click


        ' open the reader
        Dim Path As String = "C:\fms\Sample.pdf"
        Dim newFile As String = "C:\fms\Sample1.pdf"

        ' Dim pdfDoc As New Document
        ' Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("c:\FMS\Sample.pdf", FileMode.Create))



        Dim reader As PdfReader = New PdfReader(New FileStream("c:\FMS\Sample.pdf", FileMode.Open))
        Dim Size As iTextSharp.text.Rectangle = reader.GetPageSizeWithRotation(1)
        Dim Document As Document = New Document(Size)
        ' open the writer

        Dim fs As FileStream = New FileStream(newFile, FileMode.Create, FileAccess.Write)
        Dim writer As PdfWriter = PdfWriter.GetInstance(Document, fs)

        Document.Open()

        Dim cb As PdfContentByte = writer.DirectContent
        Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.EMBEDDED)
        Dim Text As String = "WV0501"
        cb.BeginText()
        ' put the alignment And coordinates here
        cb.ShowTextAligned(2, Text, 155, 655, 0)

        cb.EndText()

        '// create the New page And add it to the pdf 
        Dim Page As PdfImportedPage = writer.GetImportedPage(reader, 1)
        cb.AddTemplate(Page, 0, 0)
        Document.Close()
        fs.Close()
        writer.Close()


        MsgBox("Done")
    End Sub

    Private Sub ButnAdditional_Click(sender As Object, e As EventArgs) Handles ButnAdditional.Click



        Dim sReportHeader As New StringBuilder
        sReportHeader.Append("<table style= 'table-layout: fixed  width= '100%' style= 'font-family:Verdana;font-size:8px;'>" +
                        "<tr>" + "<td align=" + "left>" + "@ <img src='http://localhost/img/image1.jpg' width= '520'></img></td>" +
                        "</tr>" + "</table>" + "<div id='divArea1' style='position:absolute;left:50px;top:250px;font-weight:bold;'>Area1</div>")


        Dim workstream As MemoryStream = New MemoryStream()
        Dim Document As New Document
        Dim worker = New HTMLWorker(Document)

        Dim PdfWriter As PdfWriter = PdfWriter.GetInstance(Document, workstream)

        Document.Open()

        worker.StartDocument()
        PdfWriter.CloseStream = False
        '  Dim twopdf As TwoColumnHeaderFooter = New TwoColumnHeaderFooter()

        '  PdfWriter.PageEvent = twopdf
        ' twopdf.OnOpenDocument(PdfWriter, Document)
        worker.Parse(New StringReader(sReportHeader.ToString()))
        worker.EndDocument()
        worker.Close()
        Document.CloseDocument()
        Document.Close()

        Dim byteInfo As Byte() = workstream.ToArray()
        workstream.Write(byteInfo, 0, byteInfo.Length)
        workstream.Position = 0
        PdfWriter.Flush()
        PdfWriter.Close()

        '   Return New FileStreamResult(workstream, "application/pdf")

    End Sub
End Class
