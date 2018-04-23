// Developer Express Code Central Example:
// How to use the PDF printer settings
// 
// This example illustrates the application programming interface (API) available
// in the PDF Document Processor
// (https://documentation.devexpress.com/#DocumentServer/CustomDocument16491) to
// maintain the document printer settings. This API is provided by the
// PdfPrinterSettings class.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T172274

#region #Reference
using DevExpress.Pdf;
// ...
#endregion #Reference

namespace PdfProcessorPrinterOptions {
    class Program {
        #region #Code
        static void Main(string[] args) {
            // Create a Pdf Document Processor instance and load a PDF into it.
            PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();
            documentProcessor.LoadDocument(@"..\..\Demo.pdf");

            // Declare the PDF printer settings.
            PdfPrinterSettings pdfPrinterSettings = new PdfPrinterSettings();

            // Specify the PDF printer settings.
            pdfPrinterSettings.PageOrientation = PdfPrintPageOrientation.Portrait;
            pdfPrinterSettings.PageNumbers = new int[] { 1, 3, 4, 5 };

            // Changing (reducing) the default printing DPI is only required to 
            // maintain a specific print quality or speed-up document rendering.
            pdfPrinterSettings.PrintingDpi = 600;

            // Setting the PdfPrintScaleMode property to CustomScale requires 
            // specifying the Scale property, as well.
            pdfPrinterSettings.ScaleMode = PdfPrintScaleMode.CustomScale;
            pdfPrinterSettings.Scale = 90;

            // Print the document using the specified printer settings.
            documentProcessor.Print(pdfPrinterSettings);
        }
        #endregion #Code
    }
}
