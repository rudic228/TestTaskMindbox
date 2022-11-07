using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Figure
{
    public class Circle : IFigure
    {
        private readonly double Pi = 3.14;
        private double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Radius*Radius*Pi;
        }
    }
}
