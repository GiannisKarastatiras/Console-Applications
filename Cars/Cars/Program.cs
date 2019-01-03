using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test 1
            Car car1 = new Car();
            car1.DescribeCar();

            ConvertibleCar car2 = new ConvertibleCar();
            car2.DescribeCar();

            Minivan car3 = new Minivan();
            car3.DescribeCar();

            //Test 2
            //Car car4 = new ConvertibleCar();
            //Car car5 = new Minivan();
            //car4.ShowDetails();
            //car5.ShowDetails();

            ConvertibleCar car4 = new ConvertibleCar();
            Car car5 = new Minivan();
            car4.ShowDetails();
            car5.ShowDetails();
        }
    }
}
