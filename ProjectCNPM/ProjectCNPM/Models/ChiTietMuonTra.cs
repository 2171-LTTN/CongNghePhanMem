namespace ProjectCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietMuonTra")]
    public partial class ChiTietMuonTra
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string maMuonTra { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string maSach { get; set; }

        [StringLength(100)]
        public string tinhTrangSach { get; set; }

        public virtual Phieu_MuonTraSach Phieu_MuonTraSach { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
