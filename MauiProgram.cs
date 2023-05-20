using Microsoft.Extensions.Logging;
using Capsules.Data;
using Blazored.LocalStorage;
using Blazored.SessionStorage;

namespace Capsules;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		ConfigureMiddleware(builder);

        builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}

	public static void ConfigureMiddleware(MauiAppBuilder builder)
	{
        builder.Services.AddBlazoredLocalStorage();
        builder.Services.AddBlazoredSessionStorage();
    }
}
