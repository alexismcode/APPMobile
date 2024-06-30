using Microsoft.Extensions.Logging;

namespace AlexisSanchez_APPMobile
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
                    fonts.AddFont("ChakraPetch-Bold.ttf", "ChakraPetchBold");
                    fonts.AddFont("ChakraPetch-BoldItalic.ttf", "ChakraPetchBoldItalic");
                    fonts.AddFont("ChakraPetch-Italic.ttf", "ChakraPetchItalic");
                    fonts.AddFont("ChakraPetch-Light.ttf", "ChakraPetchLight");
                    fonts.AddFont("ChakraPetch-LightItalic.ttf", "ChakraPetchLightItalic");
                    fonts.AddFont("ChakraPetch-Medium.ttf", "ChakraPetchMedium");
                    fonts.AddFont("ChakraPetch-MediumItalic.ttf", "ChakraPetchMediumItalic");
                    fonts.AddFont("ChakraPetch-Regular.ttf", "ChakraPetchRegular");
                    fonts.AddFont("ChakraPetch-SemiBold.ttf", "ChakraPetchSemiBold");
                    fonts.AddFont("ChakraPetch-SemiBoldItalic.ttf", "ChakraPetchSemiBoldItalic");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}