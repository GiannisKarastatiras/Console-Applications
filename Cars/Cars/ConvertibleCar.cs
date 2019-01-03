using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class ConvertibleCar : Car
    {
        //versioning with new keyword
        public new void ShowDetails()
        {
            Console.WriteLine("A roof that opens up.");
        }
    }
}
