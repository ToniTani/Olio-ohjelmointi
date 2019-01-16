using System;
using System.Collections.Generic;
using System.Text;

namespace Firma
{
    class Company
    {
        //Fields
        public string title;
        public string adress;
        public string phone;
        private double income;
        private double expense;

        //Constructor 

        public Company()
        {

            this.title = "unknown";
            this.adress = "unknown";
            this.phone = "";
            this.income = 0;
            this.expense = 0;

        }


        public Company(string title, string adress, string phone, double income, double expense)
        {

            this.title = title;
            this.adress = adress;
            this.phone = phone;
            this.income = income;
            this.expense = expense;
            //Copy Constructor


        }
        public Company(Company previousCompany)
        {
            this.title = previousCompany.title;
            this.adress = previousCompany.adress;
            this.phone = previousCompany.phone;
            this.income = previousCompany.income;
            this.expense = previousCompany.expense;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Yritys: {this.title}");
            Console.WriteLine($"Paikkakunta: {this.adress}");
            Console.WriteLine($"Puhelinnumero: {this.phone}");
            Console.WriteLine($"Tuotto: {this.income}");
            Console.WriteLine($"Menot: {this.expense}");
            Console.WriteLine("--------------------------------------------------");
        }
            public void Profit()
        {
            double profit = 100 * (this.income - this.expense) / this.expense;

            Console.Write($"Yrityksen {this.title} voittoprosentti on {profit}%.");

            if (profit > 300)
            {
                Console.WriteLine( "Yrityksellä menee hyvin");
            }
            else if (profit < 100)
            {
                Console.WriteLine( "Yrityksellä menee huonosti");
            }
            else
            {
                Console.WriteLine( "Yrityksellä menee riittävän hyvin");
            }
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}

