using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Final_work__orders_
{
    abstract class User
    {
        internal Account account; // каждый пользователь имеет свой счёт (композиция)
        public User()
        {
            account = new Account();
        }
        private string Name { get; set; }
        private int phoneNumber { get; set; }
        private string eMail { get; set; }
        public abstract void AddItem(); // каждый пользователь может добавлять товар
    }
    class Customer : User
    {
       
        private string deliveryAddress { get; set; }
        
        
        public void Deposit(uint value) // метод для пополнения счёта
        {
            account.Deposit(value);
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
        public override void AddItem() //добавление товара в каталог
        {


            Console.Write("Введите наименование товара: ");
            string newItemName = Console.ReadLine();

            Console.Write("Введите артикульный номер: ");
            string newArticle = Console.ReadLine();

            Console.Write("Введите стоимость за единицу товара: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите количество товара на складе: ");
            uint newItemQuantity = Convert.ToUInt32(Console.ReadLine());

            Item newItem = new Item(newArticle, newItemName, price, newItemQuantity);
                        
            int i = 0;
            while (true) // цикл для добавления товара в последнюю не занятую ячейку каталога
            {                
                if (Catalogue.list[i]==null)
                {
                    Catalogue.list[i] = newItem;
                    break;
                }
                else
                {
                    i++;
                }
            }        
            Console.WriteLine($"Товар добавлен: {newItem.title} || {newItem.article} || цена за шт. {newItem.price} руб. || {newItem.quantity} шт.");
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
