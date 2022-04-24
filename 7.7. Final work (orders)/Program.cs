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
            Customer newuser = new Customer();
            Console.WriteLine(newuser.account.Balance);
            newuser.account.Deposit(10);
            Console.WriteLine(newuser.account.Balance);
            newuser.account.Deposit(5);
            Console.WriteLine(newuser.account.Balance);

            
            Individual newVendor = new Individual();
            newVendor.AddItem();
            Catalogue.Show();            
            Console.ReadKey();


            
             
           






            //Account account = new Account();
            //Console.WriteLine(account.Balance);
            //account.Deposit(10);
            //Console.WriteLine(account.Balance);
            //account.Withdraw(5);
            //Console.WriteLine(account.Balance);

            //Customer newuser = new Customer();
            //Console.WriteLine();
            //newuser.Deposit();

            //account.Deposit(10);
            //Console.WriteLine(account.Balance);
            Console.ReadKey();
        }
    }

}
