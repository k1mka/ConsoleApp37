using System;

namespace ConsoleApp37
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

    }

    internal class Program
    {

        static Student GetStudent()
        {
            Student student = new Student();

            student.firstName = "Мартин";
            student.lastName = "Курилка";
            student.middleName = "Пупик";
            student.id = Guid.NewGuid();
            student.age = 10;
            student.group = "ЦУФ-113";

            return student;
        }
        static void Print(Student student)
        {
            Console.WriteLine("Информация о студенте!");
            Console.WriteLine();
            Console.WriteLine($"Имя: {student.firstName}");
            Console.WriteLine($"Отчество: {student.lastName}");
            Console.WriteLine($"Фамилия: {student.middleName}");
            Console.WriteLine($"Возраст: {student.age}");
            Console.WriteLine($"Группа: {student.group}");
        }

        static void Main(string[] args)
        {
            var firstStudent = GetStudent();

            Print(firstStudent);
        }
    }
}
