using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    public class Catalogue
    {
        public static Item[] list = new Item[2];
        public static void Show()
        {
            Console.WriteLine("В каталоге находится следующий товар:");
            foreach (Item item in list)
            {
                if(item == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"\t {item.title} || {item.article} || цена за шт. {item.price} руб. || {item.quantity} шт.");
                }
            }            
        }
    }
}

