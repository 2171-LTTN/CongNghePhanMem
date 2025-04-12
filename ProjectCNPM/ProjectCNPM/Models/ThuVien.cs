namespace ProjectCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThuVien")]
    public partial class ThuVien
    {
        [Key]
        [StringLength(50)]
        public string maThe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayCap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayHetHan { get; set; }

        [StringLength(50)]
        public string maDocGia { get; set; }

        public virtual DocGia DocGia { get; set; }
    }
}
