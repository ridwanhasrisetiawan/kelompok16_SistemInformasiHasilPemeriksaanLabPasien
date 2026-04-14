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
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=LayananKesehatanDB;Integrated Security=True");

        public FormDashboardDokter()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {

        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {

        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {

        }

        private void btnCARI_Click(object sender, EventArgs e)
        {

        }
    }
}
