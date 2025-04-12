namespace ProjectCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            LichSuDangNhaps = new HashSet<LichSuDangNhap>();
            LichSuHoatDongs = new HashSet<LichSuHoatDong>();
        }

        [Key]
        [StringLength(20)]
        public string username { get; set; }

        [StringLength(30)]
        public string password { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(20)]
        public string maVaiTro { get; set; }

        public int? maDocGia { get; set; }

        public int? maNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuDangNhap> LichSuDangNhaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuHoatDong> LichSuHoatDongs { get; set; }

        public virtual VaiTro VaiTro { get; set; }
    }
}
