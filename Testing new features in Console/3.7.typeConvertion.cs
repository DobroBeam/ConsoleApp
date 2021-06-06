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
            //Parse работает по принципу Convert и так же, выдает ошибки если ввести данные некорректно
            Console.Write("Enter your age: ");
            int age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is {0} ", age2);
            Console.ReadKey();

            //TryParse возвращает булевское значение в зависимости от того, было ли преобразование удачным. После этого его можно обработать. Программа не выдас ошибку
            Console.Write("Enter your age: ");
            int age3;
            bool iscorrect = int.TryParse(Console.ReadLine(), out age3); //out age3 - записывает возвращаемое методом TryParse значение в int переменную age3 
            Console.WriteLine("Your age is {0} ", age3);
            Console.ReadKey();

            //Диалог 1 (для возраста используем тип int)
            Console.WriteLine("Console dialog #1");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and you are {1} years old", name, age4);
            Console.ReadKey();

            //Диалог 2 (для возраста используем тип byte)
            Console.WriteLine("Console dialog #2");
            Console.Write("Enter your name: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter your age: ");
            // можно использовать эту строку, byte age5 = byte.Parse(Console.ReadLine());
            // однако если пользователь введёт значение больше 255, приложение выдаст ошибку, поэтому лучше использовать конверсию int в byte
            byte age5 = (byte)int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and you are {1} years old", name1, age5);
            Console.ReadKey();
            // при вводе значения больше 255 в byte будет записан 0 и данные потеряются. Если нас это не устраивает, то можно воспользоваться служебным словом Checked

            // *Checked - помогает проверить, возможно ли преобразование без потери данных.
            //Диалог 3 (для возраста используем тип byte, проверяем не потерялись ли данные)
            Console.WriteLine("Console dialog #2");
            Console.Write("Enter your name: ");
            string name2 = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age6 = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and you are {1} years old", name2, age6);
        }
    }
}