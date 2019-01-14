using System;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {

            Car firstCar = new Car();
            firstCar.AskData();
            firstCar.ShowCarInfo();

            Console.WriteLine("Anna kerroin jolla auton nopeutta lisätään ja lasketaan");
        
            firstCar.Accelerate(Console.ReadLine());
            firstCar.Brake();

            Car secondCar = new Car();
            secondCar.AskData();
            secondCar.ShowCarInfo();
        }
    }
}
