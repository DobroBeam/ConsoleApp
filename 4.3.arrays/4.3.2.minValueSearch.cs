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
            var numbers = new int[] { 4, 2, 0, 10, 22 }; 
            int minValue = 100000, //переменная для хранения текущего минимального значения (изначально, для последующего сравнения, берем очень большое число)
            minIndex = -1; // переменная для хранения индекса (адреса в массиве) минимального значения 

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue) // если текущий элемент массива меньше предыдущего минимального значения
                {
                    minValue = numbers[i];
                    minIndex = i;
                }
            }
            Console.WriteLine("Наименьший элемент массива = {0} и имеет индекс {1}", minValue, minIndex);
        }
    }
}
