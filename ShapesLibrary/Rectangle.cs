using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Rectangle : Line
    {
        protected int width;
        protected int height;
        public Rectangle(Color color, int x1, int y1, int width, int height) : base(color, x1, y1, width, height)
        {
            this.height = height;
            this.width = width;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color, 3);
            g.DrawRectangle(pen, x1, y1, width, height);
        }
    }
}
