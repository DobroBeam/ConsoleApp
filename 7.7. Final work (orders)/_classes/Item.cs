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
        public uint quantity;
        public decimal price;
        
        public Item(string article, string title, decimal price, uint quantity)
        {
            this.article = article;
            this.title = title;
            this.price = price;
            this.quantity = quantity;
        }
        public Item(Item newitem)
        {
            article = newitem.article;
            title = newitem.title;
            price = newitem.price;
            quantity = newitem.quantity;
        }

        
    }
}
