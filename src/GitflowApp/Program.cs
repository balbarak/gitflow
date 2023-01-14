var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    return "Bug has been fixed !";
    //we
});

app.Run();
