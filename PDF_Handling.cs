using GemBox.Pdf;
using GemBox.Pdf.Content;
namespace Learn
{
    public class PDF_Handling
    {
        public void PdfCreation()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            var document = new PdfDocument();
            var page = document.Pages.Add();
            var text = new PdfFormattedText();
            text.Append("Hello");
            page.Content.DrawText(text, new PdfPoint(10,800));
            document.Save("samplePDF.pdf");

        }

        public void EditPDF()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            var document = PdfDocument.Load("samplePDF.pdf");
            var page = document.Pages.Clear;
            var text = new PdfFormattedText();
            text.Append("New text");
            // page.Content.DrawText(text,new PdfPoint(10,800));
            document.Save();
        }
        public static void PDF_Handling_Main()
        {
            PDF_Handling pdf = new PDF_Handling();
            // pdf.PdfCreation();
            pdf.EditPDF();
        }
    }
}