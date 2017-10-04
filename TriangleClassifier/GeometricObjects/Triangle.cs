using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Triangle: Shape
    {
        protected List<double> _angles = new List<double>();

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sides.Add(sideA);
            _sides.Add(sideB);
            _sides.Add(sideC);
        }

        public void CalculateAngles()
        {
            _angles.Add(solveAngleFromSides(_sides[0], _sides[1], _sides[2]));
        }

        private double solveAngleFromSides(double sideA, double sideB, double sideC)
        {
            double numerator = Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - Math.Pow(sideA, 2);
            double denominator = 2 * sideB * sideC;

            double angle = Math.Acos(numerator/ denominator);

            return angle;
        }
    }
}
