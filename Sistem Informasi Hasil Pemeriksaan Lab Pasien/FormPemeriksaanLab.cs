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
    }
}
