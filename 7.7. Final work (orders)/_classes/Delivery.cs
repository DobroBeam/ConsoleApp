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
        

        public Delivery(string name, int orderNum)
        {
            receiverName = name;
            this.orderNum = orderNum;
        } 
    }
    class HomeDelivery : Delivery
    {
        private string address;
        private string deliveryCompany;

        public HomeDelivery(string name, int ordNum, string address, string company):base (name, ordNum)
        {
            this.address = address;
            deliveryCompany = company;
        }
    }

    class PickPointDelivery : Delivery
    {
        private string pickPointAddress;

        public PickPointDelivery(string name, int ordNum, string address) : base(name, ordNum)
        {
            pickPointAddress = address;
        }
    }

    
}
