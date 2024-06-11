/*
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8" />
	<title>METANIT.COM</title>
</head>
<body>
	<h2>Hello ASP.NET Core!</h2>
</body>
</html>
*/

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

#if 0
app.Run(async(context) => 
{
	context.Response.ContentType = "text/html; charset=utf-8";
	await context.Response.SendFileAsync("index.html");
});
#endif

app.Map("/date", (appBuild) => {
	appBuild.Run(context =>
		context.Response.WriteAsync(
				$"Date: {DateTime.Now.ToShortDateString()}")
	);
});

app.Run( (context) =>
{
	var path = context.Request.Path;

	if (path == "/") {
		path = "/index";
	}
	// "/about" => "/html/about.html
	string target = $"/html{path}.html";

	Console.WriteLine(Path.GetFullPath(target));

	if (File.Exists(target)) {
		context.Response.ContentType = "text/html; charset=utf-8";
		return context.Response.SendFileAsync(target);
	}
	context.Response.StatusCode = 404;
	return context.Response.WriteAsync("404: Error URL");
});


app.Run();