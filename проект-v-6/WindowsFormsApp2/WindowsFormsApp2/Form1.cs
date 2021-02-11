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
            button1.BackColor = Color.White;
            button2.BackColor = Color.Gray;
            panel1.Location = new Point(12, 49);
            panel2.Location = new Point(12, 49);
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            if (textBox1.Text != "")
            {
                listBox1.Items.Insert(listBox1.SelectedItems.Count + 1, textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                richTextBox1.Text = "Выберите текст";
            }
            else 
            {
                int index = listBox1.SelectedIndex;
                string str = (string)listBox1.Items[index];
                int len = str.Length;
                int i = 0;
                string book = "йцукенгшщзхъфывапролджэячсмитьбю";
                int lenBook = book.Length;
                string otvet = "";
                while (i < len)
                {
                    int y = 0;
                    while (y < lenBook)
                    {
                        if (str[i] == book[y])
                        {
                            otvet += str[i];
                        }
                        y++;
                    }
                    i++;
                }
                richTextBox1.Text = " Ответ \r Количество букв = '" + otvet.Length + "'\r Строчный русские буквы = '" + otvet + "'";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox2.Text[textBox2.Text.Length - 1] != ' ' && textBox2.Text[0] != ' ')
            {
                listBox2.Items.Insert(listBox2.SelectedItems.Count + 1, textBox2.Text);
                textBox2.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
            {
                richTextBox2.Text = "Выберите текст";
            } 
            else
            {
                int index = listBox2.SelectedIndex;
                string str2 = (string)listBox2.Items[index];
                int len = str2.Length;
                int i = 0;
                int y = len - 1;
                string slovS = "";
                string slovP = "";
                string slovE = "";
                string otvet = "";
                while (i < len)
                {
                    if (str2[i] == ' ')
                    {
                        break;
                    }
                    slovS += str2[i];
                    i++;
                }
                while (y >= 0)
                {
                    if (str2[y] == ' ')
                    {
                        break;
                    }
                    slovE = str2[y] + slovE;
                    y--;
                }
                
                while (i <= y)
                {
                    slovP += str2[i];
                    i++;
                }
                otvet = slovE + slovP + slovS;
                richTextBox2.Text = " Ответ \r Количество  = '" + otvet.Length + "'\r Ответ = '" + otvet + "'";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.Gray;    
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.White;
            panel1.Visible = false;
            panel2.Visible = true;
        }
    }
}
