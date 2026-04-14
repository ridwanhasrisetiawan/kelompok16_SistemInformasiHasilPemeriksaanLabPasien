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
    public partial class FormDashboardAdmin: Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=LayananKesehatanDB;Integrated Security=True");
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {
            
        }
        void CekKoneksi()
        {
            try
            {
                conn.Open();
                lblStatus.Text = "Status: Koneksi Berhasil";
                conn.Close();
            }
            catch
            {
                lblStatus.Text = "Status: Koneksi Gagal";
            }
        }
        void TampilData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PEMERIKSAAN_LAB", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPemeriksaan.DataSource = dt;
        }
        void HitungData()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PEMERIKSAAN_LAB", conn);
            int total = (int)cmd.ExecuteScalar();

            lblTotal.Text = "Total Data: " + total;

            conn.Close();
        }
    }
}
