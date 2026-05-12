using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Informasi_Hasil_Pemeriksaan_Lab_Pasien
{
    public partial class Form1: Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=HasilPemeriksaanLabDB;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show(
                        "Username tidak boleh kosong");

                    txtUsername.Focus();

                    return;
                }

                if (txtPassword.Text == "")
                {
                    MessageBox.Show(
                        "Password tidak boleh kosong");

                    txtPassword.Focus();

                    return;
                }


                if (txtPassword.Text.Length < 6)
                {
                    MessageBox.Show(
                        "Password minimal 6 karakter");

                    txtPassword.Focus();

                    return;
                }

                conn.Open();

                string query =
                "SELECT * FROM AKUN " +
                "WHERE username=@username " +
                "AND password_akun=@password";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@username",
                    txtUsername.Text.Trim());

                cmd.Parameters.AddWithValue(
                    "@password",
                    txtPassword.Text.Trim());

                SqlDataReader rd =
                    cmd.ExecuteReader();

                if (rd.Read())
                {
                    string role =
                        rd["role"].ToString();

                    MessageBox.Show(
                        "Login Berhasil");

                    if (role == "Admin")
                    {
                        FormAdmin frm =
                            new FormAdmin();

                        frm.Show();

                        this.Hide();
                    }

                    else if (role == "Dokter")
                    {
                        FormPemeriksaanLab frm =
                            new FormPemeriksaanLab();

                        frm.Show();

                        this.Hide();
                    }

                    else if (role == "Pasien")
                    {
                        FormPasien frm =
                            new FormPasien();

                        frm.namaPasien =
                            rd["username"].ToString();

                        frm.idPasien =
                            rd["id_user_asli"].ToString();

                        frm.Show();

                        this.Hide();
                    }
                }

                else
                {
                    MessageBox.Show(
                        "Username atau Password Salah");
                }

                conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                conn.Close();
            }
        }
    }
}
