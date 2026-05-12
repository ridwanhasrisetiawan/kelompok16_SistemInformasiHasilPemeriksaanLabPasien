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

        }
    }
}
