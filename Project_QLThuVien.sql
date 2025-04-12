use master;
go
CREATE DATABASE Project_QLThuVien;
go
USE Project_QLThuVien;

-- Bảng VaiTro
CREATE TABLE VaiTro (
    maVaiTro VARCHAR(50) PRIMARY KEY,
    tenVaiTro VARCHAR(100)
);

-- Bảng DocGia
CREATE TABLE DocGia (
    maDocGia VARCHAR(50) PRIMARY KEY,
    tenDocGia VARCHAR(100),
    ngaySinh DATE,
    diaChi VARCHAR(255),
    soDienThoai VARCHAR(20)
);

-- Bảng NhanVien
CREATE TABLE NhanVien (
    maNV VARCHAR(50) PRIMARY KEY,
    tenNV VARCHAR(100),
    chucVu VARCHAR(100),
    soDienThoai VARCHAR(20)
);

-- Bảng TaiKhoan
CREATE TABLE TaiKhoan (
    username VARCHAR(50) PRIMARY KEY,
    password VARCHAR(100),
    maVaiTro VARCHAR(50),
    maDocGia VARCHAR(50),
    maNV VARCHAR(50),
    FOREIGN KEY (maVaiTro) REFERENCES VaiTro(maVaiTro),
    FOREIGN KEY (maDocGia) REFERENCES DocGia(maDocGia),
    FOREIGN KEY (maNV) REFERENCES NhanVien(maNV)
);

-- Bảng LichSuDangNhap
CREATE TABLE LichSuDangNhap (
    maLichSu VARCHAR(50) PRIMARY KEY,
    username VARCHAR(50),
    thoiGianDangNhap DATETIME,
    thoiGianDangXuat DATETIME,
    diaChiIP VARCHAR(50),
    FOREIGN KEY (username) REFERENCES TaiKhoan(username)
);

-- Bảng LichSuHoatDong
CREATE TABLE LichSuHoatDong (
    maHoatDong VARCHAR(50) PRIMARY KEY,
    username VARCHAR(50),
    thoiGian DATETIME,
    hanhDong VARCHAR(100),
    doiTuong VARCHAR(100),
    maDoiTuong VARCHAR(50),
    ghiChu TEXT,
    FOREIGN KEY (username) REFERENCES TaiKhoan(username)
);

-- Bảng ThuVien
CREATE TABLE ThuVien (
    maThe VARCHAR(50) PRIMARY KEY,
    ngayCap DATE,
    ngayHetHan DATE,
    maDocGia VARCHAR(50),
    FOREIGN KEY (maDocGia) REFERENCES DocGia(maDocGia)
);

-- Bảng DanhMuc
CREATE TABLE DanhMuc (
    maDanhMuc VARCHAR(50) PRIMARY KEY,
    tenDanhMuc VARCHAR(100)
);

-- Bảng TheLoai
CREATE TABLE TheLoai (
    maTheLoai VARCHAR(50) PRIMARY KEY,
    tenTheLoai VARCHAR(100)
);

-- Bảng Sach
CREATE TABLE Sach (
    maSach VARCHAR(50) PRIMARY KEY,
    tenSach VARCHAR(255),
    tacGia VARCHAR(100),
    nhaXuatBan VARCHAR(100),
    namXuatBan VARCHAR(4),
    soLuong INT,
    maDanhMuc VARCHAR(50),
    maTheLoai VARCHAR(50),
    FOREIGN KEY (maDanhMuc) REFERENCES DanhMuc(maDanhMuc),
    FOREIGN KEY (maTheLoai) REFERENCES TheLoai(maTheLoai)
);

-- Bảng Phieu_MuonTraSach
CREATE TABLE Phieu_MuonTraSach (
    maMuonTra VARCHAR(50) PRIMARY KEY,
    ngayMuon DATE,
    ngayTra DATE,
    tinhTrang VARCHAR(100),
    soLuong INT,
    maDocGia VARCHAR(50),
    maNV VARCHAR(50),
    FOREIGN KEY (maDocGia) REFERENCES DocGia(maDocGia),
    FOREIGN KEY (maNV) REFERENCES NhanVien(maNV)
);

-- Bảng ChiTietMuonTra
CREATE TABLE ChiTietMuonTra (
    maMuonTra VARCHAR(50),
    maSach VARCHAR(50),
    tinhTrangSach VARCHAR(100),
    PRIMARY KEY (maMuonTra, maSach),
    FOREIGN KEY (maMuonTra) REFERENCES Phieu_MuonTraSach(maMuonTra),
    FOREIGN KEY (maSach) REFERENCES Sach(maSach)
);

-- Bảng Phieu_GiaHanSach
CREATE TABLE Phieu_GiaHanSach (
    maGiaHan VARCHAR(50) PRIMARY KEY,
    ngayYeuCau DATE,
    trangThai VARCHAR(50),
    maNV VARCHAR(50),
    maMuonTra VARCHAR(50),
    FOREIGN KEY (maNV) REFERENCES NhanVien(maNV),
    FOREIGN KEY (maMuonTra) REFERENCES Phieu_MuonTraSach(maMuonTra)
);
