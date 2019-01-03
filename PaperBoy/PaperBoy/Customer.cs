using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperBoy
{
    class Customer 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Wallet Wallet { get; set; }

        public Customer()
        {
        }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
