using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    class Account
    {
        private int Id { get; set; }
        private uint Balance;
        public Account()
        {
            Id = 01;
            Balance = 0;
        }
        public uint ShowBalance()
        {
            return Balance;
        }
        public void Deposit(uint value) //счет может принимать средства
        {
            Balance = Balance + value;
        }
        public void Withdraw(uint value) //со счета могут списываться средства
        {
            Balance = Balance - value;
        }
    }
}
