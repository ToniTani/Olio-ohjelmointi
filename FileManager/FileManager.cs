using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace FileManager
{
    // Tulostetaan viesti jos tiedostoa ei loydy
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {
        }
    }
 
    class FileManager
    {
        private string filePath;
        public FileManager()
        {
            this.filePath = @"C:\Users\grimr\source\repos\FileManager\computer.json";
        }

        public string ReadWords()
        {
            string content = String.Empty;
            try
            {
                content = ReadFile();
                return content;
            }
            catch (WordListNotFoundException ex)
            {
                return ex.Message;
            }
            catch (FileNotFoundException ex)
            {
                return ex.Message;
            }
        }

        private string ReadFile()
        {
            if (File.Exists(filePath)) // Listing the json file
            {
                List<Computer> computerList = JsonConvert.DeserializeObject<List<Computer>>(File.ReadAllText(this.filePath));
                Console.WriteLine($"There are {computerList.Count} computers on the list.");
                foreach (Computer computer in computerList)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Amount: {computer.Amount} \nType: {computer.Type}\nModel: {computer.Model}\nColour: {computer.Colour} \nGPU: {computer.Gpu} \nPrice: {computer.Price}€");
                }
            }

            else if (!File.Exists(filePath))
            {
                throw new WordListNotFoundException("File not found."); // if the file cannot be found
            }

            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            Console.WriteLine();
            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            return "";
        }
    }
}