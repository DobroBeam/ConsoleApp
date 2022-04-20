using System;

namespace _7._6._Generic_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Obj obj = new Obj(); //создаем объект типа Obj
            obj.Display<int>(345); //передаем в метод Display значение 345, которое методу нужно воспринять как значение типа Int
            int num1 = 4;
            int num2 = 10;
            Swap<int>(ref num1, ref num2); // вызываем метод Swap передаем ему тип данных с которым ему надо работать и передаем по ссылке 2 параметра
            Console.WriteLine($"{num1}, {num2}");
            Console.ReadKey();

        }
        public static void Swap<T>(ref T x, ref T y) // создаем универсальный метод Swap (на универсальность указывает <T> после названия), который принимает 2 параметра типа данных T по ссылке
        {
            T t=x; // создаем переменную t типа T (переданного в метод) и присваиваем ей значение x
            x=y;
            y=t;
        }

    }
    // Задание 7.6.2
    // Создайте класс-обобщение Car для автомобиля.Универсальным параметром будет тип двигателя в автомобиле (электрический и бензиновый).
    // Для типов двигателей также создайте классы — ElectricEngine и GasEngine.
    // В классе Car создайте поле Engine в качестве типа которому укажите универсальный параметр.

    //  Задание 7.6.7
    //  Добавьте к схеме классов автомобиля следующие классы частей автомобиля: Battery, Differential, Wheel.
    //  Также добавьте в класс Car виртуальный обобщённый метод без реализации — ChangePart,
    //  который будет принимать один параметр — newPart универсального типа.
    class Car<T1>
    {
        public T1 Engine;
        public virtual void ChangePart<T2>(T2 newPart)
        {
        
        }
    }
    class ElectricEngine { }
    class GasEngine { }
    class Battery { }
    class Differential { }
    class Wheel { }

//  Задание 7.6.6
//  Реализуйте класс-обобщение Record, у которого будут два универсальных параметра:
//  один — для идентификатора записи(Id), другой — для значения записи(Value). Также в классе реализуйте поле Date типа DateTime.
    class Record<T1,T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }
    class Obj
    {
        public void Display<T>(T param)
        {
            Console.WriteLine(param.ToString());
        }
    }
}