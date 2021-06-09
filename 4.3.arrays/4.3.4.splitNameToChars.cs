using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3.arrays
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();
            int nameLength = name.Length;
            Console.Write("Ваше имя по буквам: ");

            foreach (char symbol in name)
            {
                Console.Write("{0} ", symbol);
            }


            for (int i=0; i != name.Length+1; i++)
            {
                if (i == name.Length)
                {
                    Console.WriteLine("\nПоследняя буква имени: {0}", name[i - 1]);
                }
            }


        }
    }
}
