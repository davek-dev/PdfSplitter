using PdfSplitter.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PdfSplitter.Controls;

public partial class PdfSelectedPages : ContentView
{
    public static readonly BindableProperty SelectedPagesProperty = BindableProperty.Create(nameof(SelectedPages), typeof(ObservableCollection<PdfPageItem>), typeof(PdfSelectedPages), null);
    public static readonly BindableProperty RemovePageCommandProperty = BindableProperty.Create(nameof(RemovePageCommand), typeof(ICommand), typeof(PdfSelectedPages), default(ICommand));

    public PdfSelectedPages()
    {
        InitializeComponent();
    }

    public ICommand RemovePageCommand
    {
        get => (ICommand)GetValue(RemovePageCommandProperty);
        set => SetValue(RemovePageCommandProperty, value);
    }

    public ObservableCollection<PdfPageItem> SelectedPages
    {
        get => (ObservableCollection<PdfPageItem>)GetValue(SelectedPagesProperty);
        set => SetValue(SelectedPagesProperty, value);
    }
}