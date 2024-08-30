# ASP.NET Core - Fundamentals - App Startup
ASP.NET Core apps created with the web templates contain the application startup code in the Program.cs file.

The following examples that show how to use app startup code in different ways support the following ASP.NET Core platforms:
- Razor Pages
- MVC Controllers with Views
- Web API with Controllers
- Minimal APIs

# Projects
## [Extend Startup with Startup Filters](Extend%20Startup%20with%20Startup%20Filters/Extend%20Startup%20with%20Startup%20Filters.csproj)
### Overview
This project demonstrates how to use startup filters to extend the Program class with additional services and middleware.

Specifically, the project demonstrates how to register a middleware with `IStartupFilter` interface. The [RequestSetOptionsMiddleware](Extend%20Startup%20with%20Startup%20Filters/RequestSetOptionsMiddleware.cs) middleware sets an options value from a query string parameter
### Background
#### What is a Startup Filter?
A startup filter is a class that can be used to modify the Startup class. It can be used to add services and middleware to the application. Startup filters are executed before the ConfigureServices and Configure methods in the Startup class.
#### Why Use a Startup Filter?
Startup filters can be used to add services and middleware to the application without modifying the Startup class. This can be useful when you want to add services and middleware to the application without modifying the Startup class.

Startup filters can be used for the following purposes:
- To configure middleware at the beginning or end of an app's middleware pipeline without an explicit call to Use{Middleware}. Use IStartupFilter to add defaults to the beginning of the pipeline without explicitly registering the default middleware. IStartupFilter allows a different component to call Use{Middleware} on behalf of the app author.
- To create a pipeline of Configure methods. IStartupFilter.Configure can set a middleware to run before or after middleware added by libraries
#### How to Use a Startup Filter
To use a startup filter, you need to create a class that implements the IStartupFilter interface. The IStartupFilter interface has a single method called Configure that takes a StartupDelegate and returns a StartupDelegate. The Configure method can be used to add services and middleware to the application.

## Add Configuration at Startup from External Assembly
`TODO`
## Using an Explicit Startup Class
`TODO`

[Back to Fundamentals](../README.md) |
[Back to Solution Home](../../README.md) |
[Back to Top](#aspnet-core---fundamentals---app-startup)
```