using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    class Item<T>
    {
        public string title;
        public T article;
        private ushort quantity { get; set; }
        private uint price { get; set; }
        private string VendorName;
    }
}
