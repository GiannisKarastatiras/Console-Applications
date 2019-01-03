using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingOverriding
{
    class DerivedClass : BaseClass
    {
        public override void Method2()
        {
            Console.WriteLine("DerivedClass-Method2");
        }

        
    }
}
