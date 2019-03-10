using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using static System.Console;

namespace ProductRegister
{
    class FileManager
    {
        private readonly string _filePath;

        public FileManager()
        {
            _filePath = @"C:\temp\items.json";
        }

        public string ListItems()
        {
            try
            {
                var contents = ReadFile();
                return contents;
            }
            catch (Exception ex) // exception message
            {
                return ex.Message;
            }
        }

//1---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string ReadFile()
        {
            if (File.Exists(_filePath)) // deserializing existing json file and contents
            {
                var itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(_filePath));
                foreach (var item in itemList)
                {
                    WriteLine();
                    WriteLine(
                        $"Product name: {item.Name}\nProduct number: {item.Id}\nProduct category: {item.GroupName}");
                }

                WriteLine();
                WriteLine("Press 1 for detailed information, press any other key to continue without information. ");
                var response = ReadLine()?.ToUpper();
                if (response == "1")
                {
                    WriteLine("Give the product number: ");
                    var inputId = ReadLine();
                    var found = false; // incorrect inputs not allowed

                    foreach (var item in itemList)
                    {
                        if (inputId != item.Id) continue;
                        found = true;
                        WriteLine(
                            $"Product name: {item.Name}\nProduct number: {item.Id}\nProduct category: {item.GroupName}\nPrice: {item.Price}\nAmount: {item.Amount}\nComment: {item.Comment}\n");
                    }

                    if (found != true) WriteLine("Bad input, please try again!");
                }
                else
                    WriteLine("Return to menu? Press any key to proceed.");
            }

            else if (!File.Exists(_filePath)) // Exception handler
            {
                throw new Exception("File not found.");
            }

            return "";
        }

//2-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string PrintProductGroup(string group)
        {
            var itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(_filePath));

            foreach (var item in itemList) // item listing 
            {
                switch (group)
                {
                    case "1":
                    {
                        if (item.GroupName == "Lajittelu ja säilytys")
                        {
                            WriteLine(
                                $"Product name: {item.Name}\nProduct number: {item.Id}\nProduct category: {item.GroupName}\nPrice: {item.Price}\nAmount: {item.Amount}\nComment: {item.Comment}\n");
                        }

                        break; // using breaks to avoid infinite loops and making the program working stable.
                    }
                    case "2":
                    {
                        if (item.GroupName == "Paperit ja lehtiöt")
                        {
                            return
                                $"Product name: {item.Name}\nProduct number: {item.Id}\nProduct category: {item.GroupName}\nPrice: {item.Price}\nAmount: {item.Amount}\nComment: {item.Comment}\n";
                        }

                        break;
                    }
                    case "3":
                    {
                        if (item.GroupName == "Kynät")
                        {
                            return
                                $"Product name: {item.Name}\nProduct number: {item.Id}\nProduct category: {item.GroupName}\nPrice: {item.Price}\nAmount: {item.Amount}\nComment: {item.Comment}\n";
                        }

                        break;
                    }
                    case "4":
                    {
                        if (item.GroupName == "Kortit ja kirjekuoret")
                        {
                            return
                                $"Product name: {item.Name}\nProduct number: {item.Id}\nProduct category: {item.GroupName}\nPrice: {item.Price}\nAmount: {item.Amount}\nComment: {item.Comment}\n";
                        }

                        break;
                    }
                    default:
                        return "Bad input, please try again.";
                }
            }

            return "";
        }

//3---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void OutOfStock() // Items that are ran out of stock
        {
            var itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(_filePath));
            foreach (var item in itemList)
            {
                if (item.Amount == 0)
                {
                    WriteLine(
                        $"Product name: {item.Name}\nProduct number: {item.Id}\nProduct category: {item.GroupName}\nPrice: {item.Price}\nAmount: {item.Amount}\nComment: {item.Comment}\n");
                }
            }
        }

//4-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void
            AddComment() // "method to add 'comments' on products, which basically means added or deleted information on the comment section.
        {
            var itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(_filePath));

            foreach (var item in itemList)
            {
                WriteLine($"{item.Name}:\t{item.Id}"); // shows item name and id number
            }

            WriteLine("Please choose item with the given product number.");
            var itemToNumber = ReadLine();
            var isFound = false;

            foreach (var item in itemList)
            {
                if (item.Id != itemToNumber) continue;
                isFound = true;

                WriteLine("Input A for Add comment or D for delete comments.");
                var choice = ReadLine()?.ToUpper();

                switch (choice)
                {
                    case "A":
                    {
                        WriteLine("Your comment: "); // add comments
                        var newComment = ReadLine();

                        if (item.Comment.Replace("   ", "") != newComment)

                        {
                            item.Comment += newComment + "   ";

                            File.WriteAllText(_filePath, JsonConvert.SerializeObject(itemList));
                            WriteLine($"Comment added successfully: {newComment}");
                        }
                        else if (item.Comment.Replace("   ", "") == newComment)
                        {
                            WriteLine(
                                "Cannot add the same comment twice, try something else."); // You must change new comments, even tho you want to add same comment twice.
                        }

                        break;
                    }
                    case "D": // 'delete' basically replaces old comments with an empty comment
                    {
                        WriteLine($"Deleted comment(s): {item.Comment}");
                        item.Comment = "";
                        File.WriteAllText(_filePath, JsonConvert.SerializeObject(itemList));
                        break;
                    }
                    default:
                    {
                        WriteLine("Bad input, please try again.");
                        break;
                    }
                }
            }

            if (isFound != true) // product can not be found if letters are incorrect
            {
                WriteLine("Product not found.");
            }
        }

//5-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void UpdateStockAndPrice() // method to change product's amount and price value
        {
            var itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(_filePath));
            foreach (var item in itemList)
            {
                WriteLine($"{item.Name}:\t{item.Id}"); // shows item name and id number
            }

            WriteLine("Please choose product with the given product number.");
            var itemToNumber = ReadLine();

            foreach (var item in itemList)
            {
                if (item.Id != itemToNumber) continue;
                const bool isFound = true;

                WriteLine("Input A for changing stock value, B for changing price value.");
                var choice = ReadLine()?.ToUpper();

                switch (choice) // some switch changes not updating in json
                {
                    case "A":
                    {
                        WriteLine("New product amount: "); // change product amount
                        ReadLine();
                        if (int.TryParse(ReadLine(), out var amount)
                        ) // HOX!Program asks information twice for some reason
                        {
                            item.Amount = amount;
                            WriteLine($"Product {item.Name} new stock amount is {item.Amount}.");
                            File.WriteAllText(_filePath, JsonConvert.SerializeObject(itemList)); // adds new amount
                            break;
                        }
                        else
                        {
                            WriteLine("An error has occured, input numbers only!");

                            break;
                        }
                    }
                    case "B":

                        WriteLine("New product stock price: "); // change product price
                        ReadLine();
                        if (int.TryParse(ReadLine(), out var price)
                        ) // HOX! You need to input numbers twice, second number is the registered input
                        {
                            item.Price = price;
                            WriteLine($"Product {item.Name} new stock price is {item.Price}.");
                            File.WriteAllText(_filePath, JsonConvert.SerializeObject(itemList)); // adds new price
                            break;
                        }
                        else

                        {
                            WriteLine("An error has occured, input numbers only!");

                            break;
                        }

                        if (isFound == true) return;
                        WriteLine("Product not found.");
                }
            }
        }
    }
}
