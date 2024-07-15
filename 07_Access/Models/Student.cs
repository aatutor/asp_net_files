using System.Net;

namespace MyProject.Models
{
	public class Student
	{
		public static List<Student> All { get; set; } = new List<Student>()
		{
			new Student(15, "Иван", "ivan2011", "IloveGAMES111"),
			new Student(20, "Петр", "petrrrr", "verySECUREpa$$", true)
		};
		public static Student? GetByUID(string? str)
		{
			if (str == null) 
				return null;

			int id = int.Parse(str);
			return Student.All.Find(s => s.Id == id);
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public string Login { get; set; }
		public string Pass { get; set; }
		public bool IsStar { get; set; }
		public Student(int id, string name, string login, string pass, bool isStar = false)
		{
			Id = id;
			Name = name;
			Login = login;
			Pass = pass;
			IsStar = isStar;
		}
	}
}
