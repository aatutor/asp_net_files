
var builder = WebApplication.CreateBuilder(args);

// поддержка контроллеров с представлениями
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles(); // доступ к картинкам

// установка маршрутов с контроллерами
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=main}/{action=index}"
);

app.Run();

