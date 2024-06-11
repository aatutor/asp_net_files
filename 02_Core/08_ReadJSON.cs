var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Map("/api/user", (bld) => { bld.Run( async (context) =>
{
	var message = "Некорректные данные";   // содержание сообщения по умолчанию
	try
	{	// пытаемся получить данные json
		var person = await context.Request.ReadFromJsonAsync<Person>();
		if (person != null) // если данные сконвертированы в Person
			message = $"Name: {person.Name}  Age: {person.Age}";
	}
	catch { }
	// отправляем пользователю данные
	await context.Response.WriteAsJsonAsync(new { text = message });
});});


app.Run(async (context) =>
{
	context.Response.ContentType = "text/html; charset=utf-8";
	await context.Response.SendFileAsync("html/index.html");
});


app.Run();

public record Person(string Name, int Age); // like a class
