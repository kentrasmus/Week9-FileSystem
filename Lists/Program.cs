using System;
using System.Collections.Generic;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishes = new list<string>();
            myWishes.Add("new pillow");
            myWishes.Add("box of shit");
            myWishes.Add("free primogems");

            int listLenght = myWishes.Count;

            Console.WriteLine($"List Length: {listLenght}");

            //Console.WriteLine(myWishes[0]);
            //Console.WriteLine(myWishes[1]);
            //Console.WriteLine(myWishes[2]);

            foreach (string wish in myWishes)
            {
                Console.WriteLine($"you wish for : {wish}");
            }
        }
    }
}
