Изменить `Program.cs`:

``` csharp
var builder = WebApplication.CreateBuilder(args);
 
// добавляем в приложение сервисы Razor Pages:
builder.Services.AddRazorPages();
 
var app = builder.Build();
 
// добавляем поддержку маршрутизации для Razor Pages:
app.MapRazorPages();  

app.Run();
```

Далее:
1. Добавить: `Pages/` (папка)
2. Добавить: `/Pages/Index.cshtml` (Razor Page - Empty):
``` html
@page

<h2>Основная страничка</h2>
```

3. Добавить: `/Pages/About.cshtml`:
``` html
@page

<h2>Сайт построен на Razor</h2>
```

