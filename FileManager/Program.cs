using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            FileManager fileManager = new FileManager();

            Console.WriteLine(fileManager.ReadWords());

            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
    }
}