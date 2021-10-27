using System;
using System.IO;
namespace ReadingFormFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\wishList";
            string userFile = "WishList";
            string fullFilePath = $@"{rootDirectory}\{userFile}.txt";

            string[] dataFormFile = File.ReadAllLines(fullFilePath);

            foreach(string line in dataFormFile)
            {
                Console.WriteLine(line);
            }

            dataFormFile[0] = "AFB";

            foreach (string line in dataFormFile)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines(fullFilePath, dataFormFile);

        } 
    }
}
