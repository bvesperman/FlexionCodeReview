using System;
using System.Collections.Generic;

namespace GeometricObjects
{
    /// <summary>
    /// Class that represents a base generic geometric shape. 
    /// </summary>
    public class Shape
    {
        protected List<double> _sides = new List<double>();

        /// <summary>
        /// A check to see if a string representing a side of a shape is a valid double
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        static public bool IsSideValid(string side)
        {
            double sideVal;
            if (!double.TryParse(side,out sideVal))
            {
                return false;
            }
            return sideVal > 0.00001;

        }

        /// <summary>
        /// compares two doubles within a predefined variance
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns> 1 it equal 0 in not</returns>
        static public int IsDoubleEquals(double a, double b)
        {
            double difference = Math.Abs(a * 0.00001);
            return Convert.ToInt16( (Math.Abs(a - b) <= difference));
        }
    }
}
