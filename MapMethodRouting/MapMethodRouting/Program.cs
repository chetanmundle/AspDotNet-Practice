var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();



app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page - GET");
    });

    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page - POST");
    });
});

//app.MapGet("/Home", () => "Hello World! - GET");
//app.MapPost("/Home", () => "Hello World! - POST");
//app.MapPut("/Home", () => "Hello World! -  PUT");
//app.MapDelete("/Home", () => "Hello World! -  DELETE");
//app.Map("/Home", () => "Hello World!");    // This is for all requests



app.Run();
