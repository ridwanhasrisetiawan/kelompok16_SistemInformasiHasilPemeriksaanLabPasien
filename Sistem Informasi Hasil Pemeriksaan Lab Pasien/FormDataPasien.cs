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
    public partial class FormDataPasien: Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=HasilPemeriksaanLabDB;Integrated Security=True");
        public FormDataPasien()
        {
            InitializeComponent();
        }

        void TampilData()
        {
            SqlCommand cmd =
        new SqlCommand(
            "sp_tampil_pasien",
            conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            SqlDataAdapter da =
                new SqlDataAdapter(cmd);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            dgvPasien.DataSource = dt;
        }

        void HitungTotal()
        {
            try
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "sp_count_pasien",
                        conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                SqlParameter total =
                    new SqlParameter();

                total.ParameterName = "@total";
                total.SqlDbType = SqlDbType.Int;
                total.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(total);

                conn.Open();

                cmd.ExecuteNonQuery();

                lblTotal.Text =
                    "Total Pasien : " +
                    total.Value.ToString();

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error : " + ex.Message);

                conn.Close();
            }
        }

        private void FormDataPasien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hasilPemeriksaanLabDBDataSet.PASIEN' table. You can move, or remove it, as needed.
            this.pASIENTableAdapter.Fill(this.hasilPemeriksaanLabDBDataSet.PASIEN);
            TampilData();
            HitungTotal();

            cmbJK.Items.Add("Laki-Laki");
            cmbJK.Items.Add("Perempuan");

            txtId.Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "sp_tambah_pasien",
                        conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@nama_pasien",
                    txtNamaPasien.Text);

                cmd.Parameters.AddWithValue(
                    "@jenis_kelamin",
                    cmbJK.Text);

                cmd.Parameters.AddWithValue(
                    "@tanggal_lahir",
                    dtTanggal.Value);

                cmd.Parameters.AddWithValue(
                    "@alamat",
                    txtAlamat.Text);

                cmd.Parameters.AddWithValue(
                    "@no_telp",
                    txtNoTelp.Text);

                cmd.Parameters.AddWithValue(
                    "@email",
                    txtUsername.Text);

                cmd.Parameters.AddWithValue(
                    "@password_pasien",
                    txtPassword.Text);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show(
                    "Data Pasien Berhasil Ditambah");

                TampilData();
                HitungTotal();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error : " + ex.Message);

                conn.Close();
            }
        }

        private void txtNamaPasien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "sp_update_pasien",
                        conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@id_pasien",
                    txtId.Text);

                cmd.Parameters.AddWithValue(
                    "@nama_pasien",
                    txtNamaPasien.Text);

                cmd.Parameters.AddWithValue(
                    "@jenis_kelamin",
                    cmbJK.Text);

                cmd.Parameters.AddWithValue(
                    "@tanggal_lahir",
                    dtTanggal.Value);

                cmd.Parameters.AddWithValue(
                    "@alamat",
                    txtAlamat.Text);

                cmd.Parameters.AddWithValue(
                    "@no_telp",
                    txtNoTelp.Text);

                cmd.Parameters.AddWithValue(
                    "@email",
                    txtUsername.Text);

                cmd.Parameters.AddWithValue(
                    "@password_pasien",
                    txtPassword.Text);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show(
                    "Data Berhasil Diupdate");

                TampilData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error : " + ex.Message);

                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "sp_hapus_pasien",
                        conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@id_pasien",
                    txtId.Text);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show(
                    "Data Berhasil Dihapus");

                TampilData();
                HitungTotal();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error : " + ex.Message);

                conn.Close();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TampilData();
            HitungTotal();
        }

        private void dgvPasien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;

                txtId.Text =
                    dgvPasien.Rows[i]
                    .Cells[0].Value.ToString();

                txtNamaPasien.Text =
                    dgvPasien.Rows[i]
                    .Cells[1].Value.ToString();

                cmbJK.Text =
                    dgvPasien.Rows[i]
                    .Cells[2].Value.ToString();

                dtTanggal.Text =
                    dgvPasien.Rows[i]
                    .Cells[3].Value.ToString();

                txtAlamat.Text =
                    dgvPasien.Rows[i]
                    .Cells[4].Value.ToString();

                txtNoTelp.Text =
                    dgvPasien.Rows[i]
                    .Cells[5].Value.ToString();

                txtUsername.Text =
                    dgvPasien.Rows[i]
                    .Cells[6].Value.ToString();

                txtPassword.Text =
                    dgvPasien.Rows[i]
                    .Cells[7].Value.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnTesInjection_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query =
                "UPDATE PASIEN " +
                "SET nama_pasien='HACKED' " +
                "WHERE nama_pasien='" +
                txtNamaPasien.Text + "'";

                MessageBox.Show(query);

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                int result =
                    cmd.ExecuteNonQuery();

                MessageBox.Show(
                    result + " data berhasil dihack");

                conn.Close();

                TampilData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error : " + ex.Message);

                conn.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = @"

                        UPDATE PASIEN
                        SET nama_pasien = b.nama_pasien,
                            jenis_kelamin = b.jenis_kelamin,
                            tanggal_lahir = b.tanggal_lahir,
                            alamat = b.alamat,
                            no_telp = b.no_telp,
                            email = b.email,
                            password_pasien = b.password_pasien

                        FROM PASIEN p
                        INNER JOIN PASIEN_BACKUP b
                        ON p.id_pasien = b.id_pasien

                        ";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Data berhasil direstore");

                conn.Close();

                TampilData();
                HitungTotal();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Reset gagal : " + ex.Message);

                conn.Close();
            }
        }
    }
}
