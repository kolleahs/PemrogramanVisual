using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tiketkeretaapi
{
    public partial class Data_Pemesanan : Form
    {
        public Data_Pemesanan()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2A7QU8GB;Initial Catalog=tiketkeretaapi;TrustServerCertificate=True;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM PemesananTiket";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    // Set agar hanya baris yang bisa dipilih
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.MultiSelect = false; // Hanya boleh pilih 1 baris
                    dataGridView1.ReadOnly = false;
                    dataGridView1.AllowUserToAddRows = false;

                    if (dataGridView1.Columns.Contains("Id"))
                    {
                        dataGridView1.Columns["Id"].ReadOnly = true;
                        dataGridView1.Columns["Id"].Visible = false; // Sembunyikan jika tidak ingin ditampilkan
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }


        private void Data_Pemesanan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PemesananTiket pesantiketForm = new PemesananTiket();
            pesantiketForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Tidak perlu diisi kalau tidak digunakan
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PemesananTiket pesantiketForm = new PemesananTiket();
            pesantiketForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tidak perlu diisi
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2A7QU8GB;Initial Catalog=tiketkeretaapi;TrustServerCertificate=True;Integrated Security=True;"))
                {
                    con.Open();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue; // Lewati baris kosong

                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        string namaPenumpang = row.Cells["NamaPenumpang"].Value?.ToString();
                        DateTime tanggalKeberangkatan = Convert.ToDateTime(row.Cells["TanggalKeberangkatan"].Value);
                        string stasiunAsal = row.Cells["StasiunAsal"].Value?.ToString();
                        string stasiunTujuan = row.Cells["StasiunTujuan"].Value?.ToString();
                        string kelas = row.Cells["Kelas"].Value?.ToString();
                        int jumlahPenumpang = Convert.ToInt32(row.Cells["JumlahPenumpang"].Value);

                        string query = "UPDATE PemesananTiket SET " +
                                       "NamaPenumpang = @NamaPenumpang, " +
                                       "TanggalKeberangkatan = @TanggalKeberangkatan, " +
                                       "StasiunAsal = @StasiunAsal, " +
                                       "StasiunTujuan = @StasiunTujuan, " +
                                       "Kelas = @Kelas, " +
                                       "JumlahPenumpang = @JumlahPenumpang " +
                                       "WHERE Id = @Id";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.Parameters.AddWithValue("@NamaPenumpang", namaPenumpang);
                            cmd.Parameters.AddWithValue("@TanggalKeberangkatan", tanggalKeberangkatan);
                            cmd.Parameters.AddWithValue("@StasiunAsal", stasiunAsal);
                            cmd.Parameters.AddWithValue("@StasiunTujuan", stasiunTujuan);
                            cmd.Parameters.AddWithValue("@Kelas", kelas);
                            cmd.Parameters.AddWithValue("@JumlahPenumpang", jumlahPenumpang);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data berhasil diperbarui!");
                    LoadData(); // Refresh data setelah update
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memperbarui data: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                        using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2A7QU8GB;Initial Catalog=tiketkeretaapi;TrustServerCertificate=True;Integrated Security=True;"))
                        {
                            con.Open();
                            string query = "DELETE FROM PemesananTiket WHERE Id = @Id";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@Id", id);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Data berhasil dihapus!");
                        LoadData(); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan saat menghapus data: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih baris yang ingin dihapus terlebih dahulu.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
    }
}