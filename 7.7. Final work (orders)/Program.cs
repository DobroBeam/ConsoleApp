using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

   
    
   
    abstract class Basket<T>
    {
        public T[] list;
        public abstract void EditBasket();
    }
    class Order<T>
    {
        public T orderNum;
        public Basket OrderList;
        public Delivery Delivery;
        public Customer Customer;
        public Vendor Vendor;
        public uint TotalPrice;

    }
    class Catalogue { }
    class Delivery 
    {
        public string address;
    }
    class HomeDelivery : Delivery
    {}

    class PickPointDelivery : Delivery
    {}

    class ShopDelivery : Delivery
    {}



}
