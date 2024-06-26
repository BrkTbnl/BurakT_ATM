﻿using BurakT_ATM.UiTools;

namespace BurakT_ATM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            AccNumTb = new TextBox();
            PinTb = new TextBox();
            label2 = new Label();
            gradientPanel1 = new GradientPanel();
            customButton2 = new UiTools.CustomButton.CustomButton();
            customButton1 = new UiTools.CustomButton.CustomButton();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(554, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(19, 167);
            label3.Name = "label3";
            label3.Size = new Size(194, 31);
            label3.TabIndex = 3;
            label3.Text = "Account Number";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(19, 235);
            label4.Name = "label4";
            label4.Size = new Size(119, 31);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            AccNumTb.Location = new Point(241, 160);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(236, 38);
            AccNumTb.TabIndex = 5;
            // 
            // PinTb
            // 
            PinTb.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            PinTb.Location = new Point(241, 228);
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(236, 38);
            PinTb.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(375, 27);
            label2.Name = "label2";
            label2.Size = new Size(84, 31);
            label2.TabIndex = 8;
            label2.Text = "LOGIN";
            // 
            // gradientPanel1
            // 
            gradientPanel1.angle = 0F;
            gradientPanel1.BackColor = SystemColors.HotTrack;
            gradientPanel1.BottomColor = Color.Empty;
            gradientPanel1.Controls.Add(customButton2);
            gradientPanel1.Controls.Add(customButton1);
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(PinTb);
            gradientPanel1.Controls.Add(AccNumTb);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(800, 450);
            gradientPanel1.TabIndex = 10;
            gradientPanel1.Tag = "Login";
            gradientPanel1.TopColor = Color.LightSkyBlue;
            gradientPanel1.Paint += gradientPanel1_Paint;
            // 
            // customButton2
            // 
            customButton2.Angle = 306F;
            customButton2.BackColor = Color.Transparent;
            customButton2.BorderRadius = 30;
            customButton2.ButtonText = "Sign-Up";
            customButton2.Color0 = SystemColors.HotTrack;
            customButton2.Color1 = Color.LightSkyBlue;
            customButton2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            customButton2.ForeColor = Color.Black;
            customButton2.Location = new Point(19, 387);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(150, 43);
            customButton2.TabIndex = 13;
            customButton2.Click += customButton2_Click;
            // 
            // customButton1
            // 
            customButton1.Angle = 242F;
            customButton1.BackColor = Color.Transparent;
            customButton1.BorderRadius = 30;
            customButton1.ButtonText = "Login";
            customButton1.Color0 = SystemColors.HotTrack;
            customButton1.Color1 = Color.LightSkyBlue;
            customButton1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            customButton1.ForeColor = Color.Black;
            customButton1.Location = new Point(626, 387);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 43);
            customButton1.TabIndex = 12;
            customButton1.Click += customButton1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(759, 9);
            label6.Name = "label6";
            label6.Size = new Size(29, 31);
            label6.TabIndex = 11;
            label6.Text = "X";
            label6.Click += label6_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox AccNumTb;
        private TextBox PinTb;
        private Label label2;
        private GradientPanel gradientPanel1;
        private Label label6;
        private UiTools.CustomButton.CustomButton customButton1;
        private UiTools.CustomButton.CustomButton customButton2;
    }
}