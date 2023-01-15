using Microsoft.AspNetCore.Hosting.Server.Features;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    return "Bug has been fixed !";
    //wesdfasdaf
    //SADSADF
    //asdfasdf
    //sadf
    //sdfs
    //sdfsadf
    //ok

    //ok !
});

app.Run();
