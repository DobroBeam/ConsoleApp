using System;

namespace _4._4.tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string surname, int age) anketa;
            Console.Write("Введите ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            anketa.surname = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ваше имя: {0}\nВаша фамилия: {1}\nВаш возраст: {2}", anketa.name, anketa.surname, anketa.age);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нажмите, чтобы продолжить\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
