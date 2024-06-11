WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.Run((context) =>
{
	context.Request.ContentType = "text/html";
	return context.Response.WriteAsync("<h1>Hello World</h1>");
});

app.Run();
