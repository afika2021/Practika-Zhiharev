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
        int q3X = -50;
        int q3Y = -20;
        int q3I = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White ;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            q1.Visible = true;
            q2.Visible = false;
            q3.Visible = false;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.White;
            button3.BackColor = Color.Gray;
            q1.Visible = false;
            q2.Visible = true;
            q3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.White;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            q1.Location = new Point(0, 50);
            q2.Location = new Point(0, 50);
            q3.Location = new Point(0, 50);
            button1.BackColor = Color.White;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
        }

        private void q1_MouseClick(object sender, MouseEventArgs e)
        {   
            
            Button LocalBut = new Button();
            q1.Controls.Add(LocalBut);
            LocalBut.Location = new Point(e.X - 25, e.Y - 25);
            LocalBut.Name = "LocalBut";
            LocalBut.Size = new Size(50, 50);
            LocalBut.BackColor = Color.White;
            LocalBut.Text = (LocalBut.Location.X + 25) + " " + (LocalBut.Location.Y + 25) ;
            localX.Text = (LocalBut.Location.X + 25).ToString() ;
            LocalY.Text = (LocalBut.Location.Y + 25).ToString();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void q2_MouseClick(object sender, MouseEventArgs e)
        {
            Button LocalBut2 = new Button();
            q2.Controls.Add(LocalBut2);
            LocalBut2.Location = new Point(e.X - 25, e.Y - 25);
            LocalBut2.Name = "LocalBut2";
            LocalBut2.Size = new Size(50, 50);
            LocalBut2.BackColor = Color.White;
            LocalBut2.Text = (LocalBut2.Location.X + 25) + " " + (LocalBut2.Location.Y + 25);

            if (e.Button == MouseButtons.Right)
            {
                q2.Controls.Clear();
            }
        }

        private void q3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (q3X >= q3.Size.Width - 30)
                {
                    q3X = 0;
                    q3Y += 20;
                }
                else 
                {
                    q3X += 50;
                }
                Button LocalBut2 = new Button();
                q3.Controls.Add(LocalBut2);
                LocalBut2.Location = new Point( q3X, q3Y);
                LocalBut2.Size = new Size(50, 10);
                LocalBut2.BackColor = Color.White;
            } 
            else
            {
                if (q3X >= q3.Size.Width - 30)
                {
                    q3X = 0;
                    q3Y += 20;
                }
                else
                {
                    q3X += 50;
                }
                TextBox LocalText = new TextBox();
                q3.Controls.Add(LocalText);
                LocalText.Location = new Point(q3X,q3Y);
                LocalText.Size = new Size(50, 10);
                LocalText.BackColor = Color.White;
            }
            
             
            
        }
    }
}
