using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    internal class Point
    {
        private int x;
        private int y;
        private string name;

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Name { get { return name; } }

        public Point()
           : this("", 0, 0) { }

        public Point(string name, int x, int y)
        {
            Random random = new Random();
            Console.WriteLine("Enter a letter of Point:");
            this.name = Console.ReadLine();
            this.x = random.Next(-10, 10);
            this.y = random.Next(-10, 10);
        }
    
    }
}
