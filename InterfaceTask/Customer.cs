using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskInterface
{
    class Customer : ICustomer
    {
        public string name;
        public double purchase;

        public Customer(string name, double purchase)
        {
            this.name = name;
            this.purchase = purchase;
        }

        public override string ToString()
        {
            return ($"\nAsiakas: {name}" +
                    $"\nOstosten kuitti: {purchase:C}");
        }

        public void GetCustomer()
        {
            string NewCustomer = name;
            if (NewCustomer == name)
            {
                Console.WriteLine($"{name}");
            }
            else
            {
                Console.WriteLine($"{null}");
            }
        }

        public void CalculateBonus()
        {
            double Total;
            if (purchase <= 1000)
            {
                Total = purchase * 0.02;
                Console.WriteLine($"Bonusta 2%: {Total:C}\n");
                Console.WriteLine(new string('-', 25));
            }
            else if (purchase > 1000 && purchase < 200)
            {
                Total = purchase * 0.03;
                Console.WriteLine($"Bonusta 3%: {Total:C}\n");
                Console.WriteLine(new string('-', 25));
            }
            else
            {
                Total = purchase * 0.05;
                Console.WriteLine($"Bonusta 5%: {Total:C}\n");
                Console.WriteLine(new string('-', 25));
            }
        }
    }
}