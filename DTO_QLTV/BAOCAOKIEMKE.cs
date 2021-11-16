namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAOCAOKIEMKE")]
    public partial class BAOCAOKIEMKE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAOCAOKIEMKE()
        {
            D_KIEMKETAILIEU = new HashSet<D_KIEMKETAILIEU>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaBaoCao { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MaDauTaiLieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaylap { get; set; }

        [StringLength(50)]
        public string NguoiLap { get; set; }

        public int? SoluongKho { get; set; }

        public int? SoLuongKT { get; set; }

        public int? SoLuongHong { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual DAUTAILIEU DAUTAILIEU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_KIEMKETAILIEU> D_KIEMKETAILIEU { get; set; }
    }
}
