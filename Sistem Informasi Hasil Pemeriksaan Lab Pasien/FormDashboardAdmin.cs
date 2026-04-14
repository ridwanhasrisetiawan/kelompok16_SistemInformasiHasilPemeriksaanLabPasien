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
            if (txtId_Pasien.Text == "" || txtId_Dokter.Text == "" || txtHasilLab.Text == "")
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO PEMERIKSAAN_LAB (id_pasien, id_dokter, id_admin, hasil_lab) VALUES (@pasien,@dokter,@admin,@hasil)", conn);

            cmd.Parameters.AddWithValue("@pasien", txtId_Pasien.Text);
            cmd.Parameters.AddWithValue("@dokter", txtId_Dokter.Text);
            cmd.Parameters.AddWithValue("@admin", 1);
            cmd.Parameters.AddWithValue("@hasil", txtHasilLab.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data berhasil disimpan");
            ClearForm();
            TampilData();
            HitungData();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPeriksa.Text == "")
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            if (MessageBox.Show("Yakin update data?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE PEMERIKSAAN_LAB SET id_pasien=@pasien, id_dokter=@dokter, hasil_lab=@hasil WHERE id_periksa=@id", conn);

            cmd.Parameters.AddWithValue("@id", txtPeriksa.Text);
            cmd.Parameters.AddWithValue("@pasien", txtId_Pasien.Text);
            cmd.Parameters.AddWithValue("@dokter", txtId_Dokter.Text);
            cmd.Parameters.AddWithValue("@hasil", txtHasilLab.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data berhasil diupdate");
            ClearForm();
            TampilData();
            HitungData();
        }
        

        private void btnCARI_Click(object sender, EventArgs e)
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

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (txtPeriksa.Text == "")
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            if (MessageBox.Show("Yakin hapus data?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM PEMERIKSAAN_LAB WHERE id_periksa=@id", conn);
            cmd.Parameters.AddWithValue("@id", txtPeriksa.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data berhasil dihapus");
            ClearForm();
            TampilData();
            HitungData();
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            TampilData();
            HitungData();
        }
        void ClearForm()
        {
            txtPeriksa.Clear();
            txtId_Pasien.Clear();
            txtId_Dokter.Clear();
            txtHasilLab.Clear();
        }

        private void btnCARI_Click_1(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM PEMERIKSAAN_LAB WHERE id_pasien LIKE @cari", conn);
            cmd.Parameters.AddWithValue("@cari", "%" + btnCARI.Text + "%");

            SqlDataReader reader = cmd.ExecuteReader();

            dgvPemeriksaan.Rows.Clear();

            while (reader.Read())
            {
                dgvPemeriksaan.Rows.Add(
                    reader["id_periksa"],
                    reader["id_pasien"],
                    reader["id_dokter"],
                    reader["id_admin"],
                    reader["tgl_periksa"],
                    reader["hasil_lab"],
                    reader["status_validasi"]
                );
            }

            reader.Close();
            conn.Close();
        }
    }
    
}
