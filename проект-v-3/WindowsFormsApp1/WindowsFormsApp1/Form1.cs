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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double o = 0;
            if (radioButton1.Checked)
            {
               if ((x * y) > 0)
                {
                    o = Math.Pow((Math.Sinh(x) + y), 2) - Math.Sqrt(Math.Sinh(x) * y);
                }
               else if ((x * y < 0))
                {
                    o = Math.Pow((Math.Sinh(x) + y), 2) + Math.Sqrt(Math.Abs(Math.Sinh(x) * y));
                }
                else
                {
                    o = Math.Pow((Math.Sinh(x) + y), 2) + 1;
                }
            }
            else if (radioButton2.Checked)
            {
                if ((x * y) > 0)
                {
                    o = Math.Pow((Math.Pow(x, 2) + y), 2) - Math.Sqrt(Math.Pow(x, 2) * y);
                }
                else if ((x * y < 0))
                {
                    o = Math.Pow((Math.Pow(x, 2) + y), 2) + Math.Sqrt(Math.Abs(Math.Pow(x, 2) * y));
                }
                else
                {
                    o = Math.Pow((Math.Pow(x, 2) + y), 2) + 1;
                }
            }
            else
            {
                if ((x * y) > 0)
                {
                    o = Math.Pow((Math.Exp(x) + y), 2) - Math.Sqrt(Math.Exp(x) * y);
                }
                else if ((x * y < 0))
                {
                    o = Math.Pow((Math.Exp(x) + y), 2) + Math.Sqrt(Math.Abs(Math.Exp(x) * y));
                }
                else
                {
                    o = Math.Pow((Math.Exp(x) + y), 2) + 1;
                }
            }
            richTextBox1.Text = "Задача №1 \r X = " + textBox1.Text + "\r Y = "+ textBox2.Text + "\r Ответ = " + o;
        } 
            else
            {
                MessageBox.Show("Введите X и Y");
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "") { 
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double o = 0;
            if (radioButton1.Checked)
            {
                if ((x / y) > 0)
                {
                    o = Math.Log(Math.Sinh(x)) + Math.Pow((Math.Pow(Math.Sinh(x), 2) + y), 3);
                }
                else if ((x / y < 0))
                {
                    o = Math.Abs(Math.Sinh(x) / y) + Math.Pow((Math.Sinh(x) + y) ,3);
                }
                else if (x == 0)
                {
                    o = Math.Pow((Math.Pow(Math.Sinh(x) ,2) + y), 3);
                }
                else 
                {
                    o = 0;
                }
            }
            else if (radioButton2.Checked)
            {
                if ((x / y) > 0)
                {
                    o = Math.Log(Math.Pow(x, 2)) + Math.Pow((Math.Pow(Math.Pow(x, 2), 2) + y), 3);
                }
                else if ((x / y < 0))
                {
                    o = Math.Abs(Math.Pow(x, 2) / y) + Math.Pow((Math.Pow(x, 2) + y), 3);
                }
                else if (x == 0)
                {
                    o = Math.Pow((Math.Pow(Math.Pow(x, 2), 2) + y), 3);
                }
                else
                {
                    o = 0;
                }
            }
            else
            {
                if ((x / y) > 0)
                {
                    o = Math.Log(Math.Exp(x)) + Math.Pow((Math.Pow(Math.Exp(x), 2) + y), 3);
                }
                else if ((x / y < 0))
                {
                    o = Math.Abs(Math.Exp(x) / y) + Math.Pow((Math.Exp(x) + y), 3);
                }
                else if (x == 0)
                {
                    o = Math.Pow((Math.Pow(Math.Exp(x), 2) + y), 3);
                }
                else
                {
                    o = 0;
                }
            }
            richTextBox1.Text = "Задача №1 \r X = " + textBox1.Text + "\r Y = " + textBox2.Text + "\r Ответ = " + o;
        
            } 
            else
            {
                MessageBox.Show("Введите X и Y");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                double o = 0;
                if (radioButton1.Checked)
                {
                    if ((x - y) == 0)
                    {
                        o = Math.Pow(Math.Sinh(x), 2) + Math.Pow(y, 2) + Math.Sin(y);
                    }
                    else if ((x - y > 0))
                    {
                        o = Math.Pow((Math.Sinh(x) - y), 2) + Math.Cos(y);
                    }
                    else
                    {
                        o = Math.Pow((y - Math.Sinh(x)), 2) + Math.Tan(y);
                    }
                    
                }
                else if (radioButton2.Checked)
                {
                    if ((x - y) == 0)
                    {
                        o = Math.Pow(Math.Pow(x, 2), 2) + Math.Pow(y, 2) + Math.Sin(y);
                    }
                    else if ((x - y > 0))
                    {
                        o = Math.Pow((Math.Pow(x, 2) - y), 2) + Math.Cos(y);
                    }
                    else
                    {
                        o = Math.Pow((y - Math.Pow(x, 2)), 2) + Math.Tan(y);
                    }
                }
                else
                {
                    if ((x - y) == 0)
                    {
                        o = Math.Pow(Math.Exp(x), 2) + Math.Pow(y, 2) + Math.Sin(y);
                    }
                    else if ((x - y > 0))
                    {
                        o = Math.Pow((Math.Exp(x) - y), 2) + Math.Cos(y);
                    }
                    else
                    {
                        o = Math.Pow((y - Math.Exp(x)), 2) + Math.Tan(y);
                    }
                }
                richTextBox1.Text = "Задача №3 \r X = " + textBox1.Text + "\r Y = " + textBox2.Text + "\r Ответ = " + o;

            }
            else
            {
                MessageBox.Show("Введите X и Y");
            }
        }
    }
}
