using PdfSplitter.ViewModels;
using PdfSplitter.Views;
using System.Reflection;

namespace PdfSplitter;

public partial class App : Application
{
	public App(AppShellViewModel viewModel)
	{
		InitializeComponent();
        MainPage = new AppShell(viewModel);
		MainPage.Title = $"PDF Splitter v{ ((AssemblyInformationalVersionAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false).FirstOrDefault()).InformationalVersion }";
    }
}
