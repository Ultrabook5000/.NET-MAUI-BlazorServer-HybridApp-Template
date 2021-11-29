namespace $safeprojectname$.Extensions;

public static class MauiHybridServices
{
    public static void AddMauiHybridServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddSingleton<WeatherForecastService>();
    }
}
