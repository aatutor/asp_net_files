[METANIT](https://metanit.com/sharp/razorpages/3.1.php)

1. Добавить в проект `/Pages/Shared/_Layout.cshtml` (шаблон "Razor Layout").

2. Изменить `_Layout.cshtml`:
``` html
<!DOCTYPE html>
<html>
<head>
	<meta name="viewport" content="width=device-width" />
	<title>RAZOR | @ViewBag.Title</title>
</head>
<body>
	<h2>Page: @ViewBag.Title</h2>
	<div><a href="/">Home</a> | <a href="About">About</a></div>
	<div>
		@RenderBody()
	</div>
</body>
</html>
```

3. Изменить `Index.cshtml`:
``` cs
@page
 
@{
	ViewBag.Title = "Index";
	Layout = "/Pages/Shared/_Layout.cshtml";
}

<h3>Главная страничка</h3>
```

4. Изменить `About.cshtml`:
``` cs
@page

@{
	ViewBag.Title = "About";
}

<h3>Сайт построен на Razor</h3>
```

5. Добавить `Pages/_ViewStart.cshtml`:
``` cs
@{
	Layout = "_Layout";
}
```
