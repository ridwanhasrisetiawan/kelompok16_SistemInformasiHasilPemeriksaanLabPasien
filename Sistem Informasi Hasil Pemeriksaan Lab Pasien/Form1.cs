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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=LayananKesehatanDB;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("admin");
            cmbRole.Items.Add("dokter");
            cmbRole.Items.Add("pasien");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUname.Text;
            string password = txtPassword.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Isi semua field!");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmdAdmin = new SqlCommand("SELECT * FROM ADMIN WHERE email=@email AND password=@pass", conn);
                cmdAdmin.Parameters.AddWithValue("@email", email);
                cmdAdmin.Parameters.AddWithValue("@pass", password);

                SqlDataReader reader = cmdAdmin.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login sebagai Admin");

                    FormDashboardAdmin f = new FormDashboardAdmin();
                    f.Show();
                    this.Hide();

                    reader.Close();
                    conn.Close();
                    return;
                }

                reader.Close();
                conn.Close();

                MessageBox.Show("Login gagal!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
   
}
