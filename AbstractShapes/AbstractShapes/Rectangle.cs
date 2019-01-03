using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{
    class Rectangle : Shape
    {
        private int width;
        private int height;

        public override double Area
        {
            get
            {
                return width * height;
            }
        }

        public Rectangle(int width, int height, string Id):
            base(Id)
        {
            this.width = width;
            this.height = height;
        }
    }
}
