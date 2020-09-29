using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_3
{
    public partial class Form1 : Form
    {
        int size_ellipse_point = 6; //Размер эллипса в точке начала и конца отрезка
        Queue<Point> points = new Queue<Point>();
        Color colorLine = Color.Black;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Change_Method(object sender, EventArgs e)
        {
            Button cur_button = (Button)sender;
            cur_button.Enabled = false;
            if (cur_button == button_Brezenheim)
            {
                button_VU.Enabled = true;
            }
            else
            {
                button_Brezenheim.Enabled = true;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point cur_point = e.Location;
            Graphics g = pictureBox1.CreateGraphics();

            

            if (points.Count == 2)
            {
                points.Dequeue();
            }

            points.Enqueue(cur_point);
            g.FillEllipse(new SolidBrush(Color.Red), cur_point.X - size_ellipse_point/2, cur_point.Y - size_ellipse_point/2, size_ellipse_point, size_ellipse_point);

            if (points.Count == 2)
            {
                Point point1 = points.Dequeue();
                Point point2 = points.Peek();

                if (!button_Brezenheim.Enabled)
                {
                    Brezenheim(g, point1, point2);
                }
                else
                {
                    VU(g, point1, point2);
                }
            }
        }

        private void Brezenheim(Graphics g, Point point1, Point point2)
        {
            int distanceX = Math.Abs(point2.X - point1.X);
            int distanceY = Math.Abs(point2.Y - point1.Y);
            double grad = distanceY / (double)distanceX;
            Tuple<int, int> dirXY = Direction(point1, point2);

            
            int x = point1.X;
            int y = point1.Y;
            Bitmap pixel = new Bitmap(1,1);
            pixel.SetPixel(0, 0, colorLine);
            if (grad <= 1)
            {
                double d = 2 * distanceY - distanceX;
                while (x != point2.X || y != point2.Y)
                {
                    if (d <= 0)
                    {
                        d = d + 2 * distanceY;
                    }
                    else
                    {
                        y += dirXY.Item2;
                        d = d + 2 * (distanceY - distanceX);
                    }

                    x += dirXY.Item1;
                    g.DrawImageUnscaled(pixel, x, y);
                }
            }
            else
            {
                double d = 2 * distanceX - distanceY;
                while (x != point2.X || y != point2.Y)
                {
                    if (d < 0)
                    {
                        d = d + 2 * distanceX;
                    }
                    else
                    {
                        x += dirXY.Item1;
                        d = d + 2 * (distanceX - distanceY);
                    }

                    y += dirXY.Item2;
                    g.DrawImageUnscaled(pixel, x, y);
                }
            }
        }

        private Tuple<int, int> Direction(Point point1, Point point2)
        {
            int x = 0;
            int y = 0;

            if (point1.X > point2.X)
            {
                x = -1;
            }
            else if (point1.X < point2.X)
            {
                x = 1;
            }


            if (point1.Y > point2.Y)
            {
                y = -1;
            }
            else if (point1.Y < point2.Y)
            {
                y = 1;
            }

            return new Tuple<int, int>(x, y);
        }

        private void DrawPoint(Graphics graphics, bool steep, int x, int y, double grade)
        {
            grade = 1 - grade;
            Bitmap bm = new Bitmap(1, 1);
            bm.SetPixel(0, 0, Color.FromArgb((int)(255 * grade), (int)(255 * grade), (int)(255 * grade)));
            if (steep)
                graphics.DrawImageUnscaled(bm, y, x);
            else
                graphics.DrawImageUnscaled(bm, x, y);
        }

        private void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        private void VU(Graphics g, Point start, Point finish)
        {
            int x0 = start.X;
            int y0 = start.Y;

            int x1 = finish.X;
            int y1 = finish.Y;

            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep)
            {
                Swap(ref x0, ref y0);
                Swap(ref x1, ref y1);
            }
            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }



            DrawPoint(g, steep, x0, y0, 1);
            DrawPoint(g, steep, x1, y1, 1);
            float dx = x1 - x0;
            float dy = y1 - y0;
            float gradient = dy / dx;
            float y = y0 + gradient;
            for (var x = x0 + 1; x <= x1 - 1; x++)
            {
                DrawPoint(g, steep, x, (int)y, 1 - (y - (int)y));
                DrawPoint(g, steep, x, (int)y + 1, y - (int)y);
                y += gradient;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(SystemColors.Control);

        }
    }

}
