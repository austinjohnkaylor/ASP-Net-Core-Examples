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

<hr>

[Back to Fundamentals](../README.md) |
[Back to Solution Home](../../README.md) |
[Back to Top](#aspnet-core---fundamentals---middleware)
