using System;
using System.Collections.Generic;
using System.Text;
namespace TaskTicketPrice
{
    class TicketPrice
    {
        //Fields
        public int isAge;
        public bool isMtk;
        public int NormalPrice;
        public decimal EndPrice;
        public int Discount;
        public bool isSoldier;
        public bool isStudent;

        //constructor
        public TicketPrice()
        {
            isAge = 0;
            isMtk = false;
            NormalPrice = 16;
            EndPrice = 0;
            isSoldier = false;
            isStudent = false;
            Discount = 0;
        }

        //Methods
        public void Data()
        {
            Console.WriteLine("Welcome! Let's calculate your ticket price!\n");

            bool isNumber;
            do
            {
                Console.Write("How old are you? ");
                string age = Console.ReadLine();
                isNumber = int.TryParse(age, out isAge);
            } while (isNumber != true);

            isMtk = Answer("member of the MTK?");
            isSoldier = Answer("soldier?");
            isStudent = Answer("student?");
        }
        public bool Answer(string msg)
        {
            Console.Write($"Are you a {msg} Y/N:");
            string ans = Console.ReadLine().ToUpper();

            if (ans == "Y")
                return true;
            else
                return false;
        }

        public void PriceCount()
        {

            double price = 16.00;

            if (isAge < 7)
            {
                price = price - (price * 1);
            }
            else if (isAge <= 15)
            {
                price = price - (price * 0.5);
            }
            else if (isAge >= 65)
            {
                price = price - (price * 0.5);
            }
            else if (isSoldier == true)
            {
                price = price - (price * 0.5);
            }
            else
            {
                if (isStudent == true)
                {
                    price = price - (price * 0.45);
                }
                if (isMtk == true)
                {
                    price = price - (price * 0.15);
                }
            }
            Console.WriteLine($"Your ticket's final price is: {price} $");
        }

    }
}