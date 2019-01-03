using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAdvancedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Control button = new Button(0, 0, "Clik Me");
            Control textBlock = new TextBlock(20, 20, "Hello");

            List<Control> controls = new List<Control>();
            controls.Add(button);
            controls.Add(button);

            foreach (Control ctrl in controls)
            {
                ctrl.DrawMe();
            }
        }
    }
}
