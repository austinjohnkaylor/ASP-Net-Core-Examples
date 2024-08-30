namespace ASPNetCore.Fundamentals.AppStartup.ExtendStartupWithStartupFilters;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
        builder.Services.AddTransient<IStartupFilter,
            RequestSetOptionsStartupFilter>(); // Registers the Startup Filter RequestSetOptionsStartupFilter
        
        WebApplication app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}