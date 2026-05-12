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
    }
}
