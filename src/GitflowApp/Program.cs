using Microsoft.AspNetCore.Hosting.Server.Features;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    //sdf//sdafsdaf/fasd
    return "Bug has been fixed !";

});

app.Run();
