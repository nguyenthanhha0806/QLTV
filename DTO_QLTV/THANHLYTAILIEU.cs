namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THANHLYTAILIEU")]
    public partial class THANHLYTAILIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THANHLYTAILIEU()
        {
            D_THANHLYTAILIEU = new HashSet<D_THANHLYTAILIEU>();
        }

        [Key]
        [StringLength(8)]
        public string MaThanhLy { get; set; }

        [StringLength(50)]
        public string TenNhanVien { get; set; }

        public int? TongTien { get; set; }

        [StringLength(50)]
        public string NguoiXacnhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_THANHLYTAILIEU> D_THANHLYTAILIEU { get; set; }
    }
}
