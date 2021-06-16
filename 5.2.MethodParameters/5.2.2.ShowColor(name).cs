using System;

namespace _5._2.MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            int age;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            ShowColor(name, surname);

            Console.WriteLine("Ваше имя: {0}\nВаша фамилия: {1}\nВаш возраст: {2}", name, surname, age);

            ClickToProceed();
        }

        static string ShowColor(string name, string surname)
        {
            
            Console.WriteLine("{0} {1},  напишите свой любимый цвет на английском маленькими буквами: ", name, surname);
            var color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is red!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is yellow!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is green!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is cyan!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            return color;
        }

        static void ClickToProceed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nНажмите, чтобы продолжить\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
