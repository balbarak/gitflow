using Microsoft.AspNetCore.Hosting.Server.Features;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    // This is a mainline !
    //increment release !
    //ok
    return "Bug has been fixed !";
});

app.Run();
