using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    public class Item
    {
        public string title;
        public string article;
        public uint quantity { get; set; }
        public decimal price { get; set; }
        public string VendorName;
        public Item(string article, string title, decimal price, uint quantity)
        {
            this.article = article;
            this.title = title;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
