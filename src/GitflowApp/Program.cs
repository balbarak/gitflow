var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    // done bro !
    return "Bug has been fixed !";
});

app.Run();
