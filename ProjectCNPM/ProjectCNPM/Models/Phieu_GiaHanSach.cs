namespace ProjectCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phieu_GiaHanSach
    {
        [Key]
        [StringLength(50)]
        public string maGiaHan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayYeuCau { get; set; }

        [StringLength(50)]
        public string trangThai { get; set; }

        [StringLength(50)]
        public string maNV { get; set; }

        [StringLength(50)]
        public string maMuonTra { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual Phieu_MuonTraSach Phieu_MuonTraSach { get; set; }
    }
}
