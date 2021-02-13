using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, xp1, xp2, xp3, xp5;
        private int k1, l1, k2, l2, k3, l3, k4, l4, k5, l5, k6, l6, p1, o1, p2, o2, p3, o3, o4, p4, o5, p5 ;
        private double px1, px2, py, ox;
        private Pen pen = new Pen(Color.Black, 2);
        int y = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i <= 750; i += 150)
            {
                g.DrawLine(pen, x1 + i, y1, x2 + i, y2);
                g.DrawLine(pen, x2 + i, y2, x3 + i, y3);
                g.DrawLine(pen, x3 + i, y3, x4 + i, y4);
                g.DrawLine(pen, x4 + i, y4, x5 + i, y5);
                g.DrawLine(pen, x5 + i, y5, x1 + i, y1);

            }
            g.DrawLine(pen, k1, l1, k2, l2);
            g.DrawLine(pen, k2, l2, k3, l3);
            g.DrawLine(pen, k3, l3, k4, l4);
            g.DrawLine(pen, k4, l4, k5, l5);
            g.DrawLine(pen, k5, l5, k6, l6);
            g.DrawLine(pen, k6, l6, k1, l1);
            g.DrawEllipse(pen, p1, o1, 25, 25);
            g.DrawEllipse(pen, p1 + 30, o1, 25, 25);




        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
        if (x1 == xp2)
            {
                x1 = xp1;
                x2 = xp2;
                x3 = xp3;
                x5 = xp5;
            }
            y1 += (int)py;
            y2 += (int)py;
            y3 += (int)py;
            y4 += (int)py;
            y5 += (int)py;
            if (y5 >= ClientSize.Height)
            {
                y1 -= ClientSize.Height;
                y2 -= ClientSize.Height;
                y3 -= ClientSize.Height;
                y4 -= ClientSize.Height;
                y5 -= ClientSize.Height;
            }
            x1 = x1 + (int)px1;
            x2 = x2 - (int)px1;
            x3 = x3 + (int)px2;
            x5 = x5 - (int)px2;

            k1 += (int)ox;
            k2 += (int)ox;
            k3 += (int)ox;
            k4 += (int)ox;
            k5 += (int)ox;
            k6 += (int)ox;
            p1 += (int)ox;
            Invalidate();
            
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            zvezda(y);
            car(y);
            elips_car(y);
            py = ClientSize.Height / 100;
            ox = ClientSize.Width / 500;

        }
        private void zvezda(int i)
        {
            x1 = i;
            y1 = (int)py + 95;
            x2 = i + 70;
            y2 = (int)py + 95;
            x3 = i + 15;
            y3 = (int)py + 130;
            x4 = i + 35;
            y4 = (int)py + 75;
            x5 = i + 55;
            y5 = (int)py + 130;
            px1 = (x2 - x1) / 10;
            px2 = (x5 - x3) / 10;
            xp1 = x1;
            xp2 = x2;
            xp3 = x3;
            xp5 = x5;
        }
        private void car(int i)
        {
            k1 = i + 20;
            l1 = 105;
            k2 = i + 80;
            l2 = 105;
            k3 = i + 90;
            l3 = 130;
            k4 = i + 90;
            l4 = 140;
            k5 = i + 20;
            l5 = 140;
            k6 = i + 20;
            l6 = 130;
            
        }
        private void elips_car(int i)
        {
            p1 = k1 + 5;
            o1 = l2 + 20;
            
        }
    }
}
