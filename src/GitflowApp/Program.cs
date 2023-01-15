using Microsoft.AspNetCore.Hosting.Server.Features;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    // This is a mainline !
    //increment release !
    return "Bug has been fixed !";
});

app.Run();
