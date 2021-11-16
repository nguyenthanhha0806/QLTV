namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DAUTAILIEU")]
    public partial class DAUTAILIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAUTAILIEU()
        {
            BAOCAOKIEMKEs = new HashSet<BAOCAOKIEMKE>();
            DANHMUCs = new HashSet<DANHMUC>();
            DONHANGs = new HashSet<DONHANG>();
            HOADONs = new HashSet<HOADON>();
            NHAXUATBANs = new HashSet<NHAXUATBAN>();
            TACGIAs = new HashSet<TACGIA>();
        }

        [Key]
        [StringLength(8)]
        public string MaDauTaiLieu { get; set; }

        [StringLength(50)]
        public string TenTaiLieu { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public int? SoluongKho { get; set; }

        [StringLength(8)]
        public string KhoGiay { get; set; }

        public int? Sotrang { get; set; }

        [StringLength(20)]
        public string NgonNgu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOCAOKIEMKE> BAOCAOKIEMKEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHMUC> DANHMUCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAXUATBAN> NHAXUATBANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TACGIA> TACGIAs { get; set; }
    }
}
