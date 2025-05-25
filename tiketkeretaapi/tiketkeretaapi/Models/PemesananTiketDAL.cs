using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiketkeretaapi
{
    class PemesananTiketDAL
    {

        public static DataTable GetAllData()
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM PemesananTiket";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void UpdateData(DataGridView dataGridView)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    string namaPenumpang = row.Cells["NamaPenumpang"].Value?.ToString();
                    DateTime tanggal = Convert.ToDateTime(row.Cells["TanggalKeberangkatan"].Value);
                    string asal = row.Cells["StasiunAsal"].Value?.ToString();
                    string tujuan = row.Cells["StasiunTujuan"].Value?.ToString();
                    string kelas = row.Cells["Kelas"].Value?.ToString();
                    int jumlah = Convert.ToInt32(row.Cells["JumlahPenumpang"].Value);

                    string query = @"UPDATE PemesananTiket SET 
                                    NamaPenumpang = @Nama, 
                                    TanggalKeberangkatan = @Tanggal, 
                                    StasiunAsal = @Asal, 
                                    StasiunTujuan = @Tujuan, 
                                    Kelas = @Kelas, 
                                    JumlahPenumpang = @Jumlah 
                                    WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nama", namaPenumpang);
                        cmd.Parameters.AddWithValue("@Tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@Asal", asal);
                        cmd.Parameters.AddWithValue("@Tujuan", tujuan);
                        cmd.Parameters.AddWithValue("@Kelas", kelas);
                        cmd.Parameters.AddWithValue("@Jumlah", jumlah);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void DeleteData(int id)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                string query = "DELETE FROM PemesananTiket WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public class Pemesanan
        {
            public string NamaPenumpang { get; set; }
            public DateTime TanggalKeberangkatan { get; set; }
            public string StasiunAsal { get; set; }
            public string StasiunTujuan { get; set; }
            public string Kelas { get; set; }
            public int JumlahPenumpang { get; set; }
        }

        

    }
}
