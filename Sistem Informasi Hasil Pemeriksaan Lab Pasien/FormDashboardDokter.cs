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
        string connStr ="Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=LayananKesehatanDB;Integrated Security=True";
        SqlConnection conn;

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

                MessageBox.Show("Koneksi berhasil"); 
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
            if (txtIDPeriksa.Text == "")
            {
                MessageBox.Show("Masukkan ID Periksa!");
                return;
            }

            try
            {
                koneksi();

                string query = "UPDATE PEMERIKSAAN_LAB SET id_pasien=@p, hasil_lab=@h WHERE id_periksa=@id";

                // WAJIB: langsung buat object cmd
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@p", txtIDPasien.Text);
                    cmd.Parameters.AddWithValue("@h", txtHasilLab.Text);
                    cmd.Parameters.AddWithValue("@id", txtIDPeriksa.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil diupdate");
                tampilData();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error update: " + ex.Message);
            }
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (txtIDPeriksa.Text == "")
            {
                MessageBox.Show("Masukkan ID Periksa!");
                return;
            }

            try
            {
                koneksi();

                string query = "DELETE FROM PEMERIKSAAN_LAB WHERE id_periksa=@id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", txtIDPeriksa.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil dihapus");
                tampilData();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error hapus: " + ex.Message);
            }
        }

        private void btnCARI_Click(object sender, EventArgs e)
        {
            if (txtIDPeriksa.Text == "")
            {
                MessageBox.Show("Masukkan ID Periksa!");
                return;
            }

            try
            {
                koneksi();

                string query = "SELECT * FROM PEMERIKSAAN_LAB WHERE id_periksa=@id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", txtIDPeriksa.Text);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        txtIDPasien.Text = rd["id_pasien"].ToString();
                        txtHasilLab.Text = rd["hasil_lab"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan");
                    }

                    rd.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cari: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtIDPeriksa.Text = row.Cells["id_periksa"].Value.ToString();
                txtIDPasien.Text = row.Cells["id_pasien"].Value.ToString();
                txtHasilLab.Text = row.Cells["hasil_lab"].Value.ToString();
            }
        }
        void clearForm()
        {
            txtIDPeriksa.Text = "";
            txtIDPasien.Text = "";
            txtHasilLab.Text = "";
        }

    }
}
