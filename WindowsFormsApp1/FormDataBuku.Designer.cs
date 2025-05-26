namespace WindowsFormsApp1
{
    partial class FormDataBuku
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
            this.Form = new System.Windows.Forms.GroupBox();
            this.TahunTerbit = new System.Windows.Forms.Label();
            this.Penerbit = new System.Windows.Forms.Label();
            this.Penulis = new System.Windows.Forms.Label();
            this.Judul = new System.Windows.Forms.Label();
            this.txtTahunTerbit = new System.Windows.Forms.TextBox();
            this.txtPenerbit = new System.Windows.Forms.TextBox();
            this.txtPenulis = new System.Windows.Forms.TextBox();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Aksi = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Form.SuspendLayout();
            this.Aksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            this.Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.Form.Controls.Add(this.TahunTerbit);
            this.Form.Controls.Add(this.Penerbit);
            this.Form.Controls.Add(this.Penulis);
            this.Form.Controls.Add(this.Judul);
            this.Form.Controls.Add(this.txtTahunTerbit);
            this.Form.Controls.Add(this.txtPenerbit);
            this.Form.Controls.Add(this.txtPenulis);
            this.Form.Controls.Add(this.txtJudul);
            this.Form.Location = new System.Drawing.Point(12, 12);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(393, 174);
            this.Form.TabIndex = 0;
            this.Form.TabStop = false;
            this.Form.Text = "Form";
            this.Form.Enter += new System.EventHandler(this.Form_Enter);
            // 
            // TahunTerbit
            // 
            this.TahunTerbit.AutoSize = true;
            this.TahunTerbit.Location = new System.Drawing.Point(6, 119);
            this.TahunTerbit.Name = "TahunTerbit";
            this.TahunTerbit.Size = new System.Drawing.Size(68, 13);
            this.TahunTerbit.TabIndex = 7;
            this.TahunTerbit.Text = "Tahun Terbit";
            // 
            // Penerbit
            // 
            this.Penerbit.AutoSize = true;
            this.Penerbit.Location = new System.Drawing.Point(6, 82);
            this.Penerbit.Name = "Penerbit";
            this.Penerbit.Size = new System.Drawing.Size(46, 13);
            this.Penerbit.TabIndex = 6;
            this.Penerbit.Text = "Penerbit";
            // 
            // Penulis
            // 
            this.Penulis.AutoSize = true;
            this.Penulis.Location = new System.Drawing.Point(6, 52);
            this.Penulis.Name = "Penulis";
            this.Penulis.Size = new System.Drawing.Size(41, 13);
            this.Penulis.TabIndex = 5;
            this.Penulis.Text = "Penulis";
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.Location = new System.Drawing.Point(6, 22);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(32, 13);
            this.Judul.TabIndex = 4;
            this.Judul.Text = "Judul";
            // 
            // txtTahunTerbit
            // 
            this.txtTahunTerbit.Location = new System.Drawing.Point(80, 116);
            this.txtTahunTerbit.Name = "txtTahunTerbit";
            this.txtTahunTerbit.Size = new System.Drawing.Size(248, 20);
            this.txtTahunTerbit.TabIndex = 3;
            this.txtTahunTerbit.TextChanged += new System.EventHandler(this.txtTahunTerbit_TextChanged);
            // 
            // txtPenerbit
            // 
            this.txtPenerbit.Location = new System.Drawing.Point(80, 79);
            this.txtPenerbit.Name = "txtPenerbit";
            this.txtPenerbit.Size = new System.Drawing.Size(248, 20);
            this.txtPenerbit.TabIndex = 2;
            // 
            // txtPenulis
            // 
            this.txtPenulis.Location = new System.Drawing.Point(80, 45);
            this.txtPenulis.Name = "txtPenulis";
            this.txtPenulis.Size = new System.Drawing.Size(248, 20);
            this.txtPenulis.TabIndex = 1;
            this.txtPenulis.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(78, 19);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(250, 20);
            this.txtJudul.TabIndex = 0;
            this.txtJudul.TextChanged += new System.EventHandler(this.txtJudul_TextChanged);
            // 
            // Aksi
            // 
            this.Aksi.Controls.Add(this.btnClear);
            this.Aksi.Controls.Add(this.btnReload);
            this.Aksi.Controls.Add(this.btnHapus);
            this.Aksi.Controls.Add(this.btnEdit);
            this.Aksi.Controls.Add(this.btnSimpan);
            this.Aksi.Location = new System.Drawing.Point(12, 260);
            this.Aksi.Name = "Aksi";
            this.Aksi.Size = new System.Drawing.Size(393, 178);
            this.Aksi.TabIndex = 1;
            this.Aksi.TabStop = false;
            this.Aksi.Text = "Aksi";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(78, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(231, 41);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(290, 58);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(197, 58);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(98, 58);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(6, 58);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dgvBuku
            // 
            this.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuku.Location = new System.Drawing.Point(432, 12);
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.Size = new System.Drawing.Size(356, 406);
            this.dgvBuku.TabIndex = 2;
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.btnSearch);
            this.Filter.Controls.Add(this.txtSearch);
            this.Filter.Controls.Add(this.cmbFilterBy);
            this.Filter.Location = new System.Drawing.Point(12, 182);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(393, 72);
            this.Filter.TabIndex = 3;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "Judul",
            "Penulis",
            "Penerbit ",
            "Tahun Terbit"});
            this.cmbFilterBy.Location = new System.Drawing.Point(9, 19);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(84, 21);
            this.cmbFilterBy.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(125, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(203, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(33, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(276, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormDataBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.dgvBuku);
            this.Controls.Add(this.Aksi);
            this.Controls.Add(this.Form);
            this.Name = "FormDataBuku";
            this.Text = "FormDataBuku";
            this.Load += new System.EventHandler(this.FormDataBuku_Load);
            this.Form.ResumeLayout(false);
            this.Form.PerformLayout();
            this.Aksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Form;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTahunTerbit;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.TextBox txtPenulis;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.GroupBox Aksi;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dgvBuku;
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.Label TahunTerbit;
        private System.Windows.Forms.Label Penerbit;
        private System.Windows.Forms.Label Penulis;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}