using System;
using System.Collections.Generic;
using System.Text;

namespace Auto
{
    class Car

    {
        public string brand;
        public int speed;

        public Car()
        {

        }

        public Car(string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;
        }

        public void AskData()
        {
            Console.Write("Syötä auton merkki:");
            brand = Console.ReadLine();
            Console.Write("Syötä auton nopeus:");
            string speedValue = Console.ReadLine();

            if (!int.TryParse(speedValue, out speed))
            {
 
                speed = 0;
            }



        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton {this.brand} huippunopeus on {this.speed}.");
        }
        public void Accelerate(string iSpeedValue)
        {
            int iSpeed = int.Parse(iSpeedValue);

            if (iSpeed >= 0)
            {
                this.speed += iSpeed;
                Console.WriteLine($"auton {this.brand} kiihdytysnopeus {this.speed} km/h");
            }
            else if (iSpeed == 0)
            {
                Console.WriteLine("ei muutosta");
            }
            else
            {
                Console.WriteLine("Negatiivista muutosta ei sallita");
            }
        }
        public void Brake()

        {

            speed = 90 * speed / 100;
            Console.WriteLine($"jarruttamalla nopeutta hidastetaan 10%, uusi nopeus {speed} km/h\n");
        }
    }
}





