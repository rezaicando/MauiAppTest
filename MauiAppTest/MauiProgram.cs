using MauiApp1.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace MauiApp1;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainPage>(); //singleton is global 
		builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddTransient<DetailPage>(); //transient is temperary and each time creates it
        builder.Services.AddTransient<DetailViewModel>();
        return builder.Build();
	}
}
