using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sistem_Informasi_Hasil_Pemeriksaan_Lab_Pasien
{
    public partial class FormDataPasien : Form
    {
        DAL dbLogic = new DAL();

        public FormDataPasien()
        {
            InitializeComponent();
        }

        private void FormDataPasien_Load(object sender, EventArgs e)
        {
            TampilData();
            HitungTotal();

            cmbJK.Items.Clear();
            cmbJK.Items.Add("Laki-Laki");
            cmbJK.Items.Add("Perempuan");

            txtId.Visible = false;

            dgvPasien.CellClick += dgvPasien_CellClick;
        }

        void TampilData()
        {
            try
            {
                dgvPasien.DataSource = dbLogic.TampilPasien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data : " + ex.Message);
            }
        }

        void HitungTotal()
        {
            try
            {
                lblTotal.Text = "Total Pasien : " + dbLogic.CountPasien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal hitung total : " + ex.Message);
            }
        }

        private bool ValidasiInput()
        {
            if (txtNamaPasien.Text.Trim() == "" ||
                cmbJK.Text.Trim() == "" ||
                txtAlamat.Text.Trim() == "" ||
                txtNoTelp.Text.Trim() == "" ||
                txtUsername.Text.Trim() == "" ||
                txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Semua data harus diisi!");
                return false;
            }

            if (!Regex.IsMatch(txtNamaPasien.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Nama pasien hanya boleh huruf dan spasi!");
                return false;
            }

            if (!Regex.IsMatch(txtAlamat.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Alamat tidak boleh mengandung simbol!");
                return false;
            }

            if (!Regex.IsMatch(txtNoTelp.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Nomor telepon hanya boleh angka!");
                return false;
            }

            if (!Regex.IsMatch(txtUsername.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email tidak valid!");
                return false;
            }

            if (!Regex.IsMatch(txtPassword.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Password tidak boleh mengandung simbol!");
                return false;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter!");
                return false;
            }

            return true;
        }

        void Bersih()
        {
            txtId.Clear();
            txtNamaPasien.Clear();
            cmbJK.SelectedIndex = -1;
            txtAlamat.Clear();
            txtNoTelp.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            dtTanggal.Value = DateTime.Now;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;

            try
            {
                dbLogic.InsertPasien(
                    txtNamaPasien.Text,
                    cmbJK.Text,
                    dtTanggal.Value,
                    txtAlamat.Text,
                    txtNoTelp.Text,
                    txtUsername.Text,
                    txtPassword.Text
                );

                MessageBox.Show("Data pasien berhasil ditambah");

                TampilData();
                HitungTotal();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Pilih data yang akan diupdate!");
                return;
            }

            if (!ValidasiInput())
                return;

            try
            {
                dbLogic.UpdatePasien(
                    Convert.ToInt32(txtId.Text),
                    txtNamaPasien.Text,
                    cmbJK.Text,
                    dtTanggal.Value,
                    txtAlamat.Text,
                    txtNoTelp.Text,
                    txtUsername.Text,
                    txtPassword.Text
                );

                MessageBox.Show("Data berhasil diupdate");

                TampilData();
                HitungTotal();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Pilih data yang akan dihapus!");
                return;
            }

            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hasil == DialogResult.No)
                return;

            try
            {
                dbLogic.DeletePasien(Convert.ToInt32(txtId.Text));

                MessageBox.Show("Data berhasil dihapus");

                TampilData();
                HitungTotal();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TampilData();
            HitungTotal();
        }

        private void dgvPasien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvPasien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNamaPasien.Text = dgvPasien.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbJK.Text = dgvPasien.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtTanggal.Value = Convert.ToDateTime(dgvPasien.Rows[e.RowIndex].Cells[3].Value);
                txtAlamat.Text = dgvPasien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNoTelp.Text = dgvPasien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtUsername.Text = dgvPasien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPassword.Text = dgvPasien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void btnTesInjection_Click(object sender, EventArgs e)
        {
            if (txtNamaPasien.Text == "")
            {
                MessageBox.Show("Pilih data pasien dulu!");
                return;
            }

            try
            {
                dbLogic.TesInjection(txtNamaPasien.Text);

                MessageBox.Show("Data berhasil dihack");

                TampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                dbLogic.ResetPasien();

                MessageBox.Show("Data berhasil direstore");

                TampilData();
                HitungTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reset gagal : " + ex.Message);
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Pilih File Excel Pasien";
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel 97-2003 Files (*.xls)|*.xls";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;
            string extension = Path.GetExtension(filePath).ToLower();
            string connString = "";

            if (extension == ".xls")
            {
                connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath +
                             ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'";
            }
            else if (extension == ".xlsx")
            {
                connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath +
                             ";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;'";
            }
            else
            {
                MessageBox.Show("Format file harus .xls atau .xlsx");
                return;
            }

            try
            {
                DataTable dtExcel = new DataTable();

                using (OleDbConnection excelConn = new OleDbConnection(connString))
                {
                    excelConn.Open();

                    DataTable dtSheets = excelConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    if (dtSheets == null || dtSheets.Rows.Count == 0)
                    {
                        MessageBox.Show("Sheet di dalam file Excel tidak ditemukan.");
                        return;
                    }

                    string sheetName = dtSheets.Rows[0]["TABLE_NAME"].ToString();

                    OleDbDataAdapter da = new OleDbDataAdapter(
                        "SELECT * FROM [" + sheetName + "]", excelConn);

                    da.Fill(dtExcel);
                }

                string[] kolomWajib =
                {
                    "nama_pasien",
                    "jenis_kelamin",
                    "tanggal_lahir",
                    "alamat",
                    "no_telp",
                    "email",
                    "password_pasien"
                };

                foreach (string kolom in kolomWajib)
                {
                    if (!dtExcel.Columns.Contains(kolom))
                    {
                        MessageBox.Show("Kolom Excel tidak lengkap. Kolom hilang: " + kolom);
                        return;
                    }
                }

                int berhasil = 0;

                foreach (DataRow row in dtExcel.Rows)
                {
                    string nama = row["nama_pasien"].ToString().Trim();
                    string jk = row["jenis_kelamin"].ToString().Trim();
                    string tanggal = row["tanggal_lahir"].ToString().Trim();
                    string alamat = row["alamat"].ToString().Trim();
                    string noTelp = row["no_telp"].ToString().Trim();
                    string email = row["email"].ToString().Trim();
                    string password = row["password_pasien"].ToString().Trim();

                    if (nama == "" && jk == "" && tanggal == "" && alamat == "" &&
                        noTelp == "" && email == "" && password == "")
                    {
                        continue;
                    }

                    if (nama == "" || jk == "" || tanggal == "" || alamat == "" ||
                        noTelp == "" || email == "" || password == "")
                    {
                        MessageBox.Show("Ada baris yang belum lengkap.");
                        return;
                    }

                    if (!Regex.IsMatch(nama, @"^[a-zA-Z\s]+$"))
                    {
                        MessageBox.Show("Nama hanya boleh huruf dan spasi: " + nama);
                        return;
                    }

                    if (jk != "Laki-Laki" && jk != "Perempuan")
                    {
                        MessageBox.Show("Jenis kelamin harus Laki-Laki atau Perempuan.");
                        return;
                    }

                    DateTime tglLahir;

                    if (!DateTime.TryParse(tanggal, out tglLahir))
                    {
                        MessageBox.Show("Tanggal lahir tidak valid pada data: " + nama);
                        return;
                    }

                    if (!Regex.IsMatch(noTelp, @"^[0-9]+$"))
                    {
                        MessageBox.Show("Nomor telepon hanya boleh angka: " + nama);
                        return;
                    }

                    if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    {
                        MessageBox.Show("Email tidak valid: " + email);
                        return;
                    }

                    if (password.Length < 6)
                    {
                        MessageBox.Show("Password minimal 6 karakter: " + nama);
                        return;
                    }

                    dbLogic.InsertPasien(
                        nama,
                        jk,
                        tglLahir,
                        alamat,
                        noTelp,
                        email,
                        password
                    );

                    berhasil++;
                }

                MessageBox.Show(berhasil + " data berhasil diimport ke database.");

                TampilData();
                HitungTotal();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal import Excel: " + ex.Message);
            }
        }
    }
}