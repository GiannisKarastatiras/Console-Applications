using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        public void DescribeCar()
        {
            Console.WriteLine("Four wheels and an engine");
            ShowDetails();
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("Standard Transportation");
        }
    }
}
