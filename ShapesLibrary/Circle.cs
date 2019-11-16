using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Circle : Dot
    {
        protected int radius;
        public Circle(Color color, int x, int y) : base(color, x, y)
        { }
        public Circle(Color color, int x, int y, int rad) : base(color, x, y, rad)
        {
            radius = rad;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color, 3);
            g.DrawEllipse(pen, x1 - radius / 2, y1 - radius / 2, radius, radius);
        }
    }
}
