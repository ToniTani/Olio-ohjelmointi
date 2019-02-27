using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndWriter
{
        class Book
    {
        //FIelds
        public string name;
        public string writer;
        public string publisher;
        private double price;
        public static string themeName;


        //Constructor
        public Book(string name, string writer, string publisher, double price, string themename)
        {
            this.name = name;
            this.writer = writer;
            this.publisher = publisher;
            this.Price = price;
            themeName = themename;
        }

        //Methods
        public void GetBook(string name)
        {
            if (this.name == name)
            {
                Console.WriteLine($"{name}\n{publisher}\n{Price:C}\n{themeName}");
            }
            else
            {
                Console.Write($"Hait kirjaa {name}. Kirjaa ei löytynyt");
            }
        }

        internal void searchBook(string v)
        {
            throw new NotSupportedException();
        }

        public static void ChangeTheme(string theme)
        {
            themeName = theme;
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 30)
                {
                    price = value * 0.9;
                }
            
                else
                {
                price = value;
            }
        }
    
        }
        public string Author
        {
            get
            {
                return writer;
            }
        }
    }
}
