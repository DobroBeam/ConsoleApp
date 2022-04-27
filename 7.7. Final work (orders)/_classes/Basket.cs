using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    public class Basket
    {
        internal Item[] basketList = new Item[10];
        internal decimal totalPrice;

        public void Total() 
        {
            decimal sum = 0;
            foreach (Item item in basketList)
            {
                if (item != null)
                {
                    sum += Convert.ToDecimal(item.quantity) * item.price;
                }
                else
                {
                    break;
                }
            }
            totalPrice = sum;            
        }
        
        public void EditBasket() { }

        public void Show()
        {
            Console.WriteLine("В корзине находится следующий товар:");
            foreach (Item item in basketList)
            {
                if (item == null)
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
