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

            side1 = GetASide(UIPrompts.side1);
            side2 = GetASide(UIPrompts.side2);
            side3 = GetASide(UIPrompts.side3);


            Triangle myTri = new Triangle(side1, side2, side3);

            Console.WriteLine("This triangle is classified as: " + myTri.Type.ToString());
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
