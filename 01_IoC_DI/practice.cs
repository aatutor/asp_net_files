using System;

namespace asp_ps_1_DI
{
    interface IFormatOut
    {
        void ShowPerson(Person p);
    }
    class Person
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public int age { get; private set; }
        // public IFormatOut format { private get; set; }

        public void ShowPerson()
        {
            Console.WriteLine(firstName + " " + lastName + " (" + age + ")");
            // format.ShowPerson(this);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person{ firstName="Ivan", lastName="Popov", age=32 };
            // user.format = new FormatOut();
            user.ShowPerson();

            // user.format = new FormatShort(); // change format
            user.ShowPerson(); 

            //Console.ReadKey();
        }
    }
}
