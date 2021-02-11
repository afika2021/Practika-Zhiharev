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
            panel1.Location = new Point(17, 51);
            panel2.Location = new Point(17, 51);
            panel3.Location = new Point(17, 51);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "")
            {
                MessageBox.Show("Введите все переменные !!!");
            }
            else
            {
                double xo = double.Parse(textBox1.Text);
                double xk = double.Parse(textBox2.Text);
                double dx = double.Parse(textBox3.Text);
                double a = double.Parse(textBox4.Text);
                double b = double.Parse(textBox5.Text);
                double c = double.Parse(textBox6.Text);
                double x = xo;
                double xf = (xk - xo) / dx;
                double otvet = 0;

                richTextBox1.Text = "Задача № 1: \r";
                if (dx < 0)
                {
                    while (x >= xk)
                    {
                        otvet = Math.Pow(10, -2) * b * c / x + Math.Cos(Math.Sqrt(Math.Pow(a, 3) * x));
                        richTextBox1.Text += "x = '" + x + "' ;y = '" + otvet + "'\r";
                        x += dx;
                    }
                } 
                else
                {
                    while (x <= xk)
                    {
                        otvet = Math.Pow(10, -2) * b * c / x + Math.Cos(Math.Sqrt(Math.Pow(a, 3) * x));
                        richTextBox1.Text += "x = '" + x + "' ;y = '" + otvet + "'\r";
                        x += dx;
                    }
                }
              

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "" && textBox9.Text == "" && textBox10.Text == "" && textBox11.Text == "" && textBox12.Text == "" )
            {
                MessageBox.Show("Введите все пременные !!!");
            }
            else
            {
                double xo = double.Parse(textBox12.Text);
                double xk = double.Parse(textBox11.Text);
                double dx = double.Parse(textBox10.Text);
                double a = double.Parse(textBox9.Text);
                double b = double.Parse(textBox8.Text);
                double x = xo;
                double otvet = 0;
                richTextBox2.Text = "Задача № 2: \r";
                if (dx < 0){
                    while (x >= xk)
                    {
                        otvet = 1.2 * Math.Pow((a - b), 3) * Math.Exp(Math.Pow(x, 2)) + x;
                        richTextBox2.Text += "x = '" + x + "'; y = '" + otvet + "'\r";
                        x += dx;
                    }
                }
                else
                {
                    while (x <= xk)
                    {
                        otvet = 1.2 * Math.Pow((a - b), 3) * Math.Exp(Math.Pow(x, 2)) + x;
                        richTextBox2.Text += "x = '" + x + "'; y = '" + otvet + "'\r";
                        x += dx;
                    }
                }
                

            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" && textBox13.Text == "" && textBox14.Text == "" && textBox15.Text == "" && textBox16.Text == "")
            {
                MessageBox.Show("Введите все пременные !!!");
            }
            else
            {
                double xo = double.Parse(textBox16.Text);
                double xk = double.Parse(textBox15.Text);
                double dx = double.Parse(textBox14.Text);
                double a = double.Parse(textBox13.Text);
                double b = double.Parse(textBox7.Text);
                double x = xo;
                double otvet = 0;
                richTextBox3.Text = "Задача № 3: \r";
                if (dx < 0)
                {
                    while (x >= xk)
                    {
                        otvet = Math.Pow(10, -1) * a * Math.Pow(x, 3) * Math.Tan(a - b * x);
                        richTextBox3.Text += "x = '" + x + "'; y = '" + otvet + "'\r";
                        x += dx;
                    }
                }
                else
                {
                    while (x <= xk)
                    {
                        otvet = Math.Pow(10, -1) * a * Math.Pow(x, 3) * Math.Tan(a - b * x);
                        richTextBox3.Text += "x = '" + x + "'; y = '" + otvet + "'\r";
                        x += dx;
                    }
                }


            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
