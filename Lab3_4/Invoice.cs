using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4
{
    internal class Invoice
    {
        public readonly int Account;
        public readonly string Customer;
        public readonly string Provider;

        private string _article = String.Empty;
        private int _quantity;

        public string Article { get { return _article; } set { _article = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public Invoice(int account, string customer, string provider, string article, int quantity) : this(account, customer, provider)
        {
            _article = article;
            _quantity = quantity;
        }

        public double GetAccountWithNds(double nds = 0.2)
        {
            return Account + (Account * nds);
        }

        public void PrintInfo()
        {
            Console.WriteLine($" {Customer} замовив у {Provider} {_quantity} {_article} на суму," +
                $"\n що становить {Account} грн без ПДВ, та {GetAccountWithNds()} грн з ПДВ");
        }
    }
}
