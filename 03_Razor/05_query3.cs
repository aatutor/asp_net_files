using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyProject.Pages
{
	public class IndexModel : PageModel
	{
		public string Message { get; private set; } = "";
#if !DEF1
		public void OnGet(string[] names) {
			Message = string.Join(", ", names); // ?
		}
		// .../?names=Ivan&names=Petr&names=Semen
		// .../?names[0]=Ivan&names[1]=Petr&names[2]=Semen
		// .../?[0]=Ivan&[1]=Petr&[2]=Semen
#elif !DEF2
		public void OnGet(Person[] people)
		{
			Message = "";
			foreach (var person in people)
			{
				Message += $"{person.Name}; ";
			}
		}
		// .../?[0].name=Ivan&[0].age=18&[1].name=Petr&[1].age=23
#else
		public void OnGet(Dictionary<string, string> items)
		{
			Message = "";
			foreach (var item in items)
			{
				Message += $"{item.Key} - {item.Value}; ";
			}
		}
		// .../?items[germany]=berlin&[france]=paris&[spain]=madrid
#endif
	}
	public record class Person(string Name, int Age);
}