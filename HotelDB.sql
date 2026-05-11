USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'HotelDB')
    DROP DATABASE HotelDB;
GO

CREATE DATABASE HotelDB COLLATE SQL_Latin1_General_CP1_CI_AS;
GO

USE HotelDB;
GO

-- ══════════════════════════════════════════════════════════
-- TABLES
-- ══════════════════════════════════════════════════════════

CREATE TABLE [User] (
    id_user    INT           IDENTITY(1,1) PRIMARY KEY,
    nama       NVARCHAR(100) NOT NULL,
    email      NVARCHAR(100) NOT NULL UNIQUE,
    password   NVARCHAR(255) NOT NULL,
    role       NVARCHAR(20)  NOT NULL CHECK (role IN ('Admin','Resepsionis')),
    is_active  BIT           NOT NULL DEFAULT 1,
    created_at DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE Tamu (
    id_tamu    INT           IDENTITY(1,1) PRIMARY KEY,
    nik        CHAR(16)      NOT NULL UNIQUE,
    nama       NVARCHAR(100) NOT NULL,
    email      NVARCHAR(100),
    no_hp      NVARCHAR(20),
    gender     NVARCHAR(10)  NOT NULL CHECK (gender IN ('Laki-laki','Perempuan')),
    alamat     NVARCHAR(255),
    created_at DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE TipeKamar (
    id_tipe    INT           IDENTITY(1,1) PRIMARY KEY,
    nama_tipe  NVARCHAR(50)  NOT NULL UNIQUE,
    harga      DECIMAL(12,2) NOT NULL CHECK (harga > 0),
    deskripsi  NVARCHAR(255),
    created_at DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE Kamar (
    id_kamar     INT          IDENTITY(1,1) PRIMARY KEY,
    id_tipe      INT          NOT NULL REFERENCES TipeKamar(id_tipe),
    nomor_kamar  NVARCHAR(10) NOT NULL UNIQUE,
    status       NVARCHAR(20) NOT NULL DEFAULT 'Tersedia'
                              CHECK (status IN ('Tersedia','Terisi','Maintenance')),
    created_at   DATETIME     NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE Properti (
    id_properti   INT           IDENTITY(1,1) PRIMARY KEY,
    nama_properti NVARCHAR(100) NOT NULL UNIQUE,
    biaya_denda   DECIMAL(12,2) NOT NULL DEFAULT 0 CHECK (biaya_denda >= 0),
    created_at    DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE PropertiKamar (
    id_detail   INT          IDENTITY(1,1) PRIMARY KEY,
    id_properti INT          NOT NULL REFERENCES Properti(id_properti) ON DELETE CASCADE,
    id_kamar    INT          NOT NULL REFERENCES Kamar(id_kamar)       ON DELETE CASCADE,
    kondisi     NVARCHAR(20) NOT NULL DEFAULT 'Baik'
                             CHECK (kondisi IN ('Baik','Rusak','Dalam Perbaikan')),
    updated_at  DATETIME     NOT NULL DEFAULT GETDATE(),
    CONSTRAINT UQ_PropertiKamar UNIQUE (id_properti, id_kamar)
);
GO

CREATE TABLE Reservasi (
    id_reservasi      INT          IDENTITY(1,1) PRIMARY KEY,
    id_tamu           INT          NOT NULL REFERENCES Tamu(id_tamu),
    tipe_reservasi    NVARCHAR(30) NOT NULL
                                   CHECK (tipe_reservasi IN ('Walk-in (Langsung)','Online / Contact')),
    tanggal_reservasi DATE         NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    tanggal_checkin   DATE         NOT NULL,
    tanggal_checkout  DATE         NOT NULL,
    status            NVARCHAR(20) NOT NULL DEFAULT 'Pending'
                                   CHECK (status IN ('Pending','Confirmed','Checked-In','Checked-Out','Cancelled')),
    created_at        DATETIME     NOT NULL DEFAULT GETDATE(),
    CONSTRAINT CHK_Tanggal CHECK (tanggal_checkout > tanggal_checkin)
);
GO

CREATE TABLE DetailReservasi (
    id_detail    INT           IDENTITY(1,1) PRIMARY KEY,
    id_reservasi INT           NOT NULL REFERENCES Reservasi(id_reservasi) ON DELETE CASCADE,
    id_kamar     INT           NOT NULL REFERENCES Kamar(id_kamar),
    harga_kamar  DECIMAL(12,2) NOT NULL CHECK (harga_kamar > 0),
    CONSTRAINT UQ_DetailReservasi UNIQUE (id_reservasi, id_kamar)
);
GO

CREATE TABLE Transaksi (
    id_transaksi      INT           IDENTITY(1,1) PRIMARY KEY,
    id_reservasi      INT           NOT NULL REFERENCES Reservasi(id_reservasi),
    id_user           INT           NOT NULL REFERENCES [User](id_user),
    total_bayar       DECIMAL(12,2) NOT NULL CHECK (total_bayar >= 0),
    denda_telat       DECIMAL(12,2) NOT NULL DEFAULT 0 CHECK (denda_telat >= 0),
    denda_kerusakan   DECIMAL(12,2) NOT NULL DEFAULT 0 CHECK (denda_kerusakan >= 0),
    metode_pembayaran NVARCHAR(30)  NOT NULL
                                    CHECK (metode_pembayaran IN
                                           ('Tunai','Kartu Debit','Kartu Kredit','Transfer Bank','QRIS')),
    tanggal_transaksi DATETIME      NOT NULL DEFAULT GETDATE(),
    CONSTRAINT UQ_Transaksi_Reservasi UNIQUE (id_reservasi)
);
GO

CREATE TABLE DendaKerusakan (
    id_denda     INT           IDENTITY(1,1) PRIMARY KEY,
    id_transaksi INT           NOT NULL REFERENCES Transaksi(id_transaksi) ON DELETE CASCADE,
    id_properti  INT           NOT NULL REFERENCES Properti(id_properti),
    id_kamar     INT           NOT NULL REFERENCES Kamar(id_kamar),
    biaya_denda  DECIMAL(12,2) NOT NULL CHECK (biaya_denda >= 0),
    catatan      NVARCHAR(255)
);
GO

-- ══════════════════════════════════════════════════════════
-- INDEXES
-- ══════════════════════════════════════════════════════════

CREATE INDEX IX_Tamu_NIK             ON Tamu(nik);
CREATE INDEX IX_Tamu_Nama            ON Tamu(nama);
CREATE INDEX IX_Kamar_Status         ON Kamar(status);
CREATE INDEX IX_Kamar_IdTipe         ON Kamar(id_tipe);
CREATE INDEX IX_Reservasi_IdTamu     ON Reservasi(id_tamu);
CREATE INDEX IX_Reservasi_Status     ON Reservasi(status);
CREATE INDEX IX_Reservasi_TglCI      ON Reservasi(tanggal_checkin);
CREATE INDEX IX_Reservasi_TglCO      ON Reservasi(tanggal_checkout);
CREATE INDEX IX_DetailRes_IdKamar    ON DetailReservasi(id_kamar);
CREATE INDEX IX_DetailRes_IdRes      ON DetailReservasi(id_reservasi);
CREATE INDEX IX_PropertiKamar_IdK    ON PropertiKamar(id_kamar);
CREATE INDEX IX_PropertiKamar_IdP    ON PropertiKamar(id_properti);
CREATE INDEX IX_PropertiKamar_Kondisi ON PropertiKamar(kondisi);
CREATE INDEX IX_Transaksi_IdRes      ON Transaksi(id_reservasi);
CREATE INDEX IX_Transaksi_TglTrans   ON Transaksi(tanggal_transaksi);
CREATE INDEX IX_DendaKerusakan_Trans ON DendaKerusakan(id_transaksi);
GO

-- ══════════════════════════════════════════════════════════
-- VIEWS — data siap pakai untuk user, bukan tabel mentah
-- ══════════════════════════════════════════════════════════

-- View: Data Tamu lengkap
CREATE OR ALTER VIEW vw_DataTamu AS
SELECT
    t.id_tamu                                    AS [ID],
    t.nik                                        AS [NIK],
    t.nama                                       AS [Nama Lengkap],
    ISNULL(t.email, '-')                         AS [Email],
    ISNULL(t.no_hp, '-')                         AS [No. HP],
    t.gender                                     AS [Jenis Kelamin],
    ISNULL(t.alamat, '-')                        AS [Alamat],
    COUNT(r.id_reservasi)                        AS [Total Reservasi],
    ISNULL(MAX(CAST(r.tanggal_checkin AS NVARCHAR(20))), 'Belum pernah menginap')
                                                 AS [Terakhir Check-In],
    FORMAT(t.created_at, 'dd/MM/yyyy')           AS [Terdaftar Sejak]
FROM Tamu t
LEFT JOIN Reservasi r ON t.id_tamu = r.id_tamu
    AND r.status IN ('Checked-In','Checked-Out')
GROUP BY t.id_tamu, t.nik, t.nama, t.email,
         t.no_hp, t.gender, t.alamat, t.created_at;
GO

-- View: Data Kamar lengkap
CREATE OR ALTER VIEW vw_DataKamar AS
SELECT
    k.id_kamar                                   AS [ID Kamar],
    k.nomor_kamar                                AS [Nomor Kamar],
    tk.nama_tipe                                 AS [Tipe Kamar],
    FORMAT(tk.harga, 'N0')                       AS [Harga per Malam],
    k.status                                     AS [Status],
    COUNT(pk.id_detail)                          AS [Jumlah Properti],
    SUM(CASE WHEN pk.kondisi = 'Rusak'
             THEN 1 ELSE 0 END)                  AS [Properti Rusak],
    SUM(CASE WHEN pk.kondisi = 'Dalam Perbaikan'
             THEN 1 ELSE 0 END)                  AS [Properti Perbaikan]
FROM Kamar k
JOIN TipeKamar tk ON k.id_tipe = tk.id_tipe
LEFT JOIN PropertiKamar pk ON k.id_kamar = pk.id_kamar
GROUP BY k.id_kamar, k.nomor_kamar, tk.nama_tipe, tk.harga, k.status;
GO

--View: Data Tipe Kamar 
CREATE OR ALTER VIEW vw_DataTipeKamar AS
SELECT
    tk.id_tipe                                          AS [ID Tipe],
    tk.nama_tipe                                        AS [Nama Tipe],
    FORMAT(tk.harga, 'N0')                              AS [Harga per Malam],
    ISNULL(tk.deskripsi, '-')                           AS [Deskripsi],
    COUNT(k.id_kamar)                                   AS [Jumlah Kamar],
    SUM(CASE WHEN k.status = 'Tersedia'
             THEN 1 ELSE 0 END)                         AS [Kamar Tersedia],
    SUM(CASE WHEN k.status = 'Terisi'
             THEN 1 ELSE 0 END)                         AS [Kamar Terisi],
    SUM(CASE WHEN k.status = 'Maintenance'
             THEN 1 ELSE 0 END)                         AS [Kamar Maintenance],
    FORMAT(tk.created_at, 'dd/MM/yyyy')                 AS [Dibuat]
FROM TipeKamar tk
LEFT JOIN Kamar k ON tk.id_tipe = k.id_tipe
GROUP BY tk.id_tipe, tk.nama_tipe, tk.harga,
         tk.deskripsi, tk.created_at;
GO

-- View: Data Reservasi lengkap
CREATE OR ALTER VIEW vw_DataReservasi AS
SELECT
    r.id_reservasi                               AS [ID Reservasi],
    t.nik                                        AS [NIK Tamu],
    t.nama                                       AS [Nama Tamu],
    ISNULL(t.no_hp, '-')                         AS [No. HP],
    k.nomor_kamar                                AS [Nomor Kamar],
    tk.nama_tipe                                 AS [Tipe Kamar],
    r.tipe_reservasi                             AS [Tipe Reservasi],
    FORMAT(r.tanggal_reservasi, 'dd/MM/yyyy')    AS [Tgl Reservasi],
    FORMAT(r.tanggal_checkin,   'dd/MM/yyyy')    AS [Tgl Check-In],
    FORMAT(r.tanggal_checkout,  'dd/MM/yyyy')    AS [Tgl Check-Out],
    DATEDIFF(DAY, r.tanggal_checkin,
             r.tanggal_checkout)                 AS [Durasi (Malam)],
    FORMAT(dr.harga_kamar, 'N0')                 AS [Harga/Malam],
    FORMAT(dr.harga_kamar *
           DATEDIFF(DAY, r.tanggal_checkin,
                    r.tanggal_checkout), 'N0')   AS [Estimasi Biaya],
    r.status                                     AS [Status]
FROM Reservasi r
JOIN Tamu t             ON r.id_tamu = t.id_tamu
JOIN DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
JOIN Kamar k            ON dr.id_kamar = k.id_kamar
JOIN TipeKamar tk       ON k.id_tipe = tk.id_tipe;
GO

-- View: Data Check-In aktif
CREATE OR ALTER VIEW vw_CheckInAktif AS
SELECT
    r.id_reservasi                               AS [ID Reservasi],
    t.nik                                        AS [NIK],
    t.nama                                       AS [Nama Tamu],
    ISNULL(t.no_hp, '-')                         AS [No. HP],
    k.nomor_kamar                                AS [Nomor Kamar],
    tk.nama_tipe                                 AS [Tipe Kamar],
    r.tipe_reservasi                             AS [Tipe Reservasi],
    FORMAT(r.tanggal_checkin,  'dd/MM/yyyy')     AS [Tgl Check-In],
    FORMAT(r.tanggal_checkout, 'dd/MM/yyyy')     AS [Tgl Check-Out Plan],
    DATEDIFF(DAY, r.tanggal_checkin,
             r.tanggal_checkout)                 AS [Durasi (Malam)],
    FORMAT(dr.harga_kamar, 'N0')                 AS [Harga/Malam],
    DATEDIFF(DAY, r.tanggal_checkin,
             CAST(GETDATE() AS DATE))            AS [Hari Menginap Sekarang],
    CASE
        WHEN CAST(GETDATE() AS DATE) > r.tanggal_checkout
        THEN DATEDIFF(DAY, r.tanggal_checkout, CAST(GETDATE() AS DATE))
        ELSE 0
    END                                          AS [Hari Terlambat],
    r.status                                     AS [Status]
FROM Reservasi r
JOIN Tamu t             ON r.id_tamu = t.id_tamu
JOIN DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
JOIN Kamar k            ON dr.id_kamar = k.id_kamar
JOIN TipeKamar tk       ON k.id_tipe = tk.id_tipe
WHERE r.status IN ('Pending','Confirmed','Checked-In');
GO

-- View: Data Check-Out (sudah selesai)
CREATE OR ALTER VIEW vw_CheckOutSelesai AS
SELECT
    r.id_reservasi                               AS [ID Reservasi],
    t.nama                                       AS [Nama Tamu],
    k.nomor_kamar                                AS [Nomor Kamar],
    FORMAT(r.tanggal_checkin,  'dd/MM/yyyy')     AS [Tgl Check-In],
    FORMAT(r.tanggal_checkout, 'dd/MM/yyyy')     AS [Tgl Check-Out],
    DATEDIFF(DAY, r.tanggal_checkin,
             r.tanggal_checkout)                 AS [Durasi (Malam)],
    FORMAT(tr.total_bayar,      'N0')            AS [Total Bayar],
    FORMAT(tr.denda_telat,      'N0')            AS [Denda Telat],
    FORMAT(tr.denda_kerusakan,  'N0')            AS [Denda Kerusakan],
    tr.metode_pembayaran                         AS [Metode Bayar],
    FORMAT(tr.tanggal_transaksi,'dd/MM/yyyy HH:mm') AS [Waktu Transaksi],
    u.nama                                       AS [Diproses Oleh]
FROM Reservasi r
JOIN Tamu t             ON r.id_tamu = t.id_tamu
JOIN DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
JOIN Kamar k            ON dr.id_kamar = k.id_kamar
JOIN Transaksi tr       ON tr.id_reservasi = r.id_reservasi
JOIN [User] u           ON tr.id_user = u.id_user
WHERE r.status = 'Checked-Out';
GO

-- View: Properti
CREATE OR ALTER VIEW vw_DataProperti AS
SELECT
    p.id_properti                               AS [ID],
    p.nama_properti                             AS [Nama Properti],
    FORMAT(p.biaya_denda, 'N0')                 AS [Biaya Denda (Rp)],
    COUNT(pk.id_detail)                         AS [Jumlah Assign],
    SUM(CASE WHEN pk.kondisi = 'Rusak'
             THEN 1 ELSE 0 END)                 AS [Properti Rusak],
    SUM(CASE WHEN pk.kondisi = 'Dalam Perbaikan'
             THEN 1 ELSE 0 END)                 AS [Properti Perbaikan],
    SUM(CASE WHEN pk.kondisi = 'Baik'
             THEN 1 ELSE 0 END)                 AS [Properti Baik]
FROM Properti p
LEFT JOIN PropertiKamar pk ON p.id_properti = pk.id_properti
GROUP BY p.id_properti, p.nama_properti, p.biaya_denda;
GO

-- View: Properti per kamar lengkap
CREATE OR ALTER VIEW vw_PropertiKamar AS
SELECT
    pk.id_detail                                 AS [ID Detail],
    k.nomor_kamar                                AS [Nomor Kamar],
    tk.nama_tipe                                 AS [Tipe Kamar],
    p.nama_properti                              AS [Nama Properti],
    FORMAT(p.biaya_denda, 'N0')                  AS [Biaya Denda],
    pk.kondisi                                   AS [Kondisi],
    FORMAT(pk.updated_at, 'dd/MM/yyyy HH:mm')    AS [Terakhir Update]
FROM PropertiKamar pk
JOIN Kamar k     ON pk.id_kamar     = k.id_kamar
JOIN TipeKamar tk ON k.id_tipe      = tk.id_tipe
JOIN Properti p  ON pk.id_properti  = p.id_properti;
GO

-- View: Laporan Reservasi
CREATE OR ALTER VIEW vw_LaporanReservasi AS
SELECT
    r.id_reservasi                               AS [ID],
    FORMAT(r.tanggal_reservasi, 'dd/MM/yyyy')    AS [Tgl Reservasi],
    t.nik                                        AS [NIK],
    t.nama                                       AS [Nama Tamu],
    k.nomor_kamar                                AS [Kamar],
    tk.nama_tipe                                 AS [Tipe],
    r.tipe_reservasi                             AS [Jenis Reservasi],
    FORMAT(r.tanggal_checkin,  'dd/MM/yyyy')     AS [Check-In],
    FORMAT(r.tanggal_checkout, 'dd/MM/yyyy')     AS [Check-Out],
    DATEDIFF(DAY, r.tanggal_checkin,
             r.tanggal_checkout)                 AS [Durasi],
    FORMAT(dr.harga_kamar, 'N0')                 AS [Harga/Malam],
    FORMAT(dr.harga_kamar *
           DATEDIFF(DAY, r.tanggal_checkin,
                    r.tanggal_checkout), 'N0')   AS [Total Estimasi],
    r.status                                     AS [Status]
FROM Reservasi r
JOIN Tamu t             ON r.id_tamu = t.id_tamu
JOIN DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
JOIN Kamar k            ON dr.id_kamar = k.id_kamar
JOIN TipeKamar tk       ON k.id_tipe = tk.id_tipe;
GO

-- View: Laporan Check-In & Check-Out
CREATE OR ALTER VIEW vw_LaporanCheckInCheckOut AS
SELECT
    r.id_reservasi                               AS [ID],
    t.nik                                        AS [NIK],
    t.nama                                       AS [Nama Tamu],
    k.nomor_kamar                                AS [Kamar],
    tk.nama_tipe                                 AS [Tipe],
    FORMAT(r.tanggal_checkin,  'dd/MM/yyyy')     AS [Check-In],
    FORMAT(r.tanggal_checkout, 'dd/MM/yyyy')     AS [Check-Out],
    DATEDIFF(DAY, r.tanggal_checkin,
             r.tanggal_checkout)                 AS [Malam],
    FORMAT(dr.harga_kamar, 'N0')                 AS [Harga/Malam],
    FORMAT(dr.harga_kamar *
           DATEDIFF(DAY, r.tanggal_checkin,
                    r.tanggal_checkout), 'N0')   AS [Subtotal],
    r.status                                     AS [Status]
FROM Reservasi r
JOIN Tamu t             ON r.id_tamu = t.id_tamu
JOIN DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
JOIN Kamar k            ON dr.id_kamar = k.id_kamar
JOIN TipeKamar tk       ON k.id_tipe = tk.id_tipe
WHERE r.status IN ('Checked-In','Checked-Out');
GO

-- View: Laporan Pendapatan
CREATE OR ALTER VIEW vw_LaporanPendapatan AS
SELECT
    tr.id_transaksi                                        AS [ID Transaksi],
    FORMAT(tr.tanggal_transaksi, 'dd/MM/yyyy')             AS [Tgl Transaksi],
    t.nama                                                 AS [Nama Tamu],
    k.nomor_kamar                                          AS [Kamar],
    FORMAT(r.tanggal_checkin,  'dd/MM/yyyy')               AS [Check-In],
    FORMAT(r.tanggal_checkout, 'dd/MM/yyyy')               AS [Check-Out],
    DATEDIFF(DAY, r.tanggal_checkin, r.tanggal_checkout)   AS [Durasi (Malam)],
    FORMAT(dr.harga_kamar, 'N0')                           AS [Harga/Malam],
    FORMAT(dr.harga_kamar *
           DATEDIFF(DAY, r.tanggal_checkin,
                    r.tanggal_checkout), 'N0')             AS [Biaya Kamar],
    FORMAT(tr.denda_telat, 'N0')                           AS [Denda Telat],
    FORMAT(tr.denda_kerusakan, 'N0')                       AS [Denda Kerusakan],
    FORMAT(tr.total_bayar, 'N0')                           AS [Total Bayar],
    tr.metode_pembayaran                                   AS [Metode Bayar],
    u.nama                                                 AS [Resepsionis],
    CASE
        WHEN tr.denda_telat > 0 AND tr.denda_kerusakan > 0 THEN 'Telat + Kerusakan'
        WHEN tr.denda_telat > 0                             THEN 'Terlambat checkout'
        WHEN tr.denda_kerusakan > 0                         THEN 'Ada kerusakan properti'
        ELSE 'Normal'
    END                                                    AS [Keterangan]
FROM Transaksi tr
JOIN Reservasi r        ON tr.id_reservasi = r.id_reservasi
JOIN Tamu t             ON r.id_tamu = t.id_tamu
JOIN DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
JOIN Kamar k            ON dr.id_kamar = k.id_kamar
JOIN [User] u           ON tr.id_user = u.id_user;
GO

-- View: Laporan Denda
CREATE OR ALTER VIEW vw_LaporanDenda AS
SELECT
    tr.id_transaksi                                        AS [ID Transaksi],
    FORMAT(tr.tanggal_transaksi, 'dd/MM/yyyy')             AS [Tgl Transaksi],
    t.nama                                                 AS [Nama Tamu],
    k.nomor_kamar                                          AS [Kamar],
    FORMAT(r.tanggal_checkout, 'dd/MM/yyyy')               AS [Checkout Rencana],
    FORMAT(tr.tanggal_transaksi,'dd/MM/yyyy')              AS [Checkout Aktual],
    CASE
        WHEN CAST(tr.tanggal_transaksi AS DATE) > r.tanggal_checkout
        THEN DATEDIFF(DAY, r.tanggal_checkout,
                      CAST(tr.tanggal_transaksi AS DATE))
        ELSE 0
    END                                                    AS [Hari Terlambat],
    FORMAT(tr.denda_telat, 'N0')                           AS [Denda Keterlambatan],
    FORMAT(tr.denda_kerusakan, 'N0')                       AS [Denda Kerusakan],
    FORMAT(tr.denda_telat + tr.denda_kerusakan, 'N0')      AS [Total Denda],
    u.nama                                                 AS [Diproses Oleh]
FROM Transaksi tr
JOIN Reservasi r        ON tr.id_reservasi = r.id_reservasi
JOIN Tamu t             ON r.id_tamu = t.id_tamu
JOIN DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
JOIN Kamar k            ON dr.id_kamar = k.id_kamar
JOIN [User] u           ON tr.id_user = u.id_user
WHERE tr.denda_telat > 0 OR tr.denda_kerusakan > 0;
GO

-- View: Laporan Tamu
CREATE OR ALTER VIEW vw_LaporanTamu AS
SELECT
    t.id_tamu                                              AS [ID],
    t.nik                                                  AS [NIK],
    t.nama                                                 AS [Nama Tamu],
    ISNULL(t.email, '-')                                   AS [Email],
    ISNULL(t.no_hp, '-')                                   AS [No. HP],
    t.gender                                               AS [Gender],
    ISNULL(t.alamat, '-')                                  AS [Alamat],
    COUNT(r.id_reservasi)                                  AS [Total Reservasi],
    SUM(CASE WHEN r.status = 'Checked-Out' THEN 1 ELSE 0 END) AS [Total Menginap],
    ISNULL(FORMAT(MAX(r.tanggal_checkin), 'dd/MM/yyyy'),
           'Belum pernah')                                 AS [Terakhir Check-In],
    ISNULL(FORMAT(SUM(
        CASE WHEN r.status = 'Checked-Out'
        THEN DATEDIFF(DAY, r.tanggal_checkin, r.tanggal_checkout)
        ELSE 0 END), 'N0') + ' malam', '0 malam')         AS [Total Malam Menginap],
    FORMAT(t.created_at, 'dd/MM/yyyy')                     AS [Terdaftar Sejak]
FROM Tamu t
LEFT JOIN Reservasi r ON t.id_tamu = r.id_tamu
GROUP BY t.id_tamu, t.nik, t.nama, t.email,
         t.no_hp, t.gender, t.alamat, t.created_at;
GO

-- View: Laporan Kamar
CREATE OR ALTER VIEW vw_LaporanKamar AS
SELECT
    k.id_kamar                                             AS [ID],
    k.nomor_kamar                                          AS [No. Kamar],
    tk.nama_tipe                                           AS [Tipe],
    FORMAT(tk.harga, 'N0')                                 AS [Harga/Malam],
    k.status                                               AS [Status Kamar],
    COUNT(DISTINCT r.id_reservasi)                         AS [Total Reservasi],
    ISNULL(SUM(
        CASE WHEN r.status = 'Checked-Out'
        THEN DATEDIFF(DAY, r.tanggal_checkin, r.tanggal_checkout)
        ELSE 0 END), 0)                                    AS [Total Malam Terjual],
    FORMAT(ISNULL(SUM(
        CASE WHEN r.status = 'Checked-Out'
        THEN dr.harga_kamar *
             DATEDIFF(DAY, r.tanggal_checkin, r.tanggal_checkout)
        ELSE 0 END), 0), 'N0')                             AS [Total Pendapatan],
    COUNT(pk.id_detail)                                    AS [Jumlah Properti],
    SUM(CASE WHEN pk.kondisi = 'Rusak'
             THEN 1 ELSE 0 END)                            AS [Properti Rusak]
FROM Kamar k
JOIN TipeKamar tk ON k.id_tipe = tk.id_tipe
LEFT JOIN DetailReservasi dr ON dr.id_kamar = k.id_kamar
LEFT JOIN Reservasi r        ON dr.id_reservasi = r.id_reservasi
LEFT JOIN PropertiKamar pk   ON pk.id_kamar = k.id_kamar
GROUP BY k.id_kamar, k.nomor_kamar, tk.nama_tipe, tk.harga, k.status;
GO

-- ══════════════════════════════════════════════════════════
-- STORED PROCEDURES — LENGKAP
-- ══════════════════════════════════════════════════════════

-- ─────────────────────────────────────────────────────────
-- Auth
-- ─────────────────────────────────────────────────────────
CREATE OR ALTER PROCEDURE sp_LoginUser
    @email    NVARCHAR(100),
    @password NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF LTRIM(RTRIM(ISNULL(@email,''))) = ''
            THROW 50001, 'Email tidak boleh kosong.', 1;
        IF LTRIM(RTRIM(ISNULL(@password,''))) = ''
            THROW 50002, 'Password tidak boleh kosong.', 1;

        SELECT id_user, nama, email, role
        FROM   [User]
        WHERE  email     = @email
          AND  password  = @password
          AND  is_active = 1;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

-- ─────────────────────────────────────────────────────────
-- User Management (Admin only)
-- ─────────────────────────────────────────────────────────
CREATE OR ALTER PROCEDURE sp_GetAllUser
AS
BEGIN
    SET NOCOUNT ON;
    SELECT id_user, nama, email, role, is_active,
           FORMAT(created_at,'dd/MM/yyyy') AS terdaftar
    FROM   [User]
    ORDER BY nama;
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertUser
    @nama     NVARCHAR(100),
    @email    NVARCHAR(100),
    @password NVARCHAR(255),
    @role     NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF LTRIM(RTRIM(ISNULL(@nama,''))) = ''
            THROW 50300, 'Nama tidak boleh kosong.', 1;
        IF LTRIM(RTRIM(ISNULL(@email,''))) = ''
            THROW 50301, 'Email tidak boleh kosong.', 1;
        IF @role NOT IN ('Admin','Resepsionis')
            THROW 50302, 'Role tidak valid.', 1;
        IF EXISTS (SELECT 1 FROM [User] WHERE email = @email)
            THROW 50303, 'Email sudah digunakan.', 1;

        INSERT INTO [User] (nama, email, password, role)
        VALUES (@nama, @email, @password, @role);

        SELECT SCOPE_IDENTITY() AS id_user;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_UpdateUserStatus
    @id_user  INT,
    @is_active BIT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM [User] WHERE id_user = @id_user)
            THROW 50310, 'User tidak ditemukan.', 1;

        UPDATE [User] SET is_active = @is_active WHERE id_user = @id_user;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

-- ─────────────────────────────────────────────────────────
-- CRUD Tamu
-- ─────────────────────────────────────────────────────────
CREATE OR ALTER PROCEDURE sp_GetAllTamu
    @filter NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        SELECT id_tamu, nik, nama, email, no_hp, gender, alamat
        FROM   Tamu
        WHERE  (@filter IS NULL OR @filter = ''
             OR nik  LIKE @filter + '%'
             OR nama LIKE '%' + @filter + '%')
        ORDER BY nama;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertTamu
    @nik    CHAR(16),
    @nama   NVARCHAR(100),
    @email  NVARCHAR(100) = NULL,
    @no_hp  NVARCHAR(20)  = NULL,
    @gender NVARCHAR(10),
    @alamat NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF LEN(LTRIM(RTRIM(ISNULL(@nik, '')))) <> 16
            THROW 50010, 'NIK harus 16 karakter.', 1;

        -- Cek semua karakter adalah digit
        -- Pattern: NIK valid = TIDAK mengandung karakter non-digit
        IF @nik LIKE '%[^0-9]%'
            THROW 50011, 'NIK harus berisi angka saja.', 1;

        IF EXISTS (SELECT 1 FROM Tamu WHERE nik = @nik)
            THROW 50012, 'NIK sudah terdaftar.', 1;

        IF LTRIM(RTRIM(ISNULL(@nama, ''))) = ''
            THROW 50013, 'Nama tidak boleh kosong.', 1;

        IF @gender NOT IN ('Laki-laki', 'Perempuan')
            THROW 50014, 'Gender tidak valid.', 1;

        INSERT INTO Tamu (nik, nama, email, no_hp, gender, alamat)
        VALUES (@nik, LTRIM(RTRIM(@nama)), @email, @no_hp, @gender, @alamat);

        SELECT SCOPE_IDENTITY() AS id_tamu;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_UpdateTamu
    @id_tamu INT,
    @nik     CHAR(16),
    @nama    NVARCHAR(100),
    @email   NVARCHAR(100) = NULL,
    @no_hp   NVARCHAR(20)  = NULL,
    @gender  NVARCHAR(10),
    @alamat  NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Tamu WHERE id_tamu = @id_tamu)
            THROW 50020, 'Data tamu tidak ditemukan.', 1;
        IF EXISTS (SELECT 1 FROM Tamu WHERE nik = @nik AND id_tamu <> @id_tamu)
            THROW 50021, 'NIK sudah digunakan tamu lain.', 1;
        IF @gender NOT IN ('Laki-laki','Perempuan')
            THROW 50022, 'Gender tidak valid.', 1;

        UPDATE Tamu
        SET nik = @nik, nama = @nama, email = @email,
            no_hp = @no_hp, gender = @gender, alamat = @alamat
        WHERE id_tamu = @id_tamu;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_DeleteTamu
    @id_tamu INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Tamu WHERE id_tamu = @id_tamu)
            THROW 50030, 'Data tamu tidak ditemukan.', 1;
        IF EXISTS (SELECT 1 FROM Reservasi WHERE id_tamu = @id_tamu)
            THROW 50031, 'Tamu memiliki riwayat reservasi, tidak dapat dihapus.', 1;

        DELETE FROM Tamu WHERE id_tamu = @id_tamu;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

-- ─────────────────────────────────────────────────────────
-- CRUD Tipe Kamar
-- ─────────────────────────────────────────────────────────
CREATE OR ALTER PROCEDURE sp_GetAllTipeKamar
AS
BEGIN
    SET NOCOUNT ON;
    SELECT id_tipe, nama_tipe, harga, ISNULL(deskripsi,'-') AS deskripsi
    FROM TipeKamar ORDER BY nama_tipe;
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertTipeKamar
    @nama_tipe NVARCHAR(50),
    @harga     DECIMAL(12,2),
    @deskripsi NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF LTRIM(RTRIM(ISNULL(@nama_tipe,''))) = ''
            THROW 50040, 'Nama tipe tidak boleh kosong.', 1;
        IF @harga <= 0
            THROW 50041, 'Harga harus lebih dari 0.', 1;
        IF EXISTS (SELECT 1 FROM TipeKamar WHERE nama_tipe = @nama_tipe)
            THROW 50042, 'Nama tipe kamar sudah ada.', 1;

        INSERT INTO TipeKamar (nama_tipe, harga, deskripsi)
        VALUES (@nama_tipe, @harga, @deskripsi);
        SELECT SCOPE_IDENTITY() AS id_tipe;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_UpdateTipeKamar
    @id_tipe   INT,
    @nama_tipe NVARCHAR(50),
    @harga     DECIMAL(12,2),
    @deskripsi NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM TipeKamar WHERE id_tipe = @id_tipe)
            THROW 50050, 'Tipe kamar tidak ditemukan.', 1;
        IF @harga <= 0
            THROW 50051, 'Harga harus lebih dari 0.', 1;
        IF EXISTS (SELECT 1 FROM TipeKamar WHERE nama_tipe = @nama_tipe AND id_tipe <> @id_tipe)
            THROW 50052, 'Nama tipe sudah digunakan.', 1;

        UPDATE TipeKamar SET nama_tipe = @nama_tipe, harga = @harga, deskripsi = @deskripsi
        WHERE id_tipe = @id_tipe;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_DeleteTipeKamar
    @id_tipe INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM TipeKamar WHERE id_tipe = @id_tipe)
            THROW 50060, 'Tipe kamar tidak ditemukan.', 1;
        IF EXISTS (SELECT 1 FROM Kamar WHERE id_tipe = @id_tipe)
            THROW 50061, 'Tipe masih digunakan kamar, tidak dapat dihapus.', 1;

        DELETE FROM TipeKamar WHERE id_tipe = @id_tipe;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

-- ─────────────────────────────────────────────────────────
-- CRUD Kamar
-- ─────────────────────────────────────────────────────────
CREATE OR ALTER PROCEDURE sp_GetAllKamar
AS
BEGIN
    SET NOCOUNT ON;
    SELECT k.id_kamar, k.id_tipe, tk.nama_tipe,
           k.nomor_kamar, k.status, tk.harga
    FROM Kamar k JOIN TipeKamar tk ON k.id_tipe = tk.id_tipe
    ORDER BY k.nomor_kamar;
END;
GO

CREATE OR ALTER PROCEDURE sp_GetKamarTersedia
AS
BEGIN
    SET NOCOUNT ON;
    SELECT k.id_kamar, k.nomor_kamar, tk.nama_tipe, tk.harga
    FROM Kamar k JOIN TipeKamar tk ON k.id_tipe = tk.id_tipe
    WHERE k.status = 'Tersedia'
    ORDER BY k.nomor_kamar;
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertKamar
    @id_tipe     INT,
    @nomor_kamar NVARCHAR(10),
    @status      NVARCHAR(20) = 'Tersedia'
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM TipeKamar WHERE id_tipe = @id_tipe)
            THROW 50070, 'Tipe kamar tidak ditemukan.', 1;
        IF EXISTS (SELECT 1 FROM Kamar WHERE nomor_kamar = @nomor_kamar)
            THROW 50071, 'Nomor kamar sudah ada.', 1;
        IF @status NOT IN ('Tersedia','Terisi','Maintenance')
            THROW 50072, 'Status kamar tidak valid.', 1;

        INSERT INTO Kamar (id_tipe, nomor_kamar, status)
        VALUES (@id_tipe, @nomor_kamar, @status);
        SELECT SCOPE_IDENTITY() AS id_kamar;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_UpdateKamar
    @id_kamar    INT,
    @id_tipe     INT,
    @nomor_kamar NVARCHAR(10),
    @status      NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Kamar WHERE id_kamar = @id_kamar)
            THROW 50080, 'Kamar tidak ditemukan.', 1;
        IF EXISTS (SELECT 1 FROM Kamar WHERE nomor_kamar = @nomor_kamar AND id_kamar <> @id_kamar)
            THROW 50081, 'Nomor kamar sudah digunakan.', 1;
        IF @status NOT IN ('Tersedia','Terisi','Maintenance')
            THROW 50082, 'Status tidak valid.', 1;

        UPDATE Kamar SET id_tipe = @id_tipe, nomor_kamar = @nomor_kamar, status = @status
        WHERE id_kamar = @id_kamar;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_DeleteKamar
    @id_kamar INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Kamar WHERE id_kamar = @id_kamar)
            THROW 50090, 'Kamar tidak ditemukan.', 1;
        IF EXISTS (
            SELECT 1 FROM DetailReservasi dr
            JOIN Reservasi r ON dr.id_reservasi = r.id_reservasi
            WHERE dr.id_kamar = @id_kamar AND r.status IN ('Confirmed','Checked-In')
        )
            THROW 50091, 'Kamar sedang aktif digunakan.', 1;

        DELETE FROM Kamar WHERE id_kamar = @id_kamar;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

-- ─────────────────────────────────────────────────────────
-- CRUD Properti
-- ─────────────────────────────────────────────────────────
CREATE OR ALTER PROCEDURE sp_GetAllProperti
AS
BEGIN
    SET NOCOUNT ON;
    SELECT p.id_properti, p.nama_properti, p.biaya_denda,
           COUNT(pk.id_detail) AS jumlah_assign
    FROM   Properti p
    LEFT JOIN PropertiKamar pk ON p.id_properti = pk.id_properti
    GROUP BY p.id_properti, p.nama_properti, p.biaya_denda
    ORDER BY p.nama_properti;
END;
GO

CREATE OR ALTER PROCEDURE sp_GetPropertiByKamar
    @id_kamar INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Kamar WHERE id_kamar = @id_kamar)
            THROW 50100, 'Kamar tidak ditemukan.', 1;

        SELECT pk.id_detail, p.id_properti, p.nama_properti,
               p.biaya_denda, pk.kondisi,
               FORMAT(pk.updated_at,'dd/MM/yyyy HH:mm') AS terakhir_update
        FROM   PropertiKamar pk
        JOIN   Properti p ON pk.id_properti = p.id_properti
        WHERE  pk.id_kamar = @id_kamar
        ORDER  BY p.nama_properti;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertProperti
    @nama_properti NVARCHAR(100),
    @biaya_denda   DECIMAL(12,2)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF LTRIM(RTRIM(ISNULL(@nama_properti,''))) = ''
            THROW 50110, 'Nama properti tidak boleh kosong.', 1;
        IF @biaya_denda < 0
            THROW 50111, 'Biaya denda tidak boleh negatif.', 1;
        IF EXISTS (SELECT 1 FROM Properti WHERE nama_properti = @nama_properti)
            THROW 50112, 'Nama properti sudah ada.', 1;

        INSERT INTO Properti (nama_properti, biaya_denda) VALUES (@nama_properti, @biaya_denda);
        SELECT SCOPE_IDENTITY() AS id_properti;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_UpdateProperti
    @id_properti   INT,
    @nama_properti NVARCHAR(100),
    @biaya_denda   DECIMAL(12,2)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Properti WHERE id_properti = @id_properti)
            THROW 50120, 'Properti tidak ditemukan.', 1;
        IF @biaya_denda < 0
            THROW 50121, 'Biaya denda tidak boleh negatif.', 1;
        IF EXISTS (SELECT 1 FROM Properti WHERE nama_properti = @nama_properti AND id_properti <> @id_properti)
            THROW 50122, 'Nama properti sudah digunakan.', 1;

        UPDATE Properti SET nama_properti = @nama_properti, biaya_denda = @biaya_denda
        WHERE id_properti = @id_properti;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_DeleteProperti
    @id_properti INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Properti WHERE id_properti = @id_properti)
            THROW 50130, 'Properti tidak ditemukan.', 1;
        IF EXISTS (SELECT 1 FROM PropertiKamar WHERE id_properti = @id_properti)
            THROW 50131, 'Properti masih ter-assign ke kamar. Unassign dulu.', 1;

        DELETE FROM Properti WHERE id_properti = @id_properti;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

-- ─────────────────────────────────────────────────────────
-- Assign / Unassign / Adjust Kondisi
-- ─────────────────────────────────────────────────────────
CREATE OR ALTER PROCEDURE sp_AssignPropertiKamar
    @id_properti INT,
    @id_kamar    INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Properti WHERE id_properti = @id_properti)
            THROW 50140, 'Properti tidak ditemukan.', 1;
        IF NOT EXISTS (SELECT 1 FROM Kamar WHERE id_kamar = @id_kamar)
            THROW 50141, 'Kamar tidak ditemukan.', 1;
        IF EXISTS (SELECT 1 FROM PropertiKamar WHERE id_properti = @id_properti AND id_kamar = @id_kamar)
            THROW 50142, 'Properti sudah ter-assign ke kamar ini.', 1;

        INSERT INTO PropertiKamar (id_properti, id_kamar, kondisi)
        VALUES (@id_properti, @id_kamar, 'Baik');
        SELECT SCOPE_IDENTITY() AS id_detail;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_UnassignPropertiKamar
    @id_properti INT,
    @id_kamar    INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM PropertiKamar WHERE id_properti = @id_properti AND id_kamar = @id_kamar)
            THROW 50150, 'Assignment tidak ditemukan.', 1;

        DELETE FROM PropertiKamar WHERE id_properti = @id_properti AND id_kamar = @id_kamar;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_UpdateKondisiProperti
    @id_properti INT,
    @id_kamar    INT,
    @kondisi     NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF @kondisi NOT IN ('Baik','Rusak','Dalam Perbaikan')
            THROW 50160, 'Kondisi tidak valid.', 1;
        IF NOT EXISTS (SELECT 1 FROM PropertiKamar WHERE id_properti = @id_properti AND id_kamar = @id_kamar)
            THROW 50161, 'Assignment tidak ditemukan.', 1;

        UPDATE PropertiKamar
        SET kondisi = @kondisi, updated_at = GETDATE()
        WHERE id_properti = @id_properti AND id_kamar = @id_kamar;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

-- ─────────────────────────────────────────────────────────
-- Reservasi
-- ─────────────────────────────────────────────────────────
CREATE OR ALTER PROCEDURE sp_GetAllReservasi
    @filter NVARCHAR(100) = NULL,
    @status NVARCHAR(20)  = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT r.id_reservasi, t.nik, t.nama AS nama_tamu, ISNULL(t.no_hp,'-') AS no_hp,
           k.id_kamar, k.nomor_kamar, tk.nama_tipe, dr.harga_kamar,
           r.tipe_reservasi, r.tanggal_reservasi,
           r.tanggal_checkin, r.tanggal_checkout, r.status
    FROM   Reservasi r
    JOIN   Tamu t   ON r.id_tamu = t.id_tamu
    JOIN   DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
    JOIN   Kamar k  ON dr.id_kamar = k.id_kamar
    JOIN   TipeKamar tk ON k.id_tipe = tk.id_tipe
    WHERE  (@filter IS NULL OR @filter = ''
         OR t.nama        LIKE '%' + @filter + '%'
         OR k.nomor_kamar LIKE '%' + @filter + '%'
         OR t.nik         LIKE @filter + '%')
      AND  (@status IS NULL OR @status = '' OR r.status = @status)
    ORDER  BY r.tanggal_reservasi DESC, r.id_reservasi DESC;
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertReservasi
    @id_tamu        INT,
    @id_kamar       INT,
    @tipe_reservasi NVARCHAR(30),
    @tgl_reservasi  DATE,
    @tgl_checkin    DATE,
    @tgl_checkout   DATE,
    @status         NVARCHAR(20) = 'Pending'
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        IF NOT EXISTS (SELECT 1 FROM Tamu WHERE id_tamu = @id_tamu)
            THROW 50170, 'Tamu tidak ditemukan.', 1;
        IF NOT EXISTS (SELECT 1 FROM Kamar WHERE id_kamar = @id_kamar)
            THROW 50171, 'Kamar tidak ditemukan.', 1;
        IF NOT EXISTS (SELECT 1 FROM Kamar WHERE id_kamar = @id_kamar AND status = 'Tersedia')
            THROW 50172, 'Kamar tidak tersedia (status bukan Tersedia).', 1;
        IF @tgl_checkout <= @tgl_checkin
            THROW 50173, 'Tanggal checkout harus setelah checkin.', 1;
        IF @tipe_reservasi NOT IN ('Walk-in (Langsung)','Online / Contact')
            THROW 50174, 'Tipe reservasi tidak valid.', 1;
        IF @status NOT IN ('Pending','Confirmed')
            THROW 50175, 'Status awal hanya boleh Pending atau Confirmed.', 1;

        -- Cek overlap
        IF EXISTS (
            SELECT 1 FROM DetailReservasi dr
            JOIN Reservasi r ON dr.id_reservasi = r.id_reservasi
            WHERE dr.id_kamar = @id_kamar
              AND r.status IN ('Confirmed','Checked-In','Pending')
              AND @tgl_checkin  < r.tanggal_checkout
              AND @tgl_checkout > r.tanggal_checkin
        )
            THROW 50176, 'Kamar sudah dipesan pada periode tersebut.', 1;

        DECLARE @harga DECIMAL(12,2);
        SELECT @harga = tk.harga
        FROM Kamar k JOIN TipeKamar tk ON k.id_tipe = tk.id_tipe
        WHERE k.id_kamar = @id_kamar;

        INSERT INTO Reservasi (id_tamu, tipe_reservasi, tanggal_reservasi,
                               tanggal_checkin, tanggal_checkout, status)
        VALUES (@id_tamu, @tipe_reservasi, @tgl_reservasi,
                @tgl_checkin, @tgl_checkout, @status);

        DECLARE @id_reservasi INT = SCOPE_IDENTITY();

        INSERT INTO DetailReservasi (id_reservasi, id_kamar, harga_kamar)
        VALUES (@id_reservasi, @id_kamar, @harga);

        UPDATE Kamar SET status = 'Terisi' WHERE id_kamar = @id_kamar;

        COMMIT TRANSACTION;
        SELECT @id_reservasi AS id_reservasi;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_UpdateReservasi
    @id_reservasi   INT,
    @id_tamu        INT,
    @id_kamar       INT,
    @tipe_reservasi NVARCHAR(30),
    @tgl_reservasi  DATE,
    @tgl_checkin    DATE,
    @tgl_checkout   DATE,
    @status         NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @currentStatus NVARCHAR(20);
        DECLARE @currentKamar  INT;
        SELECT @currentStatus = r.status, @currentKamar = dr.id_kamar
        FROM Reservasi r JOIN DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
        WHERE r.id_reservasi = @id_reservasi;

        IF @currentStatus IS NULL
            THROW 50180, 'Reservasi tidak ditemukan.', 1;
        IF @currentStatus IN ('Checked-In','Checked-Out')
            THROW 50181, 'Reservasi yang sudah diproses tidak dapat diedit.', 1;
        IF @tgl_checkout <= @tgl_checkin
            THROW 50182, 'Tanggal checkout harus setelah checkin.', 1;

        -- Bebaskan kamar lama jika kamar diganti
        IF @id_kamar <> @currentKamar
        BEGIN
            UPDATE Kamar SET status = 'Tersedia' WHERE id_kamar = @currentKamar;

            IF NOT EXISTS (SELECT 1 FROM Kamar WHERE id_kamar = @id_kamar AND status = 'Tersedia')
                THROW 50183, 'Kamar baru tidak tersedia.', 1;

            DECLARE @hargaBaru DECIMAL(12,2);
            SELECT @hargaBaru = tk.harga
            FROM Kamar k JOIN TipeKamar tk ON k.id_tipe = tk.id_tipe
            WHERE k.id_kamar = @id_kamar;

            UPDATE DetailReservasi SET id_kamar = @id_kamar, harga_kamar = @hargaBaru
            WHERE id_reservasi = @id_reservasi;

            UPDATE Kamar SET status = 'Terisi' WHERE id_kamar = @id_kamar;
        END

        UPDATE Reservasi
        SET id_tamu = @id_tamu, tipe_reservasi = @tipe_reservasi,
            tanggal_reservasi = @tgl_reservasi, tanggal_checkin = @tgl_checkin,
            tanggal_checkout = @tgl_checkout, status = @status
        WHERE id_reservasi = @id_reservasi;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_UpdateStatusReservasi
    @id_reservasi INT,
    @status       NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Reservasi WHERE id_reservasi = @id_reservasi)
            THROW 50190, 'Reservasi tidak ditemukan.', 1;
        IF @status NOT IN ('Pending','Confirmed','Checked-In','Checked-Out','Cancelled')
            THROW 50191, 'Status tidak valid.', 1;

        UPDATE Reservasi SET status = @status WHERE id_reservasi = @id_reservasi;

        IF @status IN ('Checked-Out','Cancelled')
            UPDATE Kamar SET status = 'Tersedia'
            WHERE id_kamar IN (SELECT id_kamar FROM DetailReservasi WHERE id_reservasi = @id_reservasi);
        ELSE IF @status = 'Checked-In'
            UPDATE Kamar SET status = 'Terisi'
            WHERE id_kamar IN (SELECT id_kamar FROM DetailReservasi WHERE id_reservasi = @id_reservasi);
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_DeleteReservasi
    @id_reservasi INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @status NVARCHAR(20);
        SELECT @status = status FROM Reservasi WHERE id_reservasi = @id_reservasi;

        IF @status IS NULL
            THROW 50200, 'Reservasi tidak ditemukan.', 1;
        IF @status IN ('Checked-In','Checked-Out')
            THROW 50201, 'Reservasi yang sudah diproses tidak dapat dihapus.', 1;

        UPDATE Kamar SET status = 'Tersedia'
        WHERE id_kamar IN (SELECT id_kamar FROM DetailReservasi WHERE id_reservasi = @id_reservasi);

        DELETE FROM DetailReservasi WHERE id_reservasi = @id_reservasi;
        DELETE FROM Reservasi       WHERE id_reservasi = @id_reservasi;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- ─────────────────────────────────────────────────────────
-- Check-In
-- ─────────────────────────────────────────────────────────
CREATE OR ALTER PROCEDURE sp_ProsesCheckIn
    @id_reservasi INT,
    @tgl_checkin  DATE,
    @tgl_checkout DATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        DECLARE @currentStatus NVARCHAR(20);

        SELECT @currentStatus = status
        FROM   Reservasi
        WHERE  id_reservasi = @id_reservasi;

        IF @currentStatus IS NULL
            THROW 50210, 'Reservasi tidak ditemukan.', 1;

        -- Tidak pakai string concatenation di THROW
        IF @currentStatus NOT IN ('Pending', 'Confirmed')
            THROW 50211, 'Status reservasi tidak memungkinkan untuk check-in. Pastikan status Pending atau Confirmed.', 1;

        IF @tgl_checkout <= @tgl_checkin
            THROW 50212, 'Tanggal checkout harus setelah tanggal checkin.', 1;

        UPDATE Reservasi
        SET status           = 'Checked-In',
            tanggal_checkin  = @tgl_checkin,
            tanggal_checkout = @tgl_checkout
        WHERE id_reservasi = @id_reservasi;

        UPDATE Kamar
        SET    status = 'Terisi'
        WHERE  id_kamar IN (
            SELECT id_kamar FROM DetailReservasi WHERE id_reservasi = @id_reservasi
        );
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

-- ─────────────────────────────────────────────────────────
-- Check-Out & Transaksi
-- ─────────────────────────────────────────────────────────
CREATE OR ALTER PROCEDURE sp_ProsesCheckOut
    @id_reservasi        INT,
    @id_user             INT,
    @tgl_checkout_aktual DATE,
    @metode_pembayaran   NVARCHAR(30),
    @denda_kerusakan     DECIMAL(12,2) = 0,
    @persen_denda        INT           = 50,
    @id_transaksi        INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @status      NVARCHAR(20);
        DECLARE @tgl_ci      DATE;
        DECLARE @tgl_co_plan DATE;
        DECLARE @harga       DECIMAL(12,2);
        DECLARE @id_kamar    INT;

        SELECT @status      = r.status,
               @tgl_ci      = r.tanggal_checkin,
               @tgl_co_plan = r.tanggal_checkout,
               @harga       = dr.harga_kamar,
               @id_kamar    = dr.id_kamar
        FROM Reservasi r
        JOIN DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
        WHERE r.id_reservasi = @id_reservasi;

        IF @status IS NULL
            THROW 50220, 'Reservasi tidak ditemukan.', 1;
        IF @status <> 'Checked-In'
            THROW 50221, 'Reservasi belum dalam status Checked-In.', 1;
        IF @metode_pembayaran NOT IN ('Tunai','Kartu Debit','Kartu Kredit','Transfer Bank','QRIS')
            THROW 50222, 'Metode pembayaran tidak valid.', 1;
        IF @persen_denda < 1 OR @persen_denda > 100
            THROW 50223, 'Persentase denda harus antara 1 dan 100.', 1;

        DECLARE @malam        INT          = DATEDIFF(DAY, @tgl_ci, @tgl_checkout_aktual);
        DECLARE @biaya_kamar  DECIMAL(12,2) = @malam * @harga;
        DECLARE @denda_telat  DECIMAL(12,2) = 0;

        IF @tgl_checkout_aktual > @tgl_co_plan
        BEGIN
            DECLARE @hari_telat INT = DATEDIFF(DAY, @tgl_co_plan, @tgl_checkout_aktual);
            SET @denda_telat = @hari_telat * (@harga * @persen_denda / 100.0);
        END

        DECLARE @total DECIMAL(12,2) = @biaya_kamar + @denda_telat + @denda_kerusakan;

        INSERT INTO Transaksi (id_reservasi, id_user, total_bayar,
                               denda_telat, denda_kerusakan,
                               metode_pembayaran, tanggal_transaksi)
        VALUES (@id_reservasi, @id_user, @total,
                @denda_telat, @denda_kerusakan,
                @metode_pembayaran, GETDATE());

        SET @id_transaksi = SCOPE_IDENTITY();

        UPDATE Reservasi
        SET status           = 'Checked-Out',
            tanggal_checkout = @tgl_checkout_aktual
        WHERE id_reservasi = @id_reservasi;

        UPDATE Kamar SET status = 'Tersedia' WHERE id_kamar = @id_kamar;

        COMMIT TRANSACTION;

        SELECT @id_transaksi  AS id_transaksi,
               @biaya_kamar   AS biaya_kamar,
               @denda_telat   AS denda_telat,
               @denda_kerusakan AS denda_kerusakan,
               @total          AS total_bayar;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertDendaKerusakan
    @id_transaksi INT,
    @id_properti  INT,
    @id_kamar     INT,
    @biaya_denda  DECIMAL(12,2),
    @catatan      NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Transaksi WHERE id_transaksi = @id_transaksi)
            THROW 50230, 'Transaksi tidak ditemukan.', 1;
        IF NOT EXISTS (SELECT 1 FROM Properti WHERE id_properti = @id_properti)
            THROW 50231, 'Properti tidak ditemukan.', 1;
        IF @biaya_denda < 0
            THROW 50232, 'Biaya denda tidak boleh negatif.', 1;

        INSERT INTO DendaKerusakan (id_transaksi, id_properti, id_kamar, biaya_denda, catatan)
        VALUES (@id_transaksi, @id_properti, @id_kamar, @biaya_denda, @catatan);

        -- Otomatis update kondisi properti jadi Rusak
        UPDATE PropertiKamar
        SET kondisi = 'Rusak', updated_at = GETDATE()
        WHERE id_properti = @id_properti AND id_kamar = @id_kamar;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

-- ─────────────────────────────────────────────────────────
-- SP Laporan — menggunakan Views
-- ─────────────────────────────────────────────────────────
CREATE OR ALTER PROCEDURE sp_LaporanReservasi
    @tgl_dari   DATE,
    @tgl_sampai DATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF @tgl_sampai < @tgl_dari
            THROW 50400, 'Tanggal sampai tidak boleh sebelum tanggal dari.', 1;

        SELECT * FROM vw_LaporanReservasi
        WHERE CONVERT(DATE, [Tgl Reservasi], 103) BETWEEN @tgl_dari AND @tgl_sampai
        ORDER BY [Tgl Reservasi] DESC;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_LaporanCheckInCheckOut
    @tgl_dari   DATE,
    @tgl_sampai DATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF @tgl_sampai < @tgl_dari
            THROW 50401, 'Tanggal tidak valid.', 1;

        SELECT * FROM vw_LaporanCheckInCheckOut
        WHERE CONVERT(DATE, [Check-In], 103) BETWEEN @tgl_dari AND @tgl_sampai
        ORDER BY [Check-In] DESC;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_LaporanPendapatan
    @tgl_dari   DATE,
    @tgl_sampai DATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF @tgl_sampai < @tgl_dari
            THROW 50402, 'Tanggal tidak valid.', 1;

        SELECT * FROM vw_LaporanPendapatan
        WHERE CONVERT(DATE, [Tgl Transaksi], 103) BETWEEN @tgl_dari AND @tgl_sampai
        ORDER BY [Tgl Transaksi] DESC;

        -- Ringkasan
        SELECT
            COUNT(*)                                           AS [Jumlah Transaksi],
            FORMAT(SUM(CAST(REPLACE([Biaya Kamar],'.','') AS DECIMAL(12,2))), 'N0') AS [Total Biaya Kamar],
            FORMAT(SUM(CAST(REPLACE([Denda Telat],'.','') AS DECIMAL(12,2))), 'N0') AS [Total Denda Telat],
            FORMAT(SUM(CAST(REPLACE([Denda Kerusakan],'.','') AS DECIMAL(12,2))), 'N0') AS [Total Denda Kerusakan],
            FORMAT(SUM(CAST(REPLACE([Total Bayar],'.','') AS DECIMAL(12,2))), 'N0') AS [Grand Total]
        FROM vw_LaporanPendapatan
        WHERE CONVERT(DATE, [Tgl Transaksi], 103) BETWEEN @tgl_dari AND @tgl_sampai;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_LaporanDenda
    @tgl_dari   DATE,
    @tgl_sampai DATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF @tgl_sampai < @tgl_dari
            THROW 50403, 'Tanggal tidak valid.', 1;

        SELECT * FROM vw_LaporanDenda
        WHERE CONVERT(DATE, [Tgl Transaksi], 103) BETWEEN @tgl_dari AND @tgl_sampai
        ORDER BY [Tgl Transaksi] DESC;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_LaporanTamu
    @tgl_dari   DATE = NULL,
    @tgl_sampai DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_LaporanTamu
    ORDER BY [Total Menginap] DESC, [Nama Tamu];
END;
GO

CREATE OR ALTER PROCEDURE sp_LaporanKamar
    @tgl_dari   DATE = NULL,
    @tgl_sampai DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_LaporanKamar
    ORDER BY [Total Pendapatan] DESC, [No. Kamar];
END;
GO

-- ─────────────────────────────────────────────────────────
-- SP Utilitas DBA
-- ─────────────────────────────────────────────────────────

-- Rekap dashboard (summary angka untuk status bar / info)
CREATE OR ALTER PROCEDURE sp_GetDashboardSummary
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        (SELECT COUNT(*) FROM Tamu)                                        AS total_tamu,
        (SELECT COUNT(*) FROM Kamar)                                       AS total_kamar,
        (SELECT COUNT(*) FROM Kamar WHERE status = 'Tersedia')             AS kamar_tersedia,
        (SELECT COUNT(*) FROM Kamar WHERE status = 'Terisi')               AS kamar_terisi,
        (SELECT COUNT(*) FROM Kamar WHERE status = 'Maintenance')          AS kamar_maintenance,
        (SELECT COUNT(*) FROM Reservasi WHERE status = 'Pending')          AS reservasi_pending,
        (SELECT COUNT(*) FROM Reservasi WHERE status = 'Confirmed')        AS reservasi_confirmed,
        (SELECT COUNT(*) FROM Reservasi WHERE status = 'Checked-In')       AS tamu_checkin,
        (SELECT ISNULL(SUM(total_bayar),0)
         FROM Transaksi
         WHERE MONTH(tanggal_transaksi) = MONTH(GETDATE())
           AND YEAR(tanggal_transaksi)  = YEAR(GETDATE()))                 AS pendapatan_bulan_ini,
        (SELECT COUNT(*)
         FROM PropertiKamar WHERE kondisi = 'Rusak')                       AS properti_rusak;
END;
GO

-- Cek kamar yang jatuh tempo checkout hari ini
CREATE OR ALTER PROCEDURE sp_GetCheckoutHariIni
AS
BEGIN
    SET NOCOUNT ON;
    SELECT r.id_reservasi, t.nama AS nama_tamu, t.no_hp,
           k.nomor_kamar, r.tanggal_checkin, r.tanggal_checkout,
           DATEDIFF(DAY, r.tanggal_checkin, r.tanggal_checkout) AS durasi_malam
    FROM Reservasi r
    JOIN Tamu t             ON r.id_tamu = t.id_tamu
    JOIN DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
    JOIN Kamar k            ON dr.id_kamar = k.id_kamar
    WHERE r.status = 'Checked-In'
      AND r.tanggal_checkout = CAST(GETDATE() AS DATE)
    ORDER BY r.tanggal_checkout;
END;
GO

-- Cek kamar yang sudah melewati tanggal checkout (overstay)
CREATE OR ALTER PROCEDURE sp_GetOverstay
AS
BEGIN
    SET NOCOUNT ON;
    SELECT r.id_reservasi, t.nama AS nama_tamu, t.no_hp,
           k.nomor_kamar,
           r.tanggal_checkin,
           r.tanggal_checkout AS checkout_rencana,
           CAST(GETDATE() AS DATE) AS hari_ini,
           DATEDIFF(DAY, r.tanggal_checkout, CAST(GETDATE() AS DATE)) AS hari_overstay
    FROM Reservasi r
    JOIN Tamu t             ON r.id_tamu = t.id_tamu
    JOIN DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
    JOIN Kamar k            ON dr.id_kamar = k.id_kamar
    WHERE r.status = 'Checked-In'
      AND r.tanggal_checkout < CAST(GETDATE() AS DATE)
    ORDER BY hari_overstay DESC;
END;
GO

-- Histori transaksi tamu tertentu
CREATE OR ALTER PROCEDURE sp_GetHistoriTamu
    @id_tamu INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Tamu WHERE id_tamu = @id_tamu)
            THROW 50500, 'Tamu tidak ditemukan.', 1;

        SELECT r.id_reservasi, k.nomor_kamar, tk.nama_tipe,
               FORMAT(r.tanggal_checkin,  'dd/MM/yyyy') AS checkin,
               FORMAT(r.tanggal_checkout, 'dd/MM/yyyy') AS checkout,
               DATEDIFF(DAY, r.tanggal_checkin, r.tanggal_checkout) AS durasi,
               r.status,
               ISNULL(FORMAT(tr.total_bayar,'N0'), '-') AS total_bayar,
               ISNULL(tr.metode_pembayaran, '-')         AS metode
        FROM Reservasi r
        JOIN DetailReservasi dr ON dr.id_reservasi = r.id_reservasi
        JOIN Kamar k            ON dr.id_kamar = k.id_kamar
        JOIN TipeKamar tk       ON k.id_tipe = tk.id_tipe
        LEFT JOIN Transaksi tr  ON tr.id_reservasi = r.id_reservasi
        WHERE r.id_tamu = @id_tamu
        ORDER BY r.tanggal_checkin DESC;
    END TRY
    BEGIN CATCH THROW; END CATCH
END;
GO

-- ══════════════════════════════════════════════════════════
-- SEED DATA
-- ══════════════════════════════════════════════════════════

INSERT INTO [User] (nama, email, password, role) VALUES
    ('Administrator',    'admin@hotel.com',   'admin123', 'Admin'),
    ('Resepsionis Satu', 'resep01@hotel.com', 'resep123', 'Resepsionis');

INSERT INTO TipeKamar (nama_tipe, harga, deskripsi) VALUES
    ('Standard',  350000, 'Kamar standar dengan fasilitas dasar'),
    ('Deluxe',    600000, 'Kamar deluxe dengan pemandangan taman'),
    ('Suite',    1200000, 'Kamar suite mewah dengan ruang tamu');

INSERT INTO Kamar (id_tipe, nomor_kamar) VALUES
    (1,'101'),(1,'102'),(1,'103'),
    (2,'201'),(2,'202'),
    (3,'301');

INSERT INTO Properti (nama_properti, biaya_denda) VALUES
    ('TV 32 Inch',     500000), ('AC Split 1 PK',  750000),
    ('Remote AC',       50000), ('Lemari Pakaian', 300000),
    ('Cermin Dinding', 150000), ('Meja Kerja',     200000),
    ('Kursi',           75000), ('Kasur',          800000),
    ('Bantal (2 pcs)', 100000), ('Shower',         400000),
    ('Kloset',         600000), ('Handuk (2 pcs)',  60000);

INSERT INTO Tamu (nik, nama, email, no_hp, gender, alamat) VALUES
    ('3578012345678901','Budi Santoso', 'budi@email.com','08123456789','Laki-laki','Jl. Merdeka No.1, Jakarta'),
    ('3578019876543210','Siti Rahayu',  'siti@email.com','08234567890','Perempuan','Jl. Sudirman No.5, Bandung'),
    ('3578011122334455','Agus Prasetyo','agus@email.com','08345678901','Laki-laki','Jl. Gatot Subroto, Surabaya'),
    ('3578015566778899','Dewi Lestari', 'dewi@email.com','08456789012','Perempuan','Jl. Ahmad Yani, Medan');

-- Assign semua properti ke semua kamar dengan kondisi Baik
INSERT INTO PropertiKamar (id_properti, id_kamar)
SELECT p.id_properti, k.id_kamar
FROM Properti p CROSS JOIN Kamar k;
GO

-- ══════════════════════════════════════════════════════════
-- VERIFIKASI
-- ══════════════════════════════════════════════════════════
EXEC sp_GetDashboardSummary;
EXEC sp_GetAllKamar;
EXEC sp_GetAllProperti;
SELECT * FROM vw_DataKamar;
SELECT * FROM vw_DataTamu;
SELECT * FROM vw_PropertiKamar;
GO