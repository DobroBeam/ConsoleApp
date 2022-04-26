using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    class Delivery
    {
        public string receiverName;
        public int orderNum;
        public Delivery(string name, string address, int orderNum)
        {
            receiverName = name;
            this.address = address;
            this.orderNum = orderNum;
        }
        

        public string address { get; set; }


    }
    class HomeDelivery : Delivery
    {

        public HomeDelivery(string name, string address, int orderNum) : base(name, address, orderNum)
        {

        }
    }

    class PickPointDelivery : Delivery
    { }

    class ShopDelivery : Delivery
    { }
}
