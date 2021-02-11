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
            panel1.Location = new Point(12, 67);
            panel2.Location = new Point(12, 67);
            panel2.Visible = false;
            button1.BackColor = Color.White;
            button2.BackColor = Color.Gray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            int[,] a = new int[5, 5];
            int x, y;
            int goodN = 0;
            int goodNC = 0;
            Random rand = new Random();
            for (x = 0; x < 5; x++)
            {
                for(y = 0;y < 5; y++)
                {
                    a[x, y] = rand.Next(-100, 100);
                }
            }
            for (x = 0; x < 5; x++)
            {
                for (y = 0; y < 5; y++)
                {
                    dataGridView1.Rows[x].Cells[y].Value =  a[x, y].ToString();
                }
            }
            for (x = 0; x < 5; x++)
            {
                if (a[x, 4] >= 0)
                {
                    goodN++;
                }
            }
            if (goodN < 3)
            {
                string otvet = "Все положительные элементы последнего столбаца = '";
                for (x = 0; x < 5; x++)
                {
                    if (a[x, 4] >= 0)
                    {
                        otvet += a[x, 4] + ", ";
                    }
                }
                richTextBox1.Text = otvet + "'";
            }
            else
            {
                int p = 0;
                for (x = 0; x < 5; x++)
                {
                    if (a[x, 4] >= 0)
                    {
                        p += a[x, 4];
                    }
                }
                string otvet = "Сумма положительных элементов последнего столбца ='" + p + "'";
                richTextBox1.Text = otvet;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int DRow = 4;
            int DCol = 4;
            dataGridView2.RowCount = DRow;
            dataGridView2.ColumnCount = DCol;
            int[,] a = new int[DRow, DCol];
            int x, y;
            int goodN = 0;
            int goodNC = 0;
            Random rand = new Random();
            for (x = 0; x < DRow; x++)
            {
                for (y = 0; y < DCol; y++)
                {
                    a[x, y] = rand.Next(0, 2);
                }
            }
            for (x = 0; x < DRow; x++)
            {
                for (y = 0; y < DCol; y++)
                {
                    dataGridView2.Rows[x].Cells[y].Value = a[x, y].ToString();
                }
            }
            string otvet = "Этот двухмерный массив симпатичный";
            for (x = 0; x < DRow -1; x++)
            {
                for (y = 0; y < DCol -1; y++)
                {
                    if ((a[x,y] == 0 && a[x + 1, y] == 0 && a[x, y + 1] == 0 && a[x + 1, y + 1] == 0) || ((a[x, y] == 1 && a[x + 1, y] == 1 && a[x, y + 1] == 1 && a[x + 1, y + 1] == 1)))
                    {
                        otvet = "Этот двухмерный массив не особо симпатичный";
                        break;
                    }
                }
            }
            richTextBox2.Text = otvet;
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
