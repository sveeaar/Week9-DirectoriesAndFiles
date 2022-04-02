using System;
using System.IO;

namespace DirectoriesAndFilesShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\Sander\Samples";

            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine();

            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();

            if (Directory.Exists($"{rootDirectory}\\{newDirectory}"))
            {
                Console.WriteLine($"Directory {newDirectory} exists at {rootDirectory}");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
            }

            if (File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"File {fileName} exists at {newDirectory}");
            }
            else
            {
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }

        }
    }
}
