namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAILIEU")]
    public partial class TAILIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAILIEU()
        {
            D_KIEMKETAILIEU = new HashSet<D_KIEMKETAILIEU>();
            D_SD_PHONGDOC = new HashSet<D_SD_PHONGDOC>();
            D_THANHLYTAILIEU = new HashSet<D_THANHLYTAILIEU>();
            MUONs = new HashSet<MUON>();
            PHIEUPHATs = new HashSet<PHIEUPHAT>();
            TRAs = new HashSet<TRA>();
        }

        [Key]
        [StringLength(8)]
        public string MaTaiLieu { get; set; }

        public int? DonGia { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [StringLength(20)]
        public string TinhTrang { get; set; }

        [StringLength(10)]
        public string MaVach { get; set; }

        [StringLength(8)]
        public string MaDauTaiLieu { get; set; }

        [StringLength(8)]
        public string MaHoaDon { get; set; }

        [StringLength(8)]
        public string MaViTri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_KIEMKETAILIEU> D_KIEMKETAILIEU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_SD_PHONGDOC> D_SD_PHONGDOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_THANHLYTAILIEU> D_THANHLYTAILIEU { get; set; }

        public virtual HOADON HOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUON> MUONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUPHAT> PHIEUPHATs { get; set; }

        public virtual VITRILUUTRU VITRILUUTRU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRA> TRAs { get; set; }
    }
}
