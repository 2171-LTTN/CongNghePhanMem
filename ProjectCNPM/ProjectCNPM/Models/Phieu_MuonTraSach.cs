namespace ProjectCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phieu_MuonTraSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieu_MuonTraSach()
        {
            ChiTietMuonTras = new HashSet<ChiTietMuonTra>();
            Phieu_GiaHanSach = new HashSet<Phieu_GiaHanSach>();
        }

        [Key]
        public int maMuonTra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayMuon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayTra { get; set; }

        [StringLength(50)]
        public string tinhTrang { get; set; }

        public int? soLuong { get; set; }

        public int? maDocGia { get; set; }

        public int? maNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietMuonTra> ChiTietMuonTras { get; set; }

        public virtual DocGia DocGia { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_GiaHanSach> Phieu_GiaHanSach { get; set; }
    }
}
