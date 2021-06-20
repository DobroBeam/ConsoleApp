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
            
            // имя пользователя
            do
            {
                Console.Write("Введите ваше имя:");
                UserData.userName = Console.ReadLine();
            }
            while (UserData.userName == "");
            // фамилия пользователя
            do
            {
                Console.Write("Введите вашу фамилию:");
                UserData.userLastname = Console.ReadLine();
            }
            while (UserData.userName == "");
            // возраст пользователя
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
                        SystemMessage("Ошибка");
                    }

                }
                if (UserData.userAge <= 0)
                {
                    SystemMessage("Неверный возраст");
                }

            }
            while (UserData.userAge <= 0);
            // наличие питомца
            do
            {
                Console.Write("У вас есть питомец (да/нет): ");

                string answer = Console.ReadLine();
                if (answer == "нет")
                {
                    UserData.hasPet = false;
                    break;
                }
                else if (answer == "да")
                {
                    UserData.hasPet = true;
                    do
                    {
                        while (true)
                        {
                            Console.Write("Сколько у вас питомцев ? (введите число): ");
                            bool ifInt;
                            checkInt(out UserData.petNum, out ifInt);
                            if (ifInt == true)
                            {
                                UserData.petList = CollectList("Введите имя питомца", UserData.petNum);
                                break;
                            }
                            else
                            {
                                SystemMessage("Ошибка");
                            }
                        }
                        if (UserData.petNum <= 0)
                        {
                            SystemMessage("Неверное количество");
                        }
                    }
                    while (UserData.petNum <= 0);
                    break;
                }
                else
                {
                    SystemMessage("Вы не ответили на вопрос");
                }
            }
            while (true);
            // любимые цвета
            do
            {
                while (true)
                {
                    Console.Write("Сколько у вас любимых цветов ? (введите число): ");
                    bool ifInt;
                    checkInt(out UserData.colorNum, out ifInt);
                    if (ifInt == true)
                    {
                        UserData.favcolors = CollectList("Введите цвет", UserData.colorNum);
                        break;
                    }
                    else
                    {
                        SystemMessage("Ошибка");
                    }
                }
                if (UserData.colorNum <= 0)
                {
                    SystemMessage("Неверное количество");
                }
            }
            while (UserData.colorNum <= 0);

            Console.ReadKey();

        }

        static void checkInt(out int number, out bool check)
        {
            check = Int32.TryParse(Console.ReadLine(), out number);            
        }
        static string[] CollectList(string message, int length)
        {
            string[] list = new string[length];
            for(int i=0; i < list.Length; i++)
            {
                string item;
                do
                {
                    Console.Write($"{message} {i + 1}: ");
                    item = Console.ReadLine();
                }
                while (item == "");
                list[i] = item;
            }
            return list;
        }
        static void SystemMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{message}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
