using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Random
            //Random randomNumber = new Random();
            //Console.WriteLine(randomNumber.Next(0,4));

            Random randomNumber = new Random();
            int randy = randomNumber.Next(0, 4);  //to store random number as a variable
            Console.WriteLine(randy);

            string[] words = { "Paper", "Scissors", "Rock" };
            Console.WriteLine(words[randomNumber.Next(0,3)]);  //to randomly select index of 0, 1, or 2

            int[] numbers = { 1, 2, 3, 76, 6 };
            Console.WriteLine(numbers[randomNumber.Next(0,5)]);

            string sayings = "You can never have too much cake.";
            Console.WriteLine(sayings[randomNumber.Next(0, sayings.Length)]);  //length not 0 indexed so don't need to adjust for .Next being exclusive
        }
    }
}
