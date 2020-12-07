using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Library
    {
        
        Books[] booklist;
        public Library(Books[] booklist)
        {
            this.booklist = booklist;
        }

        public void PrintBook(string userInput)
        {

            for (int i = 0; i < booklist.Length; i++)
            {
                if (userInput.ToLower() == booklist[i].title.ToLower() || userInput.ToLower() == booklist[i].author.ToLower())
                {
                    Console.WriteLine($"Книга: {booklist[i].title} \nАвтор книги: {booklist[i].author}");
                    return;
                }

            }
            Console.WriteLine("Книга не найдена");
        }
               
    }
}
