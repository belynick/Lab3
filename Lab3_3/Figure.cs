using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    internal class Figure
    {
        public enum Figures
        {
            Triangle = 3,
            Quadrilateral = 4,
            Pentagon = 5
        }

        public void InitializeFigure()
        {
            Random random = new Random();
            int pointsQuantity = random.Next(3, 6);
            points = new Point[pointsQuantity];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }
        }

        private Point[] points;
        private string name;

        public Figure()
        {
            InitializeFigure();
            name = Enum.GetName(typeof(Figures), points.Length);
        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Perimetr: {perimeter}");
        }
       
    }
}
