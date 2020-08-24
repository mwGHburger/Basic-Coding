using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing multiplication table for numbers up to 12: \n");
            
            for(int firstNumber = 1; firstNumber <= 12; firstNumber++)
            {
                for(int secondNumber = 1; secondNumber <= 12; secondNumber++)
                {
                    Console.WriteLine($"{firstNumber} x {secondNumber} = {firstNumber * secondNumber}");
                }
                Console.Write("\n");
            }
        }
    }
}
