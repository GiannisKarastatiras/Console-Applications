using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Hardware : Item
    {
        public string SerialNumber { get; set; }

        public override void Purchase()        
        {
            base.Purchase();
            Console.WriteLine($"My serial number is {SerialNumber}");
        }
    }
}
