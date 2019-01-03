using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2
{
    class Employee
    {
        //Properties
        public string Name { get; set; }
        public int Age { get; set; }    
        public double Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }

        //Default Contsructor
        public Employee()
        {
        }

        //Special method--Constructor
        public Employee(int age, string name, double salary, DateTime startingDate, string phoneNumber)
        {
            Age = age;
            Name = name;
            Salary = salary;
            StartingDate = startingDate;
            PhoneNumber = phoneNumber;
        }
        

        public double Bonus(double a)
        {
            Salary = Salary + (Salary * (a / 100));
            return Salary;
        }

        
        //public void SalaryWithBonus(double bonusPercent)
        //{
        //   Salary += Salary * bonusPercent;
        //}
        

        
   
    }
}
