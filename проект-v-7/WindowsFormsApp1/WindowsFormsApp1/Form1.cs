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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] Q = new double[20];
            Random rand = new Random();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                Q[i] = rand.Next(0, 100);
                listBox1.Items.Insert(listBox1.SelectedItems.Count, "Q[" + i +"] = '" + Q[i] + "'");
            }
            for (int i = 0; i < 20; i++)
            {
               if ((Q[i] / 7 == 5) || (Q[i] / 7 == 1) || (Q[i] / 7 == 2))
                {
                    listBox2.Items.Insert(listBox1.SelectedItems.Count, "Q[" + i + "] = '" + Q[i] + "'");
                }
               
            }
            if (listBox2.Items.Count == 0)
            {
                listBox2.Items.Insert(listBox1.SelectedItems.Count, "В этом массиве нету элементов которые");
                listBox2.Items.Insert(listBox1.SelectedItems.Count + 1, "делясь на '7' получают остаток '5, 1, 2'");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.Gray;
            panel1.Location = new Point(12, 54);
            panel2.Location = new Point(12, 54);
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            button1.BackColor = Color.White;
            button2.BackColor = Color.Gray;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.White;
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double[] K = new double[30];
            Random rand = new Random();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            for (int i = 0; i < 30; i++)
            {
                K[i] = rand.Next(0, 1000);
                listBox4.Items.Insert(listBox4.SelectedItems.Count, "K[" + i + "] = '" + K[i] + "'");
            }
            double perem1 = 0;
            double perem2 = 0;
            double perem3 = 0;
            for (int i = 2; i < 30; i++)
            {
                perem1 = K[i - 2];
                perem2 = K[i - 1];
                perem3 = K[i];
                if (perem2 > perem1 && perem2 > perem3)
                {
                    listBox3.Items.Insert(listBox3.SelectedItems.Count, "K[" + (i - 1) + "] = '" + perem2 + "'");
                }
            }
            
            
        }
    }
}
