using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapesLibrary
{
    public class Dot : Shape
    {
        protected int rad;
        public Dot(Pen pen, int x, int y) : base(pen, x, y)
        { }
        public Dot(Pen pen, int x, int y, int rad) : base(pen, x, y)
        {
            this.rad = rad;
        }

        public override void Draw(Graphics g)       //переопределяем-(override)
        {
            Brush brush = new SolidBrush(pen.Color);
            g.FillEllipse(brush, x1 - rad / 2, y1 - rad / 2, 5, 5);
        }
    }
}
