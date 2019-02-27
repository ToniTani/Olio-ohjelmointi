using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVehicle
{
    abstract class Vehicle
    {
        //fields
        protected string brand;
        protected string model;
        protected string year;
        protected string price;

        public Vehicle()
        {
            this.brand = "";
            this.model = "";
            this.year = "";
            this.price = "";
        }

        public Vehicle(string brand, string model, string year, string price)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Merkki: {this.brand}\nMalli: {this.model}\nVuosimalli: {this.year}\nHinta: {this.price} €");
        }
    }
}