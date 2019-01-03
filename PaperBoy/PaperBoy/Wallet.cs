using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperBoy
{
    class Wallet
    {
        public float Value { get; set; }

        public void AddMoney(float amount)
        {
            Value += amount;  
        }

        public void SubMoney(float amount)
        {
            Value -= amount;
        }
    }
}
