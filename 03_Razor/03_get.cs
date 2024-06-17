// https://metanit.com/sharp/razorpages/2.4.php

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace MyProject.Pages
{
	public class IndexModel : PageModel
	{
		public string Message { get; private set; } = "";
		public void OnGet()
		{
			Message = "Razor Pages on METANIT.COM";
		}
	}
}
