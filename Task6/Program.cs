using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide a number: ");
            int numInput = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Do you want the sum or the product of the number 1 to {numInput}? Type either sum or product: ");
            string decision = Console.ReadLine();
            int total = 0;
            if(decision == "sum")
            {
                for(int number = 1; number <= numInput; number++)
                {
                    total += number;
                }
            }
            else if (decision == "product")
            {
                total = 1;
                for(int number = 1; number <= numInput; number++)
                {
                    total *= number;
                }
            }
            else
            {
                Console.WriteLine("You have entered an invalid input!");
                return;
            }
            Console.WriteLine($"The total is {total}.");
        }
    }
}
