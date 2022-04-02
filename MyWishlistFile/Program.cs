using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyWishlistFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Sander\Samples\wishlist";
            string fileName = @"\\myWishlist.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");

            List<string> myWishlist = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a wish? Y/N:");
                Char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userInput == 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    myWishlist.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }

            }

            Console.Clear();

            foreach(string wish in myWishlist)
            {
                Console.WriteLine($"Your wish: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myWishlist);


            //foreach(string element in arrayFromFile)
            //{
            //    Console.WriteLine(element);
            //}
        }
    }
}
