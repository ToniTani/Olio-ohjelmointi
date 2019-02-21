using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInterface

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Tervetuloa!\n");

            List<Product> products = new List<Product>();

            Product product1 = new Product("Tietokone", 500, 50);
            Product product2 = new Product("Näppäimistö", 70, 65);
            Product product3 = new Product("Hiiri", 35, 75);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

            products[0].GetProduct();
            products[0].CalculateTotal();

            products[1].GetProduct();
            products[1].CalculateTotal();
            products[2].GetProduct();
            products[2].CalculateTotal();

            List<Customer> customers = new List<Customer>();
            Customer customer1 = new Customer("Ruskea Risto", 400);
            Customer customer2 = new Customer("Matti Teppo", 4000);
            Customer customer3 = new Customer("Uppo Behm", 1000);

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            customers[0].GetCustomer();
            customers[0].CalculateBonus();
            customers[1].GetCustomer();
            customers[1].CalculateBonus();
            customers[2].GetCustomer();
            customers[2].CalculateBonus();

            Store store = new Store("Valintatalo", "3 000 000");
            store.AddCustomer(customers);
            store.AddProduct(products);
            store.PrintCustomers();
            store.PrintProduct();
            Console.ReadKey();
        }
    }
}

