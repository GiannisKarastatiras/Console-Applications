using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            try
            {
                var smallests = GetSmallests(numbers/*null*/, 3);

                foreach (var number in smallests)
                {
                    Console.WriteLine(number);
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {           // Defencive programming
            if (list == null)
                throw new ArgumentNullException("list", "List should not be null");
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("list", "Count should not be greater than the elements of the list"); 

            var buffer = new List<int>(list);   // Copy of list //
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is always the smallest //
            var min = list[0];

            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
