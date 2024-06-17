using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace MyProject.Pages
{
	[IgnoreAntiforgeryToken]
	public class IndexModel : PageModel
	{
		public string Message { get; private set; } = "";
		public void OnGet()
		{
			Message = "Введите свое имя";
		}
		public void OnPost(string username)
		{
			Message = $"Ваше имя: {username}";
		}
	}
}
