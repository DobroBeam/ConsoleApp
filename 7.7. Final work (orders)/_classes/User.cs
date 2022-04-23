﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    abstract class User
    {
        public Account account; // каждый пользователь имеет свой счёт (композиция)
        public User()
        {
            Account account = new Account();
        }
        private string Name { get; set; }
        private int phoneNumber { get; set; }
        private string eMail { get; set; }
        public abstract void AddItem(); // каждый пользователь может добавлять товар
    }
    class Customer : User
    {
       
        private string deliveryAddress { get; set; }
        
        
        public void Deposit() // метод для пополнения счёта
        {
            account.Deposit(10);
        }
        public void Buy() // метод для оформления заказа и покупки
        { }
        public override void AddItem()
        {
            /*
             * логика для добавления товара в корзину
             */
        }
        public void RemoveItem() { } // метод для удаления товара из корзины
    }
    abstract class Vendor : User
    {
        public string vendorName { get; set; }
        public override void AddItem()
        {
            /*
             * логика для добавления товара в каталог
             */
        }
    }
    class Individual : Vendor
    {
        private int passport;
    }
    class Entity : Vendor
    {
        private int taxNumber;
    }
}
