using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAdvancedDemo
{
    interface Printable
    {
        int Status { get; }
        void Print(); // access modifier public by default

    }
}
