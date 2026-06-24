CREATE DATABASE HasilPemeriksaanLabDB;
GO

USE LayananKesehatanDB;
GO

-- =========================================
-- TABEL ADMIN
-- =========================================

CREATE TABLE ADMIN (
    id_admin INT PRIMARY KEY IDENTITY(1,1),
    nama_admin VARCHAR(100),
    email VARCHAR(100) UNIQUE,
    password_admin VARCHAR(255)
);

-- =========================================
-- TABEL DOKTER
-- =========================================

CREATE TABLE DOKTER (
    id_dokter INT PRIMARY KEY IDENTITY(1,1),
    nama_dokter VARCHAR(100),
    spesialis VARCHAR(100),
    email VARCHAR(100) UNIQUE,
    password_dokter VARCHAR(255)
);

-- =========================================
-- TABEL PASIEN
-- =========================================

CREATE TABLE PASIEN (
    id_pasien INT PRIMARY KEY IDENTITY(1,1),
    nama_pasien VARCHAR(100),
    jenis_kelamin VARCHAR(10),
    tanggal_lahir DATE,
    alamat TEXT,
    no_telp VARCHAR(15),
    email VARCHAR(100) UNIQUE,
    password_pasien VARCHAR(255)
);

-- =========================================
-- TABEL AKUN LOGIN
-- =========================================

CREATE TABLE AKUN (
    id_akun INT PRIMARY KEY IDENTITY(1,1),

    username VARCHAR(100) UNIQUE,

    password_akun VARCHAR(255),

    role VARCHAR(20),

    id_user_asli INT
);

-- =========================================
-- TABEL PEMERIKSAAN LAB
-- =========================================

CREATE TABLE PEMERIKSAAN_LAB (
    id_periksa INT PRIMARY KEY IDENTITY(1,1),

    id_pasien INT,
    id_dokter INT,
    id_admin INT,

    tanggal_periksa DATETIME DEFAULT GETDATE(),

    jenis_tes VARCHAR(100),

    hasil_lab TEXT,

    nilai_normal VARCHAR(100),

    diagnosa TEXT,

    status_validasi VARCHAR(50)
    DEFAULT 'Pending',

    FOREIGN KEY (id_pasien)
    REFERENCES PASIEN(id_pasien),

    FOREIGN KEY (id_dokter)
    REFERENCES DOKTER(id_dokter),

    FOREIGN KEY (id_admin)
    REFERENCES ADMIN(id_admin)
);

-- =========================================
-- INSERT DATA ADMIN
-- =========================================

INSERT INTO ADMIN
(nama_admin,email,password_admin)
VALUES
(
'Administrator Lab',
'admin@lab.com',
'admin123'
);

-- =========================================
-- INSERT AKUN ADMIN
-- =========================================

INSERT INTO AKUN
(username,password_akun,role,id_user_asli)
VALUES
(
'admin',
'admin123',
'Admin',
1
);

-- =========================================
-- INSERT DATA DOKTER
-- =========================================

INSERT INTO DOKTER
(nama_dokter,spesialis,email,password_dokter)
VALUES
(
'Dr. Budi Santoso',
'Patologi Klinik',
'budi@lab.com',
'dokter123'
);

-- =========================================
-- INSERT AKUN DOKTER
-- =========================================

INSERT INTO AKUN
(username,password_akun,role,id_user_asli)
VALUES
(
'dokter1',
'dokter123',
'Dokter',
1
);

-- =========================================
-- INSERT DATA PASIEN
-- =========================================

INSERT INTO PASIEN
(
nama_pasien,
jenis_kelamin,
tanggal_lahir,
alamat,
no_telp,
email,
password_pasien
)
VALUES
(
'Rizki Zulfauzi',
'Laki-Laki',
'2005-10-10',
'Bantul',
'08123456789',
'rizki@gmail.com',
'pasien123'
);

-- =========================================
-- INSERT AKUN PASIEN
-- =========================================

INSERT INTO AKUN
(username,password_akun,role,id_user_asli)
VALUES
(
'rizki',
'pasien123',
'Pasien',
1
);

-- =========================================
-- INSERT PEMERIKSAAN LAB
-- =========================================

INSERT INTO PEMERIKSAAN_LAB
(
id_pasien,
id_dokter,
id_admin,
jenis_tes,
hasil_lab,
nilai_normal,
diagnosa,
status_validasi
)
VALUES
(
1,
1,
1,
'Kolesterol',
'250 mg/dL',
'< 200 mg/dL',
'Kolesterol Tinggi',
'Sudah Validasi'
);

-- =========================================
-- MENAMPILKAN DATA PASIEN
-- =========================================

SELECT * FROM PASIEN;

-- =========================================
-- MENAMPILKAN DATA DOKTER
-- =========================================

SELECT * FROM DOKTER;

-- =========================================
-- MENAMPILKAN DATA AKUN
-- =========================================

SELECT * FROM AKUN;

-- =========================================
-- MENAMPILKAN HASIL PEMERIKSAAN LAB
-- =========================================

SELECT
    p.nama_pasien,
    d.nama_dokter,
    pl.tanggal_periksa,
    pl.jenis_tes,
    pl.hasil_lab,
    pl.nilai_normal,
    pl.diagnosa,
    pl.status_validasi

FROM PEMERIKSAAN_LAB pl

JOIN PASIEN p
ON pl.id_pasien = p.id_pasien

JOIN DOKTER d
ON pl.id_dokter = d.id_dokter;

-- =========================================
-- QUERY LOGIN
-- =========================================

SELECT *
FROM AKUN
WHERE username = 'admin'
AND password_akun = 'admin123';


DROP TABLE PEMERIKSAAN_LAB

CREATE TABLE PEMERIKSAAN_LAB (
    id_periksa INT PRIMARY KEY IDENTITY(1,1),
    id_pasien INT,
    jenis_tes VARCHAR(100),
    hasil_lab VARCHAR(255),
    nilai_normal VARCHAR(100),
    diagnosa VARCHAR(255)
)

ALTER TABLE PEMERIKSAAN_LAB
ADD CONSTRAINT FK_PASIEN
FOREIGN KEY (id_pasien)
REFERENCES PASIEN(id_pasien);

ALTER TABLE PEMERIKSAAN_LAB
ADD id_dokter INT;

ALTER TABLE PEMERIKSAAN_LAB
ADD CONSTRAINT FK_DOKTER
FOREIGN KEY (id_dokter)
REFERENCES DOKTER(id_dokter);

ALTER TABLE PEMERIKSAAN_LAB
ADD id_admin INT;

ALTER TABLE PEMERIKSAAN_LAB
ADD CONSTRAINT FK_ADMIN
FOREIGN KEY (id_admin)
REFERENCES ADMIN(id_admin);

CREATE VIEW vwPemeriksaanPublic
AS
SELECT
    id_periksa,
    id_pasien,
    jenis_tes,
    hasil_lab,
    diagnosa
FROM PEMERIKSAAN_LAB

SELECT * FROM vwPemeriksaanPublic
SELECT * FROM PEMERIKSAAN_LAB

SELECT *
INTO PEMERIKSAAN_LAB_BACKUP
FROM PEMERIKSAAN_LAB


CREATE PROCEDURE sp_tampil_pemeriksaan_lab
AS
BEGIN
    SELECT * FROM PEMERIKSAAN_LAB
END

CREATE PROCEDURE sp_cari_pemeriksaan_lab
    @id_periksa INT
AS
BEGIN
    SELECT * 
    FROM PEMERIKSAAN_LAB
    WHERE id_periksa = @id_periksa
END

CREATE PROCEDURE sp_tambah_pemeriksaan_lab
    @id_pasien INT,
    @jenis_tes VARCHAR(100),
    @hasil_lab VARCHAR(255),
    @nilai_normal VARCHAR(100),
    @diagnosa VARCHAR(255)
AS
BEGIN
    INSERT INTO PEMERIKSAAN_LAB
    (
        id_pasien,
        jenis_tes,
        hasil_lab,
        nilai_normal,
        diagnosa
    )
    VALUES
    (
        @id_pasien,
        @jenis_tes,
        @hasil_lab,
        @nilai_normal,
        @diagnosa
    )
END

CREATE PROCEDURE sp_update_pemeriksaan_lab
    @id_periksa INT,
    @id_pasien INT,
    @jenis_tes VARCHAR(100),
    @hasil_lab VARCHAR(255),
    @nilai_normal VARCHAR(100),
    @diagnosa VARCHAR(255)
AS
BEGIN
    UPDATE PEMERIKSAAN_LAB
    SET
        id_pasien = @id_pasien,
        jenis_tes = @jenis_tes,
        hasil_lab = @hasil_lab,
        nilai_normal = @nilai_normal,
        diagnosa = @diagnosa
    WHERE id_periksa = @id_periksa
END

CREATE PROCEDURE sp_hapus_pemeriksaan_lab
    @id_periksa INT
AS
BEGIN
    DELETE FROM PEMERIKSAAN_LAB
    WHERE id_periksa = @id_periksa
END

CREATE PROCEDURE sp_count_pemeriksaan_lab
    @total INT OUTPUT
AS
BEGIN
    SELECT @total = COUNT(*)
    FROM PEMERIKSAAN_LAB
END


CREATE PROCEDURE sp_tampil_pasien
AS
BEGIN
    SELECT * FROM PASIEN
END

ALTER PROCEDURE sp_tambah_pasien
    @nama_pasien VARCHAR(100),
    @jenis_kelamin VARCHAR(20),
    @tanggal_lahir DATE,
    @alamat VARCHAR(255),
    @no_telp VARCHAR(20),
    @email VARCHAR(100),
    @password_pasien VARCHAR(100)
AS
BEGIN

    INSERT INTO PASIEN
    (
        nama_pasien,
        jenis_kelamin,
        tanggal_lahir,
        alamat,
        no_telp,
        email,
        password_pasien
    )
    VALUES
    (
        @nama_pasien,
        @jenis_kelamin,
        @tanggal_lahir,
        @alamat,
        @no_telp,
        @email,
        @password_pasien
    )

    DECLARE @idPasien INT

    SET @idPasien = SCOPE_IDENTITY()

    INSERT INTO AKUN
    (
        username,
        password_akun,
        role,
        id_user_asli
    )
    VALUES
    (
        @email,
        @password_pasien,
        'Pasien',
        @idPasien
    )

END

CREATE PROCEDURE sp_update_pasien
    @id_pasien INT,
    @nama_pasien VARCHAR(100),
    @jenis_kelamin VARCHAR(20),
    @tanggal_lahir DATE,
    @alamat VARCHAR(255),
    @no_telp VARCHAR(20),
    @email VARCHAR(100),
    @password_pasien VARCHAR(100)
AS
BEGIN
    UPDATE PASIEN
    SET
        nama_pasien = @nama_pasien,
        jenis_kelamin = @jenis_kelamin,
        tanggal_lahir = @tanggal_lahir,
        alamat = @alamat,
        no_telp = @no_telp,
        email = @email,
        password_pasien = @password_pasien
    WHERE id_pasien = @id_pasien
END

CREATE PROCEDURE sp_hapus_pasien
    @id_pasien INT
AS
BEGIN
    DELETE FROM PASIEN
    WHERE id_pasien = @id_pasien
END

CREATE PROCEDURE sp_count_pasien
    @total INT OUTPUT
AS
BEGIN
    SELECT @total = COUNT(*)
    FROM PASIEN
END

CREATE PROCEDURE sp_InsertDokter
    @nama NVARCHAR(100),
    @spesialis NVARCHAR(100),
    @email NVARCHAR(100),
    @password NVARCHAR(100)
AS
BEGIN
    INSERT INTO DOKTER
    (
        nama_dokter,
        spesialis,
        email,
        password_dokter
    )
    VALUES
    (
        @nama,
        @spesialis,
        @email,
        @password
    )

    -- Ambil ID dokter terakhir
    DECLARE @idDokter INT
    SET @idDokter = SCOPE_IDENTITY()

    -- Insert ke tabel akun
    INSERT INTO AKUN
    (
        username,
        password_akun,
        role,
        id_user_asli
    )
    VALUES
    (
        @email,
        @password,
        'Dokter',
        @idDokter
    )
END

CREATE PROCEDURE sp_UpdateDokter
    @id INT,
    @nama NVARCHAR(100),
    @spesialis NVARCHAR(100),
    @email NVARCHAR(100),
    @password NVARCHAR(100)
AS
BEGIN
    UPDATE DOKTER
    SET
        nama_dokter = @nama,
        spesialis = @spesialis,
        email = @email,
        password_dokter = @password
    WHERE id_dokter = @id

    -- Update tabel akun juga
    UPDATE AKUN
    SET
        username = @email,
        password_akun = @password
    WHERE id_user_asli = @id
    AND role = 'Dokter'
END

CREATE PROCEDURE sp_DeleteDokter
    @id INT
AS
BEGIN
    -- Hapus akun dulu
    DELETE FROM AKUN
    WHERE id_user_asli = @id
    AND role = 'Dokter'

    -- Hapus dokter
    DELETE FROM DOKTER
    WHERE id_dokter = @id
END

CREATE PROCEDURE sp_TampilDokter
AS
BEGIN
    SELECT * FROM DOKTER
END

CREATE PROCEDURE sp_TampilPemeriksaanLab
AS
BEGIN
    SELECT * FROM PEMERIKSAAN_LAB
END

CREATE PROCEDURE sp_TampilAdmin
AS
BEGIN
    SELECT * FROM ADMIN
END

CREATE PROCEDURE sp_InsertPemeriksaanLab
    @pasien INT,
    @dokter INT,
    @admin INT,
    @jenis NVARCHAR(100),
    @hasil NVARCHAR(100),
    @normal NVARCHAR(100),
    @diagnosa NVARCHAR(255)
AS
BEGIN
    INSERT INTO PEMERIKSAAN_LAB
    (
        id_pasien,
        id_dokter,
        id_admin,
        jenis_tes,
        hasil_lab,
        nilai_normal,
        diagnosa
    )
    VALUES
    (
        @pasien,
        @dokter,
        @admin,
        @jenis,
        @hasil,
        @normal,
        @diagnosa
    )
END

CREATE PROCEDURE sp_UpdatePemeriksaanLab
    @id INT,
    @pasien INT,
    @dokter INT,
    @admin INT,
    @jenis NVARCHAR(100),
    @hasil NVARCHAR(100),
    @normal NVARCHAR(100),
    @diagnosa NVARCHAR(255)
AS
BEGIN
    UPDATE PEMERIKSAAN_LAB
    SET
        id_pasien = @pasien,
        id_dokter = @dokter,
        id_admin = @admin,
        jenis_tes = @jenis,
        hasil_lab = @hasil,
        nilai_normal = @normal,
        diagnosa = @diagnosa
    WHERE id_periksa = @id
END

CREATE PROCEDURE sp_DeletePemeriksaanLab
    @id INT
AS
BEGIN
    DELETE FROM PEMERIKSAAN_LAB
    WHERE id_periksa = @id
END

SELECT * INTO PASIEN_BACKUP
FROM PASIEN

DROP TABLE PEMERIKSAAN_LAB_BACKUP

SELECT *
INTO PEMERIKSAAN_LAB_BACKUP
FROM PEMERIKSAAN_LAB
SELECT * FROM PEMERIKSAAN_LAB
SET IDENTITY_INSERT PEMERIKSAAN_LAB_BACKUP ON

INSERT INTO PEMERIKSAAN_LAB_BACKUP
(
    id_periksa,
    id_pasien,
    jenis_tes,
    hasil_lab,
    nilai_normal,
    diagnosa,
    id_dokter,
    id_admin
)
SELECT
    id_periksa,
    id_pasien,
    jenis_tes,
    hasil_lab,
    nilai_normal,
    diagnosa,
    id_dokter,
    id_admin
FROM PEMERIKSAAN_LAB

SET IDENTITY_INSERT PEMERIKSAAN_LAB_BACKUP OFF

SELECT * FROM PEMERIKSAAN_LAB_BACKUP
INSERT INTO PEMERIKSAAN_LAB
(
    id_pasien,
    jenis_tes,
    hasil_lab,
    nilai_normal,
    diagnosa,
    id_dokter,
    id_admin
)
VALUES
(
    1,
    'Kolesterol',
    '250 mg/dL',
    '< 200 mg/dL',
    'Kolesterol Tinggi',
    1,
    1
)

SELECT * FROM PEMERIKSAAN_LAB
DELETE FROM PEMERIKSAAN_LAB_BACKUP
SET IDENTITY_INSERT PEMERIKSAAN_LAB_BACKUP ON

INSERT INTO PEMERIKSAAN_LAB_BACKUP
(
    id_periksa,
    id_pasien,
    jenis_tes,
    hasil_lab,
    nilai_normal,
    diagnosa,
    id_dokter,
    id_admin
)
SELECT
    id_periksa,
    id_pasien,
    jenis_tes,
    hasil_lab,
    nilai_normal,
    diagnosa,
    id_dokter,
    id_admin
FROM PEMERIKSAAN_LAB

SET IDENTITY_INSERT PEMERIKSAAN_LAB_BACKUP OFF
SELECT * FROM PEMERIKSAAN_LAB_BACKUP

INSERT INTO PASIEN
(
    nama_pasien,
    jenis_kelamin,
    tanggal_lahir,
    alamat,
    no_telp,
    email,
    password_pasien
)
VALUES
(
    'Rizki Zulfauzi',
    'Laki-Laki',
    '2005-10-10',
    'Bantul',
    '08123456789',
    'rizki@gmail.com',
    'pasien123'
)

SELECT * FROM PASIEN
UPDATE PASIEN
SET nama_pasien = 'Rizki Zulfauzi'
WHERE email = 'rizki@gmail.com'

DELETE FROM PASIEN_BACKUP

SET IDENTITY_INSERT PASIEN_BACKUP ON

INSERT INTO PASIEN_BACKUP
(
    id_pasien,
    nama_pasien,
    jenis_kelamin,
    tanggal_lahir,
    alamat,
    no_telp,
    email,
    password_pasien
)
SELECT
    id_pasien,
    nama_pasien,
    jenis_kelamin,
    tanggal_lahir,
    alamat,
    no_telp,
    email,
    password_pasien
FROM PASIEN

SET IDENTITY_INSERT PASIEN_BACKUP OFF

SELECT * FROM AKUN

DELETE FROM PEMERIKSAAN_LAB
WHERE id_pasien = 9

DELETE FROM AKUN
WHERE id_user_asli = 9
AND role = 'Pasien'

DELETE FROM PASIEN
WHERE id_pasien = 9


CREATE OR ALTER PROCEDURE sp_ReportHasilLab
    @id_pasien INT
AS
BEGIN
    SELECT
        p.nama_pasien,
        pl.jenis_tes,
        pl.hasil_lab,
        pl.nilai_normal,
        pl.diagnosa
    FROM PEMERIKSAAN_LAB pl
    INNER JOIN PASIEN p
        ON pl.id_pasien = p.id_pasien
    WHERE p.id_pasien = @id_pasien
END