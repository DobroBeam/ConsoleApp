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
            byte data1 = (byte)olddata;
            Console.WriteLine($"Конверсия int в byte data1 = {data1}");
            // это называется "приведение типов"
            Console.ReadKey();

            //Преобразования в string
            // для пробразования в строковый тип, у каждого объекта C#, существует специальный метод ToString()
            olddata = 6;
            string data2 = olddata.ToString();
            Console.WriteLine($"конверсия int в строку: data2 (преобразованная в строку из int) = {data2}");
            Console.WriteLine($"oldata осталось типом int = {olddata}");
            Console.ReadKey();

            //Преобразования из string (строка в значение)
            //на примере преобразования в int
            // * Метод Convert - позволяет конвертировать значения разных типов и на каждый имеется свой алгоритм
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is {0} ", age);
            Console.ReadKey();
            //Однако, такой способ выдаст ошибку если ввести с консоли текст "45 лет"

            //Кроме преобразования с помощью методов Convert, есть методы Parse и TryParse у системных типов данных.
            Console.Write("Enter your age: ");
            int age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is {0} ", age2);
            Console.ReadKey();
        }
    }
}