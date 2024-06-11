// using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/* index.html:
<form method="post" action="postuser">
  <p>Name: <input name="name" /></p>
  <p>Age: <input name="age" type="number" /></p>
  <input type="submit" value="Send" />
</form>
*/

app.Map("/postuser", (appBuilder) =>
{
	appBuilder.Run( (context) => {
		var form = context.Request.Form;
		
		string name = form["name"];
		string age = form["age"];

		context.Response.ContentType = "text/html; charset=utf-8";
		return context.Response.WriteAsync(
				$"<div><p>Name: {name}</p><p>Age: {age}</p></div>");
	});
});


app.Run(async (context) =>
{
	var path = context.Request.Path;
	var fullPath = $"html/{path}.html";
	var response = context.Response;

	response.ContentType = "text/html; charset=utf-8";
	if (File.Exists(fullPath))
	{
		await response.SendFileAsync(fullPath);
	}
	else
	{
		response.StatusCode = 404;
		await response.WriteAsync("<h2>Not Found</h2>");
	}
});

app.Run();
