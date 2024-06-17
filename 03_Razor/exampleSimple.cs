using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyProject.Pages
{
    public class IndexModel : PageModel
    {
        public List<Person> List { get; private set; } = new List<Person>
        {
            new Person("Ivan", 15),
            new Person("Petr", 35)
        };
        public Person User { get; private set; }
        public void OnGet(int id)
        {
            if (id != -1)
            {
                User = this.List[id];
            }
        }
    }
    public record class Person(string Name, int Age);
}
