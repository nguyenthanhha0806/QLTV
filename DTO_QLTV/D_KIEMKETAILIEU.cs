namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_KIEMKETAILIEU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaBaoCao { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MaDauTaiLieu { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string MaTaiLieu { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public virtual BAOCAOKIEMKE BAOCAOKIEMKE { get; set; }

        public virtual TAILIEU TAILIEU { get; set; }
    }
}
