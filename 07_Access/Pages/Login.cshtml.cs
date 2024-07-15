using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyProject.Models;

namespace MyProject.Pages
{
	[IgnoreAntiforgeryToken]
	public class LoginModel : PageModel
	{
		public void OnGet() 
		{
			string? uID = Request.Cookies["UID"];
			if (uID != null)
			{
				Response.Cookies.Delete(uID);
			}
		}
		public IActionResult OnPost(string login, string pass)
		{
			Student? st = Student.All.Find(s => s.Login == login);
			if (st != null && st.Pass == pass)
			{
				Response.Cookies.Append("UID", st.Id.ToString());
			}
			return RedirectToPage("index");
		}
	}
}
