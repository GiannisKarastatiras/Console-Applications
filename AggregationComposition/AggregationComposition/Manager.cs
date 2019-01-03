using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationComposition
{
    public class Manager : Employee
    {
        public Manager(string name, string street, string city, string perfecture, string postalCode):
            this(name, street, city, perfecture, postalCode, 200)            
        {            
        }

        public Manager(string name, string street, string city, string perfecture, string postalCode, double salary) :
            base(name, street, city, perfecture, postalCode, salary)
        {
        }


        public string GivePraice()
        {
            return "Manager giving praise.";
        }

        //new = hiding
        public override string DoWork()   
        {
            return "Manager doing work!";
        }

        public override string DoWork(string workType)
        {
            return "Supervising " + workType;
        }
    }
}
