using System;

namespace ConsoleApp1
{
    internal class Console_App
    {
        private static void Main(string[] args)
        {
            //if (args.Length == 0)
            //    {
            //        Console.WriteLine("Please enter your name.");
            //        args[0] = Console.ReadLine();
            //    }
            Console.WriteLine("Hello, {0}!", args[0]);
            Console.ReadKey();
        }
    }
}