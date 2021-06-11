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
            // Задание 4.3.16. Необходимо найти количество положительных элементов массива.

            int[,] array = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } }; // 2-мерный массив для сортировки

            Console.Write("Сумма всех положительных элементов массива (цикл foreach): "); 
            var sum1 = 0;
            foreach (var num in array) // считаем сумму всех положительных элементов массива
            {
                if (num > 0)
                {
                    sum1 += num;
                }
            }
            Console.WriteLine(sum1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нажмите, чтобы продолжить\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

            Console.WriteLine("Сумма всех положительных элементов массива (цикл for)");
            
            for (int i=0; i < array.GetUpperBound(0)+1; i++) // считаем сумму всех положительных элементов для каждой строки массива
            {
                sum1 = 0;
                for (int k=0; k < array.GetUpperBound(1)+1; k++)
                {
                    if (array[i,k] > 0)
                    {
                        sum1 += array[i, k];
                    }
                }
                Console.WriteLine("Строка {0}: {1}", i+1, sum1);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нажмите, чтобы продолжить\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

            // Задание 4.3.17. Сортировка элементов массива внутри одной строки.
            Console.WriteLine("Сортировка массива построчно");

            int firstChar; // переменная для хранения замещаемого значения
                        
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++) // цикл входа в строку
            {
                Console.WriteLine("Строка {0}: ", i+1);

                for (int k = 0; k < array.GetUpperBound(1) + 1; k++) // цикл сортировки элементов в строке по возрастанию
                {
                    for (int t = k + 1; t < array.GetUpperBound(1) + 1; t++)
                    {
                        if (array[i, k] > array[i, t])
                        {
                            firstChar = array[i, k];
                            array[i, k] = array[i, t];
                            array[i, t] = firstChar;
                        }
                    }
                    Console.Write($"{array[i, k]} ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нажмите, чтобы продолжить\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
