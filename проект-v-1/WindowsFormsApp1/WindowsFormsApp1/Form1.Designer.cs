namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.but_up = new System.Windows.Forms.Button();
            this.but_down = new System.Windows.Forms.Button();
            this.but_right = new System.Windows.Forms.Button();
            this.but_left = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 232);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Заполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Индивидуальное задание 10";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.but_left);
            this.panel2.Controls.Add(this.but_right);
            this.panel2.Controls.Add(this.but_down);
            this.panel2.Controls.Add(this.but_up);
            this.panel2.Location = new System.Drawing.Point(303, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 230);
            this.panel2.TabIndex = 4;
            // 
            // but_up
            // 
            this.but_up.Location = new System.Drawing.Point(111, 90);
            this.but_up.Name = "but_up";
            this.but_up.Size = new System.Drawing.Size(30, 30);
            this.but_up.TabIndex = 0;
            this.but_up.Text = "U";
            this.but_up.UseVisualStyleBackColor = true;
            this.but_up.Click += new System.EventHandler(this.but_up_Click);
            // 
            // but_down
            // 
            this.but_down.Location = new System.Drawing.Point(111, 120);
            this.but_down.Name = "but_down";
            this.but_down.Size = new System.Drawing.Size(30, 30);
            this.but_down.TabIndex = 1;
            this.but_down.Text = "D";
            this.but_down.UseVisualStyleBackColor = true;
            this.but_down.Click += new System.EventHandler(this.but_down_Click);
            // 
            // but_right
            // 
            this.but_right.Location = new System.Drawing.Point(140, 120);
            this.but_right.Name = "but_right";
            this.but_right.Size = new System.Drawing.Size(30, 30);
            this.but_right.TabIndex = 2;
            this.but_right.Text = "R";
            this.but_right.UseVisualStyleBackColor = true;
            this.but_right.Click += new System.EventHandler(this.but_right_Click);
            // 
            // but_left
            // 
            this.but_left.Location = new System.Drawing.Point(80, 120);
            this.but_left.Name = "but_left";
            this.but_left.Size = new System.Drawing.Size(30, 30);
            this.but_left.TabIndex = 3;
            this.but_left.Text = "L";
            this.but_left.UseVisualStyleBackColor = true;
            this.but_left.Click += new System.EventHandler(this.but_left_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 256);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Лаб. работа. N1 Ст. гр. 7А62  Иванов А.А.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button but_left;
        private System.Windows.Forms.Button but_right;
        private System.Windows.Forms.Button but_down;
        private System.Windows.Forms.Button but_up;
    }
}

