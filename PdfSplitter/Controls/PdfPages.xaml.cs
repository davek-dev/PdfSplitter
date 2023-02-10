using PdfSplitter.Models;
using System.Collections.ObjectModel;

namespace PdfSplitter.Controls;

public partial class PdfPages : ContentView
{
    public static readonly BindableProperty PagesProperty = BindableProperty.Create(nameof(Pages), typeof(ObservableCollection<PdfPageItem>), typeof(PdfPages), null);
    public static readonly BindableProperty SelectedPageProperty = BindableProperty.Create(nameof(SelectedPage), typeof(PdfPageItem), typeof(PdfPages), null);

    public PdfPages()
	{
		InitializeComponent();
	}

    public PdfPageItem SelectedPage
    {
        get => (PdfPageItem)GetValue(SelectedPageProperty);
        set => SetValue(SelectedPageProperty, value);
    }

    public ObservableCollection<PdfPageItem> Pages
    {
        get => (ObservableCollection<PdfPageItem>)GetValue(PagesProperty);
        set => SetValue(PagesProperty, value);
    }
}