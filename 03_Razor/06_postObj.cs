using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace MyProject.Pages
{
	[IgnoreAntiforgeryToken]
	public class IndexModel : PageModel
	{
		public string Message { get; private set; } = "";
		public void OnGet() {
			Message = "Введите свои данные";
		}
	#if !DEF1
		public void OnPost(string name, int age) {
			Message = $"Ваше имя: {name}. Ваш возраст: {age}";
		}
	#else
		public void OnGet(Person person) {
			Message = $"Person  {person.Name} ({person.Age})";
		}
	#endif
	}
#if DEF1
	public record class Person(string Name, int Age);
#endif
}