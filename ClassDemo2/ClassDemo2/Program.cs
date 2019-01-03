using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Peri = new Employee();
            Employee Kostas = new Employee()            //initialization object                   
            {
                Age = 54,
                Name = "Kostas Papadopoulos",
                Salary = 654.888,
                PhoneNumber = "210-2322334",
                StartingDate = new DateTime(2015, 5, 22)            
                
            };



            Console.WriteLine("Give me the number of bonus for your employees: ");           
            double pososto = double.Parse(Console.ReadLine());

            //Assigment
            Peri.Age = 21;
            Peri.Name = "Peri";
            Peri.Salary = 654.87;          
            Peri.PhoneNumber = "210-5665987";
            Peri.StartingDate = new DateTime(2016, 06, 13);
                       

            Peri.Bonus(pososto);
            Kostas.Bonus(pososto);

            Console.WriteLine($"{Kostas.Name} is {Kostas.Age}, he started working on {Kostas.StartingDate} and makes {Kostas.Bonus(pososto)}");
            
            //Kostas.SalaryWithBonus(0.05);
            Console.WriteLine($"{Peri.Name} is {Peri.Age}, he started working on {Peri.StartingDate} and makes {Peri.Bonus(pososto)}");
        }
        // Constructor
        Employee Alex = new Employee(32, "Alex Alex", 456.58, new DateTime(2015, 2, 22), "2107884952");          //new = constructor

        Employee Panos = new Employee();                 //Constructor overloaded
        
        
    }
}
