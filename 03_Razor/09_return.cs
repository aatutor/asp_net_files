using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace RazorPagesApp.Pages
{
	public class IndexModel : PageModel
	{
		public IActionResult OnGet()
		{
			return Page();
			return Content("Hello World!");
			return File("img.jpg", "image/jpeg");	// https://metanit.com/sharp/razorpages/2.11.php
			return Redirect("https://yandex.ru");	// https://metanit.com/sharp/razorpages/2.13.php
			return StatusCode(404);	// https://metanit.com/sharp/razorpages/2.12.php
		}
	}
}