using System;

namespace _7._1._4.nasledovaniye
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Employee // родительский класс
    {
        public string Name;
        public int Age;
        public int Salary;
    }
    class ProjectManager:Employee // класс наследник
    { private string ProjectName; }
    class Developer : Employee // класс наследник
    { private string ProgrammingLanguage; }
}
