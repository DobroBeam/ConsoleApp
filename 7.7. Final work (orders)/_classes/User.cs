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
        internal Basket basket;
        public User()
        {
            account = new Account();
            basket = new Basket();

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
            Catalogue.Show();
            Console.WriteLine("Выберите товар для добавления в корзину");
            Item newitem = Catalogue.list[Convert.ToInt32(Console.ReadLine()) - 1];
            Console.WriteLine($"Нужное количество данного товара. Всего доступно: {newitem.quantity} шт.");
            newitem.quantity = Convert.ToUInt32(Console.ReadLine());
            
            for (int i=0; i < basket.basketList.Length; i++)
            {
                if (basket.basketList[i] == null)
                {
                    basket.basketList[i] = newitem;
                    break;
                }
                else if(basket.basketList[i].title == newitem.title)
                {
                    basket.basketList[i].quantity += newitem.quantity;
                    break;
                }
            }

            basket.basketList[0] = newitem;
            basket.Show();
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
            decimal price;
            while (true)
            {
                bool isDecimal = Decimal.TryParse(Console.ReadLine(), out decimal result);
                if (isDecimal)
                {
                    price = result;
                    break;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            }          

            Console.Write("Введите количество товара на складе: ");
            uint newItemQuantity;
            while (true)
            {
                bool isUint = UInt32.TryParse(Console.ReadLine(), out uint result);
                if(isUint)
                {
                    newItemQuantity = result;
                    break ;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            }

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
