using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Worker();          
            employee1.Name = "Vaggelis";
            employee1.Salary = 238;

            var employee2 = new Manager();
            employee2.Name = "Kostas";
            employee2.Salary = 312;

            var employee3 = new Manager();
            employee3.Name = "George";
            employee3.Salary = 543;

            var employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Name}'s salary was {emp.Salary}");
                emp.GiveRaise();        //Benefit from abstract
                Console.WriteLine($"but now is {emp.Salary}");
            }
        }
    }
}
