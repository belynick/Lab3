using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    internal class Title
    {
        string title = "Аліса в країні див";
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Назва книги: {title}");
        }
    }
}
