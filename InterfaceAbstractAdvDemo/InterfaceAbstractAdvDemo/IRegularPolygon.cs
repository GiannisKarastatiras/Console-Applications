using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractAdvDemo
{
    interface IRegularPolygon
    {
        int NumSides { get; set; } //declaration and not implementation
        int SideLength { get; set; }

        double GetArea();
        double GetPerimeter();
    }
}
