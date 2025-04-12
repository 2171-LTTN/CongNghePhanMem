namespace ProjectCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuDangNhap")]
    public partial class LichSuDangNhap
    {
        [Key]
        public int maLichSu { get; set; }

        [StringLength(20)]
        public string username { get; set; }

        public DateTime? thoiGianDangNhap { get; set; }

        public DateTime? thoiGianDangXuat { get; set; }

        [StringLength(50)]
        public string diaChiIP { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
