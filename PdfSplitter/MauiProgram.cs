using Microsoft.Extensions.Logging;
using PdfSplitter.Services;
using PdfSplitter.Services.Interfaces;
using PdfSplitter.ViewModels;
using PdfSplitter.Views;

namespace PdfSplitter;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.RegisterAppServices()
			.RegisterViewModels()
			.RegisterViews()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("MaterialIcons-Regular.ttf", alias: "Icons");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

	public static MauiAppBuilder RegisterViews(this MauiAppBuilder builder) 
	{
		builder.Services.AddSingleton<AppShell>();
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<PdfViewPage>();		

		return builder;
	}

	public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<AppShellViewModel>();
		builder.Services.AddSingleton<MainPageViewModel>();
		builder.Services.AddSingleton<PdfViewPageViewModel>();

		return builder;
	}

	public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<IPdfService, PdfService>();
		builder.Services.AddSingleton<ISavePdfService, SavePdfService>();

		return builder;
	}
}
