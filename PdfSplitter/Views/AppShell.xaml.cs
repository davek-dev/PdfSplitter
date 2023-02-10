using PdfSplitter.ViewModels;

namespace PdfSplitter.Views;

public partial class AppShell : Shell
{
	public AppShell(AppShellViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

		// Register routes
        Routing.RegisterRoute(nameof(PdfViewPage), typeof(PdfViewPage));
    }   

}
