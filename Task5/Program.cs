using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            for(int number = 1; number <= input; number++)
            {
                if (number % 3 == 0 || number % 5 == 0)
                {
                    total += number;
                    Console.Write($"{number}, ");
                }
            }
            Console.WriteLine($"\nThe sum of the numbers 1 to {input}, where the numbers are a multiple of 3 or 5 is {total}.");

        }
    }
}
