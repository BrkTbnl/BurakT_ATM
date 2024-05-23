namespace BurakT_ATM
{
    partial class Balance
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
            label6 = new Label();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label13 = new Label();
            Balancelbl = new Label();
            AccNumberlbl = new Label();
            gradientPanel1 = new UiTools.GradientPanel();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(491, 9);
            label6.Name = "label6";
            label6.Size = new Size(29, 31);
            label6.TabIndex = 10;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(162, 23);
            label1.Name = "label1";
            label1.Size = new Size(239, 31);
            label1.TabIndex = 1;
            label1.Text = "X Bank ATM Systems";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(55, 131);
            label5.Name = "label5";
            label5.Size = new Size(201, 31);
            label5.TabIndex = 11;
            label5.Text = "Account Number:";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(55, 193);
            label2.Name = "label2";
            label2.Size = new Size(163, 31);
            label2.TabIndex = 12;
            label2.Text = "Your Balance:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(454, 287);
            label13.Name = "label13";
            label13.Size = new Size(66, 31);
            label13.TabIndex = 36;
            label13.Text = "Back";
            label13.Click += label13_Click;
            // 
            // Balancelbl
            // 
            Balancelbl.AutoSize = true;
            Balancelbl.BackColor = Color.Transparent;
            Balancelbl.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Balancelbl.ForeColor = Color.Black;
            Balancelbl.Location = new Point(268, 193);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(158, 31);
            Balancelbl.TabIndex = 38;
            Balancelbl.Text = "Balance In Rs";
            Balancelbl.Click += label3_Click;
            // 
            // AccNumberlbl
            // 
            AccNumberlbl.AutoSize = true;
            AccNumberlbl.BackColor = Color.Transparent;
            AccNumberlbl.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccNumberlbl.ForeColor = Color.Black;
            AccNumberlbl.Location = new Point(297, 131);
            AccNumberlbl.Name = "AccNumberlbl";
            AccNumberlbl.Size = new Size(104, 31);
            AccNumberlbl.TabIndex = 37;
            AccNumberlbl.Text = "AccNum";
            AccNumberlbl.Click += label4_Click;
            // 
            // gradientPanel1
            // 
            gradientPanel1.angle = 60F;
            gradientPanel1.BackColor = SystemColors.HotTrack;
            gradientPanel1.BottomColor = Color.Empty;
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(Balancelbl);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(label13);
            gradientPanel1.Controls.Add(AccNumberlbl);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.ForeColor = Color.DarkKhaki;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(532, 327);
            gradientPanel1.TabIndex = 39;
            gradientPanel1.TopColor = Color.LightSkyBlue;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 327);
            ControlBox = false;
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balance";
            Load += Balance_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label13;
        private Label Balancelbl;
        private Label AccNumberlbl;
        private UiTools.GradientPanel gradientPanel1;
    }
}