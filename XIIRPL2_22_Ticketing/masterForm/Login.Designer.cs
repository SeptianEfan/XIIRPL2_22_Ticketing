namespace XIIRPL2_22_Ticketing.masterForm
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
            label1 = new Label();
            label2 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(535, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 265);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 317);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(295, 262);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(295, 23);
            textUsername.TabIndex = 3;
            textUsername.TextChanged += textUsername_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(295, 314);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(295, 23);
            textPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(511, 360);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(79, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 429);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 6;
            label3.Text = "Belum punya akun?";
            label3.Click += label3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(423, 429);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(93, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Daftar Sekarang!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(876, 503);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button btnLogin;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}