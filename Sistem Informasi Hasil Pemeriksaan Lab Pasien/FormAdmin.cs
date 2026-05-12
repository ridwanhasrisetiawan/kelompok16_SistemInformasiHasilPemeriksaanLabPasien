using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Informasi_Hasil_Pemeriksaan_Lab_Pasien
{
    public partial class FormAdmin: Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnDataPasien_Click(object sender, EventArgs e)
        {
            FormDataPasien frm =
                new FormDataPasien();

            frm.Show();
        }

        private void btnDataDokter_Click(object sender, EventArgs e)
        {
            FormDokter frm =
                new FormDokter();

            frm.Show();
        }

        private void btnPemeriksaan_Click(object sender, EventArgs e)
        {
            FormPemeriksaanLab frm =
                new FormPemeriksaanLab();

            frm.Show();
        }

        private void btnHasilLab_Click(object sender, EventArgs e)
        {
            FormHasilLab frm =
                new FormHasilLab();

            frm.Show();
        }
    }
    }
}
