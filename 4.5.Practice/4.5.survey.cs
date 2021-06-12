using System;

namespace _4._5.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string surname, string login, int loginLength, bool hasPet, double age, string[] favColor) User;
            for (int k=0; k<3; k++)
            {
                Console.Write("Введите ваше имя:");
                User.name = Console.ReadLine();

                Console.Write("Введите вашу фамилию:");
                User.surname = Console.ReadLine();

                Console.Write("Введите ваш возраст:");
                User.age = double.Parse(Console.ReadLine());

                Console.Write("Введите ваш логин:");
                User.login = Console.ReadLine();
                User.loginLength = User.login.Length;

                Console.Write("У вас есть питомец? (да / нет): ");
                if (Console.ReadLine() == "да")
                {
                    User.hasPet = true;
                }
                else
                {
                    User.hasPet = false;
                }
                Console.Write("Введите 3 ваших любимых цвета:");
                User.favColor = new string[3];

                for (int i = 0; i < 3; i++)
                {
                    User.favColor[i] = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Ваше имя и фамилия: {User.name} {User.surname}\nВаш возраст: {User.age}\nВаш логин: '{User.login}' - длиной {User.loginLength} знаков");
                if (User.hasPet == true)
                {
                    Console.WriteLine("У вас есть питомец");
                }
                else
                {
                    Console.WriteLine("У вас нет питомца");
                }
                Console.Write("Ваши любимые цвета:");
                foreach (var item in User.favColor)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нажмите, чтобы продолжить\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
