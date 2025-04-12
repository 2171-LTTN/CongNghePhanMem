using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProjectCNPM.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
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
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<TheThuVien> TheThuViens { get; set; }
        public virtual DbSet<VaiTro> VaiTroes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocGia>()
                .Property(e => e.soDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuDangNhap>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuDangNhap>()
                .Property(e => e.diaChiIP)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuHoatDong>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuHoatDong>()
                .Property(e => e.maDoiTuong)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.soDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.maVaiTro)
                .IsUnicode(false);

            modelBuilder.Entity<VaiTro>()
                .Property(e => e.maVaiTro)
                .IsUnicode(false);
        }
    }
}
