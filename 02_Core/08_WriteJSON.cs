var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run( (context) =>
{
	Person tom = new("Tom", 22);
	return context.Response.WriteAsJsonAsync(tom);
});

app.Run();

public record Person(string Name, int Age); // like a class
