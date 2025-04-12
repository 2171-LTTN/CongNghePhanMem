namespace ProjectCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            Phieu_GiaHanSach = new HashSet<Phieu_GiaHanSach>();
            Phieu_MuonTraSach = new HashSet<Phieu_MuonTraSach>();
        }

        [Key]
        public int maNV { get; set; }

        [StringLength(100)]
        public string tenNV { get; set; }

        [StringLength(50)]
        public string chucVu { get; set; }

        [StringLength(20)]
        public string soDienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_GiaHanSach> Phieu_GiaHanSach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_MuonTraSach> Phieu_MuonTraSach { get; set; }
    }
}
