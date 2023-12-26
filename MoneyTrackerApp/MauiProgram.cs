using Microsoft.Extensions.Logging;
using MoneyTrackerDb;

namespace MoneyTrackerApp
{
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
            SetDatabase(builder);

            return builder.Build();
        }

        private static void SetDatabase(MauiAppBuilder builder)
        {
            //builder.Services.AddDbContext<MoneyTrackerDbContext>();
            //MoneyTrackerDbContext dbContext = builder.Services.BuildServiceProvider().GetRequiredService<MoneyTrackerDbContext>();
            //dbContext.Database.EnsureCreated();
        }
    }
}
