using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public enum ReturnStatus
    {
        OK,
        Fail
    }

                                                   
    public interface Storable                       
    {                                               
        ReturnStatus Status { get; set; }

        void Write(object obj);                   
        String Read();                     
    }
}
