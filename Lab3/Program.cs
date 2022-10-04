using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть сторони прямокутника: ");

            Console.WriteLine("сторона a: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("сторона b: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            rectangle.AreaCalculator();

            rectangle.PerimeterCalculator();

            rectangle.PrintInfo();

            Console.ReadLine();
        }
    }
}
