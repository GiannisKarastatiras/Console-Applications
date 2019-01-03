using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Software : Item           //  Software is an item.
    {
        public string ISBN { get; set; }

        public override void Purchase()
        {
            //base.Purchase();              
            Console.WriteLine($"My ISBN is {ISBN}");
        }
    }
}
