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
    class Customer 
    {
        public string firstName;
        public string lastName;
        public int phoneNumber;
        public string eMail;
        public string deliveryAddress;
    }
    class Vendor 
    {
        public string vendorName;
    }
    class Individual : Vendor 
    {
        public int passport;
    }
    class Entity : Vendor 
    {
        public int taxNumber;
    }
    class Good { }
    class Order<TDelivery> 
    {
        public TDelivery Delivery;

    }
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
