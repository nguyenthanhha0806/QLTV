namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHOMDOCGIA")]
    public partial class NHOMDOCGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHOMDOCGIA()
        {
            HOSODOCGIAs = new HashSet<HOSODOCGIA>();
        }

        [Key]
        [StringLength(10)]
        public string MaNDG { get; set; }

        [Column("Nhomdocgia")]
        [StringLength(20)]
        public string Nhomdocgia1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOSODOCGIA> HOSODOCGIAs { get; set; }
    }
}
