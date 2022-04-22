using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    class Account
    {
        public int Id { get; set; }
        public uint Money=0;
        public void Deposit(uint value)
        {
            Money = Money + value;
        }
        public void Withdraw(uint value)
        {
            Money = Money - value;
        }
    }
}
