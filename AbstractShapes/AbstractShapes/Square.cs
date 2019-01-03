using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{
    class Square : Shape
    {
        private int side;

        public override double Area
        {
            get
            {
                return side * side;
            }
        }

        public Square(int side, string Id):
            base(Id)
        {
            this.side = side;

        }
    }
}
