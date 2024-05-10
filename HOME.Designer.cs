namespace BurakT_ATM
{
    partial class HOME
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 78);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(243, 22);
            label1.Name = "label1";
            label1.Size = new Size(343, 31);
            label1.TabIndex = 2;
            label1.Text = "Select Your Transaction Please";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(771, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 31);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(69, 130);
            button1.Name = "button1";
            button1.Size = new Size(257, 43);
            button1.TabIndex = 8;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(491, 130);
            button2.Name = "button2";
            button2.Size = new Size(250, 43);
            button2.TabIndex = 9;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(69, 208);
            button3.Name = "button3";
            button3.Size = new Size(257, 43);
            button3.TabIndex = 10;
            button3.Text = "Fast Cash";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(491, 208);
            button4.Name = "button4";
            button4.Size = new Size(250, 43);
            button4.TabIndex = 11;
            button4.Text = "Mini Statement";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(69, 279);
            button5.Name = "button5";
            button5.Size = new Size(257, 43);
            button5.TabIndex = 12;
            button5.Text = "Change Password";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.HotTrack;
            button6.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(491, 279);
            button6.Name = "button6";
            button6.Size = new Size(250, 43);
            button6.TabIndex = 13;
            button6.Text = "Balance";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 12);
            panel2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(354, 394);
            label5.Name = "label5";
            label5.Size = new Size(91, 31);
            label5.TabIndex = 15;
            label5.Text = "Logout";
            label5.Click += label5_Click;
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HOME";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOME";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel2;
        private Label label5;
    }
}