using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAdvancedDemo
{
    public class Document : Printable, Storable 
    {
        public string DocName { get; set; }

        public int Status
        {
            get
            {
                return 0;   
            }
        }

        public void CountCharacters()
        {
            Console.WriteLine("133 Characters");
        }

        public void Print()
        {
            Console.WriteLine("Writing Document to printer");
        }

        public string Read()
        {
            Console.WriteLine("Getting Document from File...");
            return "Success";
        }

        public void Write()
        {
            Console.WriteLine("Writing Document to file...");
        }
    }
}
