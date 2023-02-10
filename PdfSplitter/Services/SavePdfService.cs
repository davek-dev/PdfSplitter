using iTextSharp.text.pdf;
using PdfSplitter.Services.Interfaces;
using Windows.Storage;
using Windows.Storage.Streams;

namespace PdfSplitter.Services
{
    public class SavePdfService : ISavePdfService
    {
        public async Task SavePdf(string inputFile, StorageFile outputFile, IEnumerable<int> pages)
        {
            var stream = await outputFile.OpenAsync(FileAccessMode.ReadWrite);
            using var outputStream = stream.GetOutputStreamAt(0);

            var pdfStream = new MemoryStream();

            using var reader = new PdfReader(inputFile);
            reader.SelectPages(pages.ToArray());

            PdfStamper stamper = new PdfStamper(reader, pdfStream);
            stamper.Close();

            pdfStream.Position = 0;

            await pdfStream.CopyToAsync(outputStream.AsStreamForWrite((int)pdfStream.Length));

            stream.Dispose();            
        }
    }
}
