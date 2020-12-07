using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books("Шантарам", "Грегори Дэвид Робертс", "Роман");

            Books book2 = new Books("Финансист", "Теодор Драйзер", "Роман");

            Books book3 = new Books("Я робот", "Айзек Азимов", "Научная фантастика");

            Books book4 = new Books("Код да Винчи", "Дэн Браун", "Детектив");

            Books book5 = new Books("Зеленая миля", "Стивен Кинг", "Драма");

            Books[] bookarray = new Books[] { book1, book2, book3, book4, book5 };
           
            Library mylibrary = new Library (bookarray);
           
            Console.WriteLine("Для поиска введите название книги или автора:");
            string userInput = Console.ReadLine();

            mylibrary.PrintBook(userInput);

            
            
        }
    }

  
}


//Шантарам Грегори Дэвид Робертс (роман)
// Финансист Теодор Драйзер (роман)
// Я робот - Айзек Азимов (научная фантастика)
// Код да Винчи - Дэн Браун (детектив)
// Зеленая миля - Стивен Кинг (драма)