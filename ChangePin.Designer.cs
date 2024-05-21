namespace BurakT_ATM
{
    partial class ChangePin
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
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            button1 = new Button();
            Pin2 = new TextBox();
            Pin1 = new TextBox();
            label13 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 76);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(503, 0);
            label6.Name = "label6";
            label6.Size = new Size(29, 31);
            label6.TabIndex = 10;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(155, 21);
            label1.Name = "label1";
            label1.Size = new Size(239, 31);
            label1.TabIndex = 1;
            label1.Text = "X Bank ATM Systems";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(31, 189);
            label2.Name = "label2";
            label2.Size = new Size(211, 31);
            label2.TabIndex = 14;
            label2.Text = "Confirm Password";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(31, 131);
            label5.Name = "label5";
            label5.Size = new Size(170, 31);
            label5.TabIndex = 13;
            label5.Text = "New Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(206, 241);
            button1.Name = "button1";
            button1.Size = new Size(149, 43);
            button1.TabIndex = 34;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pin2
            // 
            Pin2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            Pin2.Location = new Point(273, 186);
            Pin2.Name = "Pin2";
            Pin2.Size = new Size(236, 38);
            Pin2.TabIndex = 36;
            // 
            // Pin1
            // 
            Pin1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            Pin1.Location = new Point(273, 128);
            Pin1.Name = "Pin1";
            Pin1.Size = new Size(236, 38);
            Pin1.TabIndex = 35;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(249, 287);
            label13.Name = "label13";
            label13.Size = new Size(66, 31);
            label13.TabIndex = 37;
            label13.Text = "Back";
            label13.Click += label13_Click;
            // 
            // ChangePin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 327);
            ControlBox = false;
            Controls.Add(label13);
            Controls.Add(Pin2);
            Controls.Add(Pin1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label5;
        private Button button1;
        private TextBox Pin2;
        private TextBox Pin1;
        private Label label13;
    }
}