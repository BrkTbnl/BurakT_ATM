namespace BurakT_ATM
{
    partial class ministatement
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
            label13 = new Label();
            MiniStatementDGV = new DataGridView();
            gradientPanel1 = new UiTools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)MiniStatementDGV).BeginInit();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(599, 9);
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
            label1.Location = new Point(217, 177);
            label1.Name = "label1";
            label1.Size = new Size(239, 31);
            label1.TabIndex = 1;
            label1.Text = "X Bank ATM Systems";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(232, 21);
            label2.Name = "label2";
            label2.Size = new Size(203, 31);
            label2.TabIndex = 43;
            label2.Text = "MINI STATEMENT";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(562, 388);
            label13.Name = "label13";
            label13.Size = new Size(66, 31);
            label13.TabIndex = 45;
            label13.Text = "Back";
            label13.Click += label13_Click;
            // 
            // MiniStatementDGV
            // 
            MiniStatementDGV.BackgroundColor = Color.White;
            MiniStatementDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MiniStatementDGV.Location = new Point(12, 92);
            MiniStatementDGV.Name = "MiniStatementDGV";
            MiniStatementDGV.Size = new Size(616, 265);
            MiniStatementDGV.TabIndex = 46;
            MiniStatementDGV.CellContentClick += MiniStatementDGV_CellContentClick;
            // 
            // gradientPanel1
            // 
            gradientPanel1.angle = 60F;
            gradientPanel1.BackColor = SystemColors.HotTrack;
            gradientPanel1.BottomColor = Color.Empty;
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(label13);
            gradientPanel1.Controls.Add(MiniStatementDGV);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(640, 432);
            gradientPanel1.TabIndex = 47;
            gradientPanel1.TopColor = Color.LightSkyBlue;
            gradientPanel1.Paint += gradientPanel1_Paint;
            // 
            // ministatement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 432);
            ControlBox = false;
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ministatement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ministatement";
            Load += ministatement_Load;
            ((System.ComponentModel.ISupportInitialize)MiniStatementDGV).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label13;
        private DataGridView MiniStatementDGV;
        private UiTools.GradientPanel gradientPanel1;
    }
}