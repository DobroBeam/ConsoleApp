using System;

namespace _4._4.tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 4.4.2. Модифицируйте свою программу для ввода личной информации пользователя так, чтобы данные записывались в кортеж anketa
            (string name, string surname, int age) anketa;
            Console.Write("Введите ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            anketa.surname = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ваше имя: {0}\nВаша фамилия: {1}\nВаш возраст: {2}", anketa.name, anketa.surname, anketa.age);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нажмите, чтобы продолжить\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();

            // Задание 4.4.3. Перезаписать данные в кортеже.
            var (name2, surname2, age2) = ("Евгения", "Иванова", 27);
            Console.WriteLine("Ваше имя: {0}\nВаша фамилия: {1}\nВаш возраст: {2}", name2, surname2, age2);
            Console.Write("Введите ваше имя: ");
            name2 = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            surname2 = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: {0}\nВаша фамилия: {1}\nВаш возраст: {2}", name2, surname2, age2);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нажмите, чтобы продолжить\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
        }
    }
}
