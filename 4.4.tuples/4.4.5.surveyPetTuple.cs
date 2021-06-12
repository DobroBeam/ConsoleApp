using System;

namespace _4._4.tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 4.4.5. Дан кортеж который нужно заполнить
            //Name — имя питомца;
            //Type — тип питомца: собака, рыбка, хомячок;
            //Age — возраст питомца;
            //NameCount — длина имени питомца.

            (string name, string type, double age, int NameCount) Pet; // заданный кортеж

            Console.Write("Введите имя питомца: ");
            Pet.name = Console.ReadLine();
            Console.Write("Кто ваш питомец: ");
            Pet.type = Console.ReadLine();
            Console.Write("Сколько лет питомцу: ");
            Pet.age = Convert.ToDouble(Console.ReadLine());
            Pet.NameCount = Convert.ToInt32(Pet.name.Length);
            Console.WriteLine("Имя питомца: {0}\nВаш питомец: {1}\nЕго возраст: {2}\nДлина имени: {3}", Pet.name, Pet.type, Pet.age, Pet.NameCount);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нажмите, чтобы продолжить\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
