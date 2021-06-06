using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string MyName = "Dmitry";
            //byte MyAge = 27;
            //bool DoIHaveAPet = false;
            // float MyShoeSize = 41;
            // Console.WriteLine($"My name is {MyName}\nI am {MyAge}\nDo I have a pet? {DoIHaveAPet}\nMy shoe size is {MyShoeSize}");
            // Console.WriteLine($"Byte max value {byte.MaxValue} \nByte min value {byte.MinValue}");
            // Console.WriteLine($"Long max value {long.MaxValue} \nLong min value {long.MinValue}");
            // Console.WriteLine($"Ushort max value {ushort.MaxValue} \nUshort min value {ushort.MinValue}");
            //Console.ReadKey();

            Console.Write("Ваш любимый цвет: ");
            var favColor = Console.ReadLine();
            if (favColor == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ваш любимый цвет красный");
            }
            else if (favColor == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ваш любимый цвет зелёный");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Ваш любимый цвет бирюзовый");
            }
            Console.ReadKey();
        }
    }   
}
