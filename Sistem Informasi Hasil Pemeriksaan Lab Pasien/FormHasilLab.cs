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
    public partial class FormHasilLab: Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=HasilPemeriksaanLabDB;Integrated Security=True");
        public FormHasilLab()
        {
            InitializeComponent();
        }

        void TampilData()
        {
            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT * FROM PEMERIKSAAN_LAB",
                conn);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            dgvHasilLab.DataSource = dt;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TampilData();
        }

        private void FormHasilLab_Load(object sender, EventArgs e)
        {
            TampilData();
        }
    }
}
