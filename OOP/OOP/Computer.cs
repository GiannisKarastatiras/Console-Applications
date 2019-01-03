using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Computer : Hardware
    {
        public string CPUType { get; set; }
        public string Disks { get; set; }

        public override void Purchase()   
        {
            base.Purchase();
            Console.WriteLine($"My CPUType is {CPUType}");
        }
    }
}
