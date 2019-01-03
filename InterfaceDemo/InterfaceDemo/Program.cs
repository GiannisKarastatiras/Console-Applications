using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)             
        {
            var storableObjects = new List<Storable>();
            Note note = new Note();
            storableObjects.Add(note);
            DBEntry dBEntry = new DBEntry();
            storableObjects.Add(dBEntry);
            note = new Note();
            storableObjects.Add(note);
            note = new Note();
            storableObjects.Add(note);
            dBEntry = new DBEntry();
            storableObjects.Add(dBEntry);

            foreach (Storable storable in storableObjects)
            {
                storable.Write(null);
                Console.WriteLine(storable.Read());
            }

        }
    }
}
