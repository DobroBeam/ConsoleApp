using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    class Order
    {
        
        public int orderNum;
        public Basket OrderList;
        public Delivery Delivery;
        public Customer Customer;
        public Vendor Vendor;
        public decimal TotalPrice;
        
        
        public Order(Basket basket) //, Delivery delivery)
        {
            OrderList = basket;
            TotalPrice = basket.totalPrice;
            orderNum = OrderCounter.Count();
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
