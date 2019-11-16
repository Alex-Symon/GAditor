using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapesLibrary
{
    public abstract class Shape                        //всі фігури
    {
        protected int x1, y1;
        protected Pen pen;
        public Shape(Pen pen, int x, int y)
        {
            this.pen = pen;
            x1 = x;
            y1 = y;
        }
        public abstract void Draw(Graphics g);
    }
}
