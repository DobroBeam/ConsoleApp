using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main(string[] args)
        {
            //Преобразование типов данных друг в друга.
            //Есть "Явные" и "Неявные" преобразования
            //"Явное" или Explicit conversion
            //      Оно указывается следующим образом:
            //      (тип)переменная_другого типа
            //      Посмотрим на примере. Мы хотим превратить int в byte:
            int olddata = 6;
            byte data1 = (byte) olddata;
            Console.WriteLine(data1);
            // это называется "приведение типов"
            Console.ReadKey();

            //Преобразования в string
            // для пробразования в строковый тип, у каждого объекта C#, существует специальный метод ToString()
            olddata = 8;
            string data2 = olddata.ToString();
            Console.WriteLine(data2);
            Console.WriteLine(olddata);
            Console.ReadKey();




        }
    }
}