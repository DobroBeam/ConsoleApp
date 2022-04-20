using System;

namespace _7._6._Generic_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
// Задание 7.6.2
// Создайте класс-обобщение Car для автомобиля.Универсальным параметром будет тип двигателя в автомобиле (электрический и бензиновый).
// Для типов двигателей также создайте классы — ElectricEngine и GasEngine.
// В классе Car создайте поле Engine в качестве типа которому укажите универсальный параметр.
    class Car<T>
    {
        public T Engine;
    }
    class ElectricEngine { }
    class GasEngine { }

//  Задание 7.6.6
//  Реализуйте класс-обобщение Record, у которого будут два универсальных параметра:
//  один — для идентификатора записи(Id), другой — для значения записи(Value). Также в классе реализуйте поле Date типа DateTime.
    class Record<T1,T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }
}