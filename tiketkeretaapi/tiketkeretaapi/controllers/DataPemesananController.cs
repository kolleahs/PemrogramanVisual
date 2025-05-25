using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tiketkeretaapi;

namespace tiketkeretaapi.controllers
{
    class DataPemesananController
    {
        private Data_Pemesanan _view;
        private PemesananRepository _repository;

        public DataPemesananController(Data_Pemesanan view)
        {
            _view = view;
            _repository = new PemesananRepository();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            _view.Load += OnFormLoad;
            _view.BtnUpdate.Click += OnUpdateClick;
            _view.BtnDelete.Click += OnDeleteClick;
            _view.BtnLogout.Click += OnLogoutClick;
            _view.BtnBack.Click += OnBackClick;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _view.DataGrid.DataSource = PemesananTiketDAL.GetAllData();

                _view.DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                _view.DataGrid.MultiSelect = false;
                _view.DataGrid.ReadOnly = false;
                _view.DataGrid.AllowUserToAddRows = false;

                if (_view.DataGrid.Columns.Contains("Id"))
                {
                    _view.DataGrid.Columns["Id"].ReadOnly = true;
                    _view.DataGrid.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data: " + ex.Message);
            }
        }

        private void OnUpdateClick(object sender, EventArgs e)
        {
            try
            {
                PemesananTiketDAL.UpdateData(_view.DataGrid);
                MessageBox.Show("Data berhasil diperbarui!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memperbarui data: " + ex.Message);
            }
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            if (_view.DataGrid.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(_view.DataGrid.CurrentRow.Cells["Id"].Value);
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

        private void OnLogoutClick(object sender, EventArgs e)
        {
            _view.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void OnBackClick(object sender, EventArgs e)
        {
            _view.Hide();
            PemesananTiket formPesan = new PemesananTiket();
            formPesan.Show();

        }
        public DataTable AmbilSemuaData()
        {
            return PemesananTiketDAL.GetAllData();
        }
    }
}
