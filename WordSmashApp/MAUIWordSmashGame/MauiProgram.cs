using Microsoft.Extensions.Logging;

namespace MAUIWordSmashGame
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
                    fonts.AddFont("ComicSansMS.ttf", "ComicSans");
                    fonts.AddFont("LuckiestGuy-Regular.ttf", "DisplayFont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
