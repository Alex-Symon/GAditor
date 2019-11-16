using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesLibrary;

namespace OOPDRAW2._0
{
    public partial class Form1 : Form
    {
        protected List<Shape> Shapes;
        protected Mode Mode;
        protected int MouseX, MouseY, MouseX2, MouseY2;

        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
            listBoxShapes.Items.Add(shape);
            pictureBox1.Refresh();
        }

        protected void DeleteShape(int number)
        {
            Shapes.RemoveAt(number);
            listBoxShapes.Items.RemoveAt(number);
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            Shapes = new List<Shape>();
            Mode = Mode.DrawDot;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxShapes.Items.Count; i++)
            {
                if (listBoxShapes.GetSelected(i))
                {
                    DeleteShape(i);
                    i--;
                }
                if (listBoxShapes.Items.Count > 0)
                listBoxShapes.SetSelected(0, true);
                //if (listBoxShapes.Items.Count != -1)
                //    listBoxShapes.Remove(listBoxShapes[Select_figure()]);
                //pictureBox.Refresh();
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawDot;
        }

        private void buttonLine_Click_1(object sender, EventArgs e)
        {
            Mode = Mode.DrawLine;
        }

        private void buttonCircle_Click_1(object sender, EventArgs e)
        {
            Mode = Mode.DrawCircle;
        }

        private void buttonElipse_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawEllipse;
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawDot:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
                case Mode.DrawLine:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
                case Mode.DrawCircle:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
                    //case Mode.DrawEllipse:
                    //    MouseX = e.X;
                    //    MouseY = e.Y;
                    //    MouseX2 = e.X2;
                    //    MouseY2 = e.Y2;
                    //    break;
            }
        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < Shapes.Count; i++)
                Shapes[i].Draw(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            //Random randome = new Random();
            //Color color = new Color(randome.Next(0, 256), randome.Next(0, 256), randome.Next(0, 256));
            //pen = button1.BackColor;
            switch (Mode)
            {
                case Mode.DrawDot:
                    Shape shape = new Dot(new Pen(button1.BackColor, 3), MouseX, MouseY);
                    AddShape(shape);
                    break;
                case Mode.DrawLine:
                    shape = new Line(new Pen(button1.BackColor, 3), MouseX, MouseY, e.X, e.Y);
                    AddShape(shape);
                    break;
                case Mode.DrawCircle:
                    int side = Math.Abs(MouseX - e.X) + Math.Abs(MouseY - e.Y);
                    shape = new Circle(new Pen(button1.BackColor, 3), MouseX, MouseY, side);
                    AddShape(shape);
                    break;
                    //case Mode.DrawEllipse:
                    //    side = Math.Abs(MouseX - e.X) + Math.Abs(MouseY - e.Y);
                    //int side2 = Math.Abs(MouseX - e.X2) + Math.Abs(MouseY - e.Y2);
                    //shape = new Ellipse(new Pen(button1.BackColor, 3), MouseX, MouseY, side1, side2);
                    //    AddShape(shape);
                    //    break;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawDot:
                    if (e.Button == MouseButtons.Left)
                    {
                        pictureBox1.Refresh();
                        Graphics graphics = pictureBox1.CreateGraphics();
                        graphics.DrawEllipse(new Pen(Color.Black, 1), MouseX, MouseY, 5, 5);
                    }
                    break;
                case Mode.DrawLine:
                    if (e.Button == MouseButtons.Left)
                    {
                        MouseX2 = e.X;
                        MouseY2 = e.Y;
                        pictureBox1.Refresh();
                        Graphics graphics = pictureBox1.CreateGraphics();
                        graphics.DrawLine(new Pen(Color.Black, 1), MouseX, MouseY, MouseX2, MouseY2);
                    }
                    break;
                case Mode.DrawCircle:
                    if (e.Button == MouseButtons.Left)
                    {
                        pictureBox1.Refresh();
                        int side = Math.Abs(MouseX - e.X) + Math.Abs(MouseY - e.Y);
                        Graphics graphics = pictureBox1.CreateGraphics();
                        graphics.DrawEllipse(new Pen(Color.Black, 1), MouseX - side / 2, MouseY - side / 2, side, side);
                    }
                    break;
                    //case Mode.DrawEllipse:
                    //    if (e.Button == MouseButtons.Left)
                    //    {
                    //        pictureBox1.Refresh();
                    //        int side1 = Math.Abs(MouseX - e.X) + Math.Abs(MouseY - e.Y);
                    //        int side2 = Math.Abs(MouseX2 - e.X2) + Math.Abs(MouseY2 - e.Y2);
                    //        Graphics graphics = pictureBox1.CreateGraphics();
                    //        graphics.DrawEllipse(new Pen(Color.Black, 1), MouseX - side1 / 2, MouseY - side1 / 2, side1, side2);
                    //    }
                    //    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }
    }
}
