using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Package_finall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void twoLines()
        {
            var Graph = panel1.CreateGraphics();
            Pen p = Pens.White;
            Graph.DrawLine(p, 0, panel1.Height / 2, panel1.Width, panel1.Height / 2);
            Graph.DrawLine(p, panel1.Width / 2, 0, panel1.Width / 2, panel1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var aBrush = Brushes.Red;
            var g = panel1.CreateGraphics();
            int x0; int y0; int xEnd;int yEnd;
            x0 = int.Parse(textBox1.Text);
            y0 = int.Parse(textBox2.Text);
            xEnd = int.Parse(textBox3.Text);
            yEnd = int.Parse(textBox4.Text);
            int dx = xEnd - x0;
            int dy = yEnd - y0;
            int steps, k;
            double xIncrement, yIncrement;
            double x = x0, y = y0;
            if (Math.Abs(dx) > Math.Abs(dy))
            {
                steps = Math.Abs(dx);
            }
            else
            {
                steps = Math.Abs(dy);
            }
            xIncrement = Convert.ToDouble(dx) / Convert.ToDouble(steps);
            yIncrement = Convert.ToDouble(dy) / Convert.ToDouble(steps);

            g.FillRectangle(aBrush, Convert.ToInt32(Math.Round(x)) + (panel1.Width) / 2, 
                Convert.ToInt32(Math.Round(y) * -1 + (panel1.Height) / 2), 1, 1);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;

                g.FillRectangle(aBrush, Convert.ToInt32(Math.Round(x)) + (panel1.Width) / 2,
                    Convert.ToInt32(Math.Round(y) * -1 + (panel1.Height) / 2), 1, 1);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var aBrush = Brushes.Red;
            var g = panel1.CreateGraphics();
            int x0 = int.Parse(textBox5.Text);
            int y0 = int.Parse(textBox6.Text);
            int xEnd = int.Parse(textBox7.Text);
            int yEnd = int.Parse(textBox8.Text);
            int dx = xEnd - x0;
            int dy = yEnd - y0;
            int p = 2 * dy - dx;
            int twoDy = 2 * dy;
            int twoDyMinusDx = 2 * (dy - dx);
            double x, y;
            if (x0 > xEnd)
            {
                x = xEnd;
                y = yEnd;
                xEnd = x0;
            }
            else
            {
                x = x0;
                y = y0;
            }
            g.FillRectangle(aBrush, Convert.ToInt32(Math.Round(x)) + (panel1.Width) / 2,
                Convert.ToInt32(Math.Round(y) * -1 + (panel1.Height) / 2), 1, 1);
            while (x < xEnd)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                g.FillRectangle(aBrush, Convert.ToInt32(Math.Round(x)) + (panel1.Width) / 2,
                    Convert.ToInt32(Math.Round(y) * -1 + (panel1.Height) / 2), 1, 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            int x_centre;
            int y_centre;
            int r;
            r = int.Parse(textBox9.Text);
            x_centre = int.Parse(textBox10.Text);
            y_centre = int.Parse(textBox11.Text);
            int x = r, y = 0;
            g.FillRectangle(aBrush, x + x_centre + (panel1.Width) / 2, y + y_centre * -1 + (panel1.Height) / 2, 2, 2);
            if (r > 0)
            {
                g.FillRectangle(aBrush, x + x_centre + (panel1.Width) / 2, -y + y_centre * -1 + (panel1.Height) / 2, 2, 2);
                g.FillRectangle(aBrush, y + x_centre + (panel1.Width) / 2, x + y_centre * -1 + (panel1.Height) / 2, 2, 2);
                g.FillRectangle(aBrush, -y + x_centre + (panel1.Width) / 2, x + y_centre * -1 + (panel1.Height) / 2, 2, 2);
            }
            int P = 1 - r;
            while (x > y)
            {
                y++;
                if (P <= 0)
                    P = P + 2 * y + 1;
                else
                {
                    x--;
                    P = P + 2 * y - 2 * x + 1;
                }
                if (x < y)
                    break;
                g.FillRectangle(aBrush, x + x_centre + (panel1.Width) / 2, y + y_centre * -1 + (panel1.Height) / 2, 2, 2);
                g.FillRectangle(aBrush, -x + x_centre + (panel1.Width) / 2, y + y_centre * -1 + (panel1.Height) / 2, 2, 2);
                g.FillRectangle(aBrush, x + x_centre + (panel1.Width) / 2, -y + y_centre * -1 + (panel1.Height) / 2, 2, 2);
                g.FillRectangle(aBrush, -x + x_centre + (panel1.Width) / 2, -y + y_centre * -1 + (panel1.Height) / 2, 2, 2);

                if (x != y)
                {
                    g.FillRectangle(aBrush, y + x_centre + (panel1.Width) / 2, x + y_centre * -1 + (panel1.Height) / 2, 2, 2);
                    g.FillRectangle(aBrush, -y + x_centre + (panel1.Width) / 2, x + y_centre * -1 + (panel1.Height) / 2, 2, 2);
                    g.FillRectangle(aBrush, y + x_centre + (panel1.Width) / 2, -x + y_centre * -1 + (panel1.Height) / 2, 2, 2);
                    g.FillRectangle(aBrush, -y + x_centre + (panel1.Width) / 2, -x + y_centre * -1 + (panel1.Height) / 2, 2, 2);
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            twoLines();
        }

        //Draw Ellip
        private void button5_Click(object sender, EventArgs e)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            double xc = int.Parse(textBox12.Text);
            double yc = int.Parse(textBox13.Text);
            double rx = int.Parse(textBox14.Text);
            double ry = int.Parse(textBox15.Text);
            double dx, dy, d1, d2, x, y;
            x = 0;
            y = ry;
            d1 = (ry * ry) - (rx * rx * ry) +
                            (0.25f * rx * rx);
            dx = 2 * ry * ry * x;
            dy = 2 * rx * rx * y;
            while (dx < dy)
            {
                g.FillRectangle(aBrush, Convert.ToInt32(x + xc) + (panel1.Width) / 2, Convert.ToInt32(y + yc) * -1 + (panel1.Height) / 2, 3, 3);
                g.FillRectangle(aBrush, Convert.ToInt32(-x + xc) + (panel1.Width) / 2, Convert.ToInt32(y + yc) * -1 + (panel1.Height) / 2, 3, 3);
                g.FillRectangle(aBrush, Convert.ToInt32(x + xc) + (panel1.Width) / 2, Convert.ToInt32(-y + yc) * -1 + (panel1.Height) / 2, 3, 3);
                g.FillRectangle(aBrush, Convert.ToInt32(-x + xc) + (panel1.Width) / 2, Convert.ToInt32(-y + yc) * -1 + (panel1.Height) / 2, 3, 3);
                if (d1 < 0)
                {
                    x++;
                    dx = dx + (2 * ry * ry);
                    d1 = d1 + dx + (ry * ry);
                }
                else
                {
                    x++;
                    y--;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d1 = d1 + dx - dy + (ry * ry);
                }

            }
            d2 = ((ry * ry) * ((x + 0.5f) * (x + 0.5f)))
                + ((rx * rx) * ((y - 1) * (y - 1)))
                - (rx * rx * ry * ry);
            while (y >= 0)
            {
                g.FillRectangle(aBrush, Convert.ToInt32(x + xc) + (panel1.Width) / 2, Convert.ToInt32(y + yc) * -1 + (panel1.Height) / 2, 3, 3);
                g.FillRectangle(aBrush, Convert.ToInt32(-x + xc) + (panel1.Width) / 2, Convert.ToInt32(y + yc) * -1 + (panel1.Height) / 2, 3, 3);
                g.FillRectangle(aBrush, Convert.ToInt32(x + xc) + (panel1.Width) / 2, Convert.ToInt32(-y + yc) * -1 + (panel1.Height) / 2, 3, 3);
                g.FillRectangle(aBrush, Convert.ToInt32(-x + xc) + (panel1.Width) / 2, Convert.ToInt32(-y + yc) * -1 + (panel1.Height) / 2, 3, 3);
                if (d2 > 0)
                {
                    y--;
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + (rx * rx) - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + dx - dy + (rx * rx);
                }
            }
        }
        //Draw Rectangle
        private void button6_Click_1(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox16.Text) + (panel1.Width) / 2;
            int y1 = Convert.ToInt32(textBox17.Text) * -1 + (panel1.Height) / 2;
            int x2 = Convert.ToInt32(textBox18.Text) + (panel1.Width) / 2;
            int y2 = Convert.ToInt32(textBox19.Text) * -1 + (panel1.Height) / 2;
            int x3 = Convert.ToInt32(textBox20.Text) + (panel1.Width) / 2;
            int y3 = Convert.ToInt32(textBox21.Text) * -1 + (panel1.Height) / 2;
            int x4 = Convert.ToInt32(textBox22.Text) + (panel1.Width) / 2;
            int y4 = Convert.ToInt32(textBox23.Text) * -1 + (panel1.Height) / 2;
            Point w = new Point(x1, y1);
            Point h = new Point(x2, y2);
            Point l = new Point(x3, y3);
            Point r = new Point(x4, y4);
            var g = panel1.CreateGraphics();
            g.DrawLine(Pens.Red, w, h);
            g.DrawLine(Pens.Red, l, r);
            g.DrawLine(Pens.Red, w, r);
            g.DrawLine(Pens.Red, h, l);
        }
        //2D Translation
        private void button7_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox16.Text) + (panel1.Width) / 2;
            int y1 = Convert.ToInt32(textBox17.Text) * -1 + (panel1.Height) / 2;
            int x2 = Convert.ToInt32(textBox18.Text) + (panel1.Width) / 2;
            int y2 = Convert.ToInt32(textBox19.Text) * -1 + (panel1.Height) / 2;
            int x3 = Convert.ToInt32(textBox20.Text) + (panel1.Width) / 2;
            int y3 = Convert.ToInt32(textBox21.Text) * -1 + (panel1.Height) / 2;
            int x4 = Convert.ToInt32(textBox22.Text) + (panel1.Width) / 2;
            int y4 = Convert.ToInt32(textBox23.Text) * -1 + (panel1.Height) / 2;
            int x = Convert.ToInt32(textBox24.Text);
            int y = -Convert.ToInt32(textBox25.Text);
            int x1x = x + x1;
            int y1y = y + y1;
            int x2x = x + x2;
            int y2y = y + y2;
            int x3x = x + x3;
            int y3y = y + y3;
            int x4x = x + x4;
            int y4y = y + y4;
            Point w = new Point(x1x, y1y);
            Point h = new Point(x2x, y2y);
            Point l = new Point(x3x, y3y);
            Point r = new Point(x4x, y4y);
            var g = panel1.CreateGraphics();
            g.DrawLine(Pens.Black, w, h);
            g.DrawLine(Pens.Black, l, r);
            g.DrawLine(Pens.Black, w, r);
            g.DrawLine(Pens.Black, h, l);
        }

        //2D Scale
        private void button8_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox16.Text);
            int y1 = Convert.ToInt32(textBox17.Text);
            int x2 = Convert.ToInt32(textBox18.Text);
            int y2 = Convert.ToInt32(textBox19.Text);
            int x3 = Convert.ToInt32(textBox20.Text);
            int y3 = Convert.ToInt32(textBox21.Text);
            int x4 = Convert.ToInt32(textBox22.Text);
            int y4 = Convert.ToInt32(textBox23.Text);
            int x = Convert.ToInt32(textBox24.Text);
            int y = Convert.ToInt32(textBox25.Text);
            int x1x = (x * x1) + (panel1.Width) / 2;
            int y1y = (y * y1) * -1 + (panel1.Height) / 2;
            int x2x = (x * x2) + (panel1.Width) / 2;
            int y2y = (y * y2) * -1 + (panel1.Height) / 2;
            int x3x = (x * x3) + (panel1.Width) / 2;
            int y3y = (y * y3) * -1 + (panel1.Height) / 2;
            int x4x = (x * x4) + (panel1.Width) / 2;
            int y4y = (y * y4) * -1 + (panel1.Height) / 2;
            Point w = new Point(x1x, y1y);
            Point h = new Point(x2x, y2y);
            Point l = new Point(x3x, y3y);
            Point r = new Point(x4x, y4y);
            var g = panel1.CreateGraphics();
            g.DrawLine(Pens.Yellow, w, h);
            g.DrawLine(Pens.Yellow, l, r);
            g.DrawLine(Pens.Yellow, w, r);
            g.DrawLine(Pens.Yellow, h, l);
        }
        //2D Rotation
        private void button9_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox16.Text);
            int y1 = Convert.ToInt32(textBox17.Text);
            int x2 = Convert.ToInt32(textBox18.Text);
            int y2 = Convert.ToInt32(textBox19.Text);
            int x3 = Convert.ToInt32(textBox20.Text);
            int y3 = Convert.ToInt32(textBox21.Text);
            int x4 = Convert.ToInt32(textBox22.Text);
            int y4 = Convert.ToInt32(textBox23.Text);
            double angle = Convert.ToDouble(textBox26.Text);
            angle = angle * (Math.PI / 180);
            int x1x = (int)((x1 * Math.Cos(angle)) - (y1 * Math.Sin(angle))) + (panel1.Width) / 2;
            int x2x = (int)((x2 * Math.Cos(angle)) - (y2 * Math.Sin(angle))) + (panel1.Width) / 2;
            int x3x = (int)((x3 * Math.Cos(angle)) - (y3 * Math.Sin(angle))) + (panel1.Width) / 2;
            int x4x = (int)((x4 * Math.Cos(angle)) - (y4) * Math.Sin(angle)) + (panel1.Width) / 2;
            int y1y = (int)((x1 * Math.Sin(angle)) + (y1 * Math.Cos(angle))) * -1 + (panel1.Height) / 2;
            int y2y = (int)((x2 * Math.Sin(angle)) + (y2 * Math.Cos(angle))) * -1 + (panel1.Height) / 2;
            int y3y = Convert.ToInt32((x3 * Math.Sin(angle)) + (y3 * Math.Cos(angle))) * -1 + (panel1.Height) / 2;
            int y4y = Convert.ToInt32((x4 * Math.Sin(angle)) + (y4 * Math.Cos(angle))) * -1 + (panel1.Height) / 2;
            Point w = new Point(x1x, y1y);
            Point h = new Point(x2x, y2y);
            Point l = new Point(x3x, y3y);
            Point r = new Point(x4x, y4y);
            var a = Brushes.Black;
            var g = panel1.CreateGraphics();
            g.DrawLine(Pens.Red, w, h);
            g.DrawLine(Pens.Red, l, r);
            g.DrawLine(Pens.Red, w, r);
            g.DrawLine(Pens.Red, h, l);
        }


        //Over X
        private void button10_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox16.Text);
            int y1 = Convert.ToInt32(textBox17.Text) * -1 + (panel1.Height) / 2;
            int x2 = Convert.ToInt32(textBox18.Text);
            int y2 = Convert.ToInt32(textBox19.Text) * -1 + (panel1.Height) / 2;
            int x3 = Convert.ToInt32(textBox20.Text);
            int y3 = Convert.ToInt32(textBox21.Text) * -1 + (panel1.Height) / 2;
            int x4 = Convert.ToInt32(textBox22.Text);
            int y4 = Convert.ToInt32(textBox23.Text) * -1 + (panel1.Height) / 2;
            int x1x = (-1 * x1) + (panel1.Width) / 2;
            int x2x = (-1 * x2) + (panel1.Width) / 2;
            int x3x = (-1 * x3) + (panel1.Width) / 2;
            int x4x = (-1 * x4) + (panel1.Width) / 2;
            Point w = new Point(x1x, y1);
            Point h = new Point(x2x, y2);
            Point l = new Point(x3x, y3);
            Point r = new Point(x4x, y4);
            var a = Brushes.Black;
            var g = panel1.CreateGraphics();
            g.DrawLine(Pens.Red, w, h);
            g.DrawLine(Pens.Red, l, r);
            g.DrawLine(Pens.Red, w, r);
            g.DrawLine(Pens.Red, h, l);
        }
        //Over Y
        private void button11_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox16.Text) + (panel1.Width) / 2;
            int y1 = Convert.ToInt32(textBox17.Text);
            int x2 = Convert.ToInt32(textBox18.Text) + (panel1.Width) / 2;
            int y2 = Convert.ToInt32(textBox19.Text);
            int x3 = Convert.ToInt32(textBox20.Text) + (panel1.Width) / 2;
            int y3 = Convert.ToInt32(textBox21.Text);
            int x4 = Convert.ToInt32(textBox22.Text) + (panel1.Width) / 2;
            int y4 = Convert.ToInt32(textBox23.Text);
            int y1y = (-1 * y1) * -1 + (panel1.Height) / 2;
            int y2y = (-1 * y2) * -1 + (panel1.Height) / 2;
            int y3y = (-1 * y3) * -1 + (panel1.Height) / 2;
            int y4y = (-1 * y4) * -1 + (panel1.Height) / 2;
            Point w = new Point(x1, y1y);
            Point h = new Point(x2, y2y);
            Point l = new Point(x3, y3y);
            Point r = new Point(x4, y4y);
            var a = Brushes.Black;
            var g = panel1.CreateGraphics();
            g.DrawLine(Pens.Red, w, h);
            g.DrawLine(Pens.Red, l, r);
            g.DrawLine(Pens.Red, w, r);
            g.DrawLine(Pens.Red, h, l);
        }
        //Over Origin
        private void button12_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox16.Text);
            int y1 = Convert.ToInt32(textBox17.Text);
            int x2 = Convert.ToInt32(textBox18.Text);
            int y2 = Convert.ToInt32(textBox19.Text);
            int x3 = Convert.ToInt32(textBox20.Text);
            int y3 = Convert.ToInt32(textBox21.Text);
            int x4 = Convert.ToInt32(textBox22.Text);
            int y4 = Convert.ToInt32(textBox23.Text);
            int x1x = (-1 * x1) + (panel1.Width) / 2;
            int x2x = (-1 * x2) + (panel1.Width) / 2;
            int x3x = (-1 * x3) + (panel1.Width) / 2;
            int x4x = (-1 * x4) + (panel1.Width) / 2;
            int y1y = (-1 * y1) * -1 + (panel1.Height) / 2;
            int y2y = (-1 * y2) * -1 + (panel1.Height) / 2;
            int y3y = (-1 * y3) * -1 + (panel1.Height) / 2;
            int y4y = (-1 * y4) * -1 + (panel1.Height) / 2;
            Point w = new Point(x1x, y1y);
            Point h = new Point(x2x, y2y);
            Point l = new Point(x3x, y3y);
            Point r = new Point(x4x, y4y);
            var a = Brushes.Black;
            var g = panel1.CreateGraphics();
            g.DrawLine(Pens.Red, w, h);
            g.DrawLine(Pens.Red, l, r);
            g.DrawLine(Pens.Red, w, r);
            g.DrawLine(Pens.Red, h, l);
        }
        //Shear X
        private void button13_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox16.Text);
            int y1 = Convert.ToInt32(textBox17.Text);
            int x2 = Convert.ToInt32(textBox18.Text);
            int y2 = Convert.ToInt32(textBox19.Text);
            int x3 = Convert.ToInt32(textBox20.Text);
            int y3 = Convert.ToInt32(textBox21.Text);
            int x4 = Convert.ToInt32(textBox22.Text);
            int y4 = Convert.ToInt32(textBox23.Text);
            int Z =  Convert.ToInt32(textBox27.Text);
            int x1x = (x1 + (Z * y1)) + (panel1.Width) / 2;
            int x2x = (x2 + (Z * y2)) + (panel1.Width) / 2;
            int x3x = (x3 + (Z * y3)) + (panel1.Width) / 2;
            int x4x = (x4 + (Z * y4)) + (panel1.Width) / 2;
            int y1y = y1 * -1 + (panel1.Height) / 2;
            int y2y = y2 * -1 + (panel1.Height) / 2;
            int y3y = y3 * -1 + (panel1.Height) / 2;
            int y4y = y4 * -1 + (panel1.Height) / 2;
            Point w = new Point(x1x, y1y);
            Point h = new Point(x2x, y2y);
            Point l = new Point(x3x, y3y);
            Point r = new Point(x4x, y4y);
            var g = panel1.CreateGraphics();
            g.DrawLine(Pens.Yellow, w, h);
            g.DrawLine(Pens.Yellow, l, r);
            g.DrawLine(Pens.Yellow, w, r);
            g.DrawLine(Pens.Yellow, h, l);
        }
        //Shear Y
        private void button14_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox16.Text);
            int y1 = Convert.ToInt32(textBox17.Text);
            int x2 = Convert.ToInt32(textBox18.Text);
            int y2 = Convert.ToInt32(textBox19.Text);
            int x3 = Convert.ToInt32(textBox20.Text);
            int y3 = Convert.ToInt32(textBox21.Text);
            int x4 = Convert.ToInt32(textBox22.Text);
            int y4 = Convert.ToInt32(textBox23.Text);
            int N = Convert.ToInt32(textBox28.Text);
            int x1x = x1 + (panel1.Width) / 2;
            int x2x = x2 + (panel1.Width) / 2;
            int x3x = x3 + (panel1.Width) / 2;
            int x4x = x4 + (panel1.Width) / 2;
            int y1y = (y1 + (N * x1)) * -1 + (panel1.Height) / 2;
            int y2y = (y2 + (N * x2)) * -1 + (panel1.Height) / 2;
            int y3y = (y3 + (N * x3)) * -1 + (panel1.Height) / 2;
            int y4y = (y4 + (N * x4)) * -1 + (panel1.Height) / 2;
            Point w = new Point(x1x, y1y);
            Point h = new Point(x2x, y2y);
            Point l = new Point(x3x, y3y);
            Point r = new Point(x4x, y4y);
            var g = panel1.CreateGraphics();
            g.DrawLine(Pens.Yellow, w, h);
            g.DrawLine(Pens.Yellow, l, r);
            g.DrawLine(Pens.Yellow, w, r);
            g.DrawLine(Pens.Yellow, h, l);
        }
    }
}
