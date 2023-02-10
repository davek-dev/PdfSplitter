using PdfSplitter.ViewModels;

namespace PdfSplitter.Views;

public partial class About : ContentPage
{
	public About(AboutViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}