using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Note : Storable               //Note is storable//
    {
        private ReturnStatus status;
        public ReturnStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public void Write(object obj)
        {
            Console.WriteLine("Writing object to disk...");
        }

        public string Read()
        {
            return "Reading note from disk...";
        }

        public void OtherMethod()
        {
            Console.WriteLine("This is an other method");
        }
    }
}
