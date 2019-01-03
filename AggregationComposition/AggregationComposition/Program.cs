using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee John = new Employee("John Taramas", "Alkaiou", "Nea Ionia", "Attikis", "12351");
            Console.WriteLine(John);

            //Aggregation
            John.Insurance = new InsuranceInfo()
            {
                PolicyId = "111",
                PolicyName = "LifeTime"
            };
            Console.WriteLine(John);

            Manager Bill = new Manager("Bill Trump", "Paraiou", "Peristeri", "Attikis", "12312");
            Console.WriteLine(Bill);

            Console.WriteLine(John.DoWork());
            Console.WriteLine(Bill.DoWork());
            Console.WriteLine(Bill.DoWork("typing"));

            Employee Alex = new Manager("Alex Alex", "Papa", "Zografou", "Attikis", "6620", 888);
            Console.WriteLine(Alex);
            
            Console.WriteLine("Alex do work: " + Alex.DoWork());

            List<Employee> employees = new List<Employee>();
            employees.Add(John);
            employees.Add(Bill);
            employees.Add(Alex);

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.DoWork());
            }
        }
    }
}
