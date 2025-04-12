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
        public int id { get; set; }

        public int? maMuonTra { get; set; }

        public int? maSach { get; set; }

        [StringLength(50)]
        public string tinhTrangSach { get; set; }

        public virtual Phieu_MuonTraSach Phieu_MuonTraSach { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
