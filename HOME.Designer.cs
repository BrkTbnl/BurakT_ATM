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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            AccNumlbl = new Label();
            label1 = new Label();
            label2 = new Label();
            gradientPanel1 = new UiTools.GradientPanel();
            customButton1 = new UiTools.CustomButton.CustomButton();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(72, 225);
            button1.Name = "button1";
            button1.Size = new Size(257, 43);
            button1.TabIndex = 8;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(72, 321);
            button2.Name = "button2";
            button2.Size = new Size(250, 43);
            button2.TabIndex = 9;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(482, 122);
            button3.Name = "button3";
            button3.Size = new Size(257, 43);
            button3.TabIndex = 10;
            button3.Text = "Fast Cash";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(482, 225);
            button4.Name = "button4";
            button4.Size = new Size(257, 43);
            button4.TabIndex = 11;
            button4.Text = "Mini Statement";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(482, 321);
            button5.Name = "button5";
            button5.Size = new Size(257, 43);
            button5.TabIndex = 12;
            button5.Text = "Change Password";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.HotTrack;
            button6.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(72, 122);
            button6.Name = "button6";
            button6.Size = new Size(250, 43);
            button6.TabIndex = 13;
            button6.Text = "Balance";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // AccNumlbl
            // 
            AccNumlbl.AutoSize = true;
            AccNumlbl.BackColor = Color.Transparent;
            AccNumlbl.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccNumlbl.ForeColor = Color.Black;
            AccNumlbl.Location = new Point(492, 407);
            AccNumlbl.Name = "AccNumlbl";
            AccNumlbl.Size = new Size(194, 31);
            AccNumlbl.TabIndex = 16;
            AccNumlbl.Text = "Account Number";
            AccNumlbl.Click += AccNumBl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(235, 18);
            label1.Name = "label1";
            label1.Size = new Size(343, 31);
            label1.TabIndex = 2;
            label1.Text = "Select Your Transaction Please";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(768, 9);
            label2.Name = "label2";
            label2.Size = new Size(29, 31);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // gradientPanel1
            // 
            gradientPanel1.angle = 60F;
            gradientPanel1.BackColor = SystemColors.HotTrack;
            gradientPanel1.BottomColor = Color.Empty;
            gradientPanel1.Controls.Add(customButton1);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(button1);
            gradientPanel1.Controls.Add(AccNumlbl);
            gradientPanel1.Controls.Add(button2);
            gradientPanel1.Controls.Add(button3);
            gradientPanel1.Controls.Add(button4);
            gradientPanel1.Controls.Add(button6);
            gradientPanel1.Controls.Add(button5);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(800, 450);
            gradientPanel1.TabIndex = 17;
            gradientPanel1.TopColor = Color.LightSkyBlue;
            // 
            // customButton1
            // 
            customButton1.Angle = 106F;
            customButton1.BackColor = Color.Transparent;
            customButton1.BorderRadius = 30;
            customButton1.ButtonText = "Logout";
            customButton1.Color0 = SystemColors.HotTrack;
            customButton1.Color1 = Color.LightSkyBlue;
            customButton1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            customButton1.ForeColor = Color.Black;
            customButton1.Location = new Point(12, 395);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 43);
            customButton1.TabIndex = 40;
            customButton1.Click += customButton1_Click;
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HOME";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOME";
            Load += HOME_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label AccNumlbl;
        private Label label1;
        private Label label2;
        private UiTools.GradientPanel gradientPanel1;
        private UiTools.CustomButton.CustomButton customButton1;
    }
}