using System;
using System.Collections.Generic;
namespace Wishlist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishlist = new List<string>();

            Console.WriteLine(myWishlist.Count);

            myWishlist.Add("coffee machine");
            myWishlist.Add("new socks");
            myWishlist.Add("bicycle");
            myWishlist.Add("box of chocolates");
            myWishlist.Add("running shoes");

            Console.WriteLine(myWishlist.Count);

            //Console.WriteLine(myWishlist[0]);
            //Console.WriteLine(myWishlist[1]);
            //Console.WriteLine(myWishlist[2]);
            //Console.WriteLine(myWishlist[3]);
            //Console.WriteLine(myWishlist[4]);

            foreach(string wish in myWishlist)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
