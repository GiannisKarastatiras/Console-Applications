using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanity
{
    class Human
    {
        private const int FirstNameMinLength = 4;
        private const int LastNameMinLength = 3;

        private string firstName;
        private string FirstName
        {
            set
            {
                if (value.Length < FirstNameMinLength)
                    throw new ArgumentException($"Expected length at least {FirstNameMinLength}");
                firstName = char.ToUpper(value[0]) + value.Substring(1);
            }
        }

        private string lastName;
        private string LastName
        {
            set
            {
                if (value.Length < LastNameMinLength)
                    throw new ArgumentException($"Expected length at least {LastNameMinLength}");
                lastName = char.ToUpper(value[0]) + value.Substring(1);
            }
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"FirstName: {firstName}")
              .AppendLine($"LastName: {lastName}");

            return sb.ToString();
        }

    }
}
