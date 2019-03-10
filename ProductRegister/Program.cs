using static System.Console;

namespace ProductRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileManager = new FileManager();

            string userInterface; // UI for console commands
            var message = "Press any key to continue";

            do
            {
                userInterface = ChooseAction();
                switch (userInterface.ToUpper())
                {
                    case "1":
                        WriteLine(fileManager.ListItems());
                        break;

                    case "2":
                        WriteLine("Show products by group:");
                        WriteLine("1 = Lajittelu ja säilytys");
                        WriteLine("2 = Paperit ja lehtiöt");
                        WriteLine("3 = Kynät");
                        WriteLine("4 = Kortit ja kirjekuoret");
                        var group = ReadLine();
                        WriteLine(fileManager.PrintProductGroup(group));
                        break;

                    case "3":
                        fileManager.OutOfStock();
                        break;
                    case "4":
                        fileManager.AddComment(); // method contains both deleting and adding comments
                        break;
                    case "6":
                        message = "\nClose program.";
                        break;
                    case "5":
                        fileManager.UpdateStockAndPrice(); // use this to fix stock and price values, USE WITH EXTREME CAUTION!
                        break;


                    default:
                        message = "An error has occured, Press any key to continue";
                        break;
                }
                WriteLine(message);
                ReadKey();
                Clear();
            }

            while (userInterface.ToUpper() != "6"); 
        }

        public static string ChooseAction()
        {
            WriteLine("Product Management System Register\nPress ENTER to proceed:");
            WriteLine("[ 1 ] = Show all the listed products");
            WriteLine("[ 2 ] = List by product group");
            WriteLine("[ 3 ] = List products that are out of stock");
            WriteLine("[ 4 ] = Add or delete product comments.");
            WriteLine("[ 5 ] = Change stock and price values.");
            WriteLine("[ 6 ] = Close Program.");
            var action = ReadLine();
            return action;
        }
    }
}