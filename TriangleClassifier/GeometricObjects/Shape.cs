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
            return sideVal > 0.0000000000001;

        }
    }
}
