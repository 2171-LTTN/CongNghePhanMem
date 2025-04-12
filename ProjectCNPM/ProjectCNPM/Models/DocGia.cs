namespace ProjectCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocGia")]
    public partial class DocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocGia()
        {
            Phieu_MuonTraSach = new HashSet<Phieu_MuonTraSach>();
            TheThuViens = new HashSet<TheThuVien>();
        }

        [Key]
        public int maDocGia { get; set; }

        [StringLength(100)]
        public string tenDocGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaySinh { get; set; }

        [StringLength(200)]
        public string diaChi { get; set; }

        [StringLength(20)]
        public string soDienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_MuonTraSach> Phieu_MuonTraSach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheThuVien> TheThuViens { get; set; }
    }
}
