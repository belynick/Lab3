using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1600, "Customer", "Provider")
            {
                Quantity = 15,
                Article = "Article"
            };
            invoice.GetAccountWithNds();
            invoice.PrintInfo();

            Console.ReadLine();
        }
    }
}
