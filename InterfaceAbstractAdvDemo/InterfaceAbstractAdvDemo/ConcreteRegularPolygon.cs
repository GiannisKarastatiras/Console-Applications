using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractAdvDemo
{
    public class ConcreteRegularPolygon
    {
        public int NumSides { get; set; }
        public int SideLength { get; set; }

        public ConcreteRegularPolygon(int numSides, int sideLength)
        {
            NumSides = numSides;
            SideLength = sideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }

        public double GetPerimeter()
        {
            return SideLength * NumSides;
        }
    }
}
