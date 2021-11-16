namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANG")]
    public partial class DONHANG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaDauTaiLieu { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MaDonHang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaylap { get; set; }

        [StringLength(50)]
        public string Nguoilap { get; set; }

        [StringLength(20)]
        public string TinhTrang { get; set; }

        public int? Soluong { get; set; }

        [StringLength(50)]
        public string Ghichu { get; set; }

        [StringLength(8)]
        public string MaNCC { get; set; }

        public virtual DAUTAILIEU DAUTAILIEU { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
