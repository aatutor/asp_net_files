using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace RazorPagesApp.Pages
{
	public class IndexModel : PageModel
	{
		public void OnGet()
		{
			ViewData["Message"] = "Razor Pages text";
			ViewData["People"] = new List<string> { "Tom", "Sam", "Bob" };
		}
	}
}