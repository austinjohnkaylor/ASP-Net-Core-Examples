using System.Net;
using Microsoft.Extensions.Primitives;

namespace ASPNetCore.Fundamentals.AppStartup.ExtendStartupWithStartupFilters;

/// <summary>
/// Sets an options value from a query string parameter
/// </summary>
/// <remarks>
/// From <a href="https://learn.microsoft.com/en-us/aspnet/core/fundamentals/startup?view=aspnetcore-8.0#extend-startup-with-startup-filters">ASP.NET Core Fundamentals: Extend Startup with Startup Filters</a>
/// </remarks>
public class RequestSetOptionsMiddleware(RequestDelegate next)
{
    // Test with https://localhost:5001?option=Hello
    public async Task Invoke(HttpContext httpContext)
    {
        StringValues option = httpContext.Request.Query["option"];

        if (!string.IsNullOrWhiteSpace(option))
        {
            httpContext.Items["option"] = WebUtility.HtmlEncode(option);
        }

        await next(httpContext);
    }
}