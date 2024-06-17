using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyProject.Pages
{
	public class IndexModel : PageModel
	{
		public string Message { get; private set; } = "";
#if !DEF
		// .../?name=Ivan
		public void OnGet(string name)
		{
			Message = $"Name: {name}";
		}
#else
		// .../?id=18
		public void OnGet(int id)
		{
			Message = $"Id: {id}";
		}
#endif
	}
}