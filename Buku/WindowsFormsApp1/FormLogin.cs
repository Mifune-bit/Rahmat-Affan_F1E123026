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
    public partial class FormLogin : Form
    {
       
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password Harus di Isi !", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT password FROM pengguna WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string hashFromDb = reader.GetString("password");
                        bool isValid = BCrypt.Net.BCrypt.Verify(password, hashFromDb);
                    if (isValid)
                        {
                            MessageBox.Show("Login Berhasil !", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormMain frm = new FormMain();
                            this.Hide();
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Password Salah !", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username tidak ditemukan !", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan Koneksi:\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }

           
        }

    }
}


