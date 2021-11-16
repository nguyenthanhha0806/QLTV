namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_THANHLYTAILIEU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaThanhLy { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MaTaiLieu { get; set; }

        public int? DonGia { get; set; }

        [StringLength(50)]
        public string NoiThanhLy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThanhLy { get; set; }

        public virtual TAILIEU TAILIEU { get; set; }

        public virtual THANHLYTAILIEU THANHLYTAILIEU { get; set; }
    }
}
