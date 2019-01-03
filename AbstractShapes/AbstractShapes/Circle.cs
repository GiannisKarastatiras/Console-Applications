using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{
    class Circle : Shape
    {
        private int radius;

        public override double Area
        {
            get
            {
                return radius * radius * System.Math.PI;
            }
        }

        public Circle(int radius, string Id):
            base(Id)
        {
            this.radius = radius;
        }
    }
}
