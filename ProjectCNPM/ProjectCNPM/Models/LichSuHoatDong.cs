namespace ProjectCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuHoatDong")]
    public partial class LichSuHoatDong
    {
        [Key]
        public int maHoatDong { get; set; }

        [StringLength(20)]
        public string username { get; set; }

        public DateTime? thoiGian { get; set; }

        [StringLength(100)]
        public string hanhDong { get; set; }

        [StringLength(100)]
        public string doiTuong { get; set; }

        [StringLength(50)]
        public string maDoiTuong { get; set; }

        [StringLength(255)]
        public string ghiChu { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
