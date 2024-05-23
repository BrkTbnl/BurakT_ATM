
using BurakT_ATM.UiTools;

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
            occupationtb = new TextBox();
            gradientPanel1 = new GradientPanel();
            customButton2 = new UiTools.CustomButton.CustomButton();
            customButton1 = new UiTools.CustomButton.CustomButton();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(195, 24);
            label1.Name = "label1";
            label1.Size = new Size(239, 31);
            label1.TabIndex = 2;
            label1.Text = "X Bank ATM Systems";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(600, 9);
            label2.Name = "label2";
            label2.Size = new Size(29, 31);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1, 108);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 10;
            label5.Text = "ACC NUM";
            label5.Click += Label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1, 153);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 11;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1, 193);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 12;
            label4.Text = "Surname";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1, 243);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 13;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(279, 243);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 14;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(279, 153);
            label8.Name = "label8";
            label8.Size = new Size(117, 25);
            label8.TabIndex = 15;
            label8.Text = "Education";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(279, 193);
            label9.Name = "label9";
            label9.Size = new Size(131, 25);
            label9.TabIndex = 16;
            label9.Text = "Occupation";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(279, 294);
            label10.Name = "label10";
            label10.Size = new Size(74, 25);
            label10.TabIndex = 17;
            label10.Text = "D.O.B";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(279, 105);
            label12.Name = "label12";
            label12.Size = new Size(108, 25);
            label12.TabIndex = 19;
            label12.Text = "Pin Code";
            // 
            // AccNametb
            // 
            AccNametb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            AccNametb.Location = new Point(127, 144);
            AccNametb.Name = "AccNametb";
            AccNametb.Size = new Size(146, 31);
            AccNametb.TabIndex = 21;
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            AccNumTb.Location = new Point(127, 102);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(146, 31);
            AccNumTb.TabIndex = 20;
            AccNumTb.TextChanged += AccNumTb_TextChanged;
            // 
            // Addresstb
            // 
            Addresstb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            Addresstb.Location = new Point(127, 237);
            Addresstb.Multiline = true;
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(146, 98);
            Addresstb.TabIndex = 23;
            // 
            // FanameTb
            // 
            FanameTb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            FanameTb.Location = new Point(127, 187);
            FanameTb.Name = "FanameTb";
            FanameTb.Size = new Size(146, 31);
            FanameTb.TabIndex = 22;
            // 
            // pintb
            // 
            pintb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            pintb.Location = new Point(439, 99);
            pintb.Name = "pintb";
            pintb.Size = new Size(163, 31);
            pintb.TabIndex = 24;
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            PhoneTb.Location = new Point(439, 237);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(146, 31);
            PhoneTb.TabIndex = 28;
            // 
            // educationcb
            // 
            educationcb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            educationcb.FormattingEnabled = true;
            educationcb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            educationcb.Location = new Point(439, 145);
            educationcb.Name = "educationcb";
            educationcb.Size = new Size(163, 33);
            educationcb.TabIndex = 30;
            // 
            // dobdate
            // 
            dobdate.CalendarFont = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            dobdate.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            dobdate.Location = new Point(437, 289);
            dobdate.Name = "dobdate";
            dobdate.Size = new Size(165, 31);
            dobdate.TabIndex = 32;
            // 
            // occupationtb
            // 
            occupationtb.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            occupationtb.Location = new Point(439, 187);
            occupationtb.Name = "occupationtb";
            occupationtb.Size = new Size(163, 31);
            occupationtb.TabIndex = 36;
            // 
            // gradientPanel1
            // 
            gradientPanel1.angle = 90F;
            gradientPanel1.BackColor = SystemColors.HotTrack;
            gradientPanel1.BottomColor = Color.Empty;
            gradientPanel1.Controls.Add(customButton2);
            gradientPanel1.Controls.Add(customButton1);
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.Controls.Add(occupationtb);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(label7);
            gradientPanel1.Controls.Add(label8);
            gradientPanel1.Controls.Add(dobdate);
            gradientPanel1.Controls.Add(label9);
            gradientPanel1.Controls.Add(educationcb);
            gradientPanel1.Controls.Add(label10);
            gradientPanel1.Controls.Add(PhoneTb);
            gradientPanel1.Controls.Add(label12);
            gradientPanel1.Controls.Add(pintb);
            gradientPanel1.Controls.Add(AccNumTb);
            gradientPanel1.Controls.Add(Addresstb);
            gradientPanel1.Controls.Add(AccNametb);
            gradientPanel1.Controls.Add(FanameTb);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(640, 432);
            gradientPanel1.TabIndex = 37;
            gradientPanel1.TopColor = Color.LightSkyBlue;
            gradientPanel1.Paint += gradientPanel1_Paint;
            // 
            // customButton2
            // 
            customButton2.Angle = 76F;
            customButton2.BackColor = Color.Transparent;
            customButton2.BorderRadius = 30;
            customButton2.ButtonText = "Login";
            customButton2.Color0 = SystemColors.HotTrack;
            customButton2.Color1 = Color.LightSkyBlue;
            customButton2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            customButton2.ForeColor = Color.Black;
            customButton2.Location = new Point(12, 377);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(150, 43);
            customButton2.TabIndex = 38;
            customButton2.Click += customButton2_Click;
            // 
            // customButton1
            // 
            customButton1.Angle = 111F;
            customButton1.BackColor = Color.Transparent;
            customButton1.BorderRadius = 30;
            customButton1.ButtonText = "Submit";
            customButton1.Color0 = SystemColors.HotTrack;
            customButton1.Color1 = Color.LightSkyBlue;
            customButton1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            customButton1.ForeColor = Color.Black;
            customButton1.Location = new Point(478, 377);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 43);
            customButton1.TabIndex = 37;
            customButton1.Click += customButton1_Click;
            // 
            // account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 432);
            ControlBox = false;
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "account";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "account";
            Load += account_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
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
        private TextBox occupationtb;
        private GradientPanel gradientPanel1;
        private UiTools.CustomButton.CustomButton customButton2;
        private UiTools.CustomButton.CustomButton customButton1;
    }
}