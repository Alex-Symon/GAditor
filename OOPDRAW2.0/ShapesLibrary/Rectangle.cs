using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapesLibrary
{
    public class Rectangle : Line
    {
        protected int width;
        protected int height;
        public Rectangle(Pen pen, int x1, int y1, int width, int height) : base(pen, x1, y1, width, height)
        {
            this.height = height;
            this.width = width;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(this.pen.Color, 3);
            g.DrawRectangle(pen, x1, y1, width, height);
        }
    }
}
