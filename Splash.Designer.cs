namespace BurakT_ATM
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            gradientPanel1 = new UiTools.GradientPanel();
            percentage = new Label();
            Myprogress = new ProgressBar();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.angle = 60F;
            gradientPanel1.BackColor = SystemColors.HotTrack;
            gradientPanel1.BottomColor = Color.Empty;
            gradientPanel1.Controls.Add(percentage);
            gradientPanel1.Controls.Add(Myprogress);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.ForeColor = Color.LightSkyBlue;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(640, 432);
            gradientPanel1.TabIndex = 0;
            gradientPanel1.TopColor = Color.LightSkyBlue;
            gradientPanel1.Paint += gradientPanel1_Paint;
            // 
            // percentage
            // 
            percentage.AutoSize = true;
            percentage.BackColor = Color.Transparent;
            percentage.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            percentage.ForeColor = Color.Black;
            percentage.Location = new Point(306, 375);
            percentage.Name = "percentage";
            percentage.Size = new Size(34, 31);
            percentage.TabIndex = 4;
            percentage.Text = "%";
            // 
            // Myprogress
            // 
            Myprogress.Location = new Point(0, 409);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(640, 23);
            Myprogress.TabIndex = 3;
            Myprogress.Click += progressBar1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(175, 37);
            label2.Name = "label2";
            label2.Size = new Size(293, 31);
            label2.TabIndex = 2;
            label2.Text = "ATM X Bank ATM Systems";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 432);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UiTools.GradientPanel gradientPanel1;
        private Label percentage;
        private ProgressBar Myprogress;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}