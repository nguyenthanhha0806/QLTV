namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SD_PHONGDOC
    {
        [Key]
        [StringLength(8)]
        public string MaSD { get; set; }

        public DateTime? ThoiGianVao { get; set; }

        public DateTime? ThoiGianRa { get; set; }

        [StringLength(8)]
        public string MaThe { get; set; }

        public virtual HOSODOCGIA HOSODOCGIA { get; set; }
    }
}
