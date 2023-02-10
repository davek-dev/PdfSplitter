using PdfSplitter.ViewModels;

namespace PdfSplitter.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

	
}

