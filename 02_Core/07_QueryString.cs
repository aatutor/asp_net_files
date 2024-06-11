var builder = WebApplication.CreateBuilder();
var app = builder.Build();

#if 0
app.Run( async (context) => 
{
	context.Response.ContentType = "text/html; charset=utf-8";
	await context.Response.WriteAsync(
		$"<p>Path: {context.Request.Path}</p>" +
		$"<p>QueryString: {context.Request.QueryString}</p>");
});

#else

app.Run( async (context) =>
{
	string name = context.Request.Query["name"];
	string age = context.Request.Query["age"];
	await context.Response.WriteAsync($"{name} - {age}");
});
#endif

//:	.../users?name=Tom&age=37
//:	.../users?name=Tom&age=37&name=Petr&age=23


#if 0
app.Run( async (context) => 
{
	context.Response.ContentType = "text/html; charset=utf-8";
	var stringBuilder = new System.Text.StringBuilder("<h3>Параметры строки запроса</h3><table>");
	stringBuilder.Append("<tr><td>Параметр</td><td>Значение</td></tr>");
	foreach (var param in context.Request.Query)
	{
		stringBuilder.Append($"<tr><td>{param.Key}</td><td>{param.Value}</td></tr>");
	}
	stringBuilder.Append("</table>");
	await context.Response.WriteAsync(stringBuilder.ToString());
});
#endif
 
app.Run();