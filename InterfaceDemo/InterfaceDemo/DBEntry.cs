using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class DBEntry : Storable
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
            Console.WriteLine("Writing object to database...");
        }

        public string Read()
        {
            return "Reading entry from database...";
        }

        public void OtherMethod()
        {
            Console.WriteLine("This is an other method");
        }
    }
}
