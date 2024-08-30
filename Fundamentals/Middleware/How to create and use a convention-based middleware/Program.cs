using System.Globalization;
using ASPNetCore.Fundamentals.Middleware.How_to_create_and_use_a_convention_based_middleware;
using How_to_create_and_use_a_convention_based_middleware;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseHttpsRedirection();

app.UseRequestCulture();

app.Run(async context =>
{
    await context.Response.WriteAsync(
        $"CurrentCulture.DisplayName: {CultureInfo.CurrentCulture.DisplayName}");
});

app.Run();