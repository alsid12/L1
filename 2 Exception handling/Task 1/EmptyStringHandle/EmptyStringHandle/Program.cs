using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyStringHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyPressed = new ConsoleKeyInfo();
            Console.WriteLine("Hello {0}!", System.Environment.UserName);
            
            do
            {
                Console.WriteLine("Please, enter your location:");
                string location = Console.ReadLine();
                try
                {
                    Console.WriteLine("The first letter is: {0}.",location[0]);
                    Console.WriteLine("Press Enter to continue or hit Escape button to exit.");
                    keyPressed = Console.ReadKey();
                    if (keyPressed.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message + " Cannot process empty string. Please try again or hit Escape button to exit.");
                    Console.WriteLine("Press Enter to continue or hit Escape button to exit.");
                    keyPressed = Console.ReadKey();
                    if (keyPressed.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            } while (keyPressed.Key != ConsoleKey.Escape);

        }
    }
}
