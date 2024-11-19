namespace TNTGoClone;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("RobotoCondensed-Regular.ttf", "RobotoCondensedRegular");
			});

		return builder.Build();
	}
}
