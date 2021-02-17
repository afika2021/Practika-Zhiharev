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

        int panels = 3;
        void Any_but(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            for (int i = 1; i <= panels; i++)
            {
                Controls["button" + i].BackColor = Color.Gray;
                Controls["button" + i].Width = 150;
            }
            Controls[name].BackColor = Color.White;
            Controls[name].Width = 150;

            for (int i = 1; i <= panels; i++)
            {
                Controls["panel" + i].Visible = false;
            }
            Controls["panel" + name[name.Length - 1]].Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= panels; i++)
            {
                Controls["button" + i].BackColor = Color.Gray;
                Controls["button" + i].Width = 150;
            }
            Controls["button1"].BackColor = Color.White;
            Controls["button1"].Width = 150;

            for (int i = 1; i <= panels; i++)
            {
                Controls["panel" + i].Location = new Point(166, 12);
                Controls["panel" + i].Visible = false;
            }
            Controls["panel1"].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Any_but(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Any_but(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Any_but(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string azb = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNMЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮйцукенгшщзхъфывапролджэячсмитьбю";
            string azB = "QWERTYUIOPASDFGHJKLZXCVBNMЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
            int leng = rand.Next(10, 200);
            string[] otv = new string[leng];
            string otvet = "";
            richTextBox1.Text = "Массив строчный: ";
            for (int i = 0; i <= leng - 1; i++)
            {
                int randp = rand.Next(0, azb.Length - 1);
                otv[i] = Char.ToString(azb[randp]);
                int y = 0;
                richTextBox1.Text += otv[i];
                while(y < azB.Length - 1)
                {
                    if (Char.ToString(azB[y]) == otv[i])
                    {
                        otvet += otv[i];
                    }
                    y++;
                }
            }
            richTextBox1.Text += "\r\rОтвет: " + otvet + "\r\rКоличество :" + otvet.Length;
            
        }
    }
}
