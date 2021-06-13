using System;

namespace _5._1.methodCall
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] favcolors;
            favcolors = new string[3];
            for (int i=0; i < 3; i++)
            {
                favcolors[i] = ShowColor();
                Console.WriteLine("Принято");
            }
            Console.WriteLine("\nСписок ваших любимых цветов:");
            foreach (var item in favcolors)
            { 
                Console.Write($"{item} ");
            }
            ClickToProceed();
        }
        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском маленькими буквами: ");
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
