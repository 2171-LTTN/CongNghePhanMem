namespace ProjectCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheThuVien")]
    public partial class TheThuVien
    {
        [Key]
        public int maThe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayCap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayHetHan { get; set; }

        public int? maDocGia { get; set; }

        public virtual DocGia DocGia { get; set; }
    }
}
