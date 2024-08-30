# ASP.NET Core - Fundamentals - Middleware
ASP.NET Core middleware is software that's assembled into an app pipeline to handle requests and responses. Each component:
- Chooses whether to pass the request
- Can perform work before and after the next component in the pipeline
- Can short-circuit the pipeline and end the request
- Can pass the request to the next component in the pipeline
- Can modify the response
- Can perform work after the next component in the pipeline
- Can perform work on the response
- Can short-circuit the pipeline and end the response
- Can pass the response to the previous component in the pipeline

## Projects
### [How to create and use a convention-based middleware](How%20to%20create%20and%20use%20a%20convention-based%20middleware/.)
This project demonstrates how to create and use a convention-based middleware in an ASP.NET Core app.

This project is based off of the [ASP.NET Core Middleware](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write?view=aspnetcore-8.0) tutorial to write custom middleware

### [How to use scoped services in middleware](How%20to%20use%20scoped%20services%20in%20middleware/.)
[TODO](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write?view=aspnetcore-8.0#per-request-middleware-dependencies)

This project shows how to use scoped services in middleware in an ASP.NET Core app. 

This is important because middleware are registered once for the lifetime of the application. This means that if you try to use a scoped service in middleware using regular constructor dependency-injection, it will not work as expected.

### [How to create branches in the middleware pipeline](How%20to%20create%20branches%20in%20the%20middleware%20pipeline/.)
[TODO](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0#branch-the-middleware-pipeline)

This project demonstrates how to create branches in the middleware pipeline in an ASP.NET Core app.

### [How to implement and use built-in Rate-Limiting middleware](How%20to%20implement%20and%20use%20built-in%20Rate-Limiting%20middleware/.)
[TODO]https://learn.microsoft.com/en-us/aspnet/core/performance/rate-limit?view=aspnetcore-8.0)

This project demonstrates how to implement and use built-in Rate-Limiting middleware in an ASP.NET Core app.

### [How to implement and use a Response-Caching middleware](How%20to%20implement%20and%20use%20a%20Response-Caching%20middleware/.)
[TODO](https://learn.microsoft.com/en-us/aspnet/core/performance/caching/middleware?view=aspnetcore-8.0)

This project demonstrates how to implement and use a Response-Caching middleware in an ASP.NET Core app.

### [How to implement and use a Request Decompression middleware](How%20to%20implement%20and%20use%20a%20Request%20Decompression%20middleware/.)
[TODO](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/request-decompression?view=aspnetcore-8.0)

This project demonstrates how to implement and use a Request Decompression middleware in an ASP.NET Core app.


<hr>

[Back to Fundamentals](../README.md) |
[Back to Solution Home](../../README.md) |
[Back to Top](#aspnet-core---fundamentals---middleware)
