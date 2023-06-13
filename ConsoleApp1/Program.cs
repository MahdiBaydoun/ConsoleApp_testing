using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Console App!");

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! Nice to meet you.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
} 
