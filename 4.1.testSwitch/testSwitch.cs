using System;

namespace _4._1.testSwitch
{
    class testSwitch
    {
        static void Main(string[] args)
        {
            Console.Write("Введи на английском свой любимый цвет (со строчной буквы):");
            var color = Console.ReadLine();

            switch(color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine ("Ваш любимый цвет красный!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш любимый цвет зелёный!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш любимый цвет бирюзовый!");
                    break;                    
            }
        }
    }
}
