using System;

namespace _7._5_Static_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 58;
            Helper.Swap(ref num1, ref num2); // передача переменной внутрь статического метода Helper.Swap для того, чтобы этот метод поменял значения передаваемых переменных
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            string str = "Hello";
            Console.WriteLine(str.GetLastChar());
            Console.WriteLine("privet".GetLastChar());

            int num3 = 7;
            int num4 = -13;
            int num5 = 0;

            Console.WriteLine(num3.GetNegative()); //-7
            Console.WriteLine(num3.GetPositive()); //7
            Console.WriteLine(num4.GetNegative()); //-13
            Console.WriteLine(num4.GetPositive()); //13
            Console.WriteLine(num5.GetNegative()); //0
            Console.WriteLine(num5.GetPositive()); //0

        }
    }

    //  Задание 7.5.2
    //  Создайте класс Obj, определите в нем поля Name, Description(тип строки) и статическое поле MaxValue типа int, равное 2000.

    class Obj
    {
        public string Name;
        public string Description;
        public static int MaxValue = 2000;
    }

    //  Задание 7.5.3
    //  Создайте класс Helper и определите в нем статический метод Swap типа void, который принимает 2 переменные типа int и меняет их значения местами.

    class Helper
    {
        public static void Swap(ref int n1, ref int n2) // с помощью ref, в данный метод, осуществляется передача ссылок на переменные
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }

    //  Задание 7.5.5
    //  Измените класс Obj так, чтобы статические поля инициализировались в статическом конструкторе:

    class Obj2
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;
        
        static Obj2()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }

    static class StringExtensions
    {
        public static char GetLastChar(this string source)
        {
            return source[source.Length - 1];
        }
        public static bool ContainsExtansion (this string source)
        {
            
                Console.WriteLine("Вызван метод расширения Contains");
                return true;
            
        }
    }

    //  Задание 7.5.9
    //  Для класса int создайте 2 метода расширения: GetNegative() и GetPositive().
    //  Метод GetNegative должен возвращать отрицательное значение переменной(если оно положительно), либо саму переменную(если оно отрицательно или равно 0).
    //  Метод GetPositive должен, наоборот, возвращать положительное значение(если оно отрицательно), либо саму переменную(если оно положительно или равно 0).
    static class IntExtensions
    {
        public static int GetNegative(this int source)
        {
            if (source > 0)
            {
                return -source;
            }
            return source; 
        }
        public static int GetPositive(this int source)
        {
            if (source < 0)
            {
                return -source;
            }
            return source;
        }
    }
    
}
