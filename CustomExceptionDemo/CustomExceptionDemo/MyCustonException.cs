using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    class MyCustonException : Exception
    {
        public MyCustonException(string message) :    //--Constructor--//
            base(message)                             //--Base Constructor--//
        {

        }

    }
}
