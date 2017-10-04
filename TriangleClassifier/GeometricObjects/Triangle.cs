using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Triangle: Shape
    {
        private TriangleTypes _type;
        protected List<double> _angles = new List<double>();

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sides.Add(sideA);
            _sides.Add(sideB);
            _sides.Add(sideC);

            CalculateAngles();

            determineTriangleType();
        }

        public void CalculateAngles()
        {
            _angles.Add(solveAngleFromSides(_sides[0], _sides[1], _sides[2]));
            _angles.Add(solveAngleFromSides(_sides[1], _sides[2], _sides[0]));
            _angles.Add(solveAngleFromSides(_sides[2], _sides[0], _sides[1]));
        }

        public TriangleTypes Type
        {
            get { return _type; }
        }


        public  bool IsValidTriangle()
        {
            double total = 0.0;
            foreach(double angle in _angles)
            {
                total += angle;
            }

            return (total < 180.0000001 && total > 179.99999);
        }

        /// <summary>
        /// calculates the angle of the triangle that is between sides b and c
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns>the Angle in degrees</returns>
        private double solveAngleFromSides(double sideA, double sideB, double sideC)
        {
            double numerator = Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - Math.Pow(sideA, 2);
            double denominator = 2 * sideB * sideC;

            double angle = Math.Acos(numerator / denominator) * (180 / Math.PI);

            return angle;
        }

        private void determineTriangleType()
        {
           int totalEqualSides = IsDoubleEquals(_sides[0], _sides[1]) + IsDoubleEquals(_sides[1], _sides[2]) + IsDoubleEquals(_sides[2], _sides[0]);
            switch(totalEqualSides)
            {
                case 0:
                    _type = TriangleTypes.Scalene;
                    break;
                case 1:
                    _type = TriangleTypes.Isosceles;
                    break;
                case 3:
                    _type = TriangleTypes.Equilateral;
                    break; 
            }

            if (double.IsNaN(_angles[0]) || double.IsNaN(_angles[1]) || double.IsNaN(_angles[2]))
                _type = TriangleTypes.NotATriangle;
        }

        
    }
}
