using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperBoyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            float walletValue = customer.PayAmount(12);

            PaperBoy ppBoy = new PaperBoy();
            ppBoy.SellPaper(customer);

            Console.WriteLine(customer);

            Customer customer2 = new Customer("Giannis", "Karastatiras", new Wallet(65f));
            ppBoy.SellPaper(customer2);
            Console.WriteLine(customer2);
        }                     
    }
}
