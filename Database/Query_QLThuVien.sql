Create database DB_QuanLyThuVien
Use DB_QuanLyThuVien
GO


-- Bang VaiTro
CREATE TABLE VaiTro (
    maVaiTro VARCHAR(20) PRIMARY KEY,
    tenVaiTro NVARCHAR(100)
);

-- Bang TaiKhoan
CREATE TABLE TaiKhoan (
    username VARCHAR(20) PRIMARY KEY,
    password VARCHAR(30),
	email VARCHAR(50),
    maVaiTro VARCHAR(20),
    maDocGia INT,
    maNV INT,
    FOREIGN KEY (maVaiTro) REFERENCES VaiTro(maVaiTro)
);

-- Bang DocGia
CREATE TABLE DocGia (
    maDocGia INT IDENTITY(1,1) PRIMARY KEY,
    tenDocGia NVARCHAR(100),
    ngaySinh DATE,
    diaChi NVARCHAR(200),
    soDienThoai VARCHAR(20)
);

-- Bang NhanVien
CREATE TABLE NhanVien (
    maNV INT IDENTITY(1,1) PRIMARY KEY,
    tenNV NVARCHAR(100),
    chucVu NVARCHAR(50),
    soDienThoai VARCHAR(20)
);

-- Bang TheThuVien
CREATE TABLE TheThuVien (
    maThe INT IDENTITY(1,1) PRIMARY KEY,
    ngayCap DATE,
    ngayHetHan DATE,
    maDocGia INT,
    FOREIGN KEY (maDocGia) REFERENCES DocGia(maDocGia)
);

-- Bang DanhMuc
CREATE TABLE DanhMuc (
    maDanhMuc INT IDENTITY(1,1) PRIMARY KEY,
    tenDanhMuc NVARCHAR(100)
);

-- Bang TheLoai
CREATE TABLE TheLoai (
    maTheLoai INT IDENTITY(1,1) PRIMARY KEY,
    tenTheLoai NVARCHAR(100)
);

-- Bang Sach
CREATE TABLE Sach (
    maSach INT IDENTITY(1,1) PRIMARY KEY,
    tenSach NVARCHAR(200),
    tacGia NVARCHAR(100),
    nhaXuatBan NVARCHAR(100),
    namXuatBan INT,
    soLuong INT,
    maDanhMuc INT,
    maTheLoai INT,
    FOREIGN KEY (maDanhMuc) REFERENCES DanhMuc(maDanhMuc),
    FOREIGN KEY (maTheLoai) REFERENCES TheLoai(maTheLoai)
);

-- Bang Phieu_MuonTraSach
CREATE TABLE Phieu_MuonTraSach (
    maMuonTra INT IDENTITY(1,1) PRIMARY KEY,
    ngayMuon DATE,
    ngayTra DATE,
    tinhTrang NVARCHAR(50),
    soLuong INT,
    maDocGia INT,
    maNV INT,
    FOREIGN KEY (maDocGia) REFERENCES DocGia(maDocGia),
    FOREIGN KEY (maNV) REFERENCES NhanVien(maNV)
);

-- Bang ChiTietMuonTra
CREATE TABLE ChiTietMuonTra (
    id INT IDENTITY(1,1) PRIMARY KEY,
    maMuonTra INT,
    maSach INT,
    tinhTrangSach NVARCHAR(50),
    FOREIGN KEY (maMuonTra) REFERENCES Phieu_MuonTraSach(maMuonTra),
    FOREIGN KEY (maSach) REFERENCES Sach(maSach)
);

-- Bang Phieu_GiaHanSach
CREATE TABLE Phieu_GiaHanSach (
    maGiaHan INT IDENTITY(1,1) PRIMARY KEY,
    ngayYeuCau DATE,
    trangThai NVARCHAR(50),
    maNV INT,
    maMuonTra INT,
    FOREIGN KEY (maNV) REFERENCES NhanVien(maNV),
    FOREIGN KEY (maMuonTra) REFERENCES Phieu_MuonTraSach(maMuonTra)
);

-- Bang LichSuDangNhap
CREATE TABLE LichSuDangNhap (
    maLichSu INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(20),
    thoiGianDangNhap DATETIME,
    thoiGianDangXuat DATETIME,
    diaChiIP VARCHAR(50),
    FOREIGN KEY (username) REFERENCES TaiKhoan(username)
);

-- Bang LichSuHoatDong
CREATE TABLE LichSuHoatDong (
    maHoatDong INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(20),
    thoiGian DATETIME,
    hanhDong NVARCHAR(100),
    doiTuong NVARCHAR(100),
    maDoiTuong VARCHAR(50),
    ghiChu NVARCHAR(255),
    FOREIGN KEY (username) REFERENCES TaiKhoan(username)
);

-- VaiTro
INSERT INTO VaiTro VALUES 
('admin', N'Quản trị viên'),
('thuthu', N'Thủ thư'),
('docgia', N'Độc giả'),
('quanly', N'Quản lý'),
('ktv', N'Kỹ thuật viên');

-- DocGia
INSERT INTO DocGia (tenDocGia, ngaySinh, diaChi, soDienThoai) VALUES
(N'Nguyễn Văn A', '2000-01-01', N'123 Lê Lợi', '0909123456'),
(N'Trần Thị B', '1999-05-20', N'456 Nguyễn Huệ', '0912345678'),
(N'Lê Văn C', '2001-03-15', N'789 Trần Hưng Đạo', '0987654321'),
(N'Phạm Thị D', '1998-07-30', N'12B CMT8', '0933333333'),
(N'Đỗ Văn E', '1995-11-10', N'5A Phạm Ngũ Lão', '0966666666');

-- NhanVien
INSERT INTO NhanVien (tenNV, chucVu, soDienThoai) VALUES
(N'Ngô Thị Mai', N'Thủ thư', '0911111111'),
(N'Võ Văn Khang', N'Quản lý', '0922222222'),
(N'Hoàng Thị Lệ', N'Kỹ thuật viên', '0933333333'),
(N'Phan Văn Tùng', N'Thủ thư', '0944444444'),
(N'Nguyễn Thị Hòa', N'Admin', '0955555555');

-- TaiKhoan
INSERT INTO TaiKhoan (username, password, email, maVaiTro, maDocGia, maNV) VALUES
('admin01', 'admin123', 'adcuimia@gmail.com', 'admin', NULL, 5),
('thuthu01', 'pass456', 'thuthu@gmail.com', 'thuthu', NULL, 1),
('docgia01', 'reader789', 'docgia1@gmail.com', 'docgia', 1, NULL),
('docgia02', 'reader101', 'docgia2@gmail.com', 'docgia', 2, NULL),
('quanly01', 'manager99', 'ql@gmail.com', 'quanly', NULL, 2);

-- TheThuVien
INSERT INTO TheThuVien (ngayCap, ngayHetHan, maDocGia) VALUES
('2024-01-01', '2025-01-01', 1),
('2024-02-15', '2025-02-15', 2),
('2024-03-10', '2025-03-10', 3),
('2024-04-05', '2025-04-05', 4),
('2024-05-20', '2025-05-20', 5);

-- DanhMuc
INSERT INTO DanhMuc (tenDanhMuc) VALUES
(N'Khoa học'),
(N'Tiểu thuyết'),
(N'Lịch sử'),
(N'Giáo trình'),
(N'Thiếu nhi');

-- TheLoai
INSERT INTO TheLoai (tenTheLoai) VALUES
(N'Truyện ngắn'),
(N'Kinh tế'),
(N'Công nghệ'),
(N'Tâm lý học'),
(N'Trinh thám');

-- Sach
INSERT INTO Sach (tenSach, tacGia, nhaXuatBan, namXuatBan, soLuong, maDanhMuc, maTheLoai) VALUES
(N'Sách Khoa Học 1', N'Tác giả A', N'NXB Trẻ', 2020, 10, 1, 2),
(N'Sách Kinh Tế 2', N'Tác giả B', N'NXB Tổng hợp', 2019, 5, 2, 2),
(N'Sách Công Nghệ 3', N'Tác giả C', N'NXB Giáo dục', 2021, 15, 1, 3),
(N'Sách Tâm Lý 4', N'Tác giả D', N'NXB Văn hóa', 2022, 7, 4, 4),
(N'Sách Thiếu Nhi 5', N'Tác giả E', N'NXB Kim Đồng', 2018, 20, 5, 5);

-- Phieu_MuonTraSach
INSERT INTO Phieu_MuonTraSach (ngayMuon, ngayTra, tinhTrang, soLuong, maDocGia, maNV) VALUES
('2024-04-01', '2024-04-10', N'Đang mượn', 2, 1, 1),
('2024-04-02', '2024-04-12', N'Đã trả', 1, 2, 2),
('2024-04-03', '2024-04-13', N'Đang mượn', 3, 3, 3),
('2024-04-04', '2024-04-14', N'Đã trả', 1, 4, 4),
('2024-04-05', '2024-04-15', N'Đang mượn', 2, 5, 5);

-- ChiTietMuonTra
INSERT INTO ChiTietMuonTra (maMuonTra, maSach, tinhTrangSach) VALUES
(1, 1, N'Tốt'),
(1, 2, N'Tốt'),
(2, 3, N'Tốt'),
(3, 4, N'Trầy nhẹ'),
(4, 5, N'Tốt');

-- Phieu_GiaHanSach
INSERT INTO Phieu_GiaHanSach (ngayYeuCau, trangThai, maNV, maMuonTra) VALUES
('2024-04-05', N'Chờ duyệt', 1, 1),
('2024-04-06', N'Đã duyệt', 2, 2),
('2024-04-07', N'Từ chối', 3, 3),
('2024-04-08', N'Chờ duyệt', 4, 4),
('2024-04-09', N'Đã duyệt', 5, 5);

-- LichSuDangNhap
INSERT INTO LichSuDangNhap (username, thoiGianDangNhap, thoiGianDangXuat, diaChiIP) VALUES
('admin01', '2024-04-10 08:00', '2024-04-10 09:00', '192.168.1.1'),
('thuthu01', '2024-04-10 08:15', '2024-04-10 09:05', '192.168.1.2'),
('docgia01', '2024-04-10 09:00', '2024-04-10 09:30', '192.168.1.3'),
('docgia02', '2024-04-10 09:10', '2024-04-10 09:45', '192.168.1.4'),
('quanly01', '2024-04-10 09:20', '2024-04-10 10:00', '192.168.1.5');

-- LichSuHoatDong
INSERT INTO LichSuHoatDong (username, thoiGian, hanhDong, doiTuong, maDoiTuong, ghiChu) VALUES
('admin01', '2024-04-10 08:30', N'Tạo tài khoản', N'Tài khoản', 'user01', NULL),
('thuthu01', '2024-04-10 08:45', N'Mượn sách', N'Sách', '1', N'Mượn 2 cuốn'),
('docgia01', '2024-04-10 09:15', N'Gia hạn', N'Phiếu mượn', '2', N'Yêu cầu gia hạn'),
('docgia02', '2024-04-10 09:25', N'Đăng nhập', N'Hệ thống', '', NULL),
('quanly01', '2024-04-10 09:50', N'Chỉnh sửa sách', N'Sách', '3', N'Cập nhật số lượng');

-- Lấy dữ liệu từ bảng VaiTro
SELECT * FROM VaiTro;

-- Lấy dữ liệu từ bảng NhanVien
SELECT * FROM NhanVien;

-- Lấy dữ liệu từ bảng DocGia
SELECT * FROM DocGia;

-- Lấy dữ liệu từ bảng TaiKhoan
SELECT * FROM TaiKhoan;

-- Lấy dữ liệu từ bảng TheThuVien
SELECT * FROM TheThuVien;

-- Lấy dữ liệu từ bảng DanhMuc
SELECT * FROM DanhMuc;

-- Lấy dữ liệu từ bảng TheLoai
SELECT * FROM TheLoai;

-- Lấy dữ liệu từ bảng Sach
SELECT * FROM Sach;

-- Lấy dữ liệu từ bảng Phieu_MuonTraSach
SELECT * FROM Phieu_MuonTraSach;

-- Lấy dữ liệu từ bảng ChiTietMuonTra
SELECT * FROM ChiTietMuonTra;

-- Lấy dữ liệu từ bảng Phieu_GiaHanSach
SELECT * FROM Phieu_GiaHanSach;

-- Lấy dữ liệu từ bảng LichSuDangNhap
SELECT * FROM LichSuDangNhap;

-- Lấy dữ liệu từ bảng LichSuHoatDong
SELECT * FROM LichSuHoatDong;