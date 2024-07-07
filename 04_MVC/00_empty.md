
1. Создать стандартный пустой проект **ASP.NET Core**

2. Добавить в `Program.cs`:
	- подклюение сервисов MVC
		``` csharp
		builder.Services.AddControllersWithViews();` 
		```
	- установка сопоставления маршрутов с контроллерами
		``` csharp
		app.MapControllerRoute(
			name: "default",
			pattern: "{controller=Home}/{action=Index}/{id?}"
		);
		``` 

3. Добавить `Controllers/HomeController.cs`:
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

4. Добавить `View/Home/Index.cshtml`:
	``` html
	@{
			Layout = null;
	}
	<!doctype html>
	<html>
	<head>
			<title>First View</title>
			<meta charset="utf-8" />
	</head>
	<body>
			<h2>Страничка получена через контроллер</h2>
	</body>
	</html>
	```