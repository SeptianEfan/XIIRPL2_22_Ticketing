namespace XIIRPL2_22_Ticketing.masterForm
{
    partial class FrmRegister
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 24);
            label1.Name = "label1";
            label1.Size = new Size(173, 37);
            label1.TabIndex = 0;
            label1.Text = "Daftar Akun";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 72);
            label2.Name = "label2";
            label2.Size = new Size(304, 15);
            label2.TabIndex = 1;
            label2.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 127);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 170);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Nama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 215);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 6;
            label5.Text = "Tanggal Lahir";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(139, 258);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(208, 23);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 261);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 8;
            label6.Text = "Nomor Telepon";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(139, 300);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(208, 23);
            textBox5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 303);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 10;
            label7.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(226, 357);
            button1.Name = "button1";
            button1.Size = new Size(113, 33);
            button1.TabIndex = 12;
            button1.Text = "Daftar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 452);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 13;
            label8.Text = "Sudah punya akun?";
            label8.Click += label8_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(160, 452);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(139, 211);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Rect___Without_Tagline;
            pictureBox1.Location = new Point(353, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(522, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 503);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Button button1;
        private Label label8;
        private LinkLabel linkLabel1;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
    }
}