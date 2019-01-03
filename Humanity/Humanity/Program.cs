using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanity
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var studentData = Console.ReadLine().Split();
                var workerData = Console.ReadLine().Split();

                try
                {
                    var student = new Student(studentData[0], studentData[1], studentData[2]);
                    var worker = new Worker(workerData[0], workerData[1], decimal.Parse(workerData[2]), double.Parse(workerData[3]));
                    Console.WriteLine(student);
                    Console.WriteLine(worker);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (Worker.Counter == 3)
                    break;
            }
        }
    }
}
