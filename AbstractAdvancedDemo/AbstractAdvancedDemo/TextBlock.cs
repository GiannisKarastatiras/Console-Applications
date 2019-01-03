using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAdvancedDemo
{
    class TextBlock : Control
    {
        public string Text { get; set; }

        public TextBlock(int top, int left, string text):
            base(top, left)
        {
            Text = text;
        }

        public override void DrawMe()
        {
            Console.WriteLine(Text);
        }
    }
}
