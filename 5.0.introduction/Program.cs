using System;

namespace _5._0.introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string[] dishes) User;
            Console.WriteLine("Введите ваше имя: ");
            User.name = Console.ReadLine();
            User.dishes = new string[5];
            Console.WriteLine("Введите ваши любимые блюда: ");
            for (int i = 0; i < User.dishes.Length; i++)
            {
                Console.Write($"Блюдо {i+1} :");
                User.dishes[i] = Console.ReadLine();
            }
            Console.WriteLine($"Ваше имя: {User.name}");
            Console.Write("Ваши любимые блюда: ");
            foreach (var item in User.dishes)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
