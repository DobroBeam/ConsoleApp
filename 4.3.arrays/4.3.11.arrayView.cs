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
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Раскладываем 2-мерный массив по столбцам:");
            //раскладываем массив по столбцам
            for (int i=0; i < array.GetUpperBound(1)+1; i++)
            {
                for (int k=0; k < array.GetUpperBound(0)+1; k++)
                {
                    Console.Write(array[k, i] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Раскладываем 2-мерный массив по строкам:");
            //раскладываем массив по строкам
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                {
                    Console.Write(array[i, k] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
