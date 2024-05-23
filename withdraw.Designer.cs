namespace BurakT_ATM
{
    partial class withdraw
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
            label2 = new Label();
            withdrawTb = new TextBox();
            label5 = new Label();
            balancelbl = new Label();
            customButton1 = new UiTools.CustomButton.CustomButton();
            customButton2 = new UiTools.CustomButton.CustomButton();
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
            label1.Location = new Point(160, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 31);
            label1.TabIndex = 1;
            label1.Text = "X Bank Atm Systems";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(223, 49);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 47;
            label2.Text = "WITHDRAW";
            // 
            // withdrawTb
            // 
            withdrawTb.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            withdrawTb.Location = new Point(193, 152);
            withdrawTb.Name = "withdrawTb";
            withdrawTb.Size = new Size(236, 38);
            withdrawTb.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(71, 159);
            label5.Name = "label5";
            label5.Size = new Size(99, 31);
            label5.TabIndex = 43;
            label5.Text = "Amount";
            // 
            // balancelbl
            // 
            balancelbl.AutoSize = true;
            balancelbl.BackColor = Color.Transparent;
            balancelbl.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balancelbl.ForeColor = Color.Black;
            balancelbl.Location = new Point(193, 215);
            balancelbl.Name = "balancelbl";
            balancelbl.Size = new Size(163, 25);
            balancelbl.TabIndex = 48;
            balancelbl.Text = "Available Balance";
            balancelbl.Click += balancelbl_Click;
            // 
            // customButton1
            // 
            customButton1.Angle = 56F;
            customButton1.BackColor = Color.Transparent;
            customButton1.BorderRadius = 30;
            customButton1.ButtonText = "Withdraw";
            customButton1.Color0 = SystemColors.HotTrack;
            customButton1.Color1 = Color.LightSkyBlue;
            customButton1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            customButton1.ForeColor = Color.Black;
            customButton1.Location = new Point(370, 272);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 43);
            customButton1.TabIndex = 49;
            customButton1.Click += customButton1_Click;
            // 
            // customButton2
            // 
            customButton2.Angle = 47F;
            customButton2.BackColor = Color.Transparent;
            customButton2.BorderRadius = 30;
            customButton2.ButtonText = "Back";
            customButton2.Color0 = SystemColors.HotTrack;
            customButton2.Color1 = Color.LightSkyBlue;
            customButton2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            customButton2.ForeColor = Color.Black;
            customButton2.Location = new Point(12, 272);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(150, 43);
            customButton2.TabIndex = 50;
            customButton2.Click += customButton2_Click;
            // 
            // gradientPanel1
            // 
            gradientPanel1.angle = 90F;
            gradientPanel1.BackColor = SystemColors.HotTrack;
            gradientPanel1.BottomColor = Color.Empty;
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(customButton2);
            gradientPanel1.Controls.Add(withdrawTb);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(balancelbl);
            gradientPanel1.Controls.Add(customButton1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(532, 327);
            gradientPanel1.TabIndex = 51;
            gradientPanel1.TopColor = Color.LightSkyBlue;
            // 
            // withdraw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 327);
            ControlBox = false;
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "withdraw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "withdraw";
            Load += withdraw_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox withdrawTb;
        private Label label5;
        private Label balancelbl;
        private UiTools.CustomButton.CustomButton customButton1;
        private UiTools.CustomButton.CustomButton customButton2;
        private UiTools.GradientPanel gradientPanel1;
    }
}