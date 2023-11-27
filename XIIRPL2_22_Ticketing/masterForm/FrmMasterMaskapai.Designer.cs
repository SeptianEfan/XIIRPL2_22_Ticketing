namespace XIIRPL2_22_Ticketing.masterForm
{
    partial class FrmMasterMaskapai
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
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtNama = new TextBox();
            txtPerusahaan = new TextBox();
            label4 = new Label();
            txtDeskripsi = new TextBox();
            label5 = new Label();
            txtJumlahKru = new NumericUpDown();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 0;
            label1.Text = "Master Maskapai";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 45);
            label2.Name = "label2";
            label2.Size = new Size(279, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(94, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(680, 195);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 282);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            label3.Click += label3_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(186, 279);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(185, 23);
            txtNama.TabIndex = 4;
            txtNama.TextChanged += textBox1_TextChanged;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(186, 331);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(185, 23);
            txtPerusahaan.TabIndex = 6;
            txtPerusahaan.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 334);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 5;
            label4.Text = "Perusahaan";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(553, 279);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(185, 99);
            txtDeskripsi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(467, 282);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "Deskripsi";
            label5.Click += label5_Click;
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Location = new Point(186, 394);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(185, 23);
            txtJumlahKru.TabIndex = 9;
            txtJumlahKru.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 394);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 10;
            label6.Text = "Jumlah Kru";
            // 
            // button1
            // 
            button1.Location = new Point(607, 435);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(699, 435);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 503);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtJumlahKru);
            Controls.Add(label5);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtPerusahaan);
            Controls.Add(label4);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterMaskapai";
            Text = "FrmMasterMaskapai";
            Load += FrmMasterMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtNama;
        private TextBox txtPerusahaan;
        private Label label4;
        private TextBox txtDeskripsi;
        private Label label5;
        private NumericUpDown txtJumlahKru;
        private Label label6;
        private Button button1;
        private Button button2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}