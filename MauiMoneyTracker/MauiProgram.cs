﻿using MauiMoneyTracker.Data;
using MauiMoneyTracker.Services;
using Microsoft.Extensions.Logging;

namespace MauiMoneyTracker
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
            builder.Services.AddBlazorBootstrap();
            builder.Services.AddScoped<HistorySpents>();
            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}