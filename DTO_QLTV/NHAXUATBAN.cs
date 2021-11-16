namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHAXUATBAN")]
    public partial class NHAXUATBAN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaXB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MaDauTaiLieu { get; set; }

        [StringLength(50)]
        public string TenNXB { get; set; }

        public int? NamXB { get; set; }

        public virtual DAUTAILIEU DAUTAILIEU { get; set; }
    }
}
