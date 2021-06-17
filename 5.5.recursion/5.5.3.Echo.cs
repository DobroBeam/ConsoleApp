using System;

namespace _5._5.recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Скажите что-нибудь... ");
            string iSaid = Console.ReadLine();
            Console.WriteLine("Глубина эхо: ");
            int echoDepth = int.Parse(Console.ReadLine());
            Echo(iSaid, echoDepth);        
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
    }
}
