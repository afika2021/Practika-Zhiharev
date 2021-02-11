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
            this.q1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.q2 = new System.Windows.Forms.Panel();
            this.q3 = new System.Windows.Forms.Panel();
            this.localX = new System.Windows.Forms.Label();
            this.LocalY = new System.Windows.Forms.Label();
            this.q1.SuspendLayout();
            this.SuspendLayout();
            // 
            // q1
            // 
            this.q1.BackColor = System.Drawing.SystemColors.ControlText;
            this.q1.Controls.Add(this.LocalY);
            this.q1.Controls.Add(this.localX);
            this.q1.Location = new System.Drawing.Point(500, 50);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(480, 410);
            this.q1.TabIndex = 0;
            this.q1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.q1_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(7, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Задание №1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(126, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Задание №10";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(276, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Задание №20";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // q2
            // 
            this.q2.BackColor = System.Drawing.SystemColors.ControlText;
            this.q2.Location = new System.Drawing.Point(500, 46);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(480, 410);
            this.q2.TabIndex = 4;
            this.q2.Visible = false;
            this.q2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.q2_MouseClick);
            // 
            // q3
            // 
            this.q3.BackColor = System.Drawing.SystemColors.ControlText;
            this.q3.Location = new System.Drawing.Point(0, 40);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(480, 410);
            this.q3.TabIndex = 4;
            this.q3.Visible = false;
            this.q3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.q3_MouseClick);
            // 
            // localX
            // 
            this.localX.AutoSize = true;
            this.localX.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localX.ForeColor = System.Drawing.Color.Lime;
            this.localX.Location = new System.Drawing.Point(399, 10);
            this.localX.Name = "localX";
            this.localX.Size = new System.Drawing.Size(15, 23);
            this.localX.TabIndex = 6;
            this.localX.Text = "0";
            // 
            // LocalY
            // 
            this.LocalY.AutoSize = true;
            this.LocalY.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalY.ForeColor = System.Drawing.Color.Lime;
            this.LocalY.Location = new System.Drawing.Point(435, 10);
            this.LocalY.Name = "LocalY";
            this.LocalY.Size = new System.Drawing.Size(15, 23);
            this.LocalY.TabIndex = 7;
            this.LocalY.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.q3);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.q1);
            this.Name = "Form1";
            this.Text = "Задание №1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.q1.ResumeLayout(false);
            this.q1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel q1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel q2;
        private System.Windows.Forms.Panel q3;
        private System.Windows.Forms.Label LocalY;
        private System.Windows.Forms.Label localX;
    }
}

