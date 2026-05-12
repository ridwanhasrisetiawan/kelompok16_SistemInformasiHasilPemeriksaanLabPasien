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
    public partial class FormDokter: Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=HasilPemeriksaanLabDB;Integrated Security=True");
        public FormDokter()
        {
            InitializeComponent();
        }

        void TampilData()
        {
            SqlDataAdapter da =
                new SqlDataAdapter(
                "sp_TampilDokter",
                conn);

            da.SelectCommand.CommandType =
                CommandType.StoredProcedure;

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            dgvDokter.DataSource = dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "sp_InsertDokter", conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@nama",
                    txtNamaDokter.Text);

                cmd.Parameters.AddWithValue(
                    "@spesialis",
                    txtSpesialis.Text);

                cmd.Parameters.AddWithValue(
                    "@email",
                    txtEmail.Text);

                cmd.Parameters.AddWithValue(
                    "@password",
                    txtPassword.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Data Dokter Berhasil Ditambah");

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    "sp_UpdateDokter", conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@id",
                    txtId.Text);

                cmd.Parameters.AddWithValue(
                    "@nama",
                    txtNamaDokter.Text);

                cmd.Parameters.AddWithValue(
                    "@spesialis",
                    txtSpesialis.Text);

                cmd.Parameters.AddWithValue(
                    "@email",
                    txtEmail.Text);

                cmd.Parameters.AddWithValue(
                    "@password",
                    txtPassword.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Data Berhasil Diupdate");

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    "sp_DeleteDokter", conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@id",
                    txtId.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Data Berhasil Dihapus");

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

        private void dgvDokter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;

                txtId.Text =
                    dgvDokter.Rows[i]
                    .Cells[0].Value.ToString();

                txtNamaDokter.Text =
                    dgvDokter.Rows[i]
                    .Cells[1].Value.ToString();

                txtSpesialis.Text =
                    dgvDokter.Rows[i]
                    .Cells[2].Value.ToString();

                txtEmail.Text =
                    dgvDokter.Rows[i]
                    .Cells[3].Value.ToString();

                txtPassword.Text =
                    dgvDokter.Rows[i]
                    .Cells[4].Value.ToString();
            }
        }
    }
}
