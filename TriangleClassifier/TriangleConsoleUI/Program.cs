using GeometricObjects;
using System;

namespace TriangleConsoleUI
{
    public class Program
    {
        static public void Main(string[] args)
        {
            double validatedInput;

            Console.WriteLine(UIPrompts.Welcome);

            validatedInput = GetASide(UIPrompts.side1);
            validatedInput = GetASide(UIPrompts.side2);
            validatedInput = GetASide(UIPrompts.side3);

            Console.WriteLine("Not a hotdog!");
            Console.WriteLine(UIPrompts.exit);
            Console.ReadLine();
        }

        static double GetASide(string prompt)
        {
            string input;
            double validatedInput;

            Console.Write(prompt);
            input = Console.ReadLine();

            while (!Shape.IsSideValid(input))
            {
                Console.WriteLine(UIPrompts.invalidInput);
                Console.Write(prompt);
                input = Console.ReadLine();
            }
            validatedInput = double.Parse(input);
            return validatedInput;
        }
    }
}
