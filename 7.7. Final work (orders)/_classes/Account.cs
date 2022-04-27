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
        private decimal balance;
        public Account() // конструктор класса
        {
            Id = 01;
            balance = 0;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }       
        internal void Deposit(decimal value) //счет может принимать средства
        {
            balance = balance + value;
        }
        internal void Withdraw(decimal value) //со счета могут списываться средства
        {
            balance = balance - value;
        }
    }
}
