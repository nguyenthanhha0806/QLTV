namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MAYTINH")]
    public partial class MAYTINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAYTINH()
        {
            D_SD_INTERNET = new HashSet<D_SD_INTERNET>();
        }

        [Key]
        [StringLength(8)]
        public string MaMayTinh { get; set; }

        [StringLength(50)]
        public string LoaiMayTinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_SD_INTERNET> D_SD_INTERNET { get; set; }
    }
}
