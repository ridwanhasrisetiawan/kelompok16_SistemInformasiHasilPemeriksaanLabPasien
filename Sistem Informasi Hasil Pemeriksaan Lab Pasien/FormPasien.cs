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
    public partial class FormPasien: Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=HasilPemeriksaanLabDB;Integrated Security=True");

        public string namaPasien;
        public string idPasien;
        public FormPasien()
        {
            InitializeComponent();
        }

        void TampilData()
        {
            try
            {
                string query =
         "SELECT " +
         "jenis_tes, " +
         "hasil_lab, " +
         "nilai_normal, " +
         "diagnosa " +
         "FROM PEMERIKSAAN_LAB " +
         "WHERE id_pasien=@id";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@id",
                    idPasien);

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvHasil.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error : " + ex.Message);
            }
        }

        private void FormPasien_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TampilData();
        }
    }
}
