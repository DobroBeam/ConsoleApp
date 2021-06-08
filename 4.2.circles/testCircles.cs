using System;

namespace _4._2.circles
{
    class testCircles
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                else if (number < 0) 
                {
                    continue;
                }
                sum += number;
            }
            Console.WriteLine("Программа остановлена\nИтоговая сумма: {0}", sum);
        }
    }
}
