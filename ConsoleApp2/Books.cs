using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Books
    {
        public string title;
        public string author;
        public string genre;
        public Books(string _title, string _author, string _genre)
        {
            title = _title;
            author = _author;
            genre = _genre;

            //Print();
        }
        public void Print()
        {
            Console.WriteLine("Название книги: " + title);
            Console.WriteLine("Автор: " + author);
            Console.WriteLine("Жанр: " + genre);
        }
    }
}
