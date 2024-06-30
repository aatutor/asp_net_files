
Структура проекта:
- Models
	- `MyUser.cs`
- Pages
	- `Index.cshtml`
	- `Profile.cshtml`

---
`~/Models/MyUser.cs`:
``` csharp
namespace MyProject.Models
{
	public record class MyUser(string Name, int Age);

	public class MyGroup 
	{
		public static List<MyUser> All { get; set; } = new List<MyUser>();
	}
}
```

`~/Program.cs`:
``` csharp
using MyProject.Models;

MyGroup.All = new List<MyUser>
{
	new MyUser("Ivan", 15),
	new MyUser("Petr", 25)
};
/// ... далее стандартно
```

`~/Pages/Index.cshtml.cs`:
``` csharp
using Microsoft.AspNetCore.Mvc.RazorPages;

using MyProject.Models;

namespace MyProject.Pages { 
	public class IndexModel : PageModel {
		public List<MyUser> Users { get; set; } = MyGroup.All;
	}
}
```

`~/Pages/Index.cshtml`:
``` html
@page

@model MyProject.Pages.IndexModel

<h2>Список студентов:</h2>
<ol>
	@for (int i= 0; i < Model.Users.Count; i++) {
		<li><a href="./profile/@i">@Model.Users[i].Name</a></li>
	}
</ol>
```

`~/Pages/Profile.cshtml.cs`:
``` csharp
using Microsoft.AspNetCore.Mvc.RazorPages;

using MyProject.Models;

namespace MyProject.Pages {
	public class ProfileModel : PageModel {
		public MyUser Person { get; set; };

		public void OnGet(int id) {
			Person = MyGroup.All[id];
		}
	}
}
```

`~/Pages/Profile.cshtml`:
``` html
@page "{id}"

@model MyProject.Pages.ProfileModel

<h2>Студент:</h2>
<p><b>Имя:</b> @Model.Person.Name</p>
<p><b>Возраст:</b> @Model.Person.Age</p>
```

