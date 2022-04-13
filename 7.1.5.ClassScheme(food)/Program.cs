using System;

namespace _7._1._5.ClassScheme_food_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //    Задание 7.1.5
    //Для следующего списка объектов создайте схему классов(объявите нужные классы и установите связи между ними) :
    class Food { }
    class Vegetables : Food { }
    class Fruit : Food { }
    class Apple : Fruit { }
    class Banana : Fruit { }
    class Pear : Fruit { }
    class Potato : Vegetables { }
    class Carrot : Vegetables { }

    //    Задание 7.1.6
    //Реализуйте конструктор, заполняющий поля для следующего класса:
    class Obj 
    {

        private string name;
        private string owner;
        private int length;
        private int count;

        // ниже идёт конструктор заполняющий поля класса
        public Obj(string name, string ownerName, int objLength, int count)
        {
                this.name = name; // this используется для указания на переменную name класса Obj (используется в случае если название параметра конструктора совпадают с переменной класса)
                owner = ownerName;
                length = objLength;
                this.count = count;
        }
    }
    //        Задание 7.1.10
    //Для класса DerivedClass создайте 2 конструктора: один, принимающий 2 параметра — name и description, второй — принимающий 3 параметра name, description и counter.

    //Старайтесь написать оптимальный вариант с учетом полученных знаний.
    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        public DerivedClass(string name, string description):base(name)
        {
            Description = description;
        }
        public DerivedClass(string name, string description, int counter):base(name)
        {
            Description = description;
            Counter = counter;
        }
    }

}
