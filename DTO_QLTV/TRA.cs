namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRA")]
    public partial class TRA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaTra { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MaTaiLieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }

        public int? SoNgayQuaHan { get; set; }

        [StringLength(8)]
        public string idNguoiDung { get; set; }

        [StringLength(8)]
        public string MaThe { get; set; }

        public virtual HOSODOCGIA HOSODOCGIA { get; set; }

        public virtual TAILIEU TAILIEU { get; set; }
    }
}
