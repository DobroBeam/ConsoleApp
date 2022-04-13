using System;

namespace _7._2.Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //HybridCar hybridCar = new HybridCar(); // создаем экземпляр класса гибридкар
            //hybridCar.ChangeFuelType(FuelType.Electricity); // меняем тип топлива
            //hybridCar.Move(); // двигаемся
            //Console.WriteLine("Пробег: " + hybridCar.Mileage + " " + "Бензин: " + hybridCar.Gas + " " + "Аккумулятор: " + hybridCar.Electricity); // выводим в консоль данные по результату
            DerivedClass obj = new DerivedClass();
            obj.Display();
        }
        class Car
        {
            public int Mileage;

            public Car()
            {
                Mileage = 0;
            }

            public virtual void Move()
            {
                Console.WriteLine("Вызван метод Move класса Car");
                Mileage++;
            }
        }

        enum FuelType
        {
            Gas = 0,
            Electricity
        }

        class HybridCar : Car
        {
            public FuelType FuelType;

            public double Gas;

            public double Electricity;

            public HybridCar()
            {
                Electricity = 50;
                Gas = 50;
            }

            public override void Move()
            {
                Console.WriteLine("Вызван метод Move класса HybridCar");
                Mileage++;

                switch (FuelType)
                {
                    case FuelType.Gas:
                        Gas -= 0.5;
                        break;
                    case FuelType.Electricity:
                        Electricity -= 0.5;
                        break;
                }
            }

            public void ChangeFuelType(FuelType type)
            {
                FuelType = type;
            }
        }

        //7.2.3., 7.2.5.
        class BaseClass
        {
            public virtual int Counter
            {
                get;
                set;
            }
            public virtual void Display()
            { Console.WriteLine("Метод класса BaseClass"); }

        }
        class DerivedClass : BaseClass

        {
            private int counter;
            public override int Counter
            {
                get
                {
                    return counter;
                }
                set
                {
                    if (value < 0)
                    { Console.WriteLine("Значение не может быть меньше 0"); }
                    else { value = counter; }
                }
            }
            public override void Display()
            {
                base.Display();
                Console.WriteLine("Метод класса DerivedClass");
            }
        }

        class BaseClass2
        {
            public virtual int Counter
            {
                get;
                set;
            }
            public virtual void Display()
            {
                Console.WriteLine("\nМетод класса BaseClass2");
            }
        }

        //7.2.7

        class A
        {
            public virtual void Display()
            {
                Console.WriteLine("A");
            }
        }
        class B : A
        {
            public new void Display()
            {
                Console.WriteLine("B");
            }
        }
        class C : A
        {
            public override void Display()
            {
                Console.WriteLine("C");
            }
        }
        class D : B
        {
            public new void Display()
            {
                Console.WriteLine("D");
            }
        }
        class E : C
        {
            public new void Display()
            {
                Console.WriteLine("E");
            }
        }

        // 7.2.12 Для класса Obj перегрузите операторы + и -, чтобы результатом работы оператора был
        // новый экземпляр класса Obj, а операции производились над полем Value.
        class Obj
        {
            public int Value;
            public static Obj operator +(Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value + b.Value
                };
            }
            public static Obj operator -(Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value - b.Value
                };
            }
       
        }
    }
}