var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    //well
    return "Bug has been fixed !";

    
});

app.Run();
