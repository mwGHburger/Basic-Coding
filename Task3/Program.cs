using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            if (name == "Alice" || name == "Bob")
            {
                Console.WriteLine($"Hey {name}!");
            }
            else
            {
                Console.WriteLine("Go away!");
            }
        }
    }
}
