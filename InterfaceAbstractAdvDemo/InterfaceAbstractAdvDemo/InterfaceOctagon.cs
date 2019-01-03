using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractAdvDemo
{
    public class InterfaceOctagon : IRegularPolygon
    {
        public int NumSides { get; set; }
        public int SideLength { get; set; }

        public InterfaceOctagon(int sideLength)
        {
            NumSides = 8;
            SideLength = sideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }

        public double GetPerimeter()
        {
            return SideLength * NumSides;
        }
    }
}
