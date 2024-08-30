using System.Diagnostics;
using System.Globalization;
using Microsoft.Extensions.Primitives;

namespace How_to_create_and_use_a_convention_based_middleware;

/// <summary>
/// A middleware that sets the culture based on the request path.
/// </summary>
/// <remarks>
/// Every middleware must have the following elements:
/// <list type="bullet">
///     <item>A public constructor with a parameter of type <see cref="RequestDelegate"/></item>
///     <item>A public method named <c>Invoke</c> or <c>InvokeAsync</c> where the method returns a <see cref="Task"/> and accepts a first parameter of type <see cref="HttpContent"/></item>
///     <item></item>
///     <item></item>
/// </list>
/// From <a href="https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write?view=aspnetcore-8.0">Write custom ASP.NET Core middleware</a>
/// </remarks>
public class RequestCultureMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        StringValues cultureQuery = context.Request.Query["culture"];
        bool cultureQueryIsPopulated = !string.IsNullOrWhiteSpace(cultureQuery);
        if (cultureQueryIsPopulated)
        {
            CultureInfo culture = new(cultureQuery!);

            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;
        }

        // Call the next delegate/middleware in the pipeline.
        await next(context);
    }
}