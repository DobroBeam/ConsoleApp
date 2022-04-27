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
            account.Deposit(100);

        }
        protected string Name = "Вася";
        

        protected int phoneNumber { get; set; }
        protected string eMail { get; set; }
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
        public override void AddItem() // добавление товара из каталога в корзину, 
        {
            Console.WriteLine("Выберите товар для добавления в корзину");
            Item newitem = new Item(Catalogue.list[Convert.ToInt32(Console.ReadLine()) - 1]);
            
            while (true) // нужное количество выбранного товара
            {
                Console.WriteLine($"Введите нужное количество данного товара. Всего доступно: {newitem.quantity} шт.");
                uint q = Convert.ToUInt32(Console.ReadLine());
                if (q > newitem.quantity)
                {
                    Console.WriteLine("В наличии нет столько товара");
                }
                else
                {
                    newitem.quantity = q;
                    break;
                }
            }          
          

            for (int i=0; i < basket.basketList.Length; i++) // добавляет выбранный товар в первую незанятую ячейку (если артикул товара в текущей ячейке совпадает, добавляет только количество)
            {
                if (basket.basketList[i] == null)
                {
                    basket.basketList[i] = newitem;
                    break;
                }
                else if(basket.basketList[i].article == newitem.article)
                {
                    basket.basketList[i].quantity += newitem.quantity;
                    break;
                }
            }           
        }
        public void RemoveItem() // удаление товара из корзины
        {

        } 
        public void PlaceOrder()
        {
            
            if(basket != null & basket.basketList[0] != null)
            {
                if (account.Balance > basket.totalPrice)
                {
                    // выбор типа доставки
                    
                    
                    while (true)
                    {
                        Console.WriteLine("Выберите тип доставки: \n\t 1 - доставка на дом \n\t 2 - доставка в пункт выдачи");
                        int toogle = Convert.ToInt32(Console.ReadLine());
                        if (toogle == 1)
                        {
                            Order<HomeDelivery> neworder = new Order<HomeDelivery>(basket, Name);
                            neworder.delivery = new HomeDelivery(neworder.customer, neworder.orderNum, deliveryAddress, "Деловые линии");
                            break;
                        }
                        if (toogle == 2)
                        {
                            Order<PickPointDelivery> neworder = new Order<PickPointDelivery>(basket, Name);
                            Console.WriteLine("Введите название и адрес пункта выдачи");
                            neworder.delivery = new PickPointDelivery(neworder.customer, neworder.orderNum, Convert.ToString(Console.ReadLine()));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Нет такого варианта. Попробуйте снова.");
                        }
                    }
                    account.Withdraw(basket.totalPrice); // списание средств со счета

                    foreach (Item item in basket.basketList) // вычитает из доступного количества в каталоге товара, количество приобретенного
                    {
                        foreach (Item item2 in Catalogue.list)
                        {
                            if (item.article != item2.article)
                            {
                                continue;
                            }
                            else
                            {
                                item2.quantity -= item.quantity;
                            }                            
                        }                        
                    }
                }
                else
                {
                    Console.WriteLine("Недостаточно средств для размещения заказа");
                }                
                
            }
            else
            {
                Console.WriteLine("Корзина пуста");
            }
        }

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
            while (true) // проверка введенного значения
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
            while (true) // проверка введенного значения
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
            foreach (Item item in Catalogue.list) // цикл для добавления товара в последнюю не занятую ячейку каталога (если артикул совпадает, то добавляет только количество)
            {
                if (item == null)
                {
                    Catalogue.list[i] = newItem;
                }
                else if (item.article == newItem.article)
                {
                    item.quantity += newItem.quantity;
                }
                else
                {
                    i++;
                    continue;
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
