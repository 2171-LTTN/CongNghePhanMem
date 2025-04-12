namespace ProjectCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            ChiTietMuonTras = new HashSet<ChiTietMuonTra>();
        }

        [Key]
        public int maSach { get; set; }

        [StringLength(200)]
        public string tenSach { get; set; }

        [StringLength(100)]
        public string tacGia { get; set; }

        [StringLength(100)]
        public string nhaXuatBan { get; set; }

        public int? namXuatBan { get; set; }

        public int? soLuong { get; set; }

        public int? maDanhMuc { get; set; }

        public int? maTheLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietMuonTra> ChiTietMuonTras { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }

        public virtual TheLoai TheLoai { get; set; }
    }
}
