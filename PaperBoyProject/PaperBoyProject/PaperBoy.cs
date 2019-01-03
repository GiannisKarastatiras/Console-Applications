using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperBoyProject
{
    class PaperBoy
    {
        public void SellPaper(Customer customer)
        {
            var payment = 2.0f;
            var customerWalletValue = customer.PayAmount(payment);

            
        }
    }
}
