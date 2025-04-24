## PemrogramanVisual 
## Aplikasi Tiket Kereta Api Sederhana
## LINK DESAIN FIGMA : https://www.figma.com/design/AobeGANgW9WI5lHL45Gsgn/Figma-basics?node-id=1669-162202&t=CYJNvtjnY2euLyDw-1
![Screenshot 2025-04-19 173507](https://github.com/user-attachments/assets/5d4f7687-5c97-4fd8-a2f0-ab86000f9588)

Aplikasi ini adalah program sederhana untuk mengelola informasi tiket kereta api. Pengguna dapat menambahkan, menyimpan, memperbarui, dan menghapus data tiket.

#  Aplikasi Pemesanan Tiket Kereta Api - C# WinForms

##  Tujuan Aplikasi
Aplikasi desktop ini dibuat untuk:
- Memesan tiket kereta api
- Melihat dan mengelola data perjalanan
- Melihat daftar tiket
- Mencetak tiket
- Menyediakan antarmuka pengguna sederhana berbasis Windows Forms

---


---

##  Struktur Project (6 Form Utama)

### 1.  Form Login
**Komponen:**
- TextBox: Username, Password
- Button: Login, Exit

**Fitur:**
- Validasi login (berbasis database atau file lokal)
- Arahkan ke **Main Menu** jika berhasil login

---

### 2.  Form Main Menu (Dashboard)
**Komponen:**
- Label: Selamat datang
- Button Navigasi:
  - Pemesanan Tiket
  - Data Perjalanan
  - Daftar Tiket
  - Cetak Tiket
  - Logout

**Fitur:**
- Navigasi menuju form lainnya

---

### 3.  Form Pemesanan Tiket
**Komponen:**
- TextBox: Nomor Tiket, Nama Penumpang
- DateTimePicker: Tanggal Keberangkatan
- ComboBox: Stasiun Asal, Stasiun Tujuan, Kelas (Ekonomi, Bisnis, Eksekutif)
- NumericUpDown: Jumlah Penumpang
- Button: Hitung Harga, Simpan

**Fitur:**
- Perhitungan harga otomatis berdasarkan kelas dan jumlah penumpang
- Simpan data ke database

---

### 4.  Form Data Perjalanan (CRUD)
**Komponen:**
- DataGridView: Menampilkan data perjalanan
- TextBox/ComboBox: Nama Kereta, Rute, Harga, Jadwal
- Button: Add, Update, Delete

**Fitur:**
- CRUD (Create, Read, Update, Delete) data perjalanan

---

### 5.  Form Daftar Tiket
**Komponen:**
- DataGridView: Menampilkan daftar tiket
- TextBox: Cari tiket berdasarkan nama penumpang atau tujuan

**Fitur:**
- Pencarian dan filter tiket
- Lihat detail tiket

---

### 6.  Form Cetak Tiket
**Komponen:**
- ComboBox: Pilih nomor tiket
- Label: Menampilkan info tiket
- Button: Cetak Tiket

**Fitur:**
- Preview dan cetak tiket menggunakan `PrintDocument`

---







