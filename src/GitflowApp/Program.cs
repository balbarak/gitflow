var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    //fix bug ! twooo
    //another bug !
    //bug twoo !
    //Oky
    //well done bro !
    return "Bug has been fixed !";
});

app.Run();
