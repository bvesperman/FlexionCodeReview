using GeometricObjects;
using System;

namespace TriangleConsoleUI
{
    public class Program
    {
        static public void Main(string[] args)
        {
            double side1, side2, side3;

            Console.WriteLine(UIPrompts.Welcome);

            // collect the sides of the triangle from the user
            side1 = GetASide(UIPrompts.side1);
            side2 = GetASide(UIPrompts.side2);
            side3 = GetASide(UIPrompts.side3);

            Triangle myTri = new Triangle(side1, side2, side3);

            Console.WriteLine(UIPrompts.TriangleDescription + myTri.Type.ToString());
            Console.WriteLine(UIPrompts.exit);
            Console.ReadLine();
        }

        /// <summary>
        /// get the sides of the triangle from the user and does some basic checking and prompting of the user
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns>a side of the triangle</returns>
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
