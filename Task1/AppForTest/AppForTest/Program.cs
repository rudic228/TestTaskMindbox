using AreaCalculation;
using AreaCalculation.Figure;
using System;
using System.Drawing;

namespace AppForTest
{
    internal class Program
    {
        private static Random rand = new Random();
        static void Main(string[] args)
        {
            for(int i = 0; i < rand.Next(3,6); i++)
            {
                IFigure figure;
                int circleOrTriangle = rand.Next(0, 2);
                if(circleOrTriangle == 0)
                {
                    int side1 = rand.Next(6, 11);
                    int side2 = rand.Next(5, 12);
                    int side3 = rand.Next(8, 15);
                    figure = new Triangle(side1,side2,side3);
                    double place = figure.CalculateArea();
                    Console.WriteLine("Площадь треугольника со сторонами : "+side1
                        +" "+side2+" "+side3 + " Равна :"+Math.Round(place));
                    
                }
                if(circleOrTriangle == 1)
                {
                    int rad = rand.Next(5, 15);
                    figure = new Circle(rad);
                    double place = figure.CalculateArea();
                    Console.WriteLine("Площадь круга с радиусом: " + rad +  " Равна :" + Math.Round(place));
                }
            }
        }
    }
}
