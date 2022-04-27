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

            Console.WriteLine("создан пользователь Individual");
            Individual newuser1 = new Individual();

            newuser1.AddItem();
            Catalogue.Show();
            newuser1.AddItem();
            Catalogue.Show();

            Console.WriteLine("создан пользователь Customer");
            Customer newuser2 = new Customer();
            Catalogue.Show();
            newuser2.AddItem();
            newuser2.basket.Show();
            Catalogue.Show();
            newuser2.AddItem();
            newuser2.basket.Show();
            Catalogue.Show();
            newuser2.AddItem();
            newuser2.basket.Show();
            Catalogue.Show();

            newuser2.PlaceOrder();
            Console.WriteLine("создан заказ");
            Catalogue.Show();
            Console.WriteLine($"Ваш баланс: {newuser2.account.Balance}");

            //newuser.account.Deposit(10);
            //Console.WriteLine(newuser.account.Balance);
            //newuser.account.Deposit(5);
            //Console.WriteLine(newuser.account.Balance);


            //Individual newVendor = new Individual();
            //newVendor.AddItem();
            //Catalogue.Show();
            //newVendor.AddItem();
            //Catalogue.Show();



            //newuser.AddItem();

            //newuser.AddItem();
            //newuser.AddItem();
            //Console.ReadKey();








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
    class MotherBoard
    {
    }
    class SystemUnit
    {
        private MotherBoard motherBoard;

        public SystemUnit(MotherBoard motherBoard)
        {
            this.motherBoard = motherBoard;
        }
    }

}
