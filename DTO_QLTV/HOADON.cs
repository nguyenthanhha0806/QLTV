namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            TAILIEUx = new HashSet<TAILIEU>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaHoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MaDauTaiLieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [StringLength(50)]
        public string NguoiLap { get; set; }

        public int? Dongia { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [StringLength(8)]
        public string MaNCC { get; set; }

        [StringLength(8)]
        public string MaDonHang { get; set; }

        public virtual DAUTAILIEU DAUTAILIEU { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAILIEU> TAILIEUx { get; set; }
    }
}
