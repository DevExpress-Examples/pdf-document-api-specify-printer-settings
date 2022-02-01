' Developer Express Code Central Example:
' How to use the PDF printer settings
Imports DevExpress.Pdf

Namespace PdfProcessorPrinterOptions

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            ' Create a Pdf Document Processor instance and load a PDF into it.
            Dim documentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
            documentProcessor.LoadDocument("..\..\Demo.pdf")
            ' Declare the PDF printer settings.
            Dim pdfPrinterSettings As PdfPrinterSettings = New PdfPrinterSettings()
            ' Specify the PDF printer settings.
            pdfPrinterSettings.PageOrientation = PdfPrintPageOrientation.Portrait
            pdfPrinterSettings.PageNumbers = New Integer() {1, 3, 4, 5}
            ' Setting the PdfPrintScaleMode property to CustomScale requires 
            ' specifying the Scale property, as well.
            pdfPrinterSettings.ScaleMode = PdfPrintScaleMode.CustomScale
            pdfPrinterSettings.Scale = 90
            ' Print the document using the specified printer settings.
            documentProcessor.Print(pdfPrinterSettings)
        End Sub
    End Class
End Namespace
