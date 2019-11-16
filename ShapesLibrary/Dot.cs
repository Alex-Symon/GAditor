using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Dot : Shape
    {
        protected int rad;
        public Dot(Color color, int x, int y) : base(color, x, y)
        { }
        public Dot(Color color, int x, int y, int rad) : base(color, x, y)
        {
            this.rad = rad;
        }

        public override void Draw(Graphics g)       //переопределяем-(override)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, x1 - rad / 2, y1 - rad / 2, rad, rad);
        }
    }
}
