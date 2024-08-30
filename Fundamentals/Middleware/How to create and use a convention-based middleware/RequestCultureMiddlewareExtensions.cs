using How_to_create_and_use_a_convention_based_middleware;

namespace ASPNetCore.Fundamentals.Middleware.How_to_create_and_use_a_convention_based_middleware;

/// <summary>
/// An extension method for adding the <see cref="RequestCultureMiddleware"/> to the request pipeline.
/// </summary>
/// <remarks>
/// Typically, an extension method is created to expose a middleware through IApplicationBuilder:
/// </remarks>
/// <example>
/// <code>
/// using Middleware.Example;
/// using System.Globalization;
///
/// var builder = WebApplication.CreateBuilder(args);
/// var app = builder.Build();
///
/// app.UseHttpsRedirection();
///
/// app.UseRequestCulture();
///
/// app.Run(async (context) =>
/// {
///     await context.Response.WriteAsync(
///         $"CurrentCulture.DisplayName: {CultureInfo.CurrentCulture.DisplayName}");
/// });
///
/// app.Run();
/// </code>
/// </example>
public static class RequestCultureMiddlewareExtensions
{
    public static IApplicationBuilder UseRequestCulture(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestCultureMiddleware>();
    }
}