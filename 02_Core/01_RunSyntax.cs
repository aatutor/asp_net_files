WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

#if 0

app.Run( (context) => 
	context.Response.WriteAsync("Context!!!")					
);

#elif 1

app.Run( (context) => {
	return context.Response.WriteAsync("Context!!!");	
});

#elif 2

app.Run(async (context) => 
	await context.Response.WriteAsync("Context!!!")		
);

#endif

app.Run();
