using PdfSplitter.ViewModels;

namespace PdfSplitter.Views;

public partial class PdfViewPage : ContentPage
{
	public PdfViewPage(PdfViewPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }	
}

