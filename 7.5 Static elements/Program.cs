using System;

namespace _7._5_Static_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 58;
            Helper.Swap(ref num1, ref num2); // передача переменной внутрь метода Helper.Swap для того, чтобы этот метод поменял значения передаваемых переменных
            Console.WriteLine(num1);
            Console.WriteLine(num2);
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

}
