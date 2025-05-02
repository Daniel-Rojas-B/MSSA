using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using SoccerBettingApp.Services;
using SoccerBettingApp.ViewModel;
using SoccerBettingApp.View;

namespace SoccerBettingApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            // configuration from appsettings or Secrets
            builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            builder.Services.AddSingleton<IConfiguration>(builder.Configuration);


            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Register services
            builder.Services.AddSingleton<AzureSqlService>();
            builder.Services.AddSingleton<UserService>(); 
            builder.Services.AddSingleton<HttpClient>();
            builder.Services.AddSingleton<SoccerApiService>();

            // Register view models
            builder.Services.AddTransient<BetViewModel>();
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<MatchListViewModel>();

            // Register pages (views)
            builder.Services.AddTransient<BetPage>();            
            builder.Services.AddTransient<LoginPage>();            
            builder.Services.AddTransient<MatchListPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

