using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractAdvDemo
{
    public abstract class AbstractRegularPolygon
    {
        public int NumSides { get; set; } // automatic creation property -- implemetation
        public int SideLength { get; set; }

        public AbstractRegularPolygon(int numSides, int sideLength)
        {
            NumSides = numSides;
            SideLength = sideLength;
        }

        public abstract double GetArea();

        public double GetPerimeter()
        {
            return SideLength * NumSides;
        }
    }
}
