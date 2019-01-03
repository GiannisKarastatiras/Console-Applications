using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAdvancedDemo
{
    class Button : Control
    {
        public string Contents { get; private set; } 

        public Button(int top, int left, string contents):
           base(top, left) 
        {
            Contents = contents;
        }

        public override void DrawMe()
        {
            Console.WriteLine("Drawing button with contents: " + Contents);
        }

    }
}
