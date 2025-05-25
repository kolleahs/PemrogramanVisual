using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tiketkeretaapi.controllers
{
    class PemesananController
    {
        private readonly PemesananRepository _repo;

        public PemesananController()
        {
            _repo = new PemesananRepository();
        }

        public bool SimpanPemesanan(PemesananTiketDAL.Pemesanan data)
        {
            if (data == null ||
                string.IsNullOrWhiteSpace(data.NamaPenumpang) ||
                string.IsNullOrWhiteSpace(data.StasiunAsal) ||
                string.IsNullOrWhiteSpace(data.StasiunTujuan) ||
                string.IsNullOrWhiteSpace(data.Kelas) ||
                data.JumlahPenumpang <= 0)
            {
                throw new ArgumentException("Data tidak valid. Pastikan semua field terisi dengan benar.");
            }

            return _repo.InsertPemesanan(data);
        }

        public DataTable AmbilSemuaData()
        {
            return PemesananTiketDAL.GetAllData();
        }

        public void HapusData(int id)
        {
            PemesananTiketDAL.DeleteData(id);
        }

        public void UpdateDataGrid(System.Windows.Forms.DataGridView dgv)
        {
            PemesananTiketDAL.UpdateData(dgv);
        }
    }
}

