using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// 1. добавить Razor
// 2. выводить @Model.Result

namespace asp_auth.Pages
{
	public class IndexModel : PageModel
	{
		public string Result { get; set; } = "";
		public void OnGet(string? name)
		{ /// localhost:1111/?name=Ivan
			//Result = $"Имя: {(name != null ? name : "no name")}";
			//Result = $"Имя: {name}";

			string storedName;

			var cookie = HttpContext.Request.Cookies;
			if (name == null) {
				storedName = cookie["name"] ?? "no name";
			}
			else {
				storedName = name;
				//cookie["name"] = storedName;
				HttpContext.Response.Cookies.Append("name", storedName);
			}
#if ERR
			if (name != null) {
				HttpContext.Response.Cookies.Append("name", name);
			}
			storedName = HttpContext.Request.Cookies["name"] ?? "no name";
#endif
			Result = $"Имя: {storedName}";
		}
	}
}
