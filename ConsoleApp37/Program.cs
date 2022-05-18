using System;

namespace ConsoleApp37
{
    class Student
    {
        public Student(string FirstName, DateTime Birthday)
        {
            this.FirstName = FirstName;
            this.Birthday = Birthday;
        }

        public Student(string LastName, string MiddleName, string FirstName, DateTime Birthday) : this(FirstName, Birthday)
        {
            this.LastName = LastName;
            this.MiddleName = MiddleName;


        }
        public void Print()
        {
            Console.WriteLine($"1) Имя: {FirstName}, 2) Фамилия: {MiddleName}, 3) Дата рождения: {Birthday}, 4) Фамилия: {LastName}");
        }


        private string FirstName;
        private string LastName;
        private string MiddleName;
        private DateTime Birthday;

    }


    internal class Program
    {


        static void Main(string[] args)
        {
            Student student1 = new Student("Артем", "Романенко", "Романович", new DateTime(2000, 02, 12));
            student1.Print();
        }
    }
}
