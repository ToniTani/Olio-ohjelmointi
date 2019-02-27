using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVehicle
{
    class Truck : Car
    {
        protected double haulWeight;
        protected double usageKg;

        public Truck()
        {
            this.haulWeight = 0;
            this.usageKg = 0;
        }
        //constructor
        public Truck(string brand, double haulWeight, double usageKg)  //base (brand, model)
        {
            this.haulWeight = haulWeight;
            this.usageKg = usageKg;
        }
        public void PrintTruckInfo()
        {
            Console.WriteLine($"Kuorma-auto: {this.brand} \nKuorman paino: {this.haulWeight} kg\nKulutus per kg: {this.usageKg} l");
        }
        public void CalConsuption()
        {
            Console.WriteLine($"{this.haulWeight} kilon tuoma muunnos kulutukseen {this.usageKg * this.haulWeight} litraa.");
        }
    }
}