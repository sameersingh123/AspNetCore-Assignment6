using Assignment6.CustomMiddleware;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run(async (HttpContext context) =>
//{
//    if(context.Request.Path=="/" && context.Request.Query.ContainsKey("email") && context.Request.Query.ContainsKey("password"))
//    {
//        string email = context.Request.Query["email"];
//        string password = context.Request.Query["password"];

//        if(email== "admin@example.com" && password== "admin1234")
//        {
//            await context.Response.WriteAsync("Successfull login");
//        }
//        else
//        {
//            context.Response.StatusCode = 400;

//            await context.Response.WriteAsync("Invalid login");
//        }
//    }
//     if(context.Request.Path=="/")
//    {
//        await context.Response.WriteAsync("Invalid input for 'email'\nInvalid input for 'password' ");
//    }
//     if(/*context.Request.Path=="/" && */context.Request.Query.ContainsKey("email"))
//    {
//        await context.Response.WriteAsync("Invalid input for 'password'");
//    }


//});

//Invoking CustomMiddleware
app.UseMiddleware();

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("No response");
});

app.Run();
