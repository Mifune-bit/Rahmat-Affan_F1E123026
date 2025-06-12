using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp1
{
    public partial class FormDataBuku: Form
    {
        private int selectedId = -1;
        public FormDataBuku()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM buku";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBuku.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error load data: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            txtJudul.Clear();
            txtPenulis.Clear();
            txtPenerbit.Clear();
            txtTahunTerbit.Clear();
            selectedId = -1;
            btnSimpan.Enabled = true;
        }

        private void Form_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJudul_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTahunTerbit_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDataBuku_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO buku (judul, penulis, penerbit, tahun_terbit) " + "VALUES (@judul, @penulis, @penerbit, @tahun_terbit)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@judul", txtJudul.Text);
                    cmd.Parameters.AddWithValue("@penulis", txtPenulis.Text);
                    cmd.Parameters.AddWithValue("@penerbit", txtPenerbit.Text);
                    cmd.Parameters.AddWithValue("@tahun_terbit", txtTahunTerbit.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data buku berhasil disimpan!");
                    LoadData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Simpan!: " + ex.Message);
                }
            }

        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtJudul.Text))
            {
                MessageBox.Show("Judul wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJudul.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPenulis.Text))
            {
                MessageBox.Show("Penulis wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPenulis.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPenerbit.Text))
            {
                MessageBox.Show("Penerbit wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPenerbit.Focus();
                return false;
            }

            if (!int.TryParse(txtTahunTerbit.Text, out int tahun) || txtTahunTerbit.Text.Length != 4)
            {
                MessageBox.Show(
                    "Tahun Terbit harus angka 4 digit!",
                    "Validasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtTahunTerbit.Focus();
                return false;
            }

            return true;



        }

        private void TampilkanDataFiltered()
        {
            string kolom = cmbFilterBy.SelectedItem?.ToString();
            string keyword = txtSearch.Text.Trim();

            string kolomDb = "judul";
            if (kolom == "Penulis") kolomDb = "penulis";
            else if (kolom == "Penerbit") kolomDb = "penerbit";
            
            string query = $"SELECT * FROM buku WHERE {kolomDb} LIKE @keyword ORDER BY id DESC";
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
               
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvBuku.DataSource = dt;
                

            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TampilkanDataFiltered();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE buku SET judul=@judul, penulis=@penulis, penerbit=@penerbit, " +
                                   "tahun_terbit=@tahun_terbit WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.Parameters.AddWithValue("@judul", txtJudul.Text);
                    cmd.Parameters.AddWithValue("@penulis", txtPenulis.Text);
                    cmd.Parameters.AddWithValue("@penerbit", txtPenerbit.Text);
                    cmd.Parameters.AddWithValue("@tahun_terbit", txtTahunTerbit.Text);
                    cmd.ExecuteNonQuery();

                    LoadData();
                    ClearForm();
                    MessageBox.Show("Data buku berhasil diperbarui!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update: " + ex.Message);
                }
            }
        }

        

        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object valueSelectedId = dgvBuku.Rows[e.RowIndex].Cells["id"].Value;
                selectedId = (valueSelectedId != null && valueSelectedId != DBNull.Value)
                    ? Convert.ToInt32(valueSelectedId)
                    : -1;

                txtJudul.Text = dgvBuku.Rows[e.RowIndex].Cells["judul"].Value?.ToString() ?? "";
                txtPenulis.Text = dgvBuku.Rows[e.RowIndex].Cells["penulis"].Value?.ToString() ?? "";
                txtPenerbit.Text = dgvBuku.Rows[e.RowIndex].Cells["penerbit"].Value?.ToString() ?? "";
                txtTahunTerbit.Text = dgvBuku.Rows[e.RowIndex].Cells["tahun_terbit"].Value?.ToString() ?? "";

                btnSimpan.Enabled = false;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data buku ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes) return;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
