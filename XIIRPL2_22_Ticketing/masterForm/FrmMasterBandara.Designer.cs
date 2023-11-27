namespace XIIRPL2_22_Ticketing.masterForm
{
    partial class FrmMasterBandara
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
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            label1 = new Label();
            txtNama = new TextBox();
            txtKodeIATA = new TextBox();
            label2 = new Label();
            txtKota = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtJumlahTerminal = new NumericUpDown();
            label5 = new Label();
            button1 = new Button();
            txtNegara = new ComboBox();
            label7 = new Label();
            button2 = new Button();
            label6 = new Label();
            label8 = new Label();
            txtAlamat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(94, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(680, 195);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 287);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Nama";
            label1.Click += label1_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(179, 284);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(185, 23);
            txtNama.TabIndex = 2;
            txtNama.TextChanged += textBox1_TextChanged;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(179, 328);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(185, 23);
            txtKodeIATA.TabIndex = 4;
            txtKodeIATA.TextChanged += txtKodeIATA_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 331);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Kode IATA";
            label2.Click += label2_Click;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(179, 371);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(185, 23);
            txtKota.TabIndex = 6;
            txtKota.TextChanged += txtKota_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 374);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Kota";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 417);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Negara";
            label4.Click += label4_Click;
            // 
            // txtJumlahTerminal
            // 
            txtJumlahTerminal.Location = new Point(549, 284);
            txtJumlahTerminal.Name = "txtJumlahTerminal";
            txtJumlahTerminal.Size = new Size(185, 23);
            txtJumlahTerminal.TabIndex = 8;
            txtJumlahTerminal.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 286);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 9;
            label5.Text = "Jumlah Terminal";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(602, 443);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(179, 414);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(185, 23);
            txtNegara.TabIndex = 12;
            txtNegara.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(441, 321);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 14;
            label7.Text = "Alamat";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Location = new Point(697, 443);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(90, 9);
            label6.Name = "label6";
            label6.Size = new Size(203, 30);
            label6.TabIndex = 16;
            label6.Text = "Master Bandara";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(94, 46);
            label8.Name = "label8";
            label8.Size = new Size(272, 15);
            label8.TabIndex = 17;
            label8.Text = "Semua bandara yang terdaftar akan muncul di sini";
            label8.Click += label8_Click;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(549, 321);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(185, 99);
            txtAlamat.TabIndex = 18;
            txtAlamat.TextChanged += txtAlamat_TextChanged;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 503);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(txtNegara);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtJumlahTerminal);
            Controls.Add(label4);
            Controls.Add(txtKota);
            Controls.Add(label3);
            Controls.Add(txtKodeIATA);
            Controls.Add(label2);
            Controls.Add(txtNama);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterBandara";
            Text = "FormMasterBandara";
            Load += FrmMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtNama;
        private TextBox txtKodeIATA;
        private Label label2;
        private TextBox txtKota;
        private Label label3;
        private Label label4;
        private NumericUpDown txtJumlahTerminal;
        private Label label5;
        private Button button1;
        private ComboBox txtNegara;
        private Label label7;
        private Button button2;
        private Label label6;
        private Label label8;
        private TextBox txtAlamat;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}