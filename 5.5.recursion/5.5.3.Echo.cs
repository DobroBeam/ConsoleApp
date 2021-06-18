using System;

namespace _5._5.recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Скажите что-нибудь... ");
            //string iSaid = Console.ReadLine();
            //Console.WriteLine("Глубина эхо: ");
            //int echoDepth = int.Parse(Console.ReadLine());
            //Echo(iSaid, echoDepth);        

            // Задание 5.5.5. Расчет факториала
            Console.Write("Введите число для расчета факториала: ");
            decimal num = factorial(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Факториал вашего числа {num}");

            Console.ReadKey();
        }
        static void Echo (string saidWord, int deep)
        {                     
            string modif = saidWord;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
                
            }
            Console.BackgroundColor = (ConsoleColor)deep; // приводим значение глубины deep к типу перечисления ConsoleColor
            Console.WriteLine("... " + modif);
            if (deep > 0)
            {
                Echo(modif, deep - 1);
            }
            
        }
        static decimal factorial (int x) // 5.5.5. расчет факториала входящего параметра
        {
            if (x==0)
            {
                return 1;
            }
            else
            {
                return x * factorial(x - 1);
            }
        }
    }
}
