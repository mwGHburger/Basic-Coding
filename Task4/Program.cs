using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            for(int number = 1; number <= input; number++ )
            {
                total += number;
            }
            Console.WriteLine($"The sum of 1 to {input} is {total}.");
        }
    }
}
