using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.Deposit(10);
            Console.WriteLine(account.Money);
            Console.ReadKey();
        }
    }

}
