// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a variable containing all the letters in the alphabet.
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            
            // Ask user to input a sentence/string to check if it is a pangram and save it to variable.
            Console.WriteLine("Please enter a string to check if it is a pangram");
            string userInput = Console.ReadLine();


            // Set counter 
            int count = 0;

            /* Create 2 nested foreach loops to iterate through alpha variable and inner loop to iterate through user input to check if they are the same.
              If they match add to counter. */ 
            foreach (char c in alpha)
            {
                foreach (char l in userInput.ToLower())
                {
                    if (c == l)
                    {
                        count++;
                        break;
                    }
                }
            }

            // If statement if counter is 26 then all letters in the alphabet have been used.
            if (count == 26)
            {
                Console.WriteLine("This sentence is a pangram");
            }
            else
            {
                Console.WriteLine("Sorry this is not a pangram");
            }

            Console.ReadLine();
        }
    }
}
