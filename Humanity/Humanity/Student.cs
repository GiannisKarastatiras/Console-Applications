using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanity
{
    class Student : Human
    {
        private const int FacultyMinLength = 5;
        private const int FacultyMaxLenth = 10;

        //Properties
        private string facultyNumber;
        private string FacultyNumber
        {
            set
            {
                if (value.Length < FacultyMinLength || value.Length > FacultyMaxLenth || !value.All(char.IsLetterOrDigit))
                    throw new ArgumentException("Invalid Faculty Number!");
                facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.facultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Faculty Number: {facultyNumber}");

            return sb.ToString();
        }


    }
}
