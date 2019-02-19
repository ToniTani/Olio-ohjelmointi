using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndWriter
{
    class Author
    {
        //Fields
        public readonly string name;
        public readonly string birthday;
        Book book;

        //Constructor
        public Author(string name, string birthday, Book book)
        {
            this.name = name;
            this.birthday = birthday;
            this.book = book;
        }

        //Methods
        public void PrintInfo()
        {
            Console.WriteLine($"***************************************************");
            Console.WriteLine($"\nKirjailijan nimi on {name}," +
                $"\nhän on syntynyt {birthday}\n");
                book.GetBook("Muumipeikko ja Pyrstötähti");
                book.GetBook("Keltainen Keisari");
        }
    }
}