namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHMUC")]
    public partial class DANHMUC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaDanhMuc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MaDauTaiLieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        public int? DonGia { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [StringLength(8)]
        public string MaNCC { get; set; }

        public virtual DAUTAILIEU DAUTAILIEU { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
