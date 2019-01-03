using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperBoyProject
{
    class Customer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private Wallet _wallet;         

        public Customer()
        {
            FirstName = "Peri";
            LastName = "Aidino";
            _wallet = new Wallet(20.0f);
        }

        public Customer(string firstName, string lastName, Wallet wallet)
        {
            FirstName = firstName;
            LastName = lastName;
            _wallet = wallet;
        }

        public float PayAmount(float amountToPay)
        {
            if (_wallet == null)
                throw new ArgumentNullException("_wallet", "Wallet should not be null");

            if (_wallet.Value >= amountToPay)
            {
                _wallet.SubMoney(amountToPay);
                //return _wallet.Value
            }
            return _wallet.Value;
        }

        public override string ToString()       
        {
            return FirstName + " " + LastName + ": " + _wallet.Value;
        }
    }
}
