using System;

namespace Kirjaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjat");

            Book newBook = new Book("Taisteluni",
                            "Toni Tani",
                            "00010",
                              22);
            newBook.PrintInfo();
 

            Console.WriteLine("" + newBook.PrintInfo());
            

            Book newBook2 = new Book("Peppi Pitkätossu", "Astrid Lindgren", "00002", 19);
            newBook2.PrintInfo();


            Console.WriteLine("" + newBook2.PrintInfo());
            newBook.CompareBook(newBook2);
            Console.WriteLine(newBook.CompareBook(newBook2));
            Console.ReadKey();
        }
    }
}
