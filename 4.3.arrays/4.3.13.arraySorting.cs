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
            // Задание 4.3.13. Сортировка по возрастанию двумерного массива

            var array = new int[] { 2,3,1,9,0,5,8,8,8,11,101,99 }; // 2-мерный массив для сортировки
            int minValue = int.MaxValue; // переменная для хранения текущего минимального значения при обходе массива
            var minIndex = array.Length + 1; // переменная для хранения индекса минимального значения
            var firstChar = array[0]; // переменная для хранения замещаемого значения
            var sum = 0; // переменная хранения суммы

            Console.WriteLine("Отсортированный массив:");

            for (int k = 0; k < array.Length; k++) // обход массива и обмен значений k-го элемента и элемента с минимальным значением
            {
                    for (int i = k; i < array.Length; i++) //ищем индекс минимального значения в массиве
                    {
                        if (array[i] < minValue)
                        {
                            minValue = array[i];
                            minIndex = i;
                        }
                    }
                firstChar = array[k]; // cохраняем значение замещаемого элемента в firstChar
                array[k] = array[minIndex]; // сохраняем в замещаемый элемент минимальное значение
                array[minIndex] = firstChar; // сохраняем значение замещенного элемента в элемент с минимальным значением
                minValue = int.MaxValue; // сбрасываем текущее минимальное значение на исходное

                Console.Write(array[k] + " "); // вывод элемента с минимальным значением
            }

            // Задание 4.3.13. нахождение суммы всех элементов массива

            for (int t=0; t < array.Length; t++)
            {
                sum += array[t];
            }
            Console.Write("\n Cумма всех элементов массива: {0}", sum);
            Console.ReadKey();
        }
    }
}
