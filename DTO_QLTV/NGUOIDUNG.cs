namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOIDUNG")]
    public partial class NGUOIDUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOIDUNG()
        {
            LICHSUTRUYCAPs = new HashSet<LICHSUTRUYCAP>();
        }

        [Key]
        [StringLength(8)]
        public string idNguoidung { get; set; }

        [StringLength(50)]
        public string Tennguoidung { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [StringLength(20)]
        public string TenDN { get; set; }

        [StringLength(32)]
        public string Matkhau { get; set; }

        [StringLength(50)]
        public string Chucvu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHSUTRUYCAP> LICHSUTRUYCAPs { get; set; }
    }
}
