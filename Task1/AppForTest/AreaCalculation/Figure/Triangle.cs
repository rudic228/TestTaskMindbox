using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Figure
{
    public class Triangle : IFigure
    {
        private List<double> Sides = new List<double>();

        public Triangle(double side1, double side2, double side3)
        {
            Sides.AddRange(new List<double>() { side1, side2, side3 });
        }
        public double CalculateArea()
        {
            if(Sides[0]>=Sides[1]+Sides[2] || //Checking the existence of a triangle
                Sides[1] >= Sides[0] + Sides[2]||
                Sides[2] >= Sides[1] + Sides[0])
            {
                throw new Exception("Такой треугольник не может существовать");
            }
            if((int)Sides[0]*Sides[0] == (int)Sides[1]*Sides[1] + (int)Sides[2] * Sides[2])//3 checks for squareness
            {
                return Sides[1] * Sides[2] / 2;
            }
            if((int)Sides[1] * Sides[1] == (int)Sides[0] * Sides[0] + (int)Sides[2] * Sides[2])
            {
                return Sides[0] * Sides[2] / 2;
            }
            if ((int)Sides[2] * Sides[2] == (int)Sides[1] * Sides[1] + (int)Sides[0] * Sides[0])
            {
                return Sides[1] * Sides[0] / 2;
            }
            double halfMeter = (Sides[0]+Sides[1]+Sides[2])/2;
            double forSqrt = halfMeter * (halfMeter - Sides[0]) *
                (halfMeter - Sides[1]) *
                (halfMeter - Sides[2]);
            return Math.Sqrt(forSqrt);

        }
    }
}
