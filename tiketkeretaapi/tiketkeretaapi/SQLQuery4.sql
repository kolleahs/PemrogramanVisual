CREATE TABLE PemesananTiket (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NamaPenumpang NVARCHAR(100) NOT NULL,
    TanggalKeberangkatan DATE NOT NULL,
    StasiunAsal NVARCHAR(100) NOT NULL,
    StasiunTujuan NVARCHAR(100) NOT NULL,
    Kelas NVARCHAR(50) NOT NULL,
    JumlahPenumpang INT NOT NULL
);
