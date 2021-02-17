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
        int panels = 3;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Any_B(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls["button" + 1].BackColor = Color.White;
            Controls["button" + 1].Width = 150;
            for (int i = 2; i <= panels; i++)
            {
                Controls["button" + i].BackColor = Color.Gray;
                Controls["button" + i].Width = 150;
            }
            
            for (int i = 1; i <= panels; i++)
            {
                Controls["panel" + i].Location = new Point(217, 11);
            }
            for (int i = 2; i <= panels; i++)
            {
                Controls["panel" + i].Visible = false;
            }

        }

        class ZP
        {
            internal double z;
            internal double k = 0.30;
            public ZP(double z)
            {
                this.z = z * k + z;
                
            }
            
        }
        void Any_B(object sender, EventArgs e)
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
        private void button13_Click(object sender, EventArgs e)
        {
            ZP z = new ZP(double.Parse(textBox2.Text));
            richTextBox1.Text = "Сотрудник : " + textBox1.Text +" \r Зарпалата : " + textBox2.Text +
                " \r \r Коффицент : " + z.k * 100 + "% \r Увеличенная зарплата : " + z.z;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Any_B(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Any_B(sender, e);
        }

        class pr2
        {
            internal double stoim;
            public pr2(double x, double y)
            {
                stoim = x * y;
            }
            
        }
        private void button14_Click(object sender, EventArgs e)
        {
            pr2 z = new pr2(double.Parse(textBox3.Text), double.Parse(textBox7.Text));
            
            richTextBox2.Text = "Поле : " + textBox4.Text + " \r Агров : " + textBox3.Text +"\r Цена за м^2: " + textBox7.Text +
                " \r \r Стоимость поля : " + z.stoim;
        }

        class pr3
        {
            internal double otvet;
            internal double k;
            public pr3(string o, double x, double y)
            {
                if (o == "Рис")
                {
                    k = 0.3;
                }else if (o == "Греча")
                {
                    k = 0.2;
                } else if(o == "Пшено")
                {
                    k = 0.1;
                }
                otvet = (x * k + x) * y;
            }
            public pr3(double x, double y)
            {
                k = 0;
                otvet = (x * k + x) * y;
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            pr3 z = new pr3(comboBox1.Text, double.Parse(textBox5.Text), double.Parse(textBox8.Text));
            richTextBox3.Text = "Культура : " + comboBox1.Text + "\rВес посеянных семян на единицу площади: " + textBox5.Text + "\rПлощадь в га: " + textBox8.Text + 
                "\r\rКоффицент : " + z.k * 100 + "%\rОтвет : " + z.otvet;
        }
    }
}
