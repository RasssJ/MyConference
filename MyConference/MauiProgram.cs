﻿using MyConference.Pages;
using MyConference.ViewModels;

namespace MyConference;

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

        builder.Services.AddTransient<SchedulePage>();
        builder.Services.AddTransient<ScheduleViewModel>();

        return builder.Build();
	}
}
