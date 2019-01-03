using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tester t = new Tester();
                double answer = t.DoDivide(12, 4);
                Console.WriteLine("DoDivide(12, 4) = {0}", answer);
                answer = t.DoDivide(0, 0);
                Console.WriteLine("DoDivide(4, 0) = {0}", answer);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);                
            }
            catch (MyCustonException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
