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
    public partial class Form1: Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=LayananKesehatanDB;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("admin");
            cmbRole.Items.Add("dokter");
            cmbRole.Items.Add("pasien");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
