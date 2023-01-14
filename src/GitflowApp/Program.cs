var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    //fix bug ! twooo
    //another bug !
    return "Bug has been fixed !";
});

app.Run();
