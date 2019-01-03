using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] Shapes =
            {
                new Square(5, "Square #1"),
                new Circle(3, "Circle #1"),
                new Rectangle(4, 5, "Rectangle #1")
            };

            Console.WriteLine("Shapes Collection: ");
            foreach (Shape shape in Shapes)
            {
                Console.WriteLine(shape);
            }
            
        }
    }
}
