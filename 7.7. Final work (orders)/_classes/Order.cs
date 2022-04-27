using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    class Order<T>
    {
        
        public int orderNum;
        public Item[] OrderList;
        public T delivery;
        public string customer;
        public Vendor Vendor;
        public decimal TotalPrice;
        
       
        public Order(Basket basket, string name)
        {
            OrderList = basket.basketList;
            TotalPrice = basket.totalPrice;
            customer = name;
            orderNum = OrderCounter.Count();
            
        }
        public void Show()
        {
            Console.WriteLine($"Заказ #{orderNum}.");
            Console.WriteLine($"В заказе:");
            foreach (Item item in OrderList)
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
            Console.WriteLine($"Итоговая цена: {TotalPrice} руб.");
        }
    }
    static class OrderCounter 
    {
        public static int counter = 0;
        public static int Count()
        {
            return counter += 1;
        }
        
    }
    
}
