using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationComposition
{
    public class Employee
    {
        public string Name { get; set; }
        public AddressInfo Address { get; set; }
        public InsuranceInfo Insurance { get; set; }
        public double Salary { get; set; }

        
        public Employee(string name, string street, string city, string perfecture, string postalCode) :
            this(name, street, city, perfecture, postalCode, 100)
        {
        }        

        public Employee(string name, string street, string city, string perfecture, string postalCode, double salary)
        {
            Name = name;
            Salary = salary;
            Address = new AddressInfo()
            {
                Street = street,
                City = city,
                Perfecture = perfecture,
                PostalCode = postalCode
            };
        }
        
        public virtual string DoWork()
        {
            return "Employee doing work!";
        }

        public virtual string DoWork(string workType)
        {
            return "Doing " + workType;
        }

        public override string ToString()
        {
            string employee = Name + " " +
                Address.Street + " " +
                Address.City + " " +
                Address.Perfecture + " " +
                Address.PostalCode + " " +
                "\tSalary: " + Salary + "\t";

            if (Insurance != null)
            {
                employee += " " +
                    Insurance.PolicyId + " " +
                    Insurance.PolicyName;
            }

            return employee;
        }
    }
}
