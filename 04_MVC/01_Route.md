
1. `Controllers/HomeController.cs`:
	``` csharp
	using Microsoft.AspNetCore.Mvc;

	namespace MyProject.Controllers
	{
		public class HomeController : Controller
		{
			public IActionResult Index()
			{
				return View();
			}
		}
	}
	```

2. `Program.cs`:
	``` csharp
	var builder = WebApplication.CreateBuilder(args);

	builder.Services.AddControllers(); 

	var app = builder.Build();

	app.MapControllersRoute(
		name: "default",
		pattern: "{controller=Home}/{action=Index}"
	);

	app.Run();
	```

3. GET: `/` == `/Home/Index`