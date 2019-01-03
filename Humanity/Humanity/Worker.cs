using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanity
{
    class Worker : Human
    {
        private const decimal MinWeekSalary = 10;
        private const int MinWorkingHoursPerDay = 1;
        private const int MaxWorkingHoursPerDay = 12;
        private const int WeekWorkingDays = 5;

        private decimal weekSalary;
        private decimal WeekSalary
        {
            set
            {
                if (value <= MinWeekSalary)
                    throw new ArgumentException("Not valid Week Salary!");

                weekSalary = value;
            }
        }

        private double workHoursPerDay;
        private double WorkHoursPerDay
        {
            set
            {
                if (value < MinWorkingHoursPerDay || value > MaxWorkingHoursPerDay)
                    throw new ArgumentException("Work Hours Invalid!");

                workHoursPerDay = value;                                       
                
            }
        }

        private static int counter;
        //A read only static property
        public static int Counter
        {
            get
            {
                return counter;
            }
        }

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
            ++counter;
        }

        private decimal GetSalary()
        {
            var salaryPerDay = weekSalary / WeekWorkingDays;
            return salaryPerDay / (decimal)workHoursPerDay;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(base.ToString())
                .AppendLine($"WeekSalary: {weekSalary:F2}")     //F2: takes 2 decimals//
                .AppendLine($"HoursPerDay: {workHoursPerDay:F2}")
                .AppendLine($"WeekSalary: {GetSalary():F2}");

            return sb.ToString();
        }
    }
}
