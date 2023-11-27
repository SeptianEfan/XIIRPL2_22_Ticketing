namespace XIIRPL2_22_Ticketing.masterForm
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel2 = new Panel();
            button9 = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(278, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 79);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(337, 99);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-6, -3);
            button2.Name = "button2";
            button2.Size = new Size(284, 79);
            button2.TabIndex = 5;
            button2.Text = "Master Bandara";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlDarkDark;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-6, 75);
            button3.Name = "button3";
            button3.Size = new Size(284, 79);
            button3.TabIndex = 6;
            button3.Text = "Master Maskapai";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlDarkDark;
            button5.Image = Properties.Resources.calendar_selected_72;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-6, 153);
            button5.Name = "button5";
            button5.Size = new Size(284, 79);
            button5.TabIndex = 7;
            button5.Text = "Master Jadwal Penerbangan";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlDarkDark;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-5, 230);
            button6.Name = "button6";
            button6.Size = new Size(284, 79);
            button6.TabIndex = 8;
            button6.Text = "Master Kode Promo";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlDarkDark;
            button7.Image = Properties.Resources.calendar_selected_72;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-5, 308);
            button7.Name = "button7";
            button7.Size = new Size(284, 79);
            button7.TabIndex = 9;
            button7.Text = "Ubah Status Penerbangan";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonHighlight;
            button8.ForeColor = Color.Red;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(9, 526);
            button8.Name = "button8";
            button8.Size = new Size(106, 62);
            button8.TabIndex = 10;
            button8.Text = "Logout";
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(4, 86);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(284, 658);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Highlight;
            button9.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Image = Properties.Resources.menu_alt_72;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(-2, -1);
            button9.Name = "button9";
            button9.Size = new Size(285, 79);
            button9.TabIndex = 4;
            button9.Text = "Dashboard";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button6);
            panel3.Location = new Point(1, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(282, 603);
            panel3.TabIndex = 11;
            // 
            // Dasboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1064, 681);
            Controls.Add(button9);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Dasboard";
            Text = "Dasboard";
            Load += Dasboard_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button2;
        private Button button8;
        private Panel panel2;
        private Button button9;
        private Panel panel3;
    }
}