using System;
using System.Data;
using System.Data.SqlClient;

namespace Sistem_Informasi_Hasil_Pemeriksaan_Lab_Pasien
{
    public class DAL
    {
        private string connectionString =
            "Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=HasilPemeriksaanLabDB;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable TampilPasien()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_tampil_pasien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
        }

        public int CountPasien()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_count_pasien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter total = new SqlParameter("@total", SqlDbType.Int);
                total.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(total);

                conn.Open();
                cmd.ExecuteNonQuery();

                return Convert.ToInt32(total.Value);
            }
        }

        public void InsertPasien(string nama, string jk, DateTime tanggalLahir, string alamat, string noTelp, string email, string password)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_tambah_pasien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nama_pasien", nama);
                cmd.Parameters.AddWithValue("@jenis_kelamin", jk);
                cmd.Parameters.AddWithValue("@tanggal_lahir", tanggalLahir);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@no_telp", noTelp);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password_pasien", password);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePasien(int id, string nama, string jk, DateTime tanggalLahir, string alamat, string noTelp, string email, string password)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_update_pasien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_pasien", id);
                cmd.Parameters.AddWithValue("@nama_pasien", nama);
                cmd.Parameters.AddWithValue("@jenis_kelamin", jk);
                cmd.Parameters.AddWithValue("@tanggal_lahir", tanggalLahir);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@no_telp", noTelp);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password_pasien", password);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePasien(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                SqlCommand cmdLab = new SqlCommand(
                    "DELETE FROM PEMERIKSAAN_LAB WHERE id_pasien=@id_pasien", conn);
                cmdLab.Parameters.AddWithValue("@id_pasien", id);
                cmdLab.ExecuteNonQuery();

                SqlCommand cmdAkun = new SqlCommand(
                    "DELETE FROM AKUN WHERE id_user_asli=@id_pasien AND role='Pasien'", conn);
                cmdAkun.Parameters.AddWithValue("@id_pasien", id);
                cmdAkun.ExecuteNonQuery();

                SqlCommand cmdBackup = new SqlCommand(
                    "DELETE FROM PASIEN_BACKUP WHERE id_pasien=@id_pasien", conn);
                cmdBackup.Parameters.AddWithValue("@id_pasien", id);
                cmdBackup.ExecuteNonQuery();

                SqlCommand cmdPasien = new SqlCommand(
                    "DELETE FROM PASIEN WHERE id_pasien=@id_pasien", conn);
                cmdPasien.Parameters.AddWithValue("@id_pasien", id);
                cmdPasien.ExecuteNonQuery();
            }
        }

        public void TesInjection(string nama)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query =
                    "UPDATE PASIEN SET nama_pasien='HACKED' WHERE nama_pasien='" + nama + "'";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ResetPasien()
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                UPDATE p
                SET
                    p.nama_pasien = b.nama_pasien,
                    p.jenis_kelamin = b.jenis_kelamin,
                    p.tanggal_lahir = b.tanggal_lahir,
                    p.alamat = b.alamat,
                    p.no_telp = b.no_telp,
                    p.email = b.email,
                    p.password_pasien = b.password_pasien
                FROM PASIEN p
                INNER JOIN PASIEN_BACKUP b
                ON p.id_pasien = b.id_pasien";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}