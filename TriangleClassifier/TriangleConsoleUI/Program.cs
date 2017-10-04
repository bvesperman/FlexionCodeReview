using System;

namespace TriangleConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            decimal validatedInput;
            //Console.WriteLine("Welcome To Triangle Validator!");
            //Console.WriteLine("");
            //Console.WriteLine("Please enter the lengths of three sides of a triangle and the system will respond with the type of triangle.");
            //Console.WriteLine("   We assume the same units for each side. So only enter decimal numbers.");

            Console.WriteLine(UIPrompts.Welcome);

            Console.Write("Side 1: ");
            input = Console.ReadLine();

            decimal.TryParse(input, out validatedInput);
            Console.Write("Side 2: ");
            input = Console.ReadLine();
            Console.Write("Side 3: ");
            input = Console.ReadLine();
            Console.WriteLine("Not a hotdog!");
            Console.WriteLine("(Press and key to exit)");
            Console.ReadKey();
        }
    }
}
