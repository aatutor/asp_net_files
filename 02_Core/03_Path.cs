var builder = WebApplication.CreateBuilder();
var app = builder.Build();
 

app.Run( (context) => 
	context.Response.WriteAsync(
			$"Path: {context.Request.Path}")
);


app.Run();