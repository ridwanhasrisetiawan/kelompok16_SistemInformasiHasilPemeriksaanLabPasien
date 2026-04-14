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
    public partial class FormDashboardDokter: Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=LayananKesehatanDB;Integrated Security=True");

        public FormDashboardDokter()
        {
            InitializeComponent();
            tampilData();
        }

        void koneksi()
        {
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                MessageBox.Show("Koneksi berhasil"); // TEST
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message);
            }
        }

        void tampilData()
        {
            try
            {
                koneksi();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_periksa, id_pasien, hasil_lab, tgl_periksa, status_validasi FROM PEMERIKSAAN_LAB",
                    conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error tampil data: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (txtIDPasien.Text == "" || txtHasilLab.Text == "")
            {
                MessageBox.Show("Data harus diisi!");
                return;
            }

            try
            {
                koneksi();

                string query = "INSERT INTO PEMERIKSAAN_LAB (id_pasien, hasil_lab, status_validasi) VALUES (@p,@h,'Pending')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@p", txtIDPasien.Text);
                    cmd.Parameters.AddWithValue("@h", txtHasilLab.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil disimpan");
                tampilData();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error simpan: " + ex.Message);
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {

        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {

        }

        private void btnCARI_Click(object sender, EventArgs e)
        {

        }
    }
}
