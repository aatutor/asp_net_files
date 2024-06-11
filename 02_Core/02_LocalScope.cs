var builder = WebApplication.CreateBuilder();
var app = builder.Build();


int x = 1;
app.Run(async (context) =>
{
    x = x + 1;
    await context.Response.WriteAsync($"Counter: {x}");
});


app.Run();