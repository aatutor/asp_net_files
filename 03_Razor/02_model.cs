// https://metanit.com/sharp/razorpages/2.3.php

using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace MyProject.Pages
{
	public class IndexModel : PageModel
	{
		public string Message { get; } = "Message in object";
		public string GetTime() => DateTime.Now.ToShortTimeString();
	}
}
