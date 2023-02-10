using PdfSplitter.Models;
using System.Collections.ObjectModel;

namespace PdfSplitter.Services.Interfaces
{
    public interface IPdfService
    {
        Task LoadPdf(string path);

        void UnloadPdf();

        ObservableCollection<PdfPageItem> Items { get; }
        ObservableCollection<PdfPageItem> SelectedItems { get; }

        void SelectItem(PdfPageItem item);

        void UnselectItem(PdfPageItem item);

        string PdfFilePath { get; }
    }
}
