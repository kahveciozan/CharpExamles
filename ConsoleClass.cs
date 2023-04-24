using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    public class ConsoleClass
    {
        public ConsoleClass() 
        {
            Console.WriteLine("\n --- Console class and its methıds ---");


            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Beep();

            Console.WriteLine("Windows Height:" + Console.WindowHeight);
            Console.WriteLine("Windows Height:" + Console.WindowWidth);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Largest Windows Height:" + Console.LargestWindowHeight);
            Console.WriteLine("Largest Windows Height:" + Console.LargestWindowWidth);


            Console.CancelKeyPress += (x, y) =>
            {
                Console.WriteLine("The input was canceled");        // ctrl + c
            };

            Console.WriteLine("\nWhat is Your Age: ");
            string inputAge = Console.ReadLine() ?? string.Empty;
            Console.WriteLine($"The Age entered was: {inputAge}");
            

        }








    }
}
