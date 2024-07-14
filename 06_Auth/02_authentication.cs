using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyProject.Models;

// 1. добавить Razor
// 2. выводить @Model.Result
// 3. добавить Model.Sudent.All - List<Student>

namespace MyProject.Pages
{
	public class IndexModel : PageModel
	{
		public string Result { get; set; } = "";
		public void OnGet(int? id)
		{ /// localhost:1111/?id=15
			var cookie = HttpContext.Request.Cookies;

			if (id != null) {
				HttpContext.Response.Cookies.Append("ID", id.ToString());
			}
			else if (cookie.ContainsKey("ID")) {
				id = int.Parse(cookie["ID"]);
			}

			Student? st = null;

			foreach (var s in Student.All) {
				if (s.Id == id) {
					st = s;
				}
			}

			Result = $"Имя: {(st!=null ? st.Name : "no name")}";
		}
	}
}
