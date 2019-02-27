
using System;

namespace InheritanceVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ajoneuvo auto\n");

            Car car = new Car("Talbot", "Landcruiser", "2020", "15000", 1.8, "Hatchback", "5");

            car.PrintInfo();

            car.ToString();
            car.Equals(1);
            Console.WriteLine("\n'Kuorma-auto' muunnos \n"); //tehtavananto harhaanjohtava
            Truck truck = new Truck("Lada",3000, 15);
            truck.PrintTruckInfo();
            truck.ToString();
            truck.CalConsuption();

            Console.ReadKey();
        }
    }
}