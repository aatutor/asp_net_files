using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace MyProject.Pages
{
 
	[IgnoreAntiforgeryToken]
	public class IndexModel : PageModel
	{
		[BindProperty]
		public Person? User { get; set; };
	}

	public record class Person(string Name, int Age);
}
