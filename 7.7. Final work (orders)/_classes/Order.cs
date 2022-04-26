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
        
        
        public Order(Basket basket)
        {
            OrderList = basket;
            TotalPrice = basket.totalPrice;
        }
    }
    public static class OrderCounter 
    {
        public static int counter
        {
            get { return counter; }
            set { counter += 1; }
        }
    }
    
}
