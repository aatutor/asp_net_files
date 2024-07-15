using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyProject.Models;
using System.Security.Cryptography.X509Certificates;

namespace MyProject.Pages
{
	[IgnoreAntiforgeryToken]
	public class IndexModel : PageModel
	{
		public Student? Stud { get; set; }
		public IActionResult OnGet()
		{
			string? uID = Request.Cookies["UID"];
			if (uID == null)
				return RedirectToPage("login");

			Stud = Student.GetByUID(uID);

			return Page();
		}
	}
}
