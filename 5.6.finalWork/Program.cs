using System;

namespace _5._6.finalWork
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserData();
        }

        static void GetUserData()
        {

            (string userName, string userLastname, int userAge, bool hasPet, int petNum, string[] petList, int colorNum, string[] favcolors) UserData;

            do
            {
                Console.Write("Введите ваше имя:");
                UserData.userName = Console.ReadLine();
            }
            while (UserData.userName == "");
            do
            {
                Console.Write("Введите вашу фамилию:");
                UserData.userLastname = Console.ReadLine();
            }
            while (UserData.userName == "");

            do
            {
                while (true)
                {
                    Console.Write("Введите ваш возраст:");
                    bool ifInt;
                    checkInt(out UserData.userAge, out ifInt);
                    if (ifInt == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }

                }
                if (UserData.userAge <= 0)
                {
                    Console.WriteLine("Неверный возраст");
                }

            }
            while (UserData.userAge <= 0);
            
            Console.WriteLine(UserData.userAge);
        }

        static void checkInt(out int number, out bool check)
        {
            check = Int32.TryParse(Console.ReadLine(), out number);
            
        }
    }
}
