using System;

namespace _7._2._7_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            // создаем массив из 2-х книг
            var array = new Book[]
            {
                new Book
                {
                  Name = "Мастер и Маргарита",
                  Author = "М.А. Булгаков"
                },
                new Book
                {
                  Name = "Отцы и дети",
                  Author = "И.С. Тургенев"
                },
            };
            // создаем экземпляр класса BookCoollection и помещаем туда наш массив из 2-х книг
            BookCollection collection = new BookCollection(array); 

            // создаем экземпляр класс Book и присваеваем ему значение ВТОРОЙ книги из массива (индекс 1)
            Book book = collection[1];

            // выводим поля только что созданного экземпляра класса
            Console.WriteLine(book.Name + " - " + book.Author);
        }


        // Класс для объекта “Книга”
        class Book
        {
            public string Name;
            public string Author;
        }

        // Класс для объекта “Коллекция книг”
        class BookCollection
        {
            // Закрытое поле, хранящее книги в виде массива
            private Book[] collection;

            // Конструктор с добавлением массива книг
            public BookCollection(Book[] collection)
            {
                this.collection = collection;
            }

            // Индексатор по массиву
            public Book this[int index]
            {
                get
                {
                    // Проверяем, чтобы индекс был в диапазоне для массива
                    if (index >= 0 && index < collection.Length)
                    {
                        return collection[index]; // если есть, возвращаем запрошенный элемент массива
                    }
                    else
                    {
                        return null;
                    }
                }

                private set
                {
                    // Проверяем, чтобы индекс был в диапазоне для массива
                    if (index >= 0 && index < collection.Length)
                    {
                        collection[index] = value; // если есть, записываем элемент массива
                    }
                }
            }
        }

        // 7.2.14 - Для следующего класса напишите индексатор, для типа параметра используйте int:
        class IndexingClass
        {
            private int[] array;

            public IndexingClass(int[] array)
            {
                this.array = array;
            }

            // создаем индексатор где типом возвращаемого значения является nullable int (int?)
            public int? this[int index]
            {
                get
                {
                    if (index >= 0 && index < array.Length)
                    {
                        return array[index];
                    }
                    else
                        return null;                    
                }
                set
                {
                    array[index] = Convert.ToInt32(value);
                }                
            }
        }
           

        
    }
}
