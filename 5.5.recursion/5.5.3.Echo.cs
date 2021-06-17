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
            Console.WriteLine(saidWord);
            string modif = saidWord;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
                Echo(modif, deep - 1);
            }
            
        }
    }
}
