namespace ASPNetCore.Fundamentals.AppStartup.ExtendStartupWithStartupFilters;

/// <summary>
/// Registers a startup filter that uses the <see cref="RequestSetOptionsMiddleware"/> middleware
/// </summary>
/// <remarks>
/// From <a href="https://learn.microsoft.com/en-us/aspnet/core/fundamentals/startup?view=aspnetcore-8.0#extend-startup-with-startup-filters">ASP.NET Core Fundamentals: Extend Startup with Startup Filters</a>
/// </remarks>
public class RequestSetOptionsStartupFilter : IStartupFilter
{
    public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
    {
        return builder =>
        {
            builder.UseMiddleware<RequestSetOptionsMiddleware>();
            next(builder);
        };
    }
}