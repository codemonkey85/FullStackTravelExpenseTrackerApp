using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TravelExpenseTracker.Pages;
using TravelExpenseTracker.ViewModels;

namespace TravelExpenseTracker;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        var services = builder.Services;

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
                fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
            })
            .UseMauiCommunityToolkit();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        services
            .AddTransient<LoginViewModel>()
            .AddTransient<LoginPage>()
            .AddTransient<RegisterViewModel>()
            .AddTransient<RegisterPage>();

        return builder.Build();
    }
}
