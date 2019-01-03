using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperBoy
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Customer customer = new Customer()
            {
                FirstName = "Peri",
                LastName = "Aidinopoulos",
                Wallet = new Wallet()
                {
                    Value = 45.6f
                }
                
            };

            customer.Wallet.AddMoney(12);
            Console.WriteLine(customer.Wallet.Value);

            PaperBoy ppBoy = new PaperBoy();
            ppBoy.SellPaper(customer);

            Console.WriteLine(customer.Wallet.Value);
        }
    }
}
