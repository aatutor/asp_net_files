using MyProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyProject.Pages
{
	public class StarModel : PageModel
	{
		public Student? Star;
		public IActionResult OnGet()
		{
			Star = Student.GetByUID(Request.Cookies["UID"]);

			if (Star == null || Star.IsStar == false)
			{
				return Content("<h2>Чтобы увидеть список студентов, войдите как «Староста»</h2>");
			}
			return Page();
		}
	}
}
