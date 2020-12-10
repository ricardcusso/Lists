using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var isUserFinished = false;
            var namesList = new List<string>();

            Console.WriteLine("Enter the names of your friends. When finished, press Enter.");

            while(!isUserFinished)
            {
                if(Console.ReadLine() == "")
                {
                    isUserFinished = true;
                    break;
                }
                else
                {
                    namesList.Add(Console.ReadLine());
                }
            }

            if(namesList.Count == 0)
            {
                Console.WriteLine(namesList.Count);
                Console.WriteLine("You have no friends, loser.");
                return;
            }

            else if(namesList.Count == 1)
            {
                Console.WriteLine(namesList.Count);
                Console.WriteLine($"{namesList[0]} is your friend.");
                return;
            }

            else if(namesList.Count == 2)
            {
                Console.WriteLine(namesList.Count);
                Console.WriteLine($"{namesList[0]} and {namesList[1]} are your friends.");
                return;
            }

            else
            {
                Console.WriteLine(namesList.Count);
                Console.WriteLine($"{namesList[0]}, {namesList[1]} and {(namesList.Count) - 2} others are your friends.");
                return;
            }
        }
    }
}
