namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUON")]
    public partial class MUON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaMuon { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MaTaiLieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMuon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HanTra { get; set; }

        [StringLength(8)]
        public string idNguoiDung { get; set; }

        [StringLength(8)]
        public string MaThe { get; set; }

        public virtual HOSODOCGIA HOSODOCGIA { get; set; }

        public virtual TAILIEU TAILIEU { get; set; }
    }
}
