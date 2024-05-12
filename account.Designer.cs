
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
            label12 = new Label();
            AccNametb = new TextBox();
            AccNumTb = new TextBox();
            Addresstb = new TextBox();
            FanameTb = new TextBox();
            pintb = new TextBox();
            PhoneTb = new TextBox();
            educationcb = new ComboBox();
            dobdate = new DateTimePicker();
            button1 = new Button();
            panel2 = new Panel();
            label13 = new Label();
            occupationtb = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(198, 22);
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
            label2.Location = new Point(611, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 31);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click;
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
            label5.Click += Label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 147);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 11;
            label3.Text = "NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(0, 187);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 12;
            label4.Text = "FNAME";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(0, 237);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 13;
            label6.Text = "ADDRESS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(278, 237);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 14;
            label7.Text = "PHONE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(278, 147);
            label8.Name = "label8";
            label8.Size = new Size(143, 25);
            label8.TabIndex = 15;
            label8.Text = "EDUCATION";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(278, 187);
            label9.Name = "label9";
            label9.Size = new Size(160, 25);
            label9.TabIndex = 16;
            label9.Text = "OCCUPATION";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(278, 288);
            label10.Name = "label10";
            label10.Size = new Size(74, 25);
            label10.TabIndex = 17;
            label10.Text = "D.O.B";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(278, 99);
            label12.Name = "label12";
            label12.Size = new Size(49, 25);
            label12.TabIndex = 19;
            label12.Text = "PIN";
            // 
            // AccNametb
            // 
            AccNametb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            AccNametb.Location = new Point(126, 138);
            AccNametb.Name = "AccNametb";
            AccNametb.Size = new Size(146, 31);
            AccNametb.TabIndex = 21;
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            AccNumTb.Location = new Point(126, 96);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(146, 31);
            AccNumTb.TabIndex = 20;
            // 
            // Addresstb
            // 
            Addresstb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            Addresstb.Location = new Point(126, 231);
            Addresstb.Multiline = true;
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(146, 98);
            Addresstb.TabIndex = 23;
            // 
            // FanameTb
            // 
            FanameTb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            FanameTb.Location = new Point(126, 181);
            FanameTb.Name = "FanameTb";
            FanameTb.Size = new Size(146, 31);
            FanameTb.TabIndex = 22;
            // 
            // pintb
            // 
            pintb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            pintb.Location = new Point(438, 93);
            pintb.Name = "pintb";
            pintb.Size = new Size(163, 31);
            pintb.TabIndex = 24;
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            PhoneTb.Location = new Point(438, 231);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(146, 31);
            PhoneTb.TabIndex = 28;
            // 
            // educationcb
            // 
            educationcb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            educationcb.FormattingEnabled = true;
            educationcb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            educationcb.Location = new Point(438, 139);
            educationcb.Name = "educationcb";
            educationcb.Size = new Size(163, 33);
            educationcb.TabIndex = 30;
            // 
            // dobdate
            // 
            dobdate.CalendarFont = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            dobdate.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            dobdate.Location = new Point(436, 283);
            dobdate.Name = "dobdate";
            dobdate.Size = new Size(165, 31);
            dobdate.TabIndex = 32;
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
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            label13.Click += label13_Click;
            // 
            // occupationtb
            // 
            occupationtb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            occupationtb.Location = new Point(438, 181);
            occupationtb.Name = "occupationtb";
            occupationtb.Size = new Size(163, 31);
            occupationtb.TabIndex = 36;
            // 
            // account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 432);
            ControlBox = false;
            Controls.Add(occupationtb);
            Controls.Add(label13);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(dobdate);
            Controls.Add(educationcb);
            Controls.Add(PhoneTb);
            Controls.Add(pintb);
            Controls.Add(Addresstb);
            Controls.Add(FanameTb);
            Controls.Add(AccNametb);
            Controls.Add(AccNumTb);
            Controls.Add(label12);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "account";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private Label label12;
        private TextBox AccNametb;
        private TextBox AccNumTb;
        private TextBox Addresstb;
        private TextBox FanameTb;
        private TextBox pintb;
        private TextBox PhoneTb;
        private ComboBox educationcb;
        private DateTimePicker dobdate;
        private Button button1;
        private Panel panel2;
        private Label label13;
        private TextBox occupationtb;
    }
}