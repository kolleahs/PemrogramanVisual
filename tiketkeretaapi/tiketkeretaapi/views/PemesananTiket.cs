using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using tiketkeretaapi.controllers;
using static tiketkeretaapi.PemesananTiketDAL;
using tiketkeretaapi.Models;

namespace tiketkeretaapi
{
    public partial class PemesananTiket : Form

    {
        PemesananController controller = new PemesananController();
        public PemesananTiket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
           string.IsNullOrEmpty(textBox3.Text) ||
           string.IsNullOrEmpty(textBox4.Text) ||
           string.IsNullOrEmpty(comboBox1.Text) ||
           string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Harap lengkapi semua data sebelum menyimpan!");
                return;
            }

            try
            {
                var pemesanan = new PemesananTiketDAL.Pemesanan
                {
                    NamaPenumpang = textBox1.Text,
                    TanggalKeberangkatan = dateTimePicker1.Value.Date,
                    StasiunAsal = textBox3.Text,
                    StasiunTujuan = textBox4.Text,
                    Kelas = comboBox1.Text,
                    JumlahPenumpang = int.Parse(textBox6.Text)
                };

                bool success = controller.SimpanPemesanan(pemesanan);

                if (success)
                {
                    MessageBox.Show("Data berhasil disimpan!");

                    if (this.Owner is Data_Pemesanan dataPemesananForm)
                    {
                        dataPemesananForm.LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Terjadi kesalahan saat menyimpan data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex.Message);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PemesananTiket_Load(object sender, EventArgs e)
        {

        }
    }
}
