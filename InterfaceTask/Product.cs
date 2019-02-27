using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    class Product : IProduct
    {
        public string Name;
        public double Price;
        public double Count;

        public Product(string name, double price, double count)
        {
            Name = name;
            Price = price;
            Count = count;
        }


        public override string ToString()
        {
            return ($"Tuotteen nimi: {Name}\n" +
                     $"Hinta: {Price}\n" +
                     $"Lukumäärä: {Count}\n");
        }

        public void GetProduct()
        {
            string NewName = Name;
            if (NewName == Name)
            {
                Console.WriteLine($"{Name}");
            }
            else
            {
                Console.WriteLine($"{null}");
            }
        }

        public void CalculateTotal()
        {
            double Total = Price * Count;
            Console.WriteLine($"Yhteisarvo on: {Total:C}\n");
            Console.WriteLine(new string('-', 25));
        }
    }
}