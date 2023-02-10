using PdfSplitter.Models;
using System.Windows.Input;

namespace PdfSplitter.Controls;

public partial class PdfPageContent : ContentView
{
    public static readonly BindableProperty PageProperty = BindableProperty.Create(nameof(Page), typeof(PdfPageItem), typeof(PdfPageContent), null);
    public static readonly BindableProperty SelectPageCommandProperty = BindableProperty.Create(nameof(SelectPageCommand), typeof(ICommand), typeof(PdfPageContent), default(ICommand));   

    public PdfPageContent()
	{
		InitializeComponent();
    }

    public PdfPageItem Page
    {
        get => (PdfPageItem)GetValue(PageProperty);
        set => SetValue(PageProperty, value);
    }

    public ICommand SelectPageCommand
    {
        get => (ICommand)GetValue(SelectPageCommandProperty);
        set => SetValue(SelectPageCommandProperty, value);
    }
}