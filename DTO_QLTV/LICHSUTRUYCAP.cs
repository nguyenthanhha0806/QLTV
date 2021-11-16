namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LICHSUTRUYCAP")]
    public partial class LICHSUTRUYCAP
    {
        [Key]
        [StringLength(8)]
        public string idLichSu { get; set; }

        [StringLength(50)]
        public string Thaotac { get; set; }

        public DateTime? Thoigian { get; set; }

        [StringLength(8)]
        public string idNguoiDung { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
    }
}
