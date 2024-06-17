using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace MyProject.Pages
{
 
	[IgnoreAntiforgeryToken]
	public class IndexModel : PageModel
	{
		[BindProperty(SupportsGet = true)]
		// [BindProperty(SupportsGet = true, Name = "anonimus")]
		public string? Name { get; set; }
	}
}
// .../?name=Ivan
