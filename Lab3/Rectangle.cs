using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    internal class Rectangle
    {
        double result1;
        double result2;
        private double side1;
        private double side2;

        public double Area { get { return result2; } }
        public double Perimeter { get { return result1; } }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
         
        public double PerimeterCalculator() 
        {
            result1 = (2d * side1) + (side2 * 2d);
            return result1;
        }

        public double AreaCalculator()
        {
            result2 = side1 * side2;
            return result2;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" Площа прямокутника: {Area}");
            Console.WriteLine($" Периметр прямокутника: {Perimeter}");
        }
    }
}
