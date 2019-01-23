using System;

namespace BookAndWriter
{
    class Program
 
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine($"***KIRJAT***\n");
                Book book1 = new Book("Muumipeikko ja Pyrstötähti", "Tove Janson", "Otava", 44.40, "Fantasia\n");
                book1.GetBook("Muumipeikko ja Pyrstötähti");
                Book.ChangeTheme("Filosofia");
                Console.WriteLine($"Uusi teema on: {Book.themeName}\n");

                Book book2 = new Book("Nikomakhoksen Etiikka", "Aristoteles", "WSOY", 25.60, "Filosofia\n");
                book2.GetBook("Nikomakhoksen Etiikka");
                Console.WriteLine($"\n{book1.name} kirjoittaja on: {book1.Author}");
                Console.WriteLine($"\n{book2.name} kirjoittaja on: {book2.Author}");
                
                //book2.GetBook("Muumipeikko ja Pyrstötähti");
                //book2.searchBook("kakka");
                book1.Price = 44.10;
                book2.Price = 25.60;

            Console.WriteLine($"\n{book1.name} kirjan uusi hinta on: {book1.Price:C}");
                Console.WriteLine($"\n{book2.name} kirjan uusi hinta on: {book2.Price:C}");

                Author author1 = new Author("Tove Janson", "10.01.1960 ", book1);
                Author author2 = new Author("Aristoteles", "384 eKr ", book2);
                author1.PrintInfo();
                //author2.PrintInfo();
                //Console.WriteLine($"\n");

                Console.ReadKey();
            }
        }
    }
