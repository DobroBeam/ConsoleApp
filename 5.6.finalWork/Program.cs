using System;

namespace _5._6.finalWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var(userName, userLastname, userAge, hasPet, petNum, petList, colorNum, favcolors) = GetUserData();
            ShowData(userName, userLastname, userAge, hasPet, petNum, petList, colorNum, favcolors);

            Console.ReadKey();
        }

        static (string userName, string userLastname, int userAge, bool hasPet, int petNum, string[] petList, int colorNum, string[] favcolors) GetUserData()
        {

            (string userName, string userLastname, int userAge, bool hasPet, int petNum, string[] petList, int colorNum, string[] favcolors) UserData;
            UserData.petNum = 0;
            UserData.petList = new string[] { };
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
                Console.Write("У вас есть питомец (да/нет): "); // задаем вопрос

                string answer = Console.ReadLine();
                if (answer == "нет") // если ответ "нет", то выходим
                {
                    UserData.hasPet = false;
                    break;
                }
                else if (answer == "да") // если ответ "да"
                {
                    UserData.hasPet = true;
                    
                    do // цикл для проверки не введено ли значение меньше 0
                    {
                        while (true) // цикл для проверки корректности введенных значений
                        {
                            Console.Write("Сколько у вас питомцев ? (введите число): "); // задаем вопрос сколько питомцев
                            bool ifInt;
                            checkInt(out UserData.petNum, out ifInt); // проверяем целое ли число
                            
                            if (ifInt == true) // если значение корректно
                            {
                                UserData.petList = CollectList("Введите имя питомца", UserData.petNum);
                                break;
                            }
                            else // если значение не корректно
                            {
                                SystemMessage("Ошибка");
                            }
                        }
                        if (UserData.petNum <= 0) // если значение <= 0, выводим сообщение
                        {
                            SystemMessage("Неверное количество");
                        }
                    }
                    while (UserData.petNum <= 0); // возвращаемся в начало цикла если значение <= 0
                    break; // выходим из цикла если всё ОК
                }
                else // если ответ на вопрос не корректен, выводим сообщение
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

            return UserData;
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
        static void ShowData(string userName, string userLastname, int userAge, bool hasPet, int petNum, string[] petList, int colorNum, string[] favcolors)
        {
            Console.WriteLine($"\nВас зовут: {userName} {userLastname}\nВаш возраст: {userAge}");
            Console.WriteLine($"У вас {(hasPet == false ? "нет питомцев" : petNum > 1 ? $"{petNum} питомцев" : $"{petNum} питомец")}.");
            if (hasPet == true)
            {
                Console.Write($"{(petNum > 1 ? "Имена питомцев:" : "Имя питомца:")}");
                foreach (var item in petList)
                {
                    Console.Write($"{item} ");
                }
            }
            Console.Write($"{(hasPet == false ? "" : "\n")}{(colorNum > 1 ? "Ваши любимые цвета: " : "Ваш любимый цвет: ")}");
            foreach (var item in favcolors)
            {
                Console.Write($"{item} ");
            }
        }
        static void SystemMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{message}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
