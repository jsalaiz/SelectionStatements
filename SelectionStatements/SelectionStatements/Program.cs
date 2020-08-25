using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;
            Console.WriteLine("Guess what my favorite number is: ");

            do
            {
                userInput = int.Parse(Console.ReadLine());

                //These are non user related ways to get the correct numbers
                //userInput = r.Next(1, 1000);
                /*if (userInput < favNumber)
                {
                    userInput++;
                }
                else if (userInput > favNumber)
                {
                    userInput -= 100;
                } */

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine($"{userInput} is the right number!");
                }
            } while (userInput != favNumber);
        }
    }
}
