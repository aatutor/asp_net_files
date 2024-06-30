using Microsoft.AspNetCore.Mvc;
using MyProject.Models;

namespace MyProject.Controllers
{
	public class Main : Controller
	{
		List<Picture> pictures = new List<Picture>
		{
			new Picture("01.webp", "red man"),
			new Picture("02.jpg", "two robo faces in one"),
			new Picture("03.jpg", "cat art")
		};
		public IActionResult Index() { return View(); }
		public IActionResult Profile()
		{
			return View(pictures);
		}

	}
}
