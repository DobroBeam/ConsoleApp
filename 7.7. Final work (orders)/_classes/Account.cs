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
        private uint balance;
        public Account() // конструктор класса
        {
            Id = 01;
            balance = 0;
        }
        public uint Balance
        {
            get
            {
                return balance;
            }
        }       
        internal void Deposit(uint value) //счет может принимать средства
        {
            balance = balance + value;
        }
        internal void Withdraw(uint value) //со счета могут списываться средства
        {
            balance = balance - value;
        }
    }
}
