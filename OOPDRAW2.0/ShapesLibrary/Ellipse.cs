using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapesLibrary
{
    public class Ellipse : Circle
    {
        protected int r1;
        protected int r2;
        public Ellipse(Pen pen, int x, int y, int r1) : base(pen, x, y, r1)
        { }
        public Ellipse(Pen pen, int x, int y, int r1, int r2) : base(pen, x, y, r1)
        {
            this.r1 = r1;
            this.r2 = r2;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(this.pen.Color, 3);
            g.DrawEllipse(pen, x1 - r1 / 2, y1 - r2 / 2, r1, r2);
        }
    }
}
