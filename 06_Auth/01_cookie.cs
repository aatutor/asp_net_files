#define DEF

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyProject.Pages
{
	public class IndexModel : PageModel
	{
		public string Res { get; set; } = "";
		public void OnGet(string? name)
		{
#if DEF
			Res = $"Name: {name}";
#else
			var cookie = Request.Cookies;
			string sID;
			if (!cookie.ContainsKey("SID"))
			{
				sID = (new Random()).Next(10, 99).ToString();
				Response.Cookies.Append("SID", sID);
			}
			else
			{
				sID = cookie["SID"];
			}

			if (name != null)
			{
				Response.Cookies.Append("name", name);
			}
			else
			{
				name = cookie["name"] ?? "no name";
			}
			Res = $"SID: {sID}; Name: {name}";
#endif
		}
	}
}
