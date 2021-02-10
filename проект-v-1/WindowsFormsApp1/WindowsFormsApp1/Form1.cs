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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text ="";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "******";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "*****";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void but_up_Click(object sender, EventArgs e)
        {
            if (but_up.Location.Y != 0)
            {
                but_up.Location = new Point(but_up.Location.X, but_up.Location.Y - 10);
                but_down.Location = new Point(but_down.Location.X, but_down.Location.Y - 10);
                but_left.Location = new Point(but_left.Location.X, but_left.Location.Y - 10);
                but_right.Location = new Point(but_right.Location.X, but_right.Location.Y - 10);

            }
        }

        private void but_down_Click(object sender, EventArgs e)
        {
            if (but_down.Location.Y != 200)
            {
                but_up.Location = new Point(but_up.Location.X, but_up.Location.Y + 10);
                but_down.Location = new Point(but_down.Location.X, but_down.Location.Y + 10);
                but_left.Location = new Point(but_left.Location.X, but_left.Location.Y + 10);
                but_right.Location = new Point(but_right.Location.X, but_right.Location.Y + 10);

            }
        }

        private void but_right_Click(object sender, EventArgs e)
        {
            if (but_right.Location.X != 220)
            {
                but_up.Location = new Point(but_up.Location.X + 10, but_up.Location.Y);
                but_down.Location = new Point(but_down.Location.X + 10, but_down.Location.Y);
                but_left.Location = new Point(but_left.Location.X + 10, but_left.Location.Y);
                but_right.Location = new Point(but_right.Location.X + 10, but_right.Location.Y);

            }
        }

        private void but_left_Click(object sender, EventArgs e)
        {
            if (but_left.Location.X != 0)
            {
                but_up.Location = new Point(but_up.Location.X - 10, but_up.Location.Y);
                but_down.Location = new Point(but_down.Location.X - 10, but_down.Location.Y);
                but_left.Location = new Point(but_left.Location.X - 10, but_left.Location.Y);
                but_right.Location = new Point(but_right.Location.X - 10, but_right.Location.Y);

            }
        }
    }
}
