using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistem_Informasi_Hasil_Pemeriksaan_Lab_Pasien
{
    public partial class FormCetakHasil : Form
    {
        SqlConnection conn =
            new SqlConnection(
            "Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=HasilPemeriksaanLabDB;Integrated Security=True");

        int idPasien;

        public FormCetakHasil(int id)
        {
            InitializeComponent();

            idPasien = id;

            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "sp_ReportHasilLab",
                        conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@id_pasien",
                    idPasien);

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                CrystalReport1 rpt =
                    new CrystalReport1();

                rpt.SetDataSource(dt);

                crystalReportViewer1.ReportSource =
                    rpt;

                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }
    }
}