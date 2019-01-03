using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class Tester
    {
        //----Procedural programming----//

        public void Method1()
        {
            Console.WriteLine("Method 1 Begins...");
            Method2();
            Console.WriteLine("Method 1 Ends...");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2 Begins...");
            Method3();
            Console.WriteLine("Method 2 Ends...");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3 Begins...");
            Console.WriteLine("File Opened...");
            
            try
            {
                var x = 0;
                var y = 13 / x;
            }
            catch (Exception e)    
            {
                Console.WriteLine("Caught Exception: {0}", e.Message);                
            }
            finally        
            {
                Console.WriteLine("File Closed...");
            }
            
            Console.WriteLine("Method 3 Ends...");
        }
    }
}
