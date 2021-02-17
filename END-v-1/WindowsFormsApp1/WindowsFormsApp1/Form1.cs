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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
            {
                MessageBox.Show("Please fill in the line!!!");
            }
            else
            {
                int y = int.Parse(textBox1.Text);
            
                int k = 1;
                int j = 0;
                int p = 0;
                string mas = "";
                while (y != j)
                {
                    
                    
                    for (int l = 1; l <= k; l++)
                    {
                        mas = "";
                        int i = k;
                        label3.Text = "1 year = '" + i.ToString() + "'";
                        mas += "year[1]  Y=" + i + "\r";
                        j = i - l;
                        label4.Text = "2 year = '" + j.ToString() + "'";
                        label2.Text = "Взял = '"+ l +"'";
                        mas += "year[2]  Y=" + j + "\r";
                        for (int g = 3; g <= 20; g++)
                        {
                            
                            p = i;
                            i = j;
                            j += p;
                            mas += "year[" + g + "][" + p + "," + i + "]  Y=" + j + "\r";
                            if (j == y) break;
                        }
                        if (j == y) break;

                    }

                    k++;


                }
                
                richTextBox1.Text = mas;
            }
        }
    }
}
