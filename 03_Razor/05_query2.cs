using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyProject.Pages
{
	public class IndexModel : PageModel
	{
		public string Message { get; private set; } = "";

		// .../?name=Ivan&age=18
#if !DEF1
		public void OnGet(string name, int age) {
			Message = $"Name: {name}, Id: {age}";
		}
#elif !DEF2
		public void OnGet(string name = "Ivan", int age = 18)
		{
			Message = $"Name: {name}, Id: {age}";
		}
#elif !DEF3
		public void OnGet(Person person)
		{
			Message = $"Person: {person.Name} ({person.Age})";
		}
#else
		public void OnGet()
		{
			string name = Request.Query["name"];
			string age = Request.Query["age"];
			Message = $"Name: {name}  Age: {age}";
		}
#endif
	}
	public record class Person(string Name, int Age);
}