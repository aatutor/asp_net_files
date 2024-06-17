using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace MyProject.Pages
{
	public class IndexModel : PageModel
	{
		public int Id { get; private set; }
 
		public void OnGet(int id)
		{
			Id = id;
		}
	}
}