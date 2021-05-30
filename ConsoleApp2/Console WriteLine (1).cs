using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Dmitry";
            byte MyAge = 27;
            bool DoIHaveAPet = false;
            float MyShoeSize = 41;
            Console.WriteLine($"My name is {MyName}\nI am {MyAge}\nDo I have a pet? {DoIHaveAPet}\nMy shoe size is {MyShoeSize}");
            Console.ReadKey();
        }
    }
}
