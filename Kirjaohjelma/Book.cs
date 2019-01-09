using System;
using System.Collections.Generic;
using System.Text;

namespace Kirjaohjelma
{
    class Book
    {
        public string title;
        public string author;
        public string id;
        public double price;

        public Book()
        {
            //nthis.name = name;
            // Console.WriteLine("Kissan paino on alustettu arvoksi {0} ", this.weight);
        }
        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;
            //Console.WriteLine($"Kirjan nimi {this.title}, jonka tekijä on {this.author}, ID-numero {this.id}, hinta {this.price.ToString()}");
        }
        public string PrintInfo()
        {
            return $"Kirjan nimi {this.title}, jonka tekijä on {this.author}, ID-numero {this.id}, hinta {this.price.ToString()}";

        }

        public string CompareBook(Book book)
        {

            Console.WriteLine($"Nimi: {this.title} - Hinta: {this.price.ToString()}");
            Console.WriteLine($"Nimi: {book.title} - Hinta: {book.price.ToString()}");

            if (this.price > book.price)
            {

                return $"{this.title} on kalliimpi kuin {book.title} kirja";
            }
            else

            {
                return $"{this.title} on kalliimpi kuin {book.title} kirja";
            }
           
        }

    }
}




