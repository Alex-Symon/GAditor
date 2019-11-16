using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapesLibrary
{
    public class Circle : Dot
    {
        protected int radius;
        public Circle(Pen pen, int x, int y) : base(pen, x, y)
        { }
        public Circle(Pen pen, int x, int y, int rad) : base(pen, x, y, rad)
        {
            radius = rad;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(this.pen.Color, 3);
            g.DrawEllipse(pen, x1 - radius / 2, y1 - radius / 2, radius, radius);
        }
    }
}
