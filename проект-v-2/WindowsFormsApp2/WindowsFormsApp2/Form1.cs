using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                double o = 0;
                double x = double.Parse(textBox2.Text);
                double y = double.Parse(textBox3.Text);
                double z = double.Parse(textBox4.Text);
                double elera = 2.7182818284;


                o = Math.Pow(2, -x) * (Math.Sqrt(x + Math.Pow(Math.Abs(y), 1.0 / 4.0))) * (Math.Pow(Math.Pow(elera, x - 1 / Math.Sin(z)), 1.0 / 3.0));
                richTextBox1.Text += "Ответ на задачу №10 = '" + o  + "'\r";
            }
            else
            {
                MessageBox.Show("Введите все переменные из задачи №10");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox5.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            { 
                double o = 0;
                double a = double.Parse(textBox1.Text);
                double c = double.Parse(textBox5.Text);
                double d = double.Parse(textBox7.Text);
                double x = double.Parse(textBox8.Text);
                double elera = 2.7182818284;


                o = Math.Sqrt((c - d * Math.Pow(x, 2)) / x) + ((Math.Log(Math.Pow(x, 2) + c)) / (0.7 * x + a * d))  - (Math.Pow(10, -2) / (c - d * Math.Pow(x, 3))); 
                richTextBox1.Text += "Ответ на задачу №20 = '" + o + "'\r";
            }
            else
            {
                MessageBox.Show("Введите все переменные из задачи №20");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "" && textBox10.Text != "" && textBox9.Text != "")
            {
                double o = 0;
                double x = double.Parse(textBox11.Text);
                double y = double.Parse(textBox10.Text);
                double z = double.Parse(textBox9.Text);
                double elera = 2.7182818284;

                o = 5 * Math.Atan(x) - ((1 / 4) * Math.Acos(x)) * ((x + 3 * Math.Abs(x - y) + Math.Pow(x , 2)) / (Math.Abs(x - y) * z + Math.Pow(x, 2)));
                richTextBox1.Text += "Ответ на задачу №7 = '" + o + "'\r";
            }
            else
            {
                MessageBox.Show("Введите все переменные из задачи №7");
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
