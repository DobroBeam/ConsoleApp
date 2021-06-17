using System;

namespace _5._3.parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Дмитрий";
            //Console.WriteLine(name);
            //ChangeName(ref name); // при применении служебного слова ref - name меняет значение 
            //Console.WriteLine(name);
            var array = new int[] { 1, 2, 3 };
            Console.WriteLine($"array[0] = {array[0]}");
            int data = 5;
            BigDataOperation(in array, in data);
            Console.WriteLine($"array[0] = {array[0]}");
        }

        static void ChangeName(ref string name)
        {
            name = Console.ReadLine();
        }
        static void BigDataOperation(in int[] arr, in int data)
        {
            arr[0] = data;
        }
    }
}
