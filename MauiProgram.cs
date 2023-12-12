using Microsoft.Extensions.Logging;

namespace Kerekes_Roberta_Lab7
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .ConfigureEssentials(essentials =>
                {
                    essentials.UseMapServiceToken("3Xz8FSi9K5HoTIDGbYUD~_rPJbGbllLtt7otWeXbjwA~AiFpAQdOv3b7yACHqKRKvX8jtVMg7J7ru7t-VdklU6YqoO2LKPZlHC8mvQkvgjUc");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}