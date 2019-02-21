using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInterface
{
    class Store : ICustomers, IProducts
    {
        public string name;
        public string revenue;
        public List<Product> products;
        public List<Customer> customers;

        public Store(string name, string revenue)
        {
            this.name = name;
            this.revenue = revenue;
            customers = new List<Customer>();
            products = new List<Product>();
        }

        public override string ToString()
        {
            return ($"\n{name}\n{revenue:C}\n");
        }

        public void AddCustomer(List<Customer> customer)
        {
            customers = customer;
        }
        public void PrintCustomers()
        {
            foreach (Customer c in customers)
            {
                Console.WriteLine($" {c.ToString()}");
                c.CalculateBonus();
            }
            Console.WriteLine($"Asiakkaita listalla:" +
                $" {customers.Count()}");
            Console.WriteLine(new string('-', 25));
        }

        public void AddProduct(List<Product> product)
        {
            products = product;
        }

        public void PrintProduct()
        {
            foreach (Product p in products)
            {
                Console.WriteLine($"{p.ToString()}");
                p.CalculateTotal();
            }
            Console.WriteLine($"Tuotteita myynnissä:" +
                $" {products.Count()}");
            Console.WriteLine(new string('-', 25));
        }


        public void PrintProducts()
        {
            throw new NotImplementedException();
        }
    }
}