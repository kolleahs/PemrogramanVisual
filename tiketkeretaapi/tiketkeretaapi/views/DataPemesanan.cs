using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using tiketkeretaapi.controllers;
using tiketkeretaapi.Models;

namespace tiketkeretaapi
{
    public partial class Data_Pemesanan : Form
    {
        private DataPemesananController controller;


        public Data_Pemesanan()
        {
            InitializeComponent();
            controller = new DataPemesananController(this);
        }

        public void LoadData()
        {
            try
            {
                dataGridView1.DataSource = controller.AmbilSemuaData();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = false;
                dataGridView1.AllowUserToAddRows = false;

                if (dataGridView1.Columns.Contains("Id"))
                {
                    dataGridView1.Columns["Id"].ReadOnly = true;
                    dataGridView1.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
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
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PemesananTiket pesantiketForm = new PemesananTiket();
            pesantiketForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                PemesananTiketDAL.UpdateData(dataGridView1);
                MessageBox.Show("Data berhasil diperbarui!");
                LoadData();
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
                        PemesananTiketDAL.DeleteData(id);
                        MessageBox.Show("Data berhasil dihapus!");
                        LoadData();
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
        public DataGridView DataGrid => dataGridView1;
        public Button BtnUpdate => btnUpdate;
        public Button BtnDelete => btnDelete;
        public Button BtnLogout => btnLogout;
        public Button BtnBack => button5; // Ganti dengan button5 jika tombol back pakai button5

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}