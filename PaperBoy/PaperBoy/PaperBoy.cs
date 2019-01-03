using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperBoy
{
    class PaperBoy
    {
        public float SellPaper(Customer customer)
        {
            var payment = 2.0f;     // f----> float  //
            var wallet = customer.Wallet;
            
            if (wallet != null)
            {
                wallet.SubMoney(payment);
            }
            else
            {
                ///come back later
            }
            return wallet.Value;
        }
    }
}
