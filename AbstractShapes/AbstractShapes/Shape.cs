using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{
    public abstract class Shape
    {
        private string name;
        public string Id
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }        

        //abstract prop
        public abstract double Area
        {
            get;
        }

        public Shape(string s)
        {
            Id = s;
        }

        public override string ToString()
        {
            return Id + "Area = " + string.Format("{0:F2}", Area);
        }
    }
}
