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
    public partial class FormPemeriksaanLab: Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=HasilPemeriksaanLabDB;Integrated Security=True");
        public FormPemeriksaanLab()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    "sp_UpdatePemeriksaanLab",
                    conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@id",
                    txtId.Text);

                cmd.Parameters.AddWithValue(
                    "@pasien",
                    txtPasien.Text);

                cmd.Parameters.AddWithValue(
                    "@dokter",
                    txtDokter.Text);

                cmd.Parameters.AddWithValue(
                    "@admin",
                    txtAdmin.Text);

                cmd.Parameters.AddWithValue(
                    "@jenis",
                    txtJenisTes.Text);

                cmd.Parameters.AddWithValue(
                    "@hasil",
                    txtHasilLab.Text);

                cmd.Parameters.AddWithValue(
                    "@normal",
                    txtNilaiNormal.Text);

                cmd.Parameters.AddWithValue(
                    "@diagnosa",
                    txtDiagnosa.Text);

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

        private void FormPemeriksaanLab_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hasilPemeriksaanLabDBDataSet2.PEMERIKSAAN_LAB' table. You can move, or remove it, as needed.
            this.pEMERIKSAAN_LABTableAdapter.Fill(this.hasilPemeriksaanLabDBDataSet2.PEMERIKSAAN_LAB);

        }

        void TampilData()
        {
            SqlDataAdapter da =
            new SqlDataAdapter(
            "sp_TampilPemeriksaanLab",
            conn);

            da.SelectCommand.CommandType =
            CommandType.StoredProcedure;

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            dgvPemeriksaan.DataSource = dt;
        }

        void TampilDokter()
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

        }

        void TampilAdmin()
        {
            SqlDataAdapter da =
         new SqlDataAdapter(
         "sp_TampilAdmin",
         conn);

            da.SelectCommand.CommandType =
                CommandType.StoredProcedure;

            DataTable dt =
                new DataTable();

            da.Fill(dt);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    "sp_InsertPemeriksaanLab",
                    conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@pasien",
                    txtPasien.Text);

                cmd.Parameters.AddWithValue(
                    "@dokter",
                    txtDokter.Text);

                cmd.Parameters.AddWithValue(
                    "@admin",
                    txtAdmin.Text);

                cmd.Parameters.AddWithValue(
                    "@jenis",
                    txtJenisTes.Text);

                cmd.Parameters.AddWithValue(
                    "@hasil",
                    txtHasilLab.Text);

                cmd.Parameters.AddWithValue(
                    "@normal",
                    txtNilaiNormal.Text);

                cmd.Parameters.AddWithValue(
                    "@diagnosa",
                    txtDiagnosa.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Data Pemeriksaan Berhasil Ditambah");

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
                    "sp_DeletePemeriksaanLab",
                    conn);

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

        private void dgvPemeriksaan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;

                txtId.Text =
                    dgvPemeriksaan.Rows[i]
                    .Cells[0].Value.ToString();

                txtPasien.Text =
                    dgvPemeriksaan.Rows[i]
                    .Cells[1].Value.ToString();

                txtDokter.Text =
                    dgvPemeriksaan.Rows[i]
                    .Cells[2].Value.ToString();

                txtAdmin.Text =
                    dgvPemeriksaan.Rows[i]
                    .Cells[3].Value.ToString();

                txtJenisTes.Text =
                    dgvPemeriksaan.Rows[i]
                    .Cells[4].Value.ToString();

                txtHasilLab.Text =
                    dgvPemeriksaan.Rows[i]
                    .Cells[5].Value.ToString();

                txtNilaiNormal.Text =
                    dgvPemeriksaan.Rows[i]
                    .Cells[6].Value.ToString();

                txtDiagnosa.Text =
                    dgvPemeriksaan.Rows[i]
                    .Cells[7].Value.ToString();
            }
        }
    }
}
