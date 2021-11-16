namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUPHAT")]
    public partial class PHIEUPHAT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaPhieuPhat { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MaTaiLieu { get; set; }

        public bool? HongSach { get; set; }

        public bool? MatSach { get; set; }

        public bool? QuaHan { get; set; }

        public int? SoTrangHong { get; set; }

        [StringLength(8)]
        public string idNguoiDung { get; set; }

        public int? ThanhTien { get; set; }

        [StringLength(8)]
        public string MaThe { get; set; }

        public virtual HOSODOCGIA HOSODOCGIA { get; set; }

        public virtual TAILIEU TAILIEU { get; set; }
    }
}
