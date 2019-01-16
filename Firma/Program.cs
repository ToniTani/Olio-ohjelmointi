using System;

namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {

            Company kalatukku = new Company("Kalatukku", " Lappeenranta", "05012444", 400, 200);
            Company taikuri = new Company("Taikurin Hattu", "Helvetin Portti", "050666666", 666, 999);
            Company ravintola = new Company("Kebab ja Sushi", "Sumatra", "08983938", 5645, 1000);

            kalatukku.PrintInfo();
            taikuri.PrintInfo();
            ravintola.PrintInfo();

            kalatukku.Profit();
            taikuri.Profit();
            ravintola.Profit();

            Console.ReadLine();
        }
    }
}
