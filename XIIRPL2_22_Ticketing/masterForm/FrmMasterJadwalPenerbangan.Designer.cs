namespace XIIRPL2_22_Ticketing.masterForm
{
    partial class FrmMasterJadwalPenerbangan
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
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            label4 = new Label();
            txtKodePenerbangan = new TextBox();
            label5 = new Label();
            txtDari = new ComboBox();
            txtKe = new ComboBox();
            label6 = new Label();
            txtMaskapai = new ComboBox();
            label7 = new Label();
            txtTanggal = new DateTimePicker();
            label8 = new Label();
            txtWaktuKeberangkatan = new TextBox();
            label9 = new Label();
            txtDurasiPenerbangan = new TextBox();
            label3 = new Label();
            label10 = new Label();
            txtHargaPerTiket = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 8);
            label1.Name = "label1";
            label1.Size = new Size(262, 25);
            label1.TabIndex = 0;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 34);
            label2.Name = "label2";
            label2.Size = new Size(262, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua jadwal penerbangan akan muncul di sini.";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(94, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(680, 195);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.Click += dataGridView1_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 280);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 4;
            label4.Text = "Kode Penerbangan";
            label4.Click += label4_Click;
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(199, 276);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(207, 23);
            txtKodePenerbangan.TabIndex = 5;
            txtKodePenerbangan.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 319);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 6;
            label5.Text = "Dari";
            label5.Click += label5_Click;
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(199, 315);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(207, 23);
            txtDari.TabIndex = 7;
            txtDari.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(199, 355);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(207, 23);
            txtKe.TabIndex = 9;
            txtKe.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 359);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 8;
            label6.Text = "Ke";
            label6.Click += label6_Click;
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(199, 393);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(207, 23);
            txtMaskapai.TabIndex = 11;
            txtMaskapai.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 397);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 10;
            label7.Text = "Maskapai";
            label7.Click += label7_Click;
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(568, 276);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(207, 23);
            txtTanggal.TabIndex = 12;
            txtTanggal.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(436, 280);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 13;
            label8.Text = "Tanggal";
            label8.Click += label8_Click;
            // 
            // txtWaktuKeberangkatan
            // 
            txtWaktuKeberangkatan.Location = new Point(568, 315);
            txtWaktuKeberangkatan.Name = "txtWaktuKeberangkatan";
            txtWaktuKeberangkatan.Size = new Size(207, 23);
            txtWaktuKeberangkatan.TabIndex = 15;
            txtWaktuKeberangkatan.TextChanged += textBox2_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(436, 319);
            label9.Name = "label9";
            label9.Size = new Size(123, 15);
            label9.TabIndex = 14;
            label9.Text = "Waktu Keberangkatan";
            label9.Click += label9_Click;
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(568, 355);
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(207, 23);
            txtDurasiPenerbangan.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(436, 359);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 16;
            label3.Text = "Durasi Penerbangan";
            label3.Click += label3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(436, 397);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 18;
            label10.Text = "Harga Per Tiket";
            // 
            // txtHargaPerTiket
            // 
            txtHargaPerTiket.Location = new Point(568, 393);
            txtHargaPerTiket.Name = "txtHargaPerTiket";
            txtHargaPerTiket.Size = new Size(207, 23);
            txtHargaPerTiket.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(607, 447);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(700, 447);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 503);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtHargaPerTiket);
            Controls.Add(label10);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(label3);
            Controls.Add(txtWaktuKeberangkatan);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtTanggal);
            Controls.Add(txtMaskapai);
            Controls.Add(label7);
            Controls.Add(txtKe);
            Controls.Add(label6);
            Controls.Add(txtDari);
            Controls.Add(label5);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterJadwalPenerbangan";
            Text = "FormMasterJadwalPenerbangan";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
        private Label label4;
        private TextBox txtKodePenerbangan;
        private Label label5;
        private ComboBox txtDari;
        private ComboBox txtKe;
        private Label label6;
        private ComboBox txtMaskapai;
        private Label label7;
        private DateTimePicker txtTanggal;
        private Label label8;
        private TextBox txtWaktuKeberangkatan;
        private Label label9;
        private TextBox txtDurasiPenerbangan;
        private Label label3;
        private Label label10;
        private NumericUpDown txtHargaPerTiket;
        private Button button1;
        private Button button2;
    }
}