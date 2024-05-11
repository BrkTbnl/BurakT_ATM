namespace BurakT_ATM
{
    partial class account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox9 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            panel2 = new Panel();
            label13 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(204, 21);
            label1.Name = "label1";
            label1.Size = new Size(287, 31);
            label1.TabIndex = 2;
            label1.Text = "ATM Management System";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 78);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(660, 9);
            label2.Name = "label2";
            label2.Size = new Size(29, 31);
            label2.TabIndex = 3;
            label2.Text = "X";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(0, 102);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 10;
            label5.Text = "ACC NUM";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 147);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 11;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(0, 187);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 12;
            label4.Text = "Surname";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(0, 237);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 13;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(0, 288);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 14;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(301, 184);
            label8.Name = "label8";
            label8.Size = new Size(117, 25);
            label8.TabIndex = 15;
            label8.Text = "Education";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(301, 234);
            label9.Name = "label9";
            label9.Size = new Size(131, 25);
            label9.TabIndex = 16;
            label9.Text = "Occupation";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(301, 288);
            label10.Name = "label10";
            label10.Size = new Size(74, 25);
            label10.TabIndex = 17;
            label10.Text = "D.O.B";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(301, 144);
            label11.Name = "label11";
            label11.Size = new Size(97, 25);
            label11.TabIndex = 18;
            label11.Text = "Balance";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(301, 99);
            label12.Name = "label12";
            label12.Size = new Size(49, 25);
            label12.TabIndex = 19;
            label12.Text = "PIN";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            textBox2.Location = new Point(113, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 31);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            textBox1.Location = new Point(113, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 31);
            textBox1.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            textBox3.Location = new Point(113, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 31);
            textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            textBox4.Location = new Point(113, 181);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 31);
            textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            textBox5.Location = new Point(438, 138);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(163, 31);
            textBox5.TabIndex = 25;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            textBox6.Location = new Point(438, 93);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(163, 31);
            textBox6.TabIndex = 24;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            textBox9.Location = new Point(113, 282);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(146, 31);
            textBox9.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(440, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 33);
            comboBox1.TabIndex = 30;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(440, 229);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(165, 33);
            comboBox2.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(440, 282);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 31);
            dateTimePicker1.TabIndex = 32;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(258, 335);
            button1.Name = "button1";
            button1.Size = new Size(149, 43);
            button1.TabIndex = 33;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 416);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 16);
            panel2.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(291, 381);
            label13.Name = "label13";
            label13.Size = new Size(84, 25);
            label13.TabIndex = 35;
            label13.Text = "Logout";
            // 
            // account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 432);
            ControlBox = false;
            Controls.Add(label13);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox9);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "account";
            RightToLeft = RightToLeft.Yes;
            Text = "account";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox9;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Panel panel2;
        private Label label13;
    }
}