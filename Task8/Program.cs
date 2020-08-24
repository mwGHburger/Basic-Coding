using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number, can you guess it? ");
            int input = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int secret = rnd.Next(1,100);
            int count = 1;
            while( input != secret) {
                if (input > secret)
                {
                    Console.WriteLine("Your number is LARGER than what I'm thinking of...");
                }
                else
                {
                    Console.WriteLine("Your number is SMALLER than what I'm thinking of...");
                }
                int previousGuess = input;
                Console.Write("Try guessing again: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input != previousGuess)
                {
                    count++;
                }
            }
            Console.WriteLine($"Correct! You guess that correct number and it took you {count} tries.");
        }
    }
}
