using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Hasil_Pemeriksaan_Lab_Pasien
{
    public class PasienReport
    {
        public PasienReport()
        {
        }

        public string nama_pasien { get; set; }
        public string jenis_tes { get; set; }
        public string hasil_lab { get; set; }
        public string nilai_normal { get; set; }
        public string diagnosa { get; set; }
    }
}
