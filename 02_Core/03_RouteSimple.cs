var builder = WebApplication.CreateBuilder();
var app = builder.Build();

 
app.Run( async (context) => 
{
	var path = context.Request.Path;
	var now = DateTime.Now;
	string result = "";

	if ( path == "/date")
		result = $"Date: {now.ToShortDateString()}";
	else if (path == "/time")
		result = $"Time: {now.ToShortTimeString()}";
	else
		result = "go to <u>/date</u> or <u>/time</u> page";
	await context.Response.WriteAsync(result);
});


app.Run();