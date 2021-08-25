using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
        }
        static void Exercise1()
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = 0;
            Console.WriteLine("Guess what my favorite number is");
            do
            {
                userInput = int.Parse(Console.ReadLine());
                if (userInput < favNumber)
                {
                    Console.WriteLine("Too Low!");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else if (userInput == favNumber)
                {
                    Console.WriteLine("Yeah that's it!!");
                }
                else
                {
                    Console.WriteLine("Nevermind");
                }
            } while (userInput != favNumber);
        }
        static void Exercise2()
        {
            Console.WriteLine("What's your favorite subject?");
            var subject = Console.ReadLine().ToLower();

            switch (subject)
            {
                case "math":
                    Console.WriteLine("You like numbers huh?");
                    break;
                case "science":
                    Console.WriteLine("You like space huh?");
                    break;
                case "history":
                    Console.WriteLine("You like old things huh?");
                    break;
                case "gym":
                    Console.WriteLine("You like running huh?");
                    break;
                case "english":
                    Console.WriteLine("You like writing huh?");
                    break;
                default:
                    Console.WriteLine("That subject is preetty cool");
                    break;
            }
        }
    }
}
