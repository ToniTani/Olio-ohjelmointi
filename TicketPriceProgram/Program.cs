using System;

namespace TaskTicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            TicketPrice person1 = new TicketPrice();
            person1.Data();
            person1.PriceCount();

            Console.ReadKey();
        }
    }
}