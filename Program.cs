﻿using LeaningCsharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter id");

            if (Int32.TryParse(Console.ReadLine(), out int number))
            {
                CollectionOfItems collection = new CollectionOfItems();
                collection.CheckIfNumberExists(number);
            }
            else
            {
                Console.WriteLine("Entry could not be parsed.");
            }
        }
    }
}
