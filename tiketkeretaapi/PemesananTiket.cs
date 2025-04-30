using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tiketkeretaapi
{
    public partial class PemesananTiket : Form
    {
        public PemesananTiket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add any logic for button1 click here
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add any logic for button1 click here
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Add any logic for button1 click here
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Add any logic for label1 click here
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            // Pastikan semua field input terisi sebelum disimpan
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(comboBox1.Text) ||
                string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Harap lengkapi semua data sebelum menyimpan!");
                return;
            }

            // Membuka koneksi ke database
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2A7QU8GB;Initial Catalog=tiketkeretaapi;TrustServerCertificate=True;Integrated Security=True;"))
            {
                try
                {
                    con.Open();

                    string query = "INSERT INTO PemesananTiket (NamaPenumpang, TanggalKeberangkatan, StasiunAsal, StasiunTujuan, Kelas, JumlahPenumpang) " +
                                   "VALUES (@NamaPenumpang, @TanggalKeberangkatan, @StasiunAsal, @StasiunTujuan, @Kelas, @JumlahPenumpang)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Menambahkan parameter ke query SQL
                        cmd.Parameters.AddWithValue("@NamaPenumpang", textBox1.Text);
                        cmd.Parameters.AddWithValue("@TanggalKeberangkatan", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@StasiunAsal", textBox3.Text);
                        cmd.Parameters.AddWithValue("@StasiunTujuan", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Kelas", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@JumlahPenumpang", int.Parse(textBox6.Text));

                        // Menjalankan query
                        cmd.ExecuteNonQuery();

                        // Menampilkan pesan sukses
                        MessageBox.Show("Data berhasil disimpan!");

                        // Memanggil metode untuk memuat ulang data pada DataGridView di form Data_Pemesanan
                        if (this.Owner is Data_Pemesanan dataPemesananForm)
                        {
                            dataPemesananForm.LoadData();  // Memanggil metode LoadData dari Data_Pemesanan
                        }


                    }
                }
                catch (Exception ex)
                {
                    // Menangani jika terjadi kesalahan
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Data_Pemesanan DataPemesananForm = new Data_Pemesanan();
            DataPemesananForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
    }
}
