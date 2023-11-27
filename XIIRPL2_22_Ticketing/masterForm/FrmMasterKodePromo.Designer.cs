namespace XIIRPL2_22_Ticketing.masterForm
{
    partial class FrmMasterKodePromo
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
            label3 = new Label();
            txtKodePromo = new TextBox();
            txtDeskripsi = new TextBox();
            label4 = new Label();
            txtBerlakuSampai = new DateTimePicker();
            label5 = new Label();
            txtPresentasiDiskon = new NumericUpDown();
            txtMaksimumDiskon = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentasiDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 32);
            label1.TabIndex = 0;
            label1.Text = "Master Kode Promo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 41);
            label2.Name = "label2";
            label2.Size = new Size(294, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua kode promo yang terdaftar akan muncul di sini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(94, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(680, 195);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Resizable = DataGridViewTriState.True;
            BtnEdit.SortMode = DataGridViewColumnSortMode.Automatic;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 289);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "Kode Promo";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(211, 286);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(185, 23);
            txtKodePromo.TabIndex = 4;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(567, 286);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(185, 78);
            txtDeskripsi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 289);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Deskripsi";
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(211, 323);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(185, 23);
            txtBerlakuSampai.TabIndex = 7;
            txtBerlakuSampai.Value = new DateTime(2023, 10, 30, 0, 0, 0, 0);
            txtBerlakuSampai.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 329);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 8;
            label5.Text = "Berlaku Sampai";
            label5.Click += label5_Click;
            // 
            // txtPresentasiDiskon
            // 
            txtPresentasiDiskon.Location = new Point(211, 362);
            txtPresentasiDiskon.Name = "txtPresentasiDiskon";
            txtPresentasiDiskon.Size = new Size(185, 23);
            txtPresentasiDiskon.TabIndex = 9;
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Location = new Point(211, 402);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(185, 23);
            txtMaksimumDiskon.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 364);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 11;
            label6.Text = "Presentasi Diskon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 404);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 12;
            label7.Text = "Maksimum Diskon";
            // 
            // button1
            // 
            button1.Location = new Point(587, 424);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(677, 424);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 503);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(txtPresentasiDiskon);
            Controls.Add(label5);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(txtDeskripsi);
            Controls.Add(label4);
            Controls.Add(txtKodePromo);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterKodePromo";
            Text = "FrmMasterKodePromo";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentasiDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtKodePromo;
        private TextBox txtDeskripsi;
        private Label label4;
        private DateTimePicker txtBerlakuSampai;
        private Label label5;
        private NumericUpDown txtPresentasiDiskon;
        private NumericUpDown txtMaksimumDiskon;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}