// Developer Express Code Central Example:
// How to use the PDF printer settings

using DevExpress.Pdf;

namespace PdfProcessorPrinterOptions {
    class Program {

        static void Main(string[] args) {
            // Create a Pdf Document Processor instance and load a PDF into it.
            PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();
            documentProcessor.LoadDocument(@"..\..\Demo.pdf");

            // Declare the PDF printer settings.
            PdfPrinterSettings pdfPrinterSettings = new PdfPrinterSettings();

            // Specify the PDF printer settings.
            pdfPrinterSettings.PageOrientation = PdfPrintPageOrientation.Portrait;
            pdfPrinterSettings.PageNumbers = new int[] { 1, 3, 4, 5 };

            // Setting the PdfPrintScaleMode property to CustomScale requires 
            // specifying the Scale property, as well.
            pdfPrinterSettings.ScaleMode = PdfPrintScaleMode.CustomScale;
            pdfPrinterSettings.Scale = 90;

            // Print the document using the specified printer settings.
            documentProcessor.Print(pdfPrinterSettings);
        }
    }
}
