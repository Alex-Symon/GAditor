using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public abstract class Shape                        //всі фігури
    {
        protected int x1, y1;
        protected Color color;
        public Shape(Color color, int x, int y)
        {
            this.color = color;
            x1 = x;
            y1 = y;
        }
        public abstract void Draw(Graphics g);
    }
}
