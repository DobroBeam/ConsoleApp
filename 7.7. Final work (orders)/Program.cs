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

    abstract class User 
    {
        private string Name { get; set; }
        private int phoneNumber { get; set; }
        private string eMail { get; set; }
        public abstract void AddItem();
    }
    class Customer : User
    {        
        private string deliveryAddress { get; set; }
        public void Deposit() // метод для пополнения счёта
        { }
        public void Buy() // метод для оформления заказа и покупки
        { }
        public override void AddItem() 
        {
            /*
             * логика для добавления товара в корзину
             */
        }
        public void RemoveItem() { } // метод для удаления товара из корзины
    }
    abstract class Vendor : User
    {
        public string vendorName { get; set; }
        public override void AddItem()
        {
            /*
             * логика для добавления товара в каталог
             */
        }

    }
    class Individual : Vendor 
    {
        private int passport;        
    }
    class Entity : Vendor 
    {
        private int taxNumber;
    }
    class Item 
    {
        public string title;
        private ushort quantity { get; set; }
        private uint price { get; set; }
        private string VendorName;
    }
    abstract class Basket 
    {
        public Item[] list;
        public abstract void EditBasket();
    }
    class Order 
    {
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
