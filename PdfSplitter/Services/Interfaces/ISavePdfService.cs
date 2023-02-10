using Windows.Storage;

namespace PdfSplitter.Services.Interfaces
{
    public interface ISavePdfService
    {
        Task SavePdf(string inputFile, StorageFile outputFile, IEnumerable<int> pages);
    }
}
