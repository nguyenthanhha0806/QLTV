namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TACGIA")]
    public partial class TACGIA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaTacGia { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MaDauTaiLieu { get; set; }

        [StringLength(50)]
        public string TenTacGia { get; set; }

        public virtual DAUTAILIEU DAUTAILIEU { get; set; }
    }
}
