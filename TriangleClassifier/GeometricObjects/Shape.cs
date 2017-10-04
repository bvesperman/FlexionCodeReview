using System;
using System.Collections.Generic;

namespace GeometricObjects
{
    public class Shape
    {
        protected List<double> _sides = new List<double>();


        static public bool IsSideValid(string side)
        {
            double sideVal;
            if (!double.TryParse(side,out sideVal))
            {
                return false;
            }
            return sideVal > 0.00001;

        }

        static public int IsDoubleEquals(double a, double b)
        {
            double difference = Math.Abs(a * 0.00001);
            return Convert.ToInt16( (Math.Abs(a - b) <= difference));
        }
    }
}
