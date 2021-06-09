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
            Console.Write("В обратном порядке: ");

            for (var i=name.Length; i > 0; i--)
            {
               {
                    Console.Write(name[i - 1]);
               }
            }
            Console.ReadKey();


        }
    }
}
