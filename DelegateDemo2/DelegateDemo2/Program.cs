using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Flexibility + Extensibility---Delegate
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            /*PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;*/
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;


            processor.Process("photo.jpg", filterHandler);
        }

        
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Aplly Remove Red Eye Filter");
        }
    }
}
