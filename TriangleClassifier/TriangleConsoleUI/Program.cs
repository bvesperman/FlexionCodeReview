using System;

namespace TriangleConsoleUI
{
    public class Program
    {
        static public void Main(string[] args)
        {
            string input;
            decimal validatedInput;

            Console.WriteLine(UIPrompts.Welcome);

            validatedInput = GetASide(UIPrompts.side1);

            //Console.Write(UIPrompts.side1);
            //input = Console.ReadLine();

            //while(!decimal.TryParse(input, out validatedInput))
            //{
            //    Console.WriteLine(UIPrompts.invalidInput);
            //    Console.Write(UIPrompts.side1);
            //    input = Console.ReadLine();
            //}

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
            Console.ReadLine();
        }

        static decimal GetASide(string prompt)
        {
            string input;
            decimal validatedInput;

            Console.Write(prompt);
            input = Console.ReadLine();

            while (!decimal.TryParse(input, out validatedInput))
            {
                Console.WriteLine(UIPrompts.invalidInput);
                Console.Write(prompt);
                input = Console.ReadLine();
            }

            return validatedInput;
        }
    }
}
