using System;

namespace TriangleConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            decimal validatedInput;

            Console.WriteLine(UIPrompts.Welcome);

            Console.Write(UIPrompts.side1);
            input = Console.ReadLine();

            while(!decimal.TryParse(input, out validatedInput))
            {
                Console.WriteLine(UIPrompts.invalidInput);
                Console.Write(UIPrompts.side1);
                input = Console.ReadLine();
            }

            Console.Write(UIPrompts.side2);
            input = Console.ReadLine();

            while (!decimal.TryParse(input, out validatedInput))
            {
                Console.WriteLine(UIPrompts.invalidInput);
                Console.Write(UIPrompts.side2);
                input = Console.ReadLine();
            }

            Console.Write(UIPrompts.side3);

            input = Console.ReadLine();
            while (!decimal.TryParse(input, out validatedInput))
            {
                Console.WriteLine(UIPrompts.invalidInput);
                Console.Write(UIPrompts.side3);
                input = Console.ReadLine();
            }

            Console.WriteLine("Not a hotdog!");
            Console.WriteLine(UIPrompts.exit);
            Console.ReadKey();
        }
    }
}
