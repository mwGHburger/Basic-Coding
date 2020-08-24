using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("I'm thinking of a number, can you guess it? ");
            int input = Convert.ToInt32(Console.ReadLine());
            int secret = rnd.Next(1,100);
            int count = 1;
            while( input != secret) {
                if (input > secret)
                {
                    Console.WriteLine("Your number is larger than what I'm thinking of...");
                }
                else
                {
                    Console.WriteLine("Your number is smaller than what I'm thinking of...");
                }
                Console.Write("Try guessing again: ");
                int previousGuess = input;
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
