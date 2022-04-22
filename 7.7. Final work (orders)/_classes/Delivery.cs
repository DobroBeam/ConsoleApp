using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    class Delivery
    {
        public string address;
    }
    class HomeDelivery : Delivery
    { }

    class PickPointDelivery : Delivery
    { }

    class ShopDelivery : Delivery
    { }
}
