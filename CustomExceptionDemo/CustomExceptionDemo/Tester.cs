using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    class Tester
    {
        public double DoDivide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();      //throw exception//
            if (x == 0)
                throw new MyCustonException("Divident can not be zero!");

            return x / y;            
        }
    }
}
