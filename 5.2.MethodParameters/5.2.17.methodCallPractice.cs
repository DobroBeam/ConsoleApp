using System;

namespace _5._1.methodCall
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 5.1.5. Напишите программу, которая в цикле вызывает метод ShowColor(), записывает его значение в массив из трех цветов favcolors, а потом отображает значения этого массива. 

            //string[] favcolors;
            //favcolors = new string[3];
            //for (int i=0; i < 3; i++)
            //{
            //    favcolors[i] = ShowColor();
            //    Console.WriteLine("Принято");
            //}
            //Console.WriteLine("\nСписок ваших любимых цветов:");
            //foreach (var item in favcolors)
            //{ 
            //    Console.Write($"{item} ");
            //}

            //Задание 5.2.17. Создайте метод ShowArray с параметрами:
            //1.массив чисел,2. признак сортировки логического типа, необязательный параметр, по умолчанию ЛОЖЬ.
            //Метод должен выводить массив на экран. Если значение признака сортировки равно ИСТИНА, то предварительно массив нужно отсортировать.

            Console.Write("Вы хотите отсортировать массив (да/нет): ");
            var needSort = Console.ReadLine();            
            
            if (needSort == "да")
            {            
                ShowArray(SortArray(GetArrayFromConsole()), true);
            }
            else
            {
                ShowArray(GetArrayFromConsole());
            }

            ClickToProceed();
        
        }
        static void ShowArray(int[] arr, bool toSort = false) // вывод массива на консоль
        {
            if (toSort == false)
            {
                Console.Write("НЕ отсортированный массив: ");                             
            }
            else
            {
                Console.Write("Отсортированный массив: ");   
            }
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }            
        }
        static int[] GetArrayFromConsole(int num = 5) // ввод массива через консоль
        {
            var result = new int[num]; // объявление массива указанной размерности (по-умолчанию "5")

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }                
            return result;
        }
        static int[] SortArray(int[] array) // cортировка элементов массива по возрастанию
        {
            int firstChar;
            for (int k = 0; k < array.Length; k++) // цикл сортировки элементов в строке по возрастанию
            {
                for (int t = k + 1; t < array.Length; t++)
                {
                    if (array[k] > array[t])
                    {
                        firstChar = array[k];
                        array[k] = array[t];
                        array[t] = firstChar;
                    }
                }
            }
            return array;
        }

        static string ShowColor()
                {
                    Console.WriteLine("Напишите свой любимый цвет на английском маленькими буквами: ");
                    var color = Console.ReadLine();
                    switch (color)
                    {
                        case "red":
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Your color is red!");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case "yellow":
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Your color is yellow!");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case "green":
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Your color is green!");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Your color is cyan!");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                    return color;
                }
        static void ClickToProceed()
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНажмите, чтобы продолжить\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
    }
}
