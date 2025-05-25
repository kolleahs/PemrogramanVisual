using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tiketkeretaapi.PemesananTiketDAL;

namespace tiketkeretaapi
{
    class PemesananRepository
    {
        public bool InsertPemesanan(Pemesanan pemesanan)
        {
            try
            {
                using (SqlConnection con = koneksi.GetConnection())
                {
                    con.Open();
                    string query = "INSERT INTO PemesananTiket " +
                                   "(NamaPenumpang, TanggalKeberangkatan, StasiunAsal, StasiunTujuan, Kelas, JumlahPenumpang) " +
                                   "VALUES (@NamaPenumpang, @TanggalKeberangkatan, @StasiunAsal, @StasiunTujuan, @Kelas, @JumlahPenumpang)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NamaPenumpang", pemesanan.NamaPenumpang);
                        cmd.Parameters.AddWithValue("@TanggalKeberangkatan", pemesanan.TanggalKeberangkatan);
                        cmd.Parameters.AddWithValue("@StasiunAsal", pemesanan.StasiunAsal);
                        cmd.Parameters.AddWithValue("@StasiunTujuan", pemesanan.StasiunTujuan);
                        cmd.Parameters.AddWithValue("@Kelas", pemesanan.Kelas);
                        cmd.Parameters.AddWithValue("@JumlahPenumpang", pemesanan.JumlahPenumpang);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
