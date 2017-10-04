using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleConsoleUI
{
    /// <summary>
    /// Resources to simplify the UI elements.
    /// </summary>
    public static class UIPrompts
    {
        public const string Welcome =
@"Welcome To Triangle Validator!

Please enter the lengths of three sides of a triangle and the system will respond with the type of triangle.
   We assume the same units for each side. So only enter decimal numbers.";

        public const string exit = @"(Press enter key to exit)";

        public const string side1 = @"Side 1: ";
        public const string side2 = @"Side 2: ";
        public const string side3 = @"Side 3: ";

        public const string TriangleDescription = @"This triangle is classified as: ";

        public const string invalidInput = @"INVALID VALUE! - examples of valid input: 1 , 1.0, 1.11111111";
    }
}
