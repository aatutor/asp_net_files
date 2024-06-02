
class Person
{
	public string name;
	public int age;
	public Person(string name, int age)
	{
		this.name = name;
		this.age = age;
	}
}
interface IPersonViewer
{
	string Convert(Person person);
}
class PersonViewer: IPersonViewer
{
	public string Convert(Person person)
	{
		return person.name + " " + person.age;
	}
}
class PersonViewer2: IPersonViewer
{
	public string Convert(Person person)
	{
		return person.name + " (Age: " + person.age + ")";
	}
}
class CollectorPersones
{
	public List<Person> persones = new List<Person>();
	private IPersonViewer viewer = new PersonViewer2();

	public void ShowList()
	{
		for (int i = 0; i < persones.Count; i++)
		{
			Console.WriteLine(viewer.Convert(persones[i]));
		}
	}
}

internal class Program
{
	private static void Main(string[] args)
	{
		CollectorPersones state = new CollectorPersones();
		state.persones.Add(new Person("Ivan", 32));
		state.persones.Add(new Person("Petr", 22));
		state.persones.Add(new Person("Semen", 28));
		state.ShowList();
	}
}