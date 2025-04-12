using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProjectCNPM.Models
{
    public partial class DBconnect : DbContext
    {
        public DBconnect()
            : base("name=DBconnect")
        {
        }

        public virtual DbSet<ChiTietMuonTra> ChiTietMuonTras { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<LichSuDangNhap> LichSuDangNhaps { get; set; }
        public virtual DbSet<LichSuHoatDong> LichSuHoatDongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phieu_GiaHanSach> Phieu_GiaHanSach { get; set; }
        public virtual DbSet<Phieu_MuonTraSach> Phieu_MuonTraSach { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<ThuVien> ThuViens { get; set; }
        public virtual DbSet<VaiTro> VaiTroes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietMuonTra>()
                .Property(e => e.maMuonTra)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietMuonTra>()
                .Property(e => e.maSach)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietMuonTra>()
                .Property(e => e.tinhTrangSach)
                .IsUnicode(false);

            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.maDanhMuc)
                .IsUnicode(false);

            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.tenDanhMuc)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.maDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.tenDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.diaChi)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.soDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuDangNhap>()
                .Property(e => e.maLichSu)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuDangNhap>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuDangNhap>()
                .Property(e => e.diaChiIP)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuHoatDong>()
                .Property(e => e.maHoatDong)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuHoatDong>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuHoatDong>()
                .Property(e => e.hanhDong)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuHoatDong>()
                .Property(e => e.doiTuong)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuHoatDong>()
                .Property(e => e.maDoiTuong)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuHoatDong>()
                .Property(e => e.ghiChu)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.maNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.tenNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.chucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.soDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_GiaHanSach>()
                .Property(e => e.maGiaHan)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_GiaHanSach>()
                .Property(e => e.trangThai)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_GiaHanSach>()
                .Property(e => e.maNV)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_GiaHanSach>()
                .Property(e => e.maMuonTra)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_MuonTraSach>()
                .Property(e => e.maMuonTra)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_MuonTraSach>()
                .Property(e => e.tinhTrang)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_MuonTraSach>()
                .Property(e => e.maDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_MuonTraSach>()
                .Property(e => e.maNV)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_MuonTraSach>()
                .HasMany(e => e.ChiTietMuonTras)
                .WithRequired(e => e.Phieu_MuonTraSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.maSach)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.tenSach)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.tacGia)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.nhaXuatBan)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.namXuatBan)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.maDanhMuc)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.maTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.ChiTietMuonTras)
                .WithRequired(e => e.Sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.maVaiTro)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.maDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.maNV)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.maTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.tenTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<ThuVien>()
                .Property(e => e.maThe)
                .IsUnicode(false);

            modelBuilder.Entity<ThuVien>()
                .Property(e => e.maDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<VaiTro>()
                .Property(e => e.maVaiTro)
                .IsUnicode(false);

            modelBuilder.Entity<VaiTro>()
                .Property(e => e.tenVaiTro)
                .IsUnicode(false);
        }
    }
}
